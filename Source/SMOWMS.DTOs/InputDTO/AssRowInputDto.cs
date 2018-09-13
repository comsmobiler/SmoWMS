using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SMOWMS.DTOs.InputDTO
{
    /// <summary>
    /// 资产行项
    /// </summary>
    public class AssRowInputDto:IEntity
    {
        /// <summary>
        /// 资产模板编号
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("资产模板编号")]
        public string TEMPLATEID { get; set; }

        /// <summary>
        /// 计划单价
        /// </summary>
        [Required]
        [DisplayName("计划单价")]
        public decimal PRICE { get; set; }

        /// <summary>
        /// 采购/销售数量
        /// </summary>
        [Required]
        [DisplayName("采购/销售数量")]
        public decimal QUANT { get; set; }
 

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
        /// 模板名称
        /// </summary>
        public string NAME { get; set; }

        /// <summary>
        /// 模板图片
        /// </summary>
        public string IMAGE { get; set; }

        /// <summary>
        /// 模板价格
        /// </summary>
        public decimal TPRICE { get; set; }
    }
}