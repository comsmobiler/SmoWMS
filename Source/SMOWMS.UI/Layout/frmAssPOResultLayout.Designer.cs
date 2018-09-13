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
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.Image = new Smobiler.Core.Controls.Image();
            this.lblName = new Smobiler.Core.Controls.Label();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.label8 = new Smobiler.Core.Controls.Label();
            this.label9 = new Smobiler.Core.Controls.Label();
            this.label10 = new Smobiler.Core.Controls.Label();
            this.label11 = new Smobiler.Core.Controls.Label();
            this.label12 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.lblSTATUS = new Smobiler.Core.Controls.Label();
            this.lblQUANT = new Smobiler.Core.Controls.Label();
            this.lbPRICE = new Smobiler.Core.Controls.Label();
            // 
            // plRow
            // 
            this.plRow.BackColor = System.Drawing.Color.White;
            this.plRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plRow.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label1,
            this.Image,
            this.lblName,
            this.label5,
            this.label8,
            this.label9,
            this.label10,
            this.label11,
            this.label12,
            this.label2,
            this.lblSTATUS,
            this.lblQUANT,
            this.lbPRICE});
            this.plRow.Name = "plRow";
            this.plRow.Size = new System.Drawing.Size(300, 96);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.White;
            this.Label1.FontSize = 12F;
            this.Label1.Location = new System.Drawing.Point(88, 8);
            this.Label1.Name = "Label1";
            this.Label1.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.Label1.Size = new System.Drawing.Size(48, 20);
            this.Label1.Text = "名称";
            // 
            // Image
            // 
            this.Image.DataMember = "IMAGE";
            this.Image.DisplayMember = "IMAGE";
            this.Image.Location = new System.Drawing.Point(8, 8);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(80, 80);
            this.Image.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.DataMember = "POROWID";
            this.lblName.DisplayMember = "NAME";
            this.lblName.FontSize = 12F;
            this.lblName.Location = new System.Drawing.Point(136, 8);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.lblName.Size = new System.Drawing.Size(162, 20);
            this.lblName.Text = "资产条码";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.FontSize = 12F;
            this.label5.Location = new System.Drawing.Point(192, 68);
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.Text = "已退货";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.FontSize = 12F;
            this.label8.Location = new System.Drawing.Point(88, 48);
            this.label8.Name = "label8";
            this.label8.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.Text = "购买数";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.DataMember = "QUANTPURCHASED";
            this.label9.DisplayMember = "QUANTPURCHASED";
            this.label9.FontSize = 12F;
            this.label9.Location = new System.Drawing.Point(136, 48);
            this.label9.Name = "label9";
            this.label9.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.Text = "资产条码";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.FontSize = 12F;
            this.label10.Location = new System.Drawing.Point(192, 48);
            this.label10.Name = "label10";
            this.label10.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.Text = "单价";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.DataMember = "REALPRICE";
            this.label11.DisplayMember = "REALPRICE";
            this.label11.FontSize = 12F;
            this.label11.Location = new System.Drawing.Point(240, 48);
            this.label11.Name = "label11";
            this.label11.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.label11.Size = new System.Drawing.Size(56, 20);
            this.label11.Text = "资产条码";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.FontSize = 12F;
            this.label12.Location = new System.Drawing.Point(88, 68);
            this.label12.Name = "label12";
            this.label12.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label12.Size = new System.Drawing.Size(48, 20);
            this.label12.Text = "已入库";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FontSize = 12F;
            this.label2.Location = new System.Drawing.Point(88, 28);
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.Text = "状态";
            // 
            // lblSTATUS
            // 
            this.lblSTATUS.BackColor = System.Drawing.Color.White;
            this.lblSTATUS.DataMember = "STATUSNAME";
            this.lblSTATUS.DisplayMember = "STATUSNAME";
            this.lblSTATUS.FontSize = 12F;
            this.lblSTATUS.Location = new System.Drawing.Point(136, 28);
            this.lblSTATUS.Name = "lblSTATUS";
            this.lblSTATUS.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.lblSTATUS.Size = new System.Drawing.Size(162, 20);
            this.lblSTATUS.Text = "资产条码";
            // 
            // lblQUANT
            // 
            this.lblQUANT.BackColor = System.Drawing.Color.White;
            this.lblQUANT.DataMember = "QUANTSTORED";
            this.lblQUANT.DisplayMember = "QUANTSTORED";
            this.lblQUANT.FontSize = 12F;
            this.lblQUANT.Location = new System.Drawing.Point(136, 68);
            this.lblQUANT.Name = "lblQUANT";
            this.lblQUANT.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.lblQUANT.Size = new System.Drawing.Size(56, 20);
            this.lblQUANT.Text = "资产条码";
            // 
            // lbPRICE
            // 
            this.lbPRICE.BackColor = System.Drawing.Color.White;
            this.lbPRICE.DataMember = "QUANTRETREATED";
            this.lbPRICE.DisplayMember = "QUANTRETREATED";
            this.lbPRICE.FontSize = 12F;
            this.lbPRICE.Location = new System.Drawing.Point(240, 68);
            this.lbPRICE.Name = "lbPRICE";
            this.lbPRICE.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.lbPRICE.Size = new System.Drawing.Size(56, 20);
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
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Image Image;
        internal Smobiler.Core.Controls.Label lblName;
        internal Smobiler.Core.Controls.Label label5;
        internal Smobiler.Core.Controls.Label label8;
        internal Smobiler.Core.Controls.Label label9;
        internal Smobiler.Core.Controls.Label label10;
        internal Smobiler.Core.Controls.Label label11;
        internal Smobiler.Core.Controls.Label label12;
        internal Smobiler.Core.Controls.Label label2;
        internal Smobiler.Core.Controls.Label lblSTATUS;
        internal Smobiler.Core.Controls.Label lblQUANT;
        internal Smobiler.Core.Controls.Label lbPRICE;
    }
}