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
    partial class frmConsChooseLayout : Smobiler.Core.Controls.MobileUserControl
    {
        /// <summary>
        /// 更改选中状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Check_CheckedChanged(object sender, EventArgs e)
        {
            ((frmConsChoose)Form).upCheckState();     //更新全选框状态
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
        /// 得到选中行耗材编号
        /// </summary>
        public ConPurAndSaleCreateInputDto getData()
        {
            if (Check.Checked)
            {
                ConPurAndSaleCreateInputDto cons = new ConPurAndSaleCreateInputDto();
                cons.CID = imgCon.BindDataValue.ToString();
                cons.NAME = lblName.BindDataValue.ToString();
                cons.IMAGE = imgCon.BindDisplayValue.ToString();
                cons.QUANTPURCHASED = Convert.ToDecimal(numQuant.Value);
                if(((frmConsChoose)Form).type==1)
                    cons.QUANTSALED = Convert.ToDecimal(numQuant.Value);
                cons.REALPRICE = Convert.ToDecimal(numPrice.Value);
                return cons;
            }
            else
            {
                return null;
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
            ((frmConsChoose)Form).upCheckState();
        }
        /// <summary>
        /// 显示初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmConsChooseLayout_Load(object sender, EventArgs e)
        {
            if (((frmConsChoose)Form).type == 1)
            {
                lblQuant.Text = "销售数量";
                lblPrice.Text = "销售价格";
            }
        }
    }
}