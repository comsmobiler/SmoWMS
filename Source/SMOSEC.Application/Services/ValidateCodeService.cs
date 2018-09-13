using SMOWMS.Application.IServices;
using SMOWMS.Domain.Entity;
using SMOWMS.Domain.IRepository;
using SMOWMS.Infrastructure;
using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using Top.Api;
using Top.Api.Request;
using Top.Api.Response;

namespace SMOWMS.Application.Services
{
    /// <summary>
    /// 验证表的服务接口实现
    /// </summary>
    public class ValidateCodeService : IValidateCodeService
    {
        /// <summary>
        /// 工作单元的接口
        /// </summary>
        private IUnitOfWork _unitOfWork;
        /// <summary>
        /// 库存管理的查询接口
        /// </summary>
        private IValidateCodeRepository _ValidateCodeRepository;
        /// <summary>
        /// 用户信息的查询接口
        /// </summary>
        private IcoreUserRepository _coreUserRepository;
        /// <summary>
        /// 数据库上下文
        /// </summary>
        private SMOWMSDbContext SMOWMSDbContext;

        /// <summary>
        /// 成本中心服务实现的构造函数
        /// </summary>
        public ValidateCodeService(
            IUnitOfWork unitOfWork,
            IValidateCodeRepository ValidateCodeRepository,
            IcoreUserRepository coreUserRepository,
            IDbContext dbContext)
        {
            _unitOfWork = unitOfWork;
            _ValidateCodeRepository = ValidateCodeRepository;
            _coreUserRepository = coreUserRepository;
            SMOWMSDbContext = (SMOWMSDbContext)dbContext;
        }
        #region 查询
        /// <summary>
        /// 查询电话号码是否合法
        /// </summary>
        /// <param name="UserID"></param>
        /// <param name="PHONENUMBER"></param>
        /// <param name="VCODE"></param>
        /// <returns></returns>
        public Boolean isValidate(String UserID, String PHONENUMBER, String VCODE)
        {
            ValidateCode validateCode = _ValidateCodeRepository.GetByPhone(PHONENUMBER, VCODE).FirstOrDefault();
            if (validateCode != null)
            {
                try
                {
                    coreUser coreUser = _coreUserRepository.GetByID(UserID).FirstOrDefault();
                    if (coreUser == null) throw new Exception("用户不存在，请检查!");
                    coreUser.USER_PHONE = PHONENUMBER;
                    coreUser.USER_ISPHONEVALIDATED = 1;
                    _unitOfWork.RegisterDirty(coreUser);
                    _unitOfWork.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    _unitOfWork.Rollback();
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        #endregion
        #region 操作
        /// <summary>
        ///发送验证码
        /// </summary>
        /// <param name="PhoneNumber"></param>
        /// <param name="DeviceID"></param>
        /// <returns></returns>
        public int SendVCode(String PhoneNumber, String DeviceID)
        {
            Random rad = new Random();
            int value = rad.Next(1000, 10000);
            try
            {
                if (PhoneNumber.Length == 11 && (Regex.IsMatch(PhoneNumber, @"^1(3[0-9]|4[57]|5[0-35-9]|7[0135678]|8[0-9])\d{8}$")))
                {
                    try
                    {
                        //此处自行申请
                        ITopClient client = new DefaultTopClient("http://gw.api.taobao.com/router/rest", "****", "****");
                        AlibabaAliqinFcSmsNumSendRequest req = new AlibabaAliqinFcSmsNumSendRequest();
                        //回传参数
                        req.Extend = "123456";
                        //短信状态,一般为normal
                        req.SmsType = "normal";
                        //短信签名
                        req.SmsFreeSignName = "注册验证";
                        //短信模板中的字段对应值
                        req.SmsParam = "{'code':'" + value.ToString() + "','product':'SMOWMS'}";
                        //发送的号码
                        req.RecNum = PhoneNumber;
                        //短信模板ID
                        req.SmsTemplateCode = "SMS_3545338";
                        //返回器的执行结果
                        AlibabaAliqinFcSmsNumSendResponse rsp = client.Execute(req);
                        if (rsp.IsError == false)
                        {
                            //同步创建验证表内数据
                            ValidateCode validateCode = new ValidateCode();
                            validateCode.CREATEDATE = DateTime.Now;
                            validateCode.DEVICEID = DeviceID;
                            validateCode.PHONENUMBER = PhoneNumber;
                            validateCode.VCODE = value.ToString();
                            _unitOfWork.RegisterNew(validateCode);
                            _unitOfWork.Commit();
                            return value;
                        }
                        else
                        {
                            if (rsp.SubErrMsg == "触发业务流控")
                                throw new Exception("对同一个手机号码允许每分钟发送1条短信验证码，累计每小时7条,允许每天50条.");
                            else if (rsp.SubErrMsg == "业务停机")
                                throw new Exception("业务停机,请登陆www.alidayu.com充值.");
                            else if (rsp.SubErrMsg == "余额不足")
                                throw new Exception("余额不足未能发送成功，请登录阿里云管理中心充值后重新发送.");
                            else
                                throw new Exception("发送验证码失败.");
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                else
                {
                    throw new Exception("错误的电话号码");
                }
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback();
                throw ex;
            }
        }
        /// <summary>
        /// 发送验证邮件
        /// </summary>
        /// <param name="Email"></param>
        /// <param name="DeviceID"></param>
        /// <returns></returns>
        public Boolean SendEmail(String Email, String DeviceID)
        {
            try
            {
                if(Regex.IsMatch(Email, @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$", RegexOptions.IgnoreCase))
                {
                    int value = new Random().Next(1000,10000);     //生成大于等于1000，小于10000的随机数
                    String userName = "421835202@qq.com";
                    String pwd = "rasgprchoxfgbjab";
                    String host = "smtp.qq.com";
                    SmtpClient smtpClient = new SmtpClient();
                    smtpClient.Credentials = new NetworkCredential(userName, pwd);
                    smtpClient.Host = host;

                    //如果是gmail 则需要将EnableSsl设置为True,163则设置为False
                    //smtpClient.EnableSsl = false;
                    smtpClient.EnableSsl = true;

                    MailMessage mailMsg = new MailMessage();
                    mailMsg.Priority = MailPriority.High;
                    mailMsg.From = new MailAddress(userName);
                    mailMsg.Subject = "邮箱验证";
                    mailMsg.Body = value.ToString();
                    mailMsg.IsBodyHtml = true;
                    mailMsg.To.Add(new MailAddress(Email));
                    smtpClient.Send(mailMsg);
                    smtpClient = null;

                    ValidateCode validateCode = new ValidateCode();
                    validateCode.CREATEDATE = DateTime.Now;
                    validateCode.DEVICEID = DeviceID;
                    validateCode.PHONENUMBER = Email;
                    validateCode.VCODE = value.ToString();
                    _unitOfWork.RegisterNew(validateCode);
                    _unitOfWork.Commit();
                    return true;
                }
                else
                {
                    throw new Exception("错误的邮箱");
                }
            }
            catch(Exception ex)
            {
                _unitOfWork.Rollback();
                throw ex;
            }
        }
        #endregion
    }
}
