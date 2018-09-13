using System;
using Smobiler.Core;
namespace SMOWMS.UI.ConsumablesManager
{
    partial class frmTransferRows : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmTransferRows()
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
            this.Title = new SMOWMS.UI.UserControl.Title();
            this.plContent = new Smobiler.Core.Controls.Panel();
            this.btnCreate = new Smobiler.Core.Controls.Button();
            this.listTransferOrder = new Smobiler.Core.Controls.ListView();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.FontSize = 15F;
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(132, 52);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(100, 40);
            this.Title.TitleText = "耗材调拨单列表";
            // 
            // plContent
            // 
            this.plContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnCreate,
            this.listTransferOrder});
            this.plContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plContent.Location = new System.Drawing.Point(0, 162);
            this.plContent.Name = "plContent";
            this.plContent.Size = new System.Drawing.Size(300, 100);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnCreate.BorderRadius = 4;
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreate.FontSize = 15F;
            this.btnCreate.Location = new System.Drawing.Point(0, 10);
            this.btnCreate.Margin = new Smobiler.Core.Controls.Margin(10F, 10F, 10F, 0F);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(280, 35);
            this.btnCreate.Text = "创建调拨单";
            this.btnCreate.Press += new System.EventHandler(this.btnCreate_Press);
            // 
            // listTransferOrder
            // 
            this.listTransferOrder.BackColor = System.Drawing.Color.White;
            this.listTransferOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listTransferOrder.Location = new System.Drawing.Point(0, 66);
            this.listTransferOrder.Margin = new Smobiler.Core.Controls.Margin(0F, 20F, 0F, 0F);
            this.listTransferOrder.Name = "listTransferOrder";
            this.listTransferOrder.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listTransferOrder.PageSizeTextSize = 11F;
            this.listTransferOrder.ShowSplitLine = true;
            this.listTransferOrder.Size = new System.Drawing.Size(300, 300);
            this.listTransferOrder.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.listTransferOrder.TemplateControlName = "frmTransferRowsLayout";
            // 
            // frmTransferRows
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Title,
            this.plContent});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229))))));
            this.Load += new System.EventHandler(this.frmTransferRows_Load);
            this.Name = "frmTransferRows";

        }
        #endregion

        private UserControl.Title Title;
        internal Smobiler.Core.Controls.Panel plContent;
        private Smobiler.Core.Controls.Button btnCreate;
        internal Smobiler.Core.Controls.ListView listTransferOrder;
    }
}