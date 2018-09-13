using System;
using Smobiler.Core;
namespace SMOWMS.UI.Layout
{
    partial class frmSafeQuantAnalyzeLayout : Smobiler.Core.Controls.MobileUserControl
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
            this.lblName = new Smobiler.Core.Controls.Label();
            this.lblCID = new Smobiler.Core.Controls.Label();
            this.lblSpec = new Smobiler.Core.Controls.Label();
            this.lblQuantity = new Smobiler.Core.Controls.Label();
            this.lblSafe = new Smobiler.Core.Controls.Label();
            // 
            // lblName
            // 
            this.lblName.Bold = true;
            this.lblName.DisplayMember = "NAME";
            this.lblName.FontSize = 15F;
            this.lblName.Name = "lblName";
            this.lblName.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.lblName.Size = new System.Drawing.Size(300, 35);
            // 
            // lblCID
            // 
            this.lblCID.DataMember = "CID";
            this.lblCID.DisplayFormat = "编号:{0}";
            this.lblCID.DisplayMember = "CID";
            this.lblCID.Location = new System.Drawing.Point(0, 35);
            this.lblCID.Name = "lblCID";
            this.lblCID.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.lblCID.Size = new System.Drawing.Size(150, 20);
            this.lblCID.Text = "lblCID";
            // 
            // lblSpec
            // 
            this.lblSpec.DataMember = "SPECIFICATION";
            this.lblSpec.DisplayFormat = "规格:{0}";
            this.lblSpec.DisplayMember = "SPECIFICATION";
            this.lblSpec.Location = new System.Drawing.Point(150, 35);
            this.lblSpec.Name = "lblSpec";
            this.lblSpec.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.lblSpec.Size = new System.Drawing.Size(150, 20);
            this.lblSpec.Text = "lblSpec";
            // 
            // lblQuantity
            // 
            this.lblQuantity.DataMember = "QUANTITY";
            this.lblQuantity.DisplayFormat = "当前库存:{0}";
            this.lblQuantity.DisplayMember = "QUANTITY";
            this.lblQuantity.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblQuantity.Location = new System.Drawing.Point(150, 55);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.lblQuantity.Size = new System.Drawing.Size(150, 20);
            this.lblQuantity.Text = "lblQuantity";
            // 
            // lblSafe
            // 
            this.lblSafe.DataMember = "SAFEFLOOR";
            this.lblSafe.DisplayFormat = "安全库存:{0}";
            this.lblSafe.DisplayMember = "SAFEFLOOR";
            this.lblSafe.Location = new System.Drawing.Point(0, 55);
            this.lblSafe.Name = "lblSafe";
            this.lblSafe.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.lblSafe.Size = new System.Drawing.Size(150, 20);
            this.lblSafe.Text = "lblSafe";
            // 
            // frmSafeQuantAnalyzeLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblName,
            this.lblCID,
            this.lblSpec,
            this.lblQuantity,
            this.lblSafe});
            this.Size = new System.Drawing.Size(0, 75);
            this.Name = "frmSafeQuantAnalyzeLayout";

        }
        #endregion

        private Smobiler.Core.Controls.Label lblName;
        private Smobiler.Core.Controls.Label lblCID;
        private Smobiler.Core.Controls.Label lblSpec;
        internal Smobiler.Core.Controls.Label lblQuantity;
        internal Smobiler.Core.Controls.Label lblSafe;
    }
}