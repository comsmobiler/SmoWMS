namespace SMOWMS.DTOs.OutputDTO
{
    /// <summary>
    /// 资产采购单详情
    /// </summary>
    public class AssPurchaseOrderOutputDto
    {
        /// <summary>
        /// 采购单编号
        /// </summary>
        public string POID { get; set; }

        /// <summary>
        /// 实际的采购单编号
        /// </summary>
        public string REALID { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string NAME { get; set; }

        /// <summary>
        /// 采购人
        /// </summary>
        public string PURCHASER { get; set; }

        /// <summary>
        /// 采购人名称
        /// </summary>
        public string PURCHASERNAME { get; set; }

        /// <summary>
        /// 状态(0-未开始,1-采购中,2-采购完成)
        /// </summary>
        public int STATUS { get; set; }

        public int VID { get; set; }

        public string VNAME { get; set; }
    }

}