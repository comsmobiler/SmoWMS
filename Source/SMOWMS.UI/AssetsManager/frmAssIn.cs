using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using Smobiler.Core.Controls;
using Smobiler.Plugins.RongIM;
using SMOWMS.CommLib;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.Enum;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.DTOs.OutputDTO;
using SMOWMS.UI.Layout;

namespace SMOWMS.UI.AssetsManager
{
    partial class frmAssIn : Smobiler.Core.Controls.MobileForm
    {
        #region  定义变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        private string UserId;
        private DataTable SNTable = new DataTable(); //待盘点的资产
        private static object lockobj = new object();
        private List<string> snList=new List<string>();  //资产的初始列表
        public string POID;
        public bool IsFromPO;
        private string Image;
        private decimal Total;
        private bool IsLast;
        #endregion

        /// <summary>
        /// 入库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
                string WareId = "";
                string STID = "";
                string SLID = "";
                if (txtSLID.Tag != null)
                {
                    string[] Ids = txtSLID.Tag.ToString().Split('/');
                    WareId = Ids[0];
                    if (Ids.Length == 3)
                    {
                        STID = Ids[1];
                        SLID = Ids[2];
                    }
                }
                if (string.IsNullOrEmpty(SLID))
                {
                    throw new Exception("请扫描正确的库位！");
                }
                if (snList.Count == 0)
                {
                    throw new Exception("请添加要入库的序列号！");
                }
                ReturnInfo rInfo = new ReturnInfo();
                AssInStorageInputDto inputDto = new AssInStorageInputDto
                {
                    POID = txtPOID.Text,
                    SLID = SLID,
                    STID = STID,
                    WAREID = WareId,
                    TEMPLATEID = btnTemplate.Tag.ToString(),
                    UserId = UserId,
                    SnList = snList
                };
                rInfo = _autofacConfig.AssPurchaseOrderService.InstorageAss(inputDto);
                if (rInfo.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
//                    Toast("入库成功！");
                    btnTemplate.Text = "选择（必填）";
                    btnTemplate.Tag = null;
                    txtSLID.Text = "（必填）";
                    txtSLID.Tag = null;
                    snList.Clear();
                    lvSN.Rows.Clear();
                    SNTable.Rows.Clear();
                    //查询采购单状态
                    var po = _autofacConfig.AssPurchaseOrderService.GetById(txtPOID.Text);
                    if (IsFromPO)
                    {
                        //如果全部完成，则关闭
                        if (po.STATUS == (int) PurchaseOrderStatus.已完成)
                        {
                            Toast("该订单已全部入库完成！");
                            Close();
                        }
                        else
                        {
                            Toast("入库成功！");
                            DealLastTemp();
                            GetTotal();
                            lblQuant.Text ="剩余:  "+ GetRest();
                        }
                    }
                    else
                    {
                        //如果全部完成，则提示该订单已经完成入库
                        if (po.STATUS == (int)PurchaseOrderStatus.已完成)
                        {
                            Toast("该订单已全部入库完成！");
                            txtPOID.Text = "";
                            txtPOID.Tag = null;
                            IsLast = false;
                        }
                        else
                        {
                            Toast("入库成功！");
                            DealLastTemp();
                            GetTotal();
                            lblQuant.Text = "剩余:  " + GetRest();
                        }
                    }
                }
                else
                {
                    Toast(rInfo.ErrorInfo);
                }

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 二维码扫描序列号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelScan_Press(object sender, EventArgs e)
        {
            try
            {
                if (btnTemplate.Tag == null)
                {
                    throw new Exception("请先选择模板.");
                }
                bcScanForSN.GetBarcode();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 界面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssIn_Load(object sender, EventArgs e)
        {
            try
            {
                //添加各表格的列
                if (SNTable.Columns.Count == 0)
                {
                    SNTable.Columns.Add("IMAGE");
                    SNTable.Columns.Add("SN");
                }
                DataColumn[] keys = new DataColumn[1];
                keys[0] = SNTable.Columns["SN"];
                SNTable.PrimaryKey = keys;
                IsLast = false;
                UserId = Client.Session["UserID"].ToString();
                if (!string.IsNullOrEmpty(POID))
                {
                    txtPOID.Text = POID;
                    txtPOID.Tag = POID;
                    ImgBtnForPOID.Visible = false;
//                    txtPOID.Size = new Size(200, 30);
                    DealLastTemp();
                    GetTotal();
                    lblQuant.Text = "剩余:  " + GetRest();
                }

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 手机扫描到采购单编号时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bcScanForPOID_BarcodeScanned(object sender, BarcodeResultArgs e)
        {
            try
            {
                string barCode = e.Value;
                bool IsExist = _autofacConfig.AssPurchaseOrderService.POIDIsExist(barCode);
                if (IsExist)
                {
                    txtPOID.Text = barCode;
                    if (POID != barCode)
                    {
                        POID = barCode;
                        ClearInfo();
                    }
                    GetTotal();
                }
                else
                {
                    throw new Exception("请扫描正确的采购单编号！");
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 手机扫描到库位时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bcScanForSLID_BarcodeScanned(object sender, BarcodeResultArgs e)
        {
            try
            {
                string barCode = e.Value;
                string WareId = "";
                string STID = "";
                string SLID = "";

                string[] Ids = barCode.Split('/');
                WareId = Ids[0];
                if (Ids.Length == 3)
                {
                    STID = Ids[1];
                    SLID = Ids[2];
                }
                else
                {
                    throw new Exception("该库位编号不存在！");
                }
                if (_autofacConfig.wareHouseService.SLIsExists(WareId, STID, SLID))
                {
                    WHStorageLocationOutputDto whLoc = _autofacConfig.wareHouseService.GetSLByID(WareId, STID, SLID);
                    if (whLoc == null) throw new Exception("库位不存在，请检查!");
                    txtSLID.Text = whLoc.WARENAME + "/" + whLoc.STNAME + "/" + whLoc.SLNAME;
                    txtSLID.Tag = barCode;
                }
                else
                {
                    throw new Exception("该库位编号不存在！");
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 手机扫描到序列号时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bcScanForSN_BarcodeScanned(object sender, BarcodeResultArgs e)
        {
            try
            {
                string barCode = e.Value;
                if (!snList.Contains(barCode))
                {
                    bool isExists = _autofacConfig.SettingService.SNIsExists(barCode);
                    if (!isExists)
                    {
                        AddSnToDataTable(barCode);
                    }
                    else
                    {
                        throw new Exception("该序列号已经存在！");
                    }
                }

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 手持扫描到序列号时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void r2000ScanForSN_BarcodeDataCaptured(object sender, Smobiler.Device.R2000BarcodeScanEventArgs e)
        {
            try
            {
                string barCode = e.Data;
                if (!snList.Contains(barCode))
                {
                    bool isExists = _autofacConfig.SettingService.SNIsExists(barCode);
                    if (!isExists)
                    {  AddSnToDataTable(barCode);}
                    else
                    {
                        throw new Exception("该序列号已经存在！");
                    }
                }

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 手持扫描到RFID时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void r2000ScanForSN_RFIDDataCaptured(object sender, Smobiler.Device.R2000RFIDScanEventArgs e)
        {
            string RFID = e.Epc;
            if (!snList.Contains(RFID))
            {
                bool isExists = _autofacConfig.SettingService.SNIsExists(RFID);
                if (!isExists)
                    AddSnToDataTable(RFID);
            }
        }

        /// <summary>
        /// 回退，则关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssIn_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                Close();
            }
        }

        /// <summary>
        /// 扫描销售单编号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImgBtnForPOID_Press(object sender, EventArgs e)
        {
            try
            {
                bcScanForPOID.GetBarcode();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 扫描库位编号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImgBtnForSLID_Press(object sender, EventArgs e)
        {
            try
            {
                bcScanForSLID.GetBarcode();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 选择资产模板时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTemplate_Press(object sender, EventArgs e)
        {
            try
            {
                if (IsLast)
                {
                    return;
                }
                if (!string.IsNullOrEmpty(txtPOID.Text))
                {
                    popTemp.Groups.Clear();
                    PopListGroup tempGroup = new PopListGroup {Title = "资产模板"};
                    List<AssTempOutputDto> assTemp =
                        _autofacConfig.AssPurchaseOrderService.GetTemplateList(txtPOID.Text);
                    foreach (AssTempOutputDto Row in assTemp)
                    {
                        tempGroup.AddListItem(Row.NAME, Row.TEMPLATEID);
                    }
                    popTemp.Groups.Add(tempGroup);
                    if (btnTemplate.Tag != null) //如果已有选中项，则显示选中效果
                    {
                        foreach (PopListItem Item in tempGroup.Items)
                        {
                            if (Item.Value == btnTemplate.Tag.ToString())
                                popTemp.SetSelections(Item);
                        }
                    }
                    popTemp.ShowDialog();
                }
                else
                {
                    throw new Exception("请先输入采购单编号！");
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 选中资产模板时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popTemp_Selected(object sender, EventArgs e)
        {
            try
            {
                if (popTemp.Selection != null)
                {
                    btnTemplate.Text = popTemp.Selection.Text;

                    btnTemplate.Tag = popTemp.Selection.Value;
                    AssTemplate tempOutput = _autofacConfig.SettingService.GetAtbyId(btnTemplate.Tag.ToString());
                    Image = tempOutput.IMAGE;
                    ChangeImage();
                    GetTotal();
                    lblQuant.Text = "剩余:  " + GetRest();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 把扫描到的资产添加到对应的Dictionary
        /// </summary>
        /// <param name="SN">序列号</param>
        private void AddSnToDataTable(string SN)
        {
            lock (lockobj)
            {
                DataRow row = SNTable.Rows.Find(SN);
                if (row == null)
                {
                    DataRow newRow = SNTable.NewRow();
                    newRow["IMAGE"] = Image;
                    newRow["SN"] = SN;
                    SNTable.Rows.Add(newRow);

                    var newdt = SNTable.Clone();
                    newdt.ImportRow(newRow);
                    snList.Add(SN);
                    lvSN.NewRow(newdt, "");
                }
                lblQuant.Text = "剩余:  " + GetRest();
            }
        }

        /// <summary>
        /// 移除序列号
        /// </summary>
        /// <param name="SN"></param>
        public void RemoveSN(string SN)
        {
            DataRow row = SNTable.Rows.Find(SN);
            if (row != null)
            {
                SNTable.Rows.Remove(row);
                snList.Remove(SN);
                lvSN.DataSource = SNTable;
                lvSN.DataBind();
                lblQuant.Text = "剩余:  " + GetRest();
            }
        }

        /// <summary>
        /// 清空资产模板数据
        /// </summary>
        private void ClearInfo()
        {
            try
            {
                btnTemplate.Tag = null;
                btnTemplate.Text="" + "   > ";
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private string GetRest()
        {
            int sncount = snList.Count;
            int rest = (int)Total - sncount;
            return rest.ToString();
        }

        private void GetTotal()
        {
            //得到需要输入的SN数量
            if (btnTemplate.Tag != null && txtPOID.Tag != null)
            {
                var porow = _autofacConfig.AssPurchaseOrderService.GetPORows(txtPOID.Tag.ToString());
                if (porow == null) throw new ArgumentNullException("porow");
                var row = porow.Find(a => a.TEMPLATEID == btnTemplate.Tag.ToString());
                if (row != null)
                {
                    Total = row.QUANTPURCHASED - row.QUANTSTORED;
                }
                
            }
        }

        private void DealLastTemp()
        {
            try
            {
                //判断是否还剩一项
                //如果只剩最后一个，则直接选中，无需poplist
                List<AssTempOutputDto> assTemp =
                    _autofacConfig.AssPurchaseOrderService.GetTemplateList(txtPOID.Text);
                if (assTemp.Count == 1)
                {
                    btnTemplate.Text = assTemp.FirstOrDefault().NAME;
                    btnTemplate.Tag = assTemp.FirstOrDefault().TEMPLATEID;
                    IsLast = true;
//                    btnTemplate.Enabled = false;
//                    btnTemplate.BackColor=Color.White;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void ChangeImage()
        {
            try
            {
                lvSN.Rows.Clear();
                foreach (DataRow row in SNTable.Rows)
                {
                    row["IMAGE"] = Image;
                }
                lvSN.DataSource = SNTable;
                lvSN.DataBind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}