using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SMOWMS.DTOs.InputDTO
{
    /// <summary>
    /// 资产退货相关信息
    /// </summary>
    public class AssReturnInputDto:IEntity
    {
        /// <summary>
        /// 销售单编号
        /// </summary>
        [Required]
        [DisplayName("销售单编号")]
        public string POID { get; set; }

        /// <summary>
        /// 用户编号
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 退货的序列号
        /// </summary>
        public List<string> sns { get; set; }

    }
}