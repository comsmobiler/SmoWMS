using System;
using Smobiler.Core;
namespace SMOWMS.UI.Layout
{
    partial class frmAssetsShowLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public frmAssetsShowLayout()
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
            this.imgAss = new Smobiler.Core.Controls.Image();
            this.lblName = new Smobiler.Core.Controls.Label();
            this.lblNumber = new Smobiler.Core.Controls.Label();
            this.lblStatus = new Smobiler.Core.Controls.Label();
            // 
            // imgAss
            // 
            this.imgAss.BorderRadius = 15;
            this.imgAss.DisplayMember = "IMAGE";
            this.imgAss.Location = new System.Drawing.Point(15, 7);
            this.imgAss.Name = "imgAss";
            this.imgAss.Size = new System.Drawing.Size(45, 45);
            this.imgAss.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            // 
            // lblName
            // 
            this.lblName.DataMember = "CID";
            this.lblName.DisplayFormat = "耗材名称: {0}";
            this.lblName.DisplayMember = "NAME";
            this.lblName.Location = new System.Drawing.Point(70, 0);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.lblName.Size = new System.Drawing.Size(115, 30);
            // 
            // lblNumber
            // 
            this.lblNumber.DisplayFormat = "待调拨数量: {0}";
            this.lblNumber.DisplayMember = "WAITREPAIRQTY";
            this.lblNumber.Location = new System.Drawing.Point(70, 30);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.lblNumber.Size = new System.Drawing.Size(115, 30);
            this.lblNumber.Text = "待调拨数量:  20";
            // 
            // lblStatus
            // 
            this.lblStatus.DisplayMember = "STATUS";
            this.lblStatus.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblStatus.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lblStatus.Location = new System.Drawing.Point(185, 15);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(115, 30);
            // 
            // frmAssetsShowLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imgAss,
            this.lblName,
            this.lblNumber,
            this.lblStatus});
            this.Size = new System.Drawing.Size(0, 60);
            this.Name = "frmAssetsShowLayout";

        }
        #endregion

        internal Smobiler.Core.Controls.Image imgAss;
        internal Smobiler.Core.Controls.Label lblName;
        internal Smobiler.Core.Controls.Label lblNumber;
        internal Smobiler.Core.Controls.Label lblStatus;
    }
}