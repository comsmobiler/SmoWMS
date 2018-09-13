using System;
using Smobiler.Core.Controls;
using SMOWMS.UI.MasterData;

namespace SMOWMS.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmConsumablesLayout : Smobiler.Core.Controls.MobileUserControl
    {
        /// <summary>
        /// 点击，查看耗材详情
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void touchPanel1_Press(object sender, EventArgs e)
        {
            try
            {
                frmConsumablesDetail consumablesDetail = new frmConsumablesDetail {CID = lblID.BindDataValue.ToString()};
                Form.Show(consumablesDetail, (MobileForm sender1, object args) =>
                {
                    if (consumablesDetail.ShowResult == ShowResult.Yes)
                    {
                        ((frmConsumables)Form).Bind();
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