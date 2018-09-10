using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMOWMS.Domain.Entity
{
    /// <summary>
    /// 客户
    /// </summary>
    public class Customer : IAggregateRoot
    {
        /// <summary>
        /// 客户编号
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("客户编号")]
        public int CUSID { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "长度不能超过50")]
        [DisplayName("名称")]
        public string NAME { get; set; }

        /// <summary>
        /// 传真
        /// </summary>
        [StringLength(maximumLength: 50, ErrorMessage = "长度不能超过50")]
        [DisplayName("传真")]
        public string FAX { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [StringLength(maximumLength: 200, ErrorMessage = "长度不能超过200")]
        [DisplayName("邮箱")]
        public string EMAIL { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [StringLength(maximumLength: 200, ErrorMessage = "长度不能超过200")]
        [DisplayName("地址")]
        public string ADDRESS { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [StringLength(maximumLength: 200, ErrorMessage = "长度不能超过200")]
        [DisplayName("备注")]
        public string NOTE { get; set; }

        /// <summary>
        /// 税号
        /// </summary>
        [StringLength(maximumLength: 200, ErrorMessage = "长度不能超过50")]
        [DisplayName("税号")]
        public string TAXNUMBER { get; set; }

        /// <summary>
        /// 开户银行
        /// </summary>
        [StringLength(maximumLength: 200, ErrorMessage = "长度不能超过50")]
        [DisplayName("开户银行")]
        public string BANK { get; set; }

        /// <summary>
        /// 账户
        /// </summary>
        [StringLength(maximumLength: 200, ErrorMessage = "长度不能超过50")]
        [DisplayName("账户")]
        public string ACCOUNT { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        [StringLength(maximumLength: 50, ErrorMessage = "长度不能超过50")]
        [DisplayName("联系人")]
        public string CONTACTS { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [StringLength(maximumLength: 50, ErrorMessage = "长度不能超过50")]
        [DisplayName("电话")]
        public string PHONE { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Required]
        [DisplayName("创建时间")]
        public DateTime CREATEDATE { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("创建人")]
        public string CREATEUSER { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [Required]
        [DisplayName("更新时间")]
        public DateTime MODIFYDATE { get; set; }

        /// <summary>
        /// 更新人
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("更新人")]
        public string MODIFYUSER { get; set; }

    }

}