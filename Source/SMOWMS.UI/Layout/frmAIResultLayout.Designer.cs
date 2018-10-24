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
            this.plRow = new Smobiler.Core.Controls.Panel();
            this.image1 = new Smobiler.Core.Controls.Image();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.label8 = new Smobiler.Core.Controls.Label();
            this.label10 = new Smobiler.Core.Controls.Label();
            this.label12 = new Smobiler.Core.Controls.Label();
            this.label14 = new Smobiler.Core.Controls.Label();
            // 
            // plRow
            // 
            this.plRow.BackColor = System.Drawing.Color.White;
            this.plRow.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1,
            this.label1,
            this.label2,
            this.label4,
            this.label6,
            this.label8,
            this.label10,
            this.label12,
            this.label14});
            this.plRow.Name = "plRow";
            this.plRow.Size = new System.Drawing.Size(300, 120);
            // 
            // image1
            // 
            this.image1.DataMember = "Image";
            this.image1.DisplayMember = "Image";
            this.image1.Location = new System.Drawing.Point(12, 12);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(50, 50);
            // 
            // label1
            // 
            this.label1.DataMember = "Name";
            this.label1.DisplayMember = "Name";
            this.label1.Location = new System.Drawing.Point(72, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.DataMember = "RESULTNAME";
            this.label2.DisplayMember = "RESULTNAME";
            this.label2.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label2.Location = new System.Drawing.Point(215, 28);
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.Text = "状态";
            // 
            // label4
            // 
            this.label4.DataMember = "ASSID";
            this.label4.DisplayFormat = "条形码:{0}";
            this.label4.DisplayMember = "ASSID";
            this.label4.Location = new System.Drawing.Point(72, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 16);
            this.label4.Text = "label4";
            // 
            // label6
            // 
            this.label6.DataMember = "TypeName";
            this.label6.DisplayFormat = "资产分类:{0}";
            this.label6.DisplayMember = "TypeName";
            this.label6.Location = new System.Drawing.Point(72, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 16);
            this.label6.Text = "label6";
            // 
            // label8
            // 
            this.label8.DataMember = "SN";
            this.label8.DisplayFormat = "SN:{0}";
            this.label8.DisplayMember = "SN";
            this.label8.Location = new System.Drawing.Point(190, 8);
            this.label8.Name = "label8";
            this.label8.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.Text = "label8";
            // 
            // label10
            // 
            this.label10.DataMember = "Specification";
            this.label10.DisplayFormat = "规格型号:{0}";
            this.label10.DisplayMember = "Specification";
            this.label10.Location = new System.Drawing.Point(72, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 16);
            this.label10.Text = "label10";
            // 
            // label12
            // 
            this.label12.DataMember = "Price";
            this.label12.DisplayFormat = "价格:{0}";
            this.label12.DisplayMember = "Price";
            this.label12.Location = new System.Drawing.Point(72, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(186, 16);
            this.label12.Text = "label12";
            // 
            // label14
            // 
            this.label14.DataMember = "SLName";
            this.label14.DisplayFormat = "库位:{0}";
            this.label14.DisplayMember = "SLName";
            this.label14.Location = new System.Drawing.Point(72, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(186, 16);
            this.label14.Text = "label14";
            // 
            // frmAIResultLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plRow});
            this.Size = new System.Drawing.Size(300, 120);
            this.Name = "frmAIResultLayout";

        }
        #endregion

        private Smobiler.Core.Controls.Panel plRow;
        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.Label label6;
        private Smobiler.Core.Controls.Label label8;
        private Smobiler.Core.Controls.Label label10;
        private Smobiler.Core.Controls.Label label12;
        private Smobiler.Core.Controls.Label label14;
        public Smobiler.Core.Controls.Label label2;
    }
}