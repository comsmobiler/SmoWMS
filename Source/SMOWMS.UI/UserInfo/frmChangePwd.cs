using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.CommLib;

namespace SMOWMS.UI.UserInfo
{
    partial class frmChangePwd : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public String oldPwd;        //旧密码
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmChangePwd_Load(object sender, EventArgs e)
        {
            lblUserID.Text = Client.Session["UserID"].ToString();
        }
        /// <summary>
        /// 修改保存密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSure_Press(object sender, EventArgs e)
        {
            try
            {
                String newPwd1 = txtPassWord1.Text.Trim();
                String newPwd2 = txtPassWord2.Text.Trim();
                if (newPwd1.Length < 0) throw new Exception("请输入新密码!");
                if (newPwd1.Length < 6 || newPwd1.Length > 12) throw new Exception("新密码必须为6-12位!");
                if (newPwd2.Length < 0) throw new Exception("请输入确认密码!");
                if (newPwd2.Length < 6 || newPwd2.Length > 12) throw new Exception("新密码必须为6-12位!");
                if (newPwd1.Equals(newPwd2) == false) throw new Exception("两次密码输入不一致，请检查!");
                if (oldPwd.Equals(newPwd1)) throw new Exception("新密码不能与原密码相同，请重新输入!");
                ReturnInfo RInfo = autofacConfig.coreUserService.ChangePwd(lblUserID.Text, oldPwd, newPwd1);
                if (RInfo.IsSuccess == true)
                {
                    Form.Close();
                    Toast("密码修改成功");
                }
                else
                {
                    throw new Exception(RInfo.ErrorInfo);
                }
             }
            catch(Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}