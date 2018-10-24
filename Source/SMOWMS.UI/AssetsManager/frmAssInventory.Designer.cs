namespace SMOWMS.UI.AssetsManager
{
    partial class frmAssInventory : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAssInventory()
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
            Smobiler.Core.Controls.ActionButtonItem actionButtonItem1 = new Smobiler.Core.Controls.ActionButtonItem();
            this.Title1 = new SMOWMS.UI.UserControl.Title();
            this.listView = new Smobiler.Core.Controls.ListView();
            this.plButton = new Smobiler.Core.Controls.Panel();
            this.ibEdit = new Smobiler.Core.Controls.ImageButton();
            // 
            // Title1
            // 
            this.Title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(124)))), ((int)(((byte)(246)))));
            this.Title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title1.FontSize = 15F;
            this.Title1.ForeColor = System.Drawing.Color.White;
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(300, 40);
            this.Title1.TitleText = "资产盘点单列表";
            // 
            // listView
            // 
            this.listView.BackColor = System.Drawing.Color.White;
            this.listView.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.listView.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.Location = new System.Drawing.Point(0, 40);
            this.listView.Name = "listView";
            this.listView.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView.PageSizeTextSize = 11F;
            this.listView.ShowSplitLine = true;
            this.listView.Size = new System.Drawing.Size(300, 300);
            this.listView.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.listView.TemplateControlName = "frmAssInventoryLayout";
            // 
            // plButton
            // 
            this.plButton.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.ibEdit});
            this.plButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.plButton.Location = new System.Drawing.Point(0, 40);
            this.plButton.Name = "plButton";
            this.plButton.Size = new System.Drawing.Size(300, 60);
            // 
            // ibEdit
            // 
            this.ibEdit.FontSize = 14F;
            this.ibEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(124)))), ((int)(((byte)(246)))));
            this.ibEdit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(124)))), ((int)(((byte)(246)))));
            this.ibEdit.ImageDirection = Smobiler.Core.Controls.Direction.Left;
            this.ibEdit.ImgTextRatio = new Smobiler.Core.Controls.Ratio(2, 8);
            this.ibEdit.Margin = new Smobiler.Core.Controls.Margin(0F, 12F, 0F, 250F);
            this.ibEdit.Name = "ibEdit";
            this.ibEdit.ResourceID = "icon-add";
            this.ibEdit.Size = new System.Drawing.Size(142, 36);
            this.ibEdit.Text = "新增盘点单";
            this.ibEdit.Press += new System.EventHandler(this.ibEdit_Press);
            // 
            // frmAssInventory
            // 
            this.ActionButton.ButtonSpacing = 12;
            actionButtonItem1.ResourceID = "pencil";
            actionButtonItem1.Text = "新增";
            this.ActionButton.Items.AddRange(new Smobiler.Core.Controls.ActionButtonItem[] {
            actionButtonItem1});
            this.ActionButton.ItemSize = 45;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Title1,
            this.plButton,
            this.listView});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(124)))), ((int)(((byte)(246))))));
            this.Load += new System.EventHandler(this.frmAssInventory_Load);
            this.Name = "frmAssInventory";

        }
        #endregion

        private UserControl.Title Title1;
        private Smobiler.Core.Controls.ListView listView;
        private Smobiler.Core.Controls.Panel plButton;
        internal Smobiler.Core.Controls.ImageButton ibEdit;
    }
}