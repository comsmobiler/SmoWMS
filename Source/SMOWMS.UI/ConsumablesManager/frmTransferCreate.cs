using System;
using System.Collections.Generic;
using Smobiler.Core.Controls;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.Domain.Entity;
using SMOWMS.UI.Layout;
using SMOWMS.CommLib;
using System.Data;
using SMOWMS.DTOs.Enum;
using SMOWMS.DTOs.OutputDTO;

namespace SMOWMS.UI.ConsumablesManager
{
    partial class frmTransferCreate : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public List<ConsumablesOrderRow> RowData = new List<ConsumablesOrderRow>();    //未开启SN行项
        public String CID;               //耗材编号
        #endregion
        /// <summary>
        /// 调入管理员选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDealInMan_Press(object sender, EventArgs e)
        {
            try
            {
                popDealInMan.Groups.Clear();       //数据清空
                PopListGroup poli = new PopListGroup();
                popDealInMan.Groups.Add(poli);
                poli.Title = "调入管理员选择";
                List<coreUser> users = autofacConfig.coreUserService.GetDealInAdmin();
                foreach (coreUser Row in users)
                {
                    poli.AddListItem(Row.USER_NAME, Row.USER_ID);
                }
                if (btnDealMan.Tag != null)   //如果已有选中项，则显示选中效果
                {
                    foreach (PopListItem Item in poli.Items)
                    {
                        if (Item.Value == btnDealMan.Tag.ToString())
                            popDealInMan.SetSelections(Item);
                    }
                }
                popDealInMan.ShowDialog();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 处理人选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDealMan_Press(object sender, EventArgs e)
        {
            try
            {
                popDealMan.Groups.Clear();       //数据清空
                PopListGroup poli = new PopListGroup();
                popDealMan.Groups.Add(poli);
                poli.Title = "处理人选择";
                List<coreUser> users = autofacConfig.coreUserService.GetAdmin();
                foreach (coreUser Row in users)
                {
                    poli.AddListItem(Row.USER_NAME, Row.USER_ID);
                }
                if (btnDealMan.Tag != null)   //如果已有选中项，则显示选中效果
                {
                    foreach (PopListItem Item in poli.Items)
                    {
                        if (Item.Value == btnDealMan.Tag.ToString())
                            popDealMan.SetSelections(Item);
                    }
                }
                popDealMan.ShowDialog();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 数据加载
        /// </summary>
        public void Bind()
        {
            try
            {
                foreach (ConsumablesOrderRow data in RowData)
                {
                    foreach (ListViewRow row in ListCons.Rows)
                    {
                        frmOrderCreateLayout Layout = row.Control as frmOrderCreateLayout;
                        string[] LCData = Layout.lblLocation.BindDataValue.ToString().Split('/');
                        string cId = Layout.lblName.BindDataValue.ToString();
                        if (data.CID == cId && data.WAREID == LCData[0]
                            && data.STID == LCData[1] && data.SLID == LCData[2])
                        {
                            data.QTY = (Decimal)Layout.numNumber.Value;
                        }
                    }
                }

                DataTable tableAssets = new DataTable();       //未开启SN的资产列表
                tableAssets.Columns.Add("CID");                //资产编号
                tableAssets.Columns.Add("NAME");               //资产名称 
                tableAssets.Columns.Add("LOCID");              //   仓库/存储类型/库位
                tableAssets.Columns.Add("LOCNAME");            //   仓库名称/类型名称/库位名称
                tableAssets.Columns.Add("IMAGE");              //图片编号
                tableAssets.Columns.Add("QUANTITY");           //空闲数量
                tableAssets.Columns.Add("SELECTQTY");          //选择数量

                if (RowData.Count > 0)
                {
                    foreach (ConsumablesOrderRow Row in RowData)
                    {
                        ConQuant conQuant = autofacConfig.orderCommonService.GetUnUseConByCID(Row.CID, Row.WAREID, Row.STID, Row.SLID);
                        Consumables con = autofacConfig.consumablesService.GetConsById(Row.CID);
                        WHStorageLocationOutputDto WHLoc = autofacConfig.wareHouseService.GetSLByID(Row.WAREID, Row.STID, Row.SLID);
                        tableAssets.Rows.Add(Row.CID, con.NAME, Row.WAREID + "/" + Row.STID + "/" + Row.SLID, WHLoc.WARENAME + "/" + WHLoc.STNAME + "/" + WHLoc.SLNAME, con.IMAGE, conQuant.QUANTITY, Row.QTY);
                    }
                }
                ListCons.DataSource = tableAssets;
                ListCons.DataBind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 删除当前选择行项
        /// </summary>
        /// <param name="ASSID"></param>
        public void ReMoveAss(String CID,String locId)
        {
            String[] locData = locId.Split('/');
            foreach (ConsumablesOrderRow Row in RowData)
            {
                if (Row.CID == CID&& Row.WAREID==locData[0]
                    && Row.STID==locData[1] && Row.SLID==locData[2])
                {
                    RowData.Remove(Row);
                    break;
                }
            }
            Bind();       //刷新当前页面
        }
        /// <summary>
        /// 耗材添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Press(object sender, EventArgs e)
        {
            try
            {
                if (lblLocation.Tag == null) throw new Exception("请选择调入库位!");
                List<ConsumablesOrderRow> Data = new List<ConsumablesOrderRow>();
                foreach (ListViewRow Row in ListCons.Rows)
                {
                    frmOrderCreateLayout Layout = Row.Control as frmOrderCreateLayout;
                    Data.Add(Layout.getData());
                }

                frmTransferConsChoose frm = new frmTransferConsChoose();
                frm.RowData = Data;
                frm.LocInID = lblLocation.Tag.ToString();
                Show(frm, (MobileForm sender1, object args) =>
                {
                    if (frm.ShowResult == ShowResult.Yes)
                    {
                        //重新加载数据
                        RowData = frm.RowData;
                        Bind();
                    }
                });
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 扫描条码添加耗材
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void betGet_Press(object sender, EventArgs e)
        {
            try
            {
                if (lblLocation.Tag == null) throw new Exception("请选择调入库位!");
                BarcodeScanner1.GetBarcode();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 扫描到耗材条码时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BarcodeScanner1_BarcodeScanned(object sender, BarcodeResultArgs e)
        {
            try
            {
                ConsumablesOrderRow Data = new ConsumablesOrderRow();
                if (string.IsNullOrEmpty(e.error))
                    CID = e.Value;
                else
                    throw new Exception(e.error);
                string[] LCData = lblLocation.Tag.ToString().Split('/');
                Consumables con = autofacConfig.consumablesService.GetConsById(CID);
                if (con == null) throw new Exception("耗材不存在,请重新扫码");
                List<ConQuantOutputDto> assList = autofacConfig.orderCommonService.GetUnUseCon(LCData[0], LCData[1], LCData[2], CID);
                if (assList.Count > 1)
                {
                    popLocation.Groups.Clear();
                    PopListGroup poli = new PopListGroup();
                    popLocation.Groups.Add(poli);
                    foreach (ConQuantOutputDto Row in assList)
                    {
                        if (Row.WAREID + "/" + Row.STID + "/" + Row.SLID != lblLocation.Tag.ToString())
                        {
                            poli.AddListItem(Row.WARENAME + "/" + Row.STNAME + "/" + Row.SLNAME, Row.WAREID + "/" + Row.STID + "/" + Row.SLID);
                        }
                    }
                    popLocation.ShowDialog();
                }
                else
                {
                    if (assList[0].WAREID + "/" + assList[0].STID + "/" + assList[0].SLID == lblLocation.Tag.ToString()) throw new Exception("该资产已在目的库位!");
                    foreach (ConsumablesOrderRow Row in RowData)
                    {
                        if (Row.CID == CID && Row.WAREID == assList[0].WAREID
                            && Row.STID == assList[0].STID && Row.SLID == assList[0].SLID)
                        {
                            throw new Exception("该耗材已存在调拨列表中");
                        }
                    }
                    Consumables cons = autofacConfig.consumablesService.GetConsById(CID);
                    Data.CID = CID;
                    Data.WAREID = assList[0].WAREID;
                    Data.STID = assList[0].STID;
                    Data.SLID = assList[0].SLID;
                    Data.IMAGE = cons.IMAGE;
                    Data.QTY = 0;

                    if (RowData.Count > 0)
                    {
                        RowData.Add(Data);
                    }
                    else
                    {
                        List<ConsumablesOrderRow> Datas = new List<ConsumablesOrderRow>();
                        Datas.Add(Data);
                        RowData = Datas;
                    }
                    Bind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 选择处理人
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popDealMan_Selected(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(popDealMan.Selection.Text) == false)
            {
                btnDealMan.Text = popDealMan.Selection.Text + "   > ";
                btnDealMan.Tag = popDealMan.Selection.Value;         //处理人编号
            }
        }
        /// <summary>
        /// 选择调入管理员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popDealInMan_Selected(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(popDealInMan.Selection.Text) == false)
            {
                btnDealInMan.Text = popDealInMan.Selection.Text + "   > ";
                btnDealInMan.Tag = popDealInMan.Selection.Value;         //调入管理员编号
            }
        }
        /// <summary>
        /// 扫描库位条码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgBS_Press(object sender, EventArgs e)
        {
            bsLoc.GetBarcode();
        }
        /// <summary>
        /// 扫描到库位条码时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bsLoc_BarcodeScanned(object sender, BarcodeResultArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(e.error))
                {
                    String Data = e.Value;
                    String[] Datas = Data.Split('/');
                    if (Datas.Length != 3) throw new Exception("库位条码错误");
                    WHStorageLocationOutputDto whLoc = autofacConfig.wareHouseService.GetSLByID(Datas[0], Datas[1], Datas[2]);
                    if (whLoc == null) throw new Exception("库位不存在，请检查!");
                    lblLocation.Text = whLoc.WARENAME + "/" + whLoc.STNAME + "/" + whLoc.SLNAME;
                    lblLocation.Tag = Data;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 选择了库位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popLocation_Selected(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(popLocation.Selection.Text) == false)
                {
                    String[] locData = popLocation.Selection.Value.Split('/');
                    Consumables cons = autofacConfig.consumablesService.GetConsById(CID);
                    foreach (ConsumablesOrderRow Row in RowData)
                    {
                        if (Row.CID == CID && Row.WAREID == locData[0]
                            && Row.STID == locData[1] && Row.SLID == locData[2])
                        {
                            throw new Exception("该耗材已存在调拨列表中");
                        }
                    }
                    ConsumablesOrderRow Data = new ConsumablesOrderRow();
                    Data.CID = CID;
                    Data.WAREID = locData[0];
                    Data.STID = locData[1];
                    Data.SLID = locData[2];
                    Data.IMAGE = cons.IMAGE;
                    Data.QTY = 0;
                    if (RowData.Count > 0)
                    {
                        RowData.Add(Data);
                    }
                    else
                    {
                        List<ConsumablesOrderRow> Datas = new List<ConsumablesOrderRow>();
                        Datas.Add(Data);
                        RowData = Datas;
                    }
                    Bind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 关闭当前页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plBack_Press(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// 调拨单创建
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plSave_Press(object sender, EventArgs e)
        {
            try
            {
                TOInputDto TransferData = new TOInputDto();        //维修单信息
                if (btnDealInMan.Tag == null)
                    throw new Exception("调入管理员不能为空");
                else
                    TransferData.MANAGER = btnDealInMan.Tag.ToString();     //调入管理员

                if (lblLocation.Tag == null)
                    throw new Exception("调入库位不能为空");
                else
                {
                    string[] Datas = lblLocation.Tag.ToString().Split('/');
                    TransferData.WAREID = Datas[0];     //调入仓库
                    TransferData.STID = Datas[1];       //调入类型
                    TransferData.DESSLID = Datas[2];    //调入库位
                }


                if (btnDealMan.Tag == null)
                    throw new Exception("处理人不能为空");
                else
                    TransferData.HANDLEMAN = btnDealMan.Tag.ToString();     //处理人

                TransferData.TRANSFERDATE = DatePicker.Value;   //维修花费
                TransferData.NOTE = txtNote.Text;                           //备注
                TransferData.STATUS = 0;                                    //维修单状态
                TransferData.CREATEUSER = Client.Session["UserID"].ToString();      //创建用户
                TransferData.CREATEDATE = DateTime.Now;

                List<AssTransferOrderRow> Data = new List<AssTransferOrderRow>();
                if (ListCons.Rows.Count == 0) throw new Exception("调拨行项不能为空!");
                foreach (ListViewRow Row in ListCons.Rows)
                {
                    frmOrderCreateLayout Layout = Row.Control as frmOrderCreateLayout;
                    ConsumablesOrderRow RowData = Layout.getData();
                    AssTransferOrderRow assRow = new AssTransferOrderRow();

                    assRow.IMAGE = RowData.IMAGE;
                    assRow.CID = RowData.CID;
                    assRow.INTRANSFERQTY = RowData.QTY;
                    assRow.WAREID = RowData.WAREID;
                    assRow.STID = RowData.STID;
                    assRow.SLID = RowData.SLID;
                    assRow.STATUS = RowData.STATUS;
                    assRow.CREATEDATE = DateTime.Now;
                    Data.Add(assRow);
                }
                TransferData.Rows = Data;
                ReturnInfo r = autofacConfig.assTransferOrderService.AddAssTransferOrder(TransferData, OperateType.耗材);
                if (r.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    Form.Close();          //创建成功
                    Toast("创建调拨单成功!");
                }
                else
                {
                    throw new Exception(r.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}