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
            Smobiler.Core.Controls.ActionButtonItem actionButtonItem1 = new Smobiler.Core.Controls.ActionButtonItem();
            Smobiler.Core.Controls.ActionButtonItem actionButtonItem2 = new Smobiler.Core.Controls.ActionButtonItem();
            this.plContent = new Smobiler.Core.Controls.Panel();
            this.Label8 = new Smobiler.Core.Controls.Label();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.lblTID = new Smobiler.Core.Controls.Label();
            this.lblRealId = new Smobiler.Core.Controls.Label();
            this.lblName = new Smobiler.Core.Controls.Label();
            this.lblPMan = new Smobiler.Core.Controls.Label();
            this.lblStatus = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.lblVendor = new Smobiler.Core.Controls.Label();
            this.lvPORow = new Smobiler.Core.Controls.ListView();
            this.Title1 = new SMOWMS.UI.UserControl.Title();
            // 
            // plContent
            // 
            this.plContent.BackColor = System.Drawing.Color.White;
            this.plContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label8,
            this.label1,
            this.label3,
            this.label4,
            this.label5,
            this.lblTID,
            this.lblRealId,
            this.lblName,
            this.lblPMan,
            this.lblStatus,
            this.label2,
            this.lblVendor});
            this.plContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.plContent.Location = new System.Drawing.Point(0, 40);
            this.plContent.Name = "plContent";
            this.plContent.Size = new System.Drawing.Size(300, 180);
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.White;
            this.Label8.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.Label8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label8.Name = "Label8";
            this.Label8.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label8.Size = new System.Drawing.Size(100, 30);
            this.Label8.Text = "采购单编号";
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
            this.label1.Text = "实际编号";
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
            this.label3.Text = "名称";
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
            this.label4.Text = "采购人";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label5.Location = new System.Drawing.Point(0, 150);
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label5.Size = new System.Drawing.Size(100, 30);
            this.label5.Text = "状态";
            // 
            // lblTID
            // 
            this.lblTID.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.lblTID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblTID.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblTID.Location = new System.Drawing.Point(100, 0);
            this.lblTID.Name = "lblTID";
            this.lblTID.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.lblTID.Selectable = true;
            this.lblTID.Size = new System.Drawing.Size(200, 30);
            this.lblTID.Text = "采购单编号";
            // 
            // lblRealId
            // 
            this.lblRealId.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.lblRealId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblRealId.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblRealId.Location = new System.Drawing.Point(100, 30);
            this.lblRealId.Name = "lblRealId";
            this.lblRealId.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.lblRealId.Size = new System.Drawing.Size(200, 30);
            this.lblRealId.Text = "实际编号";
            // 
            // lblName
            // 
            this.lblName.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.lblName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblName.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblName.Location = new System.Drawing.Point(100, 60);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.lblName.Size = new System.Drawing.Size(200, 30);
            this.lblName.Text = "名称";
            // 
            // lblPMan
            // 
            this.lblPMan.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.lblPMan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblPMan.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblPMan.Location = new System.Drawing.Point(100, 90);
            this.lblPMan.Name = "lblPMan";
            this.lblPMan.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.lblPMan.Size = new System.Drawing.Size(200, 30);
            this.lblPMan.Text = "采购人";
            // 
            // lblStatus
            // 
            this.lblStatus.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.lblStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblStatus.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblStatus.Location = new System.Drawing.Point(100, 150);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.lblStatus.Size = new System.Drawing.Size(200, 30);
            this.lblStatus.Text = "状态";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label2.Location = new System.Drawing.Point(0, 120);
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.Text = "供应商";
            // 
            // lblVendor
            // 
            this.lblVendor.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.lblVendor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblVendor.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblVendor.Location = new System.Drawing.Point(100, 120);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.lblVendor.Size = new System.Drawing.Size(200, 30);
            this.lblVendor.Text = "供应商";
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
            // frmAssPurchaseOrderResult
            // 
            this.ActionButton.Enabled = true;
            actionButtonItem1.ImageType = Smobiler.Core.Controls.ActionButtonImageType.Text;
            actionButtonItem1.Text = "入库";
            actionButtonItem2.ImageType = Smobiler.Core.Controls.ActionButtonImageType.Text;
            actionButtonItem2.Text = "退货";
            this.ActionButton.Items.AddRange(new Smobiler.Core.Controls.ActionButtonItem[] {
            actionButtonItem1,
            actionButtonItem2});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Title1,
            this.plContent,
            this.lvPORow});
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229))))));
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmAssPurchaseOrderResult_KeyDown);
            this.ActionButtonPress += new Smobiler.Core.Controls.ActionButtonPressEventHandler(this.frmAssPurchaseOrderResult_ActionButtonPress);
            this.Load += new System.EventHandler(this.frmAssPurchaseOrderResult_Load);
            this.Name = "frmAssPurchaseOrderResult";

        }
        #endregion

        private UserControl.Title Title1;
        private Smobiler.Core.Controls.Panel plContent;
        internal Smobiler.Core.Controls.Label Label8;
        internal Smobiler.Core.Controls.Label label1;
        internal Smobiler.Core.Controls.Label label3;
        internal Smobiler.Core.Controls.Label label4;
        internal Smobiler.Core.Controls.Label label5;
        private Smobiler.Core.Controls.Label lblTID;
        private Smobiler.Core.Controls.Label lblRealId;
        private Smobiler.Core.Controls.Label lblName;
        private Smobiler.Core.Controls.Label lblPMan;
        private Smobiler.Core.Controls.Label lblStatus;
        private Smobiler.Core.Controls.ListView lvPORow;
        internal Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label lblVendor;
    }
}