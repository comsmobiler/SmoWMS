using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.DTOs.OutputDTO;
using SMOWMS.UI.Layout;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.CommLib;

namespace SMOWMS.UI.ConsumablesManager
{
    partial class frmConPORReturn : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public String POID;               //耗材采购单编号
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmConPORReturn_Load(object sender, EventArgs e)
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
                List<ConPurchaseOrderReturnOutputDto> rows = autofacConfig.ConPurchaseOrderService.GetReturnRowsByPOID(POID);
                listCons.DataSource = rows;
                listCons.DataBind();
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
            foreach (ListViewRow Row in listCons.Rows)
            {
                frmConPORReturnLayout Layout = Row.Control as frmConPORReturnLayout;
                Layout.setCheck(Checkall.Checked);
            }
        }
        /// <summary>
        /// 全选框更新
        /// </summary>
        internal void upCheckState()
        {
            Int32 selectQty = 0;        //当前选择行项数
            foreach (ListViewRow Row in listCons.Rows)
            {
                frmConPORReturnLayout Layout = Row.Control as frmConPORReturnLayout;
                selectQty += Layout.checkNum();
            }
            if (selectQty == listCons.Rows.Count)
                Checkall.Checked = true;          //选中所有行项时
            else
                Checkall.Checked = false;        //没有选中所有行项
        }
        /// <summary>
        /// 提交退库操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
                List<ConPurchaseOrderRowInputDto> Rows = new List<ConPurchaseOrderRowInputDto>();
                foreach (ListViewRow row in listCons.Rows)
                {
                    frmConPORReturnLayout Layout = row.Control as frmConPORReturnLayout;
                    if (Layout.getData() != null)
                    {
                        Rows.Add(Layout.getData());   //添加入库信息
                    }
                }
                if (Rows.Count == 0) throw new Exception("请选择退库耗材!");
                ConPOInStoInputDto stoInputDto = new ConPOInStoInputDto();
                stoInputDto.POID = POID;
                stoInputDto.CREATEUSER = Client.Session["UserID"].ToString();
                stoInputDto.RowDatas = Rows;
                ReturnInfo RInfo = autofacConfig.ConPurchaseOrderService.ReturnConPurchaseOrder(stoInputDto);
                if (RInfo.IsSuccess)
                {
                    List<ConPurchaseOrderReturnOutputDto> rows = autofacConfig.ConPurchaseOrderService.GetReturnRowsByPOID(POID);
                    if (rows.Count == 0)
                    {
                        Toast("该采购单退库完成!");
                        Form.Close();
                    }
                    else
                    {
                        Toast("退库成功!");
                        Bind();         //刷新当前页面入库数据
                        Checkall.Checked = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}