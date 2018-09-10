using System;
using Smobiler.Core;
namespace SMOWMS.UI.Layout
{
    partial class frmConSalesResultLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public frmConSalesResultLayout()
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
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.label17 = new Smobiler.Core.Controls.Label();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.label8 = new Smobiler.Core.Controls.Label();
            this.lblQuantStored = new Smobiler.Core.Controls.Label();
            this.lblQuantRetreated = new Smobiler.Core.Controls.Label();
            this.label13 = new Smobiler.Core.Controls.Label();
            this.label14 = new Smobiler.Core.Controls.Label();
            this.lblQuantPurchased = new Smobiler.Core.Controls.Label();
            this.lblRealPrice = new Smobiler.Core.Controls.Label();
            // 
            // plRow
            // 
            this.plRow.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1,
            this.label1,
            this.label3,
            this.label4,
            this.label17,
            this.label7,
            this.label8,
            this.lblQuantStored,
            this.lblQuantRetreated,
            this.label13,
            this.label14,
            this.lblQuantPurchased,
            this.lblRealPrice});
            this.plRow.Name = "plRow";
            this.plRow.Size = new System.Drawing.Size(300, 150);
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
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(51, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 30);
            this.label17.Text = "耗材名称";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(149, 85);
            this.label7.Name = "label7";
            this.label7.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label7.Size = new System.Drawing.Size(70, 30);
            this.label7.Text = "出库数量";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(149, 115);
            this.label8.Name = "label8";
            this.label8.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label8.Size = new System.Drawing.Size(70, 30);
            this.label8.Text = "退库数量";
            // 
            // lblQuantStored
            // 
            this.lblQuantStored.DisplayMember = "QUANTOUT";
            this.lblQuantStored.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblQuantStored.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblQuantStored.Location = new System.Drawing.Point(219, 85);
            this.lblQuantStored.Name = "lblQuantStored";
            this.lblQuantStored.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.lblQuantStored.Size = new System.Drawing.Size(73, 30);
            // 
            // lblQuantRetreated
            // 
            this.lblQuantRetreated.DisplayMember = "QUANTRETREATED";
            this.lblQuantRetreated.ForeColor = System.Drawing.Color.Red;
            this.lblQuantRetreated.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblQuantRetreated.Location = new System.Drawing.Point(219, 115);
            this.lblQuantRetreated.Name = "lblQuantRetreated";
            this.lblQuantRetreated.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.lblQuantRetreated.Size = new System.Drawing.Size(73, 30);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(6, 85);
            this.label13.Name = "label13";
            this.label13.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label13.Size = new System.Drawing.Size(70, 30);
            this.label13.Text = "实售数量";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(6, 115);
            this.label14.Name = "label14";
            this.label14.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label14.Size = new System.Drawing.Size(70, 30);
            this.label14.Text = "实售单价";
            // 
            // lblQuantPurchased
            // 
            this.lblQuantPurchased.DisplayMember = "QUANTSALED";
            this.lblQuantPurchased.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblQuantPurchased.Location = new System.Drawing.Point(76, 85);
            this.lblQuantPurchased.Name = "lblQuantPurchased";
            this.lblQuantPurchased.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.lblQuantPurchased.Size = new System.Drawing.Size(73, 30);
            // 
            // lblRealPrice
            // 
            this.lblRealPrice.DisplayMember = "REALPRICE";
            this.lblRealPrice.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblRealPrice.Location = new System.Drawing.Point(76, 115);
            this.lblRealPrice.Name = "lblRealPrice";
            this.lblRealPrice.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.lblRealPrice.Size = new System.Drawing.Size(73, 30);
            // 
            // frmConSalesResultLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plRow});
            this.Size = new System.Drawing.Size(300, 150);
            this.Name = "frmConSalesResultLayout";

        }
        #endregion

        private Smobiler.Core.Controls.Panel plRow;
        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.Label label17;
        private Smobiler.Core.Controls.Label label7;
        private Smobiler.Core.Controls.Label label8;
        private Smobiler.Core.Controls.Label lblQuantStored;
        private Smobiler.Core.Controls.Label lblQuantRetreated;
        private Smobiler.Core.Controls.Label label13;
        private Smobiler.Core.Controls.Label label14;
        private Smobiler.Core.Controls.Label lblQuantPurchased;
        private Smobiler.Core.Controls.Label lblRealPrice;
    }
}