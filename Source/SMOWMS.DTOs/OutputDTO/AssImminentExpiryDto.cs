using System;

namespace SMOWMS.DTOs.OutputDTO
{
    /// <summary>
    /// 即将过期的资产
    /// </summary>
    public class AssImminentExpiryDto
    {
        /// <summary>
        /// 资产编号
        /// </summary>
        public string ASSID { get; set; }

        /// <summary>
        /// 序列号
        /// </summary>
        public string SN { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        public DateTime ExpiryDate { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        public string IMAGE { get; set; }
    }
}