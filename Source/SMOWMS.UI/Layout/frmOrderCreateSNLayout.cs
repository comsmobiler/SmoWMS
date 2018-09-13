using System;
using Smobiler.Core.Controls;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.UI.AssetsManager;

namespace SMOWMS.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmOrderCreateSNLayout : Smobiler.Core.Controls.MobileUserControl
    {
        /// <summary>
        /// 得到选中行数据
        /// </summary>
        /// <returns></returns>
        public AssetsOrderRow getData()
        {
            AssetsOrderRow Data = new AssetsOrderRow();
            Data.IMAGE = imgAss.BindDisplayValue.ToString();
            Data.ASSID = lblName.BindDataValue.ToString();
            Data.SN = lblSN.BindDataValue.ToString();
            Data.QTY = 1;
            Data.STATUS = 0;
            return Data;
        }
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
//                            ((frmAssTransferCreate)Form).ReMoveAssSN(lblName.BindDataValue.ToString(), lblSN.BindDataValue.ToString());
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