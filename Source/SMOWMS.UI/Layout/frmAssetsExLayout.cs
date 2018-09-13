using System;
using Smobiler.Core.Controls;
using SMOWMS.UI.MasterData;

namespace SMOWMS.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmAssetsExLayout : Smobiler.Core.Controls.MobileUserControl
    {
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        
        /// <summary>
        /// 点击行项，进入资产详情
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void touchPanel1_Press(object sender, EventArgs e)
        {
            try
            {
                frmAssetsDetail detail = new frmAssetsDetail {AssId = lblID.BindDataValue.ToString()};
                Form.Show(detail, (MobileForm sender1, object args) =>
                    {
                        if (detail.ShowResult == ShowResult.Yes)
                        {
                            ((frmAssets)Form).Bind();
                        }

                    }
                );
            }
            catch (Exception ex)
            {
                Parent.Form.Toast(ex.Message);
            }
        }

        /// <summary>
        /// CheckBox改变选项时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                ((frmAssets) Form).SelectAssId = checkBox1.Checked ? lblID.Text : "";
                ((frmAssets)Form).Bind();
            }
            catch (Exception ex)
            {
                Form.Toast(ex.Message);
            }
        }
    }
}