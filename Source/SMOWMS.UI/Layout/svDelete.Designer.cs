using System;
using Smobiler.Core;
namespace SMOWMS.UI.Layout
{
    partial class svDelete : Smobiler.Core.Controls.MobileUserControl
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
            this.btnDelRow = new Smobiler.Core.Controls.Button();
            // 
            // btnDelRow
            // 
            this.btnDelRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnDelRow.BorderRadius = 0;
            this.btnDelRow.Name = "btnDelRow";
            this.btnDelRow.Size = new System.Drawing.Size(50, 90);
            this.btnDelRow.Text = "删除";
            this.btnDelRow.Press += new System.EventHandler(this.btnDelRow_Press);
            // 
            // svDelete
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnDelRow});
            this.Size = new System.Drawing.Size(50, 90);
            this.Name = "svDelete";

        }
        #endregion

        private Smobiler.Core.Controls.Button btnDelRow;
    }
}