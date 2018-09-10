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
            Smobiler.Core.Controls.ActionButtonItem actionButtonItem1 = new Smobiler.Core.Controls.ActionButtonItem();
            Smobiler.Core.Controls.ActionButtonItem actionButtonItem2 = new Smobiler.Core.Controls.ActionButtonItem();
            this.plContent = new Smobiler.Core.Controls.Panel();
            this.Label8 = new Smobiler.Core.Controls.Label();
            this.txtName = new Smobiler.Core.Controls.TextBox();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.txtHandleMan = new Smobiler.Core.Controls.TextBox();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.txtCount = new Smobiler.Core.Controls.TextBox();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.txtWare = new Smobiler.Core.Controls.TextBox();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.txtST = new Smobiler.Core.Controls.TextBox();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.txtType = new Smobiler.Core.Controls.TextBox();
            this.label12 = new Smobiler.Core.Controls.Label();
            this.txtSL = new Smobiler.Core.Controls.TextBox();
            this.image2 = new Smobiler.Core.Controls.Image();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.barcodeScanner1 = new Smobiler.Core.Controls.BarcodeScanner();
            this.image1 = new Smobiler.Core.Controls.Image();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.image3 = new Smobiler.Core.Controls.Image();
            this.label9 = new Smobiler.Core.Controls.Label();
            this.image4 = new Smobiler.Core.Controls.Image();
            this.label10 = new Smobiler.Core.Controls.Label();
            this.Title1 = new SMOWMS.UI.UserControl.Title();
            this.plButton = new Smobiler.Core.Controls.Panel();
            this.panelScan = new Smobiler.Core.Controls.Panel();
            this.image5 = new Smobiler.Core.Controls.Image();
            this.label11 = new Smobiler.Core.Controls.Label();
            this.tabPageView1 = new Smobiler.Core.Controls.TabPageView();
            this.r2000Scanner1 = new Smobiler.Device.R2000Scanner();
            // 
            // plContent
            // 
            this.plContent.BackColor = System.Drawing.Color.White;
            this.plContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label8,
            this.txtName,
            this.label1,
            this.txtHandleMan,
            this.label2,
            this.txtCount,
            this.label3,
            this.txtWare,
            this.label4,
            this.txtST,
            this.label5,
            this.txtType,
            this.label12,
            this.txtSL});
            this.plContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.plContent.Location = new System.Drawing.Point(0, 40);
            this.plContent.Name = "plContent";
            this.plContent.Size = new System.Drawing.Size(300, 210);
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.White;
            this.Label8.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.Label8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label8.Name = "Label8";
            this.Label8.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label8.Size = new System.Drawing.Size(100, 30);
            this.Label8.Text = "盘点表";
            // 
            // txtName
            // 
            this.txtName.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtName.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtName.Location = new System.Drawing.Point(100, 0);
            this.txtName.Name = "txtName";
            this.txtName.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(200, 30);
            this.txtName.WaterMarkText = "(选填)";
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
            // txtHandleMan
            // 
            this.txtHandleMan.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.txtHandleMan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtHandleMan.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtHandleMan.Location = new System.Drawing.Point(100, 30);
            this.txtHandleMan.Name = "txtHandleMan";
            this.txtHandleMan.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtHandleMan.ReadOnly = true;
            this.txtHandleMan.Size = new System.Drawing.Size(200, 30);
            this.txtHandleMan.WaterMarkText = "(选填)";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label2.Location = new System.Drawing.Point(0, 180);
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.Text = "需盘点总数";
            // 
            // txtCount
            // 
            this.txtCount.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.txtCount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtCount.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtCount.Location = new System.Drawing.Point(100, 180);
            this.txtCount.Name = "txtCount";
            this.txtCount.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtCount.ReadOnly = true;
            this.txtCount.Size = new System.Drawing.Size(200, 30);
            this.txtCount.WaterMarkText = "(选填)";
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
            // txtWare
            // 
            this.txtWare.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.txtWare.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtWare.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtWare.Location = new System.Drawing.Point(100, 60);
            this.txtWare.Name = "txtWare";
            this.txtWare.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtWare.ReadOnly = true;
            this.txtWare.Size = new System.Drawing.Size(200, 30);
            this.txtWare.WaterMarkText = "(选填)";
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
            // txtST
            // 
            this.txtST.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.txtST.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtST.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtST.Location = new System.Drawing.Point(100, 90);
            this.txtST.Name = "txtST";
            this.txtST.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtST.ReadOnly = true;
            this.txtST.Size = new System.Drawing.Size(200, 30);
            this.txtST.WaterMarkText = "(选填)";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label5.Location = new System.Drawing.Point(0, 120);
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label5.Size = new System.Drawing.Size(100, 30);
            this.label5.Text = "库位";
            // 
            // txtType
            // 
            this.txtType.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.txtType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtType.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtType.Location = new System.Drawing.Point(100, 150);
            this.txtType.Name = "txtType";
            this.txtType.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(200, 30);
            this.txtType.WaterMarkText = "(选填)";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label12.Location = new System.Drawing.Point(0, 150);
            this.label12.Name = "label12";
            this.label12.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label12.Size = new System.Drawing.Size(100, 30);
            this.label12.Text = "资产类型";
            // 
            // txtSL
            // 
            this.txtSL.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.txtSL.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtSL.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtSL.Location = new System.Drawing.Point(100, 120);
            this.txtSL.Name = "txtSL";
            this.txtSL.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtSL.ReadOnly = true;
            this.txtSL.Size = new System.Drawing.Size(200, 30);
            this.txtSL.WaterMarkText = "(选填)";
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
            // Title1
            // 
            this.Title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.Title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title1.FontSize = 15F;
            this.Title1.ForeColor = System.Drawing.Color.White;
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(300, 40);
            this.Title1.TitleText = "资产盘点";
            // 
            // plButton
            // 
            this.plButton.BackColor = System.Drawing.Color.White;
            this.plButton.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plButton.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panelScan});
            this.plButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.plButton.Location = new System.Drawing.Point(0, 279);
            this.plButton.Name = "plButton";
            this.plButton.Size = new System.Drawing.Size(300, 28);
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
            // r2000Scanner1
            // 
            this.r2000Scanner1.Name = "r2000Scanner1";
            this.r2000Scanner1.BarcodeDataCaptured += new Smobiler.Device.R2000BarcodeScanEventHandler(this.r2000Scanner1_BarcodeDataCaptured);
            this.r2000Scanner1.RFIDDataCaptured += new Smobiler.Device.R2000RFIDScanEventHandler(this.r2000Scanner1_RFIDDataCaptured);
            // 
            // frmAssInventoryResult
            // 
            this.ActionButton.ButtonSpacing = 12;
            this.ActionButton.Enabled = true;
            actionButtonItem1.ImageType = Smobiler.Core.Controls.ActionButtonImageType.Text;
            actionButtonItem1.Text = "上传结果";
            actionButtonItem2.ImageType = Smobiler.Core.Controls.ActionButtonImageType.Text;
            actionButtonItem2.Text = "盘点结束";
            this.ActionButton.Items.AddRange(new Smobiler.Core.Controls.ActionButtonItem[] {
            actionButtonItem1,
            actionButtonItem2});
            this.ActionButton.ItemSize = 45;
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.barcodeScanner1,
            this.r2000Scanner1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Title1,
            this.plContent,
            this.plButton,
            this.tabPageView1});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmAssInventoryResult_KeyDown);
            this.ActionButtonPress += new Smobiler.Core.Controls.ActionButtonPressEventHandler(this.frmAssInventoryResult_ActionButtonPress);
            this.Load += new System.EventHandler(this.frmAssInventoryResult_Load);
            this.Name = "frmAssInventoryResult";

        }
        #endregion

        private UserControl.Title Title1;
        private Smobiler.Core.Controls.Panel plContent;
        internal Smobiler.Core.Controls.Label Label8;
        internal Smobiler.Core.Controls.TextBox txtName;
        internal Smobiler.Core.Controls.Label label1;
        internal Smobiler.Core.Controls.TextBox txtHandleMan;
        internal Smobiler.Core.Controls.Label label2;
        internal Smobiler.Core.Controls.TextBox txtCount;
        private Smobiler.Core.Controls.BarcodeScanner barcodeScanner1;
        internal Smobiler.Core.Controls.Label label3;
        internal Smobiler.Core.Controls.TextBox txtWare;
        internal Smobiler.Core.Controls.Label label4;
        internal Smobiler.Core.Controls.TextBox txtST;
        internal Smobiler.Core.Controls.Label label5;
        internal Smobiler.Core.Controls.TextBox txtType;
        private Smobiler.Core.Controls.Image image2;
        private Smobiler.Core.Controls.Label label6;
        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Label label7;
        private Smobiler.Core.Controls.Image image3;
        private Smobiler.Core.Controls.Label label9;
        private Smobiler.Core.Controls.Image image4;
        private Smobiler.Core.Controls.Label label10;
        private Smobiler.Core.Controls.Panel plButton;
        internal Smobiler.Core.Controls.Panel panelScan;
        private Smobiler.Core.Controls.Image image5;
        private Smobiler.Core.Controls.Label label11;
        private Smobiler.Core.Controls.TabPageView tabPageView1;
        private Smobiler.Device.R2000Scanner r2000Scanner1;
        internal Smobiler.Core.Controls.Label label12;
        internal Smobiler.Core.Controls.TextBox txtSL;
    }
}