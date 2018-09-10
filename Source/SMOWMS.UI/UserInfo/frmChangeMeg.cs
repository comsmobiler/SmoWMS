using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.DTOs.Enum;
using System.Text.RegularExpressions;

namespace SMOWMS.UI.UserInfo
{
    partial class frmChangeMeg : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public String UserID;        //用户编号
        public EuserInfo eInfo;          //选择修改项目
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmChangeMeg_Load(object sender, EventArgs e)
        {
            try
            {
                if (eInfo ==EuserInfo.修改电话)
                {
                    title1.TitleText = "更换手机号码";
                    lblInfo.Text = "手机号码";
                    txtInfo.WaterMarkText = "请输入新的手机号码";
                    btnNext.Text = "完成";
                }
                else
                {
                    title1.TitleText = "更换邮箱";
                    lblInfo.Text = "邮箱";
                    txtInfo.WaterMarkText = "请输入新的邮箱";
                    btnNext.Text = "完成";
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
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
                if (eInfo == EuserInfo.修改电话)
                {
                    Regex regex = new Regex(@"^1(3[0-9]|4[57]|5[0-35-9]|7[0135678]|8[0-9])\d{8}$");
                    if (String.IsNullOrEmpty(txtInfo.Text))
                        throw new Exception("电话不能为空");
                    else if (regex.IsMatch(txtInfo.Text) == false)
                        throw new Exception("手机号码格式不正确!");
                    Boolean isExit = autofacConfig.coreUserService.PhoneIsExit(txtInfo.Text);
                    if (isExit) throw new Exception("该手机号码已注册!");
                    if (autofacConfig.ValidateCodeService.SendVCode(txtInfo.Text, Client.DeviceID) !=0)
                    {
                        frmVCode frm = new frmVCode();
                        frm.tel = txtInfo.Text;
                        this.Close();
                        this.Show(frm);
                    }
                }
                else if (eInfo == EuserInfo.修改邮箱)
                {
                    Regex regex = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
                    if (String.IsNullOrEmpty(txtInfo.Text))
                        throw new Exception("邮箱不能为空");
                    else if (regex.IsMatch(txtInfo.Text) == false)
                        throw new Exception("邮箱格式不正确!");
                    Boolean isExit = autofacConfig.coreUserService.PhoneIsExit(txtInfo.Text);
                    if (isExit) throw new Exception("该邮箱已注册!");
                    if (autofacConfig.ValidateCodeService.SendEmail(txtInfo.Text, Client.DeviceID))
                    {
                        this.Close();
                        Toast("已发送至该邮箱，请前往认证!");
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