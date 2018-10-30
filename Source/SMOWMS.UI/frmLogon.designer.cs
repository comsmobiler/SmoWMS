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
            this.checkRemb = new Smobiler.Core.Controls.CheckBox();
            this.lblNote = new Smobiler.Core.Controls.Label();
            this.btnLogon = new Smobiler.Core.Controls.Button();
            this.btnRegist = new Smobiler.Core.Controls.Button();
            this.btnDemo = new Smobiler.Core.Controls.Button();
            this.plUsername = new Smobiler.Core.Controls.Panel();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.txtUserName = new Smobiler.Core.Controls.TextBox();
            this.plPassword = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.txtPassWord = new Smobiler.Core.Controls.TextBox();
            this.btnForget = new Smobiler.Core.Controls.Button();
            this.line1 = new Smobiler.Core.Controls.Line();
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(122, 96);
            this.image1.Name = "image1";
            this.image1.ResourceID = "smowms";
            this.image1.Size = new System.Drawing.Size(56, 56);
            // 
            // checkRemb
            // 
            this.checkRemb.Location = new System.Drawing.Point(13, 290);
            this.checkRemb.Name = "checkRemb";
            this.checkRemb.Size = new System.Drawing.Size(15, 15);
            this.checkRemb.Style = Smobiler.Core.Controls.CheckBoxStyle.Circular;
            this.checkRemb.TintColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(153)))), ((int)(((byte)(238)))));
            // 
            // lblNote
            // 
            this.lblNote.ForeColor = System.Drawing.Color.Gray;
            this.lblNote.Location = new System.Drawing.Point(33, 280);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(100, 35);
            this.lblNote.Text = "¼Ç×¡ÃÜÂë";
            // 
            // btnLogon
            // 
            this.btnLogon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(153)))), ((int)(((byte)(238)))));
            this.btnLogon.BorderRadius = 4;
            this.btnLogon.Location = new System.Drawing.Point(10, 325);
            this.btnLogon.Name = "btnLogon";
            this.btnLogon.Size = new System.Drawing.Size(280, 40);
            this.btnLogon.Text = "µÇÂ¼";
            this.btnLogon.Press += new System.EventHandler(this.btnLogon_Click);
            // 
            // btnRegist
            // 
            this.btnRegist.BackColor = System.Drawing.Color.Transparent;
            this.btnRegist.BorderRadius = 0;
            this.btnRegist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(153)))), ((int)(((byte)(238)))));
            this.btnRegist.Location = new System.Drawing.Point(160, 283);
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
            this.btnDemo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(153)))), ((int)(((byte)(238)))));
            this.btnDemo.Location = new System.Drawing.Point(220, 283);
            this.btnDemo.Name = "btnDemo";
            this.btnDemo.Size = new System.Drawing.Size(60, 30);
            this.btnDemo.Text = "ÑÝÊ¾ÕËºÅ";
            this.btnDemo.Press += new System.EventHandler(this.btnDemo_Press);
            // 
            // plUsername
            // 
            this.plUsername.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plUsername.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label2,
            this.txtUserName});
            this.plUsername.Location = new System.Drawing.Point(10, 193);
            this.plUsername.Name = "plUsername";
            this.plUsername.Size = new System.Drawing.Size(280, 40);
            // 
            // label2
            // 
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 40);
            this.label2.Text = "ÓÃ»§Ãû";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.Transparent;
            this.txtUserName.Location = new System.Drawing.Point(60, 0);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(220, 40);
            this.txtUserName.WaterMarkText = "ÕËºÅ/ÊÖ»ú/ÓÊÏä";
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // plPassword
            // 
            this.plPassword.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plPassword.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.txtPassWord,
            this.btnForget});
            this.plPassword.Location = new System.Drawing.Point(10, 233);
            this.plPassword.Name = "plPassword";
            this.plPassword.Size = new System.Drawing.Size(280, 40);
            // 
            // label1
            // 
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 40);
            this.label1.Text = "ÃÜÂë";
            // 
            // txtPassWord
            // 
            this.txtPassWord.BackColor = System.Drawing.Color.Transparent;
            this.txtPassWord.Location = new System.Drawing.Point(60, 0);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.SecurityMode = true;
            this.txtPassWord.Size = new System.Drawing.Size(160, 40);
            this.txtPassWord.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // btnForget
            // 
            this.btnForget.BackColor = System.Drawing.Color.Transparent;
            this.btnForget.BorderRadius = 0;
            this.btnForget.ForeColor = System.Drawing.Color.Gray;
            this.btnForget.Location = new System.Drawing.Point(220, 0);
            this.btnForget.Name = "btnForget";
            this.btnForget.Size = new System.Drawing.Size(60, 40);
            this.btnForget.Text = "Íü¼ÇÃÜÂë";
            this.btnForget.Press += new System.EventHandler(this.btnForget_Press);
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.line1.Location = new System.Drawing.Point(220, 292);
            this.line1.Name = "line1";
            this.line1.Orientation = Smobiler.Core.Controls.OrientationAlignment.Vertical;
            this.line1.Size = new System.Drawing.Size(1, 15);
            // 
            // frmLogon
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageSizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1,
            this.checkRemb,
            this.lblNote,
            this.btnLogon,
            this.btnRegist,
            this.btnDemo,
            this.plUsername,
            this.plPassword,
            this.line1});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229))))));
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmLogon_KeyDown);
            this.Load += new System.EventHandler(this.frmLogon_Load);
            this.Name = "frmLogon";

        }
        #endregion

        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.CheckBox checkRemb;
        private Smobiler.Core.Controls.Label lblNote;
        internal Smobiler.Core.Controls.Button btnLogon;
        internal Smobiler.Core.Controls.Button btnRegist;
        internal Smobiler.Core.Controls.Button btnDemo;
        private Smobiler.Core.Controls.Panel plUsername;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.TextBox txtUserName;
        private Smobiler.Core.Controls.Panel plPassword;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.TextBox txtPassWord;
        private Smobiler.Core.Controls.Button btnForget;
        private Smobiler.Core.Controls.Line line1;
    }
}