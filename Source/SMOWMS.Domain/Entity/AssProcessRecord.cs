using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMOWMS.Domain.Entity
{
    /// <summary>
    /// 修理记录
    /// </summary>
    public class AssProcessRecord : IAggregateRoot
    {
        /// <summary>
        /// 记录编号
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("记录编号")]
        public int PRID { get; set; }

        /// <summary>
        /// 资产条码
        /// </summary>
//        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("资产条码")]
        public string ASSID { get; set; }
        /// <summary>
        /// 耗材编号
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("耗材编号")]
        public String CID { get; set; }

        /// <summary>
        /// 处理日期
        /// </summary>
        [Required]
        [DisplayName("处理日期")]
        public DateTime HANDLEDATE { get; set; }

        /// <summary>
        /// 处理人
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("处理人")]
        public string HANDLEMAN { get; set; }

        /// <summary>
        /// 处理方式
        /// </summary>
        [Required]
        [DisplayName("处理方式")]
        public int PROCESSMODE { get; set; }

        /// <summary>
        /// 处理内容
        /// </summary>
        [DisplayName("处理内容")]
        public string PROCESSCONTENT { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName("创建时间")]
        public DateTime CREATEDATE { get; set; }

        /// <summary>
        /// 创建用户
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("创建用户")]
        public string CREATEUSER { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [DisplayName("更新时间")]
        public DateTime MODIFYDATE { get; set; }

        /// <summary>
        /// 更新用户
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("更新用户")]
        public string MODIFYUSER { get; set; }
        /// <summary>
        /// 操作数量
        /// </summary>
        public Decimal QUANTITY { get; set; }

    }


}