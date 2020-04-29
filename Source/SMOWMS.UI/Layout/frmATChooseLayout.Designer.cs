using System;
using Smobiler.Core;
namespace SMOWMS.UI.Layout
{
    partial class frmATChooseLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public frmATChooseLayout()
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
            this.LblTId = new Smobiler.Core.Controls.Label();
            this.numQuant = new Smobiler.Core.Controls.Numeric();
            this.numPrice = new Smobiler.Core.Controls.Numeric();
            this.labQuant = new Smobiler.Core.Controls.Label();
            this.labPrice = new Smobiler.Core.Controls.Label();
            // 
            // plRow
            // 
            this.plRow.BackColor = System.Drawing.Color.White;
            this.plRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plRow.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.CheckBox1,
            this.Image,
            this.lblName,
            this.LblTId,
            this.numQuant,
            this.numPrice,
            this.labQuant,
            this.labPrice});
            this.plRow.Name = "plRow";
            this.plRow.Size = new System.Drawing.Size(300, 84);
            this.plRow.Touchable = true;
            this.plRow.Press += new System.EventHandler(this.plRow_Press);
            // 
            // CheckBox1
            // 
            this.CheckBox1.DataMember = "IsChecked";
            this.CheckBox1.DisplayMember = "IsChecked";
            this.CheckBox1.Location = new System.Drawing.Point(8, 32);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(20, 20);
            this.CheckBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // Image
            // 
            this.Image.DataMember = "IMAGE";
            this.Image.DisplayMember = "IMAGE";
            this.Image.Location = new System.Drawing.Point(35, 8);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(68, 68);
            this.Image.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.DataMember = "NAME";
            this.lblName.DisplayFormat = "名称:{0}";
            this.lblName.DisplayMember = "NAME";
            this.lblName.FontSize = 12F;
            this.lblName.Location = new System.Drawing.Point(103, 28);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.lblName.Size = new System.Drawing.Size(181, 16);
            this.lblName.Text = "资产条码";
            // 
            // LblTId
            // 
            this.LblTId.BackColor = System.Drawing.Color.White;
            this.LblTId.DataMember = "TEMPLATEID";
            this.LblTId.DisplayMember = "TEMPLATEID";
            this.LblTId.FontSize = 12F;
            this.LblTId.Location = new System.Drawing.Point(103, 8);
            this.LblTId.Name = "LblTId";
            this.LblTId.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.LblTId.Size = new System.Drawing.Size(181, 20);
            this.LblTId.Text = "资产条码";
            // 
            // numQuant
            // 
            this.numQuant.DataMember = "QUANT";
            this.numQuant.DisplayMember = "QUANT";
            this.numQuant.Location = new System.Drawing.Point(160, 44);
            this.numQuant.MaxValue = 999999;
            this.numQuant.Name = "numQuant";
            this.numQuant.Size = new System.Drawing.Size(124, 16);
            // 
            // numPrice
            // 
            this.numPrice.DataMember = "PRICE";
            this.numPrice.DisplayMember = "PRICE";
            this.numPrice.Location = new System.Drawing.Point(160, 60);
            this.numPrice.MaxValue = 999999;
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(124, 16);
            // 
            // labQuant
            // 
            this.labQuant.FontSize = 12F;
            this.labQuant.Location = new System.Drawing.Point(114, 44);
            this.labQuant.Name = "labQuant";
            this.labQuant.Size = new System.Drawing.Size(46, 16);
            this.labQuant.Text = "数量:";
            // 
            // labPrice
            // 
            this.labPrice.FontSize = 12F;
            this.labPrice.Location = new System.Drawing.Point(114, 60);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(46, 16);
            this.labPrice.Text = "价格:";
            // 
            // frmATChooseLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plRow});
            this.Size = new System.Drawing.Size(300, 84);
            this.Name = "frmATChooseLayout";

        }
        #endregion

        internal Smobiler.Core.Controls.Panel plRow;
        internal Smobiler.Core.Controls.CheckBox CheckBox1;
        internal Smobiler.Core.Controls.Image Image;
        internal Smobiler.Core.Controls.Label lblName;
        internal Smobiler.Core.Controls.Label LblTId;
        internal Smobiler.Core.Controls.Numeric numQuant;
        internal Smobiler.Core.Controls.Numeric numPrice;
        private Smobiler.Core.Controls.Label labQuant;
        private Smobiler.Core.Controls.Label labPrice;
    }
}