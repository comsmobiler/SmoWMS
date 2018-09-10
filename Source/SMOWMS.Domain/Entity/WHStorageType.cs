using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMOWMS.Domain.Entity
{
    /// <summary>
    /// 仓库存储类型
    /// </summary>
    public class WHStorageType:IAggregateRoot
    {
        /// <summary>
        /// 存储类型编号
        /// </summary>
        [Key, Column(Order = 1)]
        [StringLength(maximumLength: 10, ErrorMessage = "长度不能超过10")]
        [DisplayName("存储类型编号")]
        public string STID { get; set; }

        /// <summary>
        /// 仓库编号
        /// </summary>
        [Key, Column(Order = 2)]
        [StringLength(maximumLength: 10, ErrorMessage = "长度不能超过10")]
        [DisplayName("仓库编号")]
        public string WAREID { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "长度不能超过50")]
        [DisplayName("名称")]
        public string NAME { get; set; }

        /// <summary>
        /// 是否启用(0-不启用，1-启用)
        /// </summary>
        [Required]
        [DisplayName("是否启用")]
        public int ISENABLE { get; set; }

        /// <summary>
        /// 创建者
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("创建者")]
        public string CREATEUSER { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        [Required]
        [DisplayName("创建日期")]
        public DateTime CREATEDATE { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
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