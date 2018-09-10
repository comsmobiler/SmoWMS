using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SMOWMS.DTOs.InputDTO
{
    /// <summary>
    /// 资产入库相关信息
    /// </summary>
    public class AssInStorageInputDto:IEntity
    {
        /// <summary>
        /// 采购单编号
        /// </summary>
        [Required]
        [DisplayName("采购单编号")]
        public string POID { get; set; }

        /// <summary>
        /// 资产模板编号
        /// </summary>
        [Required]
        [DisplayName("资产模板编号")]
        public string TEMPLATEID { get; set; }

        /// <summary>
        /// 仓库编号
        /// </summary>
        [Required]
        [DisplayName("仓库编号")]
        public string WAREID { get; set; }

        /// <summary>
        /// 存储类型编号
        /// </summary>
        [Required]
        [DisplayName("存储类型编号")]
        public string STID { get; set; }

        /// <summary>
        /// 库位编号
        /// </summary>
        [Required]
        [DisplayName("库位编号")]
        public string SLID { get; set; }

        /// <summary>
        /// 用户编号
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 序列号
        /// </summary>
        public List<string> SnList { get; set; }
    }
}