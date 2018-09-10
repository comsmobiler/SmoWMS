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
    partial class frmConPORInSto : Smobiler.Core.Controls.MobileForm
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
        private void frmConPORInSto_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(POID))     //从采购单界面进入入库
            {
                plOrder.Visible = false;
                Bind();
            }
        }
        /// <summary>
        /// 加载数据
        /// </summary>
        private void Bind()
        {
            try
            {
                List<ConPORInstorageOutputDto> rows = autofacConfig.ConPurchaseOrderService.GetInStoRowsByPOID(POID);
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
                frmConPORInStoLayout Layout = Row.Control as frmConPORInStoLayout;
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
                frmConPORInStoLayout Layout = Row.Control as frmConPORInStoLayout;
                selectQty += Layout.checkNum();
            }
            if (selectQty == listCons.Rows.Count)
                Checkall.Checked = true;          //选中所有行项时
            else
                Checkall.Checked = false;        //没有选中所有行项
        }
        /// <summary>
        /// 单号扫描
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
                    ConPurchaseOrderOutputDto conPurchaseOrder= autofacConfig.ConPurchaseOrderService.GetByPOID(e.Value);
                    if(conPurchaseOrder != null)
                    {
                        POID = e.Value;
                        lblOrder.Text = POID;
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
        /// 库位扫描
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgBS_Press(object sender, EventArgs e)
        {
            bsLoc.GetBarcode();
        }
        /// <summary>
        /// 扫描到库位时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bsLoc_BarcodeScanned(object sender, BarcodeResultArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(e.error))
                {
                    String Data = e.Value;
                    String[] Datas = Data.Split('/');
                    if (Datas.Length != 3) throw new Exception("库位条码错误");
                    WHStorageLocationOutputDto whLoc = autofacConfig.wareHouseService.GetSLByID(Datas[0], Datas[1], Datas[2]);
                    if (whLoc == null) throw new Exception("库位不存在，请检查!");
                    lblLocation.Text = whLoc.WARENAME + "/" + whLoc.STNAME + "/" + whLoc.SLNAME;
                    lblLocation.Tag = Data;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 入库提交
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(lblLocation.Text)) throw new Exception("请扫描调入库位!");
                List<ConPurchaseOrderRowInputDto> Rows = new List<ConPurchaseOrderRowInputDto>();
                foreach (ListViewRow row in listCons.Rows)
                {
                    frmConPORInStoLayout Layout = row.Control as frmConPORInStoLayout;
                    if (Layout.getData() != null)
                    {
                        Rows.Add(Layout.getData());   //添加入库信息
                    }
                }
                if (Rows.Count == 0) throw new Exception("请选择入库耗材!");
                String[] locDatas = lblLocation.Tag.ToString().Split('/');
                ConPOInStoInputDto stoInputDto = new ConPOInStoInputDto();
                stoInputDto.POID = POID;
                stoInputDto.WAREID = locDatas[0];
                stoInputDto.STID = locDatas[1];
                stoInputDto.SLID = locDatas[2];
                stoInputDto.CREATEUSER = Client.Session["UserID"].ToString();
                stoInputDto.RowDatas = Rows;
                ReturnInfo RInfo = autofacConfig.ConPurchaseOrderService.InStoConPurhcaseOrder(stoInputDto);
                if (RInfo.IsSuccess)
                {
                    List<ConPORInstorageOutputDto> rows = autofacConfig.ConPurchaseOrderService.GetInStoRowsByPOID(POID);
                    if (rows.Count == 0)
                    {
                        Toast("该采购单入库完成!");
                        Form.Close();
                    }
                    else
                    {
                        Toast("入库成功!");
                        Bind();         //刷新当前页面入库数据
                        lblLocation.Text = "";
                        lblLocation.Tag = null;
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