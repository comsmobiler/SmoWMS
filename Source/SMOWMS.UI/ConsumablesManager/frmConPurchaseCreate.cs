using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;
using SMOWMS.Domain.Entity;
using SMOWMS.UI.Layout;
using SMOWMS.DTOs.Enum;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.CommLib;
using SMOWMS.DTOs.OutputDTO;

namespace SMOWMS.UI.ConsumablesManager
{
    partial class frmConPurchaseCreate : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public List<ConPurAndSaleCreateInputDto> Rows = new List<ConPurAndSaleCreateInputDto>();         //选择的耗材编号
        public string POID;        //耗材采购单号
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmConPurchaseCreate_Load(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(POID))   //POID不为空,说明是采购单修改
                {
                    this.Title1.TitleText = "耗材采购单编辑";
                    ///表头信息
                    ConPurchaseOrderOutputDto Order = autofacConfig.ConPurchaseOrderService.GetByPOID(POID);
                    txtRealID.Text = Order.REALID;
                    txtName.Text = Order.NAME;
                    btnVendor.Tag = Order.VID;
                    btnVendor.Text=Order.VENDORNAME + "   > ";
                    btnDealMan.Tag = Order.PURCHASER;
                    btnDealMan.Text = Order.PURCHASERNAME + "   > ";

                    //耗材行项信息
                    List<ConPurAndSaleCreateInputDto> OrderRows = autofacConfig.ConPurchaseOrderService.GetOrderRows(POID);
                    if (OrderRows.Count > 0)
                    {
                        Rows = OrderRows;
                        Bind();
                    }
                }
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
                if (Rows.Count > 0)
                {
                    ListCons.DataSource = Rows;
                    ListCons.DataBind();
                }
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
        public void ReMoveAss(String CID)
        {
            foreach (ConPurAndSaleCreateInputDto Con in Rows)
            {
                if (Con.CID == CID)
                {
                    Rows.Remove(Con);
                    break;
                }
            }
            Bind();       //刷新当前页面
        }
        /// <summary>
        /// 采购人选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnManager_Press(object sender, EventArgs e)
        {
            popDealMan.Groups.Clear();       //数据清空
            PopListGroup poli = new PopListGroup();
            popDealMan.Groups.Add(poli);
            poli.Title = "采购人选择";
            List<coreUser> users = autofacConfig.coreUserService.GetAll();
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
        /// <summary>
        /// 选择了采购人
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popDealMan_Selected(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(popDealMan.Selection.Text) == false)
            {
                btnDealMan.Text = popDealMan.Selection.Text + "   > ";
                btnDealMan.Tag = popDealMan.Selection.Value;         //采购人编号
            }
        }
        /// <summary>
        /// 供货商选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVendor_Press(object sender, EventArgs e)
        {
            popVendor.Groups.Clear();       //数据清空
            PopListGroup poli = new PopListGroup();
            popVendor.Groups.Add(poli);
            poli.Title = "供货商选择";
            List<Vendor> vendorList = autofacConfig.vendorService.GetAll();
            foreach (Vendor Row in vendorList)
            {
                poli.AddListItem(Row.NAME, Row.VID.ToString());
            }
            if (btnVendor.Tag != null)   //如果已有选中项，则显示选中效果
            {
                foreach (PopListItem Item in poli.Items)
                {
                    if (Item.Value == btnVendor.Tag.ToString())
                        popVendor.SetSelections(Item);
                }
            }
            popVendor.ShowDialog();
        }
        /// <summary>
        /// 选择了供货商
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popVendor_Selected(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(popVendor.Selection.Text) == false)
            {
                btnVendor.Text = popVendor.Selection.Text + "   > ";
                btnVendor.Tag = popVendor.Selection.Value;         //供货商编号
            }
        }

        /// <summary>
        /// 进入耗材选择界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Press(object sender, EventArgs e)
        {
            try
            {
                List<ConPurAndSaleCreateInputDto> Data = new List<ConPurAndSaleCreateInputDto>();
                foreach (ListViewRow Row in ListCons.Rows)
                {
                    frmPurchaseCreateLayout Layout = Row.Control as frmPurchaseCreateLayout;
                    Data.Add(Layout.getData());
                }

                frmConsChoose frm = new frmConsChoose();
                frm.Rows = Data;
                frm.type = 0;
                Show(frm, (MobileForm sender1, object args) =>
                {
                    if (frm.ShowResult == ShowResult.Yes)
                    {
                        //重新加载数据
                        Rows = frm.Rows;
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
        /// 扫码添加耗材
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void betGet_Press(object sender, EventArgs e)
        {
            bsCons.GetBarcode();
        }
        /// <summary>
        /// 扫描到物料条码时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bsCons_BarcodeScanned(object sender, BarcodeResultArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(e.error))
                {
                    String CID = e.Value;
                    Consumables con = autofacConfig.consumablesService.GetConsById(CID);
                    if (con != null)
                    {
                        ConPurAndSaleCreateInputDto conDto = new ConPurAndSaleCreateInputDto();
                        conDto.CID = con.CID;
                        conDto.NAME = con.NAME;
                        conDto.IMAGE = con.IMAGE;
                        foreach (ConPurAndSaleCreateInputDto row in Rows)
                        {
                            if (row.CID == CID)
                            {
                                throw new Exception("该耗材已添加，请勿重复添加!");
                            }
                        }

                        Rows.Add(conDto);
                        Bind();
                    }
                    else
                    {
                        throw new Exception("编号为" + CID + "耗材不存在，请检查!");
                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 创建采购单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtName.Text)) throw new Exception("采购单名称不能为空!");
                if (btnDealMan.Tag == null) throw new Exception("请选择采购人!");
                if (ListCons.Rows.Count == 0) throw new Exception("请选择采购行项");
                ConPurchaseOrderInputDto Data = new ConPurchaseOrderInputDto();
                Data.REALID = txtRealID.Text;
                Data.NAME = txtName.Text;
                Data.PURCHASER = btnDealMan.Tag.ToString();
                Data.VID = Convert.ToInt32(btnVendor.Tag);
                Data.CREATEUSER = Client.Session["UserID"].ToString();
                Data.CREATEDATE = DateTime.Now;
                Data.MODIFYUSER = Client.Session["UserID"].ToString();
                Data.MODIFYDATE = DateTime.Now;
                List<ConPurchaseOrderRowInputDto> RowData = new List<ConPurchaseOrderRowInputDto>();
                //获取行项数据
                foreach (ListViewRow Row in ListCons.Rows)
                {
                    frmPurchaseCreateLayout Layout = Row.Control as frmPurchaseCreateLayout;
                    ConPurAndSaleCreateInputDto conPurAndSaleCreateInputDto = Layout.getData();
                    ConPurchaseOrderRowInputDto row = new ConPurchaseOrderRowInputDto();
                    row.CID = conPurAndSaleCreateInputDto.CID;
                    row.IMAGE = conPurAndSaleCreateInputDto.IMAGE;
                    row.QUANTPURCHASED = conPurAndSaleCreateInputDto.QUANTPURCHASED;
                    row.REALPRICE = conPurAndSaleCreateInputDto.REALPRICE;
                    RowData.Add(row);
                }

                Data.RowData = RowData;
                ReturnInfo RInfo = new ReturnInfo();

                if (String.IsNullOrEmpty(POID))     //创建耗材采购单
                {
                    RInfo = autofacConfig.ConPurchaseOrderService.AddPurchaseOrder(Data);
                    if (RInfo.IsSuccess)     //创建成功
                    {
                        this.Close();          //关闭当前界面，返回到列表界面
                        ShowResult = ShowResult.Yes;
                        Toast("采购单" + RInfo.ErrorInfo + "创建成功!");
                    }
                    else       //创建失败
                    {
                        throw new Exception(RInfo.ErrorInfo);
                    }
                }
                else               //更新耗材采购单
                {
                    Data.POID = POID;
                    RInfo = autofacConfig.ConPurchaseOrderService.UpdatePruchaseOrder(Data);
                    if (RInfo.IsSuccess)     //创建成功
                    {
                        this.Close();          //关闭当前界面，返回到列表界面
                        ShowResult = ShowResult.Yes;
                        Toast("采购单" + POID + "编辑成功!");
                    }
                    else       //创建失败
                    {
                        throw new Exception(RInfo.ErrorInfo);
                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}