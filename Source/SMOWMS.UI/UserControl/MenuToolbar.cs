using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.UI.Menu;
using System.ComponentModel;
using SMOWMS.UI.UserInfo;

namespace SMOWMS.UI.UserControl
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    [System.ComponentModel.ToolboxItem(true)]
    partial class MenuToolbar : Smobiler.Core.Controls.MobileUserControl
    {
        public MenuToolbar() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
        /// <summary>
        /// 当前选中项
        /// </summary>
        [Browsable(false), Category("Appearance"), DefaultValue(""), Description("当前选中项")]
        public int SelectedIndex
        {
            get
            {
                return toolBar.SelectedIndex;
            }
            set
            {
                toolBar.SelectedIndex = value;
            }
        }
        /// <summary>
        /// 菜单点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolBar_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            switch (e.Name)
            {
                case "仓库":
                    frmMenu frmMenu = new frmMenu();
                    Form.Close();
                    this.Form.Show(frmMenu);
                    break;
                case "订单":
                    frmOrder frmOrder = new frmOrder();
                    Form.Close();
                    this.Form.Show(frmOrder);
                    break;
                case "主数据":
                    frmMasterData frmMasterData = new frmMasterData();
                    Form.Close();
                    this.Form.Show(frmMasterData);
                    break;
                case "统计":
                    frmAnalyze frmAnalyse = new frmAnalyze();
                    Form.Close();
                    this.Form.Show(frmAnalyse);
                    break;
                case "设置":
                    frmMessage frmMessage = new frmMessage();
                    Form.Close();
                    this.Form.Show(frmMessage);
                    break;
            }
        }
    }
}