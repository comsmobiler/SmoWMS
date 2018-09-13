using System;
using System.Collections.Generic;
using Smobiler.Core.Controls;
using SMOWMS.UI.Layout;
using System.Data;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.InputDTO;

namespace SMOWMS.UI.ConsumablesManager
{
    partial class frmConsChoose : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public List<ConPurAndSaleCreateInputDto> Rows = new List<ConPurAndSaleCreateInputDto>();    //选择耗材编号
        public int type;  // 0-采购，1-销售
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPurchaseConsChoose_Load(object sender, EventArgs e)
        {
            Bind(null);
            upCheckState();      //更新全选框状态
        }
        /// <summary>
        /// 根据名称查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            Bind(txtName.Text);
        }
        /// <summary>
        /// 数据绑定
        /// </summary>
        /// <param name="Name"></param>
        public void Bind(String Name)
        {
            try
            {
                DataTable tableAssets = new DataTable();       //未开启SN的资产列表
                tableAssets.Columns.Add("CHECK");              //资产编号
                tableAssets.Columns.Add("CID");                //耗材编号
                tableAssets.Columns.Add("NAME");               //耗材名称 
                tableAssets.Columns.Add("IMAGE");              //图片编号
                tableAssets.Columns.Add("QUANTPURCHASED");              //预购数量
                tableAssets.Columns.Add("REALPRICE");              //预购价格

                List<Consumables> cons = autofacConfig.consumablesService.GetConsByName(Name);
                foreach (Consumables con in cons)
                {
                    if (Rows.Count > 0)
                    {
                        Boolean isAdd = false;
                        foreach (ConPurAndSaleCreateInputDto Row in Rows)
                        {
                            if (con.CID == Row.CID)
                            {
                                tableAssets.Rows.Add(true, Row.CID, con.NAME, Row.IMAGE, Row.QUANTPURCHASED, Row.REALPRICE);
                                isAdd = true;
                                break;
                            }
                        }
                        if (isAdd == false)
                            tableAssets.Rows.Add(false, con.CID, con.NAME, con.IMAGE, 0, 0);
                    }
                    else
                    {
                        tableAssets.Rows.Add(false, con.CID, con.NAME, con.IMAGE, 0, 0);
                    }
                }

                if (tableAssets.Rows.Count > 0)
                {
                    ListCons.DataSource = tableAssets;
                    ListCons.DataBind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 更新全选状态
        /// </summary>
        public void upCheckState()
        {
            Int32 selectQty = 0;        //当前选择行项数
            foreach (ListViewRow Row in ListCons.Rows)
            {
                frmConsChooseLayout Layout = Row.Control as frmConsChooseLayout;
                selectQty += Layout.checkNum();
            }
            if (selectQty == ListCons.Rows.Count)
                Checkall.Checked = true;          //选中所有行项时
            else
                Checkall.Checked = false;        //没有选中所有行项
        }
        /// <summary>
        /// 全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Checkall_CheckedChanged(object sender, EventArgs e)
        {
            setCheck();
        }
        /// <summary>
        /// 全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plAll_Press(object sender, EventArgs e)
        {
            if (Checkall.Checked)
            {
                Checkall.Checked = false;
            }
            else
            {
                Checkall.Checked = true;
            }
            setCheck();
        }
        /// <summary>
        /// 修改行项选中状态
        /// </summary>
        private void setCheck()
        {
            foreach (ListViewRow Row in ListCons.Rows)
            {
                frmConsChooseLayout Layout = Row.Control as frmConsChooseLayout;
                Layout.setCheck(Checkall.Checked);
            }
        }
        /// <summary>
        /// 耗材选择完毕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
                if (Rows.Count > 0) Rows.Clear();
                foreach (ListViewRow Row in ListCons.Rows)
                {
                    frmConsChooseLayout Layout = Row.Control as frmConsChooseLayout;
                    if (Layout.getData() != null)
                    {
                        Rows.Add(Layout.getData());     //添加选择的耗材编号     
                    }
                }
                ShowResult = ShowResult.Yes;
                Form.Close();       //关闭当前页面
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}