using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.DTOs.OutputDTO;
using SMOWMS.UI.Layout;

namespace SMOWMS.UI.Analyze.Consumable
{
    partial class frmSafeQuantAnalyze : Smobiler.Core.Controls.MobileForm
    {
        public frmSafeQuantAnalyze() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        #region 变量
        private AutofacConfig autofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSafeQuantAnalyze_Load(object sender, EventArgs e)
        {
            List<ConOutputDto> conSafeQuantlist = autofacConfig.consumablesService.GetSafeQuantAnalyse();
            if (conSafeQuantlist.Count > 0)
            {
                lvSafeQuant.DataSource = conSafeQuantlist;
                lvSafeQuant.DataBind();
            }
            foreach(ListViewRow row in lvSafeQuant.Rows)
            {
                frmSafeQuantAnalyzeLayout Layout = row.Control as frmSafeQuantAnalyzeLayout;
                if(Convert.ToDecimal( Layout.lblQuantity.BindDataValue)<Convert.ToDecimal(Layout.lblSafe.BindDataValue))
                {
                    Layout.lblQuantity.ForeColor = System.Drawing.Color.Red;
                }
            }
        }
    }
}