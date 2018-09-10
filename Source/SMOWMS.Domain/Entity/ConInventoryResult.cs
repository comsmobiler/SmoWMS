using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SMOWMS.Domain.Entity
{
    /// <summary>
    /// 耗材盘点单行项
    /// </summary>
    public class ConInventoryResult : IAggregateRoot
    {
        /// <summary>
        /// 行项编号
        /// </summary>
        [Key]
        [DisplayName("行项编号")]
        public int RROWID { get; set; }

        /// <summary>
        /// 盘点单编号
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("盘点单编号")]
        public string IID { get; set; }

        /// <summary>
        /// 耗材编号
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("耗材编号")]
        public string CID { get; set; }

        /// <summary>
        /// 仓库编号
        /// </summary>
        [Required]
        [StringLength(maximumLength: 10, ErrorMessage = "长度不能超过10")]
        [DisplayName("仓库编号")]
        public string WAREID { get; set; }

        /// <summary>
        /// 类型编号
        /// </summary>
        [Required]
        [StringLength(maximumLength: 10, ErrorMessage = "长度不能超过10")]
        [DisplayName("类型编号")]
        public string STID { get; set; }

        /// <summary>
        /// 库位编号
        /// </summary>
        [Required]
        [StringLength(maximumLength: 4, ErrorMessage = "长度不能超过4")]
        [DisplayName("库位编号")]
        public string SLID { get; set; }

        /// <summary>
        /// 需要盘点的数量
        /// </summary>
        [Required]
        [DisplayName("需要盘点的数量")]
        public decimal TOTAL { get; set; }

        /// <summary>
        /// 盘点到的数量
        /// </summary>
        [Required]
        [DisplayName("盘点到的数量")]
        public decimal REALAMOUNT { get; set; }

        /// <summary>
        /// 行项的状态(0-正好,1-盘亏,2-盘盈)
        /// </summary>
        [Required]
        [DisplayName("行项的状态(0-待盘点,1盘盈,2-盘亏，3-存在)")]
        public int RESULT { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        [Required]
        [DisplayName("创建日期")]
        public DateTime CREATEDATE { get; set; }

        /// <summary>
        /// 创建者
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("创建者")]
        public string CREATEUSER { get; set; }

        /// <summary>
        /// 修改日期
        /// </summary>
        [Required]
        [DisplayName("修改日期")]
        public DateTime MODIFYDATE { get; set; }

        /// <summary>
        /// 修改者
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("修改者")]
        public string MODIFYUSER { get; set; }

    }

}