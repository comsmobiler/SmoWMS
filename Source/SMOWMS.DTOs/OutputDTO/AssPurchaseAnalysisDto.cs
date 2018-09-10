namespace SMOWMS.DTOs.OutputDTO
{
    /// <summary>
    /// 资产采购报表行项
    /// </summary>
    public class AssPurchaseAnalysisDto
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
        /// 采购数
        /// </summary>
        public decimal QUANTPURCHAED { get; set; }

        /// <summary>
        /// 入库数
        /// </summary>
        public decimal QUANTSTORED { get; set; }

        /// <summary>
        /// 退货数
        /// </summary>
        public decimal QUANTRETREATED { get; set; }

    }
}