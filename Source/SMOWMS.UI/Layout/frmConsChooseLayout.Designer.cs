using System;
using Smobiler.Core;
namespace SMOWMS.UI.Layout
{
    partial class frmConsChooseLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public frmConsChooseLayout()
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
            this.Check = new Smobiler.Core.Controls.CheckBox();
            this.imgCon = new Smobiler.Core.Controls.Image();
            this.lblName = new Smobiler.Core.Controls.Label();
            this.lblQuant = new Smobiler.Core.Controls.Label();
            this.numQuant = new Smobiler.Core.Controls.Numeric();
            this.lblPrice = new Smobiler.Core.Controls.Label();
            this.numPrice = new Smobiler.Core.Controls.Numeric();
            // 
            // plRow
            // 
            this.plRow.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Check,
            this.imgCon,
            this.lblName,
            this.lblQuant,
            this.numQuant,
            this.lblPrice,
            this.numPrice});
            this.plRow.Name = "plRow";
            this.plRow.Size = new System.Drawing.Size(300, 60);
            this.plRow.Touchable = true;
            this.plRow.Press += new System.EventHandler(this.plRow_Press);
            // 
            // Check
            // 
            this.Check.DisplayMember = "CHECK";
            this.Check.Location = new System.Drawing.Point(10, 20);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(25, 20);
            this.Check.ZIndex = 1;
            this.Check.CheckedChanged += new System.EventHandler(this.Check_CheckedChanged);
            // 
            // imgCon
            // 
            this.imgCon.BorderRadius = 15;
            this.imgCon.DataMember = "CID";
            this.imgCon.DisplayMember = "IMAGE";
            this.imgCon.Location = new System.Drawing.Point(45, 7);
            this.imgCon.Name = "imgCon";
            this.imgCon.Size = new System.Drawing.Size(45, 45);
            this.imgCon.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            // 
            // lblName
            // 
            this.lblName.DataMember = "NAME";
            this.lblName.DisplayFormat = "耗材名称: {0}";
            this.lblName.DisplayMember = "NAME";
            this.lblName.Location = new System.Drawing.Point(100, 0);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.lblName.Size = new System.Drawing.Size(200, 20);
            // 
            // lblQuant
            // 
            this.lblQuant.Location = new System.Drawing.Point(100, 20);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.lblQuant.Size = new System.Drawing.Size(100, 20);
            this.lblQuant.Text = "采购数量";
            // 
            // numQuant
            // 
            this.numQuant.DisplayFormat = null;
            this.numQuant.DisplayMember = "QUANTPURCHASED";
            this.numQuant.FontSize = 13F;
            this.numQuant.Location = new System.Drawing.Point(200, 20);
            this.numQuant.MaxValue = 10000;
            this.numQuant.MinusIconColor = System.Drawing.Color.Black;
            this.numQuant.Name = "numQuant";
            this.numQuant.Size = new System.Drawing.Size(100, 20);
            // 
            // lblPrice
            // 
            this.lblPrice.Location = new System.Drawing.Point(100, 40);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.lblPrice.Size = new System.Drawing.Size(100, 20);
            this.lblPrice.Text = "采购价格";
            // 
            // numPrice
            // 
            this.numPrice.DisplayFormat = null;
            this.numPrice.DisplayMember = "REALPRICE";
            this.numPrice.FontSize = 13F;
            this.numPrice.Location = new System.Drawing.Point(200, 40);
            this.numPrice.MaxValue = 10000;
            this.numPrice.MinusIconColor = System.Drawing.Color.Black;
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(100, 20);
            // 
            // frmConsChooseLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plRow});
            this.Size = new System.Drawing.Size(0, 60);
            this.Load += new System.EventHandler(this.frmConsChooseLayout_Load);
            this.Name = "frmConsChooseLayout";

        }
        #endregion
        private Smobiler.Core.Controls.Panel plRow;
        internal Smobiler.Core.Controls.CheckBox Check;
        internal Smobiler.Core.Controls.Image imgCon;
        internal Smobiler.Core.Controls.Label lblName;
        private Smobiler.Core.Controls.Label lblQuant;
        internal Smobiler.Core.Controls.Numeric numQuant;
        private Smobiler.Core.Controls.Label lblPrice;
        internal Smobiler.Core.Controls.Numeric numPrice;
    }
}