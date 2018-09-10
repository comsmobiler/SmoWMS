using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMOWMS.Application.IServices
{
    /// <summary>
    /// 验证表的服务接口
    /// </summary>
    public interface IValidateCodeService
    {
        #region  查询
        /// <summary>
        /// 查询电话号码是否合法
        /// </summary>
        /// <param name="UserID"></param>
        /// <param name="PHONENUMBER"></param>
        /// <param name="VCODE"></param>
        Boolean isValidate(String UserID,String PHONENUMBER,String VCODE);
        #endregion
        #region  操作
        /// <summary>
        /// 发送验证码
        /// </summary>
        /// <param name="PhoneNumber">手机号</param>
        /// <param name="DeviceID">设备ID</param>
        /// <returns></returns>
        int SendVCode(String PhoneNumber,String DeviceID);
        /// <summary>
        /// 发送验证邮件
        /// </summary>
        /// <param name="Email"></param>
        /// <param name="DeviceID"></param>
        /// <returns></returns>
        Boolean SendEmail(String Email,String DeviceID);
        #endregion
    }
}
