using SMOWMS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SMOWMS.DTOs.InputDTO
{
    /// <summary>
    /// 耗材入库/退库 传输入后台对象
    /// </summary>
     public class ConPOInStoInputDto
    {
        /// <summary>
        /// 采购单编号
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("采购单编号")]
        public string POID { get; set; }
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
        /// 创建者
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("创建者")]
        public string CREATEUSER { get; set; }
        /// <summary>
        /// 入库行项信息
        /// </summary>
        public List<ConPurchaseOrderRowInputDto> RowDatas { get; set; }
    } 
}
