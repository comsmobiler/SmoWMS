using System;
using Smobiler.Core;
namespace SMOWMS.UI.UserControl
{
    partial class MenuToolbar : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        //SmobilerUserControl overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        //NOTE: The following procedure is required by the SmobilerUserControl
        //It can be modified using the SmobilerUserControl.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            Smobiler.Core.Controls.ToolBarItem toolBarItem1 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem2 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem3 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem4 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem5 = new Smobiler.Core.Controls.ToolBarItem();
            this.toolBar = new Smobiler.Core.Controls.ToolBar();
            // 
            // toolBar
            // 
            this.toolBar.BackColor = System.Drawing.Color.White;
            this.toolBar.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.toolBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.toolBar.ItemCount = 5;
            toolBarItem1.IconID = "cangku";
            toolBarItem1.Name = "仓库";
            toolBarItem1.SelectIconID = "cangku_sel";
            toolBarItem1.Text = "仓库";
            toolBarItem2.IconID = "dingdan";
            toolBarItem2.Name = "订单";
            toolBarItem2.SelectIconID = "dingdan_sel";
            toolBarItem2.Text = "订单";
            toolBarItem3.IconID = "shuju";
            toolBarItem3.Name = "主数据";
            toolBarItem3.SelectIconID = "shuju_sel";
            toolBarItem3.Text = "主数据";
            toolBarItem4.IconID = "tongji";
            toolBarItem4.Name = "统计";
            toolBarItem4.SelectIconID = "tongji_sel";
            toolBarItem4.Text = "统计";
            toolBarItem5.IconID = "shezhi";
            toolBarItem5.Name = "设置";
            toolBarItem5.SelectIconID = "shezhi_sel";
            toolBarItem5.Text = "设置";
            this.toolBar.Items.AddRange(new Smobiler.Core.Controls.ToolBarItem[] {
            toolBarItem1,
            toolBarItem2,
            toolBarItem3,
            toolBarItem4,
            toolBarItem5});
            this.toolBar.Location = new System.Drawing.Point(114, 25);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(100, 50);
            this.toolBar.ToolbarItemClick += new Smobiler.Core.Controls.ToolbarItemClickEventHandler(this.toolBar_ToolbarItemClick);
            // 
            // MenuToolbar
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.toolBar});
            this.Size = new System.Drawing.Size(0, 50);
            this.Name = "MenuToolbar";

        }
        #endregion

        private Smobiler.Core.Controls.ToolBar toolBar;
    }
}