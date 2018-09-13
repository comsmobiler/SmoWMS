namespace SMOWMS.UI.Analyze.Assets
{
    partial class frmAssQuantAnalysis : Smobiler.Core.Controls.MobileForm
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
            this.plCondition = new Smobiler.Core.Controls.Panel();
            this.btnWare = new Smobiler.Core.Controls.Button();
            this.btnType = new Smobiler.Core.Controls.Button();
            this.popWare = new Smobiler.Core.Controls.PopList();
            this.popType = new Smobiler.Core.Controls.PopList();
            this.tpvData = new Smobiler.Core.Controls.TabPageView();
            // 
            // Title1
            // 
            this.Title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.Title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title1.FontSize = 15F;
            this.Title1.ForeColor = System.Drawing.Color.White;
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(300, 40);
            this.Title1.TitleText = "资产库存";
            // 
            // plCondition
            // 
            this.plCondition.BackColor = System.Drawing.Color.White;
            this.plCondition.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plCondition.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plCondition.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnWare,
            this.btnType});
            this.plCondition.Dock = System.Windows.Forms.DockStyle.Top;
            this.plCondition.Location = new System.Drawing.Point(0, 40);
            this.plCondition.Name = "plCondition";
            this.plCondition.Size = new System.Drawing.Size(300, 60);
            // 
            // btnWare
            // 
            this.btnWare.BackColor = System.Drawing.Color.White;
            this.btnWare.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.btnWare.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnWare.ForeColor = System.Drawing.Color.Black;
            this.btnWare.Name = "btnWare";
            this.btnWare.Size = new System.Drawing.Size(300, 30);
            this.btnWare.Text = "全部仓库   > ";
            this.btnWare.Press += new System.EventHandler(this.btnWare_Press);
            // 
            // btnType
            // 
            this.btnType.BackColor = System.Drawing.Color.White;
            this.btnType.ForeColor = System.Drawing.Color.Black;
            this.btnType.Location = new System.Drawing.Point(0, 30);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(300, 30);
            this.btnType.Text = "全部类型   > ";
            this.btnType.Press += new System.EventHandler(this.btnType_Press);
            // 
            // popWare
            // 
            this.popWare.Name = "popWare";
            this.popWare.Selected += new System.EventHandler(this.popWare_Selected);
            // 
            // popType
            // 
            this.popType.Name = "popType";
            this.popType.Selected += new System.EventHandler(this.popType_Selected);
            // 
            // tpvData
            // 
            this.tpvData.BackColor = System.Drawing.Color.White;
            this.tpvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpvData.Location = new System.Drawing.Point(0, 100);
            this.tpvData.Name = "tpvData";
            this.tpvData.PageIndicator = Smobiler.Core.Controls.TabPageIndicator.Title;
            this.tpvData.Size = new System.Drawing.Size(300, 300);
            this.tpvData.Titles = new string[] {
        "总览",
        "详情"};
            this.tpvData.TitleStyle = new Smobiler.Core.Controls.TabPageViewTitleStyle(System.Drawing.Color.White, System.Drawing.Color.Black, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), 13F, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), 2);
            // 
            // frmAssQuantAnalysis
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.popWare,
            this.popType});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Title1,
            this.plCondition,
            this.tpvData});
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229))))));
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmAssQuantAnalysis_KeyDown);
            this.Load += new System.EventHandler(this.frmAssQuantAnalysis_Load);
            this.Name = "frmAssQuantAnalysis";

        }
        #endregion

        private UserControl.Title Title1;
        private Smobiler.Core.Controls.Panel plCondition;
        private Smobiler.Core.Controls.Button btnWare;
        private Smobiler.Core.Controls.Button btnType;
        private Smobiler.Core.Controls.PopList popWare;
        private Smobiler.Core.Controls.PopList popType;
        private Smobiler.Core.Controls.TabPageView tpvData;
    }
}