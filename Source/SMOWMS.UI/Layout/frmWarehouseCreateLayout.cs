using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.CommLib;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.UI.MasterData;

namespace SMOWMS.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmWarehouseCreateLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region
        public String WareID;    //仓库编号
        public Boolean isCreate;     //页面是否为创建状态
        public Boolean isEdit;       //页面是否为编辑状态
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
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
                if (String.IsNullOrEmpty(txtWareID.Text)) throw new Exception("仓库编号不能为空");
                if (String.IsNullOrEmpty(txtWareName.Text)) throw new Exception("仓库名称不能为空");
                if (btnManager.Tag==null) throw new Exception("负责人不能为空");

                WareHouseInputDto inputDto = new WareHouseInputDto
                {
                    WAREID = txtWareID.Text,
                    ISENABLE = switchIsEnable.Checked ? 1 : 0,
                    NAME = txtWareName.Text,
                    MANAGER = btnManager.Tag.ToString(),
                    PLACE = txtPlace.Text,
                    MODIFYUSER = Client.Session["UserID"].ToString()
                };
                if (isCreate)
                {
                    inputDto.CREATEUSER = Client.Session["UserID"].ToString();
                    //添加
                    ReturnInfo rInfo = autofacConfig.wareHouseService.AddWareHouse(inputDto);
                    if (rInfo.IsSuccess)
                    {
                        this.Close();
                        Toast("创建仓库成功");
                        //刷新页面数据
                        ((frmWH)Form).Bind();
                    }
                    else
                    {
                        throw new Exception(rInfo.ErrorInfo);
                    }
                }
                else if(isEdit)
                {
                    //编辑
                    ReturnInfo rInfo = autofacConfig.wareHouseService.UpdateWareHouse(inputDto);
                    if (rInfo.IsSuccess)
                    {
                        this.Close();
                        Toast("编辑仓库成功");
                        //刷新页面数据
                        ((frmWHStorgageType)Form).Bind();
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
        private void frmWarehouseCreateLayout_Load(object sender, EventArgs e)
        {
            try
            {
                if (isEdit)
                {
                    WareHouse wareHouse = autofacConfig.wareHouseService.GetByWareID(WareID);
                    txtWareID.Text = wareHouse.WAREID;
                    txtWareID.ReadOnly = true;
                    txtWareName.Text = wareHouse.NAME;
                    btnManager.Tag = wareHouse.MANAGER;
                    txtPlace.Text = wareHouse.PLACE;
                    switchIsEnable.Checked = wareHouse.ISENABLE == 1 ? true : false;
                    coreUser user = autofacConfig.coreUserService.GetUserByID(wareHouse.MANAGER);
                    btnManager.Text = user.USER_NAME + "   > ";
                }
                else if(isCreate)
                {
                    btnManager.Text ="   > ";
                    switchIsEnable.Checked = true;
                }
            }
            catch (Exception ex)
            {
                Form.Toast(ex.Message);
            }
        }

        private void btnManager_Press(object sender, EventArgs e)
        {
            try
            {
                popMan.Groups.Clear();
                PopListGroup manGroup = new PopListGroup { Title = "负责人选择" };
                List<coreUser> users = autofacConfig.coreUserService.GetDealInAdmin();
                foreach (coreUser Row in users)
                {
                    manGroup.AddListItem(Row.USER_NAME, Row.USER_ID);
                }
                popMan.Groups.Add(manGroup);
                if (btnManager.Tag!=null)   //如果已有选中项，则显示选中效果
                {
                    foreach (PopListItem Item in manGroup.Items)
                    {
                        if (Item.Value == btnManager.Tag.ToString())
                            popMan.SetSelections(Item);
                    }
                }
                popMan.ShowDialog();

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void popMan_Selected(object sender, EventArgs e)
        {
            try
            {
                if (popMan.Selection != null)
                {
                    btnManager.Text = popMan.Selection.Text + "   > ";
                    btnManager.Tag = popMan.Selection.Value;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}