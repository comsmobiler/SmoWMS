using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SMOWMS.DTOs.InputDTO
{
    /// <summary>
    /// 耗材采购单创建时输入数据
    /// </summary>
    public class ConPurchaseOrderInputDto
    {
        /// <summary>
        /// 采购单编号
        /// </summary>
        [StringLength(maximumLength: 10, ErrorMessage = "长度不能超过10")]
        [DisplayName("采购单编号")]
        public string POID { get; set; }
        /// <summary>
        /// 实际的采购单编号
        /// </summary>
        [StringLength(maximumLength: 50, ErrorMessage = "长度不能超过50")]
        [DisplayName("实际的采购单编号")]
        public string REALID { get; set; }


        /// <summary>
        /// 供应商编号
        /// </summary>
        [DisplayName("供应商编号")]
        public int VID { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "长度不能超过50")]
        [DisplayName("名称")]
        public string NAME { get; set; }

        /// <summary>
        /// 采购人
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("采购人")]
        public string PURCHASER { get; set; }

        /// <summary>
        /// 状态(0-未开始,1-采购中,2-采购完成)
        /// </summary>
        [Required]
        [DisplayName("状态(0-未开始,1-采购中,2-采购完成)")]
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
        [Required]
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
        [Required]
        [DisplayName("修改日期")]
        public DateTime MODIFYDATE { get; set; }
        /// <summary>
        /// 采购单行项信息
        /// </summary>
        public List<ConPurchaseOrderRowInputDto> RowData { get; set; }

        /// <summary>
        /// 采购单采购耗材的实购数量和实购价格
        /// </summary>
        public Dictionary<string, List<decimal>> ConDictionary { get; set; }

        /// <summary>
        /// 是否采购结束
        /// </summary>
        public bool IsEnd { get; set; }
    }
}
