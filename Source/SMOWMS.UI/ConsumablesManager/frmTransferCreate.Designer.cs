using System;
using Smobiler.Core;
namespace SMOWMS.UI.ConsumablesManager
{
    partial class frmTransferCreate : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmTransferCreate()
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
            this.popDealMan = new Smobiler.Core.Controls.PopList();
            this.popDealInMan = new Smobiler.Core.Controls.PopList();
            this.BarcodeScanner1 = new Smobiler.Core.Controls.BarcodeScanner();
            this.bsLoc = new Smobiler.Core.Controls.BarcodeScanner();
            this.popLocation = new Smobiler.Core.Controls.PopList();
            this.plTitle = new Smobiler.Core.Controls.Panel();
            this.plBack = new Smobiler.Core.Controls.Panel();
            this.Image1 = new Smobiler.Core.Controls.Image();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.plSave = new Smobiler.Core.Controls.Panel();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.spContent = new Smobiler.Core.Controls.Panel();
            this.plContent = new Smobiler.Core.Controls.Panel();
            this.plTDInMan = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.btnDealInMan = new Smobiler.Core.Controls.Button();
            this.plDate = new Smobiler.Core.Controls.Panel();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.DatePicker = new Smobiler.Core.Controls.DatePicker();
            this.plLocation = new Smobiler.Core.Controls.Panel();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.lblLocation = new Smobiler.Core.Controls.Label();
            this.imgBS = new Smobiler.Core.Controls.ImageButton();
            this.plNote = new Smobiler.Core.Controls.Panel();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.txtNote = new Smobiler.Core.Controls.TextBox();
            this.plTDMan = new Smobiler.Core.Controls.Panel();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.btnDealMan = new Smobiler.Core.Controls.Button();
            this.plAdd = new Smobiler.Core.Controls.Panel();
            this.btnAdd = new Smobiler.Core.Controls.Button();
            this.betGet = new Smobiler.Core.Controls.Button();
            this.ListCons = new Smobiler.Core.Controls.ListView();
            // 
            // popDealMan
            // 
            this.popDealMan.Name = "popDealMan";
            this.popDealMan.Selected += new System.EventHandler(this.popDealMan_Selected);
            // 
            // popDealInMan
            // 
            this.popDealInMan.Name = "popDealInMan";
            this.popDealInMan.Selected += new System.EventHandler(this.popDealInMan_Selected);
            // 
            // BarcodeScanner1
            // 
            this.BarcodeScanner1.Name = "BarcodeScanner1";
            this.BarcodeScanner1.BarcodeScanned += new Smobiler.Core.Controls.BarcodeScannerCallBackHandler(this.BarcodeScanner1_BarcodeScanned);
            // 
            // bsLoc
            // 
            this.bsLoc.Name = "bsLoc";
            this.bsLoc.BarcodeScanned += new Smobiler.Core.Controls.BarcodeScannerCallBackHandler(this.bsLoc_BarcodeScanned);
            // 
            // popLocation
            // 
            this.popLocation.Name = "popLocation";
            this.popLocation.Selected += new System.EventHandler(this.popLocation_Selected);
            // 
            // plTitle
            // 
            this.plTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.plTitle.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plBack,
            this.label4,
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
            // label4
            // 
            this.label4.FontSize = 15F;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label4.Location = new System.Drawing.Point(50, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 40);
            this.label4.Text = "耗材调拨创建";
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
            this.label7.Text = "完成";
            // 
            // spContent
            // 
            this.spContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plContent,
            this.plAdd,
            this.ListCons});
            this.spContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spContent.Location = new System.Drawing.Point(0, 110);
            this.spContent.Name = "spContent";
            this.spContent.Size = new System.Drawing.Size(300, 100);
            // 
            // plContent
            // 
            this.plContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plTDInMan,
            this.plDate,
            this.plLocation,
            this.plNote,
            this.plTDMan});
            this.plContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.plContent.Name = "plContent";
            this.plContent.Size = new System.Drawing.Size(300, 230);
            // 
            // plTDInMan
            // 
            this.plTDInMan.BackColor = System.Drawing.Color.White;
            this.plTDInMan.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.plTDInMan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plTDInMan.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.btnDealInMan});
            this.plTDInMan.Location = new System.Drawing.Point(0, 10);
            this.plTDInMan.Name = "plTDInMan";
            this.plTDInMan.Size = new System.Drawing.Size(300, 35);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(88, 35);
            this.label1.Text = "调入管理员";
            // 
            // btnDealInMan
            // 
            this.btnDealInMan.BackColor = System.Drawing.Color.Transparent;
            this.btnDealInMan.BorderRadius = 0;
            this.btnDealInMan.ForeColor = System.Drawing.Color.Black;
            this.btnDealInMan.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnDealInMan.Location = new System.Drawing.Point(88, 0);
            this.btnDealInMan.Name = "btnDealInMan";
            this.btnDealInMan.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.btnDealInMan.Size = new System.Drawing.Size(212, 35);
            this.btnDealInMan.Text = "必填   > ";
            this.btnDealInMan.Press += new System.EventHandler(this.btnDealInMan_Press);
            // 
            // plDate
            // 
            this.plDate.BackColor = System.Drawing.Color.White;
            this.plDate.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plDate.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label5,
            this.DatePicker});
            this.plDate.Location = new System.Drawing.Point(0, 45);
            this.plDate.Name = "plDate";
            this.plDate.Size = new System.Drawing.Size(300, 35);
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label5.Size = new System.Drawing.Size(88, 35);
            this.label5.Text = "业务日期";
            // 
            // DatePicker
            // 
            this.DatePicker.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.DatePicker.Location = new System.Drawing.Point(88, 0);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.DatePicker.Size = new System.Drawing.Size(212, 35);
            // 
            // plLocation
            // 
            this.plLocation.BackColor = System.Drawing.Color.White;
            this.plLocation.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plLocation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plLocation.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label2,
            this.lblLocation,
            this.imgBS});
            this.plLocation.Location = new System.Drawing.Point(0, 90);
            this.plLocation.Name = "plLocation";
            this.plLocation.Size = new System.Drawing.Size(300, 35);
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
            // plNote
            // 
            this.plNote.BackColor = System.Drawing.Color.White;
            this.plNote.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plNote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plNote.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label6,
            this.txtNote});
            this.plNote.Location = new System.Drawing.Point(0, 160);
            this.plNote.Name = "plNote";
            this.plNote.Size = new System.Drawing.Size(300, 70);
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label6.Name = "label6";
            this.label6.Padding = new Smobiler.Core.Controls.Padding(5F, 5F, 0F, 0F);
            this.label6.Size = new System.Drawing.Size(88, 70);
            this.label6.Text = "备注";
            this.label6.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.Transparent;
            this.txtNote.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtNote.Location = new System.Drawing.Point(88, 0);
            this.txtNote.MaxLength = 200;
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Padding = new Smobiler.Core.Controls.Padding(0F, 5F, 5F, 0F);
            this.txtNote.Size = new System.Drawing.Size(212, 70);
            this.txtNote.WaterMarkText = "（选填）";
            // 
            // plTDMan
            // 
            this.plTDMan.BackColor = System.Drawing.Color.White;
            this.plTDMan.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plTDMan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plTDMan.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label3,
            this.btnDealMan});
            this.plTDMan.Location = new System.Drawing.Point(0, 125);
            this.plTDMan.Name = "plTDMan";
            this.plTDMan.Size = new System.Drawing.Size(300, 35);
            // 
            // Label3
            // 
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label3.Name = "Label3";
            this.Label3.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label3.Size = new System.Drawing.Size(88, 35);
            this.Label3.Text = "处理人";
            // 
            // btnDealMan
            // 
            this.btnDealMan.BackColor = System.Drawing.Color.Transparent;
            this.btnDealMan.BorderRadius = 0;
            this.btnDealMan.ForeColor = System.Drawing.Color.Black;
            this.btnDealMan.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnDealMan.Location = new System.Drawing.Point(88, 0);
            this.btnDealMan.Name = "btnDealMan";
            this.btnDealMan.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.btnDealMan.Size = new System.Drawing.Size(212, 35);
            this.btnDealMan.Text = "必填   > ";
            this.btnDealMan.Press += new System.EventHandler(this.btnDealMan_Press);
            // 
            // plAdd
            // 
            this.plAdd.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnAdd,
            this.betGet});
            this.plAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plAdd.Location = new System.Drawing.Point(0, 230);
            this.plAdd.Name = "plAdd";
            this.plAdd.Size = new System.Drawing.Size(300, 90);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.BorderRadius = 4;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(10, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(280, 35);
            this.btnAdd.Text = "耗材选择";
            this.btnAdd.Press += new System.EventHandler(this.btnAdd_Press);
            // 
            // betGet
            // 
            this.betGet.BackColor = System.Drawing.Color.White;
            this.betGet.BorderRadius = 4;
            this.betGet.ForeColor = System.Drawing.Color.Black;
            this.betGet.Location = new System.Drawing.Point(10, 45);
            this.betGet.Name = "betGet";
            this.betGet.Size = new System.Drawing.Size(280, 35);
            this.betGet.Text = "扫码添加";
            this.betGet.Press += new System.EventHandler(this.betGet_Press);
            // 
            // ListCons
            // 
            this.ListCons.BackColor = System.Drawing.Color.White;
            this.ListCons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListCons.Location = new System.Drawing.Point(0, 245);
            this.ListCons.Name = "ListCons";
            this.ListCons.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.ListCons.PageSizeTextSize = 11F;
            this.ListCons.ShowSplitLine = true;
            this.ListCons.Size = new System.Drawing.Size(300, 180);
            this.ListCons.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ListCons.TemplateControlName = "frmOrderCreateLayout";
            // 
            // frmTransferCreate
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.popDealMan,
            this.popDealInMan,
            this.BarcodeScanner1,
            this.bsLoc,
            this.popLocation});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plTitle,
            this.spContent});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229))))));
            this.Name = "frmTransferCreate";

        }
        #endregion
        internal Smobiler.Core.Controls.PopList popDealMan;
        internal Smobiler.Core.Controls.PopList popDealInMan;
        internal Smobiler.Core.Controls.BarcodeScanner BarcodeScanner1;
        private Smobiler.Core.Controls.BarcodeScanner bsLoc;
        private Smobiler.Core.Controls.PopList popLocation;
        internal Smobiler.Core.Controls.Panel plTitle;
        private Smobiler.Core.Controls.Panel plBack;
        internal Smobiler.Core.Controls.Image Image1;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.Panel plSave;
        private Smobiler.Core.Controls.Label label7;
        internal Smobiler.Core.Controls.Panel spContent;
        private Smobiler.Core.Controls.Panel plContent;
        private Smobiler.Core.Controls.Panel plTDInMan;
        private Smobiler.Core.Controls.Label label1;
        internal Smobiler.Core.Controls.Button btnDealInMan;
        private Smobiler.Core.Controls.Panel plDate;
        private Smobiler.Core.Controls.Label label5;
        private Smobiler.Core.Controls.DatePicker DatePicker;
        private Smobiler.Core.Controls.Panel plLocation;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label lblLocation;
        private Smobiler.Core.Controls.ImageButton imgBS;
        private Smobiler.Core.Controls.Panel plNote;
        private Smobiler.Core.Controls.Label label6;
        private Smobiler.Core.Controls.TextBox txtNote;
        private Smobiler.Core.Controls.Panel plTDMan;
        private Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.Button btnDealMan;
        internal Smobiler.Core.Controls.Panel plAdd;
        internal Smobiler.Core.Controls.Button btnAdd;
        internal Smobiler.Core.Controls.Button betGet;
        private Smobiler.Core.Controls.ListView ListCons;
    }
}