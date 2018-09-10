namespace SMOWMS.DTOs.OutputDTO
{
    /// <summary>
    /// 资产模板选择时，相关信息
    /// </summary>
    public class ATChooseOutputDto
    {
        /// <summary>
        /// 是否选中
        /// </summary>
        public bool IsChecked { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        public string IMAGE { get; set; }

        /// <summary>
        /// 资产模板编号
        /// </summary>
        public string TEMPLATEID { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string NAME { get; set; }

        /// <summary>
        /// 模板单价
        /// </summary>
        public decimal TPRICE { get; set; }

        /// <summary>
        /// 预计单价
        /// </summary>
        public decimal PRICE { get; set; }

        /// <summary>
        /// 预计数量
        /// </summary>
        public decimal QUANT { get; set; }
    }
}