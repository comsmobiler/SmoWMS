using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SMOWMS.DTOs.InputDTO
{
    /// <summary>
    /// 资产出库相关信息
    /// </summary>
    public class AssSalesInputDto:IEntity
    {
        /// <summary>
        /// 用户编号
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 资产销售单编号
        /// </summary>
        [Required]
        [DisplayName("资产销售单编号")]
        public string SOID { get; set; }

        /// <summary>
        /// 序列号
        /// </summary>
        public List<string> sns { get; set; }
    }
}