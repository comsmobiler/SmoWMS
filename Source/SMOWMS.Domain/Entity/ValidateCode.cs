using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMOWMS.Domain.Entity
{
    /// <summary>
    /// 验证信息表
    /// </summary>
    [Table("ValidateCode")]
    public class ValidateCode : IAggregateRoot
    {
        /// <summary>
        /// 编号
        /// </summary>
        [Key]
        public int CODEID { get; set; }
        /// <summary>
        /// 电话号码
        /// </summary>
        public string PHONENUMBER { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string EMAIL { get; set; }
        /// <summary>
        /// 验证码 
        /// </summary>
        public string VCODE { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime? CREATEDATE { get; set; }
        /// <summary>
        /// 设备编号
        /// </summary>
        public string DEVICEID { get; set; }
    }
}
