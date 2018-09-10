using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.UI.ConsumablesManager;
using SMOWMS.DTOs.InputDTO;

namespace SMOWMS.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmSalesCreateLayout : Smobiler.Core.Controls.MobileUserControl
    {
        public frmSalesCreateLayout() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
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
                            ((frmConSalesCreate)Form).ReMoveAss(lblName.BindDataValue.ToString());
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

        /// <summary>
        /// 销售单创建时获取行项数据
        /// </summary>
        /// <returns></returns>
        public ConPurAndSaleCreateInputDto getData()
        {
            ConPurAndSaleCreateInputDto RowData = new ConPurAndSaleCreateInputDto();
            RowData.CID = lblName.BindDataValue.ToString();
            RowData.IMAGE = imgCon.BindDisplayValue.ToString();
            if (numQuant.Value == 0)
            {
                throw new Exception("采购数量不能为0");
            }
            RowData.QUANTPURCHASED = Convert.ToDecimal(numQuant.Value);
            if (numPrice.Value == 0)
            {
                throw new Exception("采购价格不能为0");
            }
            RowData.REALPRICE = Convert.ToDecimal(numPrice.Value);
            return RowData;
        }
    }
}