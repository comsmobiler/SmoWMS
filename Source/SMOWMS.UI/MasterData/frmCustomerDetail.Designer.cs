using System;
using Smobiler.Core;
namespace SMOWMS.UI.MasterData
{
    partial class frmCustomerDetail : Smobiler.Core.Controls.MobileForm
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
            this.plButton = new Smobiler.Core.Controls.Panel();
            this.btnEdit = new Smobiler.Core.Controls.Button();
            this.btnDelete = new Smobiler.Core.Controls.Button();
            this.plContent = new Smobiler.Core.Controls.Panel();
            this.plName = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.lblName = new Smobiler.Core.Controls.Label();
            this.plContacts = new Smobiler.Core.Controls.Panel();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.lblContacts = new Smobiler.Core.Controls.Label();
            this.plPhone = new Smobiler.Core.Controls.Panel();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.lblPhone = new Smobiler.Core.Controls.Label();
            this.plAddress = new Smobiler.Core.Controls.Panel();
            this.label10 = new Smobiler.Core.Controls.Label();
            this.lblAddress = new Smobiler.Core.Controls.Label();
            this.plFax = new Smobiler.Core.Controls.Panel();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.lblFax = new Smobiler.Core.Controls.Label();
            this.plEmail = new Smobiler.Core.Controls.Panel();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.lblEmail = new Smobiler.Core.Controls.Label();
            this.plTaxNumber = new Smobiler.Core.Controls.Panel();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.lblTaxNumber = new Smobiler.Core.Controls.Label();
            this.plBank = new Smobiler.Core.Controls.Panel();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.lblBank = new Smobiler.Core.Controls.Label();
            this.plAccount = new Smobiler.Core.Controls.Panel();
            this.label8 = new Smobiler.Core.Controls.Label();
            this.lblAccount = new Smobiler.Core.Controls.Label();
            this.plNote = new Smobiler.Core.Controls.Panel();
            this.label9 = new Smobiler.Core.Controls.Label();
            this.lblNote = new Smobiler.Core.Controls.Label();
            this.title1 = new SMOWMS.UI.UserControl.Title();
            // 
            // plButton
            // 
            this.plButton.BackColor = System.Drawing.Color.White;
            this.plButton.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.plButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plButton.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnEdit,
            this.btnDelete});
            this.plButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plButton.Location = new System.Drawing.Point(0, 468);
            this.plButton.Name = "plButton";
            this.plButton.Size = new System.Drawing.Size(300, 40);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(35, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 30);
            this.btnEdit.Text = "编辑";
            this.btnEdit.Press += new System.EventHandler(this.btnEdit_Press);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(170, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.Text = "删除";
            this.btnDelete.Press += new System.EventHandler(this.btnDelete_Press);
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
            this.lblName});
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
            // lblName
            // 
            this.lblName.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblName.Location = new System.Drawing.Point(100, 0);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.lblName.Size = new System.Drawing.Size(200, 35);
            // 
            // plContacts
            // 
            this.plContacts.BackColor = System.Drawing.Color.White;
            this.plContacts.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.plContacts.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plContacts.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label4,
            this.lblContacts});
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
            // lblContacts
            // 
            this.lblContacts.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblContacts.Location = new System.Drawing.Point(100, 0);
            this.lblContacts.Name = "lblContacts";
            this.lblContacts.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.lblContacts.Size = new System.Drawing.Size(200, 35);
            // 
            // plPhone
            // 
            this.plPhone.BackColor = System.Drawing.Color.White;
            this.plPhone.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plPhone.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label5,
            this.lblPhone});
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
            // lblPhone
            // 
            this.lblPhone.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblPhone.Location = new System.Drawing.Point(100, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.lblPhone.Size = new System.Drawing.Size(200, 35);
            // 
            // plAddress
            // 
            this.plAddress.BackColor = System.Drawing.Color.White;
            this.plAddress.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plAddress.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label10,
            this.lblAddress});
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
            // lblAddress
            // 
            this.lblAddress.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblAddress.Location = new System.Drawing.Point(100, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.lblAddress.Size = new System.Drawing.Size(200, 35);
            // 
            // plFax
            // 
            this.plFax.BackColor = System.Drawing.Color.White;
            this.plFax.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plFax.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plFax.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label2,
            this.lblFax});
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
            // lblFax
            // 
            this.lblFax.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblFax.Location = new System.Drawing.Point(100, 0);
            this.lblFax.Name = "lblFax";
            this.lblFax.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.lblFax.Size = new System.Drawing.Size(200, 35);
            // 
            // plEmail
            // 
            this.plEmail.BackColor = System.Drawing.Color.White;
            this.plEmail.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plEmail.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label3,
            this.lblEmail});
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
            // lblEmail
            // 
            this.lblEmail.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblEmail.Location = new System.Drawing.Point(100, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.lblEmail.Size = new System.Drawing.Size(200, 35);
            // 
            // plTaxNumber
            // 
            this.plTaxNumber.BackColor = System.Drawing.Color.White;
            this.plTaxNumber.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plTaxNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plTaxNumber.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label6,
            this.lblTaxNumber});
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
            // lblTaxNumber
            // 
            this.lblTaxNumber.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblTaxNumber.Location = new System.Drawing.Point(100, 0);
            this.lblTaxNumber.Name = "lblTaxNumber";
            this.lblTaxNumber.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.lblTaxNumber.Size = new System.Drawing.Size(200, 35);
            // 
            // plBank
            // 
            this.plBank.BackColor = System.Drawing.Color.White;
            this.plBank.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plBank.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plBank.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label7,
            this.lblBank});
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
            // lblBank
            // 
            this.lblBank.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblBank.Location = new System.Drawing.Point(100, 0);
            this.lblBank.Name = "lblBank";
            this.lblBank.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.lblBank.Size = new System.Drawing.Size(200, 35);
            // 
            // plAccount
            // 
            this.plAccount.BackColor = System.Drawing.Color.White;
            this.plAccount.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plAccount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plAccount.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label8,
            this.lblAccount});
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
            // lblAccount
            // 
            this.lblAccount.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblAccount.Location = new System.Drawing.Point(100, 0);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.lblAccount.Size = new System.Drawing.Size(200, 35);
            // 
            // plNote
            // 
            this.plNote.BackColor = System.Drawing.Color.White;
            this.plNote.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label9,
            this.lblNote});
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
            // lblNote
            // 
            this.lblNote.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblNote.Location = new System.Drawing.Point(100, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.lblNote.Size = new System.Drawing.Size(200, 70);
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
            this.title1.TitleText = "客户详情";
            // 
            // frmCustomerDetail
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.plButton,
            this.plContent});
            this.Load += new System.EventHandler(this.frmCustomerDetail_Load);
            this.Name = "frmCustomerDetail";

        }
        #endregion

        private UserControl.Title title1;
        internal Smobiler.Core.Controls.Panel plButton;
        internal Smobiler.Core.Controls.Button btnEdit;
        private Smobiler.Core.Controls.Panel plContent;
        private Smobiler.Core.Controls.Panel plName;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label lblName;
        private Smobiler.Core.Controls.Panel plContacts;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.Label lblContacts;
        private Smobiler.Core.Controls.Panel plPhone;
        private Smobiler.Core.Controls.Label label5;
        private Smobiler.Core.Controls.Label lblPhone;
        private Smobiler.Core.Controls.Panel plAddress;
        private Smobiler.Core.Controls.Label label10;
        private Smobiler.Core.Controls.Label lblAddress;
        private Smobiler.Core.Controls.Panel plFax;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label lblFax;
        private Smobiler.Core.Controls.Panel plEmail;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Label lblEmail;
        private Smobiler.Core.Controls.Panel plTaxNumber;
        private Smobiler.Core.Controls.Label label6;
        private Smobiler.Core.Controls.Label lblTaxNumber;
        private Smobiler.Core.Controls.Panel plBank;
        private Smobiler.Core.Controls.Label label7;
        private Smobiler.Core.Controls.Label lblBank;
        private Smobiler.Core.Controls.Panel plAccount;
        private Smobiler.Core.Controls.Label label8;
        private Smobiler.Core.Controls.Label lblAccount;
        private Smobiler.Core.Controls.Panel plNote;
        private Smobiler.Core.Controls.Label label9;
        private Smobiler.Core.Controls.Label lblNote;
        internal Smobiler.Core.Controls.Button btnDelete;
    }
}