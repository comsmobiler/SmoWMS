using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SMOWMS.Domain.Entity
{
    /// <summary>
    /// 资产销售单
    /// </summary>
    public class AssSalesOrder:IAggregateRoot
    {
        /// <summary>
        /// 销售单编号
        /// </summary>
        [Key]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("销售单编号")]
        public string SOID { get; set; }

        /// <summary>
        /// 实际的销售单编号
        /// </summary>
        [StringLength(maximumLength: 50, ErrorMessage = "长度不能超过50")]
        [DisplayName("实际的销售单编号")]
        public string REALID { get; set; }

        /// <summary>
        /// 客户编号
        /// </summary>
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
        /// 销售员
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("销售员")]
        public string SALESPERSON { get; set; }

        /// <summary>
        /// 状态(0-未开始,1-销售中,2-销售完成)
        /// </summary>
        [Required]
        [DisplayName("状态(0-未开始,1-销售中,2-销售完成)")]
        public int STATUS { get; set; }

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
        /// 修改者
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("修改者")]
        public string MODIFYUSER { get; set; }

        /// <summary>
        /// 修改日期
        /// </summary>
        [Required]
        [DisplayName("修改日期")]
        public DateTime MODIFYDATE { get; set; }

    }
}