using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.Domain.Entity;
using SMOWMS.UI.MasterData;
using SMOWMS.UI.AssetsManager;
using SMOWMS.UI.ConsumablesManager;

namespace SMOWMS.UI.Menu
{
    partial class frmMenu : Smobiler.Core.Controls.MobileForm
    {
        #region 变量
        private AutofacConfig autofacConfig = new AutofacConfig();//调用配置类
        #endregion
        public frmMenu() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMenu_Load(object sender, EventArgs e)
        {
            //仓库赋值
            popWareHouse.Groups.Clear();       //数据清空
            PopListGroup poliWH = new PopListGroup();
            popWareHouse.Groups.Add(poliWH);
            poliWH.AddListItem("全部仓库",null);
            List<WareHouse> wareHouseList = autofacConfig.wareHouseService.GetAllWareHouse();
            foreach (WareHouse Row in wareHouseList)
            {
                poliWH.AddListItem(Row.NAME, Row.WAREID);
            }
            popWareHouse.SetSelections(popWareHouse.Groups[0].Items[0]);

            //设置菜单栏默认选中项
            menuToolbar.SelectedIndex = 0;
        }
        /// <summary>
        /// 手机自带返回键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMenu_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
                Client.Exit();
        }
        /// <summary>
        /// 选择仓库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWareHouse_Press(object sender, EventArgs e)
        {
            if (btnWareHouse.Tag != null)   //如果已有选中项，则显示选中效果
            {
                foreach (PopListItem Item in popWareHouse.Groups[0].Items)
                {
                    if (Item.Value == btnWareHouse.Tag.ToString())
                        popWareHouse.SetSelections(Item);
                }
            }
            popWareHouse.ShowDialog();
        }
        /// <summary>
        /// 仓库选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popWareHouse_Selected(object sender, EventArgs e)
        {
            if (popWareHouse.Selection != null)
            {
                btnWareHouse.Text = popWareHouse.Selection.Text + "   > ";
                btnWareHouse.Tag = popWareHouse.Selection.Value;
            }
        }
        /// <summary>
        /// 功能界面跳转
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iconMenu_ItemPress(object sender, IconMenuViewItemPressEventArgs e)
        {
            switch (e.Item.Value)
            {
                //资产
                case "Assets":
                    frmAssets frmAssets = new frmAssets();
                    if (btnWareHouse.Tag != null)
                        frmAssets.wareId = btnWareHouse.Tag.ToString();
                    Show(frmAssets);
                    break;
                case "AssTemplate":
                    frmAssTemplate frmAssTemplate = new frmAssTemplate();
                    Show(frmAssTemplate);
                    break;
                case "AssIn":
                    frmAssIn frmAssIn = new frmAssIn();
                    Show(frmAssIn);
                    break;
                case "AssOut":
                    frmAssOut frmAssOut = new frmAssOut();
                    Show(frmAssOut);
                    break;
                case "AssTransfer":
                    frmAssTransferRows frmAssTransferRows = new frmAssTransferRows();
                    Show(frmAssTransferRows);
                    break;
                case "AssInventory":
                    frmAssInventory frmAssInventory = new frmAssInventory();
                    Show(frmAssInventory);
                    break;

                //耗材
                case "ConManage":
                    frmConsumables frmConsumables = new frmConsumables();
                    Show(frmConsumables);
                    break;
                case "ConIn":
                    frmConPORInSto frmConPORInSto = new frmConPORInSto();
                    Show(frmConPORInSto);
                    break;
                case "ConOut":
                    frmConSOROutbound frmConSOROutbound = new frmConSOROutbound();
                    Show(frmConSOROutbound);
                    break;
                case "ConTransfer":
                    frmTransferRows frmTransferRows = new frmTransferRows();
                    Show(frmTransferRows);
                    break;
                case "ConInventory":
                    frmConInventory frmConInventory = new frmConInventory();
                    Show(frmConInventory);
                    break;
            }
        }
    }
}