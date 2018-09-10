using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.CommLib;
using SMOWMS.DTOs.Enum;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.UI.AssetsManager;

namespace SMOWMS.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmAssInventoryLayout : Smobiler.Core.Controls.MobileUserControl
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
                frmAssInventoryEdit edit = new frmAssInventoryEdit {IID = lblName.BindDataValue.ToString() };
                Form.Show(edit, (MobileForm sender1, object args) =>
                    {
                        if (edit.ShowResult == ShowResult.Yes)
                        {
                            ((frmAssInventory)Form).Bind();
                        }

                    }
                );
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
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
                MessageBox.Show("你确定要该盘点单吗?", "系统提醒", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
                {
                    try
                    {
                        if (args.Result == ShowResult.OK)     //删除该盘点单
                        {
                            ReturnInfo rInfo = _autofacConfig.AssInventoryService.DeleteInventory(lblName.BindDataValue.ToString());
                            if (rInfo.IsSuccess)
                            {
                                Toast("删除盘点单成功.");
                                ((frmAssInventory)Form).Bind();
                            }
                            else
                            {
                                throw new Exception(rInfo.ErrorInfo);
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
                Toast(ex.Message);
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
                AddAIResultInputDto inputDto = new AddAIResultInputDto {IID = lblName.BindDataValue.ToString()};
                var inventory=_autofacConfig.AssInventoryService.GetAssInventoryById(lblName.BindDataValue.ToString());
                ReturnInfo returnInfo = _autofacConfig.AssInventoryService.AddAssInventoryResult(inputDto);
                if (returnInfo.IsSuccess)
                {
                    frmAssInventory assets = (frmAssInventory)Form;
                    assets.Bind();
                    frmAssInventoryResult result = new frmAssInventoryResult {IID = lblName.BindDataValue.ToString(), WAREID = inventory.WAREID,DepartmentId = inventory.SLID,typeId = inventory.TYPEID};
                    assets.Show(result, (MobileForm sender1, object args) =>
                    {
                        if (result.ShowResult == ShowResult.Yes|| result.ShowResult == ShowResult.None)
                        {
                            assets.Bind();
                        }
                    });
                }
                else
                {
                    Toast(returnInfo.ErrorInfo);
                }

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 点击，查看盘点单详情
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_Press(object sender, EventArgs e)
        {
            try
            {
                var inventory = _autofacConfig.AssInventoryService.GetAssInventoryById(lblName.BindDataValue.ToString());
                frmAssInventoryResult result = new frmAssInventoryResult { IID = lblName.BindDataValue.ToString(), WAREID = inventory.WAREID, DepartmentId = inventory.SLID, typeId = inventory.TYPEID};
                frmAssInventory frmAssInventory = (frmAssInventory)Form;
                frmAssInventory.Show(result, (MobileForm sender1, object args) =>
                {
                    if (result.ShowResult == ShowResult.Yes|| result.ShowResult == ShowResult.None)
                    {
                        frmAssInventory.Bind();
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