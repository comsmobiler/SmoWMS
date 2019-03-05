using System;
using Smobiler.Core;
namespace SMOWMS.UI.Menu
{
    partial class frmToolBarMenu : Smobiler.Core.Controls.MobileForm
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
            Smobiler.Core.Controls.ActionButtonItem actionButtonItem1 = new Smobiler.Core.Controls.ActionButtonItem();
            Smobiler.Core.Controls.ActionButtonItem actionButtonItem2 = new Smobiler.Core.Controls.ActionButtonItem();
            Smobiler.Core.Controls.ActionButtonItem actionButtonItem3 = new Smobiler.Core.Controls.ActionButtonItem();
            Smobiler.Core.Controls.ActionButtonItem actionButtonItem4 = new Smobiler.Core.Controls.ActionButtonItem();
            this.toolBar = new Smobiler.Core.Controls.ToolBar();
            this.tabPageView1 = new Smobiler.Core.Controls.TabPageView();
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
            // tabPageView1
            // 
            this.tabPageView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPageView1.Location = new System.Drawing.Point(80, 88);
            this.tabPageView1.Name = "tabPageView1";
            this.tabPageView1.ScrollEnabled = false;
            this.tabPageView1.Size = new System.Drawing.Size(300, 300);
            this.tabPageView1.PageIndexChanged += new System.EventHandler(this.tabPageView1_PageIndexChanged);
            // 
            // frmToolBarMenu
            // 
            actionButtonItem1.ImageType = Smobiler.Core.Controls.ActionButtonImageType.Text;
            actionButtonItem1.Text = "资产采购新增";
            actionButtonItem2.ImageType = Smobiler.Core.Controls.ActionButtonImageType.Text;
            actionButtonItem2.Text = "资产销售新增";
            actionButtonItem3.ImageType = Smobiler.Core.Controls.ActionButtonImageType.Text;
            actionButtonItem3.Text = "耗材采购新增";
            actionButtonItem4.ImageType = Smobiler.Core.Controls.ActionButtonImageType.Text;
            actionButtonItem4.Text = "耗材销售新增";
            this.ActionButton.Items.AddRange(new Smobiler.Core.Controls.ActionButtonItem[] {
            actionButtonItem1,
            actionButtonItem2,
            actionButtonItem3,
            actionButtonItem4});
            this.ActionButton.OffsetY = 50;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.toolBar,
            this.tabPageView1});
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229))))));
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmToolBarMenu_KeyDown);
            this.ActionButtonPress += new Smobiler.Core.Controls.ActionButtonPressEventHandler(this.frmToolBarMenu_ActionButtonPress);
            this.Load += new System.EventHandler(this.frmToolBarMenu_Load);
            this.Name = "frmToolBarMenu";

        }
        #endregion

        private Smobiler.Core.Controls.ToolBar toolBar;
        public Smobiler.Core.Controls.TabPageView tabPageView1;
    }
}