namespace SMOWMS.UI.MasterData
{
    partial class frmConsumablesCreate : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmConsumablesCreate()
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
            this.Panel2 = new Smobiler.Core.Controls.Panel();
            this.btnSave = new Smobiler.Core.Controls.Button();
            this.Panel1 = new Smobiler.Core.Controls.Panel();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.Label5 = new Smobiler.Core.Controls.Label();
            this.Label6 = new Smobiler.Core.Controls.Label();
            this.Label9 = new Smobiler.Core.Controls.Label();
            this.Label15 = new Smobiler.Core.Controls.Label();
            this.txtName = new Smobiler.Core.Controls.TextBox();
            this.txtSpe = new Smobiler.Core.Controls.TextBox();
            this.txtUnit = new Smobiler.Core.Controls.TextBox();
            this.PanelImg = new Smobiler.Core.Controls.Panel();
            this.ImgPicture = new Smobiler.Core.Controls.Image();
            this.Label17 = new Smobiler.Core.Controls.Label();
            this.txtNote = new Smobiler.Core.Controls.TextBox();
            this.txtCeiling = new Smobiler.Core.Controls.TextBox();
            this.txtFloor = new Smobiler.Core.Controls.TextBox();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.txtSPQ = new Smobiler.Core.Controls.TextBox();
            this.CamPicture = new Smobiler.Core.Controls.Camera();
            // 
            // Title1
            // 
            this.Title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.Title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title1.FontSize = 15F;
            this.Title1.ForeColor = System.Drawing.Color.White;
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(300, 40);
            this.Title1.TitleText = "耗材创建";
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.White;
            this.Panel2.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnSave});
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel2.Location = new System.Drawing.Point(0, 480);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(300, 40);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(100, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.Text = "确定";
            this.btnSave.Press += new System.EventHandler(this.btnSave_Press);
            // 
            // Panel1
            // 
            this.Panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label2,
            this.Label3,
            this.Label4,
            this.Label5,
            this.Label6,
            this.Label9,
            this.Label15,
            this.txtName,
            this.txtSpe,
            this.txtUnit,
            this.PanelImg,
            this.Label17,
            this.txtNote,
            this.txtCeiling,
            this.txtFloor,
            this.label1,
            this.txtSPQ});
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Flex = 10000;
            this.Panel1.Location = new System.Drawing.Point(0, 70);
            this.Panel1.Name = "Panel1";
            this.Panel1.Scrollable = true;
            this.Panel1.Size = new System.Drawing.Size(300, 410);
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.White;
            this.Label2.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label2.Location = new System.Drawing.Point(0, 40);
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
            this.Label4.Location = new System.Drawing.Point(0, 260);
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label4.Size = new System.Drawing.Size(100, 40);
            this.Label4.Text = "安全库存上限";
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.White;
            this.Label5.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label5.Location = new System.Drawing.Point(0, 135);
            this.Label5.Name = "Label5";
            this.Label5.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label5.Size = new System.Drawing.Size(100, 85);
            this.Label5.Text = "规格型号";
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.White;
            this.Label6.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label6.Location = new System.Drawing.Point(0, 300);
            this.Label6.Name = "Label6";
            this.Label6.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label6.Size = new System.Drawing.Size(100, 40);
            this.Label6.Text = "安全库存下限";
            // 
            // Label9
            // 
            this.Label9.BackColor = System.Drawing.Color.White;
            this.Label9.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label9.Location = new System.Drawing.Point(0, 95);
            this.Label9.Name = "Label9";
            this.Label9.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label9.Size = new System.Drawing.Size(100, 40);
            this.Label9.Text = "单位";
            // 
            // Label15
            // 
            this.Label15.BackColor = System.Drawing.Color.White;
            this.Label15.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label15.Location = new System.Drawing.Point(99, 40);
            this.Label15.Name = "Label15";
            this.Label15.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label15.Size = new System.Drawing.Size(200, 55);
            // 
            // txtName
            // 
            this.txtName.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtName.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtName.Location = new System.Drawing.Point(100, 0);
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
            this.txtSpe.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtSpe.Location = new System.Drawing.Point(100, 135);
            this.txtSpe.Multiline = true;
            this.txtSpe.Name = "txtSpe";
            this.txtSpe.Padding = new Smobiler.Core.Controls.Padding(0F, 5F, 5F, 0F);
            this.txtSpe.Size = new System.Drawing.Size(199, 85);
            this.txtSpe.WaterMarkText = "(选填)";
            this.txtSpe.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // txtUnit
            // 
            this.txtUnit.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtUnit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtUnit.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtUnit.Location = new System.Drawing.Point(100, 95);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtUnit.Size = new System.Drawing.Size(199, 40);
            this.txtUnit.WaterMarkText = "(选填)";
            this.txtUnit.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // PanelImg
            // 
            this.PanelImg.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.ImgPicture});
            this.PanelImg.Location = new System.Drawing.Point(260, 52);
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
            this.Label17.Location = new System.Drawing.Point(0, 340);
            this.Label17.Name = "Label17";
            this.Label17.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label17.Size = new System.Drawing.Size(100, 80);
            this.Label17.Text = "备注";
            // 
            // txtNote
            // 
            this.txtNote.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtNote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtNote.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtNote.Location = new System.Drawing.Point(100, 340);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Padding = new Smobiler.Core.Controls.Padding(0F, 5F, 5F, 0F);
            this.txtNote.Size = new System.Drawing.Size(200, 80);
            this.txtNote.WaterMarkText = "(选填)";
            this.txtNote.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // txtCeiling
            // 
            this.txtCeiling.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtCeiling.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtCeiling.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtCeiling.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtCeiling.Location = new System.Drawing.Point(100, 260);
            this.txtCeiling.Name = "txtCeiling";
            this.txtCeiling.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtCeiling.Size = new System.Drawing.Size(199, 40);
            this.txtCeiling.WaterMarkText = "(选填)";
            this.txtCeiling.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // txtFloor
            // 
            this.txtFloor.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtFloor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtFloor.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtFloor.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtFloor.Location = new System.Drawing.Point(100, 300);
            this.txtFloor.Name = "txtFloor";
            this.txtFloor.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtFloor.Size = new System.Drawing.Size(199, 40);
            this.txtFloor.WaterMarkText = "(选填)";
            this.txtFloor.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label1.Location = new System.Drawing.Point(0, 220);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(100, 40);
            this.label1.Text = "标准包装数量";
            // 
            // txtSPQ
            // 
            this.txtSPQ.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtSPQ.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtSPQ.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtSPQ.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtSPQ.Location = new System.Drawing.Point(100, 220);
            this.txtSPQ.Name = "txtSPQ";
            this.txtSPQ.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtSPQ.Size = new System.Drawing.Size(199, 40);
            this.txtSPQ.WaterMarkText = "(选填)";
            this.txtSPQ.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // CamPicture
            // 
            this.CamPicture.Name = "CamPicture";
            this.CamPicture.ImageCaptured += new Smobiler.Core.Controls.CameraOnlineCallBackHandler(this.CamPicture_ImageCaptured);
            // 
            // frmConsumablesCreate
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.CamPicture});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Title1,
            this.Panel2,
            this.Panel1});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229))))));
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmConsumablesCreate_KeyDown);
            this.Load += new System.EventHandler(this.frmConsumablesCreate_Load);
            this.Name = "frmConsumablesCreate";

        }
        #endregion

        private UserControl.Title Title1;
        internal Smobiler.Core.Controls.Panel Panel2;
        internal Smobiler.Core.Controls.Button btnSave;
        internal Smobiler.Core.Controls.Panel Panel1;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.Label Label5;
        internal Smobiler.Core.Controls.Label Label6;
        internal Smobiler.Core.Controls.Label Label9;
        internal Smobiler.Core.Controls.Label Label15;
        internal Smobiler.Core.Controls.TextBox txtName;
        internal Smobiler.Core.Controls.TextBox txtSpe;
        internal Smobiler.Core.Controls.TextBox txtUnit;
        internal Smobiler.Core.Controls.Panel PanelImg;
        internal Smobiler.Core.Controls.Image ImgPicture;
        internal Smobiler.Core.Controls.Label Label17;
        internal Smobiler.Core.Controls.TextBox txtNote;
        internal Smobiler.Core.Controls.TextBox txtCeiling;
        internal Smobiler.Core.Controls.TextBox txtFloor;
        private Smobiler.Core.Controls.Camera CamPicture;
        internal Smobiler.Core.Controls.Label label1;
        internal Smobiler.Core.Controls.TextBox txtSPQ;
    }
}