using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.UI.Analyze.Assets;
using SMOWMS.UI.Analyze.Consumable;

namespace SMOWMS.UI.UserControl
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmAnalyzeLayout : Smobiler.Core.Controls.MobileUserControl
    {
        public frmAnalyzeLayout() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        internal int type = 0;   // 0-资产,1-耗材
        #endregion
        /// <summary>
        /// 资产耗材报表切换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void scType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (scType.SelectedIndex == 0)
            {
                type = 0;
                ibSafeQuant.Visible = false;
                ibExpiry.Visible = true;
            }
            else
            {
                type = 1;
                ibSafeQuant.Visible = true;
                ibExpiry.Visible = false;
            }
        }
        /// <summary>
        /// 库存统计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ibQuant_Press(object sender, EventArgs e)
        {
            if (type == 0)
            {
                frmAssQuantAnalysis frmAss = new frmAssQuantAnalysis();
                this.Form.Show(frmAss);
            }
            else
            {
                frmQuantAnalyze frm = new frmQuantAnalyze();
                this.Form.Show(frm);
            }
        }
        /// <summary>
        /// 安全库存统计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ibSafeQuant_Press(object sender, EventArgs e)
        {
            frmSafeQuantAnalyze frm = new frmSafeQuantAnalyze();
            this.Form.Show(frm);
        }
        /// <summary>
        /// 资产有效期分析
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ibExpiry_Press(object sender, EventArgs e)
        {
            frmImminentExpiryAss frm = new frmImminentExpiryAss();
            this.Form.Show(frm);
        }
        /// <summary>
        /// 采购统计        
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ibPurQuant_Press(object sender, EventArgs e)
        {
            if (type == 0)
            {
                frmAssPOAnalysis frmAss = new frmAssPOAnalysis();
               this.Form.Show(frmAss);
            }
            else
            {
                frmPurchaseAnalyze frm = new frmPurchaseAnalyze();
                this.Form.Show(frm);
            }
        }
        /// <summary>
        /// 供货商统计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ibVendor_Press(object sender, EventArgs e)
        {
            if (type == 0)
            {
                frmAssVenAnalysis frmAss = new frmAssVenAnalysis();
                this.Form.Show(frmAss);
            }
            else
            {
                frmVendorAnalyze frm = new frmVendorAnalyze();
                this.Form.Show(frm);
            }
        }
        /// <summary>
        /// 销售统计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ibSaleQuant_Press(object sender, EventArgs e)
        {
            if (type == 0)
            {
                frmAssSOAnalysis frmAss = new frmAssSOAnalysis();
                this.Form.Show(frmAss);
            }
            else
            {
                frmSaleAnalyze frm = new frmSaleAnalyze();
                this.Form.Show(frm);
            }
        }
        /// <summary>
        /// 客户统计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ibCustomer_Press(object sender, EventArgs e)
        {
            if (type == 0)
            {
                frmAssCusAnalysis frmAss = new frmAssCusAnalysis();
                this.Form.Show(frmAss);
            }
            else
            {
                frmCustomerAnalyze frm = new frmCustomerAnalyze();
                this.Form.Show(frm);
            }
        }

        private void frmAnalyzeLayout_Load(object sender, EventArgs e)
        {

        }
    }
}