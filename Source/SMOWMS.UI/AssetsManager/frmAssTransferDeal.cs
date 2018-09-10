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

namespace SMOWMS.UI.AssetsManager
{
    partial class frmAssTransferDeal : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public String TOID;     //调拨单编号
        public PROCESSMODE Type;   //操作类型
        #endregion
        /// <summary>
        /// 全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Checkall_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ListViewRow Row in ListAssetsSN.Rows)
            {
                frmAssSNTDLayout Layout = Row.Control as frmAssSNTDLayout;
                Layout.setCheck(Checkall.Checked);
            }
        }
        /// <summary>
        /// 更新全选框状态
        /// </summary>
        public void upCheckState()
        {
            if (getNum() == ListAssetsSN.Rows.Count)
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
            foreach (ListViewRow Row in ListAssetsSN.Rows)
            {
                frmAssSNTDLayout Layout = Row.Control as frmAssSNTDLayout;
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
                foreach (ListViewRow Row in ListAssetsSN.Rows)
                {
                    frmAssSNTDLayout Layout = Row.Control as frmAssSNTDLayout;
                    if (Layout.getData() != null)
                    {
                        Data.Add(Layout.getData());
                    }
                }
                BasicData.Rows = Data;
                ReturnInfo r = autofacConfig.assTransferOrderService.UpdateAssTransferOrder(BasicData, Type,OperateType.资产);
                if (r.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    Form.Close();
                    Toast("确认维修成功!");
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
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTransferDealSN_Load(object sender, EventArgs e)
        {
            Bind();
        }
        /// <summary>
        /// 加载数据
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
                if (String.IsNullOrEmpty(TOData.NOTE) == false) lblNote.Text = TOData.NOTE;

                DataTable tableAssets = new DataTable();       //未开启SN的资产列表
                tableAssets.Columns.Add("TOROWID");           //报修单行项编号
                tableAssets.Columns.Add("ASSID");              //资产编号
                tableAssets.Columns.Add("NAME");               //资产名称
                tableAssets.Columns.Add("IMAGE");              //图片编号
                tableAssets.Columns.Add("SN");                 //序列号
                foreach (AssTransferOrderRow Row in TOData.Rows)
                {
                    Assets assets = autofacConfig.orderCommonService.GetAssetsByID(Row.ASSID);
                    if (Row.STATUS == 0)
                    {
                        tableAssets.Rows.Add(Row.TOROWID, Row.ASSID, assets.NAME, Row.IMAGE, Row.SN);
                    }
                }
                if (tableAssets.Rows.Count > 0)
                {
                    ListAssetsSN.DataSource = tableAssets;
                    ListAssetsSN.DataBind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}