namespace SMOWMS.DTOs.OutputDTO
{
    /// <summary>
    /// 盘点单结果行项
    /// </summary>
    public class AssInventoryResultOutputDto
    {
        /// <summary>
        /// 资产编号
        /// </summary>
        public string ASSID { get; set; }

        /// <summary>
        /// 盘点结果(0-待盘点,1-盘盈,2-盘亏,3-存在)
        /// </summary>
        public int RESULT { get; set; }

        /// <summary>
        /// 盘点结果
        /// </summary>
        public string RESULTNAME { get; set; }

        /// <summary>
        /// 类别
        /// </summary>
        public string TypeId { get; set; }

        /// <summary>
        /// 类别名称
        /// </summary>
        public string TypeName { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 规格型号
        /// </summary>
        public string Specification { get; set; }

        /// <summary>
        /// 序列号
        /// </summary>
        public string SN { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        public decimal? Price { get; set; }

        /// <summary>
        /// 库位编号
        /// </summary>
        public string SLID { get; set; }

        /// <summary>
        /// 库位名称
        /// </summary>
        public string SLName { get; set; }

        /// <summary>
        /// 仓库编号
        /// </summary>
        public string WAREID { get; set; }

        /// <summary>
        /// 仓库名称
        /// </summary>
        public string WAREName { get; set; }

        /// <summary>
        /// 存储类型编号
        /// </summary>
        public string STID { get; set; }

        /// <summary>
        /// 存储类型名称
        /// </summary>
        public string STName { get; set; }


        /// <summary>
        /// 地点
        /// </summary>
        public string Place { get; set; }

        /// <summary>
        /// 图片名称
        /// </summary>
        public string Image { get; set; }

    }

}