using System;
using Smobiler.Core;
namespace SMOWMS.UI.Layout
{
    partial class frmOrderCreateSNLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public frmOrderCreateSNLayout()
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
            this.lblName = new Smobiler.Core.Controls.Label();
            this.imgAss = new Smobiler.Core.Controls.Image();
            this.lblSN = new Smobiler.Core.Controls.Label();
            this.lblASSID = new Smobiler.Core.Controls.Label();
            // 
            // plRow
            // 
            this.plRow.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblName,
            this.imgAss,
            this.lblSN,
            this.lblASSID});
            this.plRow.Name = "plRow";
            this.plRow.Size = new System.Drawing.Size(300, 60);
            this.plRow.Touchable = true;
            this.plRow.LongPress += new System.EventHandler(this.plRow_LongPress);
            // 
            // lblName
            // 
            this.lblName.DataMember = "ASSID";
            this.lblName.DisplayFormat = "资产名称: {0}";
            this.lblName.DisplayMember = "NAME";
            this.lblName.Location = new System.Drawing.Point(70, 0);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.lblName.Size = new System.Drawing.Size(230, 20);
            this.lblName.Text = "资产名称: ";
            // 
            // imgAss
            // 
            this.imgAss.BorderRadius = 15;
            this.imgAss.DisplayMember = "IMAGE";
            this.imgAss.Location = new System.Drawing.Point(12, 7);
            this.imgAss.Name = "imgAss";
            this.imgAss.Size = new System.Drawing.Size(45, 45);
            this.imgAss.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            // 
            // lblSN
            // 
            this.lblSN.DataMember = "SN";
            this.lblSN.DisplayFormat = "序列号: {0}";
            this.lblSN.DisplayMember = "SN";
            this.lblSN.Location = new System.Drawing.Point(70, 40);
            this.lblSN.Name = "lblSN";
            this.lblSN.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.lblSN.Size = new System.Drawing.Size(230, 20);
            // 
            // lblASSID
            // 
            this.lblASSID.DataMember = "ASSID";
            this.lblASSID.DisplayFormat = "资产名称: {0}";
            this.lblASSID.DisplayMember = "ASSID";
            this.lblASSID.Location = new System.Drawing.Point(70, 20);
            this.lblASSID.Name = "lblASSID";
            this.lblASSID.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.lblASSID.Size = new System.Drawing.Size(230, 20);
            this.lblASSID.Text = "资产编号: ";
            // 
            // frmOrderCreateSNLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plRow});
            this.Size = new System.Drawing.Size(0, 60);
            this.Name = "frmOrderCreateSNLayout";

        }
        #endregion

        internal Smobiler.Core.Controls.Panel plRow;
        internal Smobiler.Core.Controls.Label lblName;
        internal Smobiler.Core.Controls.Image imgAss;
        internal Smobiler.Core.Controls.Label lblSN;
        internal Smobiler.Core.Controls.Label lblASSID;
    }
}