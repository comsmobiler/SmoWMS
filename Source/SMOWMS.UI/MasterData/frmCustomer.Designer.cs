using System;
using Smobiler.Core;
namespace SMOWMS.UI.MasterData
{
    partial class frmCustomer : Smobiler.Core.Controls.MobileForm
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
            Smobiler.Core.Controls.ActionButtonItem actionButtonItem1 = new Smobiler.Core.Controls.ActionButtonItem();
            this.title1 = new SMOWMS.UI.UserControl.Title();
            this.plContent = new Smobiler.Core.Controls.Panel();
            this.plSearch = new Smobiler.Core.Controls.Panel();
            this.fontIcon1 = new Smobiler.Core.Controls.FontIcon();
            this.txtName = new Smobiler.Core.Controls.TextBox();
            this.lvCumtomer = new Smobiler.Core.Controls.ListView();
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
            this.title1.TitleText = "客户列表";
            // 
            // plContent
            // 
            this.plContent.BackColor = System.Drawing.Color.White;
            this.plContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plSearch,
            this.lvCumtomer});
            this.plContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plContent.Location = new System.Drawing.Point(0, 116);
            this.plContent.Name = "plContent";
            this.plContent.Size = new System.Drawing.Size(300, 100);
            // 
            // plSearch
            // 
            this.plSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.plSearch.BorderRadius = 4;
            this.plSearch.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.fontIcon1,
            this.txtName});
            this.plSearch.Location = new System.Drawing.Point(10, 8);
            this.plSearch.Name = "plSearch";
            this.plSearch.Size = new System.Drawing.Size(280, 20);
            // 
            // fontIcon1
            // 
            this.fontIcon1.ForeColor = System.Drawing.Color.Silver;
            this.fontIcon1.Location = new System.Drawing.Point(10, 2);
            this.fontIcon1.Name = "fontIcon1";
            this.fontIcon1.ResourceID = "search";
            this.fontIcon1.Size = new System.Drawing.Size(16, 16);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.Location = new System.Drawing.Point(40, 0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(230, 20);
            this.txtName.WaterMarkText = "单位名称、联系人、电话、地址";
            this.txtName.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lvCumtomer
            // 
            this.lvCumtomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCumtomer.Location = new System.Drawing.Point(0, 54);
            this.lvCumtomer.Margin = new Smobiler.Core.Controls.Margin(0F, 35F, 0F, 0F);
            this.lvCumtomer.Name = "lvCumtomer";
            this.lvCumtomer.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lvCumtomer.PageSizeTextSize = 11F;
            this.lvCumtomer.ShowSplitLine = true;
            this.lvCumtomer.Size = new System.Drawing.Size(300, 300);
            this.lvCumtomer.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // frmCustomer
            // 
            this.ActionButton.Enabled = true;
            actionButtonItem1.ImageType = Smobiler.Core.Controls.ActionButtonImageType.Text;
            actionButtonItem1.Text = "客户新增";
            this.ActionButton.Items.AddRange(new Smobiler.Core.Controls.ActionButtonItem[] {
            actionButtonItem1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.plContent});
            this.ActionButtonPress += new Smobiler.Core.Controls.ActionButtonPressEventHandler(this.frmCustomer_ActionButtonPress);
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.Name = "frmCustomer";

        }
        #endregion

        private UserControl.Title title1;
        private Smobiler.Core.Controls.Panel plContent;
        private Smobiler.Core.Controls.Panel plSearch;
        private Smobiler.Core.Controls.FontIcon fontIcon1;
        private Smobiler.Core.Controls.TextBox txtName;
        private Smobiler.Core.Controls.ListView lvCumtomer;
    }
}