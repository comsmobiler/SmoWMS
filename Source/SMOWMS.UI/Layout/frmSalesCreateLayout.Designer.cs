using System;
using Smobiler.Core;
namespace SMOWMS.UI.Layout
{
    partial class frmSalesCreateLayout : Smobiler.Core.Controls.MobileUserControl
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
            this.imgCon = new Smobiler.Core.Controls.Image();
            this.lblName = new Smobiler.Core.Controls.Label();
            this.numQuant = new Smobiler.Core.Controls.Numeric();
            this.lblQuant = new Smobiler.Core.Controls.Label();
            this.lblPrice = new Smobiler.Core.Controls.Label();
            this.numPrice = new Smobiler.Core.Controls.Numeric();
            // 
            // plRow
            // 
            this.plRow.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imgCon,
            this.lblName,
            this.numQuant,
            this.lblQuant,
            this.lblPrice,
            this.numPrice});
            this.plRow.Name = "plRow";
            this.plRow.Size = new System.Drawing.Size(300, 60);
            this.plRow.Touchable = true;
            this.plRow.LongPress += new System.EventHandler(this.plRow_LongPress);
            // 
            // imgCon
            // 
            this.imgCon.BorderRadius = 15;
            this.imgCon.DisplayMember = "IMAGE";
            this.imgCon.Location = new System.Drawing.Point(12, 7);
            this.imgCon.Name = "imgCon";
            this.imgCon.Size = new System.Drawing.Size(45, 45);
            this.imgCon.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            // 
            // lblName
            // 
            this.lblName.DataMember = "CID";
            this.lblName.DisplayFormat = "耗材名称: {0}";
            this.lblName.DisplayMember = "NAME";
            this.lblName.Location = new System.Drawing.Point(70, 0);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.lblName.Size = new System.Drawing.Size(230, 20);
            this.lblName.Text = "耗材名称: 书包";
            // 
            // numQuant
            // 
            this.numQuant.DisplayFormat = null;
            this.numQuant.DisplayMember = "QUANTSALED";
            this.numQuant.FontSize = 13F;
            this.numQuant.Location = new System.Drawing.Point(170, 20);
            this.numQuant.MaxValue = 10000;
            this.numQuant.MinusIconColor = System.Drawing.Color.Black;
            this.numQuant.Name = "numQuant";
            this.numQuant.Size = new System.Drawing.Size(130, 20);
            // 
            // lblQuant
            // 
            this.lblQuant.Location = new System.Drawing.Point(70, 20);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.lblQuant.Size = new System.Drawing.Size(100, 20);
            this.lblQuant.Text = "销售数量";
            // 
            // lblPrice
            // 
            this.lblPrice.Location = new System.Drawing.Point(70, 40);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.lblPrice.Size = new System.Drawing.Size(100, 20);
            this.lblPrice.Text = "销售价格";
            // 
            // numPrice
            // 
            this.numPrice.DisplayFormat = null;
            this.numPrice.DisplayMember = "REALPRICE";
            this.numPrice.FontSize = 13F;
            this.numPrice.Location = new System.Drawing.Point(170, 40);
            this.numPrice.MaxValue = 10000;
            this.numPrice.MinusIconColor = System.Drawing.Color.Black;
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(130, 20);
            // 
            // frmSalesCreateLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plRow});
            this.Size = new System.Drawing.Size(0, 60);
            this.Name = "frmSalesCreateLayout";

        }
        #endregion

        internal Smobiler.Core.Controls.Panel plRow;
        internal Smobiler.Core.Controls.Image imgCon;
        internal Smobiler.Core.Controls.Label lblName;
        internal Smobiler.Core.Controls.Numeric numQuant;
        private Smobiler.Core.Controls.Label lblQuant;
        private Smobiler.Core.Controls.Label lblPrice;
        internal Smobiler.Core.Controls.Numeric numPrice;
    }
}