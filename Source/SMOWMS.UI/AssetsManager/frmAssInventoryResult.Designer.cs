namespace SMOWMS.UI.AssetsManager
{
    partial class frmAssInventoryResult : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAssInventoryResult()
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
            this.plContent = new Smobiler.Core.Controls.Panel();
            this.txtName = new Smobiler.Core.Controls.TextBox();
            this.txtHandleMan = new Smobiler.Core.Controls.TextBox();
            this.txtCount = new Smobiler.Core.Controls.TextBox();
            this.txtWare = new Smobiler.Core.Controls.TextBox();
            this.txtST = new Smobiler.Core.Controls.TextBox();
            this.txtType = new Smobiler.Core.Controls.TextBox();
            this.txtSL = new Smobiler.Core.Controls.TextBox();
            this.imgUser = new Smobiler.Core.Controls.Image();
            this.image2 = new Smobiler.Core.Controls.Image();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.barcodeScanner1 = new Smobiler.Core.Controls.BarcodeScanner();
            this.image1 = new Smobiler.Core.Controls.Image();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.image3 = new Smobiler.Core.Controls.Image();
            this.label9 = new Smobiler.Core.Controls.Label();
            this.image4 = new Smobiler.Core.Controls.Image();
            this.label10 = new Smobiler.Core.Controls.Label();
            this.plScan = new Smobiler.Core.Controls.Panel();
            this.panelScan = new Smobiler.Core.Controls.Panel();
            this.image5 = new Smobiler.Core.Controls.Image();
            this.label11 = new Smobiler.Core.Controls.Label();
            this.tabPageView1 = new Smobiler.Core.Controls.TabPageView();
            this.r2000Scanner1 = new Smobiler.Device.R2000Scanner();
            this.plButton = new Smobiler.Core.Controls.Panel();
            this.ibStart = new Smobiler.Core.Controls.ImageButton();
            this.ibUpload = new Smobiler.Core.Controls.ImageButton();
            this.Title1 = new SMOWMS.UI.UserControl.Title();
            // 
            // plContent
            // 
            this.plContent.BackColor = System.Drawing.Color.White;
            this.plContent.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plContent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.txtName,
            this.txtHandleMan,
            this.txtCount,
            this.txtWare,
            this.txtST,
            this.txtType,
            this.txtSL,
            this.imgUser});
            this.plContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.plContent.Location = new System.Drawing.Point(0, 100);
            this.plContent.Name = "plContent";
            this.plContent.Size = new System.Drawing.Size(300, 136);
            // 
            // txtName
            // 
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtName.Location = new System.Drawing.Point(52, 9);
            this.txtName.Name = "txtName";
            this.txtName.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.WaterMarkText = "(选填)";
            // 
            // txtHandleMan
            // 
            this.txtHandleMan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtHandleMan.Location = new System.Drawing.Point(52, 30);
            this.txtHandleMan.Name = "txtHandleMan";
            this.txtHandleMan.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.txtHandleMan.ReadOnly = true;
            this.txtHandleMan.Size = new System.Drawing.Size(200, 16);
            this.txtHandleMan.WaterMarkText = "(选填)";
            // 
            // txtCount
            // 
            this.txtCount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtCount.Location = new System.Drawing.Point(52, 110);
            this.txtCount.Name = "txtCount";
            this.txtCount.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.txtCount.ReadOnly = true;
            this.txtCount.Size = new System.Drawing.Size(200, 16);
            this.txtCount.WaterMarkText = "(选填)";
            // 
            // txtWare
            // 
            this.txtWare.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtWare.Location = new System.Drawing.Point(52, 46);
            this.txtWare.Name = "txtWare";
            this.txtWare.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.txtWare.ReadOnly = true;
            this.txtWare.Size = new System.Drawing.Size(200, 16);
            this.txtWare.WaterMarkText = "(选填)";
            // 
            // txtST
            // 
            this.txtST.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtST.Location = new System.Drawing.Point(52, 62);
            this.txtST.Name = "txtST";
            this.txtST.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.txtST.ReadOnly = true;
            this.txtST.Size = new System.Drawing.Size(200, 16);
            this.txtST.WaterMarkText = "(选填)";
            // 
            // txtType
            // 
            this.txtType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtType.Location = new System.Drawing.Point(52, 94);
            this.txtType.Name = "txtType";
            this.txtType.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(200, 16);
            this.txtType.WaterMarkText = "(选填)";
            // 
            // txtSL
            // 
            this.txtSL.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtSL.Location = new System.Drawing.Point(52, 78);
            this.txtSL.Name = "txtSL";
            this.txtSL.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.txtSL.ReadOnly = true;
            this.txtSL.Size = new System.Drawing.Size(200, 16);
            this.txtSL.WaterMarkText = "(选填)";
            // 
            // imgUser
            // 
            this.imgUser.BorderRadius = 14;
            this.imgUser.Location = new System.Drawing.Point(12, 12);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(29, 29);
            this.imgUser.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            // 
            // image2
            // 
            this.image2.Location = new System.Drawing.Point(1, 1);
            this.image2.Name = "image2";
            this.image2.ResourceID = "scan";
            this.image2.Size = new System.Drawing.Size(30, 26);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(38, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.Text = "扫码添加";
            // 
            // barcodeScanner1
            // 
            this.barcodeScanner1.Name = "barcodeScanner1";
            this.barcodeScanner1.BarcodeScanned += new Smobiler.Core.Controls.BarcodeScannerCallBackHandler(this.barcodeScanner1_BarcodeScanned);
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(1, 1);
            this.image1.Name = "image1";
            this.image1.ResourceID = "scan";
            this.image1.Size = new System.Drawing.Size(30, 26);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(38, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 25);
            this.label7.Text = "扫码添加";
            // 
            // image3
            // 
            this.image3.Location = new System.Drawing.Point(1, 1);
            this.image3.Name = "image3";
            this.image3.ResourceID = "scan";
            this.image3.Size = new System.Drawing.Size(30, 26);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(38, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 25);
            this.label9.Text = "扫码添加";
            // 
            // image4
            // 
            this.image4.Location = new System.Drawing.Point(1, 1);
            this.image4.Name = "image4";
            this.image4.ResourceID = "scan";
            this.image4.Size = new System.Drawing.Size(30, 26);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(38, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 25);
            this.label10.Text = "扫码添加";
            // 
            // plScan
            // 
            this.plScan.BackColor = System.Drawing.Color.White;
            this.plScan.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plScan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plScan.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panelScan});
            this.plScan.Dock = System.Windows.Forms.DockStyle.Top;
            this.plScan.Location = new System.Drawing.Point(0, 279);
            this.plScan.Name = "plScan";
            this.plScan.Size = new System.Drawing.Size(300, 28);
            // 
            // panelScan
            // 
            this.panelScan.BackColor = System.Drawing.Color.White;
            this.panelScan.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.panelScan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panelScan.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image5,
            this.label11});
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
            this.tabPageView1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.tabPageView1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tabPageView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPageView1.Location = new System.Drawing.Point(0, 248);
            this.tabPageView1.Margin = new Smobiler.Core.Controls.Margin(0F, 12F, 0F, 0F);
            this.tabPageView1.Name = "tabPageView1";
            this.tabPageView1.PageIndicator = Smobiler.Core.Controls.TabPageIndicator.Title;
            this.tabPageView1.Size = new System.Drawing.Size(300, 252);
            this.tabPageView1.Titles = new string[] {
        "待盘点",
        "已盘点"};
            this.tabPageView1.TitleStyle = new Smobiler.Core.Controls.TabPageViewTitleStyle(System.Drawing.Color.White, System.Drawing.Color.Black, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), 13F, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), 2);
            // 
            // r2000Scanner1
            // 
            this.r2000Scanner1.Name = "r2000Scanner1";
            this.r2000Scanner1.BarcodeDataCaptured += new Smobiler.Device.R2000BarcodeScanEventHandler(this.r2000Scanner1_BarcodeDataCaptured);
            this.r2000Scanner1.RFIDDataCaptured += new Smobiler.Device.R2000RFIDScanEventHandler(this.r2000Scanner1_RFIDDataCaptured);
            // 
            // plButton
            // 
            this.plButton.BackColor = System.Drawing.Color.White;
            this.plButton.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plButton.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.ibStart,
            this.ibUpload});
            this.plButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.plButton.Location = new System.Drawing.Point(0, 278);
            this.plButton.Name = "plButton";
            this.plButton.Size = new System.Drawing.Size(300, 60);
            // 
            // ibStart
            // 
            this.ibStart.FontSize = 14F;
            this.ibStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(124)))), ((int)(((byte)(246)))));
            this.ibStart.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(124)))), ((int)(((byte)(246)))));
            this.ibStart.ImageDirection = Smobiler.Core.Controls.Direction.Left;
            this.ibStart.ImgTextRatio = new Smobiler.Core.Controls.Ratio(2, 8);
            this.ibStart.Location = new System.Drawing.Point(0, 12);
            this.ibStart.Name = "ibStart";
            this.ibStart.ResourceID = "48-start";
            this.ibStart.Size = new System.Drawing.Size(142, 36);
            this.ibStart.Press += new System.EventHandler(this.ibStart_Press);
            // 
            // ibUpload
            // 
            this.ibUpload.FontSize = 14F;
            this.ibUpload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(124)))), ((int)(((byte)(246)))));
            this.ibUpload.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(124)))), ((int)(((byte)(246)))));
            this.ibUpload.ImageDirection = Smobiler.Core.Controls.Direction.Left;
            this.ibUpload.ImgTextRatio = new Smobiler.Core.Controls.Ratio(2, 8);
            this.ibUpload.Location = new System.Drawing.Point(164, 12);
            this.ibUpload.Name = "ibUpload";
            this.ibUpload.ResourceID = "48-upload";
            this.ibUpload.Size = new System.Drawing.Size(142, 36);
            this.ibUpload.Text = "上传结果";
            this.ibUpload.Press += new System.EventHandler(this.ibUpload_Press);
            // 
            // Title1
            // 
            this.Title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(124)))), ((int)(((byte)(246)))));
            this.Title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title1.FontSize = 15F;
            this.Title1.ForeColor = System.Drawing.Color.White;
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(300, 40);
            this.Title1.TitleText = "资产盘点";
            // 
            // frmAssInventoryResult
            // 
            this.ActionButton.ButtonSpacing = 12;
            this.ActionButton.ItemSize = 45;
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.barcodeScanner1,
            this.r2000Scanner1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Title1,
            this.plButton,
            this.plContent,
            this.plScan,
            this.tabPageView1});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(124)))), ((int)(((byte)(246))))));
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmAssInventoryResult_KeyDown);
            this.Load += new System.EventHandler(this.frmAssInventoryResult_Load);
            this.Name = "frmAssInventoryResult";

        }
        #endregion

        private UserControl.Title Title1;
        private Smobiler.Core.Controls.Panel plContent;
        internal Smobiler.Core.Controls.TextBox txtName;
        internal Smobiler.Core.Controls.TextBox txtHandleMan;
        internal Smobiler.Core.Controls.TextBox txtCount;
        private Smobiler.Core.Controls.BarcodeScanner barcodeScanner1;
        internal Smobiler.Core.Controls.TextBox txtST;
        internal Smobiler.Core.Controls.TextBox txtType;
        private Smobiler.Core.Controls.Image image2;
        private Smobiler.Core.Controls.Label label6;
        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Label label7;
        private Smobiler.Core.Controls.Image image3;
        private Smobiler.Core.Controls.Label label9;
        private Smobiler.Core.Controls.Image image4;
        private Smobiler.Core.Controls.Label label10;
        private Smobiler.Core.Controls.Panel plScan;
        internal Smobiler.Core.Controls.Panel panelScan;
        private Smobiler.Core.Controls.Image image5;
        private Smobiler.Core.Controls.Label label11;
        private Smobiler.Core.Controls.TabPageView tabPageView1;
        private Smobiler.Device.R2000Scanner r2000Scanner1;
        internal Smobiler.Core.Controls.TextBox txtSL;
        private Smobiler.Core.Controls.Panel plButton;
        internal Smobiler.Core.Controls.ImageButton ibStart;
        private Smobiler.Core.Controls.Image imgUser;
        internal Smobiler.Core.Controls.ImageButton ibUpload;
        internal Smobiler.Core.Controls.TextBox txtWare;
    }
}