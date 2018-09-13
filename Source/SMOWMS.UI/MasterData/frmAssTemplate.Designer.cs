using System;
using Smobiler.Core;
namespace SMOWMS.UI.MasterData
{
    partial class frmAssTemplate : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAssTemplate()
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
            Smobiler.Core.Controls.ActionButtonItem actionButtonItem4 = new Smobiler.Core.Controls.ActionButtonItem();
            Smobiler.Core.Controls.ActionButtonItem actionButtonItem5 = new Smobiler.Core.Controls.ActionButtonItem();
            Smobiler.Core.Controls.ActionButtonItem actionButtonItem6 = new Smobiler.Core.Controls.ActionButtonItem();
            this.plSearch = new Smobiler.Core.Controls.Panel();
            this.imageButton1 = new Smobiler.Core.Controls.ImageButton();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.fontIcon1 = new Smobiler.Core.Controls.FontIcon();
            this.txtNote = new Smobiler.Core.Controls.TextBox();
            this.gridAssRows = new Smobiler.Core.Controls.GridView();
            this.tpSearch = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.popType = new Smobiler.Core.Controls.PopList();
            this.barcodeScanner1 = new Smobiler.Core.Controls.BarcodeScanner();
            this.r2000Scanner1 = new Smobiler.Device.R2000Scanner();
            this.posPrinter1 = new Smobiler.Device.PosPrinter();
            this.Title1 = new SMOWMS.UI.UserControl.Title();
            // 
            // plSearch
            // 
            this.plSearch.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imageButton1,
            this.panel1});
            this.plSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.plSearch.Location = new System.Drawing.Point(0, 97);
            this.plSearch.Name = "plSearch";
            this.plSearch.Size = new System.Drawing.Size(300, 45);
            // 
            // imageButton1
            // 
            this.imageButton1.BackColor = System.Drawing.Color.White;
            this.imageButton1.Location = new System.Drawing.Point(15, 8);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.ResourceID = "scan";
            this.imageButton1.Size = new System.Drawing.Size(28, 28);
            this.imageButton1.Press += new System.EventHandler(this.imageButton1_Press);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderRadius = 4;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.fontIcon1,
            this.txtNote});
            this.panel1.Location = new System.Drawing.Point(50, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 20);
            // 
            // fontIcon1
            // 
            this.fontIcon1.ForeColor = System.Drawing.Color.Silver;
            this.fontIcon1.Location = new System.Drawing.Point(10, 2);
            this.fontIcon1.Name = "fontIcon1";
            this.fontIcon1.ResourceID = "search";
            this.fontIcon1.Size = new System.Drawing.Size(16, 16);
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.Transparent;
            this.txtNote.Location = new System.Drawing.Point(40, 0);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(200, 20);
            this.txtNote.WaterMarkText = "请输入模板名称或模板编号";
            this.txtNote.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.txtNote.TextChanged += new System.EventHandler(this.txtFactor_TextChanged);
            // 
            // gridAssRows
            // 
            this.gridAssRows.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.gridAssRows.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.gridAssRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAssRows.Name = "gridAssRows";
            this.gridAssRows.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.gridAssRows.PageSizeTextSize = 11F;
            this.gridAssRows.Size = new System.Drawing.Size(0, 0);
            this.gridAssRows.TemplateControlName = "frmAssTemplateLayout";
            // 
            // tpSearch
            // 
            this.tpSearch.BackColor = System.Drawing.Color.White;
            this.tpSearch.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.tpSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tpSearch.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1});
            this.tpSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.tpSearch.Location = new System.Drawing.Point(250, 55);
            this.tpSearch.Name = "tpSearch";
            this.tpSearch.Size = new System.Drawing.Size(40, 30);
            this.tpSearch.Touchable = true;
            this.tpSearch.Press += new System.EventHandler(this.tpSearch_Press);
            // 
            // label1
            // 
            this.label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label1.Location = new System.Drawing.Point(200, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.Text = "类别选择▼";
            // 
            // popType
            // 
            this.popType.Name = "popType";
            this.popType.Title = "类型选择";
            this.popType.Selected += new System.EventHandler(this.popType_Selected);
            // 
            // barcodeScanner1
            // 
            this.barcodeScanner1.Name = "barcodeScanner1";
            this.barcodeScanner1.BarcodeScanned += new Smobiler.Core.Controls.BarcodeScannerCallBackHandler(this.barcodeScanner1_BarcodeScanned);
            // 
            // r2000Scanner1
            // 
            this.r2000Scanner1.Name = "r2000Scanner1";
            this.r2000Scanner1.BarcodeDataCaptured += new Smobiler.Device.R2000BarcodeScanEventHandler(this.r2000Scanner1_BarcodeDataCaptured);
            this.r2000Scanner1.RFIDDataCaptured += new Smobiler.Device.R2000RFIDScanEventHandler(this.r2000Scanner1_RFIDDataCaptured);
            // 
            // posPrinter1
            // 
            this.posPrinter1.Name = "posPrinter1";
            // 
            // Title1
            // 
            this.Title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.Title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title1.FontSize = 15F;
            this.Title1.ForeColor = System.Drawing.Color.White;
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(300, 40);
            this.Title1.TitleText = "资产模板列表";
            // 
            // frmAssTemplate
            // 
            this.ActionButton.Enabled = true;
            actionButtonItem4.ImageType = Smobiler.Core.Controls.ActionButtonImageType.Text;
            actionButtonItem4.Text = "添加";
            actionButtonItem5.ImageType = Smobiler.Core.Controls.ActionButtonImageType.Text;
            actionButtonItem5.Text = "复制";
            actionButtonItem6.ImageType = Smobiler.Core.Controls.ActionButtonImageType.Text;
            actionButtonItem6.Text = "打印标签";
            this.ActionButton.Items.AddRange(new Smobiler.Core.Controls.ActionButtonItem[] {
            actionButtonItem4,
            actionButtonItem5,
            actionButtonItem6});
            this.BackColor = System.Drawing.Color.White;
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.popType,
            this.barcodeScanner1,
            this.r2000Scanner1,
            this.posPrinter1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Title1,
            this.plSearch,
            this.tpSearch,
            this.gridAssRows});
            this.ActionButtonPress += new Smobiler.Core.Controls.ActionButtonPressEventHandler(this.frmAssTemplate_ActionButtonPress);
            this.Load += new System.EventHandler(this.frmAssTemplate_Load);
            this.Name = "frmAssTemplate";

        }
        #endregion

        private UserControl.Title Title1;
        private Smobiler.Core.Controls.Panel plSearch;
        private Smobiler.Core.Controls.ImageButton imageButton1;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.FontIcon fontIcon1;
        private Smobiler.Core.Controls.TextBox txtNote;
        internal Smobiler.Core.Controls.GridView gridAssRows;
        private Smobiler.Core.Controls.Panel tpSearch;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.PopList popType;
        private Smobiler.Core.Controls.BarcodeScanner barcodeScanner1;
        private Smobiler.Device.R2000Scanner r2000Scanner1;
        private Smobiler.Device.PosPrinter posPrinter1;
    }
}