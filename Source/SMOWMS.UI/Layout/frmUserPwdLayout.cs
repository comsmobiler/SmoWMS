using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.Domain.Entity;
using SMOWMS.UI.UserInfo;
using SMOWMS.DTOs.Enum;

namespace SMOWMS.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmUserPwdLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        #endregion
        /// <summary>
        /// 取消操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Press(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 确认操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Press(object sender, EventArgs e)
        {
            try
            {
                coreUser user=autofacConfig.coreUserService.GetUserByID(Client.Session["UserID"].ToString());
                if (user.USER_PASSWORD == txtPwd.Text)
                {

                    if (((frmSet)Form).eInfo == EuserInfo.修改密码)
                    {
                        frmChangePwd frm = new frmChangePwd();
                        frm.oldPwd = txtPwd.Text;
                        Form.Show(frm);
                    }
                    else
                    {
                        frmChangeMeg frm = new frmChangeMeg();
                        frm.eInfo = ((frmSet)Form).eInfo;
                        Form.Show(frm);
                    }
                    this.Close();
                }
                else
                {
                    txtPwd.Text = "";
                    throw new Exception("输入的原密码不正确，请重新输入!");
                }
            }
            catch(Exception ex)
            {
                Form.Toast(ex.Message);
            }
        } 
    }
}