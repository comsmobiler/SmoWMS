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
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        /// <summary>
        /// 编辑盘点单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Press(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                Form.Toast(ex.Message);
            }
        }
        /// <summary>
        /// 删除盘点单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Press(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("你确定要删除该盘点单吗?", "系统提醒", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
                {
                    try
                    {
                        if (args.Result == ShowResult.OK)     //删除该盘点单
                        {
                            ReturnInfo rInfo = _autofacConfig.ConInventoryService.DeleteInventory(lblName.BindDataValue.ToString());
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
            catch (Exception ex)
            {
                Form.Toast(ex.Message);
            }
        }
        /// <summary>
        /// 开始盘点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Press(object sender, EventArgs e)
        {
            try
            {
                AddCIResultInputDto inputDto = new AddCIResultInputDto {
                    IID = lblName.BindDataValue.ToString(),
                    UserId=Client.Session["UserID"].ToString()
                };
                var inventory = _autofacConfig.ConInventoryService.GetConInventoryById(lblName.BindDataValue.ToString());
                ReturnInfo returnInfo = _autofacConfig.ConInventoryService.AddConInventoryResult(inputDto);
                if (returnInfo.IsSuccess)
                {
                    frmConInventoryResult result = new frmConInventoryResult();
                    result.IID = lblName.BindDataValue.ToString();
                    result.lblWareHouse.Tag = inventory.WAREID;
                    Form.Show(result, (MobileForm sender1, object args) =>
                    {
                        ((frmConInventory)Form).Bind();
                    });
                }
                else
                {
                    throw new Exception(returnInfo.ErrorInfo);
                }

            }
            catch (Exception ex)
            {
                Form.Toast(ex.Message);
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
                var inventory = _autofacConfig.ConInventoryService.GetConInventoryById(lblName.BindDataValue.ToString());
                frmConInventoryResult result = new frmConInventoryResult();
                result.IID = lblName.BindDataValue.ToString();
                result.lblWareHouse.Tag = inventory.WAREID;
                Form.Show(result);
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}