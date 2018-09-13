namespace SMOWMS.DTOs.OutputDTO
{
    public class AssCusAnalysisDto
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
        /// 客户名称
        /// </summary>
        public string CUSNAME { get; set; }
    }
}