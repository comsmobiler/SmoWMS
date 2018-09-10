using System;
using Smobiler.Core;
namespace SMOWMS.UI.UserInfo
{
    partial class frmChangePwd : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmChangePwd()
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
            this.plUserID = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.lblUserID = new Smobiler.Core.Controls.Label();
            this.plPwd1 = new Smobiler.Core.Controls.Panel();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.txtPassWord1 = new Smobiler.Core.Controls.TextBox();
            this.plPwd2 = new Smobiler.Core.Controls.Panel();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.txtPassWord2 = new Smobiler.Core.Controls.TextBox();
            this.btnSure = new Smobiler.Core.Controls.Button();
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.FontSize = 15F;
            this.title1.ForeColor = System.Drawing.Color.White;
            this.title1.Location = new System.Drawing.Point(116, 94);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 40);
            this.title1.TitleText = "…Ë÷√√‹¬Î";
            // 
            // plUserID
            // 
            this.plUserID.BackColor = System.Drawing.Color.White;
            this.plUserID.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.plUserID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plUserID.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.lblUserID});
            this.plUserID.Location = new System.Drawing.Point(0, 50);
            this.plUserID.Name = "plUserID";
            this.plUserID.Size = new System.Drawing.Size(300, 40);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(145)))));
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(80, 40);
            this.label1.Text = "’À∫≈";
            // 
            // lblUserID
            // 
            this.lblUserID.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblUserID.Location = new System.Drawing.Point(80, 0);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.lblUserID.Size = new System.Drawing.Size(220, 40);
            // 
            // plPwd1
            // 
            this.plPwd1.BackColor = System.Drawing.Color.White;
            this.plPwd1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.plPwd1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plPwd1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label3,
            this.txtPassWord1});
            this.plPwd1.Location = new System.Drawing.Point(0, 100);
            this.plPwd1.Name = "plPwd1";
            this.plPwd1.Size = new System.Drawing.Size(300, 40);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(106)))));
            this.label3.Name = "label3";
            this.label3.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.label3.Size = new System.Drawing.Size(80, 40);
            this.label3.Text = "√‹¬Î";
            // 
            // txtPassWord1
            // 
            this.txtPassWord1.BackColor = System.Drawing.Color.Transparent;
            this.txtPassWord1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtPassWord1.Location = new System.Drawing.Point(80, 0);
            this.txtPassWord1.Name = "txtPassWord1";
            this.txtPassWord1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.txtPassWord1.SecurityMode = true;
            this.txtPassWord1.Size = new System.Drawing.Size(220, 40);
            this.txtPassWord1.WaterMarkText = "«Î ‰»Î6-12Œª√‹¬Î";
            // 
            // plPwd2
            // 
            this.plPwd2.BackColor = System.Drawing.Color.White;
            this.plPwd2.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plPwd2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plPwd2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label2,
            this.txtPassWord2});
            this.plPwd2.Location = new System.Drawing.Point(0, 140);
            this.plPwd2.Name = "plPwd2";
            this.plPwd2.Size = new System.Drawing.Size(300, 40);
            // 
            // Label2
            // 
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(106)))));
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.Label2.Size = new System.Drawing.Size(80, 40);
            this.Label2.Text = "»∑»œ√‹¬Î";
            // 
            // txtPassWord2
            // 
            this.txtPassWord2.BackColor = System.Drawing.Color.Transparent;
            this.txtPassWord2.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtPassWord2.Location = new System.Drawing.Point(80, 0);
            this.txtPassWord2.Name = "txtPassWord2";
            this.txtPassWord2.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.txtPassWord2.SecurityMode = true;
            this.txtPassWord2.Size = new System.Drawing.Size(220, 40);
            this.txtPassWord2.WaterMarkText = "«Î ‰»Î6-12Œª√‹¬Î";
            // 
            // btnSure
            // 
            this.btnSure.BorderRadius = 20;
            this.btnSure.Location = new System.Drawing.Point(0, 200);
            this.btnSure.Margin = new Smobiler.Core.Controls.Margin(32F, 0F, 32F, 0F);
            this.btnSure.Name = "btnSure";
            this.btnSure.Size = new System.Drawing.Size(220, 40);
            this.btnSure.Text = "Ã·Ωª";
            this.btnSure.Press += new System.EventHandler(this.btnSure_Press);
            // 
            // frmChangePwd
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.plUserID,
            this.plPwd1,
            this.plPwd2,
            this.btnSure});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229))))));
            this.Load += new System.EventHandler(this.frmChangePwd_Load);
            this.Name = "frmChangePwd";

        }
        #endregion

        private UserControl.Title title1;
        internal Smobiler.Core.Controls.Panel plUserID;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label lblUserID;
        internal Smobiler.Core.Controls.Panel plPwd1;
        private Smobiler.Core.Controls.Label label3;
        internal Smobiler.Core.Controls.TextBox txtPassWord1;
        internal Smobiler.Core.Controls.Panel plPwd2;
        private Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.TextBox txtPassWord2;
        internal Smobiler.Core.Controls.Button btnSure;
    }
}