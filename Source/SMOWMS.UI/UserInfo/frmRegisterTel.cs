using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Text.RegularExpressions;

namespace SMOWMS.UI.UserInfo
{
    partial class frmRegisterTel : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public Boolean isForgetPwd;       //是否忘记手机密码
        public String UserID;             //用户编号(手机号码或者邮箱)
        #endregion
        private void frmRegisterTel_Load(object sender, EventArgs e)
        {
            try
            {
                if (isForgetPwd)
                {
                    if (String.IsNullOrEmpty(UserID) == false)
                    {
                        if (UserID.Contains("@") || (UserID.Length == 11 && Regex.IsMatch(UserID, @"^1(3[0-9]|4[57]|5[0-35-9]|7[0135678]|8[0-9])\d{8}$")))
                        {
                            txtTel.Text = UserID;
                        }
                        else
                        {
                            lblTitle.Text = "请输入手机号码或邮箱";
                        }
                    }
                    else
                    {
                        lblTitle.Text = "请输入手机号码或者邮箱";
                    }
                    txtTel.WaterMarkText = "手机号码或邮箱";
                }
                else
                {
                    lblTitle.Text = "请输入手机号码";
                    txtTel.WaterMarkText = "手机号码";
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 手机自带返回键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRegisterTel_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back) Close();
        }
        /// <summary>
        /// 下一步操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Press(object sender, EventArgs e)
        {
            try
            {
                Boolean isPhone = false;
                if (txtTel.Text.Trim().Length <= 0)    //是否是手机号码
                    throw new Exception("请输入电话号码!");
                else
                {
                    UserID = txtTel.Text.Trim();
                    if (isForgetPwd)
                    {
                        if (UserID.Contains("@"))
                        {
                            Regex regex = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
                            if (regex.IsMatch(UserID) == false)
                                throw new Exception("邮箱格式不正确!");
                        }
                        else
                        {
                            Regex regex = new Regex(@"^1(3[0-9]|4[57]|5[0-35-9]|7[0135678]|8[0-9])\d{8}$");
                            if (regex.IsMatch(UserID) == false)
                                throw new Exception("手机号码格式不正确!");
                            else
                                isPhone = true;
                        }
                    }
                    else
                    {
                        isPhone = true;
                    }
                    if (isPhone)
                    {
                        //验证手机号码是否已注册
                        Boolean isRegister = autofacConfig.coreUserService.PhoneIsExit(UserID);
                        //手机注册时，验证手机号码是否已注册，当返回true时，则抛出错误
                        if (isRegister == true) throw new Exception("电话号码"+UserID+"已注册!");
                        if (isRegister == false && isForgetPwd == true) throw new Exception("账号" + UserID + "不存在!");
                    }
                    int result = autofacConfig.ValidateCodeService.SendVCode(UserID,Client.DeviceID);
                    if (result !=0)
                    {
                        if (isPhone)
                        {
                            frmVerificationCode frm = new frmVerificationCode
                            {
                                tel = UserID,
                                isForgetPwd = isForgetPwd,
                                code = result.ToString()
                            };
                            Show(frm);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}