using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SMOWMS.UI
{
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
        }

        private void btnComfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void frmHelp_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            System.Diagnostics.Process.Start("http://smobiler.com/developers.html");
        }
    }
}
