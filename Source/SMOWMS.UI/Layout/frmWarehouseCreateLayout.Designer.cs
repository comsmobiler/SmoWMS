using System;
using Smobiler.Core;
namespace SMOWMS.UI.Layout
{
    partial class frmWarehouseCreateLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public frmWarehouseCreateLayout()
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
            this.Label9 = new Smobiler.Core.Controls.Label();
            this.btnCancel = new Smobiler.Core.Controls.Button();
            this.btnSave = new Smobiler.Core.Controls.Button();
            this.txtWareID = new Smobiler.Core.Controls.TextBox();
            this.txtWareName = new Smobiler.Core.Controls.TextBox();
            this.Label15 = new Smobiler.Core.Controls.Label();
            this.label17 = new Smobiler.Core.Controls.Label();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.btnManager = new Smobiler.Core.Controls.Button();
            this.popMan = new Smobiler.Core.Controls.PopList();
            this.label8 = new Smobiler.Core.Controls.Label();
            this.label10 = new Smobiler.Core.Controls.Label();
            this.switchIsEnable = new Smobiler.Core.Controls.Switch();
            this.label11 = new Smobiler.Core.Controls.Label();
            this.label12 = new Smobiler.Core.Controls.Label();
            this.txtPlace = new Smobiler.Core.Controls.TextBox();
            // 
            // Label1
            // 
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(280, 35);
            this.Label1.Text = "仓库新增";
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
            // Label9
            // 
            this.Label9.BackColor = System.Drawing.Color.White;
            this.Label9.Location = new System.Drawing.Point(75, 85);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(205, 50);
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
            // txtWareID
            // 
            this.txtWareID.Border = new Smobiler.Core.Controls.Border(1F);
            this.txtWareID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.txtWareID.BorderRadius = 4;
            this.txtWareID.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtWareID.Location = new System.Drawing.Point(75, 45);
            this.txtWareID.Name = "txtWareID";
            this.txtWareID.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtWareID.Size = new System.Drawing.Size(190, 30);
            this.txtWareID.WaterMarkText = "仓库编码";
            // 
            // txtWareName
            // 
            this.txtWareName.Border = new Smobiler.Core.Controls.Border(1F);
            this.txtWareName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.txtWareName.BorderRadius = 4;
            this.txtWareName.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtWareName.Location = new System.Drawing.Point(75, 95);
            this.txtWareName.Name = "txtWareName";
            this.txtWareName.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtWareName.Size = new System.Drawing.Size(190, 30);
            this.txtWareName.WaterMarkText = "仓库名称";
            // 
            // Label15
            // 
            this.Label15.ForeColor = System.Drawing.Color.Red;
            this.Label15.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.Label15.Location = new System.Drawing.Point(0, 85);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(26, 50);
            this.Label15.Text = "*";
            // 
            // label17
            // 
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label17.Location = new System.Drawing.Point(0, 35);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(26, 50);
            this.label17.Text = "*";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label5.Location = new System.Drawing.Point(0, 135);
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.label5.Size = new System.Drawing.Size(75, 50);
            this.label5.Text = "负责人";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(75, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 50);
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label7.Location = new System.Drawing.Point(0, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 50);
            this.label7.Text = "*";
            // 
            // btnManager
            // 
            this.btnManager.BackColor = System.Drawing.Color.White;
            this.btnManager.Border = new Smobiler.Core.Controls.Border(1F);
            this.btnManager.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.btnManager.BorderRadius = 4;
            this.btnManager.ForeColor = System.Drawing.Color.Black;
            this.btnManager.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnManager.Location = new System.Drawing.Point(75, 144);
            this.btnManager.Name = "btnManager";
            this.btnManager.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.btnManager.Size = new System.Drawing.Size(190, 30);
            this.btnManager.Press += new System.EventHandler(this.btnManager_Press);
            // 
            // popMan
            // 
            this.popMan.Name = "popMan";
            this.popMan.Selected += new System.EventHandler(this.popMan_Selected);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label8.Location = new System.Drawing.Point(0, 185);
            this.label8.Name = "label8";
            this.label8.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.label8.Size = new System.Drawing.Size(75, 50);
            this.label8.Text = "是否启用";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(75, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(205, 50);
            // 
            // switchIsEnable
            // 
            this.switchIsEnable.Location = new System.Drawing.Point(205, 195);
            this.switchIsEnable.Name = "switchIsEnable";
            this.switchIsEnable.Size = new System.Drawing.Size(60, 30);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label11.Location = new System.Drawing.Point(0, 235);
            this.label11.Name = "label11";
            this.label11.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.label11.Size = new System.Drawing.Size(75, 50);
            this.label11.Text = "地点";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(75, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(205, 50);
            // 
            // txtPlace
            // 
            this.txtPlace.Border = new Smobiler.Core.Controls.Border(1F);
            this.txtPlace.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.txtPlace.BorderRadius = 4;
            this.txtPlace.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtPlace.Location = new System.Drawing.Point(75, 245);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtPlace.Size = new System.Drawing.Size(190, 30);
            this.txtPlace.WaterMarkText = "地点";
            // 
            // frmWarehouseCreateLayout
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.popMan});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label1,
            this.Label2,
            this.Label3,
            this.Label4,
            this.Label9,
            this.btnCancel,
            this.btnSave,
            this.txtWareID,
            this.txtWareName,
            this.Label15,
            this.label17,
            this.label5,
            this.label6,
            this.label7,
            this.btnManager,
            this.label8,
            this.label10,
            this.switchIsEnable,
            this.label11,
            this.label12,
            this.txtPlace});
            this.Size = new System.Drawing.Size(280, 320);
            this.Load += new System.EventHandler(this.frmWarehouseCreateLayout_Load);
            this.Name = "frmWarehouseCreateLayout";

        }
        #endregion

        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.Label Label9;
        internal Smobiler.Core.Controls.Button btnCancel;
        internal Smobiler.Core.Controls.Button btnSave;
        internal Smobiler.Core.Controls.TextBox txtWareID;
        internal Smobiler.Core.Controls.TextBox txtWareName;
        internal Smobiler.Core.Controls.Label Label15;
        internal Smobiler.Core.Controls.Label label17;
        internal Smobiler.Core.Controls.Label label5;
        internal Smobiler.Core.Controls.Label label6;
        internal Smobiler.Core.Controls.Label label7;
        private Smobiler.Core.Controls.Button btnManager;
        private Smobiler.Core.Controls.PopList popMan;
        internal Smobiler.Core.Controls.Label label8;
        internal Smobiler.Core.Controls.Label label10;
        private Smobiler.Core.Controls.Switch switchIsEnable;
        internal Smobiler.Core.Controls.Label label11;
        internal Smobiler.Core.Controls.Label label12;
        internal Smobiler.Core.Controls.TextBox txtPlace;
    }
}