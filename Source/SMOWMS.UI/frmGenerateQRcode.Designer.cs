
namespace SMOWMS.UI
{
    partial class frmGenerateQRcode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenerateQRcode));
            this.qrcodeControl = new Smobiler.Utility.Encoding.Windows.Forms.QrCodeImgControl();
            this.Label1 = new System.Windows.Forms.Label();
            this.labTCPPort = new System.Windows.Forms.Label();
            this.labHTTPPort = new System.Windows.Forms.Label();
            this.txtNetAddress = new System.Windows.Forms.TextBox();
            this.txtTcpPort = new System.Windows.Forms.TextBox();
            this.txtHTTPPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerateQRcode = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.qrcodeControl)).BeginInit();
            this.SuspendLayout();
            // 
            // qrcodeControl
            // 
            this.qrcodeControl.ErrorCorrectLevel = Smobiler.Utility.Encoding.ErrorCorrectionLevel.M;
            this.qrcodeControl.Image = ((System.Drawing.Image)(resources.GetObject("qrcodeControl.Image")));
            this.qrcodeControl.Location = new System.Drawing.Point(12, 119);
            this.qrcodeControl.Name = "qrcodeControl";
            this.qrcodeControl.QuietZoneModule = Smobiler.Utility.Encoding.Windows.Render.QuietZoneModules.Two;
            this.qrcodeControl.Size = new System.Drawing.Size(306, 276);
            this.qrcodeControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.qrcodeControl.TabIndex = 20;
            this.qrcodeControl.TabStop = false;
            this.qrcodeControl.Text = "lgdY7aMX70DtIt/TmG1ANg==";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(10, 35);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(65, 12);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "服务器地址";
            // 
            // labTCPPort
            // 
            this.labTCPPort.AutoSize = true;
            this.labTCPPort.Location = new System.Drawing.Point(10, 62);
            this.labTCPPort.Name = "labTCPPort";
            this.labTCPPort.Size = new System.Drawing.Size(47, 12);
            this.labTCPPort.TabIndex = 14;
            this.labTCPPort.Text = "TCP端口";
            // 
            // labHTTPPort
            // 
            this.labHTTPPort.AutoSize = true;
            this.labHTTPPort.Location = new System.Drawing.Point(183, 62);
            this.labHTTPPort.Name = "labHTTPPort";
            this.labHTTPPort.Size = new System.Drawing.Size(53, 12);
            this.labHTTPPort.TabIndex = 13;
            this.labHTTPPort.Text = "HTTP端口";
            // 
            // txtNetAddress
            // 
            this.txtNetAddress.BackColor = System.Drawing.Color.White;
            this.txtNetAddress.Location = new System.Drawing.Point(81, 32);
            this.txtNetAddress.Name = "txtNetAddress";
            this.txtNetAddress.Size = new System.Drawing.Size(237, 21);
            this.txtNetAddress.TabIndex = 2;
            // 
            // txtTcpPort
            // 
            this.txtTcpPort.BackColor = System.Drawing.Color.White;
            this.txtTcpPort.Location = new System.Drawing.Point(81, 59);
            this.txtTcpPort.Name = "txtTcpPort";
            this.txtTcpPort.Size = new System.Drawing.Size(76, 21);
            this.txtTcpPort.TabIndex = 3;
            // 
            // txtHTTPPort
            // 
            this.txtHTTPPort.BackColor = System.Drawing.Color.White;
            this.txtHTTPPort.Location = new System.Drawing.Point(242, 59);
            this.txtHTTPPort.Name = "txtHTTPPort";
            this.txtHTTPPort.Size = new System.Drawing.Size(76, 21);
            this.txtHTTPPort.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 23;
            this.label2.Text = "名称";
            // 
            // btnGenerateQRcode
            // 
            this.btnGenerateQRcode.Location = new System.Drawing.Point(12, 86);
            this.btnGenerateQRcode.Name = "btnGenerateQRcode";
            this.btnGenerateQRcode.Size = new System.Drawing.Size(306, 23);
            this.btnGenerateQRcode.TabIndex = 25;
            this.btnGenerateQRcode.Text = "生成二维码";
            this.btnGenerateQRcode.UseVisualStyleBackColor = true;
            this.btnGenerateQRcode.Click += new System.EventHandler(this.btnGenerateQRcode_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(81, 8);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(237, 21);
            this.txtName.TabIndex = 1;
            // 
            // frmGenerateQRcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 407);
            this.Controls.Add(this.btnGenerateQRcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtHTTPPort);
            this.Controls.Add(this.txtTcpPort);
            this.Controls.Add(this.txtNetAddress);
            this.Controls.Add(this.labHTTPPort);
            this.Controls.Add(this.labTCPPort);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.qrcodeControl);
            this.Name = "frmGenerateQRcode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "生成二维码";
            ((System.ComponentModel.ISupportInitialize)(this.qrcodeControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Smobiler.Utility.Encoding.Windows.Forms.QrCodeImgControl qrcodeControl;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label labTCPPort;
        internal System.Windows.Forms.Label labHTTPPort;
        internal System.Windows.Forms.TextBox txtNetAddress;
        internal System.Windows.Forms.TextBox txtTcpPort;
        internal System.Windows.Forms.TextBox txtHTTPPort;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerateQRcode;
        internal System.Windows.Forms.TextBox txtName;
    }
}
