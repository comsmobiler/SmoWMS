using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.UI.AssetsManager;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.Enum;
using SMOWMS.UI.ConsumablesManager;

namespace SMOWMS.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmAssTDLayout : Smobiler.Core.Controls.MobileUserControl
    {
        /// <summary>
        /// 点击修改选中状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plRow_Press(object sender, EventArgs e)
        {
            if (Check.Checked)
                Check.Checked = false;
            else
                Check.Checked = true;
            ((frmTransferDeal)Form).upCheckState();
        }
        /// <summary>
        /// 得到选中行数据
        /// </summary>
        public AssTransferOrderRow getData()
        {
            if (Check.Checked == true)
            {
                if (numNumber.Value > Convert.ToDouble(lblNumber.BindDataValue))
                {
                    if (((frmTransferDeal)Form).Type == PROCESSMODE.调拨确认)
                        throw new Exception("确认数量不能超过调拨数量!");
                    else
                        throw new Exception("取消数量不能超过调拨数量!");
                } 
                AssTransferOrderRow Data = new AssTransferOrderRow();
                Data.TOROWID = Check.BindDataValue.ToString();
                Data.IMAGE = imgAss.BindDisplayValue.ToString();
                Data.CID = lblName.BindDataValue.ToString();
                if(((frmTransferDeal)Form).Type == PROCESSMODE.调拨确认)
                {                   
                    if (numNumber.Value == 0 || (decimal)numNumber.Value== Convert.ToDecimal(lblNumber.BindDataValue))
                    {
                        Data.STATUS = 1;
                        Data.TRANSFEREDQTY = Convert.ToDecimal(lblNumber.BindDataValue);
                    }
                    else
                    {
                        Data.TRANSFEREDQTY = Convert.ToDecimal(numNumber.Value);
                        Data.STATUS = 0;
                    }                      
                }
                else
                {
                    if (numNumber.Value == 0 || (decimal)numNumber.Value == Convert.ToDecimal(lblNumber.BindDataValue))
                    {
                        Data.STATUS = 2;
                        Data.TRANSFERCANCELQTY = Convert.ToDecimal(lblNumber.BindDataValue);
                    }
                    else
                    {
                        Data.TRANSFERCANCELQTY = Convert.ToDecimal(numNumber.Value);
                        Data.STATUS = 0;
                    }                      
                }              
                Data.SLID = lblLocation.BindDataValue.ToString();
                return Data;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 更改选中状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Check_CheckedChanged(object sender, EventArgs e)
        {
            ((frmTransferDeal)Form).upCheckState();
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
        /// 设置CheckBox状态
        /// </summary>
        /// <param name="state"></param>
        public void setCheck(Boolean state)
        {
            Check.Checked = state;
        }
    }
}