namespace SMOWMS.UI.Layout
{
    partial class frmAssetsExLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public frmAssetsExLayout()
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
            this.imgPicture = new Smobiler.Core.Controls.Image();
            this.lblName = new Smobiler.Core.Controls.Label();
            this.lblID = new Smobiler.Core.Controls.Label();
            this.lblPrice = new Smobiler.Core.Controls.Label();
            this.Label16 = new Smobiler.Core.Controls.Label();
            this.checkBox1 = new Smobiler.Core.Controls.CheckBox();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            // 
            // plRow
            // 
            this.plRow.BackColor = System.Drawing.Color.White;
            this.plRow.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plRow.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imgPicture,
            this.lblName,
            this.lblID,
            this.lblPrice,
            this.Label16,
            this.checkBox1,
            this.label1,
            this.label2});
            this.plRow.Name = "plRow";
            this.plRow.Size = new System.Drawing.Size(300, 90);
            this.plRow.Touchable = true;
            this.plRow.Press += new System.EventHandler(this.touchPanel1_Press);
            // 
            // imgPicture
            // 
            this.imgPicture.DataMember = "Image";
            this.imgPicture.DisplayMember = "Image";
            this.imgPicture.Location = new System.Drawing.Point(32, 5);
            this.imgPicture.Name = "imgPicture";
            this.imgPicture.Size = new System.Drawing.Size(80, 80);
            this.imgPicture.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            this.imgPicture.ZIndex = 1;
            // 
            // lblName
            // 
            this.lblName.DataMember = "Name";
            this.lblName.DisplayMember = "Name";
            this.lblName.Location = new System.Drawing.Point(112, 25);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.lblName.Size = new System.Drawing.Size(178, 20);
            this.lblName.Text = "ìÅ²ÊÆ¤·ô";
            this.lblName.ZIndex = 1;
            // 
            // lblID
            // 
            this.lblID.DataMember = "AssId";
            this.lblID.DisplayMember = "AssId";
            this.lblID.Location = new System.Drawing.Point(112, 5);
            this.lblID.Name = "lblID";
            this.lblID.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.lblID.Size = new System.Drawing.Size(178, 20);
            this.lblID.Text = "001";
            this.lblID.ZIndex = 1;
            // 
            // lblPrice
            // 
            this.lblPrice.DataMember = "Price";
            this.lblPrice.DisplayMember = "Price";
            this.lblPrice.FontSize = 10F;
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.lblPrice.Location = new System.Drawing.Point(152, 45);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(138, 20);
            this.lblPrice.Text = "40Ôª";
            this.lblPrice.ZIndex = 1;
            // 
            // Label16
            // 
            this.Label16.FontSize = 10F;
            this.Label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.Label16.Location = new System.Drawing.Point(112, 45);
            this.Label16.Name = "Label16";
            this.Label16.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.Label16.Size = new System.Drawing.Size(40, 20);
            this.Label16.Text = "½ð¶î";
            this.Label16.ZIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.DataMember = "IsChecked";
            this.checkBox1.DisplayMember = "IsChecked";
            this.checkBox1.Location = new System.Drawing.Point(7, 35);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(22, 22);
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.FontSize = 10F;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label1.Location = new System.Drawing.Point(112, 65);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.Text = "¿âÎ»";
            this.label1.ZIndex = 1;
            // 
            // label2
            // 
            this.label2.DataMember = "SLName";
            this.label2.DisplayMember = "SLName";
            this.label2.FontSize = 10F;
            this.label2.Location = new System.Drawing.Point(152, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.Text = "ìÅ²ÊÆ¤·ô";
            this.label2.ZIndex = 1;
            // 
            // frmAssetsExLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plRow});
            this.Size = new System.Drawing.Size(300, 90);
            this.Name = "frmAssetsExLayout";

        }
        #endregion

        private Smobiler.Core.Controls.Panel plRow;
        private Smobiler.Core.Controls.Image imgPicture;
        private Smobiler.Core.Controls.Label lblName;
        private Smobiler.Core.Controls.Label lblID;
        private Smobiler.Core.Controls.Label lblPrice;
        private Smobiler.Core.Controls.Label Label16;
        private Smobiler.Core.Controls.CheckBox checkBox1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label2;
    }
}