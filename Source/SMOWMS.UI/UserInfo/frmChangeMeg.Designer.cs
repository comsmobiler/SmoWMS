using System;
using Smobiler.Core;
namespace SMOWMS.UI.UserInfo
{
    partial class frmChangeMeg : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmChangeMeg()
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
            this.Panel1 = new Smobiler.Core.Controls.Panel();
            this.lblInfo = new Smobiler.Core.Controls.Label();
            this.txtInfo = new Smobiler.Core.Controls.TextBox();
            this.plButton = new Smobiler.Core.Controls.Panel();
            this.btnNext = new Smobiler.Core.Controls.Button();
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.FontSize = 15F;
            this.title1.ForeColor = System.Drawing.Color.White;
            this.title1.Location = new System.Drawing.Point(149, 116);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 40);
            this.title1.TitleText = "请输入手机号码";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblInfo,
            this.txtInfo});
            this.Panel1.Location = new System.Drawing.Point(0, 50);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(300, 40);
            // 
            // lblInfo
            // 
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(106)))));
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.lblInfo.Size = new System.Drawing.Size(80, 40);
            this.lblInfo.Text = "手机号码";
            // 
            // txtInfo
            // 
            this.txtInfo.BackColor = System.Drawing.Color.Transparent;
            this.txtInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtInfo.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtInfo.Location = new System.Drawing.Point(80, 0);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.txtInfo.Size = new System.Drawing.Size(220, 40);
            this.txtInfo.WaterMarkText = "手机号码";
            this.txtInfo.ZIndex = 2;
            // 
            // plButton
            // 
            this.plButton.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnNext});
            this.plButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plButton.Location = new System.Drawing.Point(0, 371);
            this.plButton.Name = "plButton";
            this.plButton.Size = new System.Drawing.Size(300, 40);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(40, 0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(220, 40);
            this.btnNext.Text = "下一步";
            this.btnNext.Press += new System.EventHandler(this.btnNext_Press);
            // 
            // frmChangeMeg
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.Panel1,
            this.plButton});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229))))));
            this.Load += new System.EventHandler(this.frmChangeMeg_Load);
            this.Name = "frmChangeMeg";

        }
        #endregion

        private UserControl.Title title1;
        internal Smobiler.Core.Controls.Panel Panel1;
        private Smobiler.Core.Controls.Label lblInfo;
        private Smobiler.Core.Controls.TextBox txtInfo;
        internal Smobiler.Core.Controls.Panel plButton;
        internal Smobiler.Core.Controls.Button btnNext;
    }
}