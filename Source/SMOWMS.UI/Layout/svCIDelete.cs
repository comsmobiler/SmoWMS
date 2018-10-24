using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.CommLib;
using SMOWMS.UI.ConsumablesManager;
using SMOWMS.DTOs.OutputDTO;

namespace SMOWMS.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class svCIDelete : Smobiler.Core.Controls.MobileUserControl
    {
        public svCIDelete() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
        private AutofacConfig autofacConfig = new AutofacConfig();//调用配置类
        /// <summary>
        /// 删除盘点单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelRow_Press(object sender, EventArgs e)
        {
            try
            {
                ConInventoryOutputDto order = autofacConfig.ConInventoryService.GetConInventoryById(((frmConInventoryLayout)Parent.Parent).IID);
                if (order.STATUS == 2)
                {
                    MessageBox.Show("你确定要删除该盘点单吗?", "系统提醒", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
                    {
                        try
                        {
                            if (args.Result == ShowResult.OK)     //删除该盘点单
                            {
                                ReturnInfo rInfo = autofacConfig.ConInventoryService.DeleteInventory(((frmConInventoryLayout)Parent.Parent).IID);
                                if (rInfo.IsSuccess)
                                {
                                    Toast("删除盘点单成功.");
                                    ((frmConInventory)Form).Bind();
                                }
                                else
                                {
                                    Toast(rInfo.ErrorInfo);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Form.Toast(ex.Message);
                        }
                    });
                }
                else
                {
                    throw new Exception("当前状态下无法删除该盘点单");
                }
            }
            catch(Exception ex)
            {
                Form.Toast(ex.Message);
            }
        }
    }
}