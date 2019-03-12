using System;
using Smobiler.Core;
namespace SMOWMS.UI.Layout
{
    partial class frmAssSORowLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public frmAssSORowLayout()
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
            this.Image = new Smobiler.Core.Controls.Image();
            this.lblName = new Smobiler.Core.Controls.Label();
            this.LblTId = new Smobiler.Core.Controls.Label();
            this.numQuant = new Smobiler.Core.Controls.Numeric();
            this.numPrice = new Smobiler.Core.Controls.Numeric();
            this.labQuant1 = new Smobiler.Core.Controls.Label();
            this.labPrice1 = new Smobiler.Core.Controls.Label();
            // 
            // plRow
            // 
            this.plRow.BackColor = System.Drawing.Color.White;
            this.plRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plRow.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Image,
            this.lblName,
            this.LblTId,
            this.numQuant,
            this.numPrice,
            this.labQuant1,
            this.labPrice1});
            this.plRow.Name = "plRow";
            this.plRow.Size = new System.Drawing.Size(300, 84);
            this.plRow.Touchable = true;
            this.plRow.LongPress += new System.EventHandler(this.plRow_LongPress);
            // 
            // Image
            // 
            this.Image.DataMember = "IMAGE";
            this.Image.DisplayMember = "IMAGE";
            this.Image.Location = new System.Drawing.Point(9, 8);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(40, 40);
            this.Image.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.DataMember = "NAME";
            this.lblName.DisplayFormat = "名称:{0}";
            this.lblName.DisplayMember = "NAME";
            this.lblName.FontSize = 12F;
            this.lblName.Location = new System.Drawing.Point(58, 28);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.lblName.Size = new System.Drawing.Size(150, 16);
            this.lblName.Text = "资产条码";
            // 
            // LblTId
            // 
            this.LblTId.BackColor = System.Drawing.Color.White;
            this.LblTId.DataMember = "TEMPLATEID";
            this.LblTId.DisplayMember = "TEMPLATEID";
            this.LblTId.FontSize = 12F;
            this.LblTId.Location = new System.Drawing.Point(58, 8);
            this.LblTId.Name = "LblTId";
            this.LblTId.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.LblTId.Size = new System.Drawing.Size(234, 20);
            this.LblTId.Text = "资产条码";
            // 
            // numQuant
            // 
            this.numQuant.DataMember = "QUANT";
            this.numQuant.DisplayMember = "QUANT";
            this.numQuant.Location = new System.Drawing.Point(129, 44);
            this.numQuant.MaxValue = 999999F;
            this.numQuant.Name = "numQuant";
            this.numQuant.Size = new System.Drawing.Size(150, 16);
            // 
            // numPrice
            // 
            this.numPrice.DataMember = "PRICE";
            this.numPrice.DisplayMember = "PRICE";
            this.numPrice.Location = new System.Drawing.Point(129, 60);
            this.numPrice.MaxValue = 999999F;
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(150, 16);
            // 
            // labQuant1
            // 
            this.labQuant1.FontSize = 12F;
            this.labQuant1.Location = new System.Drawing.Point(69, 44);
            this.labQuant1.Name = "labQuant1";
            this.labQuant1.Size = new System.Drawing.Size(60, 16);
            this.labQuant1.Text = "销售数量：";
            // 
            // labPrice1
            // 
            this.labPrice1.FontSize = 12F;
            this.labPrice1.Location = new System.Drawing.Point(69, 60);
            this.labPrice1.Name = "labPrice1";
            this.labPrice1.Size = new System.Drawing.Size(60, 16);
            this.labPrice1.Text = "销售单价：";
            // 
            // frmAssSORowLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plRow});
            this.Size = new System.Drawing.Size(300, 84);
            this.Name = "frmAssSORowLayout";

        }
        #endregion

        internal Smobiler.Core.Controls.Panel plRow;
        internal Smobiler.Core.Controls.Image Image;
        internal Smobiler.Core.Controls.Label lblName;
        internal Smobiler.Core.Controls.Label LblTId;
        internal Smobiler.Core.Controls.Numeric numQuant;
        internal Smobiler.Core.Controls.Numeric numPrice;
        private Smobiler.Core.Controls.Label labQuant1;
        private Smobiler.Core.Controls.Label labPrice1;
    }
}