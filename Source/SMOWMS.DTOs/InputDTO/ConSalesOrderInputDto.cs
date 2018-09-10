using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SMOWMS.DTOs.InputDTO
{
    /// <summary>
    /// 耗材销售单创建时输入数据
    /// </summary>
    public class ConSalesOrderInputDto
    {
        /// <summary>
        /// 销售单编号
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("销售单编号")]
        public string SOID { get; set; }

        /// <summary>
        /// 实际的销售单编号
        /// </summary>
        [StringLength(maximumLength: 50, ErrorMessage = "长度不能超过50")]
        [DisplayName("实际的销售单编号")]
        public string REALID { get; set; }

        /// <summary>
        /// 客户编号
        /// </summary>
        [DisplayName("客户编号")]
        public int CUSID { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [StringLength(maximumLength: 50, ErrorMessage = "长度不能超过50")]
        [DisplayName("名称")]
        public string NAME { get; set; }

        /// <summary>
        /// 销售员
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("销售员")]
        public string SALESPERSON { get; set; }

        /// <summary>
        /// 状态(0-未开始,1-销售中,2-销售完成)
        /// </summary>
        [DisplayName("状态(0-未开始,1-销售中,2-销售完成)")]
        public int STATUS { get; set; }

        /// <summary>
        /// 创建者
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("创建者")]
        public string CREATEUSER { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        [DisplayName("创建日期")]
        public DateTime CREATEDATE { get; set; }

        /// <summary>
        /// 修改者
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("修改者")]
        public string MODIFYUSER { get; set; }

        /// <summary>
        /// 修改日期
        /// </summary>
        [DisplayName("修改日期")]
        public DateTime MODIFYDATE { get; set; }

        /// <summary>
        /// 销售单行项信息
        /// </summary>
        public List<ConSalesOrderRowInputDto> RowData { get; set; }

        /// <summary>
        /// 销售单耗材的实售数量和实售价格
        /// </summary>
        public Dictionary<string, List<decimal>> ConDictionary { get; set; }

        /// <summary>
        /// 是否销售结束
        /// </summary>
        public bool IsEnd { get; set; }
    }
}
