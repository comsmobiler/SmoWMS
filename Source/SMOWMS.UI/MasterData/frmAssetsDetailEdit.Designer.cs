using SMOWMS.UI.UserControl;

namespace SMOWMS.UI.MasterData
{
    partial class frmAssetsDetailEdit : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAssetsDetailEdit()
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
            this.txtType = new Smobiler.Core.Controls.TextBox();
            this.plButton = new Smobiler.Core.Controls.Panel();
            this.Button1 = new Smobiler.Core.Controls.Button();
            this.PopType = new Smobiler.Core.Controls.PopList();
            this.CamPicture = new Smobiler.Core.Controls.Camera();
            this.plContent = new Smobiler.Core.Controls.Panel();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.Label5 = new Smobiler.Core.Controls.Label();
            this.Label6 = new Smobiler.Core.Controls.Label();
            this.Label7 = new Smobiler.Core.Controls.Label();
            this.Label8 = new Smobiler.Core.Controls.Label();
            this.Label9 = new Smobiler.Core.Controls.Label();
            this.Label10 = new Smobiler.Core.Controls.Label();
            this.Label11 = new Smobiler.Core.Controls.Label();
            this.Label14 = new Smobiler.Core.Controls.Label();
            this.Label15 = new Smobiler.Core.Controls.Label();
            this.txtName = new Smobiler.Core.Controls.TextBox();
            this.txtSpe = new Smobiler.Core.Controls.TextBox();
            this.txtATID = new Smobiler.Core.Controls.TextBox();
            this.txtUnit = new Smobiler.Core.Controls.TextBox();
            this.txtSN = new Smobiler.Core.Controls.TextBox();
            this.txtPrice = new Smobiler.Core.Controls.TextBox();
            this.DatePickerBuy = new Smobiler.Core.Controls.DatePicker();
            this.PanelImg = new Smobiler.Core.Controls.Panel();
            this.ImgPicture = new Smobiler.Core.Controls.Image();
            this.Label17 = new Smobiler.Core.Controls.Label();
            this.txtNote = new Smobiler.Core.Controls.TextBox();
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.DatePickerExpiry = new Smobiler.Core.Controls.DatePicker();
            this.txtAssID = new Smobiler.Core.Controls.TextBox();
            this.label12 = new Smobiler.Core.Controls.Label();
            this.txtPlace = new Smobiler.Core.Controls.TextBox();
            this.label13 = new Smobiler.Core.Controls.Label();
            this.txtVendor = new Smobiler.Core.Controls.TextBox();
            this.label16 = new Smobiler.Core.Controls.Label();
            this.txtSL = new Smobiler.Core.Controls.TextBox();
            this.txtManager = new Smobiler.Core.Controls.TextBox();
            this.ImgBtnForSN = new Smobiler.Core.Controls.ImageButton();
            this.r2000Scanner1 = new Smobiler.Device.R2000Scanner();
            this.barcodeScanner1 = new Smobiler.Core.Controls.BarcodeScanner();
            // 
            // Title1
            // 
            this.Title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.Title1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.txtType});
            this.Title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title1.FontSize = 15F;
            this.Title1.ForeColor = System.Drawing.Color.White;
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(300, 40);
            this.Title1.TitleText = "资产编辑";
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
            // plButton
            // 
            this.plButton.BackColor = System.Drawing.Color.White;
            this.plButton.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.plButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plButton.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Button1});
            this.plButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plButton.Location = new System.Drawing.Point(0, 40);
            this.plButton.Name = "plButton";
            this.plButton.Size = new System.Drawing.Size(300, 30);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(63, 3);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(172, 27);
            this.Button1.Text = "确定";
            this.Button1.Press += new System.EventHandler(this.Button1_Press);
            // 
            // PopType
            // 
            this.PopType.Name = "PopType";
            // 
            // CamPicture
            // 
            this.CamPicture.Name = "CamPicture";
            this.CamPicture.ImageCaptured += new Smobiler.Core.Controls.CameraOnlineCallBackHandler(this.CamPicture_ImageCaptured);
            // 
            // plContent
            // 
            this.plContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label2,
            this.Label3,
            this.Label4,
            this.Label5,
            this.Label6,
            this.Label7,
            this.Label8,
            this.Label9,
            this.Label10,
            this.Label11,
            this.Label14,
            this.Label15,
            this.txtName,
            this.txtSpe,
            this.txtATID,
            this.txtUnit,
            this.txtSN,
            this.txtPrice,
            this.DatePickerBuy,
            this.PanelImg,
            this.Label17,
            this.txtNote,
            this.Label1,
            this.DatePickerExpiry,
            this.txtAssID,
            this.label12,
            this.txtPlace,
            this.label13,
            this.txtVendor,
            this.txtType,
            this.label16,
            this.txtSL,
            this.txtManager,
            this.ImgBtnForSN});
            this.plContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plContent.Flex = 10000;
            this.plContent.Location = new System.Drawing.Point(0, 70);
            this.plContent.Name = "plContent";
            this.plContent.Scrollable = true;
            this.plContent.Size = new System.Drawing.Size(300, 410);
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.White;
            this.Label2.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label2.Location = new System.Drawing.Point(0, 80);
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label2.Size = new System.Drawing.Size(100, 55);
            this.Label2.Text = "图片";
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.White;
            this.Label3.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label3.Location = new System.Drawing.Point(0, 40);
            this.Label3.Name = "Label3";
            this.Label3.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label3.Size = new System.Drawing.Size(100, 40);
            this.Label3.Text = "名称";
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.White;
            this.Label4.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label4.Location = new System.Drawing.Point(0, 215);
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label4.Size = new System.Drawing.Size(100, 40);
            this.Label4.Text = "类别";
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.White;
            this.Label5.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label5.Location = new System.Drawing.Point(0, 255);
            this.Label5.Name = "Label5";
            this.Label5.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label5.Size = new System.Drawing.Size(100, 55);
            this.Label5.Text = "规格型号";
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.White;
            this.Label6.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label6.Location = new System.Drawing.Point(0, 310);
            this.Label6.Name = "Label6";
            this.Label6.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label6.Size = new System.Drawing.Size(100, 40);
            this.Label6.Text = "库位";
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.White;
            this.Label7.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label7.Location = new System.Drawing.Point(0, 390);
            this.Label7.Name = "Label7";
            this.Label7.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label7.Size = new System.Drawing.Size(100, 40);
            this.Label7.Text = "模板编号";
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.White;
            this.Label8.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label8.Location = new System.Drawing.Point(0, 430);
            this.Label8.Name = "Label8";
            this.Label8.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label8.Size = new System.Drawing.Size(100, 40);
            this.Label8.Text = "单位";
            // 
            // Label9
            // 
            this.Label9.BackColor = System.Drawing.Color.White;
            this.Label9.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label9.Location = new System.Drawing.Point(0, 135);
            this.Label9.Name = "Label9";
            this.Label9.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label9.Size = new System.Drawing.Size(100, 40);
            this.Label9.Text = "SN";
            // 
            // Label10
            // 
            this.Label10.BackColor = System.Drawing.Color.White;
            this.Label10.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label10.Location = new System.Drawing.Point(0, 175);
            this.Label10.Name = "Label10";
            this.Label10.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label10.Size = new System.Drawing.Size(100, 40);
            this.Label10.Text = "金额";
            // 
            // Label11
            // 
            this.Label11.BackColor = System.Drawing.Color.White;
            this.Label11.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label11.Location = new System.Drawing.Point(0, 470);
            this.Label11.Name = "Label11";
            this.Label11.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label11.Size = new System.Drawing.Size(100, 40);
            this.Label11.Text = "购入时间";
            // 
            // Label14
            // 
            this.Label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label14.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label14.Name = "Label14";
            this.Label14.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label14.Size = new System.Drawing.Size(100, 40);
            this.Label14.Text = "资产编号";
            // 
            // Label15
            // 
            this.Label15.BackColor = System.Drawing.Color.White;
            this.Label15.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.Label15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label15.Location = new System.Drawing.Point(100, 80);
            this.Label15.Name = "Label15";
            this.Label15.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label15.Size = new System.Drawing.Size(200, 55);
            // 
            // txtName
            // 
            this.txtName.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtName.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtName.Location = new System.Drawing.Point(100, 40);
            this.txtName.Name = "txtName";
            this.txtName.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtName.Size = new System.Drawing.Size(199, 40);
            this.txtName.WaterMarkText = "(必填)";
            this.txtName.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // txtSpe
            // 
            this.txtSpe.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtSpe.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtSpe.Location = new System.Drawing.Point(100, 255);
            this.txtSpe.Multiline = true;
            this.txtSpe.Name = "txtSpe";
            this.txtSpe.Padding = new Smobiler.Core.Controls.Padding(0F, 5F, 10F, 0F);
            this.txtSpe.Size = new System.Drawing.Size(199, 55);
            this.txtSpe.WaterMarkText = "(选填)";
            this.txtSpe.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // txtATID
            // 
            this.txtATID.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtATID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtATID.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtATID.Location = new System.Drawing.Point(100, 390);
            this.txtATID.Name = "txtATID";
            this.txtATID.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtATID.ReadOnly = true;
            this.txtATID.Size = new System.Drawing.Size(199, 40);
            this.txtATID.WaterMarkText = "(必填)";
            this.txtATID.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // txtUnit
            // 
            this.txtUnit.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtUnit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtUnit.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtUnit.Location = new System.Drawing.Point(100, 430);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtUnit.Size = new System.Drawing.Size(199, 40);
            this.txtUnit.WaterMarkText = "(选填)";
            this.txtUnit.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // txtSN
            // 
            this.txtSN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtSN.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtSN.Location = new System.Drawing.Point(100, 135);
            this.txtSN.Name = "txtSN";
            this.txtSN.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtSN.Size = new System.Drawing.Size(140, 40);
            this.txtSN.WaterMarkText = "(选填,支持扫码)";
            this.txtSN.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // txtPrice
            // 
            this.txtPrice.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtPrice.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtPrice.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtPrice.Location = new System.Drawing.Point(100, 175);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtPrice.Size = new System.Drawing.Size(199, 40);
            this.txtPrice.WaterMarkText = "(选填)";
            this.txtPrice.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // DatePickerBuy
            // 
            this.DatePickerBuy.BackColor = System.Drawing.Color.White;
            this.DatePickerBuy.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.DatePickerBuy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.DatePickerBuy.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.DatePickerBuy.Location = new System.Drawing.Point(100, 470);
            this.DatePickerBuy.Name = "DatePickerBuy";
            this.DatePickerBuy.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.DatePickerBuy.Size = new System.Drawing.Size(200, 40);
            // 
            // PanelImg
            // 
            this.PanelImg.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.ImgPicture});
            this.PanelImg.Location = new System.Drawing.Point(260, 92);
            this.PanelImg.Name = "PanelImg";
            this.PanelImg.Size = new System.Drawing.Size(30, 30);
            this.PanelImg.Touchable = true;
            this.PanelImg.Press += new System.EventHandler(this.PanelImg_Press);
            // 
            // ImgPicture
            // 
            this.ImgPicture.Name = "ImgPicture";
            this.ImgPicture.ResourceID = "mare";
            this.ImgPicture.Size = new System.Drawing.Size(30, 30);
            // 
            // Label17
            // 
            this.Label17.BackColor = System.Drawing.Color.White;
            this.Label17.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label17.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label17.Location = new System.Drawing.Point(0, 630);
            this.Label17.Name = "Label17";
            this.Label17.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label17.Size = new System.Drawing.Size(100, 55);
            this.Label17.Text = "备注";
            // 
            // txtNote
            // 
            this.txtNote.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtNote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtNote.Location = new System.Drawing.Point(100, 630);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Padding = new Smobiler.Core.Controls.Padding(0F, 5F, 5F, 0F);
            this.txtNote.Size = new System.Drawing.Size(200, 55);
            this.txtNote.WaterMarkText = "(选填)";
            this.txtNote.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.White;
            this.Label1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label1.Location = new System.Drawing.Point(0, 510);
            this.Label1.Name = "Label1";
            this.Label1.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label1.Size = new System.Drawing.Size(100, 40);
            this.Label1.Text = "过期时间";
            // 
            // DatePickerExpiry
            // 
            this.DatePickerExpiry.BackColor = System.Drawing.Color.White;
            this.DatePickerExpiry.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.DatePickerExpiry.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.DatePickerExpiry.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.DatePickerExpiry.Location = new System.Drawing.Point(100, 510);
            this.DatePickerExpiry.Name = "DatePickerExpiry";
            this.DatePickerExpiry.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.DatePickerExpiry.Size = new System.Drawing.Size(200, 40);
            // 
            // txtAssID
            // 
            this.txtAssID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtAssID.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtAssID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtAssID.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtAssID.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtAssID.Location = new System.Drawing.Point(100, 0);
            this.txtAssID.Name = "txtAssID";
            this.txtAssID.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtAssID.ReadOnly = true;
            this.txtAssID.Size = new System.Drawing.Size(200, 40);
            this.txtAssID.Text = "20";
            this.txtAssID.WaterMarkText = "(必填)";
            this.txtAssID.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label12.Location = new System.Drawing.Point(0, 350);
            this.label12.Name = "label12";
            this.label12.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label12.Size = new System.Drawing.Size(100, 40);
            this.label12.Text = "地点";
            // 
            // txtPlace
            // 
            this.txtPlace.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtPlace.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtPlace.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtPlace.Location = new System.Drawing.Point(100, 350);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtPlace.Size = new System.Drawing.Size(199, 40);
            this.txtPlace.WaterMarkText = "(选填)";
            this.txtPlace.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label13.Location = new System.Drawing.Point(0, 550);
            this.label13.Name = "label13";
            this.label13.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label13.Size = new System.Drawing.Size(100, 40);
            this.label13.Text = "供应商";
            // 
            // txtVendor
            // 
            this.txtVendor.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtVendor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtVendor.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtVendor.Location = new System.Drawing.Point(100, 550);
            this.txtVendor.Name = "txtVendor";
            this.txtVendor.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtVendor.Size = new System.Drawing.Size(199, 40);
            this.txtVendor.WaterMarkText = "(选填)";
            this.txtVendor.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label16.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label16.Location = new System.Drawing.Point(0, 590);
            this.label16.Name = "label16";
            this.label16.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label16.Size = new System.Drawing.Size(100, 40);
            this.label16.Text = "管理者";
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
            // ImgBtnForSN
            // 
            this.ImgBtnForSN.BackColor = System.Drawing.Color.White;
            this.ImgBtnForSN.Location = new System.Drawing.Point(260, 141);
            this.ImgBtnForSN.Name = "ImgBtnForSN";
            this.ImgBtnForSN.ResourceID = "scan";
            this.ImgBtnForSN.Size = new System.Drawing.Size(28, 28);
            this.ImgBtnForSN.Press += new System.EventHandler(this.ImgBtnForAssId_Press);
            // 
            // r2000Scanner1
            // 
            this.r2000Scanner1.Name = "r2000Scanner1";
            this.r2000Scanner1.BarcodeDataCaptured += new Smobiler.Device.R2000BarcodeScanEventHandler(this.r2000Scanner1_BarcodeDataCaptured);
            this.r2000Scanner1.RFIDDataCaptured += new Smobiler.Device.R2000RFIDScanEventHandler(this.r2000Scanner1_RFIDDataCaptured);
            // 
            // barcodeScanner1
            // 
            this.barcodeScanner1.Name = "barcodeScanner1";
            this.barcodeScanner1.BarcodeScanned += new Smobiler.Core.Controls.BarcodeScannerCallBackHandler(this.barcodeScanner1_BarcodeScanned);
            // 
            // frmAssetsDetailEdit
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.PopType,
            this.CamPicture,
            this.r2000Scanner1,
            this.barcodeScanner1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Title1,
            this.plButton,
            this.plContent});
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229))))));
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmAssetsDetailEdit_KeyDown);
            this.Load += new System.EventHandler(this.frmAssetsDetailEdit_Load);
            this.Name = "frmAssetsDetailEdit";

        }
        #endregion

        private Title Title1;
        internal Smobiler.Core.Controls.Panel plButton;
        internal Smobiler.Core.Controls.Button Button1;
        internal Smobiler.Core.Controls.PopList PopType;
        internal Smobiler.Core.Controls.Camera CamPicture;
        internal Smobiler.Core.Controls.Panel plContent;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.Label Label5;
        internal Smobiler.Core.Controls.Label Label6;
        internal Smobiler.Core.Controls.Label Label7;
        internal Smobiler.Core.Controls.Label Label8;
        internal Smobiler.Core.Controls.Label Label9;
        internal Smobiler.Core.Controls.Label Label10;
        internal Smobiler.Core.Controls.Label Label11;
        internal Smobiler.Core.Controls.Label Label14;
        internal Smobiler.Core.Controls.Label Label15;
        internal Smobiler.Core.Controls.TextBox txtName;
        internal Smobiler.Core.Controls.TextBox txtSpe;
        internal Smobiler.Core.Controls.TextBox txtATID;
        internal Smobiler.Core.Controls.TextBox txtUnit;
        internal Smobiler.Core.Controls.TextBox txtSN;
        internal Smobiler.Core.Controls.TextBox txtPrice;
        internal Smobiler.Core.Controls.DatePicker DatePickerBuy;
        internal Smobiler.Core.Controls.Panel PanelImg;
        internal Smobiler.Core.Controls.Image ImgPicture;
        internal Smobiler.Core.Controls.Label Label17;
        internal Smobiler.Core.Controls.TextBox txtNote;
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.DatePicker DatePickerExpiry;
        internal Smobiler.Core.Controls.TextBox txtAssID;
        internal Smobiler.Core.Controls.Label label12;
        internal Smobiler.Core.Controls.TextBox txtPlace;
        internal Smobiler.Core.Controls.Label label13;
        internal Smobiler.Core.Controls.TextBox txtVendor;
        internal Smobiler.Core.Controls.Label label16;
        private Smobiler.Core.Controls.TextBox txtSL;
        private Smobiler.Core.Controls.TextBox txtManager;
        private Smobiler.Device.R2000Scanner r2000Scanner1;
        private Smobiler.Core.Controls.BarcodeScanner barcodeScanner1;
        private Smobiler.Core.Controls.ImageButton ImgBtnForSN;
        private Smobiler.Core.Controls.TextBox txtType;
    }
}