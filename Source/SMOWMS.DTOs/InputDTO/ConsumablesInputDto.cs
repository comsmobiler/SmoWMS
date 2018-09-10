using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SMOWMS.DTOs.InputDTO
{
    /// <summary>
    /// 耗材信息传输对象
    /// </summary>
    public class ConsumablesInputDto:IEntity
    {
        /// <summary>
        /// 耗材编号
        /// </summary>
        [Key]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("耗材编号")]
        public string CID { get; set; }

        /// <summary>
        /// 耗材名称
        /// </summary>
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "长度不能超过50")]
        [DisplayName("耗材名称")]
        public string NAME { get; set; }

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
        /// 备注
        /// </summary>
        [StringLength(maximumLength: 200, ErrorMessage = "长度不能超过200")]
        [DisplayName("备注")]
        public string NOTE { get; set; }

        /// <summary>
        /// 标准包装数量
        /// </summary>
        [DisplayName("标准包装数量")]
        public int? SPQ { get; set; }

        /// <summary>
        /// 安全库存上限
        /// </summary>
        [DisplayName("安全库存上限")]
        public int? SAFECEILING { get; set; }

        /// <summary>
        /// 安全库存下限
        /// </summary>
        [DisplayName("安全库存下限")]
        public int? SAFEFLOOR { get; set; }

        /// <summary>
        /// 创建用户
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("创建用户")]
        public string CREATEUSER { get; set; }

        /// <summary>
        /// 修改用户
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("修改用户")]
        public string MODIFYUSER { get; set; }
    }
}