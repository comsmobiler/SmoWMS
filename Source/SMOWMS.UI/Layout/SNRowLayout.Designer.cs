using System;
using Smobiler.Core;
namespace SMOWMS.UI.Layout
{
    partial class SNRowLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public SNRowLayout()
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
            this.svSN = new Smobiler.Core.Controls.SwipeView();
            this.plRow = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.image1 = new Smobiler.Core.Controls.Image();
            // 
            // svSN
            // 
            this.svSN.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plRow});
            this.svSN.Name = "svSN";
            this.svSN.RightControlName = "snDelete";
            this.svSN.Size = new System.Drawing.Size(300, 42);
            // 
            // plRow
            // 
            this.plRow.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.image1});
            this.plRow.Name = "plRow";
            this.plRow.Size = new System.Drawing.Size(300, 42);
            // 
            // label1
            // 
            this.label1.DataMember = "SN";
            this.label1.DisplayMember = "SN";
            this.label1.FontSize = 20F;
            this.label1.Location = new System.Drawing.Point(49, 1);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(40F, 0F, 10F, 0F);
            this.label1.Size = new System.Drawing.Size(251, 40);
            this.label1.Text = "lblSN";
            // 
            // image1
            // 
            this.image1.DataMember = "IMAGE";
            this.image1.DisplayMember = "IMAGE";
            this.image1.Location = new System.Drawing.Point(9, 0);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(40, 40);
            // 
            // SNRowLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.svSN});
            this.Size = new System.Drawing.Size(300, 42);
            this.Name = "SNRowLayout";

        }
        #endregion

        private Smobiler.Core.Controls.SwipeView svSN;
        private Smobiler.Core.Controls.Panel plRow;
        public Smobiler.Core.Controls.Label label1;
        internal Smobiler.Core.Controls.Image image1;
    }
}