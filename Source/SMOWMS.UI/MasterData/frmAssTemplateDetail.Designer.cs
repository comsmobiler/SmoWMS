using System;
using Smobiler.Core;
namespace SMOWMS.UI.MasterData
{
    partial class frmAssTemplateDetail : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAssTemplateDetail()
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
            this.btnEdit = new Smobiler.Core.Controls.Button();
            this.plContent = new Smobiler.Core.Controls.Panel();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.Label5 = new Smobiler.Core.Controls.Label();
            this.Label8 = new Smobiler.Core.Controls.Label();
            this.Label10 = new Smobiler.Core.Controls.Label();
            this.Label14 = new Smobiler.Core.Controls.Label();
            this.Label15 = new Smobiler.Core.Controls.Label();
            this.lblName = new Smobiler.Core.Controls.Label();
            this.lblSpe = new Smobiler.Core.Controls.Label();
            this.lblUnit = new Smobiler.Core.Controls.Label();
            this.lblPrice = new Smobiler.Core.Controls.Label();
            this.lblType = new Smobiler.Core.Controls.Label();
            this.PanelImg = new Smobiler.Core.Controls.Panel();
            this.ImgPicture = new Smobiler.Core.Controls.Image();
            this.Label17 = new Smobiler.Core.Controls.Label();
            this.lblNote = new Smobiler.Core.Controls.Label();
            this.lblTempID = new Smobiler.Core.Controls.Label();
            this.label13 = new Smobiler.Core.Controls.Label();
            this.lblVendor = new Smobiler.Core.Controls.Label();
            // 
            // Title1
            // 
            this.Title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.Title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title1.FontSize = 15F;
            this.Title1.ForeColor = System.Drawing.Color.White;
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(300, 40);
            this.Title1.TitleText = "资产模板详情";
            // 
            // plButton
            // 
            this.plButton.BackColor = System.Drawing.Color.White;
            this.plButton.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.plButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plButton.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnEdit});
            this.plButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plButton.Location = new System.Drawing.Point(0, 480);
            this.plButton.Name = "plButton";
            this.plButton.Size = new System.Drawing.Size(300, 40);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(100, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 30);
            this.btnEdit.Text = "修改";
            this.btnEdit.Press += new System.EventHandler(this.btnEdit_Press);
            // 
            // plContent
            // 
            this.plContent.BackColor = System.Drawing.Color.White;
            this.plContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label2,
            this.Label3,
            this.Label4,
            this.Label5,
            this.Label8,
            this.Label10,
            this.Label14,
            this.Label15,
            this.lblName,
            this.lblSpe,
            this.lblUnit,
            this.lblPrice,
            this.lblType,
            this.PanelImg,
            this.Label17,
            this.lblNote,
            this.lblTempID,
            this.label13,
            this.lblVendor});
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
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.White;
            this.Label8.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label8.Location = new System.Drawing.Point(0, 135);
            this.Label8.Name = "Label8";
            this.Label8.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label8.Size = new System.Drawing.Size(100, 40);
            this.Label8.Text = "单位";
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
            this.Label10.Text = "单价";
            // 
            // Label14
            // 
            this.Label14.BackColor = System.Drawing.Color.White;
            this.Label14.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label14.Name = "Label14";
            this.Label14.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label14.Size = new System.Drawing.Size(100, 40);
            this.Label14.Text = "模板编号";
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
            // lblName
            // 
            this.lblName.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.lblName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblName.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblName.Location = new System.Drawing.Point(100, 40);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.lblName.Size = new System.Drawing.Size(199, 40);
            // 
            // lblSpe
            // 
            this.lblSpe.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.lblSpe.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblSpe.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblSpe.Location = new System.Drawing.Point(100, 255);
            this.lblSpe.Name = "lblSpe";
            this.lblSpe.Padding = new Smobiler.Core.Controls.Padding(0F, 5F, 5F, 0F);
            this.lblSpe.Size = new System.Drawing.Size(199, 55);
            // 
            // lblUnit
            // 
            this.lblUnit.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.lblUnit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblUnit.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblUnit.Location = new System.Drawing.Point(100, 135);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.lblUnit.Size = new System.Drawing.Size(199, 40);
            // 
            // lblPrice
            // 
            this.lblPrice.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.lblPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblPrice.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblPrice.Location = new System.Drawing.Point(100, 175);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.lblPrice.Size = new System.Drawing.Size(199, 40);
            // 
            // lblType
            // 
            this.lblType.BackColor = System.Drawing.Color.White;
            this.lblType.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.lblType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblType.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblType.Location = new System.Drawing.Point(100, 215);
            this.lblType.Name = "lblType";
            this.lblType.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 2F, 0F);
            this.lblType.Size = new System.Drawing.Size(199, 40);
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
            this.Label17.Location = new System.Drawing.Point(0, 350);
            this.Label17.Name = "Label17";
            this.Label17.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label17.Size = new System.Drawing.Size(100, 55);
            this.Label17.Text = "备注";
            // 
            // lblNote
            // 
            this.lblNote.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.lblNote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblNote.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblNote.Location = new System.Drawing.Point(100, 350);
            this.lblNote.Name = "lblNote";
            this.lblNote.Padding = new Smobiler.Core.Controls.Padding(0F, 5F, 5F, 0F);
            this.lblNote.Size = new System.Drawing.Size(200, 55);
            // 
            // lblTempID
            // 
            this.lblTempID.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.lblTempID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblTempID.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblTempID.Location = new System.Drawing.Point(100, 0);
            this.lblTempID.Name = "lblTempID";
            this.lblTempID.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.lblTempID.Size = new System.Drawing.Size(199, 40);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label13.Location = new System.Drawing.Point(0, 310);
            this.label13.Name = "label13";
            this.label13.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label13.Size = new System.Drawing.Size(100, 40);
            this.label13.Text = "供应商";
            // 
            // lblVendor
            // 
            this.lblVendor.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.lblVendor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblVendor.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblVendor.Location = new System.Drawing.Point(100, 310);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.lblVendor.Size = new System.Drawing.Size(199, 40);
            // 
            // frmAssTemplateDetail
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Title1,
            this.plButton,
            this.plContent});
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229))))));
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmAssTemplateDetail_KeyDown);
            this.Load += new System.EventHandler(this.frmAssTemplateDetail_Load);
            this.Name = "frmAssTemplateDetail";

        }
        #endregion

        private UserControl.Title Title1;
        internal Smobiler.Core.Controls.Panel plButton;
        internal Smobiler.Core.Controls.Button btnEdit;
        internal Smobiler.Core.Controls.Panel plContent;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.Label Label5;
        internal Smobiler.Core.Controls.Label Label8;
        internal Smobiler.Core.Controls.Label Label10;
        internal Smobiler.Core.Controls.Label Label14;
        internal Smobiler.Core.Controls.Label Label15;
        internal Smobiler.Core.Controls.Label lblName;
        internal Smobiler.Core.Controls.Label lblSpe;
        internal Smobiler.Core.Controls.Label lblUnit;
        internal Smobiler.Core.Controls.Label lblPrice;
        internal Smobiler.Core.Controls.Label lblType;
        internal Smobiler.Core.Controls.Panel PanelImg;
        internal Smobiler.Core.Controls.Image ImgPicture;
        internal Smobiler.Core.Controls.Label Label17;
        internal Smobiler.Core.Controls.Label lblNote;
        internal Smobiler.Core.Controls.Label lblTempID;
        internal Smobiler.Core.Controls.Label label13;
        internal Smobiler.Core.Controls.Label lblVendor;
    }
}