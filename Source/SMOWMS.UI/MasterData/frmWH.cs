using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.UI.Layout;
using SMOWMS.Domain.Entity;

namespace SMOWMS.UI.MasterData
{
    partial class frmWH : Smobiler.Core.Controls.MobileForm
    {
        public frmWH() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();//调用配置类
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmWH_Load(object sender, EventArgs e)
        {
            Bind();
        }
        /// <summary>
        /// 数据绑定
        /// </summary>
        internal void Bind()
        {
            List<WareHouse> wareHousList=autofacConfig.wareHouseService.GetAllWareHouse();
            if (wareHousList.Count > 0)
            {
                lvWareHouse.DataSource = wareHousList;
                lvWareHouse.DataBind();
            }
            foreach (ListViewRow Row in lvWareHouse.Rows)
            {
                frmWHLayout Layout = Row.Control as frmWHLayout;
                svEnable svLayout = ((frmWHLayout)Row.Control).svRow.RightControl as svEnable;
                if (Layout.lblNext.BindDataValue.ToString() == "0")
                {
                    svLayout.btnEnable.Text = "启用";
                    svLayout.btnEnable.BackColor = System.Drawing.Color.FromArgb(43, 140, 255);
                    Layout.lblName.ForeColor = System.Drawing.Color.FromArgb(230, 230, 230);
                }
            }
        }
        /// <summary>
        /// 仓库添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plAdd_Press(object sender, EventArgs e)
        {
            frmWarehouseCreateLayout frmWh = new frmWarehouseCreateLayout
            {
                isCreate = true,
                isEdit = false
            };
            ShowDialog(frmWh);
        }
    }
}