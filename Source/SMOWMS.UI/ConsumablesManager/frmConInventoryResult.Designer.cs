using System;
using Smobiler.Core;
namespace SMOWMS.UI.ConsumablesManager
{
    partial class frmConInventoryResult : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmConInventoryResult()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            Smobiler.Core.Controls.ActionButtonItem actionButtonItem1 = new Smobiler.Core.Controls.ActionButtonItem();
            Smobiler.Core.Controls.ActionButtonItem actionButtonItem2 = new Smobiler.Core.Controls.ActionButtonItem();
            this.Title1 = new SMOWMS.UI.UserControl.Title();
            this.plContent = new Smobiler.Core.Controls.Panel();
            this.Label8 = new Smobiler.Core.Controls.Label();
            this.lblName = new Smobiler.Core.Controls.Label();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.lblHandleMan = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.lblWareHouse = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.lblST = new Smobiler.Core.Controls.Label();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.lblSL = new Smobiler.Core.Controls.Label();
            this.lblCount = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.panelScan = new Smobiler.Core.Controls.Panel();
            this.image5 = new Smobiler.Core.Controls.Image();
            this.label11 = new Smobiler.Core.Controls.Label();
            this.tabPageView1 = new Smobiler.Core.Controls.TabPageView();
            this.bsSL = new Smobiler.Core.Controls.BarcodeScanner();
            // 
            // Title1
            // 
            this.Title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.Title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title1.FontSize = 15F;
            this.Title1.ForeColor = System.Drawing.Color.White;
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(300, 40);
            this.Title1.TitleText = "耗材盘点";
            // 
            // plContent
            // 
            this.plContent.BackColor = System.Drawing.Color.White;
            this.plContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label8,
            this.lblName,
            this.label1,
            this.lblHandleMan,
            this.label3,
            this.lblWareHouse,
            this.label4,
            this.lblST,
            this.label6,
            this.lblSL,
            this.lblCount,
            this.label2});
            this.plContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.plContent.Location = new System.Drawing.Point(0, 40);
            this.plContent.Name = "plContent";
            this.plContent.Size = new System.Drawing.Size(300, 180);
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.White;
            this.Label8.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.Label8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label8.Name = "Label8";
            this.Label8.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label8.Size = new System.Drawing.Size(100, 30);
            this.Label8.Text = "盘点名称";
            // 
            // lblName
            // 
            this.lblName.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.lblName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblName.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblName.Location = new System.Drawing.Point(100, 0);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.lblName.Size = new System.Drawing.Size(200, 30);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label1.Location = new System.Drawing.Point(0, 30);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.Text = "盘点人";
            // 
            // lblHandleMan
            // 
            this.lblHandleMan.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.lblHandleMan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblHandleMan.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblHandleMan.Location = new System.Drawing.Point(100, 30);
            this.lblHandleMan.Name = "lblHandleMan";
            this.lblHandleMan.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.lblHandleMan.Size = new System.Drawing.Size(200, 30);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label3.Location = new System.Drawing.Point(0, 60);
            this.label3.Name = "label3";
            this.label3.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label3.Size = new System.Drawing.Size(100, 30);
            this.label3.Text = "仓库";
            // 
            // lblWareHouse
            // 
            this.lblWareHouse.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.lblWareHouse.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblWareHouse.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblWareHouse.Location = new System.Drawing.Point(100, 60);
            this.lblWareHouse.Name = "lblWareHouse";
            this.lblWareHouse.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.lblWareHouse.Size = new System.Drawing.Size(200, 30);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label4.Location = new System.Drawing.Point(0, 90);
            this.label4.Name = "label4";
            this.label4.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label4.Size = new System.Drawing.Size(100, 30);
            this.label4.Text = "存储类型";
            // 
            // lblST
            // 
            this.lblST.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.lblST.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblST.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblST.Location = new System.Drawing.Point(100, 90);
            this.lblST.Name = "lblST";
            this.lblST.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.lblST.Size = new System.Drawing.Size(200, 30);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label6.Location = new System.Drawing.Point(0, 120);
            this.label6.Name = "label6";
            this.label6.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label6.Size = new System.Drawing.Size(100, 30);
            this.label6.Text = "库位";
            // 
            // lblSL
            // 
            this.lblSL.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.lblSL.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblSL.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblSL.Location = new System.Drawing.Point(100, 120);
            this.lblSL.Name = "lblSL";
            this.lblSL.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.lblSL.Size = new System.Drawing.Size(200, 30);
            // 
            // lblCount
            // 
            this.lblCount.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.lblCount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblCount.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblCount.Location = new System.Drawing.Point(100, 150);
            this.lblCount.Name = "lblCount";
            this.lblCount.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.lblCount.Size = new System.Drawing.Size(200, 30);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label2.Location = new System.Drawing.Point(0, 150);
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.Text = "需盘点种数";
            // 
            // panelScan
            // 
            this.panelScan.BackColor = System.Drawing.Color.White;
            this.panelScan.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.panelScan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panelScan.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image5,
            this.label11});
            this.panelScan.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelScan.Location = new System.Drawing.Point(5, 0);
            this.panelScan.Name = "panelScan";
            this.panelScan.Size = new System.Drawing.Size(124, 28);
            this.panelScan.Touchable = true;
            this.panelScan.Press += new System.EventHandler(this.panelScan_Press);
            // 
            // image5
            // 
            this.image5.Location = new System.Drawing.Point(1, 1);
            this.image5.Name = "image5";
            this.image5.ResourceID = "scan";
            this.image5.Size = new System.Drawing.Size(30, 26);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(38, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 25);
            this.label11.Text = "扫码添加";
            // 
            // tabPageView1
            // 
            this.tabPageView1.BackColor = System.Drawing.Color.White;
            this.tabPageView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPageView1.Location = new System.Drawing.Point(0, 248);
            this.tabPageView1.Name = "tabPageView1";
            this.tabPageView1.PageIndicator = Smobiler.Core.Controls.TabPageIndicator.Title;
            this.tabPageView1.Size = new System.Drawing.Size(300, 252);
            this.tabPageView1.Titles = new string[] {
        "待盘点",
        "已盘点"};
            this.tabPageView1.TitleStyle = new Smobiler.Core.Controls.TabPageViewTitleStyle(System.Drawing.Color.White, System.Drawing.Color.Black, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), 13F, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), 2);
            // 
            // bsSL
            // 
            this.bsSL.Name = "bsSL";
            this.bsSL.BarcodeScanned += new Smobiler.Core.Controls.BarcodeScannerCallBackHandler(this.barcodeScanner1_BarcodeScanned);
            // 
            // frmConInventoryResult
            // 
            this.ActionButton.Enabled = true;
            actionButtonItem1.ImageType = Smobiler.Core.Controls.ActionButtonImageType.Text;
            actionButtonItem1.Text = "上传结果";
            actionButtonItem2.ImageType = Smobiler.Core.Controls.ActionButtonImageType.Text;
            actionButtonItem2.Text = "盘点结束";
            this.ActionButton.Items.AddRange(new Smobiler.Core.Controls.ActionButtonItem[] {
            actionButtonItem1,
            actionButtonItem2});
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.bsSL});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Title1,
            this.plContent,
            this.panelScan,
            this.tabPageView1});
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229))))));
            this.ActionButtonPress += new Smobiler.Core.Controls.ActionButtonPressEventHandler(this.frmConInventoryResult_ActionButtonPress);
            this.Load += new System.EventHandler(this.frmConInventoryResult_Load);
            this.Name = "frmConInventoryResult";

        }
        #endregion

        private UserControl.Title Title1;
        private Smobiler.Core.Controls.Panel plContent;
        internal Smobiler.Core.Controls.Label Label8;
        internal Smobiler.Core.Controls.Label lblName;
        internal Smobiler.Core.Controls.Label label1;
        internal Smobiler.Core.Controls.Label lblHandleMan;
        internal Smobiler.Core.Controls.Panel panelScan;
        private Smobiler.Core.Controls.Image image5;
        private Smobiler.Core.Controls.Label label11;
        private Smobiler.Core.Controls.TabPageView tabPageView1;
        internal Smobiler.Core.Controls.Label label3;
        internal Smobiler.Core.Controls.Label lblWareHouse;
        private Smobiler.Core.Controls.BarcodeScanner bsSL;
        internal Smobiler.Core.Controls.Label label4;
        internal Smobiler.Core.Controls.Label lblST;
        internal Smobiler.Core.Controls.Label label6;
        internal Smobiler.Core.Controls.Label lblSL;
        internal Smobiler.Core.Controls.Label lblCount;
        internal Smobiler.Core.Controls.Label label2;
    }
}