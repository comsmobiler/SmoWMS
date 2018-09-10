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
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.Image = new Smobiler.Core.Controls.Image();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.lblName = new Smobiler.Core.Controls.Label();
            this.LblTId = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.numQuant = new Smobiler.Core.Controls.Numeric();
            this.numPrice = new Smobiler.Core.Controls.Numeric();
            this.label5 = new Smobiler.Core.Controls.Label();
            // 
            // plRow
            // 
            this.plRow.BackColor = System.Drawing.Color.White;
            this.plRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plRow.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label1,
            this.Image,
            this.Label3,
            this.lblName,
            this.LblTId,
            this.label4,
            this.numQuant,
            this.numPrice,
            this.label5});
            this.plRow.Name = "plRow";
            this.plRow.Size = new System.Drawing.Size(300, 96);
            this.plRow.Touchable = true;
            this.plRow.LongPress += new System.EventHandler(this.plRow_LongPress);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.White;
            this.Label1.FontSize = 12F;
            this.Label1.Location = new System.Drawing.Point(89, 28);
            this.Label1.Name = "Label1";
            this.Label1.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.Label1.Size = new System.Drawing.Size(57, 20);
            this.Label1.Text = "名称";
            // 
            // Image
            // 
            this.Image.DataMember = "IMAGE";
            this.Image.DisplayMember = "IMAGE";
            this.Image.Location = new System.Drawing.Point(9, 8);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(80, 80);
            this.Image.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.White;
            this.Label3.FontSize = 12F;
            this.Label3.Location = new System.Drawing.Point(89, 8);
            this.Label3.Name = "Label3";
            this.Label3.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.Label3.Size = new System.Drawing.Size(57, 20);
            this.Label3.Text = "模板编号";
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.DataMember = "NAME";
            this.lblName.DisplayMember = "NAME";
            this.lblName.FontSize = 12F;
            this.lblName.Location = new System.Drawing.Point(146, 28);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.lblName.Size = new System.Drawing.Size(154, 20);
            this.lblName.Text = "资产条码";
            // 
            // LblTId
            // 
            this.LblTId.BackColor = System.Drawing.Color.White;
            this.LblTId.DataMember = "TEMPLATEID";
            this.LblTId.DisplayMember = "TEMPLATEID";
            this.LblTId.FontSize = 12F;
            this.LblTId.Location = new System.Drawing.Point(146, 8);
            this.LblTId.Name = "LblTId";
            this.LblTId.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.LblTId.Size = new System.Drawing.Size(150, 20);
            this.LblTId.Text = "资产条码";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.FontSize = 12F;
            this.label4.Location = new System.Drawing.Point(89, 48);
            this.label4.Name = "label4";
            this.label4.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.Text = "销售数量";
            // 
            // numQuant
            // 
            this.numQuant.DataMember = "QUANT";
            this.numQuant.DisplayMember = "QUANT";
            this.numQuant.Location = new System.Drawing.Point(146, 48);
            this.numQuant.MaxValue = 999999F;
            this.numQuant.Name = "numQuant";
            this.numQuant.Size = new System.Drawing.Size(150, 20);
            // 
            // numPrice
            // 
            this.numPrice.DataMember = "PRICE";
            this.numPrice.DisplayMember = "PRICE";
            this.numPrice.Location = new System.Drawing.Point(146, 68);
            this.numPrice.MaxValue = 999999F;
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(150, 20);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.FontSize = 12F;
            this.label5.Location = new System.Drawing.Point(89, 68);
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.Text = "销售单价";
            // 
            // frmAssSORowLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plRow});
            this.Size = new System.Drawing.Size(300, 96);
            this.Name = "frmAssSORowLayout";

        }
        #endregion

        internal Smobiler.Core.Controls.Panel plRow;
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Image Image;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.Label lblName;
        internal Smobiler.Core.Controls.Label LblTId;
        internal Smobiler.Core.Controls.Label label4;
        internal Smobiler.Core.Controls.Numeric numQuant;
        internal Smobiler.Core.Controls.Numeric numPrice;
        internal Smobiler.Core.Controls.Label label5;
    }
}