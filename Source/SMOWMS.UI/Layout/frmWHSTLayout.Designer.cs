using System;
using Smobiler.Core;
namespace SMOWMS.UI.Layout
{
    partial class frmWHSTLayout : Smobiler.Core.Controls.MobileUserControl
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
            this.svRow = new Smobiler.Core.Controls.SwipeView();
            this.plRow = new Smobiler.Core.Controls.Panel();
            this.lblName = new Smobiler.Core.Controls.Label();
            this.lblNext = new Smobiler.Core.Controls.Label();
            // 
            // svRow
            // 
            this.svRow.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plRow});
            this.svRow.Name = "svRow";
            this.svRow.RightControlName = "svEnable";
            this.svRow.Size = new System.Drawing.Size(300, 45);
            // 
            // plRow
            // 
            this.plRow.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblName,
            this.lblNext});
            this.plRow.Name = "plRow";
            this.plRow.Size = new System.Drawing.Size(300, 45);
            this.plRow.Touchable = true;
            this.plRow.TouchOpacity = 100;
            this.plRow.Press += new System.EventHandler(this.plRow_Press);
            // 
            // lblName
            // 
            this.lblName.DataMember = "STID";
            this.lblName.DisplayMember = "NAME";
            this.lblName.Location = new System.Drawing.Point(10, 0);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.lblName.Size = new System.Drawing.Size(195, 45);
            // 
            // lblNext
            // 
            this.lblNext.BackColor = System.Drawing.Color.White;
            this.lblNext.DataMember = "ISENABLE";
            this.lblNext.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lblNext.Location = new System.Drawing.Point(260, 0);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(40, 45);
            this.lblNext.Text = ">";
            // 
            // frmWHSTLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.svRow});
            this.Size = new System.Drawing.Size(0, 45);
            this.Name = "frmWHSTLayout";

        }
        #endregion

        internal Smobiler.Core.Controls.SwipeView svRow;
        private Smobiler.Core.Controls.Panel plRow;
        internal Smobiler.Core.Controls.Label lblName;
        internal Smobiler.Core.Controls.Label lblNext;
    }
}