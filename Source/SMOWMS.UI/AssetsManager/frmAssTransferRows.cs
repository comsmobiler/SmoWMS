using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.Enum;
using SMOWMS.DTOs.OutputDTO;

namespace SMOWMS.UI.AssetsManager
{
    partial class frmAssTransferRows : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        #endregion
        /// <summary>
        /// 关闭当前页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plBack_Press(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// 资产调拨新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plAdd_Press(object sender, EventArgs e)
        {
            frmAssTransferCreate frm = new frmAssTransferCreate();
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
        private void frmTransferRowsSN_Load(object sender, EventArgs e)
        {
            Bind();
        }
        /// <summary>
        /// 加载数据
        /// </summary>
        public void Bind()
        {
            try
            {
                List<AssTransferOrderOutputDto> Data = new List<AssTransferOrderOutputDto>();
                if (Client.Session["Role"].ToString() == "SMOWMSUser")
                {
                    Data = autofacConfig.assTransferOrderService.GetByUser(Client.Session["UserID"].ToString(),OperateType.资产);
                }
                else
                {
                    Data = autofacConfig.assTransferOrderService.GetByUser(null, OperateType.资产);
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