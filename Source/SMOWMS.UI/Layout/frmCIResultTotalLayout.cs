using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.UI.ConsumablesManager;
using SMOWMS.Domain.Entity;

namespace SMOWMS.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmCIResultTotalLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region 定义变量
        AutofacConfig autofacConfig = new AutofacConfig();
        #endregion
        /// <summary>
        /// 取消操作，关闭当前弹出框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Press(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 确定操作，进行数量盘点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
                if (lblName.Tag == null) throw new Exception("请扫描盘点耗材");
                if (String.IsNullOrEmpty(txtRealAmount.Text)) throw new Exception("实盘数量不能为空!");
                if (System.Text.RegularExpressions.Regex.IsMatch(txtRealAmount.Text.Trim(), "^\\d+$") == false)
                {
                    throw new Exception("请输入数字!");
                }
                this.Close();          //关闭当前弹出框
                ((frmConInventoryResult)Form).AddConToDictionary(lblName.Tag.ToString(), Convert.ToDecimal(txtRealAmount.Text));
            }
            catch (Exception ex)
            {
                Form.Toast(ex.Message);
            }
        }
        /// <summary>
        /// 耗材扫描
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ibCons_Press(object sender, EventArgs e)
        {
            bsCons.GetBarcode();
        }
        /// <summary>
        /// 扫描到耗材条码时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bsCons_BarcodeScanned(object sender, BarcodeResultArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(e.error))
                {
                    String cId = e.Value;
                    Consumables con = autofacConfig.consumablesService.GetConsById(cId);
                    if (con == null) throw new Exception("不存在此耗材");
                    String[] locData= ((frmConInventoryResult)Form).locData;

                     ConInventoryResult result = autofacConfig.ConInventoryService.GetResultBySL(
                        ((frmConInventoryResult)Form).IID, e.Value,
                        locData[0], locData[1], locData[2]);
                    if (result == null) throw new Exception("不存在该盘点行项");

                    lblName.Text = con.NAME;
                    lblName.Tag = con.CID;
                    lblNumber.Text = result.TOTAL.ToString();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}