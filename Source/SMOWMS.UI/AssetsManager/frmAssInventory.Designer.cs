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
            this.btnAdd = new Smobiler.Core.Controls.Button();
            this.listView = new Smobiler.Core.Controls.ListView();
            // 
            // Title1
            // 
            this.Title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.Title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title1.FontSize = 15F;
            this.Title1.ForeColor = System.Drawing.Color.White;
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(300, 40);
            this.Title1.TitleText = "资产盘点单列表";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnAdd.BorderRadius = 4;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.FontSize = 15F;
            this.btnAdd.Location = new System.Drawing.Point(0, 39);
            this.btnAdd.Margin = new Smobiler.Core.Controls.Margin(10F, 10F, 10F, 0F);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(280, 35);
            this.btnAdd.Text = "新增";
            this.btnAdd.Press += new System.EventHandler(this.btnAdd_Press);
            // 
            // listView
            // 
            this.listView.BackColor = System.Drawing.Color.White;
            this.listView.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.listView.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.Location = new System.Drawing.Point(0, 40);
            this.listView.Margin = new Smobiler.Core.Controls.Margin(0F, 20F, 0F, 0F);
            this.listView.Name = "listView";
            this.listView.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView.PageSizeTextSize = 11F;
            this.listView.Size = new System.Drawing.Size(300, 300);
            this.listView.TemplateControlName = "frmAssInventoryLayout";
            // 
            // frmAssInventory
            // 
            this.ActionButton.ButtonSpacing = 12;
            actionButtonItem1.ResourceID = "pencil";
            actionButtonItem1.Text = "新增";
            this.ActionButton.Items.AddRange(new Smobiler.Core.Controls.ActionButtonItem[] {
            actionButtonItem1});
            this.ActionButton.ItemSize = 45;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Title1,
            this.btnAdd,
            this.listView});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229))))));
            this.Load += new System.EventHandler(this.frmAssInventory_Load);
            this.Name = "frmAssInventory";

        }
        #endregion

        private UserControl.Title Title1;
        internal Smobiler.Core.Controls.Button btnAdd;
        private Smobiler.Core.Controls.ListView listView;
    }
}