using System;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.Enum;
using SMOWMS.UI.AssetsManager;

namespace SMOWMS.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmAssSNTDLayout : Smobiler.Core.Controls.MobileUserControl
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
            ((frmAssTransferDeal)Form).upCheckState();
        }
        /// <summary>
        /// 更改选中状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Check_CheckedChanged(object sender, EventArgs e)
        {
            ((frmAssTransferDeal)Form).upCheckState();
        }
        /// <summary>
        /// 获取行项数据
        /// </summary>
        /// <returns></returns>
        public AssTransferOrderRow getData()
        {
            if (Check.Checked)
            {
                AssTransferOrderRow Data = new AssTransferOrderRow();
                Data.TOROWID = Check.BindDataValue.ToString();
                Data.IMAGE = imgAss.BindDisplayValue.ToString();
                Data.ASSID = lblName.BindDataValue.ToString();
                Data.SN = lblSN.BindDataValue.ToString();
                if (((frmAssTransferDeal)Form).Type == PROCESSMODE.调拨确认)
                {
                    Data.TRANSFEREDQTY = 1;
                    Data.STATUS = 1;
                }
                else
                {
                    Data.TRANSFERCANCELQTY = 1;
                    Data.STATUS = 2;
                }
                return Data;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 获取当前行是否选中
        /// </summary>
        /// <returns></returns>
        public int checkNum()
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