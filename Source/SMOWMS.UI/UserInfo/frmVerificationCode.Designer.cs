using System;
using Smobiler.Core;
namespace SMOWMS.UI.UserInfo
{
    partial class frmVerificationCode : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmVerificationCode()
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
            this.lblHint = new Smobiler.Core.Controls.Label();
            this.lblTel = new Smobiler.Core.Controls.Label();
            this.txtVcode = new Smobiler.Core.Controls.TextBox();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.btnNext = new Smobiler.Core.Controls.Button();
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.FontSize = 15F;
            this.title1.ForeColor = System.Drawing.Color.White;
            this.title1.Location = new System.Drawing.Point(138, 53);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 40);
            // 
            // lblHint
            // 
            this.lblHint.Bold = true;
            this.lblHint.FontSize = 20F;
            this.lblHint.ForeColor = System.Drawing.Color.White;
            this.lblHint.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lblHint.Location = new System.Drawing.Point(30, 70);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(240, 30);
            this.lblHint.Text = "请输入验证码";
            this.lblHint.Visible = false;
            // 
            // lblTel
            // 
            this.lblTel.FontSize = 14F;
            this.lblTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
            this.lblTel.Location = new System.Drawing.Point(30, 100);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(240, 30);
            this.lblTel.Text = "短信验证码已发送手机至";
            // 
            // txtVcode
            // 
            this.txtVcode.BackColor = System.Drawing.Color.Transparent;
            this.txtVcode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtVcode.BorderRadius = 10;
            this.txtVcode.Location = new System.Drawing.Point(30, 160);
            this.txtVcode.MaxLength = 4;
            this.txtVcode.Name = "txtVcode";
            this.txtVcode.Size = new System.Drawing.Size(240, 40);
            this.txtVcode.WaterMarkText = "请输入验证码";
            // 
            // label1
            // 
            this.label1.FontSize = 14F;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(217)))), ((int)(((byte)(228)))));
            this.label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label1.Location = new System.Drawing.Point(30, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 30);
            this.label1.Text = "重新获取验证码60s";
            this.label1.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(30, 220);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(240, 40);
            this.btnNext.Text = "下一步";
            this.btnNext.Press += new System.EventHandler(this.btnNext_Press);
            // 
            // frmVerificationCode
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageSizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.lblHint,
            this.lblTel,
            this.txtVcode,
            this.label1,
            this.btnNext});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229))))));
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmVerificationCode_KeyDown);
            this.Load += new System.EventHandler(this.frmVerificationCode_Load);
            this.Name = "frmVerificationCode";

        }
        #endregion

        private UserControl.Title title1;
        private Smobiler.Core.Controls.Label lblHint;
        private Smobiler.Core.Controls.Label lblTel;
        private Smobiler.Core.Controls.TextBox txtVcode;
        private Smobiler.Core.Controls.Label label1;
        internal Smobiler.Core.Controls.Button btnNext;
    }
}