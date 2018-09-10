using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMOWMS.DTOs.OutputDTO
{
    /// <summary>
    /// 耗材输出对象
    /// </summary>
    public class ConOutputDto
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


        /// <summary>
        /// 库位编号
        /// </summary>
        public string SLID { get; set; }

        /// <summary>
        /// 仓库编号
        /// </summary>
        public string WAREID { get; set; }

        /// <summary>
        /// 类型编号
        /// </summary>
        public string STID { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public decimal QUANTITY { get; set; }
    }
}
