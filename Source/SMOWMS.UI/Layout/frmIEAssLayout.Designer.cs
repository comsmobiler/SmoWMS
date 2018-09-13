using System;
using Smobiler.Core;
namespace SMOWMS.UI.Layout
{
    partial class frmIEAssLayout : Smobiler.Core.Controls.MobileUserControl
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
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.Image = new Smobiler.Core.Controls.Image();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.lblName = new Smobiler.Core.Controls.Label();
            this.LblTId = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.lblWareId = new Smobiler.Core.Controls.Label();
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
            this.lblWareId});
            this.plRow.Name = "plRow";
            this.plRow.Size = new System.Drawing.Size(300, 76);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.White;
            this.Label1.FontSize = 12F;
            this.Label1.Location = new System.Drawing.Point(69, 48);
            this.Label1.Name = "Label1";
            this.Label1.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.Label1.Size = new System.Drawing.Size(57, 20);
            this.Label1.Text = "过期时间";
            // 
            // Image
            // 
            this.Image.DataMember = "IMAGE";
            this.Image.DisplayMember = "IMAGE";
            this.Image.Location = new System.Drawing.Point(9, 8);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(60, 60);
            this.Image.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.White;
            this.Label3.FontSize = 12F;
            this.Label3.Location = new System.Drawing.Point(69, 8);
            this.Label3.Name = "Label3";
            this.Label3.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.Label3.Size = new System.Drawing.Size(57, 20);
            this.Label3.Text = "资产编号";
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.DataMember = "ExpiryDate";
            this.lblName.DisplayMember = "ExpiryDate";
            this.lblName.FontSize = 12F;
            this.lblName.Location = new System.Drawing.Point(126, 48);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.lblName.Size = new System.Drawing.Size(162, 20);
            this.lblName.Text = "资产条码";
            // 
            // LblTId
            // 
            this.LblTId.BackColor = System.Drawing.Color.White;
            this.LblTId.DataMember = "SN";
            this.LblTId.DisplayMember = "SN";
            this.LblTId.FontSize = 12F;
            this.LblTId.Location = new System.Drawing.Point(126, 28);
            this.LblTId.Name = "LblTId";
            this.LblTId.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.LblTId.Size = new System.Drawing.Size(162, 20);
            this.LblTId.Text = "资产条码";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.FontSize = 12F;
            this.label4.Location = new System.Drawing.Point(69, 28);
            this.label4.Name = "label4";
            this.label4.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.Text = "SN";
            // 
            // lblWareId
            // 
            this.lblWareId.BackColor = System.Drawing.Color.White;
            this.lblWareId.DataMember = "ASSID";
            this.lblWareId.DisplayMember = "ASSID";
            this.lblWareId.FontSize = 12F;
            this.lblWareId.Location = new System.Drawing.Point(126, 8);
            this.lblWareId.Name = "lblWareId";
            this.lblWareId.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.lblWareId.Size = new System.Drawing.Size(162, 20);
            this.lblWareId.Text = "资产条码";
            // 
            // frmIEAssLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plRow});
            this.Size = new System.Drawing.Size(300, 76);
            this.Name = "frmIEAssLayout";

        }
        #endregion

        internal Smobiler.Core.Controls.Panel plRow;
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Image Image;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.Label lblName;
        internal Smobiler.Core.Controls.Label LblTId;
        internal Smobiler.Core.Controls.Label label4;
        internal Smobiler.Core.Controls.Label lblWareId;
    }
}