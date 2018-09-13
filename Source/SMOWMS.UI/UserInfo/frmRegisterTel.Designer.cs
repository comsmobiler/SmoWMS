using System;
using Smobiler.Core;
namespace SMOWMS.UI.UserInfo
{
    partial class frmRegisterTel : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmRegisterTel()
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
            this.lblTitle = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.txtTel = new Smobiler.Core.Controls.TextBox();
            this.btnNext = new Smobiler.Core.Controls.Button();
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.FontSize = 15F;
            this.title1.ForeColor = System.Drawing.Color.White;
            this.title1.Location = new System.Drawing.Point(84, 27);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 40);
            // 
            // lblTitle
            // 
            this.lblTitle.Bold = true;
            this.lblTitle.FontSize = 20F;
            this.lblTitle.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lblTitle.Location = new System.Drawing.Point(30, 70);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(240, 40);
            this.lblTitle.Text = "请输入手机号码";
            // 
            // label2
            // 
            this.label2.Border = new Smobiler.Core.Controls.Border(1F);
            this.label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label2.BorderRadius = 10;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label2.Location = new System.Drawing.Point(30, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 40);
            this.label2.ZIndex = 1;
            // 
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.Color.Transparent;
            this.txtTel.BorderRadius = 10;
            this.txtTel.FontSize = 12F;
            this.txtTel.Location = new System.Drawing.Point(48, 161);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(204, 38);
            this.txtTel.WaterMarkText = "手机号码";
            this.txtTel.WaterMarkTextColor = System.Drawing.Color.LightGray;
            this.txtTel.ZIndex = 2;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(30, 220);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(240, 40);
            this.btnNext.Text = "下一步";
            this.btnNext.Press += new System.EventHandler(this.btnNext_Press);
            // 
            // frmRegisterTel
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.lblTitle,
            this.label2,
            this.txtTel,
            this.btnNext});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229))))));
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmRegisterTel_KeyDown);
            this.Load += new System.EventHandler(this.frmRegisterTel_Load);
            this.Name = "frmRegisterTel";

        }
        #endregion

        private UserControl.Title title1;
        private Smobiler.Core.Controls.Label lblTitle;
        internal Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.TextBox txtTel;
        internal Smobiler.Core.Controls.Button btnNext;
    }
}