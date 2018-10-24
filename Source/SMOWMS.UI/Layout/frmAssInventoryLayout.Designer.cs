using System;
using Smobiler.Core;
namespace SMOWMS.UI.Layout
{
    partial class frmAssInventoryLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public frmAssInventoryLayout()
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
            this.plRow = new Smobiler.Core.Controls.Panel();
            this.lblName = new Smobiler.Core.Controls.Label();
            this.lblDate = new Smobiler.Core.Controls.Label();
            this.lblCreateMan = new Smobiler.Core.Controls.Label();
            this.lblCount = new Smobiler.Core.Controls.Label();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.image1 = new Smobiler.Core.Controls.Image();
            this.ibEdit = new Smobiler.Core.Controls.ImageButton();
            // 
            // plRow
            // 
            this.plRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plRow.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblName,
            this.lblDate,
            this.lblCreateMan,
            this.lblCount,
            this.label1,
            this.image1,
            this.ibEdit});
            this.plRow.Name = "plRow";
            this.plRow.Size = new System.Drawing.Size(300, 93);
            this.plRow.Touchable = true;
            this.plRow.Press += new System.EventHandler(this.panel1_Press);
            // 
            // lblName
            // 
            this.lblName.DataMember = "IID";
            this.lblName.DisplayMember = "NAME";
            this.lblName.Location = new System.Drawing.Point(50, 9);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.lblName.Size = new System.Drawing.Size(150, 20);
            this.lblName.Text = "label1";
            // 
            // lblDate
            // 
            this.lblDate.DataMember = "Time";
            this.lblDate.DisplayMember = "Time";
            this.lblDate.FontSize = 11F;
            this.lblDate.Location = new System.Drawing.Point(230, 10);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(90, 16);
            this.lblDate.Text = "label3";
            // 
            // lblCreateMan
            // 
            this.lblCreateMan.DataMember = "CREATEUSER";
            this.lblCreateMan.DisplayFormat = "盘点人:{0}";
            this.lblCreateMan.DisplayMember = "CREATEUSER";
            this.lblCreateMan.Location = new System.Drawing.Point(50, 32);
            this.lblCreateMan.Name = "lblCreateMan";
            this.lblCreateMan.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.lblCreateMan.Size = new System.Drawing.Size(150, 16);
            this.lblCreateMan.Text = "label5";
            // 
            // lblCount
            // 
            this.lblCount.DataMember = "Result";
            this.lblCount.DisplayFormat = "已盘点:{0}";
            this.lblCount.DisplayMember = "Result";
            this.lblCount.Location = new System.Drawing.Point(50, 47);
            this.lblCount.Name = "lblCount";
            this.lblCount.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.lblCount.Size = new System.Drawing.Size(150, 16);
            this.lblCount.Text = "label9";
            // 
            // label1
            // 
            this.label1.DataMember = "STATUSNAME";
            this.label1.DisplayMember = "STATUSNAME";
            this.label1.Location = new System.Drawing.Point(50, 69);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(100, 16);
            // 
            // image1
            // 
            this.image1.BorderRadius = 14;
            this.image1.DataMember = "Image";
            this.image1.DisplayMember = "Image";
            this.image1.Location = new System.Drawing.Point(12, 12);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(29, 29);
            this.image1.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            // 
            // ibEdit
            // 
            this.ibEdit.ImageDirection = Smobiler.Core.Controls.Direction.Left;
            this.ibEdit.ImgTextRatio = new Smobiler.Core.Controls.Ratio(10, 0);
            this.ibEdit.ItemAlign = Smobiler.Core.Controls.LayoutItemAlign.Center;
            this.ibEdit.Location = new System.Drawing.Point(261, 56);
            this.ibEdit.Name = "ibEdit";
            this.ibEdit.ResourceID = "48-edit";
            this.ibEdit.Size = new System.Drawing.Size(29, 29);
            this.ibEdit.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            this.ibEdit.Press += new System.EventHandler(this.ibEdit_Press);
            // 
            // frmAssInventoryLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plRow});
            this.Size = new System.Drawing.Size(300, 93);
            this.Name = "frmAssInventoryLayout";

        }
        #endregion

        private Smobiler.Core.Controls.Panel plRow;
        private Smobiler.Core.Controls.Label lblName;
        private Smobiler.Core.Controls.Label lblDate;
        private Smobiler.Core.Controls.Label lblCreateMan;
        private Smobiler.Core.Controls.Label lblCount;
        public Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Image image1;
        internal Smobiler.Core.Controls.ImageButton ibEdit;
    }
}