using System;

namespace SMOWMS.DTOs.OutputDTO
{
    public class BarChartOutputDto
    {
        /// <summary>
        /// 资产类型编号
        /// </summary>
        public String TYPEID { get; set; }
        /// <summary>
        /// 资产类型名称
        /// </summary>
        public String TYPENAME { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public Decimal QUANTITY { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CREATEDATE { get; set; }
    }
}
