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
            this.label17 = new Smobiler.Core.Controls.Label();
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
            this.label17,
            this.label5,
            this.lblRealNumber,
            this.label6,
            this.lblNumber});
            this.plRow.Name = "plRow";
            this.plRow.Size = new System.Drawing.Size(300, 180);
            // 
            // image1
            // 
            this.image1.DataMember = "Image";
            this.image1.DisplayMember = "Image";
            this.image1.Location = new System.Drawing.Point(6, 8);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(45, 45);
            // 
            // label1
            // 
            this.label1.DataMember = "Name";
            this.label1.DisplayMember = "Name";
            this.label1.Location = new System.Drawing.Point(108, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.DataMember = "RESULTNAME";
            this.label2.DisplayMember = "RESULTNAME";
            this.label2.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label2.Location = new System.Drawing.Point(215, 18);
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.label2.Size = new System.Drawing.Size(77, 30);
            this.label2.Text = "状态";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label3.Size = new System.Drawing.Size(100, 30);
            this.label3.Text = "耗材编号";
            // 
            // label4
            // 
            this.label4.DataMember = "CID";
            this.label4.DisplayMember = "CID";
            this.label4.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label4.Location = new System.Drawing.Point(106, 55);
            this.label4.Name = "label4";
            this.label4.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.label4.Size = new System.Drawing.Size(186, 30);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 85);
            this.label9.Name = "label9";
            this.label9.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label9.Size = new System.Drawing.Size(100, 30);
            this.label9.Text = "所在库位";
            // 
            // label10
            // 
            this.label10.DataMember = "LOCID";
            this.label10.DisplayMember = "LOCNAME";
            this.label10.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label10.Location = new System.Drawing.Point(106, 85);
            this.label10.Name = "label10";
            this.label10.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.label10.Size = new System.Drawing.Size(186, 30);
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(51, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 30);
            this.label17.Text = "耗材名称";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 145);
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label5.Size = new System.Drawing.Size(100, 30);
            this.label5.Text = "实盘数量";
            // 
            // lblRealNumber
            // 
            this.lblRealNumber.DisplayMember = "REALAMOUNT";
            this.lblRealNumber.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblRealNumber.Location = new System.Drawing.Point(106, 145);
            this.lblRealNumber.Name = "lblRealNumber";
            this.lblRealNumber.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.lblRealNumber.Size = new System.Drawing.Size(186, 30);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 115);
            this.label6.Name = "label6";
            this.label6.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label6.Size = new System.Drawing.Size(100, 30);
            this.label6.Text = "应盘数量";
            // 
            // lblNumber
            // 
            this.lblNumber.DisplayMember = "Total";
            this.lblNumber.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblNumber.Location = new System.Drawing.Point(106, 115);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.lblNumber.Size = new System.Drawing.Size(186, 30);
            // 
            // frmCIResultLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plRow});
            this.Size = new System.Drawing.Size(0, 180);
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
        private Smobiler.Core.Controls.Label label17;
        private Smobiler.Core.Controls.Label label5;
        private Smobiler.Core.Controls.Label lblRealNumber;
        private Smobiler.Core.Controls.Label label6;
        private Smobiler.Core.Controls.Label lblNumber;
    }
}