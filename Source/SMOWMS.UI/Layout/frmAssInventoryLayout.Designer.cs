using System;
using Smobiler.Core;
namespace SMOWMS.UI.Layout
{
    partial class frmAssInventoryLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public frmAssInventoryLayout()
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
            this.plRow = new Smobiler.Core.Controls.Panel();
            this.lblName = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.lblDate = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.lblCreateMan = new Smobiler.Core.Controls.Label();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.lblTotal = new Smobiler.Core.Controls.Label();
            this.label8 = new Smobiler.Core.Controls.Label();
            this.lblCount = new Smobiler.Core.Controls.Label();
            this.btnEdit = new Smobiler.Core.Controls.Button();
            this.btnDelete = new Smobiler.Core.Controls.Button();
            this.btnStart = new Smobiler.Core.Controls.Button();
            this.label1 = new Smobiler.Core.Controls.Label();
            // 
            // plRow
            // 
            this.plRow.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.plRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plRow.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblName,
            this.label2,
            this.lblDate,
            this.label4,
            this.lblCreateMan,
            this.label6,
            this.lblTotal,
            this.label8,
            this.lblCount,
            this.btnEdit,
            this.btnDelete,
            this.btnStart,
            this.label1});
            this.plRow.Name = "plRow";
            this.plRow.Size = new System.Drawing.Size(300, 122);
            this.plRow.Touchable = true;
            this.plRow.Press += new System.EventHandler(this.panel1_Press);
            // 
            // lblName
            // 
            this.lblName.DataMember = "IID";
            this.lblName.DisplayMember = "NAME";
            this.lblName.Name = "lblName";
            this.lblName.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.lblName.Size = new System.Drawing.Size(100, 30);
            this.lblName.Text = "label1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 30);
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label2.Size = new System.Drawing.Size(60, 30);
            this.label2.Text = "创建日期";
            // 
            // lblDate
            // 
            this.lblDate.DataMember = "Time";
            this.lblDate.DisplayMember = "Time";
            this.lblDate.Location = new System.Drawing.Point(60, 30);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(90, 30);
            this.lblDate.Text = "label3";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(150, 30);
            this.label4.Name = "label4";
            this.label4.Padding = new Smobiler.Core.Controls.Padding(2F, 0F, 0F, 0F);
            this.label4.Size = new System.Drawing.Size(60, 30);
            this.label4.Text = "盘点人";
            // 
            // lblCreateMan
            // 
            this.lblCreateMan.DataMember = "CREATEUSER";
            this.lblCreateMan.DisplayMember = "CREATEUSER";
            this.lblCreateMan.Location = new System.Drawing.Point(210, 30);
            this.lblCreateMan.Name = "lblCreateMan";
            this.lblCreateMan.Size = new System.Drawing.Size(90, 30);
            this.lblCreateMan.Text = "label5";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 60);
            this.label6.Name = "label6";
            this.label6.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label6.Size = new System.Drawing.Size(60, 30);
            this.label6.Text = "盘点总数";
            // 
            // lblTotal
            // 
            this.lblTotal.DataMember = "TOTAL";
            this.lblTotal.DisplayMember = "TOTAL";
            this.lblTotal.Location = new System.Drawing.Point(60, 60);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(90, 30);
            this.lblTotal.Text = "label7";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(150, 60);
            this.label8.Name = "label8";
            this.label8.Padding = new Smobiler.Core.Controls.Padding(2F, 0F, 0F, 0F);
            this.label8.Size = new System.Drawing.Size(60, 30);
            this.label8.Text = "已盘点";
            // 
            // lblCount
            // 
            this.lblCount.DataMember = "RESULTCOUNT";
            this.lblCount.DisplayMember = "RESULTCOUNT";
            this.lblCount.Location = new System.Drawing.Point(210, 60);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(90, 30);
            this.lblCount.Text = "label9";
            // 
            // btnEdit
            // 
            this.btnEdit.BindDisplayValueGone = true;
            this.btnEdit.DisplayMember = "CanEdit";
            this.btnEdit.Location = new System.Drawing.Point(15, 91);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 30);
            this.btnEdit.Text = "编辑";
            this.btnEdit.Press += new System.EventHandler(this.btnEdit_Press);
            // 
            // btnDelete
            // 
            this.btnDelete.BindDisplayValueGone = true;
            this.btnDelete.DisplayMember = "CanDelete";
            this.btnDelete.Location = new System.Drawing.Point(110, 91);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.Text = "删除";
            this.btnDelete.Press += new System.EventHandler(this.btnDelete_Press);
            // 
            // btnStart
            // 
            this.btnStart.BindDisplayValueGone = true;
            this.btnStart.DisplayMember = "CanStart";
            this.btnStart.Location = new System.Drawing.Point(205, 91);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(80, 30);
            this.btnStart.Text = "开始盘点";
            this.btnStart.Press += new System.EventHandler(this.btnStart_Press);
            // 
            // label1
            // 
            this.label1.DataMember = "STATUSNAME";
            this.label1.DisplayMember = "STATUSNAME";
            this.label1.Location = new System.Drawing.Point(222, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            // 
            // frmAssInventoryLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plRow});
            this.Size = new System.Drawing.Size(300, 122);
            this.Name = "frmAssInventoryLayout";

        }
        #endregion

        private Smobiler.Core.Controls.Panel plRow;
        private Smobiler.Core.Controls.Label lblName;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label lblDate;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.Label lblCreateMan;
        private Smobiler.Core.Controls.Label label6;
        private Smobiler.Core.Controls.Label lblTotal;
        private Smobiler.Core.Controls.Label label8;
        private Smobiler.Core.Controls.Label lblCount;
        private Smobiler.Core.Controls.Button btnEdit;
        private Smobiler.Core.Controls.Button btnDelete;
        public Smobiler.Core.Controls.Label label1;
        public Smobiler.Core.Controls.Button btnStart;
    }
}