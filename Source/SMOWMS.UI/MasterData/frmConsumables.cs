using System;
using System.Data;
using Smobiler.Core.Controls;

namespace SMOWMS.UI.MasterData
{
    partial class frmConsumables : Smobiler.Core.Controls.MobileForm
    {
        #region 变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类

        #endregion

        /// <summary>
        /// 跳转到添加耗材
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Press(object sender, EventArgs e)
        {
            try
            {
                frmConsumablesCreate consumablesCreate=new frmConsumablesCreate();
                Show(consumablesCreate, (MobileForm sender1, object args) =>
                {
                    if (consumablesCreate.ShowResult == ShowResult.Yes)
                    {
                        Bind();
                    }
                });
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
        private void frmConsumables_Load(object sender, EventArgs e)
        {
            Bind();
        }
        /// <summary>
        /// 绑定数据
        /// </summary>
        public void Bind()
        {
            try
            {
                DataTable conTable = _autofacConfig.consumablesService.GetConList();
                ListViewCon.Rows.Clear();
                if (conTable.Rows.Count > 0)
                {
                    ListViewCon.DataSource = conTable;
                    ListViewCon.DataBind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}