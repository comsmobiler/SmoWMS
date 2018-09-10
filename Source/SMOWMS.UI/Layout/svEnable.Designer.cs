using System;
using Smobiler.Core;
namespace SMOWMS.UI.Layout
{
    partial class svEnable : Smobiler.Core.Controls.MobileUserControl
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
            this.btnEnable = new Smobiler.Core.Controls.Button();
            // 
            // btnEnable
            // 
            this.btnEnable.BackColor = System.Drawing.Color.Red;
            this.btnEnable.BorderRadius = 0;
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(45, 45);
            this.btnEnable.Text = "禁用";
            this.btnEnable.Press += new System.EventHandler(this.btnEnable_Press);
            // 
            // svAssetsTypeEnable
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnEnable});
            this.Size = new System.Drawing.Size(45, 45);
            this.Name = "svAssetsTypeEnable";

        }
        #endregion

        internal Smobiler.Core.Controls.Button btnEnable;
    }
}