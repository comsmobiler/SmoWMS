using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.DTOs.Enum;
using SMOWMS.UI.Layout;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.Domain.Entity;
using SMOWMS.CommLib;
using System.Data;
using SMOWMS.DTOs.OutputDTO;

namespace SMOWMS.UI.ConsumablesManager
{
    partial class frmTransferDeal : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public String TOID;     //调拨单编号
        public PROCESSMODE Type;   //操作类型
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTransferDeal_Load(object sender, EventArgs e)
        {
            Bind();
        }
        /// <summary>
        /// 数据加载
        /// </summary>
        public void Bind()
        {
            try
            {
                if (Type == PROCESSMODE.调拨确认) title1.TitleText = "调拨单确认";
                if (Type == PROCESSMODE.调拨取消) title1.TitleText = "调拨单取消";
                TOInputDto TOData = autofacConfig.assTransferOrderService.GetByID(TOID);
                coreUser DeanInUser = autofacConfig.coreUserService.GetUserByID(TOData.MANAGER);
                coreUser DealUser = autofacConfig.coreUserService.GetUserByID(TOData.HANDLEMAN);
                lblTDInMan.Text = DeanInUser.USER_NAME;
                lblDealMan.Text = DealUser.USER_NAME;
                WHStorageLocationOutputDto whLoc = autofacConfig.wareHouseService.GetSLByID(TOData.WAREID, TOData.STID, TOData.DESSLID);
                lblLocation.Text = whLoc.WARENAME + "/" + whLoc.STNAME + "/" + whLoc.SLNAME;
                DatePicker.Value = TOData.TRANSFERDATE;
                if (String.IsNullOrEmpty(TOData.NOTE)) lblNote.Text = TOData.NOTE;

                DataTable tableAssets = new DataTable();       //未开启SN的资产列表
                tableAssets.Columns.Add("TOROWID");           //报修单行项编号
                tableAssets.Columns.Add("LOCATIONID");         //区域编号
                tableAssets.Columns.Add("LOCATIONNAME");       //区域名称
                tableAssets.Columns.Add("CID");              //资产编号
                tableAssets.Columns.Add("NAME");               //资产名称
                tableAssets.Columns.Add("IMAGE");              //图片编号
                tableAssets.Columns.Add("INTRANSFERQTY");      //调拨中数量
                foreach (AssTransferOrderRow Row in TOData.Rows)
                {
                    Consumables cons = autofacConfig.consumablesService.GetConsById(Row.CID);
                    WareHouse Location = autofacConfig.wareHouseService.GetByWareID(Row.SLID);
                    if (Row.STATUS == 0)
                    {
                        tableAssets.Rows.Add(Row.TOROWID, Row.SLID, Location.NAME, Row.CID, cons.NAME, Row.IMAGE, Row.INTRANSFERQTY);
                    }
                }
                if (tableAssets.Rows.Count > 0)
                {
                    ListAssets.DataSource = tableAssets;
                    ListAssets.DataBind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Checkall_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ListViewRow Row in ListAssets.Rows)
            {
                frmAssTDLayout Layout = Row.Control as frmAssTDLayout;
                Layout.setCheck(Checkall.Checked);
            }
        }
        /// <summary>
        /// 更新全选框状态
        /// </summary>
        public void upCheckState()
        {
            if (getNum() == ListAssets.Rows.Count)
                Checkall.Checked = true;          //选中所有行项时
            else
                Checkall.Checked = false;        //没有选中所有行项
        }
        /// <summary>
        /// 计算当前选择行数
        /// </summary>
        /// <returns></returns>
        public Int32 getNum()
        {
            Int32 selectQty = 0;        //当前选择行项数
            foreach (ListViewRow Row in ListAssets.Rows)
            {
                frmAssTDLayout Layout = Row.Control as frmAssTDLayout;
                selectQty += Layout.checkNum();
            }
            return selectQty;
        }
        /// <summary>
        /// 调拨单操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
                if (getNum() == 0) throw new Exception("请选择确认行项!");

                TOInputDto BasicData = new TOInputDto();
                BasicData.MODIFYDATE = DateTime.Now;
                BasicData.MODIFYUSER = Client.Session["UserID"].ToString();
                BasicData.TOID = TOID;

                List<AssTransferOrderRow> Data = new List<AssTransferOrderRow>();
                foreach (ListViewRow Row in ListAssets.Rows)
                {
                    frmAssTDLayout Layout = Row.Control as frmAssTDLayout;
                    if (Layout.getData() != null)
                    {
                        Data.Add(Layout.getData());
                    }
                }
                BasicData.Rows = Data;
                ReturnInfo r = autofacConfig.assTransferOrderService.UpdateAssTransferOrder(BasicData,Type,OperateType.耗材);
                if (r.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    Form.Close();
                    if (Type == PROCESSMODE.调拨确认)
                    {
                        Toast("确认调拨成功!");
                    }
                    else
                    {
                        Toast("取消调拨成功!");
                    }
                }
                else
                {
                    throw new Exception(r.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }       
    }
}