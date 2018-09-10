using System;
using Smobiler.Core;
namespace SMOWMS.UI.Layout
{
    partial class frmCIResultTotalLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public frmCIResultTotalLayout()
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
            this.lblTitle = new Smobiler.Core.Controls.Label();
            this.plCons = new Smobiler.Core.Controls.Panel();
            this.label11 = new Smobiler.Core.Controls.Label();
            this.lblName = new Smobiler.Core.Controls.Label();
            this.ibCons = new Smobiler.Core.Controls.ImageButton();
            this.plSL = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.lblSL = new Smobiler.Core.Controls.Label();
            this.plNumber = new Smobiler.Core.Controls.Panel();
            this.label10 = new Smobiler.Core.Controls.Label();
            this.lblNumber = new Smobiler.Core.Controls.Label();
            this.plRealNumber = new Smobiler.Core.Controls.Panel();
            this.label12 = new Smobiler.Core.Controls.Label();
            this.txtRealAmount = new Smobiler.Core.Controls.TextBox();
            this.plButton = new Smobiler.Core.Controls.Panel();
            this.button5 = new Smobiler.Core.Controls.Button();
            this.button6 = new Smobiler.Core.Controls.Button();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.btnCancel = new Smobiler.Core.Controls.Button();
            this.btnSure = new Smobiler.Core.Controls.Button();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.button2 = new Smobiler.Core.Controls.Button();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.label8 = new Smobiler.Core.Controls.Label();
            this.label9 = new Smobiler.Core.Controls.Label();
            this.textBox2 = new Smobiler.Core.Controls.TextBox();
            this.button3 = new Smobiler.Core.Controls.Button();
            this.button4 = new Smobiler.Core.Controls.Button();
            this.bsCons = new Smobiler.Core.Controls.BarcodeScanner();
            // 
            // plContent
            // 
            this.plContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.plContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblTitle,
            this.plCons,
            this.plSL,
            this.plNumber,
            this.plRealNumber,
            this.plButton});
            this.plContent.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.plContent.Name = "plContent";
            this.plContent.Size = new System.Drawing.Size(280, 270);
            // 
            // lblTitle
            // 
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(280, 35);
            this.lblTitle.Text = "耗材盘点";
            // 
            // plCons
            // 
            this.plCons.BackColor = System.Drawing.Color.White;
            this.plCons.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label11,
            this.lblName,
            this.ibCons});
            this.plCons.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.plCons.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.plCons.Name = "plCons";
            this.plCons.Size = new System.Drawing.Size(300, 50);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label11.Name = "label11";
            this.label11.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.label11.Size = new System.Drawing.Size(75, 50);
            this.label11.Text = "盘点耗材";
            // 
            // lblName
            // 
            this.lblName.Border = new Smobiler.Core.Controls.Border(1F);
            this.lblName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.lblName.BorderRadius = 4;
            this.lblName.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblName.Location = new System.Drawing.Point(0, 10);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.lblName.Size = new System.Drawing.Size(160, 30);
            // 
            // ibCons
            // 
            this.ibCons.BackColor = System.Drawing.Color.White;
            this.ibCons.Location = new System.Drawing.Point(6, 11);
            this.ibCons.Name = "ibCons";
            this.ibCons.ResourceID = "scan";
            this.ibCons.Size = new System.Drawing.Size(28, 28);
            this.ibCons.Press += new System.EventHandler(this.ibCons_Press);
            // 
            // plSL
            // 
            this.plSL.BackColor = System.Drawing.Color.White;
            this.plSL.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.lblSL});
            this.plSL.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.plSL.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.plSL.Name = "plSL";
            this.plSL.Size = new System.Drawing.Size(300, 50);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.label1.Size = new System.Drawing.Size(75, 50);
            this.label1.Text = "盘点库位";
            // 
            // lblSL
            // 
            this.lblSL.Border = new Smobiler.Core.Controls.Border(1F);
            this.lblSL.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.lblSL.BorderRadius = 4;
            this.lblSL.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblSL.Location = new System.Drawing.Point(0, 10);
            this.lblSL.Name = "lblSL";
            this.lblSL.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.lblSL.Size = new System.Drawing.Size(195, 30);
            // 
            // plNumber
            // 
            this.plNumber.BackColor = System.Drawing.Color.White;
            this.plNumber.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label10,
            this.lblNumber});
            this.plNumber.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.plNumber.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.plNumber.Name = "plNumber";
            this.plNumber.Size = new System.Drawing.Size(300, 50);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label10.Name = "label10";
            this.label10.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.label10.Size = new System.Drawing.Size(75, 50);
            this.label10.Text = "应盘数量";
            // 
            // lblNumber
            // 
            this.lblNumber.Border = new Smobiler.Core.Controls.Border(1F);
            this.lblNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.lblNumber.BorderRadius = 4;
            this.lblNumber.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblNumber.Location = new System.Drawing.Point(0, 10);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.lblNumber.Size = new System.Drawing.Size(195, 30);
            // 
            // plRealNumber
            // 
            this.plRealNumber.BackColor = System.Drawing.Color.White;
            this.plRealNumber.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label12,
            this.txtRealAmount});
            this.plRealNumber.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.plRealNumber.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.plRealNumber.Name = "plRealNumber";
            this.plRealNumber.Size = new System.Drawing.Size(300, 50);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label12.Name = "label12";
            this.label12.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.label12.Size = new System.Drawing.Size(75, 50);
            this.label12.Text = "实盘数量";
            // 
            // txtRealAmount
            // 
            this.txtRealAmount.Border = new Smobiler.Core.Controls.Border(1F);
            this.txtRealAmount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.txtRealAmount.BorderRadius = 4;
            this.txtRealAmount.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtRealAmount.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtRealAmount.Location = new System.Drawing.Point(0, 10);
            this.txtRealAmount.Name = "txtRealAmount";
            this.txtRealAmount.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtRealAmount.Size = new System.Drawing.Size(195, 30);
            this.txtRealAmount.WaterMarkText = "实盘数量";
            // 
            // plButton
            // 
            this.plButton.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.button5,
            this.button6});
            this.plButton.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.plButton.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.plButton.Name = "plButton";
            this.plButton.Size = new System.Drawing.Size(0, 35);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Border = new Smobiler.Core.Controls.Border(0F, 1F, 1F, 0F);
            this.button5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.button5.BorderRadius = 0;
            this.button5.Flex = 1;
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(0, 0);
            this.button5.Text = "取消";
            this.button5.Press += new System.EventHandler(this.btnCancel_Press);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.button6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.button6.BorderRadius = 0;
            this.button6.Flex = 1;
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(0, 0);
            this.button6.Text = "确定";
            this.button6.Press += new System.EventHandler(this.btnSave_Press);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.label2.Size = new System.Drawing.Size(75, 50);
            this.label2.Text = "应盘数量";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.label5.Size = new System.Drawing.Size(75, 50);
            this.label5.Text = "实盘数量";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Border = new Smobiler.Core.Controls.Border(0F, 1F, 1F, 0F);
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnCancel.BorderRadius = 0;
            this.btnCancel.Flex = 1;
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(0, 0);
            this.btnCancel.Text = "取消";
            this.btnCancel.Press += new System.EventHandler(this.btnCancel_Press);
            // 
            // btnSure
            // 
            this.btnSure.BackColor = System.Drawing.Color.White;
            this.btnSure.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.btnSure.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSure.BorderRadius = 0;
            this.btnSure.Flex = 1;
            this.btnSure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.btnSure.Name = "btnSure";
            this.btnSure.Size = new System.Drawing.Size(0, 0);
            this.btnSure.Text = "确定";
            this.btnSure.Press += new System.EventHandler(this.btnSave_Press);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label3.Name = "label3";
            this.label3.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.label3.Size = new System.Drawing.Size(75, 50);
            this.label3.Text = "应盘数量";
            // 
            // label6
            // 
            this.label6.Border = new Smobiler.Core.Controls.Border(1F);
            this.label6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.label6.BorderRadius = 4;
            this.label6.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label6.Location = new System.Drawing.Point(0, 10);
            this.label6.Name = "label6";
            this.label6.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.label6.Size = new System.Drawing.Size(195, 30);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label7.Name = "label7";
            this.label7.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.label7.Size = new System.Drawing.Size(75, 50);
            this.label7.Text = "实盘数量";
            // 
            // textBox1
            // 
            this.textBox1.Border = new Smobiler.Core.Controls.Border(1F);
            this.textBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.textBox1.BorderRadius = 4;
            this.textBox1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.textBox1.Location = new System.Drawing.Point(0, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.textBox1.Size = new System.Drawing.Size(195, 30);
            this.textBox1.WaterMarkText = "实盘数量";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 1F, 0F);
            this.button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.button1.BorderRadius = 0;
            this.button1.Flex = 1;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.Text = "取消";
            this.button1.Press += new System.EventHandler(this.btnCancel_Press);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.button2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.button2.BorderRadius = 0;
            this.button2.Flex = 1;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(0, 0);
            this.button2.Text = "确定";
            this.button2.Press += new System.EventHandler(this.btnSave_Press);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label4.Name = "label4";
            this.label4.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.label4.Size = new System.Drawing.Size(75, 50);
            this.label4.Text = "应盘数量";
            // 
            // label8
            // 
            this.label8.Border = new Smobiler.Core.Controls.Border(1F);
            this.label8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.label8.BorderRadius = 4;
            this.label8.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label8.Location = new System.Drawing.Point(0, 10);
            this.label8.Name = "label8";
            this.label8.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.label8.Size = new System.Drawing.Size(195, 30);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label9.Name = "label9";
            this.label9.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.label9.Size = new System.Drawing.Size(75, 50);
            this.label9.Text = "实盘数量";
            // 
            // textBox2
            // 
            this.textBox2.Border = new Smobiler.Core.Controls.Border(1F);
            this.textBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.textBox2.BorderRadius = 4;
            this.textBox2.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.textBox2.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.textBox2.Location = new System.Drawing.Point(0, 10);
            this.textBox2.Name = "textBox2";
            this.textBox2.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.textBox2.Size = new System.Drawing.Size(195, 30);
            this.textBox2.WaterMarkText = "实盘数量";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Border = new Smobiler.Core.Controls.Border(0F, 1F, 1F, 0F);
            this.button3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.button3.BorderRadius = 0;
            this.button3.Flex = 1;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(0, 0);
            this.button3.Text = "取消";
            this.button3.Press += new System.EventHandler(this.btnCancel_Press);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.button4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.button4.BorderRadius = 0;
            this.button4.Flex = 1;
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(0, 0);
            this.button4.Text = "确定";
            this.button4.Press += new System.EventHandler(this.btnSave_Press);
            // 
            // bsCons
            // 
            this.bsCons.Name = "bsCons";
            this.bsCons.BarcodeScanned += new Smobiler.Core.Controls.BarcodeScannerCallBackHandler(this.bsCons_BarcodeScanned);
            // 
            // frmCIResultTotalLayout
            // 
            this.BorderRadius = 8;
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.bsCons});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plContent});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Size = new System.Drawing.Size(280, 270);
            this.Name = "frmCIResultTotalLayout";

        }
        #endregion

        internal Smobiler.Core.Controls.Panel plContent;
        internal Smobiler.Core.Controls.Label lblTitle;
        internal Smobiler.Core.Controls.Label label3;
        internal Smobiler.Core.Controls.Label label6;
        internal Smobiler.Core.Controls.Label label7;
        internal Smobiler.Core.Controls.TextBox textBox1;
        internal Smobiler.Core.Controls.Button button1;
        internal Smobiler.Core.Controls.Button button2;
        internal Smobiler.Core.Controls.Label label2;
        internal Smobiler.Core.Controls.Label label5;
        internal Smobiler.Core.Controls.Button btnCancel;
        internal Smobiler.Core.Controls.Button btnSure;
        internal Smobiler.Core.Controls.Label label4;
        internal Smobiler.Core.Controls.Label label8;
        internal Smobiler.Core.Controls.Label label9;
        internal Smobiler.Core.Controls.TextBox textBox2;
        internal Smobiler.Core.Controls.Button button3;
        internal Smobiler.Core.Controls.Button button4;
        private Smobiler.Core.Controls.Panel plCons;
        internal Smobiler.Core.Controls.Label label11;
        internal Smobiler.Core.Controls.Label lblName;
        private Smobiler.Core.Controls.ImageButton ibCons;
        private Smobiler.Core.Controls.BarcodeScanner bsCons;
        private Smobiler.Core.Controls.Panel plSL;
        internal Smobiler.Core.Controls.Label label1;
        internal Smobiler.Core.Controls.Label lblSL;
        internal Smobiler.Core.Controls.Panel plNumber;
        internal Smobiler.Core.Controls.Label label10;
        internal Smobiler.Core.Controls.Label lblNumber;
        private Smobiler.Core.Controls.Panel plRealNumber;
        internal Smobiler.Core.Controls.Label label12;
        internal Smobiler.Core.Controls.TextBox txtRealAmount;
        private Smobiler.Core.Controls.Panel plButton;
        internal Smobiler.Core.Controls.Button button5;
        internal Smobiler.Core.Controls.Button button6;
    }
}