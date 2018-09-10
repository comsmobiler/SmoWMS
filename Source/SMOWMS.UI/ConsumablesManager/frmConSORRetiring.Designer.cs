using System;
using Smobiler.Core;
namespace SMOWMS.UI.ConsumablesManager
{
    partial class frmConSORRetiring : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmConSORRetiring()
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
            this.plButton = new Smobiler.Core.Controls.Panel();
            this.btnSave = new Smobiler.Core.Controls.Button();
            this.plAll = new Smobiler.Core.Controls.Panel();
            this.Checkall = new Smobiler.Core.Controls.CheckBox();
            this.lblCheckall = new Smobiler.Core.Controls.Label();
            this.listCons = new Smobiler.Core.Controls.ListView();
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.FontSize = 15F;
            this.title1.ForeColor = System.Drawing.Color.White;
            this.title1.Location = new System.Drawing.Point(59, 21);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 40);
            this.title1.TitleText = "销售退货";
            // 
            // plButton
            // 
            this.plButton.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.plButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plButton.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnSave,
            this.plAll});
            this.plButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plButton.Location = new System.Drawing.Point(0, 235);
            this.plButton.Name = "plButton";
            this.plButton.Size = new System.Drawing.Size(300, 70);
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
            this.btnSave.Text = "提交";
            this.btnSave.Press += new System.EventHandler(this.btnSave_Press);
            // 
            // plAll
            // 
            this.plAll.BackColor = System.Drawing.Color.White;
            this.plAll.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Checkall,
            this.lblCheckall});
            this.plAll.Name = "plAll";
            this.plAll.Size = new System.Drawing.Size(300, 35);
            this.plAll.Touchable = true;
            this.plAll.Press += new System.EventHandler(this.plAll_Press);
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
            // listCons
            // 
            this.listCons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listCons.Location = new System.Drawing.Point(0, 35);
            this.listCons.Name = "listCons";
            this.listCons.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listCons.PageSizeTextSize = 11F;
            this.listCons.ShowSplitLine = true;
            this.listCons.Size = new System.Drawing.Size(300, 300);
            this.listCons.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.listCons.TemplateControlName = "frmConSORRetiringLayout";
            // 
            // frmConSORRetiring
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.plButton,
            this.listCons});
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229))))));
            this.Load += new System.EventHandler(this.frmConSORRetiring_Load);
            this.Name = "frmConSORRetiring";

        }
        #endregion

        private UserControl.Title title1;
        private Smobiler.Core.Controls.Panel plButton;
        private Smobiler.Core.Controls.Button btnSave;
        private Smobiler.Core.Controls.Panel plAll;
        internal Smobiler.Core.Controls.CheckBox Checkall;
        internal Smobiler.Core.Controls.Label lblCheckall;
        private Smobiler.Core.Controls.ListView listCons;
    }
}