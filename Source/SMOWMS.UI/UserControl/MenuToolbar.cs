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
        [Browsable(false), Category("Appearance"), DefaultValue(""), Description("当前选中项的name")]
        public string selectName
        {
            set; get;
        }
        /// <summary>
        /// 菜单点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolBar_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            selectName = e.Name;
            switch (this.Form.Name)
            {
                case "frmMenu":
                    showForm(e.Name);
                    break;
                case "frmOrder":
                    if (e.Name != "订单") this.Form.Close();
                    break;
                case "frmMasterData":
                    if (e.Name != "主数据") this.Form.Close();
                    break;
                case "frmAnalyze":
                    if (e.Name != "统计") this.Form.Close();
                    break;
                case "frmMessage":
                    if (e.Name != "设置") this.Form.Close();
                    break;
            }


        }
        private void showForm(string ename)
        {
            switch (ename)
            {
                case "仓库":
                    // frmMenu frmMenu = new frmMenu();
                    //this.Form.Show(frmMenu, (obj, arg) =>
                    //{
                    //    showForm(frmMenu.menuToolbar.selectName);
                    //});
                    //Form.Close();
                    //this.Form.Show(frmMenu);
                    break;
                case "订单":
                    frmOrder frmOrder = new frmOrder();
                    this.Form.Show(frmOrder, (obj, arg) =>
                    {
                        showForm(frmOrder.menuToolbar.selectName);
                    });
                    //Form.Close();
                    //this.Form.Show(frmOrder);
                    break;
                case "主数据":
                    frmMasterData frmMasterData = new frmMasterData();
                    this.Form.Show(frmMasterData, (obj, arg) =>
                    {
                        showForm(frmMasterData.menuToolbar.selectName);
                    });
                    //Form.Close();
                    //this.Form.Show(frmMasterData);
                    break;
                case "统计":
                    frmAnalyze frmAnalyse = new frmAnalyze();
                    this.Form.Show(frmAnalyse, (obj, arg) =>
                    {
                        showForm(frmAnalyse.menuToolbar.selectName);
                    });
                    //Form.Close();
                    //this.Form.Show(frmAnalyse);
                    break;
                case "设置":
                    frmMessage frmMessage = new frmMessage();
                    this.Form.Show(frmMessage, (obj, arg) =>
                    {
                        showForm(frmMessage.menuToolbar.selectName);
                    });
                    //Form.Close();
                    //this.Form.Show(frmMessage);
                    break;
            }
        }
    }
}