using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.Domain.Entity;
using SMOWMS.UI.Layout;

namespace SMOWMS.UI.MasterData
{
    partial class frmWHStorgageType : Smobiler.Core.Controls.MobileForm
    {
        public frmWHStorgageType() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();//调用配置类
        internal String WAREID;              //仓库编号
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmWHStorgageType_Load(object sender, EventArgs e)
        {
            Bind();
        }
        /// <summary>
        /// 数据绑定
        /// </summary>
        internal void Bind()
        {
            WareHouse wareHouse= autofacConfig.wareHouseService.GetByWareID(WAREID);
            title1.TitleText = wareHouse.NAME;

            List<WHStorageType> WHSTlist = autofacConfig.wareHouseService.GetSTByWareID(WAREID);
            if (WHSTlist.Count > 0)
            {
                lvWHStorageType.DataSource = WHSTlist;
                lvWHStorageType.DataBind();
            }
            foreach (ListViewRow Row in lvWHStorageType.Rows)
            {
                frmWHSTLayout Layout = Row.Control as frmWHSTLayout;
                svEnable svLayout = ((frmWHSTLayout)Row.Control).svRow.RightControl as svEnable;
                if (Layout.lblNext.BindDataValue.ToString() == "0")
                {
                    svLayout.btnEnable.Text = "启用";
                    svLayout.btnEnable.BackColor = System.Drawing.Color.FromArgb(43, 140, 255);
                    Layout.lblName.ForeColor = System.Drawing.Color.FromArgb(230, 230, 230);
                }
            }
        }
        /// <summary>
        /// 新增当前仓库下存储类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plAdd_Press(object sender, EventArgs e)
        {
            frmSTCreateLayout frmSt = new frmSTCreateLayout
            {
                isCreate = true,
                isEdit = false,
                WareID = WAREID
            };
            ShowDialog(frmSt);
        }
        /// <summary>
        /// 编辑当前仓库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plEdit_Press(object sender, EventArgs e)
        {
            DialogOptions dialog = new DialogOptions
            {
                JustifyAlign = LayoutJustifyAlign.Center,
                Padding = new Padding(0)
            };
            frmWarehouseCreateLayout frmWh = new frmWarehouseCreateLayout
            {
                isCreate = false,
                isEdit = true,
                WareID = WAREID
            };
            ShowDialog(frmWh, dialog);
        }
    }
}