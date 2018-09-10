using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.UI.Analyze.Consumable;
using SMOWMS.UI.AssetsManager;
using SMOWMS.UI.Analyze.Assets;

namespace SMOWMS.UI.Menu
{
    partial class frmAnalyze : Smobiler.Core.Controls.MobileForm
    {
        public frmAnalyze() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        internal int type = 0;   // 0-资产,1-耗材
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAnalyse_Load(object sender, EventArgs e)
        {
            // 设置菜单栏默认选中项
            menuToolbar.SelectedIndex = 3;
        }
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
        /// 手机自带返回键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAnalyse_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
                Client.Exit();
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
                Show(frmAss);
            }
            else
            {
                frmQuantAnalyze frm = new frmQuantAnalyze();
                Show(frm);
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
            Show(frm);
        }
        /// <summary>
        /// 采购统计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ibPurQuant_Press(object sender, EventArgs e)
        {
            if (type == 0)
            {
                frmAssPOAnalysis frmAss = new frmAssPOAnalysis();
                Show(frmAss);
            }
            else
            {
                frmPurchaseAnalyze frm = new frmPurchaseAnalyze();
                Show(frm);
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
                Show(frmAss);
            }
            else
            {
                frmVendorAnalyze frm = new frmVendorAnalyze();
                Show(frm);
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
                frmAssSOAnalysis  frmAss= new frmAssSOAnalysis();
                Show(frmAss);
            }
            else
            {
                frmSaleAnalyze frm = new frmSaleAnalyze();
                Show(frm);
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
                Show(frmAss);
            }
            else
            {
                frmCustomerAnalyze frm = new frmCustomerAnalyze();
                Show(frm);
            }
        }
        /// <summary>
        /// 资产有效期分析
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ibExpiry_Press(object sender, EventArgs e)
        {
            frmImminentExpiryAss frm = new frmImminentExpiryAss();
            Show(frm);
        }
    }
}