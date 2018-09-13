using System;
using Smobiler.Core;
namespace SMOWMS.UI.Layout
{
    partial class frmUserPwdLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public frmUserPwdLayout()
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
            this.lblTitle = new Smobiler.Core.Controls.Label();
            this.lblInfo = new Smobiler.Core.Controls.Label();
            this.txtPwd = new Smobiler.Core.Controls.TextBox();
            this.btnClose = new Smobiler.Core.Controls.Button();
            this.btnOK = new Smobiler.Core.Controls.Button();
            // 
            // lblTitle
            // 
            this.lblTitle.FontSize = 16F;
            this.lblTitle.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(270, 30);
            this.lblTitle.Text = "验证原始密码";
            // 
            // lblInfo
            // 
            this.lblInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblInfo.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lblInfo.Location = new System.Drawing.Point(0, 30);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(270, 60);
            this.lblInfo.Text = "为保证您的数据安全，修改密码前请填写原密码。";
            this.lblInfo.ZIndex = 1;
            // 
            // txtPwd
            // 
            this.txtPwd.Border = new Smobiler.Core.Controls.Border(1F);
            this.txtPwd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.txtPwd.Location = new System.Drawing.Point(20, 90);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.SecurityMode = true;
            this.txtPwd.Size = new System.Drawing.Size(230, 30);
            this.txtPwd.WaterMarkText = "请输入6-12位密码";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Border = new Smobiler.Core.Controls.Border(0F, 1F, 1F, 0F);
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnClose.BorderRadius = 0;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnClose.Location = new System.Drawing.Point(0, 135);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 40);
            this.btnClose.Text = "取消";
            this.btnClose.Press += new System.EventHandler(this.btnClose_Press);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.White;
            this.btnOK.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.btnOK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnOK.BorderRadius = 0;
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnOK.Location = new System.Drawing.Point(135, 135);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(135, 40);
            this.btnOK.Text = "确定";
            this.btnOK.Press += new System.EventHandler(this.btnOK_Press);
            // 
            // frmUserPwdLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblTitle,
            this.lblInfo,
            this.txtPwd,
            this.btnClose,
            this.btnOK});
            this.Size = new System.Drawing.Size(270, 175);
            this.Name = "frmUserPwdLayout";

        }
        #endregion

        internal Smobiler.Core.Controls.Label lblTitle;
        private Smobiler.Core.Controls.Label lblInfo;
        private Smobiler.Core.Controls.TextBox txtPwd;
        internal Smobiler.Core.Controls.Button btnClose;
        internal Smobiler.Core.Controls.Button btnOK;
    }
}