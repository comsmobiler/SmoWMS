using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SMOWMS.DTOs.InputDTO
{
    /// <summary>
    /// 仓库
    /// </summary>
    public class WareHouseInputDto : IEntity
    {
        /// <summary>
        /// 仓库编码
        /// </summary>
//        [Key]
        [StringLength(maximumLength: 10, ErrorMessage = "长度不能超过10")]
        [DisplayName("仓库编码")]
        public String WAREID { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        [DisplayName("名称")]
        public String NAME { get; set; }
        /// <summary>
        /// 是否启用(0 不启用，1 启用，默认为1)
        /// </summary>
        [Required]
        [DisplayName("是否启用")]
        public Int32 ISENABLE { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [StringLength(maximumLength: 200, ErrorMessage = "长度不能超过200")]
        [DisplayName("地址")]
        public string PLACE { get; set; }

        /// <summary>
        /// 管理者
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("管理者")]
        public string MANAGER { get; set; }

        /// <summary>
        /// 创建者
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("创建者")]
        public string CREATEUSER { get; set; }

        /// <summary>
        /// 更新人
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("更新人")]
        public string MODIFYUSER { get; set; }
    }
}