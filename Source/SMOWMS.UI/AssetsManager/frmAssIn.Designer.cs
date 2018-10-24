using System;
using Smobiler.Core;
namespace SMOWMS.UI.AssetsManager
{
    partial class frmAssIn : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAssIn()
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
            this.btnSave2 = new Smobiler.Core.Controls.Button();
            this.plContent = new Smobiler.Core.Controls.Panel();
            this.Label7 = new Smobiler.Core.Controls.Label();
            this.txtPOID = new Smobiler.Core.Controls.TextBox();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.ImgBtnForPOID = new Smobiler.Core.Controls.ImageButton();
            this.txtSLID = new Smobiler.Core.Controls.TextBox();
            this.ImgBtnForSLID = new Smobiler.Core.Controls.ImageButton();
            this.btnTemplate = new Smobiler.Core.Controls.Button();
            this.plSacnRow = new Smobiler.Core.Controls.Panel();
            this.panelScan = new Smobiler.Core.Controls.Panel();
            this.image5 = new Smobiler.Core.Controls.Image();
            this.label11 = new Smobiler.Core.Controls.Label();
            this.lblQuant = new Smobiler.Core.Controls.Label();
            this.lvSN = new Smobiler.Core.Controls.ListView();
            this.bcScanForPOID = new Smobiler.Core.Controls.BarcodeScanner();
            this.bcScanForSLID = new Smobiler.Core.Controls.BarcodeScanner();
            this.bcScanForSN = new Smobiler.Core.Controls.BarcodeScanner();
            this.r2000ScanForSN = new Smobiler.Device.R2000Scanner();
            this.popTemp = new Smobiler.Core.Controls.PopList();
            this.btnSave = new Smobiler.Core.Controls.Button();
            // 
            // Title1
            // 
            this.Title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.Title1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label3});
            this.Title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title1.FontSize = 15F;
            this.Title1.ForeColor = System.Drawing.Color.White;
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(300, 40);
            this.Title1.TitleText = "采购入库";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label3.Location = new System.Drawing.Point(0, 72);
            this.label3.Name = "label3";
            this.label3.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label3.Size = new System.Drawing.Size(68, 36);
            this.label3.Text = "库位";
            // 
            // plButton
            // 
            this.plButton.BackColor = System.Drawing.Color.White;
            this.plButton.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.plButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plButton.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnSave2});
            this.plButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plButton.Location = new System.Drawing.Point(0, 468);
            this.plButton.Name = "plButton";
            this.plButton.Size = new System.Drawing.Size(300, 50);
            // 
            // btnSave2
            // 
            this.btnSave2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(124)))), ((int)(((byte)(246)))));
            this.btnSave2.BorderRadius = 0;
            this.btnSave2.Location = new System.Drawing.Point(12, 0);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(276, 38);
            this.btnSave2.Text = "完成";
            this.btnSave2.Press += new System.EventHandler(this.btnSave_Press);
            // 
            // plContent
            // 
            this.plContent.BackColor = System.Drawing.Color.White;
            this.plContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label7,
            this.txtPOID,
            this.label4,
            this.label3,
            this.label4,
            this.ImgBtnForPOID,
            this.txtSLID,
            this.ImgBtnForSLID,
            this.btnTemplate,
            this.plSacnRow});
            this.plContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.plContent.Flex = 2;
            this.plContent.Location = new System.Drawing.Point(0, 40);
            this.plContent.Name = "plContent";
            this.plContent.Size = new System.Drawing.Size(300, 138);
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.White;
            this.Label7.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label7.Name = "Label7";
            this.Label7.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label7.Size = new System.Drawing.Size(68, 36);
            this.Label7.Text = "采购单号";
            // 
            // txtPOID
            // 
            this.txtPOID.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtPOID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtPOID.Location = new System.Drawing.Point(68, 0);
            this.txtPOID.Name = "txtPOID";
            this.txtPOID.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtPOID.ReadOnly = true;
            this.txtPOID.Size = new System.Drawing.Size(232, 36);
            this.txtPOID.WaterMarkText = "（必填）";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label4.Location = new System.Drawing.Point(0, 36);
            this.label4.Name = "label4";
            this.label4.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label4.Size = new System.Drawing.Size(68, 36);
            this.label4.Text = "模板编号";
            // 
            // ImgBtnForPOID
            // 
            this.ImgBtnForPOID.BackColor = System.Drawing.Color.White;
            this.ImgBtnForPOID.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.ImgBtnForPOID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ImgBtnForPOID.Location = new System.Drawing.Point(264, 0);
            this.ImgBtnForPOID.Name = "ImgBtnForPOID";
            this.ImgBtnForPOID.ResourceID = "scan";
            this.ImgBtnForPOID.Size = new System.Drawing.Size(36, 36);
            this.ImgBtnForPOID.Press += new System.EventHandler(this.ImgBtnForPOID_Press);
            // 
            // txtSLID
            // 
            this.txtSLID.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.txtSLID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtSLID.Location = new System.Drawing.Point(68, 72);
            this.txtSLID.Name = "txtSLID";
            this.txtSLID.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtSLID.ReadOnly = true;
            this.txtSLID.Size = new System.Drawing.Size(232, 36);
            this.txtSLID.WaterMarkText = "（必填）";
            // 
            // ImgBtnForSLID
            // 
            this.ImgBtnForSLID.BackColor = System.Drawing.Color.White;
            this.ImgBtnForSLID.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.ImgBtnForSLID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ImgBtnForSLID.Location = new System.Drawing.Point(264, 72);
            this.ImgBtnForSLID.Name = "ImgBtnForSLID";
            this.ImgBtnForSLID.ResourceID = "scan";
            this.ImgBtnForSLID.Size = new System.Drawing.Size(36, 36);
            this.ImgBtnForSLID.Press += new System.EventHandler(this.ImgBtnForSLID_Press);
            // 
            // btnTemplate
            // 
            this.btnTemplate.BackColor = System.Drawing.Color.White;
            this.btnTemplate.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.btnTemplate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnTemplate.BorderRadius = 0;
            this.btnTemplate.ForeColor = System.Drawing.Color.Black;
            this.btnTemplate.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Left;
            this.btnTemplate.Location = new System.Drawing.Point(68, 36);
            this.btnTemplate.Name = "btnTemplate";
            this.btnTemplate.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.btnTemplate.Size = new System.Drawing.Size(232, 36);
            this.btnTemplate.Text = "选择（必填）";
            this.btnTemplate.Press += new System.EventHandler(this.btnTemplate_Press);
            // 
            // plSacnRow
            // 
            this.plSacnRow.BackColor = System.Drawing.Color.White;
            this.plSacnRow.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plSacnRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plSacnRow.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panelScan,
            this.lblQuant});
            this.plSacnRow.Location = new System.Drawing.Point(0, 108);
            this.plSacnRow.Name = "plSacnRow";
            this.plSacnRow.Size = new System.Drawing.Size(300, 30);
            // 
            // panelScan
            // 
            this.panelScan.BackColor = System.Drawing.Color.White;
            this.panelScan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panelScan.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image5,
            this.label11});
            this.panelScan.Name = "panelScan";
            this.panelScan.Size = new System.Drawing.Size(123, 28);
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
            // lblQuant
            // 
            this.lblQuant.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblQuant.Location = new System.Drawing.Point(236, 3);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.lblQuant.Size = new System.Drawing.Size(64, 25);
            this.lblQuant.Text = "0";
            // 
            // lvSN
            // 
            this.lvSN.BackColor = System.Drawing.Color.White;
            this.lvSN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSN.Flex = 5;
            this.lvSN.Location = new System.Drawing.Point(0, 160);
            this.lvSN.Name = "lvSN";
            this.lvSN.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lvSN.PageSizeTextSize = 11F;
            this.lvSN.ShowSplitLine = true;
            this.lvSN.Size = new System.Drawing.Size(300, 300);
            this.lvSN.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lvSN.TemplateControlName = "SNRowLayout";
            // 
            // bcScanForPOID
            // 
            this.bcScanForPOID.Name = "bcScanForPOID";
            this.bcScanForPOID.BarcodeScanned += new Smobiler.Core.Controls.BarcodeScannerCallBackHandler(this.bcScanForPOID_BarcodeScanned);
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
            // popTemp
            // 
            this.popTemp.Name = "popTemp";
            this.popTemp.Selected += new System.EventHandler(this.popTemp_Selected);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(124)))), ((int)(((byte)(246)))));
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSave.BorderRadius = 0;
            this.btnSave.Location = new System.Drawing.Point(261, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(30, 13);
            this.btnSave.Text = "完成";
            this.btnSave.Press += new System.EventHandler(this.btnSave_Press);
            // 
            // frmAssIn
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.bcScanForPOID,
            this.bcScanForSLID,
            this.bcScanForSN,
            this.r2000ScanForSN,
            this.popTemp});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Title1,
            this.plContent,
            this.plButton,
            this.lvSN,
            this.btnSave});
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(124)))), ((int)(((byte)(246))))));
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmAssIn_KeyDown);
            this.Load += new System.EventHandler(this.frmAssIn_Load);
            this.Name = "frmAssIn";

        }
        #endregion

        private UserControl.Title Title1;
        internal Smobiler.Core.Controls.Label label3;
        internal Smobiler.Core.Controls.Panel plButton;
        internal Smobiler.Core.Controls.Button btnSave2;
        private Smobiler.Core.Controls.Panel plContent;
        internal Smobiler.Core.Controls.Label Label7;
        internal Smobiler.Core.Controls.TextBox txtPOID;
        internal Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.ListView lvSN;
        private Smobiler.Core.Controls.ImageButton ImgBtnForPOID;
        internal Smobiler.Core.Controls.TextBox txtSLID;
        private Smobiler.Core.Controls.ImageButton ImgBtnForSLID;
        internal Smobiler.Core.Controls.Button btnTemplate;
        private Smobiler.Core.Controls.BarcodeScanner bcScanForPOID;
        private Smobiler.Core.Controls.BarcodeScanner bcScanForSLID;
        private Smobiler.Core.Controls.BarcodeScanner bcScanForSN;
        private Smobiler.Device.R2000Scanner r2000ScanForSN;
        private Smobiler.Core.Controls.PopList popTemp;
        private Smobiler.Core.Controls.Panel plSacnRow;
        internal Smobiler.Core.Controls.Panel panelScan;
        private Smobiler.Core.Controls.Image image5;
        private Smobiler.Core.Controls.Label label11;
        private Smobiler.Core.Controls.Label lblQuant;
        internal Smobiler.Core.Controls.Button btnSave;
    }
}