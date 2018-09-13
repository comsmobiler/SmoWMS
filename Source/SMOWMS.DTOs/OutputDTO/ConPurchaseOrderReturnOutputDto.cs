using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SMOWMS.DTOs.OutputDTO
{
    /// <summary>
    /// 耗材退库输出到前台对象
    /// </summary>
    public class ConPurchaseOrderReturnOutputDto
    {
        /// <summary>
        /// 采购单编号
        /// </summary>
        [StringLength(maximumLength: 10, ErrorMessage = "长度不能超过10")]
        [DisplayName("采购单编号")]
        public string POID { get; set; }

        /// <summary>
        /// 行项编号
        /// </summary>
        [DisplayName("行项编号")]
        public int POROWID { get; set; }

        /// <summary>
        /// 耗材编号
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("耗材编号")]
        public string CID { get; set; }

        /// <summary>
        /// 耗材名称
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("耗材名称")]
        public string NAME { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        [StringLength(maximumLength: 200, ErrorMessage = "长度不能超过200")]
        [DisplayName("图片")]
        public string IMAGE { get; set; }

        /// <summary>
        /// 仓库编号
        /// </summary>
        [StringLength(maximumLength: 10, ErrorMessage = "长度不能超过10")]
        [DisplayName("仓库编号")]
        public string WAREID { get; set; }
        /// <summary>
        /// 仓库名称
        /// </summary>
        [StringLength(maximumLength: 50, ErrorMessage = "长度不能超过50")]
        [DisplayName("仓库名称")]
        public string WARENAME { get; set; }
        /// <summary>
        /// 类型编号
        /// </summary>
        [StringLength(maximumLength: 10, ErrorMessage = "长度不能超过10")]
        [DisplayName("类型编号")]
        public string STID { get; set; }
        /// <summary>
        /// 类型名称
        /// </summary>
        [StringLength(maximumLength: 50, ErrorMessage = "长度不能超过50")]
        [DisplayName("类型名称")]
        public string STNAME { get; set; }
        /// <summary>
        /// 库位编号
        /// </summary>
        [StringLength(maximumLength: 4, ErrorMessage = "长度不能超过4")]
        [DisplayName("库位编号")]
        public string SLID { get; set; }

        /// <summary>
        /// 库位
        /// </summary>
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "长度不能超过50")]
        [DisplayName("名称")]
        public string SLNAME { get; set; }

        /// <summary>
        /// 入库数量
        /// </summary>
        [DisplayName("入库数量")]
        public decimal QUANTSTORED { get; set; }
        /// <summary>
        /// 仓库名称/存储类型名称/库位名称
        /// </summary>
        public string LOCNAME { get; set; }
        /// <summary>
        /// 仓库编号/存储类型编号/库位编号
        /// </summary>
        public string LOCID { get; set; }
        /// <summary>
        /// 退库数量
        /// </summary>
        [DisplayName("退库数量")]
        public decimal QUANTRETREATED { get; set; }
    }
}
