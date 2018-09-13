using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SMOWMS.DTOs.InputDTO
{
    public class AssTypeDto : IEntity
    {
        /// <summary>
        /// 资产类型编号
        /// </summary>
        [Key]
        [DisplayName("资产类型编号")]
        public int TYPEID { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
        [Required]
        [DisplayName("NAME")]
        public string NAME { get; set; }
        /// <summary>
        /// 考勤日期
        /// </summary>
        [Required]
        [DisplayName("考勤日期")]
        public DateTime AL_Date { get; set; }
        /// <summary>
        /// 层级
        /// </summary>
        [Required]
        [DisplayName("层级")]
        public String TLEVEL { get; set; }
        /// <summary>
        /// 有效期
        /// </summary>
        [Required]
        [DisplayName("有效期")]
        public int EXPIRYDATE { get; set; }
        /// <summary>
        /// 有效期时间单位(0 年,1 月, 2 日,默认为1)
        /// </summary>
        [Required]
        [DisplayName("有效期时间单位")]
        public int EXPIRYDATEUNIT { get; set; }
        /// <summary>
        /// 是否启用(0 不启用，1 启用，默认为1)
        /// </summary>
        [Required]
        [DisplayName("是否启用")]
        public Boolean ISENABLE { get; set; }
        /// <summary>
        /// 父编码
        /// </summary>
        [DisplayName("父编码")]
        public string PARENTTYPEID { get; set; }
        /// <summary>
        /// 创建用户
        /// </summary>
        [DisplayName("创建用户")]
        public string CREATEUSER { get; set; }
    }
}
