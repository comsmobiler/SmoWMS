using System;

namespace SMOWMS.DTOs.OutputDTO
{
    /// <summary>
    /// 资产销售单列表
    /// </summary>
    public class AssSOListOutputDto
    {
        /// <summary>
        /// 销售单编号
        /// </summary>
        public string SOID { get; set; }

        /// <summary>
        /// 实际的销售单编号
        /// </summary>
        public string REALID { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string NAME { get; set; }

        /// <summary>
        /// 销售人
        /// </summary>
        public string SALESPERSON { get; set; }

        /// <summary>
        /// 销售人名称
        /// </summary>
        public string SALESPERSONNAME { get; set; }

        /// <summary>
        /// 状态(0-销售中,1-出库中,2-销售完成)
        /// </summary>
        public int STATUS { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public string STATUSNAME { get; set; }

        /// <summary>
        /// 订单中行项图片(任意一个)
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        public string Time { get; set; }

        public DateTime CREATEDATE { get; set; }
    }
}