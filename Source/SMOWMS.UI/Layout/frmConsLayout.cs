using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.UI.AssetsManager;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.UI.ConsumablesManager;

namespace SMOWMS.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmConsLayout : Smobiler.Core.Controls.MobileUserControl
    {
        /// <summary>
        /// 更改选中状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Check_CheckedChanged(object sender, EventArgs e)
        {
            ((frmTransferConsChoose)Form).upCheckState();     //更新全选框状态
        }
        /// <summary>
        /// 获取当前行是否选中
        /// </summary>
        public Int32 checkNum()
        {
            if (Check.Checked)
                return 1;
            else
                return 0;
        }
        /// <summary>
        /// 得到选中行数据
        /// </summary>
        public ConsumablesOrderRow getData()
        {
            try
            {
                if (Check.Checked)
                {
                    if (numNumber.Value > Convert.ToDecimal(lblNumber.BindDataValue)) throw new Exception("选择数量不可超过可用数量!");
                    if (numNumber.Value == 0) throw new Exception("选择数量不能为0!");
                    ConsumablesOrderRow Data = new ConsumablesOrderRow();
                    Data.IMAGE = imgAss.BindDisplayValue.ToString();
                    Data.CID = lblName.BindDataValue.ToString();
                    Data.QTY = Convert.ToDecimal(numNumber.Value);
                    string[] datas = lblLocation.BindDataValue.ToString().Split('/');
                    Data.WAREID = datas[0];
                    Data.STID = datas[1];
                    Data.SLID = datas[2];
                    Data.STATUS = 0;
                    return Data;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 设置每行CheckBox状态
        /// </summary>
        public void setCheck(Boolean state)
        {
            Check.Checked = state;
        }
        /// <summary>
        /// 点击选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plRow_Press(object sender, EventArgs e)
        {
            if (Check.Checked)
                Check.Checked = false;
            else
                Check.Checked = true;
            ((frmTransferConsChoose)Form).upCheckState();
        }
    }
}