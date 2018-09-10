using System;
using Smobiler.Core;
namespace SMOWMS.UI.Layout
{
    partial class frmAssVenAnalysisLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

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
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.lblTId = new Smobiler.Core.Controls.Label();
            this.lblPurchase = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.lblName = new Smobiler.Core.Controls.Label();
            // 
            // plRow
            // 
            this.plRow.BackColor = System.Drawing.Color.White;
            this.plRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plRow.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Image,
            this.Label3,
            this.lblTId,
            this.lblPurchase,
            this.label4,
            this.lblName});
            this.plRow.Name = "plRow";
            this.plRow.Size = new System.Drawing.Size(300, 56);
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
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.White;
            this.Label3.FontSize = 12F;
            this.Label3.Location = new System.Drawing.Point(49, 28);
            this.Label3.Name = "Label3";
            this.Label3.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.Label3.Size = new System.Drawing.Size(57, 20);
            this.Label3.Text = "名称";
            // 
            // lblTId
            // 
            this.lblTId.BackColor = System.Drawing.Color.White;
            this.lblTId.DataMember = "VendorName";
            this.lblTId.DisplayMember = "VendorName";
            this.lblTId.FontSize = 12F;
            this.lblTId.Location = new System.Drawing.Point(106, 8);
            this.lblTId.Name = "lblTId";
            this.lblTId.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.lblTId.Size = new System.Drawing.Size(109, 20);
            this.lblTId.Text = "资产条码";
            // 
            // lblPurchase
            // 
            this.lblPurchase.BackColor = System.Drawing.Color.White;
            this.lblPurchase.DataMember = "QUANTPURCHAED";
            this.lblPurchase.DisplayMember = "QUANTPURCHAED";
            this.lblPurchase.FontSize = 24F;
            this.lblPurchase.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblPurchase.Location = new System.Drawing.Point(215, 8);
            this.lblPurchase.Name = "lblPurchase";
            this.lblPurchase.Size = new System.Drawing.Size(79, 40);
            this.lblPurchase.Text = "200";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.FontSize = 12F;
            this.label4.Location = new System.Drawing.Point(49, 8);
            this.label4.Name = "label4";
            this.label4.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.Text = "供应商";
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.DataMember = "NAME";
            this.lblName.DisplayMember = "NAME";
            this.lblName.FontSize = 12F;
            this.lblName.Location = new System.Drawing.Point(106, 28);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.lblName.Size = new System.Drawing.Size(109, 20);
            this.lblName.Text = "资产条码";
            // 
            // frmAssVenAnalysisLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plRow});
            this.Size = new System.Drawing.Size(300, 56);
            this.Name = "frmAssVenAnalysisLayout";

        }
        #endregion

        internal Smobiler.Core.Controls.Panel plRow;
        internal Smobiler.Core.Controls.Image Image;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.Label lblTId;
        internal Smobiler.Core.Controls.Label lblPurchase;
        internal Smobiler.Core.Controls.Label label4;
        internal Smobiler.Core.Controls.Label lblName;
    }
}