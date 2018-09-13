namespace SMOWMS.DTOs.OutputDTO
{
    /// <summary>
    /// 耗材详情信息
    /// </summary>
    public class ConsumablesOutputDto
    {
        /// <summary>
        /// 耗材编号
        /// </summary>
        public string CID { get; set; }

        /// <summary>
        /// 耗材名称
        /// </summary>
        public string NAME { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        public string IMAGE { get; set; }

        /// <summary>
        /// 规格
        /// </summary>
        public string SPECIFICATION { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public string UNIT { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string NOTE { get; set; }

        /// <summary>
        /// 标准包装数量
        /// </summary>
        public int? SPQ { get; set; }

        /// <summary>
        /// 安全库存上限
        /// </summary>
        public int? SAFECEILING { get; set; }

        /// <summary>
        /// 安全库存下限
        /// </summary>
        public int? SAFEFLOOR { get; set; }
    }
}