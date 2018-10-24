using System;
using Smobiler.Core;
namespace SMOWMS.UI.ConsumablesManager
{
    partial class frmConInventoryEdit : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmConInventoryEdit()
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
            this.popMan = new Smobiler.Core.Controls.PopList();
            this.popWareHouse = new Smobiler.Core.Controls.PopList();
            this.popST = new Smobiler.Core.Controls.PopList();
            this.popSL = new Smobiler.Core.Controls.PopList();
            this.plTitle = new Smobiler.Core.Controls.Panel();
            this.plBack = new Smobiler.Core.Controls.Panel();
            this.Image1 = new Smobiler.Core.Controls.Image();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.plSave = new Smobiler.Core.Controls.Panel();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.plButton = new Smobiler.Core.Controls.Panel();
            this.btnDelete = new Smobiler.Core.Controls.Button();
            this.plContent = new Smobiler.Core.Controls.Panel();
            this.Label7 = new Smobiler.Core.Controls.Label();
            this.txtName = new Smobiler.Core.Controls.TextBox();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.btnWareHouse = new Smobiler.Core.Controls.Button();
            this.btnManager = new Smobiler.Core.Controls.Button();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.btnST = new Smobiler.Core.Controls.Button();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.btnSL = new Smobiler.Core.Controls.Button();
            // 
            // popMan
            // 
            this.popMan.Name = "popMan";
            this.popMan.Selected += new System.EventHandler(this.popMan_Selected);
            // 
            // popWareHouse
            // 
            this.popWareHouse.Name = "popWareHouse";
            this.popWareHouse.Selected += new System.EventHandler(this.popWareHouse_Selected);
            // 
            // popST
            // 
            this.popST.Name = "popST";
            this.popST.Title = "存储类型选择";
            this.popST.Selected += new System.EventHandler(this.popST_Selected);
            // 
            // popSL
            // 
            this.popSL.Name = "popSL";
            this.popSL.Title = "库位选择";
            this.popSL.Selected += new System.EventHandler(this.popSL_Selected);
            // 
            // plTitle
            // 
            this.plTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.plTitle.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plBack,
            this.label1,
            this.plSave});
            this.plTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTitle.Name = "plTitle";
            this.plTitle.Size = new System.Drawing.Size(300, 40);
            // 
            // plBack
            // 
            this.plBack.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Image1});
            this.plBack.Location = new System.Drawing.Point(10, 0);
            this.plBack.Name = "plBack";
            this.plBack.Size = new System.Drawing.Size(40, 40);
            this.plBack.Touchable = true;
            this.plBack.TouchOpacity = 100;
            this.plBack.Press += new System.EventHandler(this.plBack_Press);
            // 
            // Image1
            // 
            this.Image1.Name = "Image1";
            this.Image1.ResourceID = "back";
            this.Image1.Size = new System.Drawing.Size(40, 40);
            // 
            // label1
            // 
            this.label1.FontSize = 15F;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label1.Location = new System.Drawing.Point(50, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 40);
            this.label1.Text = "耗材盘点编辑";
            // 
            // plSave
            // 
            this.plSave.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label6});
            this.plSave.Location = new System.Drawing.Point(250, 0);
            this.plSave.Name = "plSave";
            this.plSave.Size = new System.Drawing.Size(40, 40);
            this.plSave.Touchable = true;
            this.plSave.TouchOpacity = 100;
            this.plSave.Press += new System.EventHandler(this.plSave_Press);
            // 
            // label6
            // 
            this.label6.FontSize = 15F;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 40);
            this.label6.Text = "保存";
            // 
            // plButton
            // 
            this.plButton.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnDelete});
            this.plButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plButton.Location = new System.Drawing.Point(0, 328);
            this.plButton.Name = "plButton";
            this.plButton.Size = new System.Drawing.Size(300, 50);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.BorderRadius = 4;
            this.btnDelete.FontSize = 15F;
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(10, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(280, 30);
            this.btnDelete.Text = "删除";
            this.btnDelete.Press += new System.EventHandler(this.btnDelete_Press);
            // 
            // plContent
            // 
            this.plContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.plContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label7,
            this.txtName,
            this.label3,
            this.label4,
            this.btnWareHouse,
            this.btnManager,
            this.label2,
            this.btnST,
            this.label5,
            this.btnSL});
            this.plContent.Flex = 1;
            this.plContent.Location = new System.Drawing.Point(0, 40);
            this.plContent.Name = "plContent";
            this.plContent.Size = new System.Drawing.Size(300, 160);
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.White;
            this.Label7.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label7.Name = "Label7";
            this.Label7.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label7.Size = new System.Drawing.Size(100, 30);
            this.Label7.Text = "盘点单名称";
            // 
            // txtName
            // 
            this.txtName.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtName.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtName.Location = new System.Drawing.Point(100, 0);
            this.txtName.Name = "txtName";
            this.txtName.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtName.Size = new System.Drawing.Size(200, 30);
            this.txtName.WaterMarkText = "（必填）";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label3.Location = new System.Drawing.Point(0, 70);
            this.label3.Name = "label3";
            this.label3.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label3.Size = new System.Drawing.Size(100, 30);
            this.label3.Text = "仓库";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label4.Location = new System.Drawing.Point(0, 30);
            this.label4.Name = "label4";
            this.label4.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label4.Size = new System.Drawing.Size(100, 30);
            this.label4.Text = "盘点人";
            // 
            // btnWareHouse
            // 
            this.btnWareHouse.BackColor = System.Drawing.Color.White;
            this.btnWareHouse.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.btnWareHouse.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnWareHouse.BorderRadius = 0;
            this.btnWareHouse.ForeColor = System.Drawing.Color.Black;
            this.btnWareHouse.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnWareHouse.Location = new System.Drawing.Point(100, 70);
            this.btnWareHouse.Name = "btnWareHouse";
            this.btnWareHouse.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.btnWareHouse.Size = new System.Drawing.Size(200, 30);
            this.btnWareHouse.Text = "选择（必填）   > ";
            this.btnWareHouse.Press += new System.EventHandler(this.btnLocation_Press);
            // 
            // btnManager
            // 
            this.btnManager.BackColor = System.Drawing.Color.White;
            this.btnManager.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.btnManager.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnManager.BorderRadius = 0;
            this.btnManager.ForeColor = System.Drawing.Color.Black;
            this.btnManager.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnManager.Location = new System.Drawing.Point(100, 30);
            this.btnManager.Name = "btnManager";
            this.btnManager.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.btnManager.Size = new System.Drawing.Size(200, 30);
            this.btnManager.Text = "选择（必填）   > ";
            this.btnManager.Press += new System.EventHandler(this.btnManager_Press);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label2.Location = new System.Drawing.Point(0, 100);
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.Text = "存储类型";
            // 
            // btnST
            // 
            this.btnST.BackColor = System.Drawing.Color.White;
            this.btnST.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.btnST.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnST.BorderRadius = 0;
            this.btnST.ForeColor = System.Drawing.Color.Black;
            this.btnST.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnST.Location = new System.Drawing.Point(100, 100);
            this.btnST.Name = "btnST";
            this.btnST.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.btnST.Size = new System.Drawing.Size(200, 30);
            this.btnST.Text = "选择（选填）   > ";
            this.btnST.Press += new System.EventHandler(this.btnST_Press);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label5.Location = new System.Drawing.Point(0, 130);
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label5.Size = new System.Drawing.Size(100, 30);
            this.label5.Text = "库位";
            // 
            // btnSL
            // 
            this.btnSL.BackColor = System.Drawing.Color.White;
            this.btnSL.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.btnSL.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSL.BorderRadius = 0;
            this.btnSL.ForeColor = System.Drawing.Color.Black;
            this.btnSL.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnSL.Location = new System.Drawing.Point(100, 130);
            this.btnSL.Name = "btnSL";
            this.btnSL.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.btnSL.Size = new System.Drawing.Size(200, 30);
            this.btnSL.Text = "选择（选填）   > ";
            this.btnSL.Press += new System.EventHandler(this.btnSL_Press);
            // 
            // frmConInventoryEdit
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.popMan,
            this.popWareHouse,
            this.popST,
            this.popSL});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plTitle,
            this.plButton,
            this.plContent});
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229))))));
            this.Load += new System.EventHandler(this.frmConInventoryEdit_Load);
            this.Name = "frmConInventoryEdit";

        }
        #endregion
        private Smobiler.Core.Controls.PopList popMan;
        private Smobiler.Core.Controls.PopList popWareHouse;
        private Smobiler.Core.Controls.PopList popST;
        private Smobiler.Core.Controls.PopList popSL;
        internal Smobiler.Core.Controls.Panel plTitle;
        private Smobiler.Core.Controls.Panel plBack;
        internal Smobiler.Core.Controls.Image Image1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Panel plSave;
        private Smobiler.Core.Controls.Label label6;
        private Smobiler.Core.Controls.Panel plButton;
        internal Smobiler.Core.Controls.Button btnDelete;
        private Smobiler.Core.Controls.Panel plContent;
        internal Smobiler.Core.Controls.Label Label7;
        internal Smobiler.Core.Controls.TextBox txtName;
        internal Smobiler.Core.Controls.Label label3;
        internal Smobiler.Core.Controls.Label label4;
        internal Smobiler.Core.Controls.Button btnWareHouse;
        internal Smobiler.Core.Controls.Button btnManager;
        internal Smobiler.Core.Controls.Label label2;
        internal Smobiler.Core.Controls.Button btnST;
        internal Smobiler.Core.Controls.Label label5;
        internal Smobiler.Core.Controls.Button btnSL;
    }
}