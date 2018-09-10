using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOWMS.DTOs.Enum;
using SMOWMS.UI.Layout;

namespace SMOWMS.UI.UserInfo
{
    partial class frmSet : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public EuserInfo eInfo;            //用户修改项
        public Boolean isDemo;       //是否是演示账号
        #endregion
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tpChangePwd_Press(object sender, EventArgs e)
        {
            try
            {
                if (isDemo)
                {
                    throw new Exception("当前为演示账号，不能进行密码修改!");
                }
                else
                {
                    frmUserPwdLayout UserLayout = new frmUserPwdLayout();
                    eInfo = EuserInfo.修改密码;
                    Form.ShowDialog(UserLayout);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 修改电话
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tpChangePhone_Press(object sender, EventArgs e)
        {
            if (isDemo == false)
            {
                frmUserPwdLayout UserLayout = new frmUserPwdLayout();
                eInfo = EuserInfo.修改电话;
                Form.ShowDialog(UserLayout);
            }
            else
            {
                Toast("当前为演示账号，不能进行电话修改!");
            }
        }
        /// <summary>
        /// 修改邮箱
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tpChangeEmail_Press(object sender, EventArgs e)
        {
            if (isDemo == false)
            {
                frmUserPwdLayout UserLayout = new frmUserPwdLayout();
                eInfo = EuserInfo.修改邮箱;
                Form.ShowDialog(UserLayout);
            }
            else
            {
                Toast("当前为演示账号，不能进行邮箱修改!");
            }
        }
        /// <summary>
        /// 注销用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Press(object sender, EventArgs e)
        {
            MessageBox.Show("是否注销当前用户？", "系统提醒",MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
            {
                if (args.Result == ShowResult.OK)
                {
                    Client.ReStart();
                }
            });
        }
    }
}