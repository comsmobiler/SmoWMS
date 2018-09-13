using System;
using System.Windows.Forms;

namespace SMOWMS.UI
{
    public partial class frmGenerateQRcode : Form
    {
        public frmGenerateQRcode()
        {
            InitializeComponent();
        }

        private void btnGenerateQRcode_Click(object sender, EventArgs e)
        {
            try
            {
                qrcodeControl.SetServerInfo(this.txtNetAddress.Text, int.Parse(this.txtTcpPort.Text), int.Parse(this.txtHTTPPort.Text), this.txtName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
