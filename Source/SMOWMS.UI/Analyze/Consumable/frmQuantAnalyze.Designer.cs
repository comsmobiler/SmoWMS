using System;
using Smobiler.Core;
namespace SMOWMS.UI.Analyze.Consumable
{
    partial class frmQuantAnalyze : Smobiler.Core.Controls.MobileForm
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
            this.Title1 = new SMOWMS.UI.UserControl.Title();
            this.plWareHouse = new Smobiler.Core.Controls.Panel();
            this.btnWareHouse = new Smobiler.Core.Controls.Button();
            this.bcQuant = new Smobiler.Core.Controls.BarChart();
            this.popWareHouse = new Smobiler.Core.Controls.PopList();
            // 
            // Title1
            // 
            this.Title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.Title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title1.FontSize = 15F;
            this.Title1.ForeColor = System.Drawing.Color.White;
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(300, 40);
            this.Title1.TitleText = "耗材库存统计";
            // 
            // plWareHouse
            // 
            this.plWareHouse.BackColor = System.Drawing.Color.White;
            this.plWareHouse.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnWareHouse});
            this.plWareHouse.Location = new System.Drawing.Point(0, 40);
            this.plWareHouse.Name = "plWareHouse";
            this.plWareHouse.Size = new System.Drawing.Size(300, 35);
            // 
            // btnWareHouse
            // 
            this.btnWareHouse.BackColor = System.Drawing.Color.White;
            this.btnWareHouse.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnWareHouse.BorderRadius = 0;
            this.btnWareHouse.ForeColor = System.Drawing.Color.Black;
            this.btnWareHouse.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnWareHouse.Location = new System.Drawing.Point(200, 0);
            this.btnWareHouse.Name = "btnWareHouse";
            this.btnWareHouse.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.btnWareHouse.Size = new System.Drawing.Size(100, 35);
            this.btnWareHouse.Text = "全部仓库   > ";
            this.btnWareHouse.Press += new System.EventHandler(this.btnWareHouse_Press);
            // 
            // bcQuant
            // 
            this.bcQuant.Location = new System.Drawing.Point(0, 105);
            this.bcQuant.Name = "bcQuant";
            this.bcQuant.Size = new System.Drawing.Size(300, 300);
            this.bcQuant.XAxisValues = new string[0];
            this.bcQuant.XValueMember = "NAME";
            this.bcQuant.YValueMember = "QUANTITY";
            // 
            // popWareHouse
            // 
            this.popWareHouse.Name = "popWareHouse";
            this.popWareHouse.Selected += new System.EventHandler(this.popWareHouse_Selected);
            // 
            // frmQuantAnalyze
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.popWareHouse});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Title1,
            this.plWareHouse,
            this.bcQuant});
            this.Load += new System.EventHandler(this.frmQuantAnalyze_Load);
            this.Name = "frmQuantAnalyze";

        }
        #endregion

        private UserControl.Title Title1;
        private Smobiler.Core.Controls.Panel plWareHouse;
        internal Smobiler.Core.Controls.Button btnWareHouse;
        private Smobiler.Core.Controls.BarChart bcQuant;
        private Smobiler.Core.Controls.PopList popWareHouse;
    }
}