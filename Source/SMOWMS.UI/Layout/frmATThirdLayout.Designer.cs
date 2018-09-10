using System;
using Smobiler.Core;
namespace SMOWMS.UI.Layout
{
    partial class frmATThirdLayout : Smobiler.Core.Controls.MobileUserControl
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
            this.ibEdit = new Smobiler.Core.Controls.ImageButton();
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
            this.ibEdit});
            this.plRow.Name = "plRow";
            this.plRow.Size = new System.Drawing.Size(300, 45);
            // 
            // lblName
            // 
            this.lblName.DataMember = "TYPEID";
            this.lblName.DisplayMember = "NAME";
            this.lblName.Location = new System.Drawing.Point(10, 0);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.lblName.Size = new System.Drawing.Size(195, 45);
            // 
            // ibEdit
            // 
            this.ibEdit.DataMember = "ISENABLE";
            this.ibEdit.ImgTextRatio = new Smobiler.Core.Controls.Ratio(10, 0);
            this.ibEdit.Location = new System.Drawing.Point(260, 5);
            this.ibEdit.Name = "ibEdit";
            this.ibEdit.ResourceID = "edit1";
            this.ibEdit.Size = new System.Drawing.Size(35, 35);
            this.ibEdit.Press += new System.EventHandler(this.ibEdit_Press);
            // 
            // frmATThirdLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.svRow});
            this.Size = new System.Drawing.Size(0, 45);
            this.Name = "frmATThirdLayout";

        }
        #endregion
        private Smobiler.Core.Controls.Panel plRow;
        internal Smobiler.Core.Controls.Label lblName;
        internal Smobiler.Core.Controls.SwipeView svRow;
        internal Smobiler.Core.Controls.ImageButton ibEdit;
    }
}