namespace SMOWMS.DTOs.InputDTO
{
    /// <summary>
    /// 耗材列表所用传输数据类型
    /// </summary>
    public class ConsumablesOrderRow
    {
        /// <summary>
        /// 图片名称
        /// </summary>
        public string IMAGE { get; set; }
        /// <summary>
        /// 仓库编号
        /// </summary>
        public string WAREID { get; set; }
        /// <summary>
        /// 仓库名称
        /// </summary>
        public string WARENAME { get; set; }
        /// <summary>
        /// 存储类型编号
        /// </summary>
        public string STID { get; set; }
        /// <summary>
        /// 存储类型名称
        /// </summary>
        public string STNAME { get; set; }
        /// <summary>
        /// 库位编号
        /// </summary>
        public string SLID { get; set; }
        /// <summary>
        /// 库位名称
        /// </summary>
        public string SLNAME { get; set; }
        /// <summary>
        /// 耗材编号
        /// </summary>
        public string CID { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public decimal QTY { get; set; }
        /// <summary>
        /// 当前状态
        /// </summary>
        public int? STATUS { get; set; }
    }
}
