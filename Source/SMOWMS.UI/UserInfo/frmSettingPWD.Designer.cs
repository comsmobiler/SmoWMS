using System;
using Smobiler.Core;
namespace SMOWMS.UI.UserInfo
{
    partial class frmSettingPWD : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmSettingPWD()
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
            this.label2 = new Smobiler.Core.Controls.Label();
            this.lblID1 = new Smobiler.Core.Controls.Label();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.lblID2 = new Smobiler.Core.Controls.Label();
            this.txtID = new Smobiler.Core.Controls.TextBox();
            this.txtPwd = new Smobiler.Core.Controls.TextBox();
            this.btnNext = new Smobiler.Core.Controls.Button();
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.FontSize = 15F;
            this.title1.ForeColor = System.Drawing.Color.White;
            this.title1.Location = new System.Drawing.Point(148, 44);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 40);
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
            // lblID1
            // 
            this.lblID1.Border = new Smobiler.Core.Controls.Border(1F);
            this.lblID1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblID1.BorderRadius = 10;
            this.lblID1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblID1.Location = new System.Drawing.Point(30, 100);
            this.lblID1.Name = "lblID1";
            this.lblID1.Size = new System.Drawing.Size(240, 40);
            this.lblID1.ZIndex = 1;
            // 
            // label1
            // 
            this.label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label1.Location = new System.Drawing.Point(48, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 38);
            this.label1.Text = "…Ë÷√√‹¬Î";
            this.label1.ZIndex = 2;
            // 
            // lblID2
            // 
            this.lblID2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblID2.Location = new System.Drawing.Point(48, 101);
            this.lblID2.Name = "lblID2";
            this.lblID2.Size = new System.Drawing.Size(66, 38);
            this.lblID2.Text = "’À∫≈";
            this.lblID2.ZIndex = 2;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.Transparent;
            this.txtID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtID.FontSize = 12F;
            this.txtID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.txtID.Location = new System.Drawing.Point(114, 100);
            this.txtID.MaxLength = 16;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(143, 38);
            this.txtID.WaterMarkText = "«Î ‰»Î∑˚∫≈+ ˝◊÷6-18Œª’À∫≈";
            this.txtID.ZIndex = 2;
            // 
            // txtPwd
            // 
            this.txtPwd.BackColor = System.Drawing.Color.Transparent;
            this.txtPwd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtPwd.FontSize = 12F;
            this.txtPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.txtPwd.Location = new System.Drawing.Point(114, 161);
            this.txtPwd.MaxLength = 12;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(143, 38);
            this.txtPwd.WaterMarkText = "«Î ‰»Î6-12Œª√‹¬Î";
            this.txtPwd.ZIndex = 2;
            // 
            // btnNext
            // 
            this.btnNext.FontSize = 15F;
            this.btnNext.Location = new System.Drawing.Point(30, 220);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(240, 40);
            this.btnNext.Text = "»∑»œ";
            this.btnNext.Press += new System.EventHandler(this.btnNext_Press);
            // 
            // frmSettingPWD
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageSizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.label2,
            this.lblID1,
            this.label1,
            this.lblID2,
            this.txtID,
            this.txtPwd,
            this.btnNext});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229))))));
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmSettingPWD_KeyDown);
            this.Load += new System.EventHandler(this.frmSettingPWD_Load);
            this.Name = "frmSettingPWD";

        }
        #endregion

        private UserControl.Title title1;
        internal Smobiler.Core.Controls.Label label2;
        internal Smobiler.Core.Controls.Label lblID1;
        internal Smobiler.Core.Controls.Label label1;
        internal Smobiler.Core.Controls.Label lblID2;
        internal Smobiler.Core.Controls.TextBox txtID;
        internal Smobiler.Core.Controls.TextBox txtPwd;
        internal Smobiler.Core.Controls.Button btnNext;
    }
}