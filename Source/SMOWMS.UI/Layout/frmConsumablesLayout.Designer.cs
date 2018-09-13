namespace SMOWMS.UI.Layout
{
    partial class frmConsumablesLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public frmConsumablesLayout()
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
            this.touchPanel1 = new Smobiler.Core.Controls.Panel();
            this.imgPicture = new Smobiler.Core.Controls.Image();
            this.lblName = new Smobiler.Core.Controls.Label();
            this.lblID = new Smobiler.Core.Controls.Label();
            this.lblPrice = new Smobiler.Core.Controls.Label();
            this.Label16 = new Smobiler.Core.Controls.Label();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            // 
            // touchPanel1
            // 
            this.touchPanel1.BackColor = System.Drawing.Color.White;
            this.touchPanel1.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.touchPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.touchPanel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imgPicture,
            this.lblName,
            this.lblID,
            this.lblPrice,
            this.Label16,
            this.label1,
            this.label2});
            this.touchPanel1.Name = "touchPanel1";
            this.touchPanel1.Size = new System.Drawing.Size(300, 90);
            this.touchPanel1.Touchable = true;
            this.touchPanel1.Press += new System.EventHandler(this.touchPanel1_Press);
            // 
            // imgPicture
            // 
            this.imgPicture.DataMember = "IMAGE";
            this.imgPicture.DisplayMember = "IMAGE";
            this.imgPicture.Location = new System.Drawing.Point(10, 5);
            this.imgPicture.Name = "imgPicture";
            this.imgPicture.Size = new System.Drawing.Size(86, 80);
            this.imgPicture.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            this.imgPicture.ZIndex = 1;
            // 
            // lblName
            // 
            this.lblName.DataMember = "NAME";
            this.lblName.DisplayMember = "NAME";
            this.lblName.Location = new System.Drawing.Point(96, 25);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.lblName.Size = new System.Drawing.Size(185, 20);
            this.lblName.Text = "炫彩皮肤";
            this.lblName.ZIndex = 1;
            // 
            // lblID
            // 
            this.lblID.DataMember = "CID";
            this.lblID.DisplayMember = "CID";
            this.lblID.Location = new System.Drawing.Point(96, 5);
            this.lblID.Name = "lblID";
            this.lblID.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.lblID.Size = new System.Drawing.Size(185, 20);
            this.lblID.Text = "001";
            this.lblID.ZIndex = 1;
            // 
            // lblPrice
            // 
            this.lblPrice.DataMember = "SAFEFLOOR";
            this.lblPrice.DisplayMember = "SAFEFLOOR";
            this.lblPrice.FontSize = 12F;
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.lblPrice.Location = new System.Drawing.Point(202, 45);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(79, 20);
            this.lblPrice.Text = "40元";
            this.lblPrice.ZIndex = 1;
            // 
            // Label16
            // 
            this.Label16.FontSize = 12F;
            this.Label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.Label16.Location = new System.Drawing.Point(96, 45);
            this.Label16.Name = "Label16";
            this.Label16.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.Label16.Size = new System.Drawing.Size(106, 20);
            this.Label16.Text = "安全库存下限";
            this.Label16.ZIndex = 1;
            // 
            // label1
            // 
            this.label1.FontSize = 12F;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label1.Location = new System.Drawing.Point(96, 65);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.Text = "安全库存上限";
            this.label1.ZIndex = 1;
            // 
            // label2
            // 
            this.label2.DataMember = "SAFECEILING";
            this.label2.DisplayMember = "SAFECEILING";
            this.label2.FontSize = 12F;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.label2.Location = new System.Drawing.Point(202, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.Text = "40元";
            this.label2.ZIndex = 1;
            // 
            // frmConsumablesLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.touchPanel1});
            this.Size = new System.Drawing.Size(300, 90);
            this.Name = "frmConsumablesLayout";

        }
        #endregion

        private Smobiler.Core.Controls.Panel touchPanel1;
        private Smobiler.Core.Controls.Image imgPicture;
        private Smobiler.Core.Controls.Label lblName;
        private Smobiler.Core.Controls.Label lblID;
        private Smobiler.Core.Controls.Label lblPrice;
        private Smobiler.Core.Controls.Label Label16;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label2;
    }
}