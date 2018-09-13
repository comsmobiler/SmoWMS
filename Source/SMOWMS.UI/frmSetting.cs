using System;
using System.Windows.Forms;

namespace SMOWMS.UI
{
    public partial class frmSetting : Form
    {
        private Smobiler.Core.Setting mSetting = null;


        public frmSetting()
        {
            InitializeComponent();
            mSetting = new Smobiler.Core.Setting();
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            try
            {
                this.gridMain.SelectedObject = mSetting;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                mSetting.SaveData();
                if (MessageBox.Show("保存成功，是否重新启动服务", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.Yes;
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
