using System;
using Smobiler.Core;
namespace SMOWMS.UI.Analyze.Consumable
{
    partial class frmSafeQuantAnalyze : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

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
            this.lvSafeQuant = new Smobiler.Core.Controls.ListView();
            // 
            // Title1
            // 
            this.Title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.Title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title1.FontSize = 15F;
            this.Title1.ForeColor = System.Drawing.Color.White;
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(300, 40);
            this.Title1.TitleText = "耗材安全库存统计";
            // 
            // lvSafeQuant
            // 
            this.lvSafeQuant.BackColor = System.Drawing.Color.White;
            this.lvSafeQuant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSafeQuant.Location = new System.Drawing.Point(0, 40);
            this.lvSafeQuant.Name = "lvSafeQuant";
            this.lvSafeQuant.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lvSafeQuant.PageSizeTextSize = 11F;
            this.lvSafeQuant.ShowSplitLine = true;
            this.lvSafeQuant.Size = new System.Drawing.Size(300, 300);
            this.lvSafeQuant.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lvSafeQuant.TemplateControlName = "frmSafeQuantAnalyzeLayout";
            // 
            // frmSafeQuantAnalyze
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Title1,
            this.lvSafeQuant});
            this.Load += new System.EventHandler(this.frmSafeQuantAnalyze_Load);
            this.Name = "frmSafeQuantAnalyze";

        }
        #endregion

        private UserControl.Title Title1;
        private Smobiler.Core.Controls.ListView lvSafeQuant;
    }
}