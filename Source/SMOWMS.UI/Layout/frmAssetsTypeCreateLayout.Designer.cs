using System;
using Smobiler.Core;
namespace SMOWMS.UI.Layout
{
    partial class frmAssetsTypeCreateLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public frmAssetsTypeCreateLayout()
            : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

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
            this.plContent = new Smobiler.Core.Controls.Panel();
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.plFID = new Smobiler.Core.Controls.Panel();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.txtFID = new Smobiler.Core.Controls.TextBox();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.plFName = new Smobiler.Core.Controls.Panel();
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.txtFName = new Smobiler.Core.Controls.TextBox();
            this.Label9 = new Smobiler.Core.Controls.Label();
            this.plFDate = new Smobiler.Core.Controls.Panel();
            this.Label5 = new Smobiler.Core.Controls.Label();
            this.txtFDate = new Smobiler.Core.Controls.TextBox();
            this.Label10 = new Smobiler.Core.Controls.Label();
            this.plID = new Smobiler.Core.Controls.Panel();
            this.Label15 = new Smobiler.Core.Controls.Label();
            this.Label6 = new Smobiler.Core.Controls.Label();
            this.txtID = new Smobiler.Core.Controls.TextBox();
            this.Label11 = new Smobiler.Core.Controls.Label();
            this.plName = new Smobiler.Core.Controls.Panel();
            this.Label14 = new Smobiler.Core.Controls.Label();
            this.txtName = new Smobiler.Core.Controls.TextBox();
            this.Label7 = new Smobiler.Core.Controls.Label();
            this.Label12 = new Smobiler.Core.Controls.Label();
            this.plDate = new Smobiler.Core.Controls.Panel();
            this.Label16 = new Smobiler.Core.Controls.Label();
            this.Label8 = new Smobiler.Core.Controls.Label();
            this.txtDate = new Smobiler.Core.Controls.TextBox();
            this.Label13 = new Smobiler.Core.Controls.Label();
            this.plButton = new Smobiler.Core.Controls.Panel();
            this.btnCancel = new Smobiler.Core.Controls.Button();
            this.btnSave = new Smobiler.Core.Controls.Button();
            // 
            // plContent
            // 
            this.plContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label1,
            this.plFID,
            this.plFName,
            this.plFDate,
            this.plID,
            this.plName,
            this.plDate,
            this.plButton});
            this.plContent.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.plContent.Name = "plContent";
            this.plContent.Size = new System.Drawing.Size(300, 370);
            // 
            // Label1
            // 
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(280, 35);
            this.Label1.Text = "资产类别";
            // 
            // plFID
            // 
            this.plFID.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label2,
            this.txtFID,
            this.Label3});
            this.plFID.Name = "plFID";
            this.plFID.Size = new System.Drawing.Size(300, 50);
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.White;
            this.Label2.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.Label2.Size = new System.Drawing.Size(75, 50);
            this.Label2.Text = "父类编码";
            // 
            // txtFID
            // 
            this.txtFID.Border = new Smobiler.Core.Controls.Border(1F);
            this.txtFID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.txtFID.BorderRadius = 4;
            this.txtFID.Location = new System.Drawing.Point(75, 10);
            this.txtFID.Name = "txtFID";
            this.txtFID.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.txtFID.ReadOnly = true;
            this.txtFID.Size = new System.Drawing.Size(190, 30);
            this.txtFID.WaterMarkText = "父类编码";
            this.txtFID.ZIndex = 1;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(75, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(205, 50);
            // 
            // plFName
            // 
            this.plFName.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label4,
            this.txtFName,
            this.Label9});
            this.plFName.Name = "plFName";
            this.plFName.Size = new System.Drawing.Size(300, 50);
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.White;
            this.Label4.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.Label4.Size = new System.Drawing.Size(75, 50);
            this.Label4.Text = "父类名称";
            // 
            // txtFName
            // 
            this.txtFName.Border = new Smobiler.Core.Controls.Border(1F);
            this.txtFName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.txtFName.BorderRadius = 4;
            this.txtFName.Location = new System.Drawing.Point(75, 10);
            this.txtFName.Name = "txtFName";
            this.txtFName.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.txtFName.ReadOnly = true;
            this.txtFName.Size = new System.Drawing.Size(190, 30);
            this.txtFName.WaterMarkText = "父类名称";
            this.txtFName.ZIndex = 1;
            // 
            // Label9
            // 
            this.Label9.BackColor = System.Drawing.Color.White;
            this.Label9.Location = new System.Drawing.Point(75, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(205, 50);
            // 
            // plFDate
            // 
            this.plFDate.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label5,
            this.txtFDate,
            this.Label10});
            this.plFDate.Name = "plFDate";
            this.plFDate.Size = new System.Drawing.Size(300, 50);
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.White;
            this.Label5.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.Label5.Name = "Label5";
            this.Label5.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.Label5.Size = new System.Drawing.Size(75, 50);
            this.Label5.Text = "父年限(月)";
            // 
            // txtFDate
            // 
            this.txtFDate.Border = new Smobiler.Core.Controls.Border(1F);
            this.txtFDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.txtFDate.BorderRadius = 4;
            this.txtFDate.Location = new System.Drawing.Point(75, 10);
            this.txtFDate.Name = "txtFDate";
            this.txtFDate.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.txtFDate.ReadOnly = true;
            this.txtFDate.Size = new System.Drawing.Size(190, 30);
            this.txtFDate.WaterMarkText = "父年限(月)";
            this.txtFDate.ZIndex = 1;
            // 
            // Label10
            // 
            this.Label10.BackColor = System.Drawing.Color.White;
            this.Label10.Location = new System.Drawing.Point(75, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(205, 50);
            // 
            // plID
            // 
            this.plID.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label15,
            this.Label6,
            this.txtID,
            this.Label11});
            this.plID.Name = "plID";
            this.plID.Size = new System.Drawing.Size(300, 50);
            // 
            // Label15
            // 
            this.Label15.ForeColor = System.Drawing.Color.Red;
            this.Label15.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(26, 50);
            this.Label15.Text = "*";
            this.Label15.ZIndex = 1;
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.White;
            this.Label6.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.Label6.Name = "Label6";
            this.Label6.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.Label6.Size = new System.Drawing.Size(75, 50);
            this.Label6.Text = "类别编码";
            // 
            // txtID
            // 
            this.txtID.Border = new Smobiler.Core.Controls.Border(1F);
            this.txtID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.txtID.BorderRadius = 4;
            this.txtID.Location = new System.Drawing.Point(75, 10);
            this.txtID.Name = "txtID";
            this.txtID.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.txtID.Size = new System.Drawing.Size(190, 30);
            this.txtID.WaterMarkText = "类别编码";
            this.txtID.ZIndex = 1;
            // 
            // Label11
            // 
            this.Label11.BackColor = System.Drawing.Color.White;
            this.Label11.Location = new System.Drawing.Point(75, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(205, 50);
            // 
            // plName
            // 
            this.plName.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label14,
            this.txtName,
            this.Label7,
            this.Label12});
            this.plName.Name = "plName";
            this.plName.Size = new System.Drawing.Size(300, 50);
            // 
            // Label14
            // 
            this.Label14.ForeColor = System.Drawing.Color.Red;
            this.Label14.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(26, 50);
            this.Label14.Text = "*";
            this.Label14.ZIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Border = new Smobiler.Core.Controls.Border(1F);
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.txtName.BorderRadius = 4;
            this.txtName.Location = new System.Drawing.Point(75, 10);
            this.txtName.Name = "txtName";
            this.txtName.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.txtName.Size = new System.Drawing.Size(190, 30);
            this.txtName.WaterMarkText = "类别名称";
            this.txtName.ZIndex = 1;
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.White;
            this.Label7.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.Label7.Name = "Label7";
            this.Label7.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.Label7.Size = new System.Drawing.Size(75, 50);
            this.Label7.Text = "类别名称";
            // 
            // Label12
            // 
            this.Label12.BackColor = System.Drawing.Color.White;
            this.Label12.Location = new System.Drawing.Point(75, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(205, 50);
            // 
            // plDate
            // 
            this.plDate.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label16,
            this.Label8,
            this.txtDate,
            this.Label13});
            this.plDate.Name = "plDate";
            this.plDate.Size = new System.Drawing.Size(300, 50);
            // 
            // Label16
            // 
            this.Label16.ForeColor = System.Drawing.Color.Red;
            this.Label16.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(26, 50);
            this.Label16.Text = "*";
            this.Label16.ZIndex = 1;
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.White;
            this.Label8.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.Label8.Name = "Label8";
            this.Label8.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.Label8.Size = new System.Drawing.Size(75, 50);
            this.Label8.Text = "年限(月)";
            // 
            // txtDate
            // 
            this.txtDate.Border = new Smobiler.Core.Controls.Border(1F);
            this.txtDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.txtDate.BorderRadius = 4;
            this.txtDate.Location = new System.Drawing.Point(75, 10);
            this.txtDate.Name = "txtDate";
            this.txtDate.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.txtDate.Size = new System.Drawing.Size(190, 30);
            this.txtDate.WaterMarkText = "年限(月)";
            this.txtDate.ZIndex = 1;
            // 
            // Label13
            // 
            this.Label13.BackColor = System.Drawing.Color.White;
            this.Label13.Location = new System.Drawing.Point(75, 0);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(205, 50);
            // 
            // plButton
            // 
            this.plButton.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnCancel,
            this.btnSave});
            this.plButton.Name = "plButton";
            this.plButton.Size = new System.Drawing.Size(300, 35);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Border = new Smobiler.Core.Controls.Border(0F, 1F, 1F, 0F);
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnCancel.BorderRadius = 0;
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 35);
            this.btnCancel.Text = "取消";
            this.btnCancel.Press += new System.EventHandler(this.btnCancel_Press);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSave.BorderRadius = 0;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.btnSave.Location = new System.Drawing.Point(140, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 35);
            this.btnSave.Text = "确定";
            this.btnSave.Press += new System.EventHandler(this.btnSave_Press);
            // 
            // frmAssetsTypeCreateLayout
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.BorderRadius = 8;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plContent});
            this.Size = new System.Drawing.Size(280, 370);
            this.Load += new System.EventHandler(this.frmAssetsTypeCreateLayout_Load);
            this.Name = "frmAssetsTypeCreateLayout";

        }
        #endregion
        private Smobiler.Core.Controls.Panel plContent;
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.TextBox txtFID;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.TextBox txtFName;
        internal Smobiler.Core.Controls.Label Label9;
        internal Smobiler.Core.Controls.Label Label5;
        internal Smobiler.Core.Controls.TextBox txtFDate;
        internal Smobiler.Core.Controls.Label Label10;
        private Smobiler.Core.Controls.Panel plID;
        internal Smobiler.Core.Controls.Label Label15;
        internal Smobiler.Core.Controls.Label Label6;
        internal Smobiler.Core.Controls.TextBox txtID;
        internal Smobiler.Core.Controls.Label Label11;
        private Smobiler.Core.Controls.Panel plName;
        internal Smobiler.Core.Controls.Label Label14;
        internal Smobiler.Core.Controls.TextBox txtName;
        internal Smobiler.Core.Controls.Label Label7;
        internal Smobiler.Core.Controls.Label Label12;
        private Smobiler.Core.Controls.Panel plDate;
        internal Smobiler.Core.Controls.Label Label16;
        internal Smobiler.Core.Controls.Label Label8;
        internal Smobiler.Core.Controls.TextBox txtDate;
        internal Smobiler.Core.Controls.Label Label13;
        private Smobiler.Core.Controls.Panel plButton;
        internal Smobiler.Core.Controls.Button btnCancel;
        internal Smobiler.Core.Controls.Button btnSave;
        internal Smobiler.Core.Controls.Panel plFID;
        internal Smobiler.Core.Controls.Panel plFName;
        internal Smobiler.Core.Controls.Panel plFDate;
    }
}