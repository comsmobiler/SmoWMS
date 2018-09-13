using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.DTOs.Enum;
using SMOWMS.CommLib;
using SMOWMS.UI.MasterData;

namespace SMOWMS.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class svEnable : Smobiler.Core.Controls.MobileUserControl
    {
        private AutofacConfig autofacConfig = new AutofacConfig();//调用配置类
        public svEnable() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
        /// <summary>
        /// 启用/禁用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnable_Press(object sender, EventArgs e)
        {
            switch (Parent.Parent.ToString())
            {
                case "SMOWMS.UI.Layout.frmATFirstLevelLayout":
                    if (((frmATFirstLevelLayout)Parent.Parent).ISENABLE == (int)IsEnable.启用)
                    {
                        MessageBox.Show("你确定要禁用该分类吗?", "系统提醒", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
                        {
                            try
                            {
                                if (args.Result == ShowResult.OK)     //禁用该分类
                                {
                                    ReturnInfo rInfo = autofacConfig.assTypeService.ChangeEnable(((frmATFirstLevelLayout)Parent.Parent).TYPEID, IsEnable.禁用);
                                    if (rInfo.IsSuccess)
                                    {
                                        if (Parent.Parent.Form.ToString() == "SMOWMS.UI.MasterData.frmAssetsTypeFirstLevel")
                                        {
                                            ((frmAssetsTypeFirstLevel)Form).Bind();       //页面刷新
                                        }
                                        else
                                        {
                                            ((frmAssetsTypeSecondLevel)Form).Bind();       //页面刷新
                                        }
                                        Toast("禁用分类成功");
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
                    else
                    {
                        MessageBox.Show("你确定要启用该分类吗?", "系统提醒", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
                        {
                            try
                            {
                                if (args.Result == ShowResult.OK)     //启用该分类
                                {
                                    ReturnInfo rInfo = autofacConfig.assTypeService.ChangeEnable(((frmATFirstLevelLayout)Parent.Parent).TYPEID, IsEnable.启用);
                                    if (rInfo.IsSuccess)
                                    {
                                        if (Parent.Parent.Form.ToString() == "SMOWMS.UI.MasterData.frmAssetsTypeFirstLevel")
                                        {
                                            ((frmAssetsTypeFirstLevel)Form).Bind();       //页面刷新
                                        }
                                        else
                                        {
                                            ((frmAssetsTypeSecondLevel)Form).Bind();       //页面刷新
                                        }
                                        Toast("启用分类成功");
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
                    break;
                case "SMOWMS.UI.Layout.frmATThirdLayout":
                    if (((frmATThirdLayout)Parent.Parent).ISENABLE == (int)IsEnable.启用)
                    {
                        MessageBox.Show("你确定要禁用该分类吗?", "系统提醒", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
                        {
                            try
                            {
                                if (args.Result == ShowResult.OK)     //禁用该分类
                                {
                                    ReturnInfo rInfo = autofacConfig.assTypeService.ChangeEnable(((frmATThirdLayout)Parent.Parent).TYPEID, IsEnable.禁用);
                                    if (rInfo.IsSuccess)
                                    {
                                        ((frmAssetsTypeThirdLevel)Form).Bind();       //页面刷新
                                        Toast("禁用分类成功");
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
                    else
                    {
                        MessageBox.Show("你确定要启用该分类吗?", "系统提醒", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
                        {
                            try
                            {
                                if (args.Result == ShowResult.OK)     //启用该分类
                                {
                                    ReturnInfo rInfo = autofacConfig.assTypeService.ChangeEnable(((frmATThirdLayout)Parent.Parent).TYPEID, IsEnable.启用);
                                    if (rInfo.IsSuccess)
                                    {

                                        ((frmAssetsTypeThirdLevel)Form).Bind();       //页面刷新
                                        Toast("启用分类成功");
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
                    break;
                case "SMOWMS.UI.Layout.frmWHLayout":
                    if (((frmWHLayout)Parent.Parent).ISENABLE == (int)IsEnable.启用)
                    {
                        MessageBox.Show("你确定要禁用该仓库吗?", "系统提醒", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
                        {
                            try
                            {
                                if (args.Result == ShowResult.OK)     //禁用该仓库
                                {
                                    ReturnInfo rInfo = autofacConfig.wareHouseService.ChangeEnable(((frmWHLayout)Parent.Parent).WAREID, null, null, IsEnable.禁用);
                                    if (rInfo.IsSuccess)
                                    {
                                        ((frmWH)Form).Bind();       //页面刷新
                                        Toast("禁用仓库成功");
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
                    else
                    {
                        MessageBox.Show("你确定要启用该仓库吗?", "系统提醒", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
                        {
                            try
                            {
                                if (args.Result == ShowResult.OK)     //启用该仓库
                                {
                                    ReturnInfo rInfo = autofacConfig.wareHouseService.ChangeEnable(((frmWHLayout)Parent.Parent).WAREID, null, null, IsEnable.启用);
                                    if (rInfo.IsSuccess)
                                    {

                                        ((frmWH)Form).Bind();       //页面刷新
                                        Toast("启用仓库成功");
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
                    break;
                case "SMOWMS.UI.Layout.frmWHSTLayout":
                    if (((frmWHSTLayout)Parent.Parent).ISENABLE == (int)IsEnable.启用)
                    {
                        MessageBox.Show("你确定要禁用该存储类型吗?", "系统提醒", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
                        {
                            try
                            {
                                if (args.Result == ShowResult.OK)     //禁用该存储类型
                                {
                                    ReturnInfo rInfo = autofacConfig.wareHouseService.ChangeEnable(((frmWHStorgageType)Form).WAREID, ((frmWHSTLayout)Parent.Parent).STID, null, IsEnable.禁用);
                                    if (rInfo.IsSuccess)
                                    {
                                        ((frmWHStorgageType)Form).Bind();       //页面刷新
                                        Toast("禁用存储类型成功");
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
                    else
                    {
                        MessageBox.Show("你确定要启用该存储类型吗?", "系统提醒", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
                        {
                            try
                            {
                                if (args.Result == ShowResult.OK)     //启用该存储类型
                                {
                                    ReturnInfo rInfo = autofacConfig.wareHouseService.ChangeEnable(((frmWHStorgageType)Form).WAREID, ((frmWHSTLayout)Parent.Parent).STID, null, IsEnable.启用);
                                    if (rInfo.IsSuccess)
                                    {

                                        ((frmWHStorgageType)Form).Bind();       //页面刷新
                                        Toast("启用存储类型成功");
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
                    break;
                case "SMOWMS.UI.Layout.frmWHSLLayout":
                    if (((frmWHSLLayout)Parent.Parent).ISENABLE == (int)IsEnable.启用)
                    {
                        MessageBox.Show("你确定要禁用该库位吗?", "系统提醒", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
                        {
                            try
                            {
                                if (args.Result == ShowResult.OK)     //禁用该库位
                                {
                                    ReturnInfo rInfo = autofacConfig.wareHouseService.ChangeEnable(((frmWHStorageLocation)Form).WAREID, ((frmWHStorageLocation)Form).STID,((frmWHSLLayout)Parent.Parent).SLID, IsEnable.禁用);
                                    if (rInfo.IsSuccess)
                                    {
                                        ((frmWHStorageLocation)Form).Bind();       //页面刷新
                                        Toast("禁用库位成功");
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
                    else
                    {
                        MessageBox.Show("你确定要启用该库位吗?", "系统提醒", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
                        {
                            try
                            {
                                if (args.Result == ShowResult.OK)     //启用该库位
                                {
                                    ReturnInfo rInfo = autofacConfig.wareHouseService.ChangeEnable(((frmWHStorageLocation)Form).WAREID, ((frmWHStorageLocation)Form).STID, ((frmWHSLLayout)Parent.Parent).SLID, IsEnable.启用);
                                    if (rInfo.IsSuccess)
                                    {

                                        ((frmWHStorageLocation)Form).Bind();       //页面刷新
                                        Toast("启用库位成功");
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
                    break;
            }
        }
    }
}