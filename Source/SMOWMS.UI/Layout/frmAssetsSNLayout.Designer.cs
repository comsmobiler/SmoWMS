using System;
using Smobiler.Core;
namespace SMOWMS.UI.Layout
{
    partial class frmAssetsSNLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public frmAssetsSNLayout()
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
            this.Check = new Smobiler.Core.Controls.CheckBox();
            this.imgAss = new Smobiler.Core.Controls.Image();
            this.lblName = new Smobiler.Core.Controls.Label();
            this.lblSN = new Smobiler.Core.Controls.Label();
            this.lblLocation = new Smobiler.Core.Controls.Label();
            // 
            // plRow
            // 
            this.plRow.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Check,
            this.imgAss,
            this.lblName,
            this.lblSN,
            this.lblLocation});
            this.plRow.Name = "plRow";
            this.plRow.Size = new System.Drawing.Size(300, 60);
            this.plRow.Touchable = true;
            this.plRow.Press += new System.EventHandler(this.plRow_Press);
            // 
            // Check
            // 
            this.Check.DisplayMember = "CHECK";
            this.Check.Location = new System.Drawing.Point(5, 20);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(20, 20);
            this.Check.ZIndex = 1;
            this.Check.CheckedChanged += new System.EventHandler(this.Check_CheckedChanged);
            // 
            // imgAss
            // 
            this.imgAss.BorderRadius = 15;
            this.imgAss.DisplayMember = "IMAGE";
            this.imgAss.Location = new System.Drawing.Point(25, 7);
            this.imgAss.Name = "imgAss";
            this.imgAss.Size = new System.Drawing.Size(45, 45);
            this.imgAss.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            // 
            // lblName
            // 
            this.lblName.DataMember = "ASSID";
            this.lblName.DisplayFormat = "资产名称: {0}";
            this.lblName.DisplayMember = "NAME";
            this.lblName.Location = new System.Drawing.Point(70, 0);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.lblName.Size = new System.Drawing.Size(115, 30);
            // 
            // lblSN
            // 
            this.lblSN.DataMember = "SN";
            this.lblSN.DisplayFormat = "序列号: {0}";
            this.lblSN.DisplayMember = "SN";
            this.lblSN.Location = new System.Drawing.Point(185, 15);
            this.lblSN.Name = "lblSN";
            this.lblSN.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.lblSN.Size = new System.Drawing.Size(115, 30);
            // 
            // lblLocation
            // 
            this.lblLocation.DataMember = "LOCATIONID";
            this.lblLocation.DisplayFormat = "所在区域: {0}";
            this.lblLocation.DisplayMember = "LOCATIONNAME";
            this.lblLocation.Location = new System.Drawing.Point(70, 30);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.lblLocation.Size = new System.Drawing.Size(115, 30);
            this.lblLocation.Text = "所在区域: 嘉兴";
            // 
            // frmAssetsSNLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plRow});
            this.Size = new System.Drawing.Size(0, 60);
            this.Name = "frmAssetsSNLayout";

        }
        #endregion

        internal Smobiler.Core.Controls.Panel plRow;
        internal Smobiler.Core.Controls.CheckBox Check;
        internal Smobiler.Core.Controls.Image imgAss;
        internal Smobiler.Core.Controls.Label lblName;
        internal Smobiler.Core.Controls.Label lblSN;
        internal Smobiler.Core.Controls.Label lblLocation;
    }
}