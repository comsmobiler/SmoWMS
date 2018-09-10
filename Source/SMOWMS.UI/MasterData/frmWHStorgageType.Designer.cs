using System;
using Smobiler.Core;
namespace SMOWMS.UI.MasterData
{
    partial class frmWHStorgageType : Smobiler.Core.Controls.MobileForm
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
            this.plAdd = new Smobiler.Core.Controls.Panel();
            this.imgAdd = new Smobiler.Core.Controls.Image();
            this.lblAdd = new Smobiler.Core.Controls.Label();
            this.plEdit = new Smobiler.Core.Controls.Panel();
            this.imgEdit = new Smobiler.Core.Controls.Image();
            this.lblEdit = new Smobiler.Core.Controls.Label();
            this.lvWHStorageType = new Smobiler.Core.Controls.ListView();
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.FontSize = 15F;
            this.title1.ForeColor = System.Drawing.Color.White;
            this.title1.Location = new System.Drawing.Point(109, 52);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 40);
            // 
            // plButton
            // 
            this.plButton.BackColor = System.Drawing.Color.White;
            this.plButton.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plAdd,
            this.plEdit});
            this.plButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.plButton.Location = new System.Drawing.Point(0, 40);
            this.plButton.Name = "plButton";
            this.plButton.Size = new System.Drawing.Size(150, 35);
            // 
            // plAdd
            // 
            this.plAdd.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imgAdd,
            this.lblAdd});
            this.plAdd.Name = "plAdd";
            this.plAdd.Size = new System.Drawing.Size(150, 35);
            this.plAdd.Touchable = true;
            this.plAdd.TouchOpacity = 100;
            this.plAdd.Press += new System.EventHandler(this.plAdd_Press);
            // 
            // imgAdd
            // 
            this.imgAdd.Location = new System.Drawing.Point(20, 5);
            this.imgAdd.Name = "imgAdd";
            this.imgAdd.ResourceID = "add1";
            this.imgAdd.Size = new System.Drawing.Size(25, 25);
            // 
            // lblAdd
            // 
            this.lblAdd.Location = new System.Drawing.Point(55, 0);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(95, 35);
            this.lblAdd.Text = "存储类型";
            // 
            // plEdit
            // 
            this.plEdit.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imgEdit,
            this.lblEdit});
            this.plEdit.Location = new System.Drawing.Point(150, 0);
            this.plEdit.Name = "plEdit";
            this.plEdit.Size = new System.Drawing.Size(150, 35);
            this.plEdit.Touchable = true;
            this.plEdit.TouchOpacity = 100;
            this.plEdit.Press += new System.EventHandler(this.plEdit_Press);
            // 
            // imgEdit
            // 
            this.imgEdit.Location = new System.Drawing.Point(60, 5);
            this.imgEdit.Name = "imgEdit";
            this.imgEdit.ResourceID = "edit1";
            this.imgEdit.Size = new System.Drawing.Size(25, 25);
            // 
            // lblEdit
            // 
            this.lblEdit.Location = new System.Drawing.Point(95, 0);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(50, 35);
            this.lblEdit.Text = "编辑";
            // 
            // lvWHStorageType
            // 
            this.lvWHStorageType.BackColor = System.Drawing.Color.White;
            this.lvWHStorageType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvWHStorageType.Name = "lvWHStorageType";
            this.lvWHStorageType.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lvWHStorageType.PageSizeTextSize = 11F;
            this.lvWHStorageType.ShowSplitLine = true;
            this.lvWHStorageType.Size = new System.Drawing.Size(300, 300);
            this.lvWHStorageType.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lvWHStorageType.TemplateControlName = "frmWHSTLayout";
            // 
            // frmWHStorgageType
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.plButton,
            this.lvWHStorageType});
            this.Load += new System.EventHandler(this.frmWHStorgageType_Load);
            this.Name = "frmWHStorgageType";

        }
        #endregion

        private UserControl.Title title1;
        private Smobiler.Core.Controls.Panel plButton;
        private Smobiler.Core.Controls.Panel plAdd;
        private Smobiler.Core.Controls.Image imgAdd;
        private Smobiler.Core.Controls.Label lblAdd;
        private Smobiler.Core.Controls.Panel plEdit;
        private Smobiler.Core.Controls.Image imgEdit;
        private Smobiler.Core.Controls.Label lblEdit;
        private Smobiler.Core.Controls.ListView lvWHStorageType;
    }
}