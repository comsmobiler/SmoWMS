using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.UI.ConsumablesManager;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.InputDTO;

namespace SMOWMS.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmConPORReturnLayout : Smobiler.Core.Controls.MobileUserControl
    {
        /// <summary>
        /// 选中/非选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Check_CheckedChanged(object sender, EventArgs e)
        {
            ((frmConPORReturn)Form).upCheckState();
        }
        /// <summary>
        /// 设置每行CheckBox状态
        /// </summary>
        public void setCheck(Boolean state)
        {
            Check.Checked = state;
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
        /// 选中/非选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plRow_Press(object sender, EventArgs e)
        {
            if (Check.Checked)
                Check.Checked = false;
            else
                Check.Checked = true;
            ((frmConPORReturn)Form).upCheckState();
        }
        /// <summary>
        /// 获取入库信息数据
        /// </summary>
        /// <returns></returns>
        internal ConPurchaseOrderRowInputDto getData()
        {
            if (Check.Checked)
            {
                string[] locDatas = lblLoc.BindDataValue.ToString().Split('/');
                ConPurchaseOrderRowInputDto conPOW = new ConPurchaseOrderRowInputDto();
                conPOW.CID = lblName.BindDataValue.ToString();
                conPOW.POROWID = Convert.ToInt32(imgCon.BindDataValue);
                conPOW.WAREID = locDatas[0];
                conPOW.STID = locDatas[1];
                conPOW.SLID = locDatas[2];
                if (numInStoQuant.Value == 0)
                {
                    conPOW.QUANTRETREATED = Convert.ToDecimal(lblQuant.Text);
                }
                else
                {
                    if (Convert.ToDecimal(numInStoQuant.Value) > Convert.ToDecimal(lblQuant.Text))
                    {
                        throw new Exception("实际退库数量不可大于可退库数量!");
                    }
                    conPOW.QUANTRETREATED = Convert.ToDecimal(numInStoQuant.Value);
                }
                return conPOW;
            }
            else
            {
                return null;
            }
        }
    }
}