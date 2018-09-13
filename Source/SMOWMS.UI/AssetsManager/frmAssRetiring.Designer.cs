using System;
using Smobiler.Core;
namespace SMOWMS.UI.AssetsManager
{
    partial class frmAssRetiring : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAssRetiring()
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
            this.Title1 = new SMOWMS.UI.UserControl.Title();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.plButton = new Smobiler.Core.Controls.Panel();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.plContent = new Smobiler.Core.Controls.Panel();
            this.Label7 = new Smobiler.Core.Controls.Label();
            this.txtSOID = new Smobiler.Core.Controls.TextBox();
            this.ImgBtnForSOID = new Smobiler.Core.Controls.ImageButton();
            this.txtSLID = new Smobiler.Core.Controls.TextBox();
            this.ImgBtnForSLID = new Smobiler.Core.Controls.ImageButton();
            this.panelScan = new Smobiler.Core.Controls.Panel();
            this.image5 = new Smobiler.Core.Controls.Image();
            this.label11 = new Smobiler.Core.Controls.Label();
            this.lvSN = new Smobiler.Core.Controls.ListView();
            this.bcScanForSOID = new Smobiler.Core.Controls.BarcodeScanner();
            this.bcScanForSLID = new Smobiler.Core.Controls.BarcodeScanner();
            this.bcScanForSN = new Smobiler.Core.Controls.BarcodeScanner();
            this.r2000ScanForSN = new Smobiler.Device.R2000Scanner();
            // 
            // Title1
            // 
            this.Title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.Title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title1.FontSize = 15F;
            this.Title1.ForeColor = System.Drawing.Color.White;
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(300, 40);
            this.Title1.TitleText = "销售退库";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label3.Location = new System.Drawing.Point(0, 30);
            this.label3.Name = "label3";
            this.label3.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label3.Size = new System.Drawing.Size(100, 30);
            this.label3.Text = "库位";
            // 
            // plButton
            // 
            this.plButton.BackColor = System.Drawing.Color.White;
            this.plButton.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.plButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plButton.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.button1});
            this.plButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plButton.Location = new System.Drawing.Point(0, 468);
            this.plButton.Name = "plButton";
            this.plButton.Size = new System.Drawing.Size(300, 40);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 30);
            this.button1.Text = "确定";
            this.button1.Press += new System.EventHandler(this.btnSave_Press);
            // 
            // plContent
            // 
            this.plContent.BackColor = System.Drawing.Color.White;
            this.plContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label7,
            this.txtSOID,
            this.label3,
            this.ImgBtnForSOID,
            this.txtSLID,
            this.ImgBtnForSLID,
            this.panelScan});
            this.plContent.Flex = 3;
            this.plContent.Location = new System.Drawing.Point(0, 40);
            this.plContent.Name = "plContent";
            this.plContent.Size = new System.Drawing.Size(300, 90);
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.White;
            this.Label7.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label7.Name = "Label7";
            this.Label7.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label7.Size = new System.Drawing.Size(100, 30);
            this.Label7.Text = "销售单号";
            // 
            // txtSOID
            // 
            this.txtSOID.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtSOID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtSOID.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtSOID.Location = new System.Drawing.Point(100, 0);
            this.txtSOID.Name = "txtSOID";
            this.txtSOID.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtSOID.ReadOnly = true;
            this.txtSOID.Size = new System.Drawing.Size(170, 30);
            this.txtSOID.WaterMarkText = "（必填）";
            // 
            // ImgBtnForSOID
            // 
            this.ImgBtnForSOID.BackColor = System.Drawing.Color.White;
            this.ImgBtnForSOID.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.ImgBtnForSOID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ImgBtnForSOID.Location = new System.Drawing.Point(270, 0);
            this.ImgBtnForSOID.Name = "ImgBtnForSOID";
            this.ImgBtnForSOID.ResourceID = "scan";
            this.ImgBtnForSOID.Size = new System.Drawing.Size(30, 30);
            this.ImgBtnForSOID.Press += new System.EventHandler(this.ImgBtnForPOID_Press);
            // 
            // txtSLID
            // 
            this.txtSLID.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.txtSLID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtSLID.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtSLID.Location = new System.Drawing.Point(100, 30);
            this.txtSLID.Name = "txtSLID";
            this.txtSLID.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtSLID.ReadOnly = true;
            this.txtSLID.Size = new System.Drawing.Size(170, 30);
            this.txtSLID.WaterMarkText = "（必填）";
            // 
            // ImgBtnForSLID
            // 
            this.ImgBtnForSLID.BackColor = System.Drawing.Color.White;
            this.ImgBtnForSLID.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.ImgBtnForSLID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ImgBtnForSLID.Location = new System.Drawing.Point(270, 30);
            this.ImgBtnForSLID.Name = "ImgBtnForSLID";
            this.ImgBtnForSLID.ResourceID = "scan";
            this.ImgBtnForSLID.Size = new System.Drawing.Size(30, 30);
            this.ImgBtnForSLID.Press += new System.EventHandler(this.ImgBtnForSLID_Press);
            // 
            // panelScan
            // 
            this.panelScan.BackColor = System.Drawing.Color.White;
            this.panelScan.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.panelScan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panelScan.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image5,
            this.label11});
            this.panelScan.Location = new System.Drawing.Point(0, 60);
            this.panelScan.Name = "panelScan";
            this.panelScan.Size = new System.Drawing.Size(300, 28);
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
            // lvSN
            // 
            this.lvSN.BackColor = System.Drawing.Color.White;
            this.lvSN.Flex = 11;
            this.lvSN.Location = new System.Drawing.Point(0, 130);
            this.lvSN.Name = "lvSN";
            this.lvSN.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lvSN.PageSizeTextSize = 11F;
            this.lvSN.ShowSplitLine = true;
            this.lvSN.Size = new System.Drawing.Size(300, 330);
            this.lvSN.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lvSN.TemplateControlName = "SNRowLayout";
            // 
            // bcScanForSOID
            // 
            this.bcScanForSOID.Name = "bcScanForSOID";
            this.bcScanForSOID.BarcodeScanned += new Smobiler.Core.Controls.BarcodeScannerCallBackHandler(this.bcScanForPOID_BarcodeScanned);
            // 
            // bcScanForSLID
            // 
            this.bcScanForSLID.Name = "bcScanForSLID";
            this.bcScanForSLID.BarcodeScanned += new Smobiler.Core.Controls.BarcodeScannerCallBackHandler(this.bcScanForSLID_BarcodeScanned);
            // 
            // bcScanForSN
            // 
            this.bcScanForSN.Name = "bcScanForSN";
            this.bcScanForSN.BarcodeScanned += new Smobiler.Core.Controls.BarcodeScannerCallBackHandler(this.bcScanForSN_BarcodeScanned);
            // 
            // r2000ScanForSN
            // 
            this.r2000ScanForSN.Name = "r2000ScanForSN";
            this.r2000ScanForSN.BarcodeDataCaptured += new Smobiler.Device.R2000BarcodeScanEventHandler(this.r2000ScanForSN_BarcodeDataCaptured);
            this.r2000ScanForSN.RFIDDataCaptured += new Smobiler.Device.R2000RFIDScanEventHandler(this.r2000ScanForSN_RFIDDataCaptured);
            // 
            // frmAssRetiring
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.bcScanForSOID,
            this.bcScanForSLID,
            this.bcScanForSN,
            this.r2000ScanForSN});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Title1,
            this.plButton,
            this.plContent,
            this.lvSN});
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229))))));
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmAssRetiring_KeyDown);
            this.Load += new System.EventHandler(this.frmAssRetiring_Load);
            this.Name = "frmAssRetiring";

        }
        #endregion

        private UserControl.Title Title1;
        internal Smobiler.Core.Controls.Label label3;
        internal Smobiler.Core.Controls.Panel plButton;
        internal Smobiler.Core.Controls.Button button1;
        private Smobiler.Core.Controls.Panel plContent;
        internal Smobiler.Core.Controls.Label Label7;
        internal Smobiler.Core.Controls.TextBox txtSOID;
        private Smobiler.Core.Controls.ImageButton ImgBtnForSOID;
        internal Smobiler.Core.Controls.TextBox txtSLID;
        private Smobiler.Core.Controls.ImageButton ImgBtnForSLID;
        internal Smobiler.Core.Controls.Panel panelScan;
        private Smobiler.Core.Controls.Image image5;
        private Smobiler.Core.Controls.Label label11;
        private Smobiler.Core.Controls.ListView lvSN;
        private Smobiler.Core.Controls.BarcodeScanner bcScanForSOID;
        private Smobiler.Core.Controls.BarcodeScanner bcScanForSLID;
        private Smobiler.Core.Controls.BarcodeScanner bcScanForSN;
        private Smobiler.Device.R2000Scanner r2000ScanForSN;
    }
}