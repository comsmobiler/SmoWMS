using System;
using Smobiler.Core;
namespace SMOWMS.UI.Layout
{
    partial class frmVendorLayout : Smobiler.Core.Controls.MobileUserControl
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
            this.plAddress = new Smobiler.Core.Controls.Panel();
            this.fiAddress = new Smobiler.Core.Controls.FontIcon();
            this.lblAddress = new Smobiler.Core.Controls.Label();
            this.plContacts = new Smobiler.Core.Controls.Panel();
            this.fiContacts = new Smobiler.Core.Controls.FontIcon();
            this.lblContacts = new Smobiler.Core.Controls.Label();
            this.plPhone = new Smobiler.Core.Controls.Panel();
            this.fiPhone = new Smobiler.Core.Controls.FontIcon();
            this.plCall = new Smobiler.Core.Controls.Panel();
            this.lblPhone = new Smobiler.Core.Controls.Label();
            // 
            // svRow
            // 
            this.svRow.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plRow});
            this.svRow.Name = "svRow";
            this.svRow.RightControlName = "svDelete";
            this.svRow.Size = new System.Drawing.Size(300, 90);
            // 
            // plRow
            // 
            this.plRow.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblName,
            this.plAddress,
            this.plContacts,
            this.plPhone});
            this.plRow.Name = "plRow";
            this.plRow.Size = new System.Drawing.Size(300, 90);
            this.plRow.Touchable = true;
            this.plRow.TouchOpacity = 100;
            this.plRow.Press += new System.EventHandler(this.plRow_Press);
            // 
            // lblName
            // 
            this.lblName.DataMember = "VID";
            this.lblName.DisplayMember = "NAME";
            this.lblName.FontSize = 14F;
            this.lblName.Name = "lblName";
            this.lblName.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.lblName.Size = new System.Drawing.Size(300, 30);
            // 
            // plAddress
            // 
            this.plAddress.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.fiAddress,
            this.lblAddress});
            this.plAddress.Location = new System.Drawing.Point(0, 30);
            this.plAddress.Name = "plAddress";
            this.plAddress.Size = new System.Drawing.Size(300, 30);
            // 
            // fiAddress
            // 
            this.fiAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.fiAddress.Location = new System.Drawing.Point(10, 5);
            this.fiAddress.Name = "fiAddress";
            this.fiAddress.ResourceID = "location-arrow";
            this.fiAddress.Size = new System.Drawing.Size(20, 20);
            // 
            // lblAddress
            // 
            this.lblAddress.DisplayMember = "ADDRESS";
            this.lblAddress.FontSize = 12F;
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.lblAddress.Location = new System.Drawing.Point(40, 5);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(250, 20);
            // 
            // plContacts
            // 
            this.plContacts.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.fiContacts,
            this.lblContacts});
            this.plContacts.Location = new System.Drawing.Point(0, 60);
            this.plContacts.Name = "plContacts";
            this.plContacts.Size = new System.Drawing.Size(150, 30);
            // 
            // fiContacts
            // 
            this.fiContacts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.fiContacts.Location = new System.Drawing.Point(10, 5);
            this.fiContacts.Name = "fiContacts";
            this.fiContacts.ResourceID = "user";
            this.fiContacts.Size = new System.Drawing.Size(20, 20);
            // 
            // lblContacts
            // 
            this.lblContacts.DisplayMember = "CONTACTS";
            this.lblContacts.FontSize = 12F;
            this.lblContacts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.lblContacts.Location = new System.Drawing.Point(40, 5);
            this.lblContacts.Name = "lblContacts";
            this.lblContacts.Size = new System.Drawing.Size(100, 20);
            // 
            // plPhone
            // 
            this.plPhone.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.fiPhone,
            this.plCall});
            this.plPhone.Location = new System.Drawing.Point(150, 60);
            this.plPhone.Name = "plPhone";
            this.plPhone.Size = new System.Drawing.Size(150, 30);
            // 
            // fiPhone
            // 
            this.fiPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.fiPhone.Location = new System.Drawing.Point(10, 5);
            this.fiPhone.Name = "fiPhone";
            this.fiPhone.ResourceID = "phone";
            this.fiPhone.Size = new System.Drawing.Size(20, 20);
            // 
            // plCall
            // 
            this.plCall.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblPhone});
            this.plCall.Location = new System.Drawing.Point(40, 5);
            this.plCall.Name = "plCall";
            this.plCall.Size = new System.Drawing.Size(100, 20);
            this.plCall.Touchable = true;
            this.plCall.TouchOpacity = 100;
            this.plCall.Press += new System.EventHandler(this.plCall_Press);
            // 
            // lblPhone
            // 
            this.lblPhone.DisplayMember = "PHONE";
            this.lblPhone.FontSize = 12F;
            this.lblPhone.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(100, 20);
            this.lblPhone.Underline = true;
            // 
            // frmVendorLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.svRow});
            this.Size = new System.Drawing.Size(0, 90);
            this.Name = "frmVendorLayout";

        }
        #endregion

        private Smobiler.Core.Controls.SwipeView svRow;
        private Smobiler.Core.Controls.Panel plRow;
        private Smobiler.Core.Controls.Label lblName;
        private Smobiler.Core.Controls.Panel plAddress;
        private Smobiler.Core.Controls.FontIcon fiAddress;
        private Smobiler.Core.Controls.Label lblAddress;
        private Smobiler.Core.Controls.Panel plContacts;
        private Smobiler.Core.Controls.FontIcon fiContacts;
        private Smobiler.Core.Controls.Label lblContacts;
        private Smobiler.Core.Controls.Panel plPhone;
        private Smobiler.Core.Controls.FontIcon fiPhone;
        private Smobiler.Core.Controls.Panel plCall;
        private Smobiler.Core.Controls.Label lblPhone;
    }
}