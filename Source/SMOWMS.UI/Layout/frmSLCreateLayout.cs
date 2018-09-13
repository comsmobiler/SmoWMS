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
    partial class frmSLCreateLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region
        public String WareID;    //仓库编号
        public Boolean isCreate;     //页面是否为创建状态
        public Boolean isEdit;       //页面是否为编辑状态
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public string STID;
        public string SLID;
        #endregion

        /// <summary>
        /// 提交操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtSLID.Text)) throw new Exception("库位编号不能为空");
                if (String.IsNullOrEmpty(txtSLName.Text)) throw new Exception("库位名称不能为空");
                if (btnManager.Tag == null) throw new Exception("负责人不能为空");

                WHStorageLocationInputDto inputDto = new WHStorageLocationInputDto
                {
                    SLID = txtSLID.Text,
                    WAREID = txtWareID.Text,
                    STID = txtSTID.Text,
                    NAME = txtSLName.Text,
                    MANAGER = btnManager.Tag.ToString(),
                    MAXVOLUME = txtMAXVOLUME.Text,
                    MAXCAPACITY = txtMAXCAPACITY.Text,
                    MODIFYUSER = Client.Session["UserID"].ToString()
                };
                if (isCreate)
                {
                    inputDto.CREATEUSER = Client.Session["UserID"].ToString();
                    inputDto.STATUS = 0;
                    //添加
                    ReturnInfo rInfo = autofacConfig.wareHouseService.AddWhStorageLocation(inputDto);
                    if (rInfo.IsSuccess)
                    {
                        this.Close();
                        Toast("创建库位成功");
                        //刷新页面数据
                        ((frmWHStorageLocation)Form).Bind();
                    }
                    else
                    {
                        throw new Exception(rInfo.ErrorInfo);
                    }
                }
                else if (isEdit)
                {
                    //编辑
                    ReturnInfo rInfo = autofacConfig.wareHouseService.UpdateWhStorageLocation(inputDto);
                    if (rInfo.IsSuccess)
                    {
                        this.Close();
                        Toast("编辑库位成功");
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
        /// 关闭当前弹出框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Press(object sender, EventArgs e)
        {
            this.Close();
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
                if (btnManager.Tag != null)   //如果已有选中项，则显示选中效果
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

        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSLCreateLayout_Load(object sender, EventArgs e)
        {
            try
            {
                WHStorageTypeOutputDto whStorageType = autofacConfig.wareHouseService.GetSTByWareIDandSTID(WareID, STID);
                txtWareID.Text = whStorageType.WAREID;
                txtWareID.ReadOnly = true;
                txtWareName.Text = whStorageType.WARENAME;
                txtWareName.ReadOnly = true;
                txtSTID.Text = whStorageType.STID;
                txtSTID.ReadOnly = true;
                txtSTName.Text = whStorageType.NAME;
                txtSTName.ReadOnly = true;
                if (isEdit)
                {
                    WHStorageLocationOutputDto whStorageLocation = autofacConfig.wareHouseService.GetSLByID(WareID, STID, SLID);
                    txtSLID.Text = whStorageLocation.SLID;
                    txtSLID.ReadOnly = true;
                    txtSLName.Text = whStorageLocation.SLNAME;
                    btnManager.Tag = whStorageLocation.MANAGER;
                    btnManager.Text = whStorageLocation.MANAGERNAME + "   > ";
                    txtMAXCAPACITY.Text = whStorageLocation.MAXCAPACITY;
                    txtMAXVOLUME.Text = whStorageLocation.MAXVOLUME;
                }
            }
            catch (Exception ex)
            {
                Form.Toast(ex.Message);
            }
        }
    }
}