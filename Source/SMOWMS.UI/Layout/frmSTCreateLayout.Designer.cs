using System;
using Smobiler.Core;
namespace SMOWMS.UI.Layout
{
    partial class frmSTCreateLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public frmSTCreateLayout()
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
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.Label5 = new Smobiler.Core.Controls.Label();
            this.Label6 = new Smobiler.Core.Controls.Label();
            this.Label10 = new Smobiler.Core.Controls.Label();
            this.Label9 = new Smobiler.Core.Controls.Label();
            this.Label11 = new Smobiler.Core.Controls.Label();
            this.btnCancel = new Smobiler.Core.Controls.Button();
            this.txtWareID = new Smobiler.Core.Controls.TextBox();
            this.btnSave = new Smobiler.Core.Controls.Button();
            this.txtWareName = new Smobiler.Core.Controls.TextBox();
            this.txtSTID = new Smobiler.Core.Controls.TextBox();
            this.txtSTName = new Smobiler.Core.Controls.TextBox();
            this.Label15 = new Smobiler.Core.Controls.Label();
            this.label17 = new Smobiler.Core.Controls.Label();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.label8 = new Smobiler.Core.Controls.Label();
            this.switchIsEnable = new Smobiler.Core.Controls.Switch();
            // 
            // Label1
            // 
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(280, 35);
            this.Label1.Text = "仓库类别";
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.White;
            this.Label2.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.Label2.Location = new System.Drawing.Point(0, 35);
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.Label2.Size = new System.Drawing.Size(75, 50);
            this.Label2.Text = "仓库编码";
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(75, 35);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(205, 50);
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.White;
            this.Label4.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.Label4.Location = new System.Drawing.Point(0, 85);
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.Label4.Size = new System.Drawing.Size(75, 50);
            this.Label4.Text = "仓库名称";
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.White;
            this.Label5.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.Label5.Location = new System.Drawing.Point(0, 135);
            this.Label5.Name = "Label5";
            this.Label5.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.Label5.Size = new System.Drawing.Size(75, 50);
            this.Label5.Text = "类别编码";
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.White;
            this.Label6.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.Label6.Location = new System.Drawing.Point(0, 185);
            this.Label6.Name = "Label6";
            this.Label6.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.Label6.Size = new System.Drawing.Size(75, 50);
            this.Label6.Text = "类别名称";
            // 
            // Label10
            // 
            this.Label10.BackColor = System.Drawing.Color.White;
            this.Label10.Location = new System.Drawing.Point(75, 135);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(205, 50);
            // 
            // Label9
            // 
            this.Label9.BackColor = System.Drawing.Color.White;
            this.Label9.Location = new System.Drawing.Point(75, 85);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(205, 50);
            // 
            // Label11
            // 
            this.Label11.BackColor = System.Drawing.Color.White;
            this.Label11.Location = new System.Drawing.Point(75, 185);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(205, 50);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Border = new Smobiler.Core.Controls.Border(0F, 1F, 1F, 0F);
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnCancel.BorderRadius = 0;
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(0, 285);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 35);
            this.btnCancel.Text = "取消";
            this.btnCancel.Press += new System.EventHandler(this.btnCancel_Press);
            // 
            // txtWareID
            // 
            this.txtWareID.Border = new Smobiler.Core.Controls.Border(1F);
            this.txtWareID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.txtWareID.BorderRadius = 4;
            this.txtWareID.Location = new System.Drawing.Point(75, 45);
            this.txtWareID.Name = "txtWareID";
            this.txtWareID.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.txtWareID.ReadOnly = true;
            this.txtWareID.Size = new System.Drawing.Size(190, 30);
            this.txtWareID.WaterMarkText = "仓库编码";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSave.BorderRadius = 0;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.btnSave.Location = new System.Drawing.Point(140, 285);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 35);
            this.btnSave.Text = "确定";
            this.btnSave.Press += new System.EventHandler(this.btnSave_Press);
            // 
            // txtWareName
            // 
            this.txtWareName.Border = new Smobiler.Core.Controls.Border(1F);
            this.txtWareName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.txtWareName.BorderRadius = 4;
            this.txtWareName.Location = new System.Drawing.Point(75, 95);
            this.txtWareName.Name = "txtWareName";
            this.txtWareName.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.txtWareName.ReadOnly = true;
            this.txtWareName.Size = new System.Drawing.Size(190, 30);
            this.txtWareName.WaterMarkText = "仓库名称";
            // 
            // txtSTID
            // 
            this.txtSTID.Border = new Smobiler.Core.Controls.Border(1F);
            this.txtSTID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.txtSTID.BorderRadius = 4;
            this.txtSTID.Location = new System.Drawing.Point(75, 145);
            this.txtSTID.Name = "txtSTID";
            this.txtSTID.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.txtSTID.Size = new System.Drawing.Size(190, 30);
            this.txtSTID.WaterMarkText = "类别编码";
            // 
            // txtSTName
            // 
            this.txtSTName.Border = new Smobiler.Core.Controls.Border(1F);
            this.txtSTName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.txtSTName.BorderRadius = 4;
            this.txtSTName.Location = new System.Drawing.Point(75, 195);
            this.txtSTName.Name = "txtSTName";
            this.txtSTName.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.txtSTName.Size = new System.Drawing.Size(190, 30);
            this.txtSTName.WaterMarkText = "类别名称";
            // 
            // Label15
            // 
            this.Label15.ForeColor = System.Drawing.Color.Red;
            this.Label15.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.Label15.Location = new System.Drawing.Point(0, 185);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(26, 50);
            this.Label15.Text = "*";
            // 
            // label17
            // 
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label17.Location = new System.Drawing.Point(0, 135);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(26, 50);
            this.label17.Text = "*";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label7.Location = new System.Drawing.Point(0, 235);
            this.label7.Name = "label7";
            this.label7.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.label7.Size = new System.Drawing.Size(75, 50);
            this.label7.Text = "是否启用";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(75, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 50);
            // 
            // switchIsEnable
            // 
            this.switchIsEnable.Location = new System.Drawing.Point(205, 245);
            this.switchIsEnable.Name = "switchIsEnable";
            this.switchIsEnable.Size = new System.Drawing.Size(60, 30);
            // 
            // frmSTCreateLayout
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label1,
            this.Label2,
            this.Label3,
            this.Label4,
            this.Label5,
            this.Label6,
            this.Label10,
            this.Label9,
            this.Label11,
            this.btnCancel,
            this.txtWareID,
            this.btnSave,
            this.txtWareName,
            this.txtSTID,
            this.txtSTName,
            this.Label15,
            this.label17,
            this.label7,
            this.label8,
            this.switchIsEnable});
            this.Size = new System.Drawing.Size(280, 320);
            this.Load += new System.EventHandler(this.frmSTCreateLayout_Load);
            this.Name = "frmSTCreateLayout";

        }
        #endregion

        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.Label Label5;
        internal Smobiler.Core.Controls.Label Label6;
        internal Smobiler.Core.Controls.Label Label10;
        internal Smobiler.Core.Controls.Label Label9;
        internal Smobiler.Core.Controls.Label Label11;
        internal Smobiler.Core.Controls.Button btnCancel;
        internal Smobiler.Core.Controls.TextBox txtWareID;
        internal Smobiler.Core.Controls.Button btnSave;
        internal Smobiler.Core.Controls.TextBox txtWareName;
        internal Smobiler.Core.Controls.TextBox txtSTID;
        internal Smobiler.Core.Controls.TextBox txtSTName;
        internal Smobiler.Core.Controls.Label Label15;
        internal Smobiler.Core.Controls.Label label17;
        internal Smobiler.Core.Controls.Label label7;
        internal Smobiler.Core.Controls.Label label8;
        private Smobiler.Core.Controls.Switch switchIsEnable;
    }
}