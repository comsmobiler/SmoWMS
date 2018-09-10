using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SMOWMS.DTOs.OutputDTO
{
    public class ConQuantOutputDto
    {
        /// <summary>
        /// 耗材编号
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("耗材编号")]
        public string CID { get; set; }

        /// <summary>
        /// 仓库编号
        /// </summary>
        [StringLength(maximumLength: 10, ErrorMessage = "长度不能超过10")]
        [DisplayName("仓库编号")]
        public string WAREID { get; set; }
        /// <summary>
        /// 仓库名称
        /// </summary>
        [StringLength(maximumLength: 50, ErrorMessage = "长度不能超过50")]
        [DisplayName("仓库名称")]
        public string WARENAME { get; set; }
        /// <summary>
        /// 类型编号
        /// </summary>
        [StringLength(maximumLength: 10, ErrorMessage = "长度不能超过10")]
        [DisplayName("类型编号")]
        public string STID { get; set; }
        /// <summary>
        /// 类型名称
        /// </summary>
        [StringLength(maximumLength: 50, ErrorMessage = "长度不能超过50")]
        [DisplayName("类型名称")]
        public string STNAME { get; set; }
        /// <summary>
        /// 库位编号
        /// </summary>
        [StringLength(maximumLength: 4, ErrorMessage = "长度不能超过4")]
        [DisplayName("库位编号")]
        public string SLID { get; set; }

        /// <summary>
        /// 库位
        /// </summary>
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "长度不能超过50")]
        [DisplayName("名称")]
        public string SLNAME { get; set; }


        /// <summary>
        /// 数量
        /// </summary>
        [Required]
        [DisplayName("数量")]
        public decimal QUANTITY { get; set; }

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
        /// 是否锁定(0-不锁定,1-锁定)
        /// </summary>
        [DisplayName("是否锁定(0-不锁定,1-锁定)")]
        public int ISLOCKED { get; set; }
    }
}
