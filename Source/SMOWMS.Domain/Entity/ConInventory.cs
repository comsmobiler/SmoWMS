using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SMOWMS.Domain.Entity
{
    /// <summary>
    /// 耗材盘点单
    /// </summary>
    public class ConInventory : IAggregateRoot
    {
        /// <summary>
        /// 盘点单单号
        /// </summary>
        [Key]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("盘点单单号")]
        public string IID { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        [StringLength(maximumLength: 200, ErrorMessage = "长度不能超过200")]
        [DisplayName("名称")]
        public string NAME { get; set; }

        /// <summary>
        /// 盘点人
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("盘点人")]
        public string HANDLEMAN { get; set; }

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
        [StringLength(maximumLength: 10, ErrorMessage = "长度不能超过10")]
        [DisplayName("类型编号")]
        public string STID { get; set; }

        /// <summary>
        /// 库位编号
        /// </summary>
        [StringLength(maximumLength: 4, ErrorMessage = "长度不能超过4")]
        [DisplayName("库位编号")]
        public string SLID { get; set; }

        /// <summary>
        /// 盘点状态(0-盘点结束,1-盘点中,2-盘点未开始)
        /// </summary>
        [Required]
        [DisplayName("盘点状态(0-盘点结束,1-盘点中,2-盘点未开始)")]
        public int STATUS { get; set; }

        /// <summary>
        /// 需要盘点的总数
        /// </summary>
        [Required]
        [DisplayName("需要盘点的总数")]
        public int TOTAL { get; set; }

        /// <summary>
        /// 实际盘点的数量
        /// </summary>
        [Required]
        [DisplayName("实际盘点的数量")]
        public int RESULTCOUNT { get; set; }

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