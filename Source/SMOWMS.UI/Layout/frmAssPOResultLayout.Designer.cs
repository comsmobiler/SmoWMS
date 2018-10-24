using System;
using Smobiler.Core;
namespace SMOWMS.UI.Layout
{
    partial class frmAssPOResultLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public frmAssPOResultLayout()
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
            this.label9 = new Smobiler.Core.Controls.Label();
            this.label11 = new Smobiler.Core.Controls.Label();
            this.lblSTATUS = new Smobiler.Core.Controls.Label();
            this.lblQUANT = new Smobiler.Core.Controls.Label();
            this.lbPRICE = new Smobiler.Core.Controls.Label();
            // 
            // plRow
            // 
            this.plRow.BackColor = System.Drawing.Color.White;
            this.plRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plRow.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Image,
            this.lblName,
            this.label9,
            this.label11,
            this.lblSTATUS,
            this.lblQUANT,
            this.lbPRICE});
            this.plRow.Name = "plRow";
            this.plRow.Size = new System.Drawing.Size(300, 96);
            // 
            // Image
            // 
            this.Image.DataMember = "IMAGE";
            this.Image.DisplayMember = "IMAGE";
            this.Image.Location = new System.Drawing.Point(8, 8);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(40, 40);
            this.Image.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.DataMember = "POROWID";
            this.lblName.DisplayMember = "NAME";
            this.lblName.FontSize = 12F;
            this.lblName.Location = new System.Drawing.Point(58, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(180, 20);
            this.lblName.Text = "资产条码";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.DataMember = "QUANTPURCHASED";
            this.label9.DisplayFormat = "购买数:{0}";
            this.label9.DisplayMember = "QUANTPURCHASED";
            this.label9.FontSize = 12F;
            this.label9.Location = new System.Drawing.Point(58, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 16);
            this.label9.Text = "资产条码";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.DataMember = "REALPRICE";
            this.label11.DisplayFormat = "单价:{0}";
            this.label11.DisplayMember = "REALPRICE";
            this.label11.FontSize = 12F;
            this.label11.Location = new System.Drawing.Point(58, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(180, 16);
            this.label11.Text = "资产条码";
            // 
            // lblSTATUS
            // 
            this.lblSTATUS.BackColor = System.Drawing.Color.White;
            this.lblSTATUS.DataMember = "STATUSNAME";
            this.lblSTATUS.DisplayMember = "STATUSNAME";
            this.lblSTATUS.FontSize = 12F;
            this.lblSTATUS.Location = new System.Drawing.Point(238, 8);
            this.lblSTATUS.Name = "lblSTATUS";
            this.lblSTATUS.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.lblSTATUS.Size = new System.Drawing.Size(58, 20);
            this.lblSTATUS.Text = "资产条码";
            // 
            // lblQUANT
            // 
            this.lblQUANT.BackColor = System.Drawing.Color.White;
            this.lblQUANT.DataMember = "QUANTSTORED";
            this.lblQUANT.DisplayFormat = "已入库:{0}";
            this.lblQUANT.DisplayMember = "QUANTSTORED";
            this.lblQUANT.FontSize = 12F;
            this.lblQUANT.Location = new System.Drawing.Point(58, 60);
            this.lblQUANT.Name = "lblQUANT";
            this.lblQUANT.Size = new System.Drawing.Size(180, 16);
            this.lblQUANT.Text = "资产条码";
            // 
            // lbPRICE
            // 
            this.lbPRICE.BackColor = System.Drawing.Color.White;
            this.lbPRICE.DataMember = "QUANTRETREATED";
            this.lbPRICE.DisplayFormat = "已退货:{0}";
            this.lbPRICE.DisplayMember = "QUANTRETREATED";
            this.lbPRICE.FontSize = 12F;
            this.lbPRICE.Location = new System.Drawing.Point(58, 76);
            this.lbPRICE.Name = "lbPRICE";
            this.lbPRICE.Size = new System.Drawing.Size(180, 16);
            this.lbPRICE.Text = "资产条码";
            // 
            // frmAssPOResultLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plRow});
            this.Size = new System.Drawing.Size(300, 96);
            this.Name = "frmAssPOResultLayout";

        }
        #endregion

        internal Smobiler.Core.Controls.Panel plRow;
        internal Smobiler.Core.Controls.Image Image;
        internal Smobiler.Core.Controls.Label lblName;
        internal Smobiler.Core.Controls.Label label9;
        internal Smobiler.Core.Controls.Label label11;
        internal Smobiler.Core.Controls.Label lblSTATUS;
        internal Smobiler.Core.Controls.Label lblQUANT;
        internal Smobiler.Core.Controls.Label lbPRICE;
    }
}