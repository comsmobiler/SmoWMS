using SMOWMS.UI.UserControl;

namespace SMOWMS.UI.MasterData
{
    partial class frmAssetsDetail : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAssetsDetail()
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
            this.btnPrint = new Smobiler.Core.Controls.Button();
            this.btnEdit = new Smobiler.Core.Controls.Button();
            this.btnLog = new Smobiler.Core.Controls.Button();
            this.plContent = new Smobiler.Core.Controls.Panel();
            this.label35 = new Smobiler.Core.Controls.Label();
            this.label36 = new Smobiler.Core.Controls.Label();
            this.label37 = new Smobiler.Core.Controls.Label();
            this.label38 = new Smobiler.Core.Controls.Label();
            this.label39 = new Smobiler.Core.Controls.Label();
            this.label40 = new Smobiler.Core.Controls.Label();
            this.label41 = new Smobiler.Core.Controls.Label();
            this.label42 = new Smobiler.Core.Controls.Label();
            this.label43 = new Smobiler.Core.Controls.Label();
            this.label44 = new Smobiler.Core.Controls.Label();
            this.label45 = new Smobiler.Core.Controls.Label();
            this.label46 = new Smobiler.Core.Controls.Label();
            this.txtName1 = new Smobiler.Core.Controls.TextBox();
            this.txtSPE1 = new Smobiler.Core.Controls.TextBox();
            this.txtATID = new Smobiler.Core.Controls.TextBox();
            this.txtUnit1 = new Smobiler.Core.Controls.TextBox();
            this.txtSN1 = new Smobiler.Core.Controls.TextBox();
            this.txtPrice1 = new Smobiler.Core.Controls.TextBox();
            this.panel6 = new Smobiler.Core.Controls.Panel();
            this.image2 = new Smobiler.Core.Controls.Image();
            this.label47 = new Smobiler.Core.Controls.Label();
            this.txtNote1 = new Smobiler.Core.Controls.TextBox();
            this.label48 = new Smobiler.Core.Controls.Label();
            this.txtAssId1 = new Smobiler.Core.Controls.TextBox();
            this.label49 = new Smobiler.Core.Controls.Label();
            this.txtPlace1 = new Smobiler.Core.Controls.TextBox();
            this.label50 = new Smobiler.Core.Controls.Label();
            this.txtVendor1 = new Smobiler.Core.Controls.TextBox();
            this.label51 = new Smobiler.Core.Controls.Label();
            this.txtType = new Smobiler.Core.Controls.TextBox();
            this.txtSL = new Smobiler.Core.Controls.TextBox();
            this.txtManager = new Smobiler.Core.Controls.TextBox();
            this.txtBuyDate = new Smobiler.Core.Controls.TextBox();
            this.txtEDate = new Smobiler.Core.Controls.TextBox();
            this.popCurrentUser = new Smobiler.Core.Controls.PopList();
            this.posPrinter1 = new Smobiler.Device.PosPrinter();
            // 
            // Title1
            // 
            this.Title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.Title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title1.FontSize = 15F;
            this.Title1.ForeColor = System.Drawing.Color.White;
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(300, 40);
            this.Title1.TitleText = "资产详情";
            // 
            // plButton
            // 
            this.plButton.BackColor = System.Drawing.Color.White;
            this.plButton.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.plButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plButton.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnPrint,
            this.btnEdit,
            this.btnLog});
            this.plButton.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.plButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plButton.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.plButton.Location = new System.Drawing.Point(0, 40);
            this.plButton.Name = "plButton";
            this.plButton.Size = new System.Drawing.Size(300, 35);
            // 
            // btnPrint
            // 
            this.btnPrint.Flex = 1;
            this.btnPrint.Margin = new Smobiler.Core.Controls.Margin(2F, 5F, 2F, 5F);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(0, 0);
            this.btnPrint.Text = "打印";
            this.btnPrint.Press += new System.EventHandler(this.btnPrint_Press);
            // 
            // btnEdit
            // 
            this.btnEdit.Flex = 1;
            this.btnEdit.Margin = new Smobiler.Core.Controls.Margin(2F, 5F, 2F, 5F);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(0, 0);
            this.btnEdit.Text = "修改资产";
            this.btnEdit.Press += new System.EventHandler(this.btnEdit_Press);
            // 
            // btnLog
            // 
            this.btnLog.Flex = 1;
            this.btnLog.Margin = new Smobiler.Core.Controls.Margin(2F, 5F, 2F, 5F);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(0, 0);
            this.btnLog.Text = "处理记录";
            this.btnLog.Press += new System.EventHandler(this.btnLog_Press);
            // 
            // plContent
            // 
            this.plContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label35,
            this.label36,
            this.label37,
            this.label38,
            this.label39,
            this.label40,
            this.label41,
            this.label42,
            this.label43,
            this.label44,
            this.label45,
            this.label46,
            this.txtName1,
            this.txtSPE1,
            this.txtATID,
            this.txtUnit1,
            this.txtSN1,
            this.txtPrice1,
            this.panel6,
            this.label47,
            this.txtNote1,
            this.label48,
            this.txtAssId1,
            this.label49,
            this.txtPlace1,
            this.label50,
            this.txtVendor1,
            this.label51,
            this.txtType,
            this.txtSL,
            this.txtManager,
            this.txtBuyDate,
            this.txtEDate});
            this.plContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plContent.Flex = 10000;
            this.plContent.Location = new System.Drawing.Point(0, 70);
            this.plContent.Name = "plContent";
            this.plContent.Scrollable = true;
            this.plContent.Size = new System.Drawing.Size(300, 410);
            // 
            // label35
            // 
            this.label35.BackColor = System.Drawing.Color.White;
            this.label35.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label35.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label35.Location = new System.Drawing.Point(0, 80);
            this.label35.Name = "label35";
            this.label35.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label35.Size = new System.Drawing.Size(100, 55);
            this.label35.Text = "图片";
            // 
            // label36
            // 
            this.label36.BackColor = System.Drawing.Color.White;
            this.label36.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label36.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label36.Location = new System.Drawing.Point(0, 40);
            this.label36.Name = "label36";
            this.label36.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label36.Size = new System.Drawing.Size(100, 40);
            this.label36.Text = "名称";
            // 
            // label37
            // 
            this.label37.BackColor = System.Drawing.Color.White;
            this.label37.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label37.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label37.Location = new System.Drawing.Point(0, 215);
            this.label37.Name = "label37";
            this.label37.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label37.Size = new System.Drawing.Size(100, 40);
            this.label37.Text = "类别";
            // 
            // label38
            // 
            this.label38.BackColor = System.Drawing.Color.White;
            this.label38.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label38.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label38.Location = new System.Drawing.Point(0, 255);
            this.label38.Name = "label38";
            this.label38.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label38.Size = new System.Drawing.Size(100, 55);
            this.label38.Text = "规格型号";
            // 
            // label39
            // 
            this.label39.BackColor = System.Drawing.Color.White;
            this.label39.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label39.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label39.Location = new System.Drawing.Point(0, 310);
            this.label39.Name = "label39";
            this.label39.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label39.Size = new System.Drawing.Size(100, 40);
            this.label39.Text = "库位";
            // 
            // label40
            // 
            this.label40.BackColor = System.Drawing.Color.White;
            this.label40.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label40.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label40.Location = new System.Drawing.Point(0, 390);
            this.label40.Name = "label40";
            this.label40.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label40.Size = new System.Drawing.Size(100, 40);
            this.label40.Text = "模板编号";
            // 
            // label41
            // 
            this.label41.BackColor = System.Drawing.Color.White;
            this.label41.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label41.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label41.Location = new System.Drawing.Point(0, 430);
            this.label41.Name = "label41";
            this.label41.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label41.Size = new System.Drawing.Size(100, 40);
            this.label41.Text = "单位";
            // 
            // label42
            // 
            this.label42.BackColor = System.Drawing.Color.White;
            this.label42.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label42.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label42.Location = new System.Drawing.Point(0, 135);
            this.label42.Name = "label42";
            this.label42.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label42.Size = new System.Drawing.Size(100, 40);
            this.label42.Text = "SN";
            // 
            // label43
            // 
            this.label43.BackColor = System.Drawing.Color.White;
            this.label43.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label43.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label43.Location = new System.Drawing.Point(0, 175);
            this.label43.Name = "label43";
            this.label43.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label43.Size = new System.Drawing.Size(100, 40);
            this.label43.Text = "金额";
            // 
            // label44
            // 
            this.label44.BackColor = System.Drawing.Color.White;
            this.label44.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label44.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label44.Location = new System.Drawing.Point(0, 470);
            this.label44.Name = "label44";
            this.label44.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label44.Size = new System.Drawing.Size(100, 40);
            this.label44.Text = "购入时间";
            // 
            // label45
            // 
            this.label45.BackColor = System.Drawing.Color.White;
            this.label45.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label45.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label45.Name = "label45";
            this.label45.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label45.Size = new System.Drawing.Size(100, 40);
            this.label45.Text = "资产编号";
            // 
            // label46
            // 
            this.label46.BackColor = System.Drawing.Color.White;
            this.label46.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label46.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label46.Location = new System.Drawing.Point(100, 80);
            this.label46.Name = "label46";
            this.label46.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label46.Size = new System.Drawing.Size(200, 55);
            // 
            // txtName1
            // 
            this.txtName1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtName1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtName1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtName1.Location = new System.Drawing.Point(100, 40);
            this.txtName1.Name = "txtName1";
            this.txtName1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtName1.ReadOnly = true;
            this.txtName1.Size = new System.Drawing.Size(199, 40);
            this.txtName1.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // txtSPE1
            // 
            this.txtSPE1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtSPE1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtSPE1.Location = new System.Drawing.Point(100, 255);
            this.txtSPE1.Multiline = true;
            this.txtSPE1.Name = "txtSPE1";
            this.txtSPE1.Padding = new Smobiler.Core.Controls.Padding(0F, 5F, 10F, 0F);
            this.txtSPE1.ReadOnly = true;
            this.txtSPE1.Size = new System.Drawing.Size(199, 55);
            this.txtSPE1.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // txtATID
            // 
            this.txtATID.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtATID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtATID.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtATID.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtATID.Location = new System.Drawing.Point(100, 390);
            this.txtATID.Name = "txtATID";
            this.txtATID.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtATID.ReadOnly = true;
            this.txtATID.Size = new System.Drawing.Size(199, 40);
            this.txtATID.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // txtUnit1
            // 
            this.txtUnit1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtUnit1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtUnit1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtUnit1.Location = new System.Drawing.Point(100, 430);
            this.txtUnit1.Name = "txtUnit1";
            this.txtUnit1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtUnit1.ReadOnly = true;
            this.txtUnit1.Size = new System.Drawing.Size(199, 40);
            this.txtUnit1.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // txtSN1
            // 
            this.txtSN1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtSN1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtSN1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtSN1.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtSN1.Location = new System.Drawing.Point(100, 135);
            this.txtSN1.Name = "txtSN1";
            this.txtSN1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtSN1.ReadOnly = true;
            this.txtSN1.Size = new System.Drawing.Size(199, 40);
            this.txtSN1.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // txtPrice1
            // 
            this.txtPrice1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtPrice1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtPrice1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtPrice1.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtPrice1.Location = new System.Drawing.Point(100, 175);
            this.txtPrice1.Name = "txtPrice1";
            this.txtPrice1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtPrice1.ReadOnly = true;
            this.txtPrice1.Size = new System.Drawing.Size(199, 40);
            this.txtPrice1.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image2});
            this.panel6.Location = new System.Drawing.Point(260, 92);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(30, 30);
            // 
            // image2
            // 
            this.image2.Name = "image2";
            this.image2.ResourceID = "mare";
            this.image2.Size = new System.Drawing.Size(30, 30);
            // 
            // label47
            // 
            this.label47.BackColor = System.Drawing.Color.White;
            this.label47.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label47.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label47.Location = new System.Drawing.Point(0, 630);
            this.label47.Name = "label47";
            this.label47.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label47.Size = new System.Drawing.Size(100, 55);
            this.label47.Text = "备注";
            // 
            // txtNote1
            // 
            this.txtNote1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtNote1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtNote1.Location = new System.Drawing.Point(100, 630);
            this.txtNote1.Multiline = true;
            this.txtNote1.Name = "txtNote1";
            this.txtNote1.Padding = new Smobiler.Core.Controls.Padding(0F, 5F, 5F, 0F);
            this.txtNote1.ReadOnly = true;
            this.txtNote1.Size = new System.Drawing.Size(200, 55);
            this.txtNote1.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // label48
            // 
            this.label48.BackColor = System.Drawing.Color.White;
            this.label48.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label48.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label48.Location = new System.Drawing.Point(0, 510);
            this.label48.Name = "label48";
            this.label48.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label48.Size = new System.Drawing.Size(100, 40);
            this.label48.Text = "过期时间";
            // 
            // txtAssId1
            // 
            this.txtAssId1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtAssId1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtAssId1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtAssId1.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtAssId1.Location = new System.Drawing.Point(100, 0);
            this.txtAssId1.Name = "txtAssId1";
            this.txtAssId1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtAssId1.ReadOnly = true;
            this.txtAssId1.Size = new System.Drawing.Size(200, 40);
            this.txtAssId1.WaterMarkText = "(必填)";
            this.txtAssId1.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // label49
            // 
            this.label49.BackColor = System.Drawing.Color.White;
            this.label49.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label49.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label49.Location = new System.Drawing.Point(0, 350);
            this.label49.Name = "label49";
            this.label49.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label49.Size = new System.Drawing.Size(100, 40);
            this.label49.Text = "地点";
            // 
            // txtPlace1
            // 
            this.txtPlace1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtPlace1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtPlace1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtPlace1.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtPlace1.Location = new System.Drawing.Point(100, 350);
            this.txtPlace1.Name = "txtPlace1";
            this.txtPlace1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtPlace1.ReadOnly = true;
            this.txtPlace1.Size = new System.Drawing.Size(199, 40);
            this.txtPlace1.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // label50
            // 
            this.label50.BackColor = System.Drawing.Color.White;
            this.label50.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label50.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label50.Location = new System.Drawing.Point(0, 550);
            this.label50.Name = "label50";
            this.label50.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label50.Size = new System.Drawing.Size(100, 40);
            this.label50.Text = "供应商";
            // 
            // txtVendor1
            // 
            this.txtVendor1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtVendor1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtVendor1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtVendor1.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtVendor1.Location = new System.Drawing.Point(100, 550);
            this.txtVendor1.Name = "txtVendor1";
            this.txtVendor1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtVendor1.ReadOnly = true;
            this.txtVendor1.Size = new System.Drawing.Size(199, 40);
            this.txtVendor1.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // label51
            // 
            this.label51.BackColor = System.Drawing.Color.White;
            this.label51.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label51.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label51.Location = new System.Drawing.Point(0, 590);
            this.label51.Name = "label51";
            this.label51.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label51.Size = new System.Drawing.Size(100, 40);
            this.label51.Text = "管理者";
            // 
            // txtType
            // 
            this.txtType.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtType.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtType.Location = new System.Drawing.Point(100, 215);
            this.txtType.Name = "txtType";
            this.txtType.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(200, 40);
            // 
            // txtSL
            // 
            this.txtSL.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtSL.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtSL.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtSL.Location = new System.Drawing.Point(100, 310);
            this.txtSL.Name = "txtSL";
            this.txtSL.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtSL.ReadOnly = true;
            this.txtSL.Size = new System.Drawing.Size(200, 40);
            // 
            // txtManager
            // 
            this.txtManager.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtManager.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtManager.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtManager.Location = new System.Drawing.Point(100, 590);
            this.txtManager.Name = "txtManager";
            this.txtManager.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtManager.ReadOnly = true;
            this.txtManager.Size = new System.Drawing.Size(200, 40);
            // 
            // txtBuyDate
            // 
            this.txtBuyDate.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtBuyDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtBuyDate.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtBuyDate.Location = new System.Drawing.Point(100, 470);
            this.txtBuyDate.Name = "txtBuyDate";
            this.txtBuyDate.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtBuyDate.ReadOnly = true;
            this.txtBuyDate.Size = new System.Drawing.Size(200, 40);
            // 
            // txtEDate
            // 
            this.txtEDate.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtEDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtEDate.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtEDate.Location = new System.Drawing.Point(100, 510);
            this.txtEDate.Name = "txtEDate";
            this.txtEDate.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtEDate.ReadOnly = true;
            this.txtEDate.Size = new System.Drawing.Size(200, 40);
            // 
            // popCurrentUser
            // 
            this.popCurrentUser.Name = "popCurrentUser";
            // 
            // posPrinter1
            // 
            this.posPrinter1.Name = "posPrinter1";
            // 
            // frmAssetsDetail
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.popCurrentUser,
            this.posPrinter1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Title1,
            this.plButton,
            this.plContent});
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229))))));
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmAssetsDetail_KeyDown);
            this.Load += new System.EventHandler(this.frmAssetsDetail_Load);
            this.Name = "frmAssetsDetail";

        }

        #endregion

        private Title Title1;
        internal Smobiler.Core.Controls.Panel plButton;
        private Smobiler.Core.Controls.Button btnPrint;
        internal Smobiler.Core.Controls.Button btnEdit;
        internal Smobiler.Core.Controls.Button btnLog;
        internal Smobiler.Core.Controls.Panel plContent;
        internal Smobiler.Core.Controls.Label label35;
        internal Smobiler.Core.Controls.Label label36;
        internal Smobiler.Core.Controls.Label label37;
        internal Smobiler.Core.Controls.Label label38;
        internal Smobiler.Core.Controls.Label label39;
        internal Smobiler.Core.Controls.Label label40;
        internal Smobiler.Core.Controls.Label label41;
        internal Smobiler.Core.Controls.Label label42;
        internal Smobiler.Core.Controls.Label label43;
        internal Smobiler.Core.Controls.Label label44;
        internal Smobiler.Core.Controls.Label label45;
        internal Smobiler.Core.Controls.Label label46;
        internal Smobiler.Core.Controls.TextBox txtName1;
        internal Smobiler.Core.Controls.TextBox txtSPE1;
        internal Smobiler.Core.Controls.TextBox txtATID;
        internal Smobiler.Core.Controls.TextBox txtUnit1;
        internal Smobiler.Core.Controls.TextBox txtSN1;
        internal Smobiler.Core.Controls.TextBox txtPrice1;
        internal Smobiler.Core.Controls.Panel panel6;
        internal Smobiler.Core.Controls.Image image2;
        internal Smobiler.Core.Controls.Label label47;
        internal Smobiler.Core.Controls.TextBox txtNote1;
        internal Smobiler.Core.Controls.Label label48;
        internal Smobiler.Core.Controls.TextBox txtAssId1;
        internal Smobiler.Core.Controls.Label label49;
        internal Smobiler.Core.Controls.TextBox txtPlace1;
        internal Smobiler.Core.Controls.Label label50;
        internal Smobiler.Core.Controls.TextBox txtVendor1;
        internal Smobiler.Core.Controls.Label label51;
        private Smobiler.Core.Controls.TextBox txtType;
        private Smobiler.Core.Controls.TextBox txtSL;
        internal Smobiler.Core.Controls.TextBox txtManager;
        private Smobiler.Core.Controls.TextBox txtBuyDate;
        private Smobiler.Core.Controls.TextBox txtEDate;
        private Smobiler.Core.Controls.PopList popCurrentUser;
        private Smobiler.Device.PosPrinter posPrinter1;
    }
}