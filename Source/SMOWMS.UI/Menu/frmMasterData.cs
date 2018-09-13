using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.UI.MasterData;
using SMOWMS.DTOs.Enum;

namespace SMOWMS.UI.Menu
{
    partial class frmMasterData : Smobiler.Core.Controls.MobileForm
    {
        public frmMasterData() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMasterData_Load(object sender, EventArgs e)
        {
            // 设置菜单栏默认选中项
            menuToolbar.SelectedIndex = 2;
        }
        /// <summary>
        /// 手机自带返回键操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMasterData_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
                Client.Exit();
        }
        /// <summary>
        /// 资产分类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plAssetsType_Press(object sender, EventArgs e)
        {
            frmAssetsTypeFirstLevel frmAssetsTypeFirstLevel = new frmAssetsTypeFirstLevel();
            Show(frmAssetsTypeFirstLevel);
        }
        /// <summary>
        /// 仓库管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plWareHouse_Press(object sender, EventArgs e)
        {
            frmWH frmWarehouse = new frmWH();
            Show(frmWarehouse);
        }
        /// <summary>
        /// 客户管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plClient_Press(object sender, EventArgs e)
        {
            frmCustomer frmCustomer = new frmCustomer();
            frmCustomer.unitType = UnitType.客户;
            Show(frmCustomer);
        }
        /// <summary>
        /// 供应商管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plSupplier_Press(object sender, EventArgs e)
        {
            frmCustomer frmCustomer = new frmCustomer();
            frmCustomer.unitType = UnitType.供应商;
            Show(frmCustomer);
        }
    }
}