using System;
using Smobiler.Core.Controls;
using SMOWMS.DTOs.OutputDTO;
using SMOWMS.DTOs.InputDTO;
using System.Data;
using System.Collections.Generic;
using SMOWMS.DTOs.Enum;
using SMOWMS.CommLib;

namespace SMOWMS.UI.ConsumablesManager
{
    partial class frmConPurchaseResult : Smobiler.Core.Controls.MobileForm
    {
        #region  定义变量
        private AutofacConfig autofacConfig = new AutofacConfig();//调用配置类
        public string POID; //采购单编号
        private string UserId;  //用户编号

        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmConPurChaseResult_Load(object sender, EventArgs e)
        {
            try
            {
                UserId = Client.Session["UserID"].ToString();

                ///表头信息
                ConPurchaseOrderOutputDto Order = autofacConfig.ConPurchaseOrderService.GetByPOID(POID);
                lblOrder.Text = POID;
                lblRealID.Text = Order.REALID;
                lblName.Text = Order.NAME;
                lblVendor.Text = Order.VENDORNAME;
                lblDealMan.Text = Order.PURCHASERNAME;

                //数据绑定
                Bind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 数据绑定
        /// </summary>
        public void Bind()
        {
            try
            {
                ConPurchaseOrderOutputDto Order = autofacConfig.ConPurchaseOrderService.GetByPOID(POID);
                List<ConPurchaseOrderReturnOutputDto> returnRows = autofacConfig.ConPurchaseOrderService.GetReturnRowsByPOID(POID);
                List<ConPORInstorageOutputDto> rows = autofacConfig.ConPurchaseOrderService.GetInStoRowsByPOID(POID);
                if (Order.STATUS == (int)PurchaseOrderStatus.已完成 && returnRows.Count == 0 && rows.Count == 0)        ////如果无可退库耗材,无可入库耗材，则隐藏按钮
                {
                    Form.ActionButton.Items.RemoveAt(1);
                    Form.ActionButton.Items.RemoveAt(0);
                }
                if (Form.ActionButton.Items.Count == 0)
                {
                    Form.ActionButton.Enabled = false;
                }

                List<ConPurAndSaleCreateInputDto> AlRows = autofacConfig.ConPurchaseOrderService.GetOrderRows(POID);
                lvData.Rows.Clear();
                lvData.DataSource = AlRows;
                lvData.DataBind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 入库、出库、购买提交、结束购买等操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmConPurchaseResult_ActionButtonPress(object sender, ActionButtonPressEventArgs e)
        {
            try
            {
                ReturnInfo rInfo = new ReturnInfo();
                switch (e.Index)
                {
                    case 0:      //耗材入库
                        List<ConPORInstorageOutputDto> rows = autofacConfig.ConPurchaseOrderService.GetInStoRowsByPOID(POID);
                        if (rows.Count > 0)
                        {
                            frmConPORInSto frmConPORInSto = new frmConPORInSto();
                            frmConPORInSto.POID = POID;
                            Form.Show(frmConPORInSto, (MobileForm sender1, object args) =>
                            {
                                Bind();      //数据绑定
                            });
                        }
                        else
                        {
                            throw new Exception("该入库单下目前无可入库耗材!");
                        }
                        break;
                    case 1:      //耗材退库
                        List<ConPurchaseOrderReturnOutputDto> returnRows = autofacConfig.ConPurchaseOrderService.GetReturnRowsByPOID(POID);
                        if (returnRows.Count > 0)
                        {
                            frmConPORReturn frmConPORReturn = new frmConPORReturn();
                            frmConPORReturn.POID = POID;
                            Form.Show(frmConPORReturn, (MobileForm sender1, object args) =>
                            {
                                Bind();      //数据绑定
                            });
                        }
                        else
                        {
                            throw new Exception("该入库单下目前无可退库耗材!");
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}