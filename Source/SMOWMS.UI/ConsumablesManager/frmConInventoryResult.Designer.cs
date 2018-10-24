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
            this.bsSL = new Smobiler.Core.Controls.BarcodeScanner();
            this.plTitle = new Smobiler.Core.Controls.Panel();
            this.plBack = new Smobiler.Core.Controls.Panel();
            this.Image1 = new Smobiler.Core.Controls.Image();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.plSave = new Smobiler.Core.Controls.Panel();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.plContent = new Smobiler.Core.Controls.Panel();
            this.plButton = new Smobiler.Core.Controls.Panel();
            this.plAction = new Smobiler.Core.Controls.Panel();
            this.imgAction = new Smobiler.Core.Controls.Image();
            this.lblAction = new Smobiler.Core.Controls.Label();
            this.plScan = new Smobiler.Core.Controls.Panel();
            this.image2 = new Smobiler.Core.Controls.Image();
            this.label8 = new Smobiler.Core.Controls.Label();
            this.plText = new Smobiler.Core.Controls.Panel();
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
            this.lblCreateManName = new Smobiler.Core.Controls.Label();
            this.tabPageView1 = new Smobiler.Core.Controls.TabPageView();
            // 
            // bsSL
            // 
            this.bsSL.Name = "bsSL";
            this.bsSL.BarcodeScanned += new Smobiler.Core.Controls.BarcodeScannerCallBackHandler(this.barcodeScanner1_BarcodeScanned);
            // 
            // plTitle
            // 
            this.plTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.plTitle.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plBack,
            this.label5,
            this.plSave});
            this.plTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTitle.Name = "plTitle";
            this.plTitle.Size = new System.Drawing.Size(300, 40);
            // 
            // plBack
            // 
            this.plBack.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Image1});
            this.plBack.Location = new System.Drawing.Point(10, 0);
            this.plBack.Name = "plBack";
            this.plBack.Size = new System.Drawing.Size(40, 40);
            this.plBack.Touchable = true;
            this.plBack.TouchOpacity = 100;
            this.plBack.Press += new System.EventHandler(this.plBack_Press);
            // 
            // Image1
            // 
            this.Image1.Name = "Image1";
            this.Image1.ResourceID = "back";
            this.Image1.Size = new System.Drawing.Size(40, 40);
            // 
            // label5
            // 
            this.label5.FontSize = 15F;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label5.Location = new System.Drawing.Point(50, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 40);
            this.label5.Text = "盘点单";
            // 
            // plSave
            // 
            this.plSave.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label7});
            this.plSave.Location = new System.Drawing.Point(250, 0);
            this.plSave.Name = "plSave";
            this.plSave.Size = new System.Drawing.Size(40, 40);
            this.plSave.Touchable = true;
            this.plSave.TouchOpacity = 100;
            this.plSave.Press += new System.EventHandler(this.plSave_Press);
            // 
            // label7
            // 
            this.label7.FontSize = 15F;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 40);
            this.label7.Text = "保存";
            // 
            // plContent
            // 
            this.plContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plButton,
            this.plText,
            this.tabPageView1});
            this.plContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plContent.Location = new System.Drawing.Point(0, 233);
            this.plContent.Name = "plContent";
            this.plContent.Size = new System.Drawing.Size(300, 100);
            // 
            // plButton
            // 
            this.plButton.BackColor = System.Drawing.Color.White;
            this.plButton.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plButton.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plAction,
            this.plScan});
            this.plButton.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.plButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.plButton.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.plButton.Location = new System.Drawing.Point(0, 270);
            this.plButton.Name = "plButton";
            this.plButton.Size = new System.Drawing.Size(300, 50);
            // 
            // plAction
            // 
            this.plAction.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imgAction,
            this.lblAction});
            this.plAction.Flex = 1;
            this.plAction.Name = "plAction";
            this.plAction.Size = new System.Drawing.Size(0, 0);
            this.plAction.Touchable = true;
            this.plAction.TouchOpacity = 100;
            this.plAction.Press += new System.EventHandler(this.plAction_Press);
            // 
            // imgAction
            // 
            this.imgAction.Location = new System.Drawing.Point(14, 12);
            this.imgAction.Name = "imgAction";
            this.imgAction.ResourceID = "icon-start";
            this.imgAction.Size = new System.Drawing.Size(25, 25);
            // 
            // lblAction
            // 
            this.lblAction.Location = new System.Drawing.Point(60, 12);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(90, 25);
            this.lblAction.Text = "开始盘点";
            // 
            // plScan
            // 
            this.plScan.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image2,
            this.label8});
            this.plScan.Flex = 1;
            this.plScan.Name = "plScan";
            this.plScan.Size = new System.Drawing.Size(0, 0);
            this.plScan.Touchable = true;
            this.plScan.TouchOpacity = 100;
            this.plScan.Press += new System.EventHandler(this.plScan_Press);
            // 
            // image2
            // 
            this.image2.Location = new System.Drawing.Point(14, 12);
            this.image2.Name = "image2";
            this.image2.ResourceID = "icon-scan";
            this.image2.Size = new System.Drawing.Size(25, 25);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(60, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 25);
            this.label8.Text = "耗材扫描";
            // 
            // plText
            // 
            this.plText.BackColor = System.Drawing.Color.White;
            this.plText.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
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
            this.label2,
            this.lblCreateManName});
            this.plText.Dock = System.Windows.Forms.DockStyle.Top;
            this.plText.Location = new System.Drawing.Point(0, 40);
            this.plText.Name = "plText";
            this.plText.Size = new System.Drawing.Size(300, 113);
            // 
            // lblName
            // 
            this.lblName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblName.Location = new System.Drawing.Point(50, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 18);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label1.FontSize = 11F;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.label1.Location = new System.Drawing.Point(50, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.Text = "盘点人:";
            // 
            // lblHandleMan
            // 
            this.lblHandleMan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblHandleMan.FontSize = 11F;
            this.lblHandleMan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.lblHandleMan.Location = new System.Drawing.Point(100, 30);
            this.lblHandleMan.Name = "lblHandleMan";
            this.lblHandleMan.Size = new System.Drawing.Size(51, 15);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label3.FontSize = 11F;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.label3.Location = new System.Drawing.Point(50, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.Text = "仓库:";
            // 
            // lblWareHouse
            // 
            this.lblWareHouse.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblWareHouse.FontSize = 11F;
            this.lblWareHouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.lblWareHouse.Location = new System.Drawing.Point(100, 45);
            this.lblWareHouse.Name = "lblWareHouse";
            this.lblWareHouse.Size = new System.Drawing.Size(51, 15);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label4.FontSize = 11F;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.label4.Location = new System.Drawing.Point(50, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.Text = "存储类型:";
            // 
            // lblST
            // 
            this.lblST.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblST.FontSize = 11F;
            this.lblST.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.lblST.Location = new System.Drawing.Point(100, 60);
            this.lblST.Name = "lblST";
            this.lblST.Size = new System.Drawing.Size(51, 15);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label6.FontSize = 11F;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.label6.Location = new System.Drawing.Point(50, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.Text = "库位:";
            // 
            // lblSL
            // 
            this.lblSL.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblSL.FontSize = 11F;
            this.lblSL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.lblSL.Location = new System.Drawing.Point(100, 75);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(51, 15);
            // 
            // lblCount
            // 
            this.lblCount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblCount.FontSize = 11F;
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.lblCount.Location = new System.Drawing.Point(110, 90);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(40, 15);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label2.FontSize = 11F;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.label2.Location = new System.Drawing.Point(50, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.Text = "需盘点种数:";
            // 
            // lblCreateManName
            // 
            this.lblCreateManName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(199)))), ((int)(((byte)(245)))));
            this.lblCreateManName.BorderRadius = 13;
            this.lblCreateManName.DataMember = "CREATEUSERNAME";
            this.lblCreateManName.DisplayMember = "CREATEUSERNAME";
            this.lblCreateManName.ForeColor = System.Drawing.Color.White;
            this.lblCreateManName.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lblCreateManName.Location = new System.Drawing.Point(14, 12);
            this.lblCreateManName.Name = "lblCreateManName";
            this.lblCreateManName.Size = new System.Drawing.Size(25, 26);
            // 
            // tabPageView1
            // 
            this.tabPageView1.BackColor = System.Drawing.Color.White;
            this.tabPageView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPageView1.Location = new System.Drawing.Point(0, 248);
            this.tabPageView1.Margin = new Smobiler.Core.Controls.Margin(0F, 10F, 0F, 0F);
            this.tabPageView1.Name = "tabPageView1";
            this.tabPageView1.PageIndicator = Smobiler.Core.Controls.TabPageIndicator.Title;
            this.tabPageView1.Size = new System.Drawing.Size(300, 252);
            this.tabPageView1.Titles = new string[] {
        "待盘点",
        "已盘点"};
            this.tabPageView1.TitleStyle = new Smobiler.Core.Controls.TabPageViewTitleStyle(System.Drawing.Color.White, System.Drawing.Color.Black, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), 13F, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), 2);
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
            this.plTitle,
            this.plContent});
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229))))));
            this.Load += new System.EventHandler(this.frmConInventoryResult_Load);
            this.Name = "frmConInventoryResult";

        }
        #endregion
        private Smobiler.Core.Controls.BarcodeScanner bsSL;
        internal Smobiler.Core.Controls.Panel plTitle;
        private Smobiler.Core.Controls.Panel plBack;
        internal Smobiler.Core.Controls.Image Image1;
        private Smobiler.Core.Controls.Label label5;
        private Smobiler.Core.Controls.Panel plSave;
        private Smobiler.Core.Controls.Label label7;
        private Smobiler.Core.Controls.Panel plContent;
        private Smobiler.Core.Controls.Panel plButton;
        private Smobiler.Core.Controls.Panel plAction;
        private Smobiler.Core.Controls.Image imgAction;
        private Smobiler.Core.Controls.Label lblAction;
        private Smobiler.Core.Controls.Panel plScan;
        private Smobiler.Core.Controls.Image image2;
        private Smobiler.Core.Controls.Label label8;
        private Smobiler.Core.Controls.Panel plText;
        internal Smobiler.Core.Controls.Label lblName;
        internal Smobiler.Core.Controls.Label label1;
        internal Smobiler.Core.Controls.Label lblHandleMan;
        internal Smobiler.Core.Controls.Label label3;
        internal Smobiler.Core.Controls.Label lblWareHouse;
        internal Smobiler.Core.Controls.Label label4;
        internal Smobiler.Core.Controls.Label lblST;
        internal Smobiler.Core.Controls.Label label6;
        internal Smobiler.Core.Controls.Label lblSL;
        internal Smobiler.Core.Controls.Label lblCount;
        internal Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label lblCreateManName;
        private Smobiler.Core.Controls.TabPageView tabPageView1;
    }
}