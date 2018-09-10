using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.UI.Layout;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.CommLib;
using SMOWMS.DTOs.OutputDTO;

namespace SMOWMS.UI.ConsumablesManager
{
    partial class frmConSOROutbound : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public String SOID;               //耗材销售单编号
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmConSOROutbound_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(SOID))       //从销售单界面进入出库
            {
                plOrder.Visible = false;
                Bind();
            }          
        }
        /// <summary>
        /// 订单扫描
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgOrder_Press(object sender, EventArgs e)
        {
            bsOrder.GetBarcode();
        }
        /// <summary>
        /// 扫描到单号时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bsOrder_BarcodeScanned(object sender, BarcodeResultArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(e.error))
                {
                    ConSalesOrderOutputDto conSales= autofacConfig.ConSalesOrderService.GetBySOID(e.Value);
                    if(conSales != null)
                    {
                        SOID = e.Value;
                        lblOrder.Text = SOID;
                        Bind();
                    }
                    else
                    {
                        throw new Exception("该订单号不存在");
                    }
                }
            }
            catch(Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 数据加载
        /// </summary>
        public void Bind()
        {
            try
            {
                List<ConSalesOrderOutboundOutputDto> rows = autofacConfig.ConSalesOrderService.GetOutRowsBySOID(SOID);
                listCons.DataSource = rows;
                listCons.DataBind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 全选/全不选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Checkall_CheckedChanged(object sender, EventArgs e)
        {
            setCheck();
        }
        /// <summary>
        /// 全选/全不选
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
                frmConSOROutboundLayout Layout = Row.Control as frmConSOROutboundLayout;
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
                frmConSOROutboundLayout Layout = Row.Control as frmConSOROutboundLayout;
                selectQty += Layout.checkNum();
            }
            if (selectQty == listCons.Rows.Count)
                Checkall.Checked = true;          //选中所有行项时
            else
                Checkall.Checked = false;        //没有选中所有行项
        }
        /// <summary>
        /// 出库提交
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
                List<ConSalesOrderRowInputDto> Rows = new List<ConSalesOrderRowInputDto>();
                foreach (ListViewRow row in listCons.Rows)
                {
                    frmConSOROutboundLayout Layout = row.Control as frmConSOROutboundLayout;
                    if (Layout.getData() != null)
                    {
                        Rows.Add(Layout.getData());   //添加入库信息
                    }
                }
                if (Rows.Count == 0) throw new Exception("请选择退库耗材!");
                ConSOOutboundInputDto outInputDto = new ConSOOutboundInputDto();
                outInputDto.SOID = SOID;
                outInputDto.CREATEUSER = Client.Session["UserID"].ToString();
                outInputDto.RowDatas = Rows;
                ReturnInfo RInfo = autofacConfig.ConSalesOrderService.OutboundConSalesOrder(outInputDto);
                if (RInfo.IsSuccess)
                {
                    List<ConSalesOrderOutboundOutputDto> rows = autofacConfig.ConSalesOrderService.GetOutRowsBySOID(SOID);
                    if (rows.Count == 0)
                    {
                        Toast("该销售单出库完成!");
                        Form.Close();
                    }
                    else
                    {
                        Toast("出库成功!");
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