using System;
using Smobiler.Core;
namespace SMOWMS.UI.Layout
{
    partial class frmOrderCreateLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public frmOrderCreateLayout()
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
            this.imgAss = new Smobiler.Core.Controls.Image();
            this.lblName = new Smobiler.Core.Controls.Label();
            this.lblLocation = new Smobiler.Core.Controls.Label();
            this.lblNumber = new Smobiler.Core.Controls.Label();
            this.numNumber = new Smobiler.Core.Controls.Numeric();
            // 
            // plRow
            // 
            this.plRow.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imgAss,
            this.lblName,
            this.lblLocation,
            this.lblNumber,
            this.numNumber});
            this.plRow.Name = "plRow";
            this.plRow.Size = new System.Drawing.Size(300, 60);
            this.plRow.Touchable = true;
            this.plRow.LongPress += new System.EventHandler(this.plRow_LongPress);
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
            // lblName
            // 
            this.lblName.DataMember = "CID";
            this.lblName.DisplayFormat = "耗材名称: {0}";
            this.lblName.DisplayMember = "NAME";
            this.lblName.Location = new System.Drawing.Point(70, 0);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.lblName.Size = new System.Drawing.Size(115, 20);
            this.lblName.Text = "耗材名称: 书包";
            // 
            // lblLocation
            // 
            this.lblLocation.DataMember = "LOCID";
            this.lblLocation.DisplayFormat = "所在库位: {0}";
            this.lblLocation.DisplayMember = "LOCNAME";
            this.lblLocation.Location = new System.Drawing.Point(70, 20);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.lblLocation.Size = new System.Drawing.Size(230, 20);
            this.lblLocation.Text = "所在库位: 嘉兴";
            // 
            // lblNumber
            // 
            this.lblNumber.DataMember = "QUANTITY";
            this.lblNumber.DisplayFormat = "可用数量: {0}";
            this.lblNumber.DisplayMember = "QUANTITY";
            this.lblNumber.Location = new System.Drawing.Point(185, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.lblNumber.Size = new System.Drawing.Size(115, 20);
            this.lblNumber.Text = "可用数量:  20";
            // 
            // numNumber
            // 
            this.numNumber.DisplayFormat = null;
            this.numNumber.DisplayMember = "SELECTQTY";
            this.numNumber.FontSize = 13F;
            this.numNumber.Location = new System.Drawing.Point(127, 40);
            this.numNumber.MinusIconColor = System.Drawing.Color.Black;
            this.numNumber.Name = "numNumber";
            this.numNumber.Size = new System.Drawing.Size(115, 20);
            // 
            // frmOrderCreateLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plRow});
            this.Size = new System.Drawing.Size(0, 60);
            this.Name = "frmOrderCreateLayout";

        }
        #endregion

        internal Smobiler.Core.Controls.Panel plRow;
        internal Smobiler.Core.Controls.Image imgAss;
        internal Smobiler.Core.Controls.Label lblName;
        internal Smobiler.Core.Controls.Label lblLocation;
        internal Smobiler.Core.Controls.Label lblNumber;
        internal Smobiler.Core.Controls.Numeric numNumber;
    }
}