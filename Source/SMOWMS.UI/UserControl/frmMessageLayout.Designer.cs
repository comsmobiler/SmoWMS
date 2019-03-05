using System;
using Smobiler.Core;
namespace SMOWMS.UI.UserControl
{
    partial class frmMessageLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        //SmobilerUserControl overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        //NOTE: The following procedure is required by the SmobilerUserControl
        //It can be modified using the SmobilerUserControl.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.lblTitle = new Smobiler.Core.Controls.Label();
            this.spContent = new Smobiler.Core.Controls.Panel();
            this.plImage = new Smobiler.Core.Controls.Panel();
            this.imgUser = new Smobiler.Core.Controls.ImageButton();
            this.lblName = new Smobiler.Core.Controls.Label();
            this.imgEdit = new Smobiler.Core.Controls.ImageButton();
            this.plSex = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.btnSex = new Smobiler.Core.Controls.Button();
            this.plAddress = new Smobiler.Core.Controls.Panel();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.txtAddress = new Smobiler.Core.Controls.TextBox();
            this.plBirthday = new Smobiler.Core.Controls.Panel();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.dpkBirthday = new Smobiler.Core.Controls.DatePicker();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.plUser = new Smobiler.Core.Controls.Panel();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.lblID = new Smobiler.Core.Controls.Label();
            this.plTel = new Smobiler.Core.Controls.Panel();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.lblPhone = new Smobiler.Core.Controls.Label();
            this.plEmail = new Smobiler.Core.Controls.Panel();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.lblEmail = new Smobiler.Core.Controls.Label();
            this.btnMessage = new Smobiler.Core.Controls.Button();
            this.btnExit = new Smobiler.Core.Controls.Button();
            this.Camera1 = new Smobiler.Core.Controls.Camera();
            this.popSex = new Smobiler.Core.Controls.PopList();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.FontSize = 15F;
            this.lblTitle.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lblTitle.Location = new System.Drawing.Point(107, 51);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(100, 40);
            this.lblTitle.Text = "个人信息";
            // 
            // spContent
            // 
            this.spContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.spContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plImage,
            this.plSex,
            this.plAddress,
            this.plBirthday,
            this.label6,
            this.plUser,
            this.plTel,
            this.plEmail,
            this.btnMessage,
            this.btnExit});
            this.spContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spContent.Location = new System.Drawing.Point(0, 180);
            this.spContent.Name = "spContent";
            this.spContent.Scrollable = true;
            this.spContent.Size = new System.Drawing.Size(300, 40);
            // 
            // plImage
            // 
            this.plImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.plImage.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imgUser,
            this.lblName,
            this.imgEdit});
            this.plImage.Name = "plImage";
            this.plImage.Size = new System.Drawing.Size(300, 140);
            // 
            // imgUser
            // 
            this.imgUser.BorderRadius = 44;
            this.imgUser.Location = new System.Drawing.Point(106, 10);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(88, 88);
            this.imgUser.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Stretch;
            this.imgUser.Press += new System.EventHandler(this.ImgUser_Press);
            // 
            // lblName
            // 
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lblName.Location = new System.Drawing.Point(106, 100);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(80, 31);
            // 
            // imgEdit
            // 
            this.imgEdit.IconColor = System.Drawing.Color.White;
            this.imgEdit.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imgEdit.Location = new System.Drawing.Point(194, 100);
            this.imgEdit.Name = "imgEdit";
            this.imgEdit.ResourceID = "pencil";
            this.imgEdit.Size = new System.Drawing.Size(25, 25);
            this.imgEdit.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Stretch;
            this.imgEdit.Press += new System.EventHandler(this.Img_Press);
            // 
            // plSex
            // 
            this.plSex.BackColor = System.Drawing.Color.White;
            this.plSex.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.plSex.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plSex.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.btnSex});
            this.plSex.Location = new System.Drawing.Point(0, 140);
            this.plSex.Name = "plSex";
            this.plSex.Size = new System.Drawing.Size(300, 35);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(106)))));
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(80, 35);
            this.label1.Text = "性别";
            // 
            // btnSex
            // 
            this.btnSex.BackColor = System.Drawing.Color.Transparent;
            this.btnSex.BorderRadius = 0;
            this.btnSex.ForeColor = System.Drawing.Color.Black;
            this.btnSex.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnSex.Location = new System.Drawing.Point(80, 0);
            this.btnSex.Name = "btnSex";
            this.btnSex.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.btnSex.Size = new System.Drawing.Size(220, 35);
            this.btnSex.Text = "男   >";
            this.btnSex.Press += new System.EventHandler(this.btnSex_Press);
            // 
            // plAddress
            // 
            this.plAddress.BackColor = System.Drawing.Color.White;
            this.plAddress.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plAddress.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label5,
            this.txtAddress});
            this.plAddress.Location = new System.Drawing.Point(0, 175);
            this.plAddress.Name = "plAddress";
            this.plAddress.Size = new System.Drawing.Size(300, 35);
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(106)))));
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.label5.Size = new System.Drawing.Size(80, 35);
            this.label5.Text = "地址";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtAddress.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtAddress.Location = new System.Drawing.Point(80, 0);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.txtAddress.Size = new System.Drawing.Size(220, 35);
            this.txtAddress.TouchLeave += new System.EventHandler(this.txtLocation_TouchLeave);
            // 
            // plBirthday
            // 
            this.plBirthday.BackColor = System.Drawing.Color.White;
            this.plBirthday.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plBirthday.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plBirthday.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label4,
            this.dpkBirthday});
            this.plBirthday.Location = new System.Drawing.Point(0, 210);
            this.plBirthday.Name = "plBirthday";
            this.plBirthday.Size = new System.Drawing.Size(300, 35);
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(106)))));
            this.label4.Name = "label4";
            this.label4.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.label4.Size = new System.Drawing.Size(80, 35);
            this.label4.Text = "出生日期";
            // 
            // dpkBirthday
            // 
            this.dpkBirthday.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.dpkBirthday.Location = new System.Drawing.Point(80, 0);
            this.dpkBirthday.Name = "dpkBirthday";
            this.dpkBirthday.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.dpkBirthday.Size = new System.Drawing.Size(220, 35);
            this.dpkBirthday.ValueChanged += new System.EventHandler(this.dpkBirthday_ValueChanged);
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(0, 245);
            this.label6.Name = "label6";
            this.label6.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.label6.Size = new System.Drawing.Size(300, 30);
            // 
            // plUser
            // 
            this.plUser.BackColor = System.Drawing.Color.White;
            this.plUser.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.plUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plUser.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label7,
            this.lblID});
            this.plUser.Location = new System.Drawing.Point(0, 275);
            this.plUser.Name = "plUser";
            this.plUser.Size = new System.Drawing.Size(300, 35);
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(106)))));
            this.label7.Name = "label7";
            this.label7.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.label7.Size = new System.Drawing.Size(80, 40);
            this.label7.Text = "账号";
            // 
            // lblID
            // 
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(145)))));
            this.lblID.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblID.Location = new System.Drawing.Point(80, 0);
            this.lblID.Name = "lblID";
            this.lblID.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.lblID.Size = new System.Drawing.Size(220, 40);
            // 
            // plTel
            // 
            this.plTel.BackColor = System.Drawing.Color.White;
            this.plTel.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plTel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plTel.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label2,
            this.lblPhone});
            this.plTel.Location = new System.Drawing.Point(0, 310);
            this.plTel.Name = "plTel";
            this.plTel.Size = new System.Drawing.Size(300, 35);
            // 
            // Label2
            // 
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(106)))));
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.Label2.Size = new System.Drawing.Size(80, 35);
            this.Label2.Text = "电话";
            // 
            // lblPhone
            // 
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(145)))));
            this.lblPhone.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblPhone.Location = new System.Drawing.Point(80, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.lblPhone.Size = new System.Drawing.Size(220, 40);
            // 
            // plEmail
            // 
            this.plEmail.BackColor = System.Drawing.Color.White;
            this.plEmail.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plEmail.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label3,
            this.lblEmail});
            this.plEmail.Location = new System.Drawing.Point(0, 345);
            this.plEmail.Name = "plEmail";
            this.plEmail.Size = new System.Drawing.Size(300, 35);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(106)))));
            this.label3.Name = "label3";
            this.label3.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.label3.Size = new System.Drawing.Size(80, 40);
            this.label3.Text = "邮箱";
            // 
            // lblEmail
            // 
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(145)))));
            this.lblEmail.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblEmail.Location = new System.Drawing.Point(80, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.lblEmail.Size = new System.Drawing.Size(220, 40);
            // 
            // btnMessage
            // 
            this.btnMessage.BackColor = System.Drawing.Color.White;
            this.btnMessage.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.btnMessage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnMessage.BorderRadius = 0;
            this.btnMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(106)))));
            this.btnMessage.Location = new System.Drawing.Point(0, 400);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(300, 40);
            this.btnMessage.Text = "修改";
            this.btnMessage.Press += new System.EventHandler(this.btnMessage_Press);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.btnExit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnExit.BorderRadius = 0;
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(0, 440);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(300, 40);
            this.btnExit.Text = "注销";
            this.btnExit.Press += new System.EventHandler(this.btnExit_Press);
            // 
            // Camera1
            // 
            this.Camera1.Name = "Camera1";
            this.Camera1.ImageCaptured += new Smobiler.Core.Controls.CameraOnlineCallBackHandler(this.Camera1_ImageCaptured);
            // 
            // popSex
            // 
            this.popSex.Name = "popSex";
            this.popSex.Selected += new System.EventHandler(this.popSex_Selected);
            // 
            // frmMessageLayout
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.Camera1,
            this.popSex});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblTitle,
            this.spContent});
            this.Load += new System.EventHandler(this.frmMessageLayout_Load);
            this.Name = "frmMessageLayout";

        }
        #endregion

        private Smobiler.Core.Controls.Label lblTitle;
        private Smobiler.Core.Controls.Panel spContent;
        internal Smobiler.Core.Controls.Panel plImage;
        internal Smobiler.Core.Controls.ImageButton imgUser;
        internal Smobiler.Core.Controls.Label lblName;
        internal Smobiler.Core.Controls.ImageButton imgEdit;
        internal Smobiler.Core.Controls.Panel plSex;
        private Smobiler.Core.Controls.Label label1;
        internal Smobiler.Core.Controls.Button btnSex;
        internal Smobiler.Core.Controls.Panel plAddress;
        private Smobiler.Core.Controls.Label label5;
        internal Smobiler.Core.Controls.TextBox txtAddress;
        internal Smobiler.Core.Controls.Panel plBirthday;
        private Smobiler.Core.Controls.Label label4;
        internal Smobiler.Core.Controls.DatePicker dpkBirthday;
        private Smobiler.Core.Controls.Label label6;
        internal Smobiler.Core.Controls.Panel plUser;
        private Smobiler.Core.Controls.Label label7;
        private Smobiler.Core.Controls.Label lblID;
        internal Smobiler.Core.Controls.Panel plTel;
        private Smobiler.Core.Controls.Label Label2;
        private Smobiler.Core.Controls.Label lblPhone;
        internal Smobiler.Core.Controls.Panel plEmail;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Label lblEmail;
        internal Smobiler.Core.Controls.Button btnMessage;
        internal Smobiler.Core.Controls.Button btnExit;
        private Smobiler.Core.Controls.Camera Camera1;
        private Smobiler.Core.Controls.PopList popSex;
    }
}