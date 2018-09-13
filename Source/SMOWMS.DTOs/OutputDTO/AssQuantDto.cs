namespace SMOWMS.DTOs.OutputDTO
{
    /// <summary>
    /// 资产库存
    /// </summary>
    public class AssQuantDto
    {
        /// <summary>
        /// 资产模板编号
        /// </summary>
        public string TEMPLATEID { get; set; }

        /// <summary>
        /// 资产模板名称
        /// </summary>
        public string NAME { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        public string IMAGE { get; set; }

        /// <summary>
        /// 仓库名称
        /// </summary>
        public string WARENAME { get; set; }

        /// <summary>
        /// 资产类型
        /// </summary>
        public string TYPENAME { get; set; }


        /// <summary>
        /// 库存
        /// </summary>
        public decimal QUANT { get; set; }

    }
}