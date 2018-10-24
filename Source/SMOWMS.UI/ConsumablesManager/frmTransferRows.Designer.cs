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
            this.plTitle = new Smobiler.Core.Controls.Panel();
            this.plBack = new Smobiler.Core.Controls.Panel();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.plContent = new Smobiler.Core.Controls.Panel();
            this.plAdd = new Smobiler.Core.Controls.Panel();
            this.imgAdd = new Smobiler.Core.Controls.Image();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.listTransferOrder = new Smobiler.Core.Controls.ListView();
            // 
            // plTitle
            // 
            this.plTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.plTitle.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plBack,
            this.label1,
            this.label2});
            this.plTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTitle.Name = "plTitle";
            this.plTitle.Size = new System.Drawing.Size(300, 40);
            // 
            // plBack
            // 
            this.plBack.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label3,
            this.label4});
            this.plBack.Location = new System.Drawing.Point(10, 0);
            this.plBack.Name = "plBack";
            this.plBack.Size = new System.Drawing.Size(40, 40);
            this.plBack.Touchable = true;
            this.plBack.TouchOpacity = 100;
            this.plBack.Press += new System.EventHandler(this.plBack_Press);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 40);
            this.label3.Text = "<";
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 40);
            this.label4.Text = "仓库";
            // 
            // label1
            // 
            this.label1.FontSize = 15F;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label1.Location = new System.Drawing.Point(50, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 40);
            this.label1.Text = "耗材调拨";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(250, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 40);
            // 
            // plContent
            // 
            this.plContent.BackColor = System.Drawing.Color.White;
            this.plContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plAdd,
            this.listTransferOrder});
            this.plContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plContent.Location = new System.Drawing.Point(0, 162);
            this.plContent.Name = "plContent";
            this.plContent.Size = new System.Drawing.Size(300, 100);
            // 
            // plAdd
            // 
            this.plAdd.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imgAdd,
            this.label5});
            this.plAdd.Location = new System.Drawing.Point(0, 10);
            this.plAdd.Name = "plAdd";
            this.plAdd.Size = new System.Drawing.Size(180, 30);
            this.plAdd.Touchable = true;
            this.plAdd.TouchOpacity = 100;
            this.plAdd.Press += new System.EventHandler(this.plAdd_Press);
            // 
            // imgAdd
            // 
            this.imgAdd.Location = new System.Drawing.Point(10, 3);
            this.imgAdd.Name = "imgAdd";
            this.imgAdd.ResourceID = "icon-add";
            this.imgAdd.Size = new System.Drawing.Size(24, 24);
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(124)))), ((int)(((byte)(246)))));
            this.label5.Location = new System.Drawing.Point(44, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 30);
            this.label5.Text = "新增调拨单";
            // 
            // listTransferOrder
            // 
            this.listTransferOrder.BackColor = System.Drawing.Color.White;
            this.listTransferOrder.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.listTransferOrder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.listTransferOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listTransferOrder.Location = new System.Drawing.Point(0, 66);
            this.listTransferOrder.Margin = new Smobiler.Core.Controls.Margin(0F, 50F, 0F, 0F);
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
            this.plTitle,
            this.plContent});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229))))));
            this.Load += new System.EventHandler(this.frmTransferRows_Load);
            this.Name = "frmTransferRows";

        }
        #endregion
        private Smobiler.Core.Controls.Panel plTitle;
        private Smobiler.Core.Controls.Panel plBack;
        internal Smobiler.Core.Controls.Panel plContent;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.Panel plAdd;
        private Smobiler.Core.Controls.Image imgAdd;
        private Smobiler.Core.Controls.Label label5;
        internal Smobiler.Core.Controls.ListView listTransferOrder;
    }
}