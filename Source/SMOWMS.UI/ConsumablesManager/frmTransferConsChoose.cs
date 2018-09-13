using System;
using Smobiler.Core.Controls;
using SMOWMS.DTOs.InputDTO;
using System.Data;
using SMOWMS.UI.Layout;
using System.Collections.Generic;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.OutputDTO;

namespace SMOWMS.UI.ConsumablesManager
{
    partial class frmTransferConsChoose : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public List<ConsumablesOrderRow> RowData = new List<ConsumablesOrderRow>();    //未开启SN行项
        public String LocInID;           //调入区域编号
        #endregion
        /// <summary>
        /// 根据名称进行查询耗材
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            Bind(txtName.Text);
        }
        /// <summary>
        /// 全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Checkall_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewRow Row in ListCons.Rows)
                {
                    frmConsLayout Layout = Row.Control as frmConsLayout;
                    Layout.setCheck(Checkall.Checked);
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
                                        //if (tpvAssets.PageIndex == 0)
                                        //{
            foreach (ListViewRow Row in ListCons.Rows)
            {
                frmConsLayout Layout = Row.Control as frmConsLayout;
                selectQty += Layout.checkNum();
            }
            if (selectQty == ListCons.Rows.Count)
                Checkall.Checked = true;          //选中所有行项时
            else
                Checkall.Checked = false;        //没有选中所有行项
        }
        /// <summary>
        /// 选择耗材完毕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Press(object sender, EventArgs e)
        {
            if (RowData.Count > 0) RowData.Clear();
            foreach (ListViewRow Row in ListCons.Rows)
            {
                frmConsLayout Layout = Row.Control as frmConsLayout;
                if (Layout.getData() != null)
                {
                    RowData.Add(Layout.getData());     //添加未开启SN资产信息
                }
            }
            ShowResult = ShowResult.Yes;
            Form.Close();       //关闭当前页面
        }
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssetsChoose_Load(object sender, EventArgs e)
        {
            Bind(null);
            upCheckState();      //更新全选框状态
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
                tableAssets.Columns.Add("NAME");               //资产名称 
                tableAssets.Columns.Add("LOCID");              //   仓库/存储类型/库位
                tableAssets.Columns.Add("LOCNAME");            //   仓库名称/类型名称/库位名称
                tableAssets.Columns.Add("IMAGE");              //图片编号
                tableAssets.Columns.Add("QUANTITY");           //空闲数量
                tableAssets.Columns.Add("SELECTQTY");          //选择数量

                string[] LCData = LocInID.Split('/');
                List<ConQuantOutputDto> listAss = new List<ConQuantOutputDto>();
                if (String.IsNullOrEmpty(Name))     //查询所有耗材
                    listAss = autofacConfig.orderCommonService.GetUnUseCon(LCData[0], LCData[1], LCData[2], null);
                else
                {
                    List<Consumables> cons = autofacConfig.consumablesService.GetConsByName(Name);
                    foreach (Consumables con in cons)
                    {
                        List<ConQuantOutputDto> list = autofacConfig.orderCommonService.GetUnUseCon(LCData[0], LCData[1], LCData[2], con.CID);
                        listAss.AddRange(list);
                    }
                }
                foreach (ConQuantOutputDto Row in listAss)
                {
                    Consumables cons = autofacConfig.consumablesService.GetConsById(Row.CID);
                    WHStorageLocationOutputDto WHLoc = autofacConfig.wareHouseService.GetSLByID(Row.WAREID, Row.STID, Row.SLID);
                    if (RowData.Count > 0)
                    {
                        Boolean isAdd = false;
                        foreach (ConsumablesOrderRow HaveRow in RowData)
                        {
                            if (HaveRow.CID == Row.CID && HaveRow.WAREID == Row.WAREID 
                                && HaveRow.STID == Row.STID && HaveRow.SLID == Row.SLID)
                            {
                                tableAssets.Rows.Add(true, Row.CID, cons.NAME, Row.WAREID + "/" + Row.STID + "/" + Row.SLID, Row.WARENAME + "/" + Row.STNAME + "/" + Row.SLNAME, cons.IMAGE, Row.QUANTITY, HaveRow.QTY);
                                isAdd = true;
                                break;
                            }
                        }
                        if (isAdd == false)
                            tableAssets.Rows.Add(false, Row.CID, cons.NAME, Row.WAREID + "/" + Row.STID + "/" + Row.SLID, Row.WARENAME + "/" + Row.STNAME + "/" + Row.SLNAME, cons.IMAGE, Row.QUANTITY, 0);
                    }
                    else
                    {
                        tableAssets.Rows.Add(false, Row.CID, cons.NAME, Row.WAREID + "/" + Row.STID + "/" + Row.SLID, Row.WARENAME + "/" + Row.STNAME + "/" + Row.SLNAME, cons.IMAGE, Row.QUANTITY, 0);
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
    }
}