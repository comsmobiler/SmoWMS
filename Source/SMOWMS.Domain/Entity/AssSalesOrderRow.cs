using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMOWMS.Domain.Entity
{
    /// <summary>
    /// 资产销售单行项
    /// </summary>
    public class AssSalesOrderRow:IAggregateRoot
    {
        /// <summary>
        /// 行项编号
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("行项编号")]
        public int SOROWID { get; set; }

        /// <summary>
        /// 销售单编号
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("销售单编号")]
        public string SOID { get; set; }

        /// <summary>
        /// 资产模板编号
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("资产模板编号")]
        public string TEMPLATEID { get; set; }

        /// <summary>
        /// 状态(0-未开始,1-销售中,2-销售完成)
        /// </summary>
        [Required]
        [DisplayName("状态")]
        public int STATUS { get; set; }

        /// <summary>
        /// 实际单价
        /// </summary>
        [DisplayName("实际单价")]
        public decimal REALPRICE { get; set; }

        /// <summary>
        /// 已销售数量
        /// </summary>
        [Required]
        [DisplayName("已销售数量")]
        public decimal QUANTSALED { get; set; }

        /// <summary>
        /// 出库数量
        /// </summary>
        [Required]
        [DisplayName("出库数量")]
        public decimal QUANTOUT { get; set; }

        /// <summary>
        /// 退库数量
        /// </summary>
        [Required]
        [DisplayName("退库数量")]
        public decimal QUANTRETREATED { get; set; }

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