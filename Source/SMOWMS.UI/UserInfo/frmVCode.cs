using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SMOWMS.UI.UserInfo
{
    partial class frmVCode : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public String UserID;        //用户编号
        public String tel;          //手机号码
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmVCode_Load(object sender, EventArgs e)
        {
            try
            {
                UserID = Client.Session["UserID"].ToString();
                lblTel.Text = "短信验证码已发送至手机" + tel;
            }
            catch(Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtVcode.Text)) throw new Exception("验证码不能为空!");
                if (autofacConfig.ValidateCodeService.isValidate(UserID, tel, txtVcode.Text))
                {
                    Close();
                    Toast("修改电话成功!");
                }
            }
            catch(Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}