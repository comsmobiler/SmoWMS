using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.Domain.Entity;
using SMOWMS.CommLib;
using SMOWMS.UI.MasterData;

namespace SMOWMS.UI.UserInfo
{
    partial class frmSettingPWD : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public String tel;              //手机号码
        public String  vcode;           //手机验证码
        public Boolean isForgetPwd;     //是否忘记密码
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSettingPWD_Load(object sender, EventArgs e)
        {
            if(isForgetPwd)    //忘记密码，手机验证
            {
                lblID1.Visible = false;
                lblID2.Visible = false;
                txtID.Visible = false;
            }
            else          //如果是手机注册
            {
                lblID1.Visible = true;
                lblID2.Visible = true;
                txtID.Visible = true;
            }
        }
        /// <summary>
        /// 手机自带返回键操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSettingPWD_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back) Close();
        }

        private void btnNext_Press(object sender, EventArgs e)
        {
            try
            {
                String UserID = txtID.Text.Trim();
                if (isForgetPwd == false)
                {
                    if (UserID.Length < 0) throw new Exception("请输入账号!");
                    if (UserID.Length < 6 || UserID.Length > 18) throw new Exception("账号必须为6-18位!");
                }
                String pwd = txtPwd.Text.Trim();
                if (pwd.Length <= 0) throw new Exception("请输入密码!");
                if (pwd.Length < 6 || pwd.Length > 12) throw new Exception("密码必须为6-12位!");
                if (isForgetPwd)    //忘记密码，手机验证
                {
                    coreUser coreUser= autofacConfig.coreUserService.GetUserByID(UserID);
                    if(coreUser != null)
                    {
                        String OldPwd = coreUser.USER_PASSWORD;
                        ReturnInfo RInfo= autofacConfig.coreUserService.ChangePwd(UserID,OldPwd,pwd);
                        if (RInfo.IsSuccess)
                        {
                            ReturnInfo result=  autofacConfig.coreUserService.Login(UserID,pwd);
                            if (result.IsSuccess)
                            {
                                String Role = autofacConfig.coreUserService.GetUserByID(UserID).USER_ROLE;
                                Client.Session["UserID"] = UserID;
                                Client.Session["Role"] = Role;
                                //frmAssets frm = new frmAssets();
                                //Show(frm);
                            }
                            else
                            {
                                throw new Exception(result.ErrorInfo);
                            }
                        }
                    }
                    else
                    {
                        throw new Exception("未找到该用户!");
                    }
                }
            }
            catch(Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}