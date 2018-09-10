namespace SMOWMS.DTOs.OutputDTO
{
    public class AssVenAnalysisDto
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
        /// 供应商名称
        /// </summary>
        public string VendorName { get; set; }
    }
}