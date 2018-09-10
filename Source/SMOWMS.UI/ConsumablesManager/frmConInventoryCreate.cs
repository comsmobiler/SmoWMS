using System;
using System.Collections.Generic;
using Smobiler.Core.Controls;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.CommLib;

namespace SMOWMS.UI.ConsumablesManager
{
    partial class frmConInventoryCreate : Smobiler.Core.Controls.MobileForm
    {
        #region  定义变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类

        private string UserId;
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmConInventoryCreate_Load(object sender, EventArgs e)
        {
            try
            {
                UserId = Client.Session["UserID"].ToString();
                if (Client.Session["Role"].ToString() == "SMOWMSAdmin")
                {
                    var user = _autofacConfig.coreUserService.GetUserByID(UserId);
                    String LocationId = user.USER_LOCATIONID;
                    var location = _autofacConfig.wareHouseService.GetByWareID(LocationId);
                    btnWareHouse.Text = location.NAME;
                    btnWareHouse.Tag = LocationId;
                    btnWareHouse.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 仓库选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLocation_Press(object sender, EventArgs e)
        {
            try
            {
                //仓库列表赋值
                popWareHouse.Groups.Clear();       //数据清空
                PopListGroup poli = new PopListGroup();
                popWareHouse.Groups.Add(poli);
                List<WareHouse> WHS = _autofacConfig.wareHouseService.GetAllWareHouse();
                foreach (WareHouse Row in WHS)
                {
                    poli.AddListItem(Row.NAME, Row.WAREID);
                }
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
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 存储类型选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnST_Press(object sender, EventArgs e)
        {
            try
            {
                if (btnWareHouse.Tag == null) throw new Exception("请先选择盘点仓库!");
                //存储类型赋值
                popST.Groups.Clear();       //数据清空
                PopListGroup poliST = new PopListGroup();
                popST.Groups.Add(poliST);
                List<WHStorageType> WHST = _autofacConfig.wareHouseService.GetSTByWareID(btnWareHouse.Tag.ToString());
                poliST.AddListItem("全部", "");
                foreach (WHStorageType Row in WHST)
                {
                    poliST.AddListItem(Row.NAME, Row.STID);
                }
                if(btnST.Tag != null)
                {
                    foreach (PopListItem Item in popST.Groups[0].Items)
                    {
                        if (Item.Value == btnST.Tag.ToString())
                            popST.SetSelections(Item);
                    }
                }              
                popST.ShowDialog();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 库位选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSL_Press(object sender, EventArgs e)
        {
            try
            {
                if (btnWareHouse.Tag == null) throw new Exception("请先选择盘点仓库!");
                if (btnST.Tag == null) throw new Exception("请先选择存储类型!");
                //库位赋值
                popSL.Groups.Clear();       //数据清空
                PopListGroup poliSL = new PopListGroup();
                popSL.Groups.Add(poliSL);
                poliSL.AddListItem("全部", "");
                List<WHStorageLocation> WHSL = _autofacConfig.wareHouseService.GetSLByWareIDAndSTID(btnWareHouse.Tag.ToString(), btnST.Tag.ToString());
                foreach (WHStorageLocation Row in WHSL)
                {
                    poliSL.AddListItem(Row.NAME, Row.SLID);
                }
                if (btnSL.Tag != null)
                {
                    foreach (PopListItem Item in popSL.Groups[0].Items)
                    {
                        if (Item.Value == btnSL.Tag.ToString())
                            popSL.SetSelections(Item);
                    }
                }
                popSL.ShowDialog();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 盘点人选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnManager_Press(object sender, EventArgs e)
        {
            try
            {
                popMan.Groups.Clear();
                PopListGroup manGroup = new PopListGroup { Title = "盘点人选择" };
                List<coreUser> users = _autofacConfig.coreUserService.GetAll();
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
        /// <summary>
        /// 选择盘点人
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popMan_Selected(object sender, EventArgs e)
        {
            if (popMan.Selection != null)
            {
                btnManager.Text = popMan.Selection.Text + "   > ";
                btnManager.Tag = popMan.Selection.Value;
            }
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
                if (btnWareHouse.Tag != null && popWareHouse.Selection.Value != btnWareHouse.Tag.ToString())
                {
                    MessageBox.Show("更换盘点仓库将会清空所选存储类型和库位,是否更换？", "系统提示", MessageBoxButtons.YesNo, (object sender1, MessageBoxHandlerArgs args) =>
                    {
                        try
                        {
                            if (args.Result == ShowResult.Yes)
                            {
                                btnWareHouse.Text = popWareHouse.Selection.Text + "   > ";
                                btnWareHouse.Tag = popWareHouse.Selection.Value;
                                //清空存储类型和库位
                                btnST.Text = "选择（选填）   > ";
                                btnST.Tag = null;
                                btnSL.Text = "选择（选填）   > ";
                                btnSL.Tag = null;
                            }
                        }
                        catch (Exception ex)
                        {
                            Toast(ex.Message);
                        }
                    });
                }
                else
                {
                    btnWareHouse.Text = popWareHouse.Selection.Text + "   > ";
                    btnWareHouse.Tag = popWareHouse.Selection.Value;
                }
            }
        }
        /// <summary>
        /// 选择了存储类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popST_Selected(object sender, EventArgs e)
        {
            if (popST.Selection != null)
            {
                if (btnST.Tag != null && popST.Selection.Value != btnST.Tag.ToString())
                {
                    MessageBox.Show("更换存储类型将会清空所选库位,是否更换？", "系统提示", MessageBoxButtons.YesNo, (object sender1, MessageBoxHandlerArgs args) =>
                    {
                        if (args.Result == ShowResult.Yes)
                        {
                            btnST.Text = popST.Selection.Text + "   > ";
                            btnST.Tag = popST.Selection.Value;
                            //清空库位
                            btnSL.Text = "选择（选填）   > ";
                            btnSL.Tag = null;
                        }
                    });
                }
                else
                {
                    btnST.Text = popST.Selection.Text + "   > ";
                    btnST.Tag = popST.Selection.Value;
                }
            }
        }
        /// <summary>
        /// 选择了库位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popSL_Selected(object sender, EventArgs e)
        {
            if (popSL.Selection != null)
            {
                btnSL.Text = popSL.Selection.Text + "   > ";
                btnSL.Tag = popSL.Selection.Value;
            }
        }
        /// <summary>
        /// 保存盘点单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtName.Text)) throw new Exception("盘点单名称不能为空!");
                if (btnManager.Tag == null) throw new Exception("盘点人不能为空!");
                if (btnWareHouse.Tag == null) throw new Exception("仓库不能为空!");

                ConInventoryInputDto conInventoryInput = new ConInventoryInputDto()
                {
                    HANDLEMAN = btnManager.Tag.ToString(),
                    CREATEUSER = UserId,
                    WAREID = btnWareHouse.Tag.ToString(),
                    IsEnd = false,
                    MODIFYUSER = UserId,
                    NAME = txtName.Text
                };
                if (btnST.Tag != null)
                    conInventoryInput.STID = btnST.Tag.ToString();
                if (btnSL.Tag != null)
                    conInventoryInput.SLID = btnSL.Tag.ToString();

                ReturnInfo returnInfo = _autofacConfig.ConInventoryService.AddConInventory(conInventoryInput);
                if (returnInfo.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    Toast("添加成功");
                    Close();
                }
                else
                {
                    throw new Exception(returnInfo.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}