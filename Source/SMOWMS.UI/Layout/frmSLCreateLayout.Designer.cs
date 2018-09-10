using System;
using Smobiler.Core;
namespace SMOWMS.UI.Layout
{
    partial class frmSLCreateLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public frmSLCreateLayout()
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
            this.Label16 = new Smobiler.Core.Controls.Label();
            this.Label14 = new Smobiler.Core.Controls.Label();
            this.txtSLName = new Smobiler.Core.Controls.TextBox();
            this.txtSLID = new Smobiler.Core.Controls.TextBox();
            this.txtSTName = new Smobiler.Core.Controls.TextBox();
            this.txtSTID = new Smobiler.Core.Controls.TextBox();
            this.txtWareName = new Smobiler.Core.Controls.TextBox();
            this.txtWareID = new Smobiler.Core.Controls.TextBox();
            this.btnSave = new Smobiler.Core.Controls.Button();
            this.btnCancel = new Smobiler.Core.Controls.Button();
            this.Label13 = new Smobiler.Core.Controls.Label();
            this.Label12 = new Smobiler.Core.Controls.Label();
            this.Label11 = new Smobiler.Core.Controls.Label();
            this.Label9 = new Smobiler.Core.Controls.Label();
            this.Label10 = new Smobiler.Core.Controls.Label();
            this.Label8 = new Smobiler.Core.Controls.Label();
            this.Label6 = new Smobiler.Core.Controls.Label();
            this.Label7 = new Smobiler.Core.Controls.Label();
            this.Label5 = new Smobiler.Core.Controls.Label();
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.label15 = new Smobiler.Core.Controls.Label();
            this.txtMAXCAPACITY = new Smobiler.Core.Controls.TextBox();
            this.label17 = new Smobiler.Core.Controls.Label();
            this.label18 = new Smobiler.Core.Controls.Label();
            this.label19 = new Smobiler.Core.Controls.Label();
            this.txtMAXVOLUME = new Smobiler.Core.Controls.TextBox();
            this.label20 = new Smobiler.Core.Controls.Label();
            this.label21 = new Smobiler.Core.Controls.Label();
            this.btnManager = new Smobiler.Core.Controls.Button();
            this.popMan = new Smobiler.Core.Controls.PopList();
            this.label22 = new Smobiler.Core.Controls.Label();
            // 
            // Label16
            // 
            this.Label16.ForeColor = System.Drawing.Color.Red;
            this.Label16.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.Label16.Location = new System.Drawing.Point(0, 235);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(26, 40);
            this.Label16.Text = "*";
            // 
            // Label14
            // 
            this.Label14.ForeColor = System.Drawing.Color.Red;
            this.Label14.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.Label14.Location = new System.Drawing.Point(0, 195);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(26, 40);
            this.Label14.Text = "*";
            // 
            // txtSLName
            // 
            this.txtSLName.Border = new Smobiler.Core.Controls.Border(1F);
            this.txtSLName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.txtSLName.BorderRadius = 4;
            this.txtSLName.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtSLName.Location = new System.Drawing.Point(75, 240);
            this.txtSLName.Name = "txtSLName";
            this.txtSLName.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtSLName.Size = new System.Drawing.Size(190, 30);
            this.txtSLName.WaterMarkText = "库位名称";
            // 
            // txtSLID
            // 
            this.txtSLID.Border = new Smobiler.Core.Controls.Border(1F);
            this.txtSLID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.txtSLID.BorderRadius = 4;
            this.txtSLID.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtSLID.Location = new System.Drawing.Point(75, 200);
            this.txtSLID.Name = "txtSLID";
            this.txtSLID.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtSLID.Size = new System.Drawing.Size(190, 30);
            this.txtSLID.WaterMarkText = "库位编号";
            // 
            // txtSTName
            // 
            this.txtSTName.Border = new Smobiler.Core.Controls.Border(1F);
            this.txtSTName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.txtSTName.BorderRadius = 4;
            this.txtSTName.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtSTName.Location = new System.Drawing.Point(75, 160);
            this.txtSTName.Name = "txtSTName";
            this.txtSTName.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtSTName.ReadOnly = true;
            this.txtSTName.Size = new System.Drawing.Size(190, 30);
            this.txtSTName.WaterMarkText = "类别名称";
            // 
            // txtSTID
            // 
            this.txtSTID.Border = new Smobiler.Core.Controls.Border(1F);
            this.txtSTID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.txtSTID.BorderRadius = 4;
            this.txtSTID.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtSTID.Location = new System.Drawing.Point(75, 120);
            this.txtSTID.Name = "txtSTID";
            this.txtSTID.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtSTID.ReadOnly = true;
            this.txtSTID.Size = new System.Drawing.Size(190, 30);
            this.txtSTID.WaterMarkText = "类别编码";
            // 
            // txtWareName
            // 
            this.txtWareName.Border = new Smobiler.Core.Controls.Border(1F);
            this.txtWareName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.txtWareName.BorderRadius = 4;
            this.txtWareName.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtWareName.Location = new System.Drawing.Point(75, 80);
            this.txtWareName.Name = "txtWareName";
            this.txtWareName.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtWareName.ReadOnly = true;
            this.txtWareName.Size = new System.Drawing.Size(190, 30);
            this.txtWareName.WaterMarkText = "仓库名称";
            // 
            // txtWareID
            // 
            this.txtWareID.Border = new Smobiler.Core.Controls.Border(1F);
            this.txtWareID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.txtWareID.BorderRadius = 4;
            this.txtWareID.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtWareID.Location = new System.Drawing.Point(75, 40);
            this.txtWareID.Name = "txtWareID";
            this.txtWareID.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
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
            this.btnSave.Location = new System.Drawing.Point(140, 395);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 35);
            this.btnSave.Text = "确定";
            this.btnSave.Press += new System.EventHandler(this.btnSave_Press);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Border = new Smobiler.Core.Controls.Border(0F, 1F, 1F, 0F);
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnCancel.BorderRadius = 0;
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(0, 395);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 35);
            this.btnCancel.Text = "取消";
            this.btnCancel.Press += new System.EventHandler(this.btnCancel_Press);
            // 
            // Label13
            // 
            this.Label13.BackColor = System.Drawing.Color.White;
            this.Label13.Location = new System.Drawing.Point(75, 235);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(205, 40);
            // 
            // Label12
            // 
            this.Label12.BackColor = System.Drawing.Color.White;
            this.Label12.Location = new System.Drawing.Point(75, 195);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(205, 40);
            // 
            // Label11
            // 
            this.Label11.BackColor = System.Drawing.Color.White;
            this.Label11.Location = new System.Drawing.Point(75, 155);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(205, 40);
            // 
            // Label9
            // 
            this.Label9.BackColor = System.Drawing.Color.White;
            this.Label9.Location = new System.Drawing.Point(75, 75);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(205, 40);
            // 
            // Label10
            // 
            this.Label10.BackColor = System.Drawing.Color.White;
            this.Label10.Location = new System.Drawing.Point(75, 115);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(205, 40);
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.White;
            this.Label8.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.Label8.Location = new System.Drawing.Point(0, 235);
            this.Label8.Name = "Label8";
            this.Label8.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.Label8.Size = new System.Drawing.Size(75, 40);
            this.Label8.Text = "库位名称";
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.White;
            this.Label6.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.Label6.Location = new System.Drawing.Point(0, 155);
            this.Label6.Name = "Label6";
            this.Label6.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.Label6.Size = new System.Drawing.Size(75, 40);
            this.Label6.Text = "类别名称";
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.White;
            this.Label7.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.Label7.Location = new System.Drawing.Point(0, 195);
            this.Label7.Name = "Label7";
            this.Label7.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.Label7.Size = new System.Drawing.Size(75, 40);
            this.Label7.Text = "库位编号";
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.White;
            this.Label5.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.Label5.Location = new System.Drawing.Point(0, 115);
            this.Label5.Name = "Label5";
            this.Label5.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.Label5.Size = new System.Drawing.Size(75, 40);
            this.Label5.Text = "类别编码";
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.White;
            this.Label4.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.Label4.Location = new System.Drawing.Point(0, 75);
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.Label4.Size = new System.Drawing.Size(75, 40);
            this.Label4.Text = "仓库名称";
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(75, 35);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(205, 40);
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.White;
            this.Label2.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.Label2.Location = new System.Drawing.Point(0, 35);
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.Label2.Size = new System.Drawing.Size(75, 40);
            this.Label2.Text = "仓库编码";
            // 
            // Label1
            // 
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(280, 35);
            this.Label1.Text = "库位";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label15.Location = new System.Drawing.Point(0, 275);
            this.label15.Name = "label15";
            this.label15.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.label15.Size = new System.Drawing.Size(75, 40);
            this.label15.Text = "负责人";
            // 
            // txtMAXCAPACITY
            // 
            this.txtMAXCAPACITY.Border = new Smobiler.Core.Controls.Border(1F);
            this.txtMAXCAPACITY.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.txtMAXCAPACITY.BorderRadius = 4;
            this.txtMAXCAPACITY.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtMAXCAPACITY.Location = new System.Drawing.Point(75, 360);
            this.txtMAXCAPACITY.Name = "txtMAXCAPACITY";
            this.txtMAXCAPACITY.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtMAXCAPACITY.Size = new System.Drawing.Size(190, 30);
            this.txtMAXCAPACITY.WaterMarkText = "最大承重";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(75, 355);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(205, 40);
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label18.Location = new System.Drawing.Point(0, 315);
            this.label18.Name = "label18";
            this.label18.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.label18.Size = new System.Drawing.Size(75, 40);
            this.label18.Text = "最大体积";
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(75, 315);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(205, 40);
            // 
            // txtMAXVOLUME
            // 
            this.txtMAXVOLUME.Border = new Smobiler.Core.Controls.Border(1F);
            this.txtMAXVOLUME.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.txtMAXVOLUME.BorderRadius = 4;
            this.txtMAXVOLUME.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtMAXVOLUME.Location = new System.Drawing.Point(75, 320);
            this.txtMAXVOLUME.Name = "txtMAXVOLUME";
            this.txtMAXVOLUME.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtMAXVOLUME.Size = new System.Drawing.Size(190, 30);
            this.txtMAXVOLUME.WaterMarkText = "最大体积";
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label20.Location = new System.Drawing.Point(0, 355);
            this.label20.Name = "label20";
            this.label20.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.label20.Size = new System.Drawing.Size(75, 40);
            this.label20.Text = "最大承重";
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(75, 275);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(205, 40);
            // 
            // btnManager
            // 
            this.btnManager.BackColor = System.Drawing.Color.White;
            this.btnManager.Border = new Smobiler.Core.Controls.Border(1F);
            this.btnManager.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.btnManager.BorderRadius = 4;
            this.btnManager.ForeColor = System.Drawing.Color.Black;
            this.btnManager.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnManager.Location = new System.Drawing.Point(75, 280);
            this.btnManager.Name = "btnManager";
            this.btnManager.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.btnManager.Size = new System.Drawing.Size(190, 30);
            this.btnManager.Text = "   >";
            this.btnManager.Press += new System.EventHandler(this.btnManager_Press);
            // 
            // popMan
            // 
            this.popMan.Name = "popMan";
            this.popMan.Selected += new System.EventHandler(this.popMan_Selected);
            // 
            // label22
            // 
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label22.Location = new System.Drawing.Point(0, 275);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(26, 40);
            this.label22.Text = "*";
            // 
            // frmSLCreateLayout
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.popMan});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnSave,
            this.btnCancel,
            this.Label13,
            this.Label12,
            this.Label11,
            this.Label9,
            this.Label10,
            this.Label8,
            this.Label6,
            this.Label7,
            this.Label5,
            this.Label4,
            this.Label3,
            this.Label2,
            this.Label16,
            this.Label14,
            this.txtSLName,
            this.txtSLID,
            this.txtSTName,
            this.txtSTID,
            this.txtWareName,
            this.txtWareID,
            this.Label1,
            this.label15,
            this.label17,
            this.txtMAXCAPACITY,
            this.label18,
            this.label19,
            this.txtMAXVOLUME,
            this.label20,
            this.label21,
            this.btnManager,
            this.label22});
            this.Size = new System.Drawing.Size(280, 430);
            this.Load += new System.EventHandler(this.frmSLCreateLayout_Load);
            this.Name = "frmSLCreateLayout";

        }
        #endregion
        internal Smobiler.Core.Controls.Label Label16;
        internal Smobiler.Core.Controls.Label Label14;
        internal Smobiler.Core.Controls.TextBox txtSLName;
        internal Smobiler.Core.Controls.TextBox txtSLID;
        internal Smobiler.Core.Controls.TextBox txtSTName;
        internal Smobiler.Core.Controls.TextBox txtSTID;
        internal Smobiler.Core.Controls.TextBox txtWareName;
        internal Smobiler.Core.Controls.TextBox txtWareID;
        internal Smobiler.Core.Controls.Button btnSave;
        internal Smobiler.Core.Controls.Button btnCancel;
        internal Smobiler.Core.Controls.Label Label13;
        internal Smobiler.Core.Controls.Label Label12;
        internal Smobiler.Core.Controls.Label Label11;
        internal Smobiler.Core.Controls.Label Label9;
        internal Smobiler.Core.Controls.Label Label10;
        internal Smobiler.Core.Controls.Label Label8;
        internal Smobiler.Core.Controls.Label Label6;
        internal Smobiler.Core.Controls.Label Label7;
        internal Smobiler.Core.Controls.Label Label5;
        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Label label15;
        internal Smobiler.Core.Controls.TextBox txtMAXCAPACITY;
        internal Smobiler.Core.Controls.Label label17;
        internal Smobiler.Core.Controls.Label label18;
        internal Smobiler.Core.Controls.Label label19;
        internal Smobiler.Core.Controls.TextBox txtMAXVOLUME;
        internal Smobiler.Core.Controls.Label label20;
        internal Smobiler.Core.Controls.Label label21;
        private Smobiler.Core.Controls.Button btnManager;
        private Smobiler.Core.Controls.PopList popMan;
        internal Smobiler.Core.Controls.Label label22;
    }
}