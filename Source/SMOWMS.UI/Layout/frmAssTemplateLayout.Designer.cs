using System;
using Smobiler.Core;
namespace SMOWMS.UI.Layout
{
    partial class frmAssTemplateLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public frmAssTemplateLayout()
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
            this.CheckBox1 = new Smobiler.Core.Controls.CheckBox();
            this.Image = new Smobiler.Core.Controls.Image();
            this.lblName = new Smobiler.Core.Controls.Label();
            this.LblTemplateId = new Smobiler.Core.Controls.Label();
            // 
            // plRow
            // 
            this.plRow.BackColor = System.Drawing.Color.White;
            this.plRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plRow.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.CheckBox1,
            this.Image,
            this.lblName,
            this.LblTemplateId});
            this.plRow.Name = "plRow";
            this.plRow.Size = new System.Drawing.Size(300, 52);
            this.plRow.Touchable = true;
            this.plRow.Press += new System.EventHandler(this.plRow_Press);
            // 
            // CheckBox1
            // 
            this.CheckBox1.DataMember = "IsChecked";
            this.CheckBox1.DisplayMember = "IsChecked";
            this.CheckBox1.Location = new System.Drawing.Point(8, 16);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(18, 18);
            this.CheckBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // Image
            // 
            this.Image.DataMember = "IMAGE";
            this.Image.DisplayMember = "IMAGE";
            this.Image.Location = new System.Drawing.Point(35, 8);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(36, 36);
            this.Image.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.DataMember = "NAME";
            this.lblName.DisplayFormat = "模板名称:{0}";
            this.lblName.DisplayMember = "NAME";
            this.lblName.FontSize = 12F;
            this.lblName.Location = new System.Drawing.Point(81, 28);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.lblName.Size = new System.Drawing.Size(215, 16);
            this.lblName.Text = "资产条码";
            // 
            // LblTemplateId
            // 
            this.LblTemplateId.BackColor = System.Drawing.Color.White;
            this.LblTemplateId.DataMember = "TEMPLATEID";
            this.LblTemplateId.DisplayMember = "TEMPLATEID";
            this.LblTemplateId.FontSize = 12F;
            this.LblTemplateId.Location = new System.Drawing.Point(81, 8);
            this.LblTemplateId.Name = "LblTemplateId";
            this.LblTemplateId.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.LblTemplateId.Size = new System.Drawing.Size(215, 20);
            this.LblTemplateId.Text = "资产条码";
            // 
            // frmAssTemplateLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plRow});
            this.Size = new System.Drawing.Size(300, 52);
            this.Name = "frmAssTemplateLayout";

        }
        #endregion

        internal Smobiler.Core.Controls.Panel plRow;
        internal Smobiler.Core.Controls.CheckBox CheckBox1;
        internal Smobiler.Core.Controls.Image Image;
        internal Smobiler.Core.Controls.Label lblName;
        internal Smobiler.Core.Controls.Label LblTemplateId;
    }
}