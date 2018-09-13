using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.UI.Layout;
using SMOWMS.CommLib;
using SMOWMS.DTOs.OutputDTO;

namespace SMOWMS.UI.ConsumablesManager
{
    partial class frmConSalesCreate : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public List<ConPurAndSaleCreateInputDto> Rows = new List<ConPurAndSaleCreateInputDto>();         //选择的耗材编号
        public string SOID;        //耗材销售单号
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmConSalesCreate_Load(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(SOID))   //SOID不为空,说明是销售单修改
                {
                    this.Title1.TitleText = "耗材销售单编辑";
                    ///表头信息
                    ConSalesOrderOutputDto Order = autofacConfig.ConSalesOrderService.GetBySOID(SOID);
                    txtRealID.Text = Order.REALID;
                    txtName.Text = Order.NAME;
                    btnCustomer.Tag = Order.CUSID;
                    btnCustomer.Text=Order.CUSTOMERNAME + "   > ";
                    btnDealMan.Tag = Order.SALESPERSON;
                    btnDealMan.Text = Order.SALESPERSONNAME + "   > ";

                    //耗材行项信息
                    List<ConPurAndSaleCreateInputDto> OrderRows = autofacConfig.ConSalesOrderService.GetOrderRows(SOID);
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
        /// 销售人选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnManager_Press(object sender, EventArgs e)
        {
            popDealMan.Groups.Clear();       //数据清空
            PopListGroup poli = new PopListGroup();
            popDealMan.Groups.Add(poli);
            poli.Title = "销售人选择";
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
        /// 选择了销售人
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popDealMan_Selected(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(popDealMan.Selection.Text) == false)
            {
                btnDealMan.Text = popDealMan.Selection.Text + "   > ";
                btnDealMan.Tag = popDealMan.Selection.Value;         //销售人编号
            }
        }
        /// <summary>
        /// 客户选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCustomer_Press(object sender, EventArgs e)
        {
            popCustomer.Groups.Clear();       //数据清空
            PopListGroup poli = new PopListGroup();
            popCustomer.Groups.Add(poli);
            poli.Title = "销售人选择";
            List<Customer> customerList = autofacConfig.customerService.GetAll();
            foreach (Customer Row in customerList)
            {
                poli.AddListItem(Row.NAME, Row.CUSID.ToString());
            }
            if (btnCustomer.Tag != null)   //如果已有选中项，则显示选中效果
            {
                foreach (PopListItem Item in poli.Items)
                {
                    if (Item.Value == btnCustomer.Tag.ToString())
                        popCustomer.SetSelections(Item);
                }
            }
            popCustomer.ShowDialog();
        }
        /// <summary>
        /// 选择了客户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popCustomer_Selected(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(popCustomer.Selection.Text) == false)
            {
                btnCustomer.Text = popCustomer.Selection.Text + "   > ";
                btnCustomer.Tag = popCustomer.Selection.Value;         //客户编号
            }
        }
        /// <summary>
        /// 删除当前选择行项
        /// </summary>
        /// <param name="CID"></param>
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
                    frmSalesCreateLayout Layout = Row.Control as frmSalesCreateLayout;
                    Data.Add(Layout.getData());
                }

                frmConsChoose frm = new frmConsChoose();
                frm.Rows = Data;
                frm.type = 1;
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
        /// 扫描到耗材编号时
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
        /// 耗材销售单创建
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtName.Text)) throw new Exception("销售单名称不能为空!");
                if (btnDealMan.Tag == null) throw new Exception("请选择销售人!");
                if (ListCons.Rows.Count == 0) throw new Exception("请选择销售行项");
                ConSalesOrderInputDto Data = new ConSalesOrderInputDto();
                Data.REALID = txtRealID.Text;
                Data.NAME = txtName.Text;
                Data.CUSID = Convert.ToInt32(btnCustomer.Tag);
                Data.SALESPERSON = btnDealMan.Tag.ToString();
                Data.CREATEUSER = Client.Session["UserID"].ToString();
                Data.CREATEDATE = DateTime.Now;
                Data.MODIFYUSER = Client.Session["UserID"].ToString();
                Data.MODIFYDATE = DateTime.Now;
                List<ConSalesOrderRowInputDto> RowData = new List<ConSalesOrderRowInputDto>();
                //获取行项数据
                foreach (ListViewRow Row in ListCons.Rows)
                {
                    frmSalesCreateLayout Layout = Row.Control as frmSalesCreateLayout;
                    ConPurAndSaleCreateInputDto conPurAndSaleCreateInputDto = Layout.getData();
                    ConSalesOrderRowInputDto row = new ConSalesOrderRowInputDto();
                    row.CID = conPurAndSaleCreateInputDto.CID;
                    row.IMAGE = conPurAndSaleCreateInputDto.IMAGE;
                    row.QUANTSALED = conPurAndSaleCreateInputDto.QUANTPURCHASED;
                    row.REALPRICE = conPurAndSaleCreateInputDto.REALPRICE;
                    RowData.Add(row);
                }

                Data.RowData = RowData;
                ReturnInfo RInfo = new ReturnInfo();

                if (String.IsNullOrEmpty(SOID))     //创建耗材采购单
                {
                    RInfo = autofacConfig.ConSalesOrderService.AddSalesOrder(Data);
                    if (RInfo.IsSuccess)     //创建成功
                    {
                        this.Close();          //关闭当前界面，返回到列表界面
                        ShowResult = ShowResult.Yes;
                        Toast("销售单" + RInfo.ErrorInfo + "创建成功!");
                    }
                    else       //创建失败
                    {
                        throw new Exception(RInfo.ErrorInfo);
                    }
                }
                else               //更新耗材采购单
                {
                    Data.SOID = SOID;
                    RInfo = autofacConfig.ConSalesOrderService.UpdateSalesOrder(Data);
                    if (RInfo.IsSuccess)     //创建成功
                    {
                        this.Close();          //关闭当前界面，返回到列表界面
                        ShowResult = ShowResult.Yes;
                        Toast("销售单" + SOID + "编辑成功!");
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