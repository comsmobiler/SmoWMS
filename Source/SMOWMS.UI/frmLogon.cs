using System;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.CommLib;
using SMOWMS.UI.UserInfo;
using SMOWMS.UI.MasterData;
using SMOWMS.UI.Menu;

namespace SMOWMS.UI
{
    partial class frmLogon : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();//调用配置类
        private DateTime toasttime;
        #endregion
        /// <summary>
        /// 根据输入用户名判断能否进行登录操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUserName.Text))
            {
                btnLogon.ForeColor = System.Drawing.Color.LightGray;
                btnLogon.Enabled = false;
            }
            else
            {
                btnLogon.ForeColor = System.Drawing.Color.White;
                btnLogon.Enabled = true;
            }
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogon_Click(object sender, EventArgs e)
        {
            try
            {
                String userID = txtUserName.Text.Trim();
                String PassWord = txtPassWord.Text.Trim();
                if (userID.Length <= 0)
                    throw new Exception("请输入手机号码");
                if (PassWord.Length < 0)
                    throw new Exception("请输入密码");
                LoadClientData(MobileServer.ServerID + "user", userID);
                if (checkRemb.Checked == true)
                {
                    //记住密码
                    LoadClientData(MobileServer.ServerID + "pwd", PassWord);
                }
                else
                {
                    //删除客户端数据
                    RemoveClientData(MobileServer.ServerID + "pwd", (object s, ClientDataResultHandlerArgs args) => txtPassWord.Text = "");
                }
                ReturnInfo result = autofacConfig.coreUserService.Login(userID, PassWord);

                if (result.IsSuccess)
                {
                    String Role = autofacConfig.coreUserService.GetUserByID(userID).USER_ROLE;
                    Client.Session["UserID"] = userID;
                    Client.Session["Role"] = Role;
                    frmMenu frmMenu = new frmMenu();
                    this.Show(frmMenu);
                }
                else
                {
                    throw new Exception(result.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 退出客户端
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLogon_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                if (toasttime.AddSeconds(3) > DateTime.Now)
                {
                    Client.Exit(false);
                }
                else
                {
                    toasttime = DateTime.Now;
                    Toast("再按一次退出应用", ToastLength.SHORT);
                }
            }
        }
        /// <summary>
        /// 读取客户端数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLogon_Load(object sender, EventArgs e)
        {
            //读取用户名
            ReadClientData(MobileServer.ServerID + "user", (object sender1, ClientDataResultHandlerArgs e1) =>
            {
                if (String.IsNullOrEmpty(e1.error))
                {
                    txtUserName.Text = e1.Value;
                }
            });
            //读取密码
            ReadClientData(MobileServer.ServerID + "pwd", (object sender1, ClientDataResultHandlerArgs e1) =>
            {
                if (String.IsNullOrEmpty(e1.error))
                {
                    txtPassWord.Text = e1.Value;
                    if (txtPassWord.Text.Length > 0)
                    {
                        checkRemb.Checked = true;
                    }
                }
            });
        }
        /// <summary>
        /// 账号注册
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegist_Press(object sender, EventArgs e)
        {
            frmRegisterTel frm = new frmRegisterTel();
            this.Show(frm);
        }
        /// <summary>
        /// Demo账号登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDemo_Press(object sender, EventArgs e)
        {
            try
            {
                ReturnInfo result = autofacConfig.coreUserService.Login("12345678917", "123456");

                if (result.IsSuccess)
                {
                    String Role = autofacConfig.coreUserService.GetUserByID("12345678917").USER_ROLE;
                    Client.Session["UserID"] = "12345678917";
                    Client.Session["Role"] = Role;
                    frmMenu frm = new frmMenu();
                    Show(frm);
                }
                else
                {
                    throw new Exception(result.ErrorInfo);
                }
            }
            catch(Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 忘记密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnForget_Press(object sender, EventArgs e)
        {
            frmRegisterTel frm = new frmRegisterTel();
            frm.isForgetPwd = true;
            frm.UserID = txtUserName.Text.Trim();
            this.Show(frm);
        }
    }
}