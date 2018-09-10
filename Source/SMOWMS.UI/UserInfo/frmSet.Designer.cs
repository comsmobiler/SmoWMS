using System;
using Smobiler.Core;
namespace SMOWMS.UI.UserInfo
{
    partial class frmSet : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmSet()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.title1 = new SMOWMS.UI.UserControl.Title();
            this.tpChangePwd = new Smobiler.Core.Controls.Panel();
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.tpChangeEmail = new Smobiler.Core.Controls.Panel();
            this.Label5 = new Smobiler.Core.Controls.Label();
            this.Label6 = new Smobiler.Core.Controls.Label();
            this.tpChangePhone = new Smobiler.Core.Controls.Panel();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.btnExit = new Smobiler.Core.Controls.Button();
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.FontSize = 15F;
            this.title1.ForeColor = System.Drawing.Color.White;
            this.title1.Location = new System.Drawing.Point(111, 69);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 40);
            this.title1.TitleText = "ÉèÖÃ";
            // 
            // tpChangePwd
            // 
            this.tpChangePwd.BackColor = System.Drawing.Color.White;
            this.tpChangePwd.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.tpChangePwd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tpChangePwd.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label1,
            this.Label2});
            this.tpChangePwd.Location = new System.Drawing.Point(0, 60);
            this.tpChangePwd.Name = "tpChangePwd";
            this.tpChangePwd.Size = new System.Drawing.Size(300, 40);
            this.tpChangePwd.Touchable = true;
            this.tpChangePwd.Press += new System.EventHandler(this.tpChangePwd_Press);
            // 
            // Label1
            // 
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(106)))));
            this.Label1.Name = "Label1";
            this.Label1.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.Label1.Size = new System.Drawing.Size(265, 40);
            this.Label1.Text = "ÃÜÂëÐÞ¸Ä";
            // 
            // Label2
            // 
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(106)))));
            this.Label2.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.Label2.Location = new System.Drawing.Point(265, 0);
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.Label2.Size = new System.Drawing.Size(35, 40);
            this.Label2.Text = ">";
            // 
            // tpChangeEmail
            // 
            this.tpChangeEmail.BackColor = System.Drawing.Color.White;
            this.tpChangeEmail.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.tpChangeEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tpChangeEmail.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label5,
            this.Label6});
            this.tpChangeEmail.Location = new System.Drawing.Point(0, 160);
            this.tpChangeEmail.Name = "tpChangeEmail";
            this.tpChangeEmail.Size = new System.Drawing.Size(300, 40);
            this.tpChangeEmail.Touchable = true;
            this.tpChangeEmail.Press += new System.EventHandler(this.tpChangeEmail_Press);
            // 
            // Label5
            // 
            this.Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(106)))));
            this.Label5.Name = "Label5";
            this.Label5.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.Label5.Size = new System.Drawing.Size(265, 40);
            this.Label5.Text = "ÓÊÏäÐÞ¸Ä";
            // 
            // Label6
            // 
            this.Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(106)))));
            this.Label6.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.Label6.Location = new System.Drawing.Point(265, 0);
            this.Label6.Name = "Label6";
            this.Label6.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.Label6.Size = new System.Drawing.Size(35, 40);
            this.Label6.Text = ">";
            // 
            // tpChangePhone
            // 
            this.tpChangePhone.BackColor = System.Drawing.Color.White;
            this.tpChangePhone.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.tpChangePhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tpChangePhone.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label3,
            this.Label4});
            this.tpChangePhone.Location = new System.Drawing.Point(0, 110);
            this.tpChangePhone.Name = "tpChangePhone";
            this.tpChangePhone.Size = new System.Drawing.Size(300, 40);
            this.tpChangePhone.Touchable = true;
            this.tpChangePhone.Press += new System.EventHandler(this.tpChangePhone_Press);
            // 
            // Label3
            // 
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(106)))));
            this.Label3.Name = "Label3";
            this.Label3.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.Label3.Size = new System.Drawing.Size(265, 40);
            this.Label3.Text = "µç»°ÐÞ¸Ä";
            // 
            // Label4
            // 
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(106)))));
            this.Label4.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.Label4.Location = new System.Drawing.Point(265, 0);
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.Label4.Size = new System.Drawing.Size(35, 40);
            this.Label4.Text = ">";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.btnExit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnExit.BorderRadius = 0;
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(0, 210);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(300, 40);
            this.btnExit.Text = "ÍË³öµÇÂ¼";
            this.btnExit.Press += new System.EventHandler(this.btnExit_Press);
            // 
            // frmSet
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.tpChangePwd,
            this.tpChangeEmail,
            this.tpChangePhone,
            this.btnExit});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229))))));
            this.Name = "frmSet";

        }
        #endregion

        private UserControl.Title title1;
        internal Smobiler.Core.Controls.Panel tpChangePwd;
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.Panel tpChangeEmail;
        internal Smobiler.Core.Controls.Label Label5;
        internal Smobiler.Core.Controls.Label Label6;
        internal Smobiler.Core.Controls.Panel tpChangePhone;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.Button btnExit;
    }
}