using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.CommLib;
using SMOWMS.UI.AssetsManager;
using SMOWMS.UI.Menu;
using SMOWMS.DTOs.OutputDTO;
using SMOWMS.DTOs.Enum;
using SMOWMS.UI.MasterData;

namespace SMOWMS.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class svDelete : Smobiler.Core.Controls.MobileUserControl
    {
        private AutofacConfig autofacConfig = new AutofacConfig();//调用配置类
        public svDelete() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
        /// <summary>
        /// 删除列表行项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelRow_Press(object sender, EventArgs e)
        {
            try
            {
                switch (Parent.Parent.ToString())
                {
                    case "SMOWMS.UI.Layout.frmAssPOLayout":
                        AssPurchaseOrderOutputDto assPurchase = autofacConfig.AssPurchaseOrderService.GetById(((frmAssPOLayout)Parent.Parent).POID);
                        if (assPurchase.STATUS == (int)PurchaseOrderStatus.采购中)
                        {
                            MessageBox.Show("你确定要删除该采购单吗?", "系统提醒", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
                            {
                                try
                                {
                                    if (args.Result == ShowResult.OK)     //删除该采购单
                                    {
                                        ReturnInfo rInfo = autofacConfig.AssPurchaseOrderService.DeletePurchaseOrder(((frmAssPOLayout)Parent.Parent).POID);
                                        if (rInfo.IsSuccess)
                                        {
                                            ((frmOrder)Form).Bind(((frmOrder)Form).type, ((frmOrder)Form).orderType);  //刷新当前列表
                                            Toast("删除采购单成功");
                                        }
                                        else
                                        {
                                            throw new Exception(rInfo.ErrorInfo);
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Form.Toast(ex.Message);
                                }
                            });
                        }
                        else
                        {
                            throw new Exception("当前状态下无法删除该采购单");
                        }
                        break;
                    case "SMOWMS.UI.Layout.frmAssSOLayout":
                        AssSalesOrderOutputDto assSale = autofacConfig.AssSalesOrderService.GetById(((frmAssSOLayout)Parent.Parent).SOID);
                        if (assSale.STATUS == (int)SalesOrderStatus.销售中)
                        {
                            MessageBox.Show("你确定要刪除该销售单吗?", "系统提醒", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
                            {
                                try
                                {
                                    if (args.Result == ShowResult.OK)     //删除该销售单
                                    {
                                        ReturnInfo rInfo = autofacConfig.AssSalesOrderService.DeleteSalesOrder(((frmAssSOLayout)Parent.Parent).SOID);
                                        if (rInfo.IsSuccess)
                                        {
                                            ((frmOrder)Form).Bind(((frmOrder)Form).type, ((frmOrder)Form).orderType);  //刷新当前列表
                                            Toast("删除销售单成功");
                                        }
                                        else
                                        {
                                            throw new Exception(rInfo.ErrorInfo);
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Form.Toast(ex.Message);
                                }
                            });
                        }
                        else
                        {
                            throw new Exception("当前状态下无法删除该销售单");
                        }
                        break;
                    case "SMOWMS.UI.Layout.frmConPurchaseLayout":
                        ConPurchaseOrderOutputDto conPurchaseOrder = autofacConfig.ConPurchaseOrderService.GetByPOID(((frmConPurchaseLayout)Parent.Parent).POID);
                        if (conPurchaseOrder.STATUS == (int)PurchaseOrderStatus.采购中)
                        {
                            MessageBox.Show("你确定要删除该采购单吗?", "系统提醒", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
                            {
                                try
                                {
                                    if (args.Result == ShowResult.OK)     //删除该采购单
                                    {
                                        ReturnInfo rInfo = autofacConfig.ConPurchaseOrderService.DeletePurchaseOrder(((frmConPurchaseLayout)Parent.Parent).POID);
                                        if (rInfo.IsSuccess)
                                        {
                                            ((frmOrder)Form).Bind(((frmOrder)Form).type, ((frmOrder)Form).orderType);  //刷新当前列表
                                            Toast("删除采购单成功");
                                        }
                                        else
                                        {
                                            Toast(rInfo.ErrorInfo);
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Form.Toast(ex.Message);
                                }
                            });
                        }
                        else
                        {
                            throw new Exception("当前状态下无法删除该采购单");
                        }
                        break;
                    case "SMOWMS.UI.Layout.frmConSalesLayout":
                        ConSalesOrderOutputDto conSalesOrder = autofacConfig.ConSalesOrderService.GetBySOID(((frmConSalesLayout)Parent.Parent).SOID);
                        if (conSalesOrder.STATUS == (int)SalesOrderStatus.销售中)
                        {
                            MessageBox.Show("你确定要删除该销售单吗?", "系统提醒", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
                            {
                                try
                                {
                                    if (args.Result == ShowResult.OK)     //删除该销售单
                                    {
                                        ReturnInfo rInfo = autofacConfig.ConSalesOrderService.DeleteSalesOrder(((frmConSalesLayout)Parent.Parent).SOID);
                                        if (rInfo.IsSuccess)
                                        {
                                            ((frmOrder)Form).Bind(((frmOrder)Form).type, ((frmOrder)Form).orderType);  //刷新当前列表
                                            Toast("删除销售单成功");
                                        }
                                        else
                                        {
                                            Toast(rInfo.ErrorInfo);
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Form.Toast(ex.Message);
                                }
                            });
                        }
                        else
                        {
                            throw new Exception("当前状态下无法删除该销售单");
                        }
                        break;
                    case "SMOWMS.UI.Layout.frmCustomerLayout":
                        MessageBox.Show("你确定要删除该客户吗?", "系统提醒", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
                        {
                            try
                            {
                                if (args.Result == ShowResult.OK)     //启用该仓库
                                {
                                    ReturnInfo rInfo = autofacConfig.customerService.DeleteCustomer(((frmCustomerLayout)Parent.Parent).cusId);
                                    if (rInfo.IsSuccess)
                                    {
                                        ((frmCustomer)Form).Bind();
                                        Toast("删除客户成功");
                                    }
                                    else
                                    {
                                        throw new Exception(rInfo.ErrorInfo);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                Form.Toast(ex.Message);
                            }
                        });
                        break;
                    case "SMOWMS.UI.Layout.frmVendorLayout":
                        MessageBox.Show("你确定要删除该供货商吗?", "系统提醒", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
                        {
                            try
                            {
                                if (args.Result == ShowResult.OK)     //启用该仓库
                                {
                                    ReturnInfo rInfo = autofacConfig.vendorService.DeleteVendor(((frmVendorLayout)Parent.Parent).vId);
                                    if (rInfo.IsSuccess)
                                    {
                                        ((frmCustomer)Form).Bind();
                                        Toast("删除供货商成功");
                                    }
                                    else
                                    {
                                        throw new Exception(rInfo.ErrorInfo);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                Form.Toast(ex.Message);
                            }
                        });
                        break;
                }
            }
            catch (Exception ex)
            {

                Form.Toast(ex.Message);
            }
        }
    }
}