using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMOWMS.Domain.Entity
{
    /// <summary>
    /// 库位
    /// </summary>
    public class WHStorageLocation : IAggregateRoot
    {
        /// <summary>
        /// 库位编号
        /// </summary>
        [Key, Column(Order = 1)]
        [StringLength(maximumLength: 4, ErrorMessage = "长度不能超过4")]
        [DisplayName("库位编号")]
        public string SLID { get; set; }

        /// <summary>
        /// 仓库编号
        /// </summary>
        [Key, Column(Order = 2)]
        [StringLength(maximumLength: 10, ErrorMessage = "长度不能超过10")]
        [DisplayName("仓库编号")]
        public string WAREID { get; set; }

        /// <summary>
        /// 类型编号
        /// </summary>
        [Key, Column(Order = 3)]
        [StringLength(maximumLength: 10, ErrorMessage = "长度不能超过10")]
        [DisplayName("类型编号")]
        public string STID { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "长度不能超过50")]
        [DisplayName("名称")]
        public string NAME { get; set; }

        /// <summary>
        /// 管理者
        /// </summary>
        [Required]
        [StringLength(20, ErrorMessage = "长度不能超过20")]
        [DisplayName("管理者")]
        public string MANAGER { get; set; }

        /// <summary>
        /// 最大承重
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("最大承重")]
        public string MAXCAPACITY { get; set; }

        /// <summary>
        /// 最大体积
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("最大体积")]
        public string MAXVOLUME { get; set; }

        /// <summary>
        /// 当前承重
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("当前承重")]
        public string NOWCAPACITY { get; set; }

        /// <summary>
        /// 当前体积
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("当前体积")]
        public string NOWVOLUME { get; set; }

        /// <summary>
        /// 库位状态（0-正常,1-入库冻结,2-出库冻结,3-全部冻结,4-不可用）
        /// </summary>
        [Required]
        [DisplayName("库位状态（0-正常,1-入库冻结,2-出库冻结,3-全部冻结,4-不可用）")]
        public int STATUS { get; set; }

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