using System;
using System.ComponentModel.DataAnnotations;

namespace SMOWMS.DTOs.InputDTO
{
    public class QueryAssCusandVenAnalysisInputDto
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

        /// <summary>
        /// 编号
        /// </summary>
        public int? ID { get; set; }
    }
}