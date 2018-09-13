using System;
using Smobiler.Core;
namespace SMOWMS.UI.UserInfo
{
    partial class frmVCode : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmVCode()
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
            this.lblTel = new Smobiler.Core.Controls.Label();
            this.plCode = new Smobiler.Core.Controls.Panel();
            this.lblHint = new Smobiler.Core.Controls.Label();
            this.txtVcode = new Smobiler.Core.Controls.TextBox();
            this.plButton = new Smobiler.Core.Controls.Panel();
            this.btnSave = new Smobiler.Core.Controls.Button();
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.FontSize = 15F;
            this.title1.ForeColor = System.Drawing.Color.White;
            this.title1.Location = new System.Drawing.Point(142, 90);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 40);
            // 
            // lblTel
            // 
            this.lblTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.lblTel.Location = new System.Drawing.Point(0, 50);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(300, 40);
            this.lblTel.Text = "短信验证码已发送手机至";
            // 
            // plCode
            // 
            this.plCode.BackColor = System.Drawing.Color.White;
            this.plCode.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.plCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plCode.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblHint,
            this.txtVcode});
            this.plCode.Location = new System.Drawing.Point(0, 90);
            this.plCode.Name = "plCode";
            this.plCode.Size = new System.Drawing.Size(300, 40);
            // 
            // lblHint
            // 
            this.lblHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(106)))));
            this.lblHint.Name = "lblHint";
            this.lblHint.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.lblHint.Size = new System.Drawing.Size(80, 40);
            this.lblHint.Text = "验证码";
            // 
            // txtVcode
            // 
            this.txtVcode.BackColor = System.Drawing.Color.Transparent;
            this.txtVcode.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtVcode.Location = new System.Drawing.Point(80, 0);
            this.txtVcode.MaxLength = 4;
            this.txtVcode.Name = "txtVcode";
            this.txtVcode.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.txtVcode.Size = new System.Drawing.Size(220, 40);
            this.txtVcode.WaterMarkText = "请输入验证码";
            // 
            // plButton
            // 
            this.plButton.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnSave});
            this.plButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plButton.Location = new System.Drawing.Point(0, 371);
            this.plButton.Name = "plButton";
            this.plButton.Size = new System.Drawing.Size(300, 40);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(40, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(220, 40);
            this.btnSave.Text = "完成";
            this.btnSave.Press += new System.EventHandler(this.btnSave_Press);
            // 
            // frmVCode
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.lblTel,
            this.plCode,
            this.plButton});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229))))));
            this.Load += new System.EventHandler(this.frmVCode_Load);
            this.Name = "frmVCode";

        }
        #endregion

        private UserControl.Title title1;
        private Smobiler.Core.Controls.Label lblTel;
        internal Smobiler.Core.Controls.Panel plCode;
        private Smobiler.Core.Controls.Label lblHint;
        internal Smobiler.Core.Controls.TextBox txtVcode;
        internal Smobiler.Core.Controls.Panel plButton;
        internal Smobiler.Core.Controls.Button btnSave;
    }
}