namespace SMOWMS.UI.ConsumablesManager
{
    partial class frmConQuant : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmConQuant()
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
            this.GridView1 = new Smobiler.Core.Controls.GridView();
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.FontSize = 15F;
            this.title1.ForeColor = System.Drawing.Color.White;
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(300, 40);
            this.title1.TitleText = "¿â´æ·Ö²¼";
            // 
            // GridView1
            // 
            this.GridView1.BackColor = System.Drawing.Color.White;
            this.GridView1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.GridView1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.GridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridView1.Location = new System.Drawing.Point(0, 95);
            this.GridView1.Name = "GridView1";
            this.GridView1.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.GridView1.PageSizeTextSize = 11F;
            this.GridView1.Size = new System.Drawing.Size(300, 450);
            this.GridView1.TemplateControlName = "QuantShowLayout";
            // 
            // frmConQuant
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.GridView1});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229))))));
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmConQuant_KeyDown);
            this.Load += new System.EventHandler(this.frmConQuant_Load);
            this.Name = "frmConQuant";

        }
        #endregion

        private UserControl.Title title1;
        internal Smobiler.Core.Controls.GridView GridView1;
    }
}