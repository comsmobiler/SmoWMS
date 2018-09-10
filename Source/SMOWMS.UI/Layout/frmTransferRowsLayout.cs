using System;
using Smobiler.Core.Controls;
using SMOWMS.UI.AssetsManager;
using SMOWMS.UI.ConsumablesManager;

namespace SMOWMS.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmTransferRowsLayout : Smobiler.Core.Controls.MobileUserControl
    {
        /// <summary>
        /// 查看调拨单详情
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plContent_Press(object sender, EventArgs e)
        {
            try
            {
                if (Form.ToString() == "SMOWMS.UI.AssetsManager.frmAssTransferRows")
                {
                    frmAssTransferDetail frm = new frmAssTransferDetail();
                    frm.TOID = lblID.BindDataValue.ToString();
                    Form.Show(frm, (MobileForm sender1, object args) => {
                        if (frm.ShowResult == ShowResult.Yes)
                        {
                            ((frmAssTransferRows)Form).Bind();        //重新绑定数据
                        }
                    });             
                }
                else if (Form.ToString() == "SMOWMS.UI.ConsumablesManager.frmTransferRows")
                {
                    frmTransferDetail frm = new frmTransferDetail();
                    frm.TOID = lblID.BindDataValue.ToString();
                    Form.Show(frm, (MobileForm sender1, object args) => {
                        if (frm.ShowResult == ShowResult.Yes)
                        {
                            ((frmTransferRows)Form).Bind();        //重新绑定数据
                        }
                    });
                }
            }
            catch (Exception ex)
            {
                Form.Toast(ex.Message);
            }
        }
    }
}