using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;
using System.Drawing;
using SMOWMS.UI.Layout;

namespace SMOWMS.UI.ConsumablesManager
{
    partial class frmConInventory : Smobiler.Core.Controls.MobileForm
    {
        #region  定义变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmConInventory_Load(object sender, EventArgs e)
        {
            Bind();
        }
        /// <summary>
        /// 数据绑定
        /// </summary>
        public void Bind()
        {
            try
            {
                string LocationId = "";
                string UserId = Session["UserID"].ToString();
                if (Client.Session["Role"].ToString() == "SMOWMSAdmin")
                {
                    var user = _autofacConfig.coreUserService.GetUserByID(UserId);
                    LocationId = user.USER_LOCATIONID;
                }

                DataTable assInventoryList = _autofacConfig.ConInventoryService.GetConInventoryList(Client.Session["Role"].ToString() == "SMOWMSUser" ? Client.Session["UserID"].ToString() : "", LocationId);
                listView.Rows.Clear();
                if (assInventoryList.Rows.Count > 0)
                {
                    listView.DataSource = assInventoryList;
                    listView.DataBind();
                }
                foreach (var row in listView.Rows)
                {
                    frmConInventoryLayout layout = (frmConInventoryLayout)row.Control;
                    switch (layout.label1.Text)
                    {
                        case "盘点结束":
                            layout.label1.ForeColor = Color.FromArgb(43, 125, 43);
                            break;
                        case "盘点中":
                            layout.label1.ForeColor = Color.FromArgb(43, 140, 255);
                            layout.btnStart.Text = "继续盘点";
                            break;
                        case "盘点未开始":
                            layout.label1.ForeColor = Color.FromArgb(211, 215, 217);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }
        /// <summary>
        /// 耗材盘点单创建
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Press(object sender, EventArgs e)
        {
            try
            {
                frmConInventoryCreate conInventoryCreate = new frmConInventoryCreate();
                Show(conInventoryCreate, (MobileForm sender1, object args) =>
                {
                    if (conInventoryCreate.ShowResult == ShowResult.Yes)
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
    }
}