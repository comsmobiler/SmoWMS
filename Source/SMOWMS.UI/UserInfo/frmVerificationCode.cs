using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SMOWMS.UI.UserInfo
{
    partial class frmVerificationCode : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public String  tel;       //手机号码
        public Boolean  isForgetPwd;             //是否忘记密码
        public String code;             //手机验证码
        #endregion
        private void frmVerificationCode_Load(object sender, EventArgs e)
        {
            lblTel.Text = "短信验证码已发送手机至" + tel;
        }
        /// <summary>
        /// 手机自带返回键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmVerificationCode_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back) Close();
        }
        /// <summary>
        /// 跳转到设置密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Press(object sender, EventArgs e)
        {
            try
            {
                String vcode = txtVcode.Text.Trim();
                if (vcode.Length > 0)
                {
                    if (vcode != code) throw new Exception("您输入的验证码错误!");
                    if (isForgetPwd)
                    {
                        frmSettingPWD frm = new frmSettingPWD();
                        frm.isForgetPwd = isForgetPwd;
                        frm.tel = tel;
                        frm.vcode = vcode;
                        Show(frm);
                    }
                    else
                    {
                        frmRegister frm = new frmRegister();
                        frm.Tel = tel;
                        frm.VCode = vcode;
                        Show(frm);
                    }
                }
                else
                {
                    throw new Exception("请输入手机验证码!");
                }
            }
            catch(Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}