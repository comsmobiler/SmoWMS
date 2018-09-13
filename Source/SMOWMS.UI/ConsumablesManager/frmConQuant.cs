using System;
using System.Data;
using Smobiler.Core.Controls;

namespace SMOWMS.UI.ConsumablesManager
{
    partial class frmConQuant : Smobiler.Core.Controls.MobileForm
    {
        #region 变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        public string CID;
        #endregion
        /// <summary>
        /// 如果按了回退键，则关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmConQuant_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
                Close();
        }

        /// <summary>
        /// 界面初始化时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmConQuant_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = _autofacConfig.consumablesService.GetQuantsEx("","","",CID);
                if (dataTable.Rows.Count > 0)
                {
                    GridView1.DataSource = dataTable;
                    GridView1.DataBind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}