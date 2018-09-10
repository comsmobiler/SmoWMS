using System;
using Smobiler.Core;
namespace SMOWMS.UI.Analyze.Consumable
{
    partial class frmPurchaseAnalyze : Smobiler.Core.Controls.MobileForm
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
            this.plDate = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.dpStart = new Smobiler.Core.Controls.DatePicker();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.dpEnd = new Smobiler.Core.Controls.DatePicker();
            this.bcQuant = new Smobiler.Core.Controls.BarChart();
            // 
            // Title1
            // 
            this.Title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.Title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title1.FontSize = 15F;
            this.Title1.ForeColor = System.Drawing.Color.White;
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(300, 40);
            this.Title1.TitleText = "采购分析";
            // 
            // plDate
            // 
            this.plDate.BackColor = System.Drawing.Color.White;
            this.plDate.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.dpStart,
            this.label2,
            this.dpEnd});
            this.plDate.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.plDate.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.plDate.Location = new System.Drawing.Point(0, 40);
            this.plDate.Name = "plDate";
            this.plDate.Size = new System.Drawing.Size(300, 35);
            // 
            // label1
            // 
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(80, 35);
            this.label1.Text = "采购日期";
            // 
            // dpStart
            // 
            this.dpStart.Name = "dpStart";
            this.dpStart.Size = new System.Drawing.Size(100, 35);
            this.dpStart.ValueChanged += new System.EventHandler(this.dpStart_ValueChanged);
            // 
            // label2
            // 
            this.label2.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 35);
            this.label2.Text = "-";
            // 
            // dpEnd
            // 
            this.dpEnd.Name = "dpEnd";
            this.dpEnd.Size = new System.Drawing.Size(100, 35);
            this.dpEnd.ValueChanged += new System.EventHandler(this.dpEnd_ValueChanged);
            // 
            // bcQuant
            // 
            this.bcQuant.Location = new System.Drawing.Point(0, 101);
            this.bcQuant.Name = "bcQuant";
            this.bcQuant.Size = new System.Drawing.Size(300, 300);
            this.bcQuant.XAxisValues = new string[0];
            this.bcQuant.XValueMember = "NAME";
            this.bcQuant.YValueMember = "QUANTITY";
            // 
            // frmPurchaseAnalyze
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Title1,
            this.plDate,
            this.bcQuant});
            this.Load += new System.EventHandler(this.frmPurchaseAnalyze_Load);
            this.Name = "frmPurchaseAnalyze";

        }
        #endregion

        private UserControl.Title Title1;
        private Smobiler.Core.Controls.Panel plDate;
        private Smobiler.Core.Controls.BarChart bcQuant;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.DatePicker dpStart;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.DatePicker dpEnd;
    }
}