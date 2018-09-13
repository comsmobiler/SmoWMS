using System;
using Smobiler.Core;
namespace SMOWMS.UI.Layout
{
    partial class frmTransferRowsLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public frmTransferRowsLayout()
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
            this.plContent = new Smobiler.Core.Controls.Panel();
            this.lblID = new Smobiler.Core.Controls.Label();
            this.lblDate = new Smobiler.Core.Controls.Label();
            this.lblContent = new Smobiler.Core.Controls.Label();
            // 
            // plContent
            // 
            this.plContent.BackColor = System.Drawing.Color.White;
            this.plContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblID,
            this.lblDate,
            this.lblContent});
            this.plContent.Name = "plContent";
            this.plContent.Size = new System.Drawing.Size(300, 50);
            this.plContent.Touchable = true;
            this.plContent.Press += new System.EventHandler(this.plContent_Press);
            // 
            // lblID
            // 
            this.lblID.DataMember = "TOID";
            this.lblID.DisplayFormat = "单号  {0}";
            this.lblID.DisplayMember = "TOID";
            this.lblID.Name = "lblID";
            this.lblID.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.lblID.Size = new System.Drawing.Size(150, 30);
            this.lblID.Text = "单号";
            // 
            // lblDate
            // 
            this.lblDate.DisplayFormat = "日期  {0:yyyy/MM/dd}";
            this.lblDate.DisplayMember = "TRANSFERDATE";
            this.lblDate.Location = new System.Drawing.Point(150, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.lblDate.Size = new System.Drawing.Size(150, 30);
            this.lblDate.Text = "日期";
            // 
            // lblContent
            // 
            this.lblContent.DisplayFormat = "备注  {0}";
            this.lblContent.DisplayMember = "NOTE";
            this.lblContent.FontSize = 12F;
            this.lblContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblContent.Location = new System.Drawing.Point(0, 30);
            this.lblContent.Name = "lblContent";
            this.lblContent.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.lblContent.Size = new System.Drawing.Size(300, 20);
            this.lblContent.Text = "备注 ";
            // 
            // frmTransferRowsLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plContent});
            this.Size = new System.Drawing.Size(0, 50);
            this.Name = "frmTransferRowsLayout";

        }
        #endregion

        internal Smobiler.Core.Controls.Panel plContent;
        internal Smobiler.Core.Controls.Label lblID;
        internal Smobiler.Core.Controls.Label lblDate;
        internal Smobiler.Core.Controls.Label lblContent;
    }
}