using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SMOWMS.DTOs.InputDTO
{
    /// <summary>
    /// 资产退库信息
    /// </summary>
    public class AssRetiringInputDto:IEntity
    {
        /// <summary>
        /// 销售单编号
        /// </summary>
        [Required]
        [DisplayName("销售单编号")]
        public string SOID { get; set; }

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
        /// 序列号集合
        /// </summary>
        public List<string> SnList { get; set; }
    }
}