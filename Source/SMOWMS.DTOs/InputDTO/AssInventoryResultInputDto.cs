using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SMOWMS.DTOs.InputDTO
{
    /// <summary>
    /// 盘点单结果行项
    /// </summary>
    public class AssInventoryResultInputDto : IEntity
    {
        /// <summary>
        /// 结果行项编号
        /// </summary>
        [Required]
        [DisplayName("结果行项编号")]
        public int RROWID { get; set; }

        /// <summary>
        /// 盘点单编号
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("盘点单编号")]
        public string IID { get; set; }

        /// <summary>
        /// 资产编号
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("资产编号")]
        public string ASSID { get; set; }

        /// <summary>
        /// 盘点结果(0-待盘点,1-盘盈,2-盘亏,3-存在)
        /// </summary>
        [Required]
        [DisplayName("盘点结果(0-待盘点,1-盘盈,2-盘亏,3-存在)")]
        public int RESULT { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        [Required]
        [DisplayName("创建日期")]
        public DateTime CREATEDATE { get; set; }

        /// <summary>
        /// 创建者
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("创建者")]
        public string CREATEUSER { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [Required]
        [DisplayName("修改时间")]
        public DateTime MODIFYDATE { get; set; }

        /// <summary>
        /// 修改者
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("修改者")]
        public string MODIFYUSER { get; set; }

    }

}