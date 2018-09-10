namespace SMOWMS.DTOs.OutputDTO
{
    /// <summary>
    /// 资产采购单行项
    /// </summary>
    public class AssPORowOutputDto
    {
        /// <summary>
        /// 行项编号
        /// </summary>
        public int POROWID { get; set; }

        /// <summary>
        /// 采购单编号
        /// </summary>
        public string POID { get; set; }

        /// <summary>
        /// 模板编号
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
        /// 计划采购数量
        /// </summary>
        public decimal QUANT { get; set; }

        /// <summary>
        /// 计划采购单价
        /// </summary>
        public decimal PRICE { get; set; }

        /// <summary>
        /// 模板单价
        /// </summary>
        public decimal TPRICE { get; set; }

        /// <summary>
        /// 实际采购单价
        /// </summary>
        public decimal REALPRICE { get; set; }

        /// <summary>
        /// 采购数量
        /// </summary>
        public decimal QUANTPURCHASED { get; set; }

        /// <summary>
        /// 入库数量
        /// </summary>
        public decimal QUANTSTORED { get; set; }

        /// <summary>
        /// 退货数量
        /// </summary>
        public decimal QUANTRETREATED { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public int STATUS { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public string STATUSNAME { get; set; }

    }
}