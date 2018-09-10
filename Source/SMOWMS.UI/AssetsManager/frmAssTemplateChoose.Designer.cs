using System;
using Smobiler.Core;
namespace SMOWMS.UI.AssetsManager
{
    partial class frmAssTemplateChoose : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAssTemplateChoose()
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
            this.plButton = new Smobiler.Core.Controls.Panel();
            this.plAll = new Smobiler.Core.Controls.Panel();
            this.Checkall = new Smobiler.Core.Controls.CheckBox();
            this.lblCheckall = new Smobiler.Core.Controls.Label();
            this.btnSave = new Smobiler.Core.Controls.Button();
            this.spContent = new Smobiler.Core.Controls.Panel();
            this.lvAssTemplate = new Smobiler.Core.Controls.ListView();
            this.plSearch = new Smobiler.Core.Controls.Panel();
            this.fontIcon1 = new Smobiler.Core.Controls.FontIcon();
            this.txtName = new Smobiler.Core.Controls.TextBox();
            // 
            // Title1
            // 
            this.Title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.Title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title1.FontSize = 15F;
            this.Title1.ForeColor = System.Drawing.Color.White;
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(300, 40);
            this.Title1.TitleText = "资产选择";
            // 
            // plButton
            // 
            this.plButton.BackColor = System.Drawing.Color.White;
            this.plButton.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plAll,
            this.btnSave});
            this.plButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plButton.Location = new System.Drawing.Point(0, 382);
            this.plButton.Name = "plButton";
            this.plButton.Size = new System.Drawing.Size(300, 70);
            // 
            // plAll
            // 
            this.plAll.BackColor = System.Drawing.Color.White;
            this.plAll.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Checkall,
            this.lblCheckall});
            this.plAll.Name = "plAll";
            this.plAll.Size = new System.Drawing.Size(300, 35);
            // 
            // Checkall
            // 
            this.Checkall.Location = new System.Drawing.Point(8, 8);
            this.Checkall.Name = "Checkall";
            this.Checkall.Size = new System.Drawing.Size(20, 20);
            this.Checkall.ZIndex = 2;
            this.Checkall.CheckedChanged += new System.EventHandler(this.Checkall_CheckedChanged);
            // 
            // lblCheckall
            // 
            this.lblCheckall.FontSize = 12F;
            this.lblCheckall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblCheckall.Location = new System.Drawing.Point(42, 0);
            this.lblCheckall.Name = "lblCheckall";
            this.lblCheckall.Size = new System.Drawing.Size(40, 35);
            this.lblCheckall.Text = "全选";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnSave.BorderRadius = 4;
            this.btnSave.FontSize = 17F;
            this.btnSave.Location = new System.Drawing.Point(10, 35);
            this.btnSave.Margin = new Smobiler.Core.Controls.Margin(0F, 0F, 10F, 0F);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(280, 35);
            this.btnSave.Text = "确定";
            this.btnSave.Press += new System.EventHandler(this.btnSave_Press);
            // 
            // spContent
            // 
            this.spContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lvAssTemplate});
            this.spContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spContent.Flex = 10000;
            this.spContent.Location = new System.Drawing.Point(0, 40);
            this.spContent.Name = "spContent";
            this.spContent.Size = new System.Drawing.Size(300, 300);
            // 
            // lvAssTemplate
            // 
            this.lvAssTemplate.BackColor = System.Drawing.Color.White;
            this.lvAssTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvAssTemplate.Margin = new Smobiler.Core.Controls.Margin(0F, 20F, 0F, 0F);
            this.lvAssTemplate.Name = "lvAssTemplate";
            this.lvAssTemplate.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lvAssTemplate.PageSizeTextSize = 11F;
            this.lvAssTemplate.ShowSplitLine = true;
            this.lvAssTemplate.Size = new System.Drawing.Size(300, 355);
            this.lvAssTemplate.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lvAssTemplate.TemplateControlName = "frmATChooseLayout";
            // 
            // plSearch
            // 
            this.plSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.plSearch.BorderRadius = 4;
            this.plSearch.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.fontIcon1,
            this.txtName});
            this.plSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.plSearch.Location = new System.Drawing.Point(10, 8);
            this.plSearch.Margin = new Smobiler.Core.Controls.Margin(10F);
            this.plSearch.Name = "plSearch";
            this.plSearch.Size = new System.Drawing.Size(280, 20);
            // 
            // fontIcon1
            // 
            this.fontIcon1.ForeColor = System.Drawing.Color.Silver;
            this.fontIcon1.Location = new System.Drawing.Point(10, 2);
            this.fontIcon1.Name = "fontIcon1";
            this.fontIcon1.ResourceID = "search";
            this.fontIcon1.Size = new System.Drawing.Size(16, 16);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.Location = new System.Drawing.Point(40, 0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(230, 20);
            this.txtName.WaterMarkText = "请输入资产名称或资产条码";
            this.txtName.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // frmAssTemplateChoose
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Title1,
            this.plSearch,
            this.plButton,
            this.spContent});
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229))))));
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmAssTemplateChoose_KeyDown);
            this.Load += new System.EventHandler(this.frmAssTemplateChoose_Load);
            this.Name = "frmAssTemplateChoose";

        }
        #endregion

        private UserControl.Title Title1;
        private Smobiler.Core.Controls.Panel plButton;
        private Smobiler.Core.Controls.Panel plAll;
        internal Smobiler.Core.Controls.CheckBox Checkall;
        internal Smobiler.Core.Controls.Label lblCheckall;
        private Smobiler.Core.Controls.Button btnSave;
        internal Smobiler.Core.Controls.Panel spContent;
        private Smobiler.Core.Controls.ListView lvAssTemplate;
        private Smobiler.Core.Controls.Panel plSearch;
        private Smobiler.Core.Controls.FontIcon fontIcon1;
        private Smobiler.Core.Controls.TextBox txtName;
    }
}