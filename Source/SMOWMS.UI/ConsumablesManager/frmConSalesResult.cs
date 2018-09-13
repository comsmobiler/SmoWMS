using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using ListView = Smobiler.Core.Controls.ListView;
using Smobiler.Core.Controls;
using System.Data;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.Enum;
using SMOWMS.CommLib;
using SMOWMS.UI.Layout;
using System.Windows.Forms;
using System.Drawing;
using SMOWMS.DTOs.OutputDTO;

namespace SMOWMS.UI.ConsumablesManager
{
    partial class frmConSalesResult : Smobiler.Core.Controls.MobileForm
    {
        #region  定义变量
        private AutofacConfig autofacConfig = new AutofacConfig();//调用配置类
        public string SOID; //销售单编号
        private string UserId;  //用户编号
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmConSalesResult_Load(object sender, EventArgs e)
        {
            try
            {
                UserId = Client.Session["UserID"].ToString();

                ///表头信息
                ConSalesOrderOutputDto Order = autofacConfig.ConSalesOrderService.GetBySOID(SOID);
                lblOrder.Text = SOID;
                lblRealID.Text = Order.REALID;
                lblName.Text = Order.NAME;
                lblCustomer.Text = Order.CUSTOMERNAME;
                lblDealMan.Text = Order.SALESPERSONNAME;

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
                ConSalesOrderOutputDto Order = autofacConfig.ConSalesOrderService.GetBySOID(SOID);
                List<ConSalesOrderOutboundOutputDto> outRows = autofacConfig.ConSalesOrderService.GetOutRowsBySOID(SOID);
                List<ConSalesOrderRowInputDto> retRows = autofacConfig.ConSalesOrderService.GetRetRowsBySOID(SOID);
                if (Order.STATUS == (int)SalesOrderStatus.已完成 && outRows.Count == 0 && retRows.Count == 0)        ////如果无可退库耗材,无可入库耗材，则隐藏按钮
                {
                    Form.ActionButton.Items.RemoveAt(1);
                    Form.ActionButton.Items.RemoveAt(0);
                }
                if (Form.ActionButton.Items.Count == 0)
                {
                    Form.ActionButton.Enabled = false;
                }

                List<ConPurAndSaleCreateInputDto> AlRows = autofacConfig.ConSalesOrderService.GetOrderRows(SOID);

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
        /// 出库、退货、销售提交、结束销售等操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmConSalesResult_ActionButtonPress(object sender, ActionButtonPressEventArgs e)
        {
            try
            {
                ReturnInfo rInfo = new ReturnInfo();
                switch (e.Index)
                {
                    case 0:      //耗材出库
                        List<ConSalesOrderOutboundOutputDto> outRows = autofacConfig.ConSalesOrderService.GetOutRowsBySOID(SOID);
                        if (outRows.Count > 0)
                        {
                            frmConSOROutbound frmOut = new frmConSOROutbound();
                            frmOut.SOID = SOID;
                            Form.Show(frmOut, (MobileForm sender1, object args) =>
                            {
                                Bind();      //数据绑定
                            });
                        }
                        else
                        {
                            throw new Exception("该消耗单下目前无可出库耗材!");
                        }
                        break;
                    case 1:      //耗材退货
                        List<ConSalesOrderRowInputDto> retRows = autofacConfig.ConSalesOrderService.GetRetRowsBySOID(SOID);
                        if (retRows.Count > 0)
                        {
                            frmConSORRetiring frmRet = new frmConSORRetiring();
                            frmRet.SOID = SOID;
                            Form.Show(frmRet, (MobileForm sender1, object args) =>
                            {
                                Bind();      //数据绑定
                            });
                        }
                        else
                        {
                            throw new Exception("该消耗单下目前无可出库耗材!");
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