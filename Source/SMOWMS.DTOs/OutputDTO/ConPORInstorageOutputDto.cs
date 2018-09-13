using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SMOWMS.DTOs.OutputDTO
{
    /// <summary>
    /// 耗材采购时，传给前台的数据
    /// </summary>
    public class ConPORInstorageOutputDto
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
        /// 已购数量
        /// </summary>
        [DisplayName("已购数量")]
        public decimal QUANTPURCHASED { get; set; }

        /// <summary>
        /// 入库数量
        /// </summary>
        [DisplayName("入库数量")]
        public decimal QUANTSTORED { get; set; }

        /// <summary>
        /// 退库数量
        /// </summary>
        [DisplayName("退库数量")]
        public decimal QUANTRETREATED { get; set; }
    }
}
