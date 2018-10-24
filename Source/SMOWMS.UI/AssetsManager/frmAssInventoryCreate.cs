using System;
using System.Collections.Generic;
using Smobiler.Core.Controls;
using SMOWMS.CommLib;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.UI.Layout;

namespace SMOWMS.UI.AssetsManager
{
    /// <summary>
    /// 添加盘点单界面
    /// </summary>
    partial class frmAssInventoryCreate : Smobiler.Core.Controls.MobileForm
    {
        #region  定义变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        private string UserId;
        private AssetTypeTree tree = new AssetTypeTree();
        #endregion

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
                if (btnManager.Tag == null) throw new Exception("请选择盘点人！");
                if (btnWareHouse.Tag == null) throw new Exception("请选择仓库！");
                string typeId="";
                string stId="";
                string slId="";
                if (btnType.Tag != null)
                {
                    typeId = btnType.Tag.ToString();
                }
                if (btnST.Tag != null)
                {
                    stId = btnST.Tag.ToString();
                }
                if (btnSL.Tag != null)
                {
                    slId = btnSL.Tag.ToString();
                }

                AssInventoryInputDto assInventoryInput = new AssInventoryInputDto()
                {
                    HANDLEMAN = btnManager.Tag.ToString(),
                    CREATEUSER = UserId,
//                    LOCATIONID = LocationId,
                    TYPEID = typeId,
//                    DEPARTMENTID = DepId,
                    IsEnd = false,
                    MODIFYUSER = UserId,
                    WAREID = btnWareHouse.Tag.ToString(),
                    STID = stId,
                    SLID = slId,
                    NAME = txtName.Text
                };
                ReturnInfo returnInfo = _autofacConfig.AssInventoryService.AddAssInventory(assInventoryInput);
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
                PopListGroup manGroup = new PopListGroup {Title = "盘点人选择"};
                List<coreUser> users = _autofacConfig.coreUserService.GetAll();
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

