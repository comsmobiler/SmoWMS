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
    partial class frmConSORRetiring : Smobiler.Core.Controls.MobileForm
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
        private void frmConSORRetiring_Load(object sender, EventArgs e)
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
                List<ConSalesOrderRowInputDto> rows = autofacConfig.ConSalesOrderService.GetRetRowsBySOID(SOID);
                listCons.DataSource = rows;
                listCons.DataBind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 全选/非全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Checkall_CheckedChanged(object sender, EventArgs e)
        {
            setCheck();
        }
        /// <summary>
        /// 全选/非全选
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
                frmConSORRetiringLayout Layout = Row.Control as frmConSORRetiringLayout;
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
                frmConSORRetiringLayout Layout = Row.Control as frmConSORRetiringLayout;
                selectQty += Layout.checkNum();
            }
            if (selectQty == listCons.Rows.Count)
                Checkall.Checked = true;          //选中所有行项时
            else
                Checkall.Checked = false;        //没有选中所有行项
        }
        /// <summary>
        /// 退货操作提交
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
                    frmConSORRetiringLayout Layout = row.Control as frmConSORRetiringLayout;
                    if (Layout.getData() != null)
                    {
                        Rows.Add(Layout.getData());   //添加入库信息
                    }
                }
                if (Rows.Count == 0) throw new Exception("请选择退货耗材!");
                ConSOOutboundInputDto outInputDto = new ConSOOutboundInputDto();
                outInputDto.SOID = SOID;
                outInputDto.CREATEUSER = Client.Session["UserID"].ToString();
                outInputDto.RowDatas = Rows;
                ReturnInfo RInfo = autofacConfig.ConSalesOrderService.RetConSalesOrder(outInputDto);
                if (RInfo.IsSuccess)
                {
                    List<ConSalesOrderRowInputDto> rows = autofacConfig.ConSalesOrderService.GetRetRowsBySOID(SOID);
                    if (rows.Count == 0)
                    {
                        Toast("该销售单退货完成!");
                        Form.Close();
                    }
                    else
                    {
                        Toast("退货成功!");
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