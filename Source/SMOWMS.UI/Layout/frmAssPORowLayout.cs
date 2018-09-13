using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.UI.AssetsManager;
using SMOWMS.UI.ConsumablesManager;

namespace SMOWMS.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmAssPORowLayout : Smobiler.Core.Controls.MobileUserControl
    {

        private void plRow_LongPress(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("你确定要该行项吗?", "系统提醒", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
                {
                    try
                    {
                        if (args.Result == ShowResult.OK)     //删除该行项
                        {
                            if (this.Form.ToString() == "SMOWMS.UI.AssetsManager.frmAssPurchaseOrderCreate")
                            {
                                ((frmAssPurchaseOrderCreate)Form).RemoveTemplate(LblTId.BindDataValue.ToString());
                            }
                            else
                            {
                                ((frmAssPurchaseOrderEdit)Form).RemoveTemplate(LblTId.BindDataValue.ToString());
                            }
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
                Toast(ex.Message);
            }
        }
    }
}