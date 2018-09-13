using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.CommLib;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.DTOs.OutputDTO;
using SMOWMS.UI.MasterData;

namespace SMOWMS.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmSTCreateLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region
        public String WareID;    //仓库编号
        public Boolean isCreate;     //页面是否为创建状态
        public Boolean isEdit;       //页面是否为编辑状态
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public string STID;
        #endregion

        /// <summary>
        /// 关闭当前弹出框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Press(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 提交操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtSTID.Text)) throw new Exception("类型编号不能为空");
                if (String.IsNullOrEmpty(txtSTName.Text)) throw new Exception("类型名称不能为空");

                WHStorageTypeInputDto inputDto = new WHStorageTypeInputDto
                {
                    WAREID = txtWareID.Text,
                    ISENABLE = switchIsEnable.Checked ? 1 : 0,
                    NAME = txtSTName.Text,
                    STID = txtSTID.Text,
                    MODIFYUSER = Client.Session["UserID"].ToString()
                };
                if (isCreate)
                {
                    inputDto.CREATEUSER = Client.Session["UserID"].ToString();
                    //添加
                    ReturnInfo rInfo = autofacConfig.wareHouseService.AddWhStorageType(inputDto);
                    if (rInfo.IsSuccess)
                    {
                        this.Close();
                        Toast("创建仓库类型成功");
                        //刷新页面数据
                        ((frmWHStorgageType)Form).Bind();
                    }
                    else
                    {
                        throw new Exception(rInfo.ErrorInfo);
                    }
                }
                else if (isEdit)
                {
                    //编辑
                    ReturnInfo rInfo = autofacConfig.wareHouseService.UpdateWhStorageType(inputDto);
                    if (rInfo.IsSuccess)
                    {
                        this.Close();
                        Toast("编辑仓库类型成功");
                        //刷新页面数据
                        ((frmWHStorageLocation)Form).Bind();
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
        }

        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSTCreateLayout_Load(object sender, EventArgs e)
        {
            try
            {
                WareHouse wareHouse = autofacConfig.wareHouseService.GetByWareID(WareID);
                if (wareHouse != null)
                {
                    txtWareID.Text = wareHouse.WAREID;
                    txtWareID.ReadOnly = true;
                    txtWareName.Text = wareHouse.NAME;

                }
                txtWareName.ReadOnly = true;
                if (isEdit)
                {
                    WHStorageTypeOutputDto whStorageType = autofacConfig.wareHouseService.GetSTByWareIDandSTID(WareID, STID);
                    txtSTID.Text = whStorageType.STID;
                    txtSTID.ReadOnly = true;
                    txtSTName.Text = whStorageType.NAME;
                    switchIsEnable.Checked = whStorageType.ISENABLE == 1 ? true : false;
                }
                else if (isCreate)
                {
                    switchIsEnable.Checked = true;
                }
            }
            catch (Exception ex)
            {
                Form.Toast(ex.Message);
            }
        }
    }
}