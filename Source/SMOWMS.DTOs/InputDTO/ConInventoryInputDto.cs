using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SMOWMS.DTOs.InputDTO
{
    /// <summary>
    /// 耗材盘点单表头
    /// </summary>
    public class ConInventoryInputDto : IEntity
    {
        /// <summary>
        /// 盘点单编号
        /// </summary>
        [Key]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("盘点单编号")]
        public string IID { get; set; }

        /// <summary>
        /// 盘点名称
        /// </summary>
        [Required]
        [StringLength(maximumLength: 200, ErrorMessage = "长度不能超过200")]
        [DisplayName("盘点名称")]
        public string NAME { get; set; }

        /// <summary>
        /// 盘点人
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("盘点人")]
        public string HANDLEMAN { get; set; }

        /// <summary>
        /// 盘点仓库
        /// </summary>
        [Required]
        [StringLength(maximumLength: 128, ErrorMessage = "长度不能超过128")]
        [DisplayName("盘点仓库")]
        public string WAREID { get; set; }
        /// <summary>
        /// 存储类型
        /// </summary>
        [StringLength(maximumLength: 128, ErrorMessage = "长度不能超过128")]
        [DisplayName("存储类型")]
        public string STID { get; set; }
        /// <summary>
        /// 库位
        /// </summary>
        [StringLength(maximumLength: 128, ErrorMessage = "长度不能超过128")]
        [DisplayName("库位")]
        public string SLID { get; set; }

        /// <summary>
        /// 盘点状态(0-盘点结束,1-盘点中)
        /// </summary>
        [Required]
        [DisplayName("盘点状态(0-盘点结束,1-盘点中)")]
        public int STATUS { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Required]
        [DisplayName("创建时间")]
        public DateTime CREATEDATE { get; set; }

        /// <summary>
        /// 创建者
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("创建者")]
        public string CREATEUSER { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [Required]
        [DisplayName("修改时间")]
        public DateTime MODIFYDATE { get; set; }

        /// <summary>
        /// 修改者
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("修改者")]
        public string MODIFYUSER { get; set; }

        /// <summary>
        /// 盘点单盘点耗材的信息
        /// </summary>
        public Dictionary<string, List<decimal>> ConDictionary { get; set; }

        /// <summary>
        /// 是否盘点结束
        /// </summary>
        public bool IsEnd { get; set; }
    }
}
