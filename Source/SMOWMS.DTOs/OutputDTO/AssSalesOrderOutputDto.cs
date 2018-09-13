namespace SMOWMS.DTOs.OutputDTO
{
    /// <summary>
    /// 资产销售单
    /// </summary>
    public class AssSalesOrderOutputDto
    {
        /// <summary>
        /// 销售单编号
        /// </summary>
        public string SOID { get; set; }

        /// <summary>
        /// 实际编号
        /// </summary>
        public string REALID { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string NAME { get; set; }

        /// <summary>
        /// 仓库编号
        /// </summary>
        public string WAREID { get; set; }

        /// <summary>
        /// 存储类型编号
        /// </summary>
        public string STID { get; set; }

        /// <summary>
        /// 库位编号
        /// </summary>
        public string SLID { get; set; }

        /// <summary>
        /// 销售员编号
        /// </summary>
        public string SALESPERSON { get; set; }

        /// <summary>
        /// 销售员名称
        /// </summary>
        public string SALESPERSONNAME { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public int STATUS { get; set; }

        public int CUSID { get; set; }

        public string CUSNAME { get; set; }
    }
}