namespace SMOWMS.UI.Analyze.Assets
{
    partial class frmImminentExpiryAss : Smobiler.Core.Controls.MobileForm
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
            this.label1 = new Smobiler.Core.Controls.Label();
            this.btnTime = new Smobiler.Core.Controls.Button();
            this.lvRow = new Smobiler.Core.Controls.ListView();
            this.popTime = new Smobiler.Core.Controls.PopList();
            // 
            // Title1
            // 
            this.Title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.Title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title1.FontSize = 15F;
            this.Title1.ForeColor = System.Drawing.Color.White;
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(300, 40);
            this.Title1.TitleText = "临近过期资产";
            // 
            // plCondition
            // 
            this.plCondition.BackColor = System.Drawing.Color.White;
            this.plCondition.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plCondition.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plCondition.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.btnTime});
            this.plCondition.Dock = System.Windows.Forms.DockStyle.Top;
            this.plCondition.Location = new System.Drawing.Point(0, 40);
            this.plCondition.Name = "plCondition";
            this.plCondition.Size = new System.Drawing.Size(300, 35);
            // 
            // label1
            // 
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 5F, 0F);
            this.label1.Size = new System.Drawing.Size(80, 35);
            this.label1.Text = "过期时间";
            // 
            // btnTime
            // 
            this.btnTime.BackColor = System.Drawing.Color.White;
            this.btnTime.BorderRadius = 0;
            this.btnTime.ForeColor = System.Drawing.Color.Black;
            this.btnTime.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnTime.Location = new System.Drawing.Point(80, 0);
            this.btnTime.Name = "btnTime";
            this.btnTime.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.btnTime.Size = new System.Drawing.Size(220, 35);
            this.btnTime.Text = "近一个月   > ";
            this.btnTime.Press += new System.EventHandler(this.btnTime_Press);
            // 
            // lvRow
            // 
            this.lvRow.BackColor = System.Drawing.Color.White;
            this.lvRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvRow.Location = new System.Drawing.Point(0, 80);
            this.lvRow.Name = "lvRow";
            this.lvRow.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lvRow.PageSizeTextSize = 11F;
            this.lvRow.ShowSplitLine = true;
            this.lvRow.Size = new System.Drawing.Size(300, 300);
            this.lvRow.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lvRow.TemplateControlName = "frmIEAssLayout";
            // 
            // popTime
            // 
            this.popTime.Name = "popTime";
            this.popTime.Selected += new System.EventHandler(this.popTime_Selected);
            // 
            // frmImminentExpiryAss
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.popTime});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Title1,
            this.plCondition,
            this.lvRow});
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmImminentExpiryAss_KeyDown);
            this.Load += new System.EventHandler(this.frmImminentExpiryAss_Load);
            this.Name = "frmImminentExpiryAss";

        }
        #endregion

        private UserControl.Title Title1;
        private Smobiler.Core.Controls.Panel plCondition;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Button btnTime;
        private Smobiler.Core.Controls.ListView lvRow;
        private Smobiler.Core.Controls.PopList popTime;
    }
}