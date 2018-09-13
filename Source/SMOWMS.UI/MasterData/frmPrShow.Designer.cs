using System;
using SMOWMS.UI.UserControl;
using Smobiler.Core;
namespace SMOWMS.UI.MasterData
{
    partial class frmPrShow : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmPrShow()
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
            this.Title1 = new SMOWMS.UI.UserControl.Title();
            this.GridView1 = new Smobiler.Core.Controls.GridView();
            // 
            // Title1
            // 
            this.Title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.Title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title1.FontSize = 15F;
            this.Title1.ForeColor = System.Drawing.Color.White;
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(300, 40);
            this.Title1.TitleText = "´¦Àí¼ÇÂ¼";
            // 
            // GridView1
            // 
            this.GridView1.BackColor = System.Drawing.Color.White;
            this.GridView1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.GridView1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.GridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridView1.Location = new System.Drawing.Point(0, 70);
            this.GridView1.Name = "GridView1";
            this.GridView1.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.GridView1.PageSizeTextSize = 11F;
            this.GridView1.Size = new System.Drawing.Size(300, 450);
            this.GridView1.TemplateControlName = "PrShowLayout";
            // 
            // frmPrShow
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Title1,
            this.GridView1});
            this.Name = "frmPrShow";
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229))))));
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmPRShow_KeyDown);
            this.Load += new System.EventHandler(this.frmPRShow_Load);
            this.Name = "frmPrShow";

        }
        #endregion

        private Title Title1;
        internal Smobiler.Core.Controls.GridView GridView1;
    }
}