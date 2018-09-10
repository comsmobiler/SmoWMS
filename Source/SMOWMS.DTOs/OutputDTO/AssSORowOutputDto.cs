namespace SMOWMS.DTOs.OutputDTO
{
    /// <summary>
    /// 资产销售单行项
    /// </summary>
    public class AssSORowOutputDto
    {
        /// <summary>
        /// 行项编号
        /// </summary>
        public int SOROWID { get; set; }

        /// <summary>
        /// 销售单编号
        /// </summary>
        public string SOID { get; set; }

        /// <summary>
        /// 资产模板编号
        /// </summary>
        public string TEMPLATEID { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string NAME { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        public string IMAGE { get; set; }

        /// <summary>
        /// 状态(0-销售中,1-销售完成)
        /// </summary>
        public int STATUS { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public string STATUSNAME { get; set; }

        /// <summary>
        /// 计划单价
        /// </summary>
        public decimal PRICE { get; set; }

        /// <summary>
        /// 模板单价
        /// </summary>
        public decimal TPRICE { get; set; }

        /// <summary>
        /// 实际单价
        /// </summary>
        public decimal REALPRICE { get; set; }

        /// <summary>
        /// 需销售数量
        /// </summary>
        public decimal QUANT { get; set; }

        /// <summary>
        /// 已销售数量
        /// </summary>
        public decimal QUANTSALED { get; set; }

        /// <summary>
        /// 出库数量
        /// </summary>
        public decimal QUANTOUT { get; set; }

        /// <summary>
        /// 退库数量
        /// </summary>
        public decimal QUANTRETREATED { get; set; }
    }
}