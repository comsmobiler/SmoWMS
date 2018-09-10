using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SMOWMS.DTOs.InputDTO
{
    /// <summary>
    /// 销售单信息
    /// </summary>
    public class AssSalesOrderInputDto : IEntity
    {
        /// <summary>
        /// 销售单编号
        /// </summary>
        [Required]
        [StringLength(maximumLength: 10, ErrorMessage = "长度不能超过10")]
        [DisplayName("销售单编号")]
        public string SOID { get; set; }

        /// <summary>
        /// 实际的销售单编号
        /// </summary>
        [StringLength(maximumLength: 50, ErrorMessage = "长度不能超过50")]
        [DisplayName("实际的销售单编号")]
        public string REALID { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "长度不能超过50")]
        [DisplayName("名称")]
        public string NAME { get; set; }

        /// <summary>
        /// 销售员
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("销售员")]
        public string SALESPERSON { get; set; }

        /// <summary>
        /// 状态(0-未开始,1-销售中,2-销售完成)
        /// </summary>
        [Required]
        [DisplayName("状态(0-未开始,1-销售中,2-销售完成)")]
        public int STATUS { get; set; }

        /// <summary>
        /// 创建者
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("创建者")]
        public string CREATEUSER { get; set; }

        /// <summary>
        /// 修改者
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("修改者")]
        public string MODIFYUSER { get; set; }

        /// <summary>
        /// 客户编号
        /// </summary>
        [DisplayName("客户编号")]
        public int CUSID { get; set; }
        /// <summary>
        /// 销售单行项
        /// </summary>
        public List<AssRowInputDto> RowInputDtos { get; set; }
    }

}