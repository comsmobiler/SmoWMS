using System;
using Smobiler.Core;
namespace SMOWMS.UI.Layout
{
    partial class frmCIResultLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public frmCIResultLayout()
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
            this.image1 = new Smobiler.Core.Controls.Image();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.label9 = new Smobiler.Core.Controls.Label();
            this.label10 = new Smobiler.Core.Controls.Label();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.lblRealNumber = new Smobiler.Core.Controls.Label();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.lblNumber = new Smobiler.Core.Controls.Label();
            // 
            // plRow
            // 
            this.plRow.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1,
            this.label1,
            this.label2,
            this.label3,
            this.label4,
            this.label9,
            this.label10,
            this.label5,
            this.lblRealNumber,
            this.label6,
            this.lblNumber});
            this.plRow.Name = "plRow";
            this.plRow.Size = new System.Drawing.Size(300, 105);
            // 
            // image1
            // 
            this.image1.DataMember = "Image";
            this.image1.DisplayMember = "Image";
            this.image1.Location = new System.Drawing.Point(6, 8);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(85, 85);
            // 
            // label1
            // 
            this.label1.DataMember = "Name";
            this.label1.DisplayMember = "Name";
            this.label1.Location = new System.Drawing.Point(99, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.DataMember = "RESULTNAME";
            this.label2.DisplayMember = "RESULTNAME";
            this.label2.FontSize = 11F;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.label2.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label2.Location = new System.Drawing.Point(215, 11);
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.Text = "状态";
            // 
            // label3
            // 
            this.label3.FontSize = 11F;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.label3.Location = new System.Drawing.Point(99, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.Text = "耗材编号:";
            // 
            // label4
            // 
            this.label4.DataMember = "CID";
            this.label4.DisplayMember = "CID";
            this.label4.FontSize = 11F;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.label4.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label4.Location = new System.Drawing.Point(154, 35);
            this.label4.Name = "label4";
            this.label4.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.label4.Size = new System.Drawing.Size(138, 15);
            // 
            // label9
            // 
            this.label9.FontSize = 11F;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.label9.Location = new System.Drawing.Point(99, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.Text = "所在库位:";
            // 
            // label10
            // 
            this.label10.DataMember = "LOCID";
            this.label10.DisplayMember = "LOCNAME";
            this.label10.FontSize = 11F;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.label10.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label10.Location = new System.Drawing.Point(154, 50);
            this.label10.Name = "label10";
            this.label10.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.label10.Size = new System.Drawing.Size(138, 15);
            // 
            // label5
            // 
            this.label5.FontSize = 11F;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.label5.Location = new System.Drawing.Point(99, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.Text = "实盘数量:";
            // 
            // lblRealNumber
            // 
            this.lblRealNumber.DisplayMember = "REALAMOUNT";
            this.lblRealNumber.FontSize = 11F;
            this.lblRealNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.lblRealNumber.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblRealNumber.Location = new System.Drawing.Point(154, 80);
            this.lblRealNumber.Name = "lblRealNumber";
            this.lblRealNumber.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.lblRealNumber.Size = new System.Drawing.Size(138, 15);
            // 
            // label6
            // 
            this.label6.FontSize = 11F;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.label6.Location = new System.Drawing.Point(99, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.Text = "应盘数量:";
            // 
            // lblNumber
            // 
            this.lblNumber.DisplayMember = "Total";
            this.lblNumber.FontSize = 11F;
            this.lblNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.lblNumber.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblNumber.Location = new System.Drawing.Point(154, 65);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.lblNumber.Size = new System.Drawing.Size(138, 15);
            // 
            // frmCIResultLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plRow});
            this.Size = new System.Drawing.Size(0, 105);
            this.Name = "frmCIResultLayout";

        }
        #endregion

        private Smobiler.Core.Controls.Panel plRow;
        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Label label1;
        public Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.Label label9;
        private Smobiler.Core.Controls.Label label10;
        private Smobiler.Core.Controls.Label label5;
        private Smobiler.Core.Controls.Label lblRealNumber;
        private Smobiler.Core.Controls.Label label6;
        private Smobiler.Core.Controls.Label lblNumber;
    }
}