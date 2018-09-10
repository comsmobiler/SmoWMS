using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMOWMS.Domain.Entity
{
    public class AssSalesOrderRetiring : IAggregateRoot
    {
        /// <summary>
        /// 资产退库编号
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("资产退库编号")]
        public int SORID { get; set; }

        /// <summary>
        /// 资产销售单编号
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("销售单编号")]
        public string SOID { get; set; }

        /// <summary>
        /// 资产模板编号
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("模板编号")]
        public string TEMPLATEID { get; set; }

        /// <summary>
        /// 序列号
        /// </summary>
        [Required]
        [StringLength(maximumLength: 200, ErrorMessage = "长度不能超过200")]
        [DisplayName("序列号")]
        public string SN { get; set; }
    }
}