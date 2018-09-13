using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMOWMS.Domain.Entity
{
    /// <summary>
    /// 用户信息表
    /// </summary>
    [Table("coreUser")]
    public class coreUser: IAggregateRoot
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        [Key]
        public string USER_ID { get; set; }
        /// <summary>
        /// 用户昵称
        /// </summary>
        public string USER_NAME { get; set; }
        /// <summary>
        /// 用户密码 
        /// </summary>
        public string USER_PASSWORD { get; set; }
        /// <summary>
        /// 用户角色
        /// </summary>
        public string USER_ROLE { get; set; }
        /// <summary>
        /// 用户所选语种
        /// </summary>
        public int? USER_LANGUAGE { get; set; }
        /// <summary>
        /// 用户性别(0 男，1 女)
        /// </summary>
        public int? USER_SEX { get; set; }
        /// <summary>
        /// 用户生日
        /// </summary>
        public DateTime? USER_BIRTHDAY { get; set; }
        /// <summary>
        /// 用户区域
        /// </summary>
        public string USER_LOCATIONID { get; set; }

        /// <summary>
        /// 用户地址
        /// </summary>
        public string USER_ADDRESS { get; set; }
        /// <summary>
        /// 用户号码
        /// </summary>
        public string USER_PHONE { get; set; }
        /// <summary>
        /// 用户邮箱
        /// </summary>
        public string USER_EMAIL { get; set; }
        /// <summary>
        /// 用户头像
        /// </summary>
        public string USER_IMAGEID { get; set; }
        /// <summary>
        /// 电话是否合法
        /// </summary>
        public int? USER_ISPHONEVALIDATED { get; set; }
        /// <summary>
        /// 邮箱是否合法
        /// </summary>
        public int? USER_ISEMAILVALIDATED { get; set; }
        /// <summary>
        /// 是否是演示账号
        /// </summary>
        public int? USER_ISDEMO { get; set; }
        /// <summary>
        /// 演示账号名称
        /// </summary>
        public string USER_DEMONAME { get; set; }

        /// <summary>
        /// 部门编号
        /// </summary>
        [StringLength(maximumLength: 10, ErrorMessage = "长度不能超过10")]
        [DisplayName("部门编号")]
        public string USER_DEPARTMENTID { get; set; }
    }
}
