using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.CommLib;
using SMOWMS.UI.ConsumablesManager;
using SMOWMS.UI.Menu;

namespace SMOWMS.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmConPurchaseLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region 定义变量
        AutofacConfig _autofacConfig=new AutofacConfig();
        #endregion
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
        /// 点击行项，进入采购详情查看
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plRow_Press(object sender, EventArgs e)
        {
            frmConPurchaseResult frm = new frmConPurchaseResult();
            frm.POID = lblName.BindDataValue.ToString();
            Form.Show(frm, (MobileForm sender1, object args) => {
                ((frmOrder)Form).Bind(((frmOrder)Form).type, ((frmOrder)Form).orderType);
            });
        }
        /// <summary>
        /// 采购单编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ibEdit_Press(object sender, EventArgs e)
        {
            frmConPurchaseCreate frm = new frmConPurchaseCreate { POID = lblName.BindDataValue.ToString() };
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