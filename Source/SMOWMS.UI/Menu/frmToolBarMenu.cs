using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.UI.UserControl;
using SMOWMS.UI.AssetsManager;
using SMOWMS.UI.ConsumablesManager;
namespace SMOWMS.UI.Menu
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmToolBarMenu : Smobiler.Core.Controls.MobileForm
    {
        public frmToolBarMenu() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }

        private void toolBar_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            if (toolBar.SelectedIndex != tabPageView1.PageIndex)
            {
                switch (e.Name)
                {
                    case "仓库":
                        tabPageView1.PageIndex = 0;
                        break;
                    case "订单":
                        tabPageView1.PageIndex = 1;
                        break;
                    case "主数据":
                        tabPageView1.PageIndex = 2;
                        break;
                    case "统计":
                        tabPageView1.PageIndex = 3;
                        break;
                    case "设置":
                        tabPageView1.PageIndex = 4;
                        break;
                }

            }
            if (tabPageView1.PageIndex == 1)
            {
                this.ActionButton.Enabled = true;
            }
            else
            {
                this.ActionButton.Enabled = false;
            }

        }

        private void tabPageView1_PageIndexChanged(object sender, EventArgs e)
        {
            toolBar.SelectedIndex = tabPageView1.PageIndex;
        }

        private void frmToolBarMenu_Load(object sender, EventArgs e)
        {

            tabPageView1.Controls.Add(new frmMenuLayout() { Dock = System.Windows.Forms.DockStyle.Fill });
            tabPageView1.Controls.Add(new frmOrderLayout() { Dock = System.Windows.Forms.DockStyle.Fill });
            tabPageView1.Controls.Add(new frmMasterDataLayout() { Dock = System.Windows.Forms.DockStyle.Fill });
            tabPageView1.Controls.Add(new frmAnalyzeLayout() { Dock = System.Windows.Forms.DockStyle.Fill });
            tabPageView1.Controls.Add(new frmMessageLayout() { Dock = System.Windows.Forms.DockStyle.Fill });
            toolBar.SelectedIndex = 0;
        }

        private void frmToolBarMenu_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
                Client.Exit();
        }

        private void frmToolBarMenu_ActionButtonPress(object sender, ActionButtonPressEventArgs e)
        {
            frmOrderLayout ly = (frmOrderLayout)tabPageView1.Controls[1];
            //  int i = ly.type;
            int type = ly.type;
            int orderType = ly.orderType;
            switch (e.Index)
            {
                case 0:       //资产采购创建
                    frmAssPurchaseOrderCreate frmAssPurchaseOrderCreate = new frmAssPurchaseOrderCreate();
                    Show(frmAssPurchaseOrderCreate, (MobileForm senderAP, object args) =>
                    {
                        ly.Bind(type, orderType);
                    });
                    break;
                case 1:      //资产销售创建
                    frmAssSalesOrderCreate frmAssSalesOrderCreate = new frmAssSalesOrderCreate();
                    Show(frmAssSalesOrderCreate, (MobileForm senderAS, object args) =>
                    {
                        ly.Bind(type, orderType);
                    });
                    break;
                case 2:      //耗材采购创建
                    frmConPurchaseCreate frmConPurchaseCreate = new frmConPurchaseCreate();
                    Show(frmConPurchaseCreate, (MobileForm senderCP, object args) =>
                    {
                        ly.Bind(type, orderType);
                    });
                    break;
                case 3:      //耗材销售创建
                    frmConSalesCreate frmConSalesCreate = new frmConSalesCreate();
                    Show(frmConSalesCreate, (MobileForm senderCS, object args) =>
                    {
                        ly.Bind(type, orderType);
                    });
                    break;
            }
        }

    }
}