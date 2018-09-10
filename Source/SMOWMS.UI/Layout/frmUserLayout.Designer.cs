using System;
using Smobiler.Core;
namespace SMOWMS.UI.Layout
{
    partial class frmUserLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public frmUserLayout()
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
            this.tpUser = new Smobiler.Core.Controls.Panel();
            this.imgPortrait = new Smobiler.Core.Controls.Image();
            this.lblUser = new Smobiler.Core.Controls.Label();
            // 
            // tpUser
            // 
            this.tpUser.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imgPortrait,
            this.lblUser});
            this.tpUser.Name = "tpUser";
            this.tpUser.Size = new System.Drawing.Size(300, 50);
            this.tpUser.Press += new System.EventHandler(this.tpUser_Press);
            // 
            // imgPortrait
            // 
            this.imgPortrait.BorderRadius = 18;
            this.imgPortrait.DataMember = "USER_IMAGEID";
            this.imgPortrait.DisplayMember = "USER_IMAGEID";
            this.imgPortrait.Location = new System.Drawing.Point(4, 7);
            this.imgPortrait.Name = "imgPortrait";
            this.imgPortrait.Size = new System.Drawing.Size(36, 36);
            this.imgPortrait.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            // 
            // lblUser
            // 
            this.lblUser.DataMember = "USER_ID";
            this.lblUser.DisplayMember = "USER_NAME";
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblUser.Location = new System.Drawing.Point(47, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(253, 50);
            // 
            // frmUserLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.tpUser});
            this.Size = new System.Drawing.Size(0, 50);
            this.Name = "frmUserLayout";

        }
        #endregion

        private Smobiler.Core.Controls.Panel tpUser;
        private Smobiler.Core.Controls.Image imgPortrait;
        private Smobiler.Core.Controls.Label lblUser;
    }
}