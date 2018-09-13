using System;
using Smobiler.Core;
namespace SMOWMS.UI.AssetsManager
{
    partial class frmAssReturn : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAssReturn()
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
            this.plButton = new Smobiler.Core.Controls.Panel();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.plContent = new Smobiler.Core.Controls.Panel();
            this.Label7 = new Smobiler.Core.Controls.Label();
            this.txtPOID = new Smobiler.Core.Controls.TextBox();
            this.ImgBtnForPOID = new Smobiler.Core.Controls.ImageButton();
            this.plScanRow = new Smobiler.Core.Controls.Panel();
            this.panelScan = new Smobiler.Core.Controls.Panel();
            this.image5 = new Smobiler.Core.Controls.Image();
            this.label11 = new Smobiler.Core.Controls.Label();
            this.lvSN = new Smobiler.Core.Controls.ListView();
            this.r2000ScanForSN = new Smobiler.Device.R2000Scanner();
            this.bcScanForSN = new Smobiler.Core.Controls.BarcodeScanner();
            this.bcScanForPOID = new Smobiler.Core.Controls.BarcodeScanner();
            // 
            // Title1
            // 
            this.Title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.Title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title1.FontSize = 15F;
            this.Title1.ForeColor = System.Drawing.Color.White;
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(300, 40);
            this.Title1.TitleText = "采购退货";
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
            this.txtPOID,
            this.ImgBtnForPOID,
            this.plScanRow});
            this.plContent.Flex = 3;
            this.plContent.Location = new System.Drawing.Point(0, 40);
            this.plContent.Name = "plContent";
            this.plContent.Size = new System.Drawing.Size(300, 60);
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.White;
            this.Label7.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.Label7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label7.Name = "Label7";
            this.Label7.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label7.Size = new System.Drawing.Size(100, 30);
            this.Label7.Text = "采购单号";
            // 
            // txtPOID
            // 
            this.txtPOID.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.txtPOID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtPOID.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtPOID.Location = new System.Drawing.Point(100, 0);
            this.txtPOID.Name = "txtPOID";
            this.txtPOID.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtPOID.ReadOnly = true;
            this.txtPOID.Size = new System.Drawing.Size(170, 30);
            this.txtPOID.WaterMarkText = "（必填）";
            // 
            // ImgBtnForPOID
            // 
            this.ImgBtnForPOID.BackColor = System.Drawing.Color.White;
            this.ImgBtnForPOID.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.ImgBtnForPOID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ImgBtnForPOID.Location = new System.Drawing.Point(270, 0);
            this.ImgBtnForPOID.Name = "ImgBtnForPOID";
            this.ImgBtnForPOID.ResourceID = "scan";
            this.ImgBtnForPOID.Size = new System.Drawing.Size(30, 30);
            this.ImgBtnForPOID.Press += new System.EventHandler(this.ImgBtnForPOID_Press);
            // 
            // plScanRow
            // 
            this.plScanRow.BackColor = System.Drawing.Color.White;
            this.plScanRow.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plScanRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plScanRow.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panelScan});
            this.plScanRow.Location = new System.Drawing.Point(0, 30);
            this.plScanRow.Name = "plScanRow";
            this.plScanRow.Size = new System.Drawing.Size(300, 30);
            // 
            // panelScan
            // 
            this.panelScan.BackColor = System.Drawing.Color.White;
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
            // lvSN
            // 
            this.lvSN.BackColor = System.Drawing.Color.White;
            this.lvSN.Flex = 11;
            this.lvSN.Location = new System.Drawing.Point(0, 100);
            this.lvSN.Name = "lvSN";
            this.lvSN.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lvSN.PageSizeTextSize = 11F;
            this.lvSN.ShowSplitLine = true;
            this.lvSN.Size = new System.Drawing.Size(300, 360);
            this.lvSN.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lvSN.TemplateControlName = "SNRowLayout";
            // 
            // r2000ScanForSN
            // 
            this.r2000ScanForSN.Name = "r2000ScanForSN";
            this.r2000ScanForSN.BarcodeDataCaptured += new Smobiler.Device.R2000BarcodeScanEventHandler(this.r2000ScanForSN_BarcodeDataCaptured);
            this.r2000ScanForSN.RFIDDataCaptured += new Smobiler.Device.R2000RFIDScanEventHandler(this.r2000ScanForSN_RFIDDataCaptured);
            // 
            // bcScanForSN
            // 
            this.bcScanForSN.Name = "bcScanForSN";
            this.bcScanForSN.BarcodeScanned += new Smobiler.Core.Controls.BarcodeScannerCallBackHandler(this.bcScanForSN_BarcodeScanned);
            // 
            // bcScanForPOID
            // 
            this.bcScanForPOID.Name = "bcScanForPOID";
            this.bcScanForPOID.BarcodeScanned += new Smobiler.Core.Controls.BarcodeScannerCallBackHandler(this.bcScanForPOID_BarcodeScanned);
            // 
            // frmAssReturn
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.r2000ScanForSN,
            this.bcScanForSN,
            this.bcScanForPOID});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Title1,
            this.plButton,
            this.plContent,
            this.lvSN});
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229))))));
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmAssReturn_KeyDown);
            this.Load += new System.EventHandler(this.frmAssReturn_Load);
            this.Name = "frmAssReturn";

        }
        #endregion

        private UserControl.Title Title1;
        internal Smobiler.Core.Controls.Panel plButton;
        internal Smobiler.Core.Controls.Button button1;
        private Smobiler.Core.Controls.Panel plContent;
        internal Smobiler.Core.Controls.Label Label7;
        internal Smobiler.Core.Controls.TextBox txtPOID;
        private Smobiler.Core.Controls.ImageButton ImgBtnForPOID;
        private Smobiler.Core.Controls.ListView lvSN;
        private Smobiler.Device.R2000Scanner r2000ScanForSN;
        private Smobiler.Core.Controls.BarcodeScanner bcScanForSN;
        private Smobiler.Core.Controls.BarcodeScanner bcScanForPOID;
        private Smobiler.Core.Controls.Panel plScanRow;
        internal Smobiler.Core.Controls.Panel panelScan;
        private Smobiler.Core.Controls.Image image5;
        private Smobiler.Core.Controls.Label label11;
    }
}