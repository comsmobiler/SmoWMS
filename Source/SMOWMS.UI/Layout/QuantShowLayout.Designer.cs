namespace SMOWMS.UI.Layout
{
    partial class QuantShowLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public QuantShowLayout()
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
            this.Panel1 = new Smobiler.Core.Controls.Panel();
            this.lblLocation = new Smobiler.Core.Controls.Label();
            this.lblASSID = new Smobiler.Core.Controls.Label();
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.lblQuant = new Smobiler.Core.Controls.Label();
            this.lblInUse = new Smobiler.Core.Controls.Label();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblLocation,
            this.lblASSID,
            this.Label1,
            this.Label2,
            this.Label3,
            this.lblQuant,
            this.lblInUse});
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(300, 130);
            // 
            // lblLocation
            // 
            this.lblLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.lblLocation.DataMember = "SLNAME";
            this.lblLocation.DisplayMember = "SLNAME";
            this.lblLocation.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(300, 25);
            this.lblLocation.Text = "¼ÇÂ¼±àºÅ";
            this.lblLocation.ZIndex = 1;
            // 
            // lblASSID
            // 
            this.lblASSID.DataMember = "CID";
            this.lblASSID.DisplayMember = "CID";
            this.lblASSID.Location = new System.Drawing.Point(99, 25);
            this.lblASSID.Name = "lblASSID";
            this.lblASSID.Size = new System.Drawing.Size(191, 20);
            this.lblASSID.Text = "×Ê²ú±àºÅ";
            this.lblASSID.ZIndex = 1;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(10, 25);
            this.Label1.Name = "Label1";
            this.Label1.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.Label1.Size = new System.Drawing.Size(89, 20);
            this.Label1.Text = "ºÄ²Ä±àºÅ";
            this.Label1.ZIndex = 1;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(10, 45);
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.Label2.Size = new System.Drawing.Size(89, 20);
            this.Label2.Text = "ºÄ²ÄÃû³Æ";
            this.Label2.ZIndex = 1;
            // 
            // Label3
            // 
            this.Label3.FontSize = 12F;
            this.Label3.Location = new System.Drawing.Point(10, 65);
            this.Label3.Name = "Label3";
            this.Label3.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.Label3.Size = new System.Drawing.Size(89, 20);
            this.Label3.Text = "¿â´æÊýÁ¿";
            this.Label3.ZIndex = 1;
            // 
            // lblQuant
            // 
            this.lblQuant.DataMember = "NAME";
            this.lblQuant.DisplayMember = "NAME";
            this.lblQuant.Location = new System.Drawing.Point(99, 45);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(191, 20);
            this.lblQuant.Text = "×Ê²ú±àºÅ";
            this.lblQuant.ZIndex = 1;
            // 
            // lblInUse
            // 
            this.lblInUse.DataMember = "QUANTITY";
            this.lblInUse.DisplayMember = "QUANTITY";
            this.lblInUse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.lblInUse.Location = new System.Drawing.Point(99, 65);
            this.lblInUse.Name = "lblInUse";
            this.lblInUse.Size = new System.Drawing.Size(191, 20);
            this.lblInUse.Text = "×Ê²ú±àºÅ";
            this.lblInUse.ZIndex = 1;
            // 
            // QuantShowLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Panel1});
            this.Size = new System.Drawing.Size(300, 90);
            this.Name = "QuantShowLayout";

        }
        #endregion

        internal Smobiler.Core.Controls.Panel Panel1;
        private Smobiler.Core.Controls.Label lblLocation;
        private Smobiler.Core.Controls.Label lblASSID;
        private Smobiler.Core.Controls.Label Label1;
        private Smobiler.Core.Controls.Label Label2;
        private Smobiler.Core.Controls.Label Label3;
        private Smobiler.Core.Controls.Label lblQuant;
        private Smobiler.Core.Controls.Label lblInUse;
    }
}