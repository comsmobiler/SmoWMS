using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.UI.ConsumablesManager;
using SMOWMS.CommLib;
using SMOWMS.UI.Menu;

namespace SMOWMS.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmConSalesLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region 定义变量
        AutofacConfig _autofacConfig = new AutofacConfig();
        #endregion
        /// <summary>
        /// 销售单编号
        /// </summary>
        internal string SOID
        {
            get
            {
                return this.lblName.BindDataValue.ToString();
            }

        }
        /// <summary>
        /// 点击行项，进入销售详情页查看
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plRow_Press(object sender, EventArgs e)
        {
            frmConSalesResult frm = new frmConSalesResult();
            frm.SOID = lblName.BindDataValue.ToString();
            Form.Show(frm, (MobileForm sender1, object args) => {
                ((frmOrder)Form).Bind(((frmOrder)Form).type, ((frmOrder)Form).orderType);
            });
        }
        /// <summary>
        /// 耗材销售单编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ibEdit_Press(object sender, EventArgs e)
        {
            frmConSalesCreate frm = new frmConSalesCreate { SOID = lblName.BindDataValue.ToString() };
            Form.Show(frm, (MobileForm sender1, object args) =>
            {
                if (frm.ShowResult == ShowResult.Yes)
                {
                    ((frmOrder)Form).Bind(((frmOrder)Form).type, ((frmOrder)Form).orderType);
                }
            });
        }
    }
}