        /// <summary>
        /// 资产类型选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnType_Press(object sender, EventArgs e)
        {
            try
            {
                ShowDialog(tree, GetType);
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 界面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssInventoryCreate_Load(object sender, EventArgs e)
        {
            try
            {
                UserId = Client.Session["UserID"].ToString();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 盘点人选择后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popMan_Selected(object sender, EventArgs e)
        {
            try
            {
                if (popMan.Selection != null)
                {
                    btnManager.Text = popMan.Selection.Text ;
                    btnManager.Tag = popMan.Selection.Value;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }


        /// <summary>
        /// 资产类型选中后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popType_Selected(object sender, EventArgs e)
        {
            try
            {
                if (popType.Selection != null)
                {
                    btnType.Text = popType.Selection.Text;
                    btnType.Tag = popType.Selection.Value;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void btnST_Press(object sender, EventArgs e)
        {
            try
            {
                if (btnWareHouse.Tag==null)
                {
                    throw new Exception("请先选择仓库！");
                }
                popST.Groups.Clear();
                PopListGroup stGroup = new PopListGroup { Title = "存储类型" };
                var stlist = _autofacConfig.wareHouseService.GetSTByWareID(btnWareHouse.Tag.ToString());
                PopListItem first = new PopListItem
                {
                    Text = "全部",
                    Value = ""
                };
                stGroup.Items.Add(first);
                foreach (var st in stlist)
                {
                    PopListItem item = new PopListItem
                    {
                        Value = st.STID,
                        Text = st.NAME
                    };
                    stGroup.Items.Add(item);
                }
                popST.Groups.Add(stGroup);
                if (btnST.Tag!=null)
                {
                    foreach (PopListItem row in popST.Groups[0].Items)
                    {
                        if (row.Value == btnST.Tag.ToString())
                        {
                            popST.SetSelections(row);
                        }
                    }
                }
                popST.ShowDialog();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void btnSL_Press(object sender, EventArgs e)
        {
            try
            {
                if (btnWareHouse.Tag==null)
                {
                    throw new Exception("请先选择仓库！");
                }
                if (btnST.Tag==null)
                {
                    throw new Exception("请先选择存储类型！");
                }
                popSL.Groups.Clear();
                PopListGroup slGroup = new PopListGroup { Title = "库位" };
                var sllist = _autofacConfig.wareHouseService.GetSLByWareIDAndSTID(btnWareHouse.Tag.ToString(),btnST.Tag.ToString());
                PopListItem first = new PopListItem
                {
                    Text = "全部",
                    Value = ""
                };
                slGroup.Items.Add(first);
                foreach (var sl in sllist)
                {
                    PopListItem item = new PopListItem
                    {
                        Value = sl.SLID,
                        Text = sl.NAME
                    };
                    slGroup.Items.Add(item);
                }
                popSL.Groups.Add(slGroup);
                if (btnSL.Tag!=null)
                {
                    foreach (PopListItem row in popSL.Groups[0].Items)
                    {
                        if (row.Value == btnSL.Tag.ToString())
                        {
                            popSL.SetSelections(row);
                        }
                    }
                }
                popSL.ShowDialog();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void btnWareHouse_Press(object sender, EventArgs e)
        {
            try
            {
                popWH.Groups.Clear();
                PopListGroup whGroup = new PopListGroup { Title = "仓库" };
                var whlist = _autofacConfig.wareHouseService.GetAllWareHouse();

                foreach (var wh in whlist)
                {
                    PopListItem item = new PopListItem
                    {
                        Value = wh.WAREID,
                        Text = wh.NAME
                    };
                    whGroup.Items.Add(item);
                }
                popWH.Groups.Add(whGroup);
                if (btnWareHouse.Tag!=null)
                {
                    foreach (PopListItem row in popWH.Groups[0].Items)
                    {
                        if (row.Value == btnWareHouse.Tag.ToString())
                        {
                            popWH.SetSelections(row);
                        }
                    }
                }
                popWH.ShowDialog();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void popSL_Selected(object sender, EventArgs e)
        {
            try
            {
                if (popSL.Selection != null)
                {
                    btnSL.Text = popSL.Selection.Text;
                    if (btnSL.Tag == null || btnSL.Tag.ToString() != popSL.Selection.Value)
                    {
                        //赋最新的值
                        btnSL.Tag = popSL.Selection.Value;
                    }

                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void popST_Selected(object sender, EventArgs e)
        {
            try
            {
                if (popST.Selection != null)
                {
                    btnST.Text = popST.Selection.Text;
                    if (btnST.Tag == null || btnST.Tag.ToString() != popST.Selection.Value)
                    {

                        popSL.Groups.Clear();
                        btnSL.Tag = null;
                        btnSL.Text = "全部";
                        //赋最新的值
                        btnST.Tag = popST.Selection.Value;
                    }

                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void popWH_Selected(object sender, EventArgs e)
        {
            try
            {
                if (popWH.Selection != null)
                {
                    btnWareHouse.Text = popWH.Selection.Text;
                    if (btnWareHouse.Tag==null||btnWareHouse.Tag.ToString() != popWH.Selection.Value)
                    {
                        //如果之前的选中项和现在的不同,则把相关的选择清空
                        popST.Groups.Clear();
                        popSL.Groups.Clear();
                        btnST.Tag = null;
                        btnSL.Tag = null;
                        btnST.Text = "全部";
                        btnSL.Text = "全部";
                        //给btnWareHouse.Tag赋值最新的值
                        btnWareHouse.Tag = popWH.Selection.Value;
                    }
                    
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void frmAssInventoryCreate_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                Close();
            }
        }

        public void GetType(object sender, EventArgs e)
        {
            btnType.Tag = tree.ID;
            btnType.Text = tree.TypeName; 
        }
    }
}