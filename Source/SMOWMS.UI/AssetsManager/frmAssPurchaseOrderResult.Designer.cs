using System;
using Smobiler.Core;
namespace SMOWMS.UI.AssetsManager
{
    partial class frmAssPurchaseOrderResult : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAssPurchaseOrderResult()
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
            this.lblTID = new Smobiler.Core.Controls.Label();
            this.lblRealId = new Smobiler.Core.Controls.Label();
            this.lblName = new Smobiler.Core.Controls.Label();
            this.lblPMan = new Smobiler.Core.Controls.Label();
            this.lblStatus = new Smobiler.Core.Controls.Label();
            this.lblVendor = new Smobiler.Core.Controls.Label();
            this.imgUser = new Smobiler.Core.Controls.Image();
            this.lvPORow = new Smobiler.Core.Controls.ListView();
            this.Title1 = new SMOWMS.UI.UserControl.Title();
            this.plButton = new Smobiler.Core.Controls.Panel();
            this.ibAssIn = new Smobiler.Core.Controls.ImageButton();
            this.ibAssReturn = new Smobiler.Core.Controls.ImageButton();
            // 
            // plContent
            // 
            this.plContent.BackColor = System.Drawing.Color.White;
            this.plContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblTID,
            this.lblRealId,
            this.lblName,
            this.lblPMan,
            this.lblStatus,
            this.lblVendor,
            this.imgUser});
            this.plContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.plContent.Location = new System.Drawing.Point(0, 40);
            this.plContent.Name = "plContent";
            this.plContent.Size = new System.Drawing.Size(300, 116);
            // 
            // lblTID
            // 
            this.lblTID.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.lblTID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblTID.Location = new System.Drawing.Point(52, 9);
            this.lblTID.Name = "lblTID";
            this.lblTID.Padding = new Smobiler.Core.Controls.Padding(7F, 0F, 0F, 0F);
            this.lblTID.Size = new System.Drawing.Size(200, 20);
            this.lblTID.Text = "编号";
            // 
            // lblRealId
            // 
            this.lblRealId.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.lblRealId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblRealId.Location = new System.Drawing.Point(52, 29);
            this.lblRealId.Name = "lblRealId";
            this.lblRealId.Padding = new Smobiler.Core.Controls.Padding(7F, 0F, 0F, 0F);
            this.lblRealId.Size = new System.Drawing.Size(200, 16);
            this.lblRealId.Text = "实际编号";
            // 
            // lblName
            // 
            this.lblName.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.lblName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblName.Location = new System.Drawing.Point(52, 45);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new Smobiler.Core.Controls.Padding(7F, 0F, 0F, 0F);
            this.lblName.Size = new System.Drawing.Size(200, 16);
            this.lblName.Text = "名称";
            // 
            // lblPMan
            // 
            this.lblPMan.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.lblPMan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblPMan.Location = new System.Drawing.Point(52, 61);
            this.lblPMan.Name = "lblPMan";
            this.lblPMan.Padding = new Smobiler.Core.Controls.Padding(7F, 0F, 0F, 0F);
            this.lblPMan.Size = new System.Drawing.Size(200, 16);
            this.lblPMan.Text = "采购人";
            // 
            // lblStatus
            // 
            this.lblStatus.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.lblStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblStatus.Location = new System.Drawing.Point(52, 93);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Padding = new Smobiler.Core.Controls.Padding(7F, 0F, 0F, 0F);
            this.lblStatus.Size = new System.Drawing.Size(200, 16);
            this.lblStatus.Text = "状态";
            // 
            // lblVendor
            // 
            this.lblVendor.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.lblVendor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblVendor.Location = new System.Drawing.Point(52, 77);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Padding = new Smobiler.Core.Controls.Padding(7F, 0F, 0F, 0F);
            this.lblVendor.Size = new System.Drawing.Size(200, 16);
            this.lblVendor.Text = "供应商";
            // 
            // imgUser
            // 
            this.imgUser.BorderRadius = 14;
            this.imgUser.Location = new System.Drawing.Point(12, 12);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(29, 29);
            this.imgUser.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            // 
            // lvPORow
            // 
            this.lvPORow.BackColor = System.Drawing.Color.White;
            this.lvPORow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPORow.Location = new System.Drawing.Point(0, 190);
            this.lvPORow.Name = "lvPORow";
            this.lvPORow.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lvPORow.PageSizeTextSize = 11F;
            this.lvPORow.ShowSplitLine = true;
            this.lvPORow.Size = new System.Drawing.Size(300, 310);
            this.lvPORow.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lvPORow.TemplateControlName = "frmAssPOResultLayout";
            // 
            // Title1
            // 
            this.Title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.Title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title1.FontSize = 15F;
            this.Title1.ForeColor = System.Drawing.Color.White;
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(300, 40);
            this.Title1.TitleText = "资产采购";
            // 
            // plButton
            // 
            this.plButton.BackColor = System.Drawing.Color.White;
            this.plButton.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plButton.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.ibAssIn,
            this.ibAssReturn});
            this.plButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.plButton.Location = new System.Drawing.Point(0, 278);
            this.plButton.Name = "plButton";
            this.plButton.Size = new System.Drawing.Size(300, 60);
            // 
            // ibAssIn
            // 
            this.ibAssIn.FontSize = 14F;
            this.ibAssIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(124)))), ((int)(((byte)(246)))));
            this.ibAssIn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(124)))), ((int)(((byte)(246)))));
            this.ibAssIn.ImageDirection = Smobiler.Core.Controls.Direction.Left;
            this.ibAssIn.ImgTextRatio = new Smobiler.Core.Controls.Ratio(2, 8);
            this.ibAssIn.Location = new System.Drawing.Point(0, 12);
            this.ibAssIn.Name = "ibAssIn";
            this.ibAssIn.ResourceID = "48-start";
            this.ibAssIn.Size = new System.Drawing.Size(142, 36);
            this.ibAssIn.Press += new System.EventHandler(this.ibAssIn_Press);
            // 
            // ibAssReturn
            // 
            this.ibAssReturn.FontSize = 14F;
            this.ibAssReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(124)))), ((int)(((byte)(246)))));
            this.ibAssReturn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(124)))), ((int)(((byte)(246)))));
            this.ibAssReturn.ImageDirection = Smobiler.Core.Controls.Direction.Left;
            this.ibAssReturn.ImgTextRatio = new Smobiler.Core.Controls.Ratio(2, 8);
            this.ibAssReturn.Location = new System.Drawing.Point(164, 12);
            this.ibAssReturn.Name = "ibAssReturn";
            this.ibAssReturn.ResourceID = "48-upload";
            this.ibAssReturn.Size = new System.Drawing.Size(142, 36);
            this.ibAssReturn.Text = "上传结果";
            this.ibAssReturn.Press += new System.EventHandler(this.ibAssReturn_Press);
            // 
            // frmAssPurchaseOrderResult
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Title1,
            this.plButton,
            this.plContent,
            this.lvPORow});
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(124)))), ((int)(((byte)(246))))));
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmAssPurchaseOrderResult_KeyDown);
            this.Load += new System.EventHandler(this.frmAssPurchaseOrderResult_Load);
            this.Name = "frmAssPurchaseOrderResult";

        }
        #endregion

        private UserControl.Title Title1;
        private Smobiler.Core.Controls.Panel plContent;
        private Smobiler.Core.Controls.Label lblTID;
        private Smobiler.Core.Controls.Label lblRealId;
        private Smobiler.Core.Controls.Label lblName;
        private Smobiler.Core.Controls.Label lblPMan;
        private Smobiler.Core.Controls.Label lblStatus;
        private Smobiler.Core.Controls.ListView lvPORow;
        private Smobiler.Core.Controls.Label lblVendor;
        private Smobiler.Core.Controls.Panel plButton;
        internal Smobiler.Core.Controls.ImageButton ibAssIn;
        internal Smobiler.Core.Controls.ImageButton ibAssReturn;
        private Smobiler.Core.Controls.Image imgUser;
    }
}