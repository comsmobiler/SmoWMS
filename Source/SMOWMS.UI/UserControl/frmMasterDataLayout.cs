using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using Smobiler.Core.Controls;
using SMOWMS.UI.MasterData;
using SMOWMS.DTOs.Enum;

namespace SMOWMS.UI.UserControl
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmMasterDataLayout : Smobiler.Core.Controls.MobileUserControl
    {
        public frmMasterDataLayout() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
        /// <summary>
        /// 资产分类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plAssetsType_Press(object sender, EventArgs e)
        {
            frmAssetsTypeFirstLevel frmAssetsTypeFirstLevel = new frmAssetsTypeFirstLevel();
            this.Form.Show(frmAssetsTypeFirstLevel);
        }
        /// <summary>
        /// 仓库管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plWareHouse_Press(object sender, EventArgs e)
        {
            frmWH frmWarehouse = new frmWH();
            this.Form.Show(frmWarehouse);
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
            this.Form.Show(frmCustomer);
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
            this.Form.Show(frmCustomer);
        }
    }
}