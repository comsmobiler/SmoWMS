using System;
using Smobiler.Core;
namespace SMOWMS.UI.Layout
{
    partial class frmAIResultLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public frmAIResultLayout()
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
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.image1 = new Smobiler.Core.Controls.Image();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.label8 = new Smobiler.Core.Controls.Label();
            this.label9 = new Smobiler.Core.Controls.Label();
            this.label10 = new Smobiler.Core.Controls.Label();
            this.label11 = new Smobiler.Core.Controls.Label();
            this.label12 = new Smobiler.Core.Controls.Label();
            this.label13 = new Smobiler.Core.Controls.Label();
            this.label14 = new Smobiler.Core.Controls.Label();
            this.label17 = new Smobiler.Core.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1,
            this.label1,
            this.label2,
            this.label3,
            this.label4,
            this.label5,
            this.label6,
            this.label7,
            this.label8,
            this.label9,
            this.label10,
            this.label11,
            this.label12,
            this.label13,
            this.label14,
            this.label17});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 239);
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
            this.label1.Location = new System.Drawing.Point(108, 8);
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
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label3.Size = new System.Drawing.Size(100, 30);
            this.label3.Text = "条形码";
            // 
            // label4
            // 
            this.label4.DataMember = "ASSID";
            this.label4.DisplayMember = "ASSID";
            this.label4.Location = new System.Drawing.Point(106, 53);
            this.label4.Name = "label4";
            this.label4.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.label4.Size = new System.Drawing.Size(186, 30);
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 83);
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label5.Size = new System.Drawing.Size(100, 30);
            this.label5.Text = "资产分类";
            // 
            // label6
            // 
            this.label6.DataMember = "TypeName";
            this.label6.DisplayMember = "TypeName";
            this.label6.Location = new System.Drawing.Point(106, 83);
            this.label6.Name = "label6";
            this.label6.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.label6.Size = new System.Drawing.Size(186, 30);
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 113);
            this.label7.Name = "label7";
            this.label7.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label7.Size = new System.Drawing.Size(100, 30);
            this.label7.Text = "SN";
            // 
            // label8
            // 
            this.label8.DataMember = "SN";
            this.label8.DisplayMember = "SN";
            this.label8.Location = new System.Drawing.Point(106, 113);
            this.label8.Name = "label8";
            this.label8.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.label8.Size = new System.Drawing.Size(186, 30);
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 143);
            this.label9.Name = "label9";
            this.label9.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label9.Size = new System.Drawing.Size(100, 30);
            this.label9.Text = "规格型号";
            // 
            // label10
            // 
            this.label10.DataMember = "Specification";
            this.label10.DisplayMember = "Specification";
            this.label10.Location = new System.Drawing.Point(106, 143);
            this.label10.Name = "label10";
            this.label10.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.label10.Size = new System.Drawing.Size(186, 30);
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(6, 173);
            this.label11.Name = "label11";
            this.label11.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label11.Size = new System.Drawing.Size(100, 30);
            this.label11.Text = "价格";
            // 
            // label12
            // 
            this.label12.DataMember = "Price";
            this.label12.DisplayMember = "Price";
            this.label12.Location = new System.Drawing.Point(106, 173);
            this.label12.Name = "label12";
            this.label12.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.label12.Size = new System.Drawing.Size(186, 30);
            this.label12.Text = "label12";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(6, 203);
            this.label13.Name = "label13";
            this.label13.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label13.Size = new System.Drawing.Size(100, 30);
            this.label13.Text = "库位";
            // 
            // label14
            // 
            this.label14.DataMember = "SLName";
            this.label14.DisplayMember = "SLName";
            this.label14.Location = new System.Drawing.Point(106, 203);
            this.label14.Name = "label14";
            this.label14.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.label14.Size = new System.Drawing.Size(186, 30);
            this.label14.Text = "label14";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(51, 8);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 30);
            this.label17.Text = "资产名称";
            // 
            // frmAIResultLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(300, 239);
            this.Name = "frmAIResultLayout";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.Label label5;
        private Smobiler.Core.Controls.Label label6;
        private Smobiler.Core.Controls.Label label7;
        private Smobiler.Core.Controls.Label label8;
        private Smobiler.Core.Controls.Label label9;
        private Smobiler.Core.Controls.Label label10;
        private Smobiler.Core.Controls.Label label11;
        private Smobiler.Core.Controls.Label label12;
        private Smobiler.Core.Controls.Label label13;
        private Smobiler.Core.Controls.Label label14;
        private Smobiler.Core.Controls.Label label17;
        public Smobiler.Core.Controls.Label label2;
    }
}