using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.Enum;

namespace SMOWMS.UI.ConsumablesManager
{
    partial class frmTransferRows : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        #endregion
        private void btnCreate_Press(object sender, EventArgs e)
        {
            frmTransferCreate frm = new frmTransferCreate();
            Show(frm, (MobileForm sender1, object args) => {
                if (frm.ShowResult == ShowResult.Yes)
                {
                    Bind();   //重新加载数据
                }
            });
        }
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTransferRows_Load(object sender, EventArgs e)
        {
            Bind();
        }
        /// <summary>
        /// 数据加载
        /// </summary>
        public void Bind()
        {
            try
            {
                List<AssTransferOrder> Data = new List<AssTransferOrder>();
                if (Client.Session["Role"].ToString() == "SMOWMSUser")
                {
                    Data = autofacConfig.assTransferOrderService.GetByUser(Client.Session["UserID"].ToString(),OperateType.耗材);
                }
                else
                {
                    Data = autofacConfig.assTransferOrderService.GetByUser(null,OperateType.耗材);
                }
                if (Data.Count > 0)
                {
                    listTransferOrder.DataSource = Data;
                    listTransferOrder.DataBind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}