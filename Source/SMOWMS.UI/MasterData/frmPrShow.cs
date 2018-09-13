using System;
using System.Data;
using Smobiler.Core.Controls;

namespace SMOWMS.UI.MasterData
{
    /// <summary>
    /// 处理记录展示界面
    /// </summary>
    partial class frmPrShow : Smobiler.Core.Controls.MobileForm
    {
        #region 变量
        public string AssId;  //资产编号
        AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        

        #endregion

        /// <summary>
        /// 按回退键，关闭当前界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPRShow_KeyDown(object sender, KeyDownEventArgs e)
        {
            try
            {
                if (e.KeyCode == KeyCode.Back)
                    Close();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 界面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPRShow_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable table = _autofacConfig.SettingService.GetRecords(AssId,"");
                if (table != null)
                {
                    GridView1.DataSource = table;
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