using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.UI.AssetsManager;
using SMOWMS.UI.ConsumablesManager;

namespace SMOWMS.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmOrderCreateLayout : Smobiler.Core.Controls.MobileUserControl
    {
        /// <summary>
        /// 获取选中行数据
        /// </summary>
        /// <returns></returns>
        public ConsumablesOrderRow getData()
        {
            if (numNumber.Value == 0) throw new Exception("选择数量不能为0!");
            ConsumablesOrderRow Data = new ConsumablesOrderRow();
            Data.IMAGE = imgAss.BindDisplayValue.ToString();
            Data.CID = lblName.BindDataValue.ToString();
            Data.QTY = Convert.ToDecimal(numNumber.Value);
            string[] datas = lblLocation.BindDataValue.ToString().Split('/');
            Data.WAREID = datas[0];
            Data.STID = datas[1];
            Data.SLID =datas[2];
            Data.STATUS = 0;
            return Data;
        }
        /// <summary>
        /// 长按删除该行项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plRow_LongPress(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("是否删除该行项?", "系统提醒", MessageBoxButtons.YesNo, (object sender1, MessageBoxHandlerArgs args) =>
                {
                    try
                    {
                        if (args.Result == ShowResult.Yes)     //删除该区域
                        {
                            ((frmTransferCreate)Form).ReMoveAss(lblName.BindDataValue.ToString(),lblLocation.BindDataValue.ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        Form.Toast(ex.Message);
                    }
                });
            }
            catch (Exception ex)
            {
                Form.Toast(ex.Message);
            }
        }
    }
}