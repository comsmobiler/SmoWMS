using System;
using Smobiler.Core;
namespace SMOWMS.UI.Layout
{
    partial class frmAssSOLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public frmAssSOLayout()
            : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

        //SmobilerUserControl overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerUserControl
        //It can be modified using the SmobilerUserControl.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.svRow = new Smobiler.Core.Controls.SwipeView();
            this.plRow = new Smobiler.Core.Controls.Panel();
            this.lblName = new Smobiler.Core.Controls.Label();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.label8 = new Smobiler.Core.Controls.Label();
            this.label9 = new Smobiler.Core.Controls.Label();
            this.lblStatus = new Smobiler.Core.Controls.Label();
            this.imgFirstAss = new Smobiler.Core.Controls.Image();
            this.ibEdit = new Smobiler.Core.Controls.ImageButton();
            // 
            // svRow
            // 
            this.svRow.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plRow});
            this.svRow.Name = "svRow";
            this.svRow.RightControlName = "svDelete";
            this.svRow.Size = new System.Drawing.Size(260, 90);
            // 
            // plRow
            // 
            this.plRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plRow.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblName,
            this.label5,
            this.label7,
            this.label8,
            this.label9,
            this.lblStatus,
            this.imgFirstAss,
            this.ibEdit});
            this.plRow.Name = "plRow";
            this.plRow.Size = new System.Drawing.Size(260, 90);
            this.plRow.Touchable = true;
            this.plRow.Press += new System.EventHandler(this.plRow_Press);
            // 
            // lblName
            // 
            this.lblName.DataMember = "SOID";
            this.lblName.DisplayMember = "NAME";
            this.lblName.FontSize = 14F;
            this.lblName.Location = new System.Drawing.Point(85, 7);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.lblName.Size = new System.Drawing.Size(115, 25);
            this.lblName.Text = "label1";
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.label5.Location = new System.Drawing.Point(85, 57);
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Controls.Padding(2F, 0F, 0F, 0F);
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.Text = "销售人";
            // 
            // label7
            // 
            this.label7.DataMember = "SALESPERSONNAME";
            this.label7.DisplayMember = "SALESPERSONNAME";
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.label7.Location = new System.Drawing.Point(140, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 25);
            this.label7.Text = "label5";
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.label8.Location = new System.Drawing.Point(85, 32);
            this.label8.Name = "label8";
            this.label8.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label8.Size = new System.Drawing.Size(55, 25);
            this.label8.Text = "单号";
            // 
            // label9
            // 
            this.label9.DataMember = "REALID";
            this.label9.DisplayMember = "REALID";
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.label9.Location = new System.Drawing.Point(140, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 25);
            this.label9.Text = "label7";
            // 
            // lblStatus
            // 
            this.lblStatus.DataMember = "STATUSNAME";
            this.lblStatus.DisplayMember = "STATUSNAME";
            this.lblStatus.FontSize = 14F;
            this.lblStatus.Location = new System.Drawing.Point(200, 7);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 25);
            // 
            // imgFirstAss
            // 
            this.imgFirstAss.DisplayMember = "Image";
            this.imgFirstAss.Location = new System.Drawing.Point(10, 7);
            this.imgFirstAss.Name = "imgFirstAss";
            this.imgFirstAss.Size = new System.Drawing.Size(75, 75);
            // 
            // ibEdit
            // 
            this.ibEdit.Location = new System.Drawing.Point(220, 60);
            this.ibEdit.Name = "ibEdit";
            this.ibEdit.ResourceID = "edit1";
            this.ibEdit.Size = new System.Drawing.Size(30, 30);
            this.ibEdit.Press += new System.EventHandler(this.ibEdit_Press);
            // 
            // frmAssSOLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.svRow});
            this.Size = new System.Drawing.Size(260, 90);
            this.Name = "frmAssSOLayout";

        }
        #endregion
        private Smobiler.Core.Controls.SwipeView svRow;
        private Smobiler.Core.Controls.Panel plRow;
        private Smobiler.Core.Controls.Label lblName;
        private Smobiler.Core.Controls.Label label5;
        private Smobiler.Core.Controls.Label label7;
        private Smobiler.Core.Controls.Label label8;
        private Smobiler.Core.Controls.Label label9;
        public Smobiler.Core.Controls.Label lblStatus;
        private Smobiler.Core.Controls.Image imgFirstAss;
        internal Smobiler.Core.Controls.ImageButton ibEdit;
    }
}