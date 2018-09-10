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
    partial class frmAssetsSNLayout : Smobiler.Core.Controls.MobileUserControl
    {
        /// <summary>
        /// 更改选中状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Check_CheckedChanged(object sender, EventArgs e)
        {
            ((frmTransferConsChoose)Form).upCheckState();       //更改全选框状态
        }
        /// <summary>
        /// 获取当前行是否选中
        /// </summary>
        /// <returns></returns>
        public Int32 checkNum()
        {
            if (Check.Checked)
                return 1;
            else
                return 0;
        }
        public AssetsOrderRow getData()
        {
            AssetsOrderRow Data = new AssetsOrderRow();
            if (Check.Checked)
            {
                Data.IMAGE = imgAss.BindDisplayValue.ToString();
                Data.ASSID = lblName.BindDataValue.ToString();
                Data.SN = lblSN.BindDataValue.ToString();
                Data.QTY = 1;
                Data.SLID = lblLocation.BindDataValue.ToString();
                Data.STATUS = 0;
                return Data;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 设置每行CheckBox状态
        /// </summary>
        /// <param name="state"></param>
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