using System;
using Smobiler.Core;
namespace SMOWMS.UI.AssetsManager
{
    partial class frmAssSalesOrderResult : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAssSalesOrderResult()
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
            this.lblCustomer = new Smobiler.Core.Controls.Label();
            this.imgUser = new Smobiler.Core.Controls.Image();
            this.lvSORow = new Smobiler.Core.Controls.ListView();
            this.Title1 = new SMOWMS.UI.UserControl.Title();
            this.plButton = new Smobiler.Core.Controls.Panel();
            this.ibAssOut = new Smobiler.Core.Controls.ImageButton();
            this.ibAssRetiring = new Smobiler.Core.Controls.ImageButton();
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
            this.lblCustomer,
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
            this.lblTID.Selectable = true;
            this.lblTID.Size = new System.Drawing.Size(200, 20);
            this.lblTID.Text = "销售单编号";
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
            this.lblPMan.Text = "销售人";
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
            // lblCustomer
            // 
            this.lblCustomer.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.lblCustomer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblCustomer.Location = new System.Drawing.Point(52, 77);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Padding = new Smobiler.Core.Controls.Padding(7F, 0F, 0F, 0F);
            this.lblCustomer.Size = new System.Drawing.Size(200, 16);
            this.lblCustomer.Text = "客户";
            // 
            // imgUser
            // 
            this.imgUser.BorderRadius = 14;
            this.imgUser.Location = new System.Drawing.Point(12, 12);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(29, 29);
            this.imgUser.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            // 
            // lvSORow
            // 
            this.lvSORow.BackColor = System.Drawing.Color.White;
            this.lvSORow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSORow.Location = new System.Drawing.Point(0, 190);
            this.lvSORow.Name = "lvSORow";
            this.lvSORow.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lvSORow.PageSizeTextSize = 11F;
            this.lvSORow.ShowSplitLine = true;
            this.lvSORow.Size = new System.Drawing.Size(300, 310);
            this.lvSORow.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lvSORow.TemplateControlName = "frmAssSOResultLayout";
            // 
            // Title1
            // 
            this.Title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.Title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title1.FontSize = 15F;
            this.Title1.ForeColor = System.Drawing.Color.White;
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(300, 40);
            this.Title1.TitleText = "资产销售";
            // 
            // plButton
            // 
            this.plButton.BackColor = System.Drawing.Color.White;
            this.plButton.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plButton.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.ibAssOut,
            this.ibAssRetiring});
            this.plButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.plButton.Location = new System.Drawing.Point(0, 278);
            this.plButton.Name = "plButton";
            this.plButton.Size = new System.Drawing.Size(300, 60);
            // 
            // ibAssOut
            // 
            this.ibAssOut.FontSize = 14F;
            this.ibAssOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(124)))), ((int)(((byte)(246)))));
            this.ibAssOut.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(124)))), ((int)(((byte)(246)))));
            this.ibAssOut.ImageDirection = Smobiler.Core.Controls.Direction.Left;
            this.ibAssOut.ImgTextRatio = new Smobiler.Core.Controls.Ratio(2, 8);
            this.ibAssOut.Location = new System.Drawing.Point(0, 12);
            this.ibAssOut.Name = "ibAssOut";
            this.ibAssOut.ResourceID = "48-start";
            this.ibAssOut.Size = new System.Drawing.Size(142, 36);
            this.ibAssOut.Press += new System.EventHandler(this.ibAssOut_Press);
            // 
            // ibAssRetiring
            // 
            this.ibAssRetiring.FontSize = 14F;
            this.ibAssRetiring.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(124)))), ((int)(((byte)(246)))));
            this.ibAssRetiring.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(124)))), ((int)(((byte)(246)))));
            this.ibAssRetiring.ImageDirection = Smobiler.Core.Controls.Direction.Left;
            this.ibAssRetiring.ImgTextRatio = new Smobiler.Core.Controls.Ratio(2, 8);
            this.ibAssRetiring.Location = new System.Drawing.Point(164, 12);
            this.ibAssRetiring.Name = "ibAssRetiring";
            this.ibAssRetiring.ResourceID = "48-upload";
            this.ibAssRetiring.Size = new System.Drawing.Size(142, 36);
            this.ibAssRetiring.Text = "上传结果";
            this.ibAssRetiring.Press += new System.EventHandler(this.ibAssRetiring_Press);
            // 
            // frmAssSalesOrderResult
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Title1,
            this.plButton,
            this.plContent,
            this.lvSORow});
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(124)))), ((int)(((byte)(246))))));
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmAssSalesOrderResult_KeyDown);
            this.Load += new System.EventHandler(this.frmAssSalesOrderResult_Load);
            this.Name = "frmAssSalesOrderResult";

        }
        #endregion

        private UserControl.Title Title1;
        private Smobiler.Core.Controls.Panel plContent;
        private Smobiler.Core.Controls.Label lblTID;
        private Smobiler.Core.Controls.Label lblRealId;
        private Smobiler.Core.Controls.Label lblName;
        private Smobiler.Core.Controls.Label lblPMan;
        private Smobiler.Core.Controls.Label lblStatus;
        private Smobiler.Core.Controls.ListView lvSORow;
        private Smobiler.Core.Controls.Label lblCustomer;
        private Smobiler.Core.Controls.Panel plButton;
        internal Smobiler.Core.Controls.ImageButton ibAssOut;
        internal Smobiler.Core.Controls.ImageButton ibAssRetiring;
        private Smobiler.Core.Controls.Image imgUser;
    }
}