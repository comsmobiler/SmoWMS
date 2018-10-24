using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.UI.ConsumablesManager;
using SMOWMS.CommLib;
using SMOWMS.DTOs.InputDTO;

namespace SMOWMS.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmConInventoryLayout : Smobiler.Core.Controls.MobileUserControl
    {
        private AutofacConfig autofacConfig = new AutofacConfig();//调用配置类
        /// <summary>
        /// 盘点单编号
        /// </summary>
        internal string IID
        {
            get
            {
                return this.lblName.BindDataValue.ToString();
            }
        }
        /// <summary>
        /// 点击行项跳转查看详情
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plRow_Press(object sender, EventArgs e)
        {
            try
            {
                var inventory = autofacConfig.ConInventoryService.GetConInventoryById(lblName.BindDataValue.ToString());
                frmConInventoryResult result = new frmConInventoryResult();
                result.IID = lblName.BindDataValue.ToString();
                result.lblWareHouse.Tag = inventory.WAREID;
                Form.Show(result, (MobileForm sender1, object args) =>
                {
                    ((frmConInventory)Form).Bind();
                });
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 盘点单编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ibEdit_Press(object sender, EventArgs e)
        {
            frmConInventoryEdit edit = new frmConInventoryEdit { IID = lblName.BindDataValue.ToString() };
            Form.Show(edit, (MobileForm sender1, object args) =>
            {
                if (edit.ShowResult == ShowResult.Yes)
                {
                    ((frmConInventory)Form).Bind();
                }
            });
        }
    }
}