namespace SMOWMS.DTOs.InputDTO
{
    /// <summary>
    /// 资产选择时候，所用数据类型
    /// </summary>
    public class AssetsOrderRow
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
        /// 存储类型编号
        /// </summary>
        public string STID { get; set; }
        /// <summary>
        /// 库位编号
        /// </summary>
        public string SLID { get; set; }
        /// <summary>
        /// 资产条码
        /// </summary>
        public string ASSID { get; set; }
        /// <summary>
        /// 序列号
        /// </summary>
        public string SN { get; set; }
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
