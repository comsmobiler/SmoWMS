using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.CommLib;
using SMOWMS.UI.AssetsManager;
using SMOWMS.UI.Menu;

namespace SMOWMS.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmAssPOLayout : Smobiler.Core.Controls.MobileUserControl
    {
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        /// <summary>
        /// 采购单编号
        /// </summary>
        internal string POID
        {
            get
            {
                return this.lblName.BindDataValue.ToString();
            }
        }

        /// <summary>
        /// 对订单进行编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ibEdit_Press(object sender, EventArgs e)
        {
            try
            {
                frmAssPurchaseOrderEdit edit = new frmAssPurchaseOrderEdit { POID = lblName.BindDataValue.ToString() };
                Form.Show(edit, (MobileForm sender1, object args) =>
                {
                    if (edit.ShowResult == ShowResult.Yes)
                    {
                        ((frmOrder)Form).Bind(((frmOrder)Form).type, ((frmOrder)Form).orderType);
                    }
                });
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 行项点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plRow_Press(object sender, EventArgs e)
        {
            try
            {
                frmAssPurchaseOrderResult result = new frmAssPurchaseOrderResult { POID = lblName.BindDataValue.ToString() };

                Form.Show(result, (MobileForm sender1, object args) =>
                {
                        ((frmOrder)Form).Bind(((frmOrder)Form).type, ((frmOrder)Form).orderType);
                });
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}