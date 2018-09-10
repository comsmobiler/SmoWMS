namespace SMOWMS.UI
{
    partial class frmLogon : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmLogon()
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
            this.image1 = new Smobiler.Core.Controls.Image();
            this.lblUserName = new Smobiler.Core.Controls.Label();
            this.txtUserName = new Smobiler.Core.Controls.TextBox();
            this.lblPassWord = new Smobiler.Core.Controls.Label();
            this.txtPassWord = new Smobiler.Core.Controls.TextBox();
            this.checkRemb = new Smobiler.Core.Controls.CheckBox();
            this.lblNote = new Smobiler.Core.Controls.Label();
            this.btnLogon = new Smobiler.Core.Controls.Button();
            this.btnRegist = new Smobiler.Core.Controls.Button();
            this.btnDemo = new Smobiler.Core.Controls.Button();
            this.btnForget = new Smobiler.Core.Controls.Button();
            this.FontIcon1 = new Smobiler.Core.Controls.FontIcon();
            this.FontIcon2 = new Smobiler.Core.Controls.FontIcon();
            this.Line1 = new Smobiler.Core.Controls.Line();
            this.Line2 = new Smobiler.Core.Controls.Line();
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(100, 50);
            this.image1.Name = "image1";
            this.image1.ResourceID = "smowms";
            this.image1.Size = new System.Drawing.Size(100, 100);
            // 
            // lblUserName
            // 
            this.lblUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblUserName.Border = new Smobiler.Core.Controls.Border(1F);
            this.lblUserName.BorderColor = System.Drawing.Color.White;
            this.lblUserName.BorderRadius = 20;
            this.lblUserName.Location = new System.Drawing.Point(40, 183);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(220, 40);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.Transparent;
            this.txtUserName.ForeColor = System.Drawing.Color.White;
            this.txtUserName.Location = new System.Drawing.Point(77, 183);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(163, 40);
            this.txtUserName.WaterMarkText = "ÕËºÅ/ÊÖ»ú/ÓÊÏä";
            this.txtUserName.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // lblPassWord
            // 
            this.lblPassWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblPassWord.Border = new Smobiler.Core.Controls.Border(1F);
            this.lblPassWord.BorderColor = System.Drawing.Color.White;
            this.lblPassWord.BorderRadius = 20;
            this.lblPassWord.Location = new System.Drawing.Point(40, 236);
            this.lblPassWord.Name = "lblPassWord";
            this.lblPassWord.Size = new System.Drawing.Size(220, 40);
            // 
            // txtPassWord
            // 
            this.txtPassWord.BackColor = System.Drawing.Color.Transparent;
            this.txtPassWord.ForeColor = System.Drawing.Color.White;
            this.txtPassWord.Location = new System.Drawing.Point(77, 236);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.SecurityMode = true;
            this.txtPassWord.Size = new System.Drawing.Size(163, 40);
            this.txtPassWord.WaterMarkText = "ÃÜÂë";
            this.txtPassWord.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // checkRemb
            // 
            this.checkRemb.Location = new System.Drawing.Point(53, 290);
            this.checkRemb.Name = "checkRemb";
            this.checkRemb.Size = new System.Drawing.Size(15, 15);
            this.checkRemb.TintColor = System.Drawing.Color.White;
            // 
            // lblNote
            // 
            this.lblNote.ForeColor = System.Drawing.Color.White;
            this.lblNote.Location = new System.Drawing.Point(77, 280);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(100, 35);
            this.lblNote.Text = "¼Ç×¡ÃÜÂë";
            // 
            // btnLogon
            // 
            this.btnLogon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(153)))), ((int)(((byte)(238)))));
            this.btnLogon.BorderRadius = 20;
            this.btnLogon.Location = new System.Drawing.Point(40, 325);
            this.btnLogon.Name = "btnLogon";
            this.btnLogon.Size = new System.Drawing.Size(220, 40);
            this.btnLogon.Text = "µÇÂ¼";
            this.btnLogon.Press += new System.EventHandler(this.btnLogon_Click);
            // 
            // btnRegist
            // 
            this.btnRegist.BackColor = System.Drawing.Color.Transparent;
            this.btnRegist.BorderRadius = 0;
            this.btnRegist.Location = new System.Drawing.Point(60, 375);
            this.btnRegist.Name = "btnRegist";
            this.btnRegist.Size = new System.Drawing.Size(60, 30);
            this.btnRegist.Text = "Á¢¼´×¢²á";
            this.btnRegist.Press += new System.EventHandler(this.btnRegist_Press);
            // 
            // btnDemo
            // 
            this.btnDemo.BackColor = System.Drawing.Color.Transparent;
            this.btnDemo.BorderColor = System.Drawing.Color.White;
            this.btnDemo.BorderRadius = 0;
            this.btnDemo.Location = new System.Drawing.Point(120, 375);
            this.btnDemo.Name = "btnDemo";
            this.btnDemo.Size = new System.Drawing.Size(60, 30);
            this.btnDemo.Text = "ÑÝÊ¾ÕËºÅ";
            this.btnDemo.Press += new System.EventHandler(this.btnDemo_Press);
            // 
            // btnForget
            // 
            this.btnForget.BackColor = System.Drawing.Color.Transparent;
            this.btnForget.BorderRadius = 0;
            this.btnForget.Location = new System.Drawing.Point(180, 375);
            this.btnForget.Name = "btnForget";
            this.btnForget.Size = new System.Drawing.Size(60, 30);
            this.btnForget.Text = "Íü¼ÇÃÜÂë";
            this.btnForget.Press += new System.EventHandler(this.btnForget_Press);
            // 
            // FontIcon1
            // 
            this.FontIcon1.ForeColor = System.Drawing.Color.White;
            this.FontIcon1.Location = new System.Drawing.Point(53, 193);
            this.FontIcon1.Name = "FontIcon1";
            this.FontIcon1.ResourceID = "user";
            this.FontIcon1.Size = new System.Drawing.Size(17, 17);
            // 
            // FontIcon2
            // 
            this.FontIcon2.ForeColor = System.Drawing.Color.White;
            this.FontIcon2.Location = new System.Drawing.Point(53, 247);
            this.FontIcon2.Name = "FontIcon2";
            this.FontIcon2.ResourceID = "lock";
            this.FontIcon2.Size = new System.Drawing.Size(17, 17);
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.White;
            this.Line1.Location = new System.Drawing.Point(120, 383);
            this.Line1.Name = "Line1";
            this.Line1.Orientation = Smobiler.Core.Controls.OrientationAlignment.Vertical;
            this.Line1.Size = new System.Drawing.Size(1, 14);
            // 
            // Line2
            // 
            this.Line2.BackColor = System.Drawing.Color.White;
            this.Line2.Location = new System.Drawing.Point(180, 383);
            this.Line2.Name = "Line2";
            this.Line2.Orientation = Smobiler.Core.Controls.OrientationAlignment.Vertical;
            this.Line2.Size = new System.Drawing.Size(1, 14);
            // 
            // frmLogon
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = "bg";
            this.BackgroundImageSizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1,
            this.lblUserName,
            this.txtUserName,
            this.lblPassWord,
            this.txtPassWord,
            this.checkRemb,
            this.lblNote,
            this.btnLogon,
            this.btnRegist,
            this.btnDemo,
            this.btnForget,
            this.FontIcon1,
            this.FontIcon2,
            this.Line1,
            this.Line2});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229))))));
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmLogon_KeyDown);
            this.Load += new System.EventHandler(this.frmLogon_Load);
            this.Name = "frmLogon";

        }
        #endregion

        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Label lblUserName;
        private Smobiler.Core.Controls.TextBox txtUserName;
        private Smobiler.Core.Controls.Label lblPassWord;
        private Smobiler.Core.Controls.TextBox txtPassWord;
        private Smobiler.Core.Controls.CheckBox checkRemb;
        private Smobiler.Core.Controls.Label lblNote;
        internal Smobiler.Core.Controls.Button btnLogon;
        internal Smobiler.Core.Controls.Button btnRegist;
        internal Smobiler.Core.Controls.Button btnDemo;
        internal Smobiler.Core.Controls.Button btnForget;
        internal Smobiler.Core.Controls.FontIcon FontIcon1;
        internal Smobiler.Core.Controls.FontIcon FontIcon2;
        internal Smobiler.Core.Controls.Line Line1;
        internal Smobiler.Core.Controls.Line Line2;
    }
}