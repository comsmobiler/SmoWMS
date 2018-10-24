using System;
using Smobiler.Core;
namespace SMOWMS.UI.Layout
{
    partial class frmConInventoryLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public frmConInventoryLayout()
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
            this.lblCreateManName = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.lblCreateMan = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.lblCount = new Smobiler.Core.Controls.Label();
            this.lblStatus = new Smobiler.Core.Controls.Label();
            this.lblDate = new Smobiler.Core.Controls.Label();
            this.ibEdit = new Smobiler.Core.Controls.ImageButton();
            // 
            // svRow
            // 
            this.svRow.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plRow});
            this.svRow.Name = "svRow";
            this.svRow.RightControlName = "svCIDelete";
            this.svRow.Size = new System.Drawing.Size(300, 100);
            // 
            // plRow
            // 
            this.plRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plRow.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblName,
            this.lblCreateManName,
            this.label4,
            this.lblCreateMan,
            this.label3,
            this.lblCount,
            this.lblStatus,
            this.lblDate,
            this.ibEdit});
            this.plRow.Name = "plRow";
            this.plRow.Size = new System.Drawing.Size(300, 100);
            this.plRow.Touchable = true;
            this.plRow.TouchOpacity = 100;
            this.plRow.Press += new System.EventHandler(this.plRow_Press);
            // 
            // lblName
            // 
            this.lblName.DataMember = "IID";
            this.lblName.DisplayMember = "NAME";
            this.lblName.Location = new System.Drawing.Point(50, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 18);
            this.lblName.Text = "label1";
            // 
            // lblCreateManName
            // 
            this.lblCreateManName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(199)))), ((int)(((byte)(245)))));
            this.lblCreateManName.BorderRadius = 13;
            this.lblCreateManName.DataMember = "CREATEUSERNAME";
            this.lblCreateManName.DisplayMember = "CREATEUSERNAME";
            this.lblCreateManName.ForeColor = System.Drawing.Color.White;
            this.lblCreateManName.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lblCreateManName.Location = new System.Drawing.Point(14, 12);
            this.lblCreateManName.Name = "lblCreateManName";
            this.lblCreateManName.Size = new System.Drawing.Size(25, 26);
            this.lblCreateManName.Text = "张";
            // 
            // label4
            // 
            this.label4.FontSize = 11F;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.label4.Location = new System.Drawing.Point(50, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.Text = "盘点人：";
            // 
            // lblCreateMan
            // 
            this.lblCreateMan.DisplayMember = "CREATEUSER";
            this.lblCreateMan.FontSize = 11F;
            this.lblCreateMan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.lblCreateMan.Location = new System.Drawing.Point(100, 35);
            this.lblCreateMan.Name = "lblCreateMan";
            this.lblCreateMan.Padding = new Smobiler.Core.Controls.Padding(2F, 0F, 0F, 0F);
            this.lblCreateMan.Size = new System.Drawing.Size(50, 15);
            // 
            // label3
            // 
            this.label3.FontSize = 11F;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.label3.Location = new System.Drawing.Point(50, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.Text = "已盘点：";
            // 
            // lblCount
            // 
            this.lblCount.DisplayMember = "COUNT";
            this.lblCount.FontSize = 11F;
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.lblCount.Location = new System.Drawing.Point(100, 50);
            this.lblCount.Name = "lblCount";
            this.lblCount.Padding = new Smobiler.Core.Controls.Padding(2F, 0F, 0F, 0F);
            this.lblCount.Size = new System.Drawing.Size(50, 15);
            // 
            // lblStatus
            // 
            this.lblStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.lblStatus.DataMember = "STATUSNAME";
            this.lblStatus.DisplayMember = "STATUSNAME";
            this.lblStatus.FontSize = 11F;
            this.lblStatus.Location = new System.Drawing.Point(50, 75);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 15);
            // 
            // lblDate
            // 
            this.lblDate.DataMember = "Time";
            this.lblDate.DisplayMember = "Time";
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.lblDate.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lblDate.Location = new System.Drawing.Point(201, 5);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(90, 30);
            this.lblDate.Text = "label3";
            // 
            // ibEdit
            // 
            this.ibEdit.Location = new System.Drawing.Point(261, 60);
            this.ibEdit.Name = "ibEdit";
            this.ibEdit.ResourceID = "icon-edit";
            this.ibEdit.Size = new System.Drawing.Size(30, 30);
            this.ibEdit.Press += new System.EventHandler(this.ibEdit_Press);
            // 
            // frmConInventoryLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.svRow});
            this.Size = new System.Drawing.Size(300, 100);
            this.Name = "frmConInventoryLayout";

        }
        #endregion
        private Smobiler.Core.Controls.SwipeView svRow;
        private Smobiler.Core.Controls.Panel plRow;
        private Smobiler.Core.Controls.Label lblName;
        private Smobiler.Core.Controls.Label lblCreateManName;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.Label lblCreateMan;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Label lblCount;
        public Smobiler.Core.Controls.Label lblStatus;
        private Smobiler.Core.Controls.Label lblDate;
        internal Smobiler.Core.Controls.ImageButton ibEdit;
    }
}