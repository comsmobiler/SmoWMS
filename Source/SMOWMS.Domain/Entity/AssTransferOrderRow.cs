using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMOWMS.Domain.Entity
{
    /// <summary>
    /// 调拨单行项
    /// </summary>
    [Table("AssTransferOrderRow")]
    public class AssTransferOrderRow : IAggregateRoot
    {
        /// <summary>
        /// 调拨单行项编号
        /// </summary>
        [Key]
        [Column(Order = 1)]
        public string TOROWID { get; set; }
        /// <summary>
        /// 调拨单编号
        /// </summary>
        [Key]
        [Column(Order = 2)]
        public string TOID { get; set; }
        /// <summary>
        /// 图片名称
        /// </summary>
        public string IMAGE { get; set; }
        /// <summary>
        /// 资产条码
        /// </summary>
        public string ASSID { get; set; }
        /// <summary>
        /// 序列号
        /// </summary>
        public string SN { get; set; }

        /// <summary>
        /// 耗材编号
        /// </summary>
        public string CID { get; set; }
        /// <summary>
        /// 库位编号
        /// </summary>
        [Required]
        [StringLength(maximumLength: 4, ErrorMessage = "长度不能超过4")]
        [DisplayName("库位编号")]
        public string SLID { get; set; }

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
        /// 调拨中数量
        /// </summary>
        public decimal INTRANSFERQTY { get; set; }
        /// <summary>
        /// 完成调拨数量
        /// </summary>
        public decimal? TRANSFEREDQTY { get; set; }
        /// <summary>
        /// 取消调拨数量
        /// </summary>
        public decimal? TRANSFERCANCELQTY { get; set; }
        /// <summary>
        /// 当前所在部门
        /// </summary>
        public string CURRENTDEP { get; set; }
        /// <summary>
        /// 当前使用人
        /// </summary>
        public string CURRENTUSER { get; set; }
        /// <summary>
        /// 存放地址
        /// </summary>
        public string PLACE { get; set; }
        /// <summary>
        /// 状态(0 调拨中,1 调拨完成,2 取消调拨,默认为调拨中)
        /// </summary>
        public int? STATUS { get; set; }
        /// <summary>
        /// 创建用户
        /// </summary>
        public string CREATEUSER { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CREATEDATE { get; set; }

    }

}
