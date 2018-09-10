using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SMOWMS.DTOs.InputDTO
{
    /// <summary>
    /// 耗材入库时，传给后台数据
    /// </summary>
    public class ConPORInstorageInputDto
    {

        /// <summary>
        /// 行项编号
        /// </summary>
        [DisplayName("行项编号")]
        public int POROWID { get; set; }

        /// <summary>
        /// 采购单编号
        /// </summary>
        [StringLength(maximumLength: 10, ErrorMessage = "长度不能超过10")]
        [DisplayName("采购单编号")]
        public string POID { get; set; }

        /// <summary>
        /// 耗材编号
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("耗材编号")]
        public string CID { get; set; }

        /// <summary>
        /// 已购数量
        /// </summary>
        [DisplayName("已购数量")]
        public decimal QUANTPURCHASED { get; set; }

        /// <summary>
        /// 仓库编号
        /// </summary>
        [StringLength(maximumLength: 10, ErrorMessage = "长度不能超过10")]
        [DisplayName("仓库编号")]
        public string WAREID { get; set; }

        /// <summary>
        /// 类型编号
        /// </summary>
        [StringLength(maximumLength: 10, ErrorMessage = "长度不能超过10")]
        [DisplayName("类型编号")]
        public string STID { get; set; }

        /// <summary>
        /// 库位编号
        /// </summary>
        [StringLength(maximumLength: 4, ErrorMessage = "长度不能超过4")]
        [DisplayName("库位编号")]
        public string SLID { get; set; }

        /// <summary>
        /// 入库数量
        /// </summary>
        [DisplayName("入库数量")]
        public decimal QUANT { get; set; }
    }
}
