using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SMOWMS.DTOs.OutputDTO
{
    /// <summary>
    /// 销售退货时，传给后台的数据
    /// </summary>
    public class ConSORetiringOutputDto
    {
        /// <summary>
        /// 销售单编号
        /// </summary>
        [StringLength(maximumLength: 10, ErrorMessage = "长度不能超过10")]
        [DisplayName("销售单编号")]
        public string SOID { get; set; }

        /// <summary>
        /// 行项编号
        /// </summary>
        [DisplayName("行项编号")]
        public int SOROWID { get; set; }

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
        /// 已销售数量
        /// </summary>
        [Required]
        [DisplayName("已销售数量")]
        public decimal QUANTSALED { get; set; }

        /// <summary>
        /// 出库数量
        /// </summary>
        [Required]
        [DisplayName("出库数量")]
        public decimal QUANTOUT { get; set; }

        /// <summary>
        /// 退库数量
        /// </summary>
        [Required]
        [DisplayName("退库数量")]
        public decimal QUANTRETREATED { get; set; }
    }
}
