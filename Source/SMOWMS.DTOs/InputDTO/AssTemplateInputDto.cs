using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SMOWMS.DTOs.InputDTO
{
    /// <summary>
    /// 资产模板
    /// </summary>
    public class AssTemplateInputDto:IEntity
    {
        /// <summary>
        /// 模板编号
        /// </summary>
        [Key]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("模板编号")]
        public string TEMPLATEID { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "长度不能超过50")]
        [DisplayName("名称")]
        public string NAME { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [Required]
        [StringLength(maximumLength: 4, ErrorMessage = "长度不能超过4")]
        [DisplayName("类型")]
        public string TYPEID { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        [StringLength(maximumLength: 200, ErrorMessage = "长度不能超过200")]
        [DisplayName("图片")]
        public string IMAGE { get; set; }

        /// <summary>
        /// 规格
        /// </summary>
        [StringLength(maximumLength: 200, ErrorMessage = "长度不能超过200")]
        [DisplayName("规格")]
        public string SPECIFICATION { get; set; }


        /// <summary>
        /// 单位
        /// </summary>
        [StringLength(maximumLength: 6, ErrorMessage = "长度不能超过6")]
        [DisplayName("单位")]
        public string UNIT { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        [DisplayName("价格")]
        public decimal? PRICE { get; set; }


        /// <summary>
        /// 管理者
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("管理者")]
        public string MANAGER { get; set; }

        /// <summary>
        /// 供应商
        /// </summary>
        [StringLength(maximumLength: 10, ErrorMessage = "长度不能超过10")]
        [DisplayName("供应商")]
        public string VENDOR { get; set; }

        /// <summary>
        /// 说明
        /// </summary>
        [StringLength(maximumLength: 200, ErrorMessage = "长度不能超过200")]
        [DisplayName("说明")]
        public string NOTE { get; set; }
    }
}