using System;
using Smobiler.Core;
namespace SMOWMS.UI.ConsumablesManager
{
    partial class frmConPORInSto : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmConPORInSto()
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
            this.title1 = new SMOWMS.UI.UserControl.Title();
            this.bsLoc = new Smobiler.Core.Controls.BarcodeScanner();
            this.plOrder = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.lblOrder = new Smobiler.Core.Controls.Label();
            this.imgOrder = new Smobiler.Core.Controls.ImageButton();
            this.plLoc = new Smobiler.Core.Controls.Panel();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.lblLocation = new Smobiler.Core.Controls.Label();
            this.imgBS = new Smobiler.Core.Controls.ImageButton();
            this.listCons = new Smobiler.Core.Controls.ListView();
            this.plButton = new Smobiler.Core.Controls.Panel();
            this.btnSave = new Smobiler.Core.Controls.Button();
            this.plAll = new Smobiler.Core.Controls.Panel();
            this.Checkall = new Smobiler.Core.Controls.CheckBox();
            this.lblCheckall = new Smobiler.Core.Controls.Label();
            this.bsOrder = new Smobiler.Core.Controls.BarcodeScanner();
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.title1.FontSize = 15F;
            this.title1.ForeColor = System.Drawing.Color.White;
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(0, 40);
            this.title1.TitleText = "采购入库";
            // 
            // bsLoc
            // 
            this.bsLoc.Name = "bsLoc";
            this.bsLoc.BarcodeScanned += new Smobiler.Core.Controls.BarcodeScannerCallBackHandler(this.bsLoc_BarcodeScanned);
            // 
            // plOrder
            // 
            this.plOrder.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plOrder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plOrder.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.lblOrder,
            this.imgOrder});
            this.plOrder.Name = "plOrder";
            this.plOrder.Size = new System.Drawing.Size(0, 35);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(88, 35);
            this.label1.Text = "采购单号";
            // 
            // lblOrder
            // 
            this.lblOrder.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblOrder.Location = new System.Drawing.Point(88, 0);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.lblOrder.Size = new System.Drawing.Size(174, 35);
            // 
            // imgOrder
            // 
            this.imgOrder.BackColor = System.Drawing.Color.White;
            this.imgOrder.Location = new System.Drawing.Point(262, 3);
            this.imgOrder.Name = "imgOrder";
            this.imgOrder.ResourceID = "scan";
            this.imgOrder.Size = new System.Drawing.Size(28, 28);
            this.imgOrder.Press += new System.EventHandler(this.imgOrder_Press);
            // 
            // plLoc
            // 
            this.plLoc.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plLoc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plLoc.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label2,
            this.lblLocation,
            this.imgBS});
            this.plLoc.Name = "plLoc";
            this.plLoc.Size = new System.Drawing.Size(300, 35);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label2.Size = new System.Drawing.Size(88, 35);
            this.label2.Text = "调入库位";
            // 
            // lblLocation
            // 
            this.lblLocation.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblLocation.Location = new System.Drawing.Point(88, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.lblLocation.Size = new System.Drawing.Size(174, 35);
            // 
            // imgBS
            // 
            this.imgBS.BackColor = System.Drawing.Color.White;
            this.imgBS.Location = new System.Drawing.Point(262, 3);
            this.imgBS.Name = "imgBS";
            this.imgBS.ResourceID = "scan";
            this.imgBS.Size = new System.Drawing.Size(28, 28);
            this.imgBS.Press += new System.EventHandler(this.imgBS_Press);
            // 
            // listCons
            // 
            this.listCons.Flex = 1;
            this.listCons.Name = "listCons";
            this.listCons.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listCons.PageSizeTextSize = 11F;
            this.listCons.ShowSplitLine = true;
            this.listCons.Size = new System.Drawing.Size(300, 300);
            this.listCons.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.listCons.TemplateControlName = "frmConPORInStoLayout";
            // 
            // plButton
            // 
            this.plButton.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.plButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plButton.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnSave,
            this.plAll});
            this.plButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plButton.Name = "plButton";
            this.plButton.Size = new System.Drawing.Size(300, 70);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnSave.BorderRadius = 4;
            this.btnSave.FontSize = 17F;
            this.btnSave.Location = new System.Drawing.Point(10, 35);
            this.btnSave.Margin = new Smobiler.Core.Controls.Margin(0F, 0F, 10F, 0F);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(280, 35);
            this.btnSave.Text = "提交";
            this.btnSave.Press += new System.EventHandler(this.btnSave_Press);
            // 
            // plAll
            // 
            this.plAll.BackColor = System.Drawing.Color.White;
            this.plAll.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Checkall,
            this.lblCheckall});
            this.plAll.Name = "plAll";
            this.plAll.Size = new System.Drawing.Size(300, 35);
            this.plAll.Touchable = true;
            this.plAll.Press += new System.EventHandler(this.plAll_Press);
            // 
            // Checkall
            // 
            this.Checkall.Location = new System.Drawing.Point(8, 8);
            this.Checkall.Name = "Checkall";
            this.Checkall.Size = new System.Drawing.Size(20, 20);
            this.Checkall.ZIndex = 2;
            this.Checkall.CheckedChanged += new System.EventHandler(this.Checkall_CheckedChanged);
            // 
            // lblCheckall
            // 
            this.lblCheckall.FontSize = 12F;
            this.lblCheckall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblCheckall.Location = new System.Drawing.Point(42, 0);
            this.lblCheckall.Name = "lblCheckall";
            this.lblCheckall.Size = new System.Drawing.Size(40, 35);
            this.lblCheckall.Text = "全选";
            // 
            // bsOrder
            // 
            this.bsOrder.Name = "bsOrder";
            this.bsOrder.BarcodeScanned += new Smobiler.Core.Controls.BarcodeScannerCallBackHandler(this.bsOrder_BarcodeScanned);
            // 
            // frmConPORInSto
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.bsLoc,
            this.bsOrder});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.plOrder,
            this.plLoc,
            this.listCons,
            this.plButton});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229))))));
            this.Load += new System.EventHandler(this.frmConPORInSto_Load);
            this.Name = "frmConPORInSto";

        }
        #endregion

        private UserControl.Title title1;
        private Smobiler.Core.Controls.BarcodeScanner bsLoc;
        private Smobiler.Core.Controls.Panel plOrder;
        private Smobiler.Core.Controls.Panel plLoc;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label lblLocation;
        private Smobiler.Core.Controls.ImageButton imgBS;
        private Smobiler.Core.Controls.ListView listCons;
        private Smobiler.Core.Controls.Panel plButton;
        private Smobiler.Core.Controls.Button btnSave;
        private Smobiler.Core.Controls.Panel plAll;
        internal Smobiler.Core.Controls.CheckBox Checkall;
        internal Smobiler.Core.Controls.Label lblCheckall;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label lblOrder;
        private Smobiler.Core.Controls.ImageButton imgOrder;
        private Smobiler.Core.Controls.BarcodeScanner bsOrder;
    }
}