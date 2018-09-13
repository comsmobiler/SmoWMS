namespace SMOWMS.UI.MasterData
{
    partial class frmConsumablesDetail : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmConsumablesDetail()
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
            this.btnQuant = new Smobiler.Core.Controls.Button();
            this.btnEdit = new Smobiler.Core.Controls.Button();
            this.btnDelete = new Smobiler.Core.Controls.Button();
            this.plContent = new Smobiler.Core.Controls.Panel();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.Label5 = new Smobiler.Core.Controls.Label();
            this.Label6 = new Smobiler.Core.Controls.Label();
            this.Label9 = new Smobiler.Core.Controls.Label();
            this.Label14 = new Smobiler.Core.Controls.Label();
            this.Label15 = new Smobiler.Core.Controls.Label();
            this.txtName = new Smobiler.Core.Controls.TextBox();
            this.txtSpe = new Smobiler.Core.Controls.TextBox();
            this.txtUnit = new Smobiler.Core.Controls.TextBox();
            this.PanelImg = new Smobiler.Core.Controls.Panel();
            this.ImgPicture = new Smobiler.Core.Controls.Image();
            this.Label17 = new Smobiler.Core.Controls.Label();
            this.txtNote = new Smobiler.Core.Controls.TextBox();
            this.txtAssID = new Smobiler.Core.Controls.TextBox();
            this.txtCeiling = new Smobiler.Core.Controls.TextBox();
            this.txtFloor = new Smobiler.Core.Controls.TextBox();
            this.txtSPQ = new Smobiler.Core.Controls.TextBox();
            this.label1 = new Smobiler.Core.Controls.Label();
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
            this.Title1.TitleText = "耗材详情";
            // 
            // plButton
            // 
            this.plButton.BackColor = System.Drawing.Color.White;
            this.plButton.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.plButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plButton.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnPrint,
            this.btnQuant,
            this.btnEdit,
            this.btnDelete});
            this.plButton.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.plButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plButton.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.plButton.Location = new System.Drawing.Point(0, 480);
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
            // btnQuant
            // 
            this.btnQuant.Flex = 1;
            this.btnQuant.Margin = new Smobiler.Core.Controls.Margin(2F, 5F, 2F, 5F);
            this.btnQuant.Name = "btnQuant";
            this.btnQuant.Size = new System.Drawing.Size(0, 0);
            this.btnQuant.Text = "库存分布";
            this.btnQuant.Press += new System.EventHandler(this.btnQuant_Press);
            // 
            // btnEdit
            // 
            this.btnEdit.Flex = 1;
            this.btnEdit.Margin = new Smobiler.Core.Controls.Margin(2F, 5F, 2F, 5F);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(0, 0);
            this.btnEdit.Text = "修改耗材";
            this.btnEdit.Press += new System.EventHandler(this.btnEdit_Press);
            // 
            // btnDelete
            // 
            this.btnDelete.Flex = 1;
            this.btnDelete.Margin = new Smobiler.Core.Controls.Margin(2F, 5F, 2F, 5F);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(0, 0);
            this.btnDelete.Text = "删除";
            this.btnDelete.Press += new System.EventHandler(this.btnDelete_Press);
            // 
            // plContent
            // 
            this.plContent.BackColor = System.Drawing.Color.White;
            this.plContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label2,
            this.Label3,
            this.Label4,
            this.Label5,
            this.Label6,
            this.Label9,
            this.Label14,
            this.Label15,
            this.txtName,
            this.txtSpe,
            this.txtUnit,
            this.PanelImg,
            this.Label17,
            this.txtNote,
            this.txtAssID,
            this.txtCeiling,
            this.txtFloor,
            this.txtSPQ,
            this.label1});
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
            this.Label5.Location = new System.Drawing.Point(0, 175);
            this.Label5.Name = "Label5";
            this.Label5.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label5.Size = new System.Drawing.Size(100, 45);
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
            this.Label9.Location = new System.Drawing.Point(0, 135);
            this.Label9.Name = "Label9";
            this.Label9.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label9.Size = new System.Drawing.Size(100, 40);
            this.Label9.Text = "单位";
            // 
            // Label14
            // 
            this.Label14.BackColor = System.Drawing.Color.White;
            this.Label14.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label14.Name = "Label14";
            this.Label14.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label14.Size = new System.Drawing.Size(100, 40);
            this.Label14.Text = "耗材编号";
            // 
            // Label15
            // 
            this.Label15.BackColor = System.Drawing.Color.White;
            this.Label15.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
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
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(199, 40);
            this.txtName.WaterMarkText = "(必填)";
            this.txtName.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // txtSpe
            // 
            this.txtSpe.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtSpe.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtSpe.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtSpe.Location = new System.Drawing.Point(100, 175);
            this.txtSpe.Multiline = true;
            this.txtSpe.Name = "txtSpe";
            this.txtSpe.Padding = new Smobiler.Core.Controls.Padding(0F, 5F, 5F, 0F);
            this.txtSpe.ReadOnly = true;
            this.txtSpe.Size = new System.Drawing.Size(199, 45);
            this.txtSpe.WaterMarkText = "(选填)";
            this.txtSpe.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // txtUnit
            // 
            this.txtUnit.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtUnit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtUnit.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtUnit.Location = new System.Drawing.Point(100, 135);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtUnit.ReadOnly = true;
            this.txtUnit.Size = new System.Drawing.Size(199, 40);
            this.txtUnit.WaterMarkText = "(选填)";
            this.txtUnit.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // PanelImg
            // 
            this.PanelImg.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.ImgPicture});
            this.PanelImg.Location = new System.Drawing.Point(260, 92);
            this.PanelImg.Name = "PanelImg";
            this.PanelImg.Size = new System.Drawing.Size(30, 30);
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
            this.txtNote.ReadOnly = true;
            this.txtNote.Size = new System.Drawing.Size(200, 80);
            this.txtNote.WaterMarkText = "(选填)";
            this.txtNote.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // txtAssID
            // 
            this.txtAssID.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtAssID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtAssID.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtAssID.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtAssID.Location = new System.Drawing.Point(100, 0);
            this.txtAssID.Name = "txtAssID";
            this.txtAssID.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtAssID.ReadOnly = true;
            this.txtAssID.Size = new System.Drawing.Size(199, 40);
            this.txtAssID.WaterMarkText = "(必填)";
            this.txtAssID.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
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
            this.txtCeiling.ReadOnly = true;
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
            this.txtFloor.ReadOnly = true;
            this.txtFloor.Size = new System.Drawing.Size(199, 40);
            this.txtFloor.WaterMarkText = "(选填)";
            this.txtFloor.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
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
            this.txtSPQ.ReadOnly = true;
            this.txtSPQ.Size = new System.Drawing.Size(199, 40);
            this.txtSPQ.WaterMarkText = "(选填)";
            this.txtSPQ.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
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
            // posPrinter1
            // 
            this.posPrinter1.Name = "posPrinter1";
            // 
            // frmConsumablesDetail
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.posPrinter1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Title1,
            this.plButton,
            this.plContent});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229))))));
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmConsumablesDetail_KeyDown);
            this.Load += new System.EventHandler(this.frmConsumablesDetail_Load);
            this.Name = "frmConsumablesDetail";

        }
        #endregion

        private UserControl.Title Title1;
        internal Smobiler.Core.Controls.Panel plButton;
        internal Smobiler.Core.Controls.Button btnQuant;
        internal Smobiler.Core.Controls.Panel plContent;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.Label Label5;
        internal Smobiler.Core.Controls.Label Label6;
        internal Smobiler.Core.Controls.Label Label9;
        internal Smobiler.Core.Controls.Label Label14;
        internal Smobiler.Core.Controls.Label Label15;
        internal Smobiler.Core.Controls.TextBox txtName;
        internal Smobiler.Core.Controls.TextBox txtSpe;
        internal Smobiler.Core.Controls.TextBox txtUnit;
        internal Smobiler.Core.Controls.Panel PanelImg;
        internal Smobiler.Core.Controls.Image ImgPicture;
        internal Smobiler.Core.Controls.Label Label17;
        internal Smobiler.Core.Controls.TextBox txtNote;
        internal Smobiler.Core.Controls.TextBox txtAssID;
        internal Smobiler.Core.Controls.TextBox txtCeiling;
        internal Smobiler.Core.Controls.TextBox txtFloor;
        internal Smobiler.Core.Controls.Button btnEdit;
        internal Smobiler.Core.Controls.TextBox txtSPQ;
        internal Smobiler.Core.Controls.Label label1;
        internal Smobiler.Core.Controls.Button btnDelete;
        private Smobiler.Core.Controls.Button btnPrint;
        private Smobiler.Device.PosPrinter posPrinter1;
    }
}