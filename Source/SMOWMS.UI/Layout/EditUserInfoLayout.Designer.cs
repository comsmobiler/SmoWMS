using System;
using Smobiler.Core;
namespace SMOWMS.UI.Layout
{
    partial class EditUserInfoLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public EditUserInfoLayout()
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
            this.lblEditInfo = new Smobiler.Core.Controls.Label();
            this.txtEditInfo = new Smobiler.Core.Controls.TextBox();
            this.btnClose = new Smobiler.Core.Controls.Button();
            this.btnOK = new Smobiler.Core.Controls.Button();
            // 
            // lblEditInfo
            // 
            this.lblEditInfo.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.lblEditInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.lblEditInfo.FontSize = 19F;
            this.lblEditInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.lblEditInfo.Name = "lblEditInfo";
            this.lblEditInfo.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.lblEditInfo.Size = new System.Drawing.Size(270, 45);
            this.lblEditInfo.Text = "修改昵称：";
            this.lblEditInfo.ZIndex = 1;
            // 
            // txtEditInfo
            // 
            this.txtEditInfo.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.txtEditInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.txtEditInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.txtEditInfo.Location = new System.Drawing.Point(10, 46);
            this.txtEditInfo.Name = "txtEditInfo";
            this.txtEditInfo.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.txtEditInfo.Size = new System.Drawing.Size(260, 30);
            this.txtEditInfo.WaterMarkText = "（必输）";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Border = new Smobiler.Core.Controls.Border(0F, 1F, 1F, 0F);
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnClose.BorderRadius = 0;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnClose.Location = new System.Drawing.Point(0, 95);
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
            this.btnOK.Location = new System.Drawing.Point(135, 95);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(135, 40);
            this.btnOK.Text = "确定";
            this.btnOK.Press += new System.EventHandler(this.btnOK_Press);
            // 
            // EditUserInfoLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblEditInfo,
            this.txtEditInfo,
            this.btnClose,
            this.btnOK});
            this.Size = new System.Drawing.Size(270, 135);
            this.Load += new System.EventHandler(this.EditUserInfoLayout_Load);
            this.Name = "EditUserInfoLayout";

        }
        #endregion

        internal Smobiler.Core.Controls.Label lblEditInfo;
        private Smobiler.Core.Controls.TextBox txtEditInfo;
        internal Smobiler.Core.Controls.Button btnClose;
        internal Smobiler.Core.Controls.Button btnOK;
    }
}