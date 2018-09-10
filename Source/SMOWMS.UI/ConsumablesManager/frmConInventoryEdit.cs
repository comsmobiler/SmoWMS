using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.CommLib;

namespace SMOWMS.UI.ConsumablesManager
{
    partial class frmConInventoryEdit : Smobiler.Core.Controls.MobileForm
    {
        #region  定义变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类

        public string IID;
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmConInventoryEdit_Load(object sender, EventArgs e)
        {
            try
            {
                String UserId = Client.Session["UserID"].ToString();
                var assInventory = _autofacConfig.ConInventoryService.GetConInventoryById(IID);
                txtName.Text = assInventory.NAME;
                btnManager.Text = assInventory.HANDLEMANNAME + "   > ";
                btnManager.Tag = assInventory.HANDLEMAN;
                btnWareHouse.Text = assInventory.WARENAME + "   > ";
                btnWareHouse.Tag = assInventory.WAREID;
                if (string.IsNullOrEmpty(assInventory.STID) == false)
                {
                    btnST.Text = assInventory.STNAME + "   > ";
                    btnST.Tag = assInventory.STID;
                }
                if (string.IsNullOrEmpty(assInventory.SLID) == false)
                {
                    btnSL.Text = assInventory.SLNAME + "   > ";
                    btnSL.Tag = assInventory.SLID;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 区域选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLocation_Press(object sender, EventArgs e)
        {
            try
            {
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
                    foreach (PopListItem Item in poli.Items)
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
                foreach (WHStorageType Row in WHST)
                {
                    poliST.AddListItem(Row.NAME, Row.STID);
                }
                if (btnST.Tag != null)   //如果已有选中项，则显示选中效果
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
                List<WHStorageLocation> WHSL = _autofacConfig.wareHouseService.GetSLByWareIDAndSTID(btnWareHouse.Tag.ToString(), btnST.Tag.ToString());
                foreach (WHStorageLocation Row in WHSL)
                {
                    poliSL.AddListItem(Row.NAME, Row.SLID);
                }
                if (btnSL.Tag != null)   //如果已有选中项，则显示选中效果
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
        /// 选择区域
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popWareHouse_Selected(object sender, EventArgs e)
        {
            if (popWareHouse.Selection != null && popWareHouse.Selection.Value != btnWareHouse.Tag.ToString())
            {
                if (btnST.Tag != null)
                {
                    MessageBox.Show("更换盘点仓库将会清空所选存储类型和库位,是否更换？", "系统提示", MessageBoxButtons.YesNo, (object sender1, MessageBoxHandlerArgs args) =>
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
                    if (btnSL.Tag != null)
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
        /// 保存盘点修改
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

                AddCIResultInputDto conInventoryInput = new AddCIResultInputDto()
                {
                    IID = IID,
                    HANDLEMAN = btnManager.Tag.ToString(),
                    WAREID = btnWareHouse.Tag.ToString(),
                    UserId = Client.Session["UserID"].ToString(),
                    Name = txtName.Text
                };
                if (btnST.Tag != null)
                    conInventoryInput.STID = btnST.Tag.ToString();
                if (btnSL.Tag != null)
                    conInventoryInput.SLID = btnSL.Tag.ToString();

                ReturnInfo returnInfo = _autofacConfig.ConInventoryService.UpdateInventoryOnly(conInventoryInput);
                if (returnInfo.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    Toast("修改成功");
                    Close();
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
    }
}