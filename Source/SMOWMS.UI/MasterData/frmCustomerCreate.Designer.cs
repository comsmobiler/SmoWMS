using System;
using Smobiler.Core;
namespace SMOWMS.UI.MasterData
{
    partial class frmCustomerCreate : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

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
            this.plContent = new Smobiler.Core.Controls.Panel();
            this.plName = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.txtName = new Smobiler.Core.Controls.TextBox();
            this.plContacts = new Smobiler.Core.Controls.Panel();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.txtContacts = new Smobiler.Core.Controls.TextBox();
            this.plPhone = new Smobiler.Core.Controls.Panel();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.txtPhone = new Smobiler.Core.Controls.TextBox();
            this.plAddress = new Smobiler.Core.Controls.Panel();
            this.label10 = new Smobiler.Core.Controls.Label();
            this.txtAddress = new Smobiler.Core.Controls.TextBox();
            this.plFax = new Smobiler.Core.Controls.Panel();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.txtFax = new Smobiler.Core.Controls.TextBox();
            this.plEmail = new Smobiler.Core.Controls.Panel();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.txtEmail = new Smobiler.Core.Controls.TextBox();
            this.plTaxNumber = new Smobiler.Core.Controls.Panel();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.txtTaxNumber = new Smobiler.Core.Controls.TextBox();
            this.plBank = new Smobiler.Core.Controls.Panel();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.txtBank = new Smobiler.Core.Controls.TextBox();
            this.plAccount = new Smobiler.Core.Controls.Panel();
            this.label8 = new Smobiler.Core.Controls.Label();
            this.txtAccount = new Smobiler.Core.Controls.TextBox();
            this.plNote = new Smobiler.Core.Controls.Panel();
            this.label9 = new Smobiler.Core.Controls.Label();
            this.txtNote = new Smobiler.Core.Controls.TextBox();
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.FontSize = 15F;
            this.title1.ForeColor = System.Drawing.Color.White;
            this.title1.Location = new System.Drawing.Point(30, 89);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 40);
            this.title1.TitleText = "客户创建";
            // 
            // plButton
            // 
            this.plButton.BackColor = System.Drawing.Color.White;
            this.plButton.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.plButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plButton.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnSave});
            this.plButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plButton.Location = new System.Drawing.Point(0, 468);
            this.plButton.Name = "plButton";
            this.plButton.Size = new System.Drawing.Size(300, 40);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(56, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(176, 30);
            this.btnSave.Text = "确定";
            this.btnSave.Press += new System.EventHandler(this.btnSave_Press);
            // 
            // plContent
            // 
            this.plContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plName,
            this.plContacts,
            this.plPhone,
            this.plAddress,
            this.plFax,
            this.plEmail,
            this.plTaxNumber,
            this.plBank,
            this.plAccount,
            this.plNote});
            this.plContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plContent.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.plContent.Location = new System.Drawing.Point(0, 40);
            this.plContent.Name = "plContent";
            this.plContent.Size = new System.Drawing.Size(300, 100);
            // 
            // plName
            // 
            this.plName.BackColor = System.Drawing.Color.White;
            this.plName.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.txtName});
            this.plName.Name = "plName";
            this.plName.Size = new System.Drawing.Size(300, 35);
            // 
            // label1
            // 
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(100, 35);
            this.label1.Text = "单位名称";
            // 
            // txtName
            // 
            this.txtName.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtName.Location = new System.Drawing.Point(100, 0);
            this.txtName.Name = "txtName";
            this.txtName.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.txtName.Size = new System.Drawing.Size(200, 35);
            // 
            // plContacts
            // 
            this.plContacts.BackColor = System.Drawing.Color.White;
            this.plContacts.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.plContacts.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plContacts.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label4,
            this.txtContacts});
            this.plContacts.Name = "plContacts";
            this.plContacts.Size = new System.Drawing.Size(300, 35);
            // 
            // label4
            // 
            this.label4.Name = "label4";
            this.label4.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label4.Size = new System.Drawing.Size(100, 35);
            this.label4.Text = "联系人";
            // 
            // txtContacts
            // 
            this.txtContacts.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtContacts.Location = new System.Drawing.Point(100, 0);
            this.txtContacts.Name = "txtContacts";
            this.txtContacts.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.txtContacts.Size = new System.Drawing.Size(200, 35);
            // 
            // plPhone
            // 
            this.plPhone.BackColor = System.Drawing.Color.White;
            this.plPhone.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plPhone.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label5,
            this.txtPhone});
            this.plPhone.Name = "plPhone";
            this.plPhone.Size = new System.Drawing.Size(300, 35);
            // 
            // label5
            // 
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label5.Size = new System.Drawing.Size(100, 35);
            this.label5.Text = "电话";
            // 
            // txtPhone
            // 
            this.txtPhone.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtPhone.Location = new System.Drawing.Point(100, 0);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.txtPhone.Size = new System.Drawing.Size(200, 35);
            // 
            // plAddress
            // 
            this.plAddress.BackColor = System.Drawing.Color.White;
            this.plAddress.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plAddress.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label10,
            this.txtAddress});
            this.plAddress.Name = "plAddress";
            this.plAddress.Size = new System.Drawing.Size(300, 35);
            // 
            // label10
            // 
            this.label10.Name = "label10";
            this.label10.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label10.Size = new System.Drawing.Size(100, 35);
            this.label10.Text = "地址";
            // 
            // txtAddress
            // 
            this.txtAddress.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtAddress.Location = new System.Drawing.Point(100, 0);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.txtAddress.Size = new System.Drawing.Size(200, 35);
            // 
            // plFax
            // 
            this.plFax.BackColor = System.Drawing.Color.White;
            this.plFax.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plFax.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plFax.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label2,
            this.txtFax});
            this.plFax.Name = "plFax";
            this.plFax.Size = new System.Drawing.Size(300, 35);
            // 
            // label2
            // 
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label2.Size = new System.Drawing.Size(100, 35);
            this.label2.Text = "传真";
            // 
            // txtFax
            // 
            this.txtFax.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtFax.Location = new System.Drawing.Point(100, 0);
            this.txtFax.Name = "txtFax";
            this.txtFax.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.txtFax.Size = new System.Drawing.Size(200, 35);
            // 
            // plEmail
            // 
            this.plEmail.BackColor = System.Drawing.Color.White;
            this.plEmail.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plEmail.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label3,
            this.txtEmail});
            this.plEmail.Name = "plEmail";
            this.plEmail.Size = new System.Drawing.Size(300, 35);
            // 
            // label3
            // 
            this.label3.Name = "label3";
            this.label3.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label3.Size = new System.Drawing.Size(100, 35);
            this.label3.Text = "邮箱";
            // 
            // txtEmail
            // 
            this.txtEmail.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtEmail.Location = new System.Drawing.Point(100, 0);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.txtEmail.Size = new System.Drawing.Size(200, 35);
            // 
            // plTaxNumber
            // 
            this.plTaxNumber.BackColor = System.Drawing.Color.White;
            this.plTaxNumber.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plTaxNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plTaxNumber.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label6,
            this.txtTaxNumber});
            this.plTaxNumber.Name = "plTaxNumber";
            this.plTaxNumber.Size = new System.Drawing.Size(300, 35);
            // 
            // label6
            // 
            this.label6.Name = "label6";
            this.label6.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label6.Size = new System.Drawing.Size(100, 35);
            this.label6.Text = "税号";
            // 
            // txtTaxNumber
            // 
            this.txtTaxNumber.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtTaxNumber.Location = new System.Drawing.Point(100, 0);
            this.txtTaxNumber.Name = "txtTaxNumber";
            this.txtTaxNumber.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.txtTaxNumber.Size = new System.Drawing.Size(200, 35);
            // 
            // plBank
            // 
            this.plBank.BackColor = System.Drawing.Color.White;
            this.plBank.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plBank.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plBank.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label7,
            this.txtBank});
            this.plBank.Name = "plBank";
            this.plBank.Size = new System.Drawing.Size(300, 35);
            // 
            // label7
            // 
            this.label7.Name = "label7";
            this.label7.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label7.Size = new System.Drawing.Size(100, 35);
            this.label7.Text = "开户银行";
            // 
            // txtBank
            // 
            this.txtBank.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtBank.Location = new System.Drawing.Point(100, 0);
            this.txtBank.Name = "txtBank";
            this.txtBank.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.txtBank.Size = new System.Drawing.Size(200, 35);
            // 
            // plAccount
            // 
            this.plAccount.BackColor = System.Drawing.Color.White;
            this.plAccount.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plAccount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plAccount.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label8,
            this.txtAccount});
            this.plAccount.Name = "plAccount";
            this.plAccount.Size = new System.Drawing.Size(300, 35);
            // 
            // label8
            // 
            this.label8.Name = "label8";
            this.label8.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label8.Size = new System.Drawing.Size(100, 35);
            this.label8.Text = "账户";
            // 
            // txtAccount
            // 
            this.txtAccount.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtAccount.Location = new System.Drawing.Point(100, 0);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.txtAccount.Size = new System.Drawing.Size(200, 35);
            // 
            // plNote
            // 
            this.plNote.BackColor = System.Drawing.Color.White;
            this.plNote.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label9,
            this.txtNote});
            this.plNote.Name = "plNote";
            this.plNote.Size = new System.Drawing.Size(300, 70);
            // 
            // label9
            // 
            this.label9.Name = "label9";
            this.label9.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label9.Size = new System.Drawing.Size(100, 70);
            this.label9.Text = "备注";
            // 
            // txtNote
            // 
            this.txtNote.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtNote.Location = new System.Drawing.Point(100, 0);
            this.txtNote.Name = "txtNote";
            this.txtNote.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.txtNote.Size = new System.Drawing.Size(200, 70);
            // 
            // frmCustomerCreate
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.plButton,
            this.plContent});
            this.Load += new System.EventHandler(this.frmCustomerCreate_Load);
            this.Name = "frmCustomerCreate";

        }
        #endregion

        private UserControl.Title title1;
        internal Smobiler.Core.Controls.Panel plButton;
        internal Smobiler.Core.Controls.Button btnSave;
        private Smobiler.Core.Controls.Panel plContent;
        private Smobiler.Core.Controls.Panel plName;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.TextBox txtName;
        private Smobiler.Core.Controls.Panel plContacts;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.TextBox txtContacts;
        private Smobiler.Core.Controls.Panel plPhone;
        private Smobiler.Core.Controls.Label label5;
        private Smobiler.Core.Controls.TextBox txtPhone;
        private Smobiler.Core.Controls.Panel plAddress;
        private Smobiler.Core.Controls.Label label10;
        private Smobiler.Core.Controls.TextBox txtAddress;
        private Smobiler.Core.Controls.Panel plFax;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.TextBox txtFax;
        private Smobiler.Core.Controls.Panel plEmail;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.TextBox txtEmail;
        private Smobiler.Core.Controls.Panel plTaxNumber;
        private Smobiler.Core.Controls.Label label6;
        private Smobiler.Core.Controls.TextBox txtTaxNumber;
        private Smobiler.Core.Controls.Panel plBank;
        private Smobiler.Core.Controls.Label label7;
        private Smobiler.Core.Controls.TextBox txtBank;
        private Smobiler.Core.Controls.Panel plAccount;
        private Smobiler.Core.Controls.Label label8;
        private Smobiler.Core.Controls.TextBox txtAccount;
        private Smobiler.Core.Controls.Panel plNote;
        private Smobiler.Core.Controls.Label label9;
        private Smobiler.Core.Controls.TextBox txtNote;
    }
}