namespace SMOWMS.DTOs.OutputDTO
{
    /// <summary>
    /// 资产销售报表行项
    /// </summary>
    public class AssSaleAnalysisDto
    {
        /// <summary>
        /// 资产模板编号
        /// </summary>
        public string TEMPLATEID { get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        public string NAME { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        public string IMAGE { get; set; }

        /// <summary>
        /// 销售数
        /// </summary>
        public decimal QUANTSALED { get; set; }

        /// <summary>
        /// 出库数
        /// </summary>
        public decimal QUANTOUT { get; set; }

        /// <summary>
        /// 退库数
        /// </summary>
        public decimal QUANTRETREATED { get; set; }
    }
}