using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.UI.Layout;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.Enum;
using SMOWMS.CommLib;

namespace SMOWMS.UI.UserInfo
{
    partial class frmMessage : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public String UserID;        //用户名
        public EuserInfo eInfo;            //用户修改项
        public Boolean isDemo;       //是否是演示账号
        private EditUserInfoLayout Dialog = new EditUserInfoLayout();     //修改信息
        #endregion
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMessage_Load(object sender, EventArgs e)
        {
            try
            {
                // 设置菜单栏默认选中项
                menuToolbar.SelectedIndex = 4;

                UserID = Client.Session["UserID"].ToString();
                coreUser UserData = autofacConfig.coreUserService.GetUserByID(UserID);
                if (UserData.USER_SEX != null)
                {
                    if (Convert.ToInt32(UserData.USER_SEX) == 0)
                        btnSex.Text = "男   >";
                    else
                        btnSex.Text = "女   >";
                }
                if (UserData.USER_IMAGEID == null)
                {
                    if (Convert.ToInt32(UserData.USER_SEX) == 0)
                        imgUser.ResourceID = "male";
                    else
                        imgUser.ResourceID = "female";
                }
                else
                {
                    imgUser.ResourceID = UserData.USER_IMAGEID;
                }
                if (UserData.USER_ADDRESS != null) txtAddress.Text = UserData.USER_ADDRESS;
                if (UserData.USER_EMAIL != null) lblEmail.Text = UserData.USER_EMAIL;
                lblID.Text = UserID;
                if (UserData.USER_NAME != null)
                {
                    lblName.Text = UserData.USER_NAME;
                }
                else
                {
                    lblName.Text = UserID;
                }
                if (UserData.USER_PHONE != null) lblPhone.Text = UserData.USER_PHONE;
                if (UserData.USER_EMAIL != null) lblEmail.Text = UserData.USER_EMAIL;
                if (UserData.USER_BIRTHDAY != null) dpkBirthday.Value = (DateTime)UserData.USER_BIRTHDAY;

                if (UserData.USER_ISDEMO != null)
                {
                    if (UserData.USER_ISDEMO == 1)
                        isDemo = true;
                    else
                        isDemo = false;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 头像更换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImgUser_Press(object sender, EventArgs e)
        {
            Camera1.GetPhoto();
        }
        /// <summary>
        /// 图片捕获事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Camera1_ImageCaptured(object sender, BinaryResultArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(e.error))
                {
                    e.SaveFile(UserID + ".png");   //保存图片文件到服务器
                    imgUser.ResourceID = UserID;
                    imgUser.Refresh();       //刷新当前显示界面
                    UpdateUserInfo(EuserInfo.修改头像, imgUser.ResourceID);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 修改昵称
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Img_Press(object sender, EventArgs e)
        {
            eInfo = EuserInfo.修改昵称;
            ShowDialog(Dialog);
        }
        /// <summary>
        /// 修改性别
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSex_Press(object sender, EventArgs e)
        {
            popSex.ShowDialog();
        }
        /// <summary>
        /// 选择了性别
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popSex_Selected(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(popSex.Selection.Text) == false)
                {
                    if (btnSex.Text != popSex.Selection.Text + "   >")
                    {
                        btnSex.Text = popSex.Selection.Text + "   >";
                        UpdateUserInfo(EuserInfo.修改性别, popSex.Selection.Value);
                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 修改地址
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLocation_TouchLeave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAddress.Text))
                UpdateUserInfo(EuserInfo.修改地址, "");
            else
                UpdateUserInfo(EuserInfo.修改地址, txtAddress.Text);
        }
        /// <summary>
        /// 选择生日
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dpkBirthday_ValueChanged(object sender, EventArgs e)
        {
            UpdateUserInfo(EuserInfo.修改生日, dpkBirthday.Value.ToString());
        }
        /// <summary>
        /// 账户设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMessage_Press(object sender, EventArgs e)
        {
            try
            {
                if (UserID == "13123456789") throw new Exception("测试用户没有此权限");
                frmSet frm = new frmSet();
                frm.eInfo = eInfo;
                frm.isDemo = isDemo;
                this.Show(frm);
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="Value"></param>
        public void UpdateUserInfo(EuserInfo Type, String Value)
        {
            try
            {
                coreUser UserInfo = new coreUser();
                UserInfo.USER_ID = UserID;
                switch (Type)
                {
                    case EuserInfo.修改地址:
                        UserInfo.USER_ADDRESS = Value;
                        break;
                    case EuserInfo.修改头像:
                        UserInfo.USER_IMAGEID = Value;
                        break;
                    case EuserInfo.修改性别:
                        UserInfo.USER_SEX = Convert.ToInt32(Value);
                        break;
                    case EuserInfo.修改昵称:
                        UserInfo.USER_NAME = Value;
                        break;
                    case EuserInfo.修改生日:
                        UserInfo.USER_BIRTHDAY = Convert.ToDateTime(Value);
                        break;
                    case EuserInfo.修改所属区域:
                        UserInfo.USER_LOCATIONID = Value;
                        break;
                }
                ReturnInfo RInfo = autofacConfig.coreUserService.UpdateUser(UserInfo, Type);
                if (RInfo.IsSuccess)
                {
                    Toast("修改信息成功!");
                }
                else
                {
                    throw new Exception(RInfo.ErrorInfo);
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
        private void frmMessage_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
                Client.Exit();
        }
        /// <summary>
        /// 注销用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Press(object sender, EventArgs e)
        {
            MessageBox.Show("是否注销当前用户？", "系统提醒", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
            {
                if (args.Result == ShowResult.OK)
                    Client.ReStart();
            });
        }
    }
}