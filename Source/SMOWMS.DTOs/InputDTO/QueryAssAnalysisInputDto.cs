using System;
using System.ComponentModel.DataAnnotations;

namespace SMOWMS.DTOs.InputDTO
{
    /// <summary>
    /// 资产有效期分析/资产采购报表/资产销售报表入参
    /// </summary>
    public class QueryAssAnalysisInputDto:IEntity
    {
        /// <summary>
        /// 开始时间
        /// </summary>
        [Required]
        public DateTime StarTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [Required]
        public DateTime EndTime { get; set; }
    }
}