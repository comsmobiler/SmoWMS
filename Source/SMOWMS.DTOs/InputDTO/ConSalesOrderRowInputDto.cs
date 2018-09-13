using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SMOWMS.DTOs.InputDTO
{
    public class ConSalesOrderRowInputDto
    {
        /// <summary>
        /// 行项编号
        /// </summary>
        [DisplayName("行项编号")]
        public int SOROWID { get; set; }

        /// <summary>
        /// 销售单编号
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("销售单编号")]
        public string SOID { get; set; }

        /// <summary>
        /// 耗材编号
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("耗材编号")]
        public string CID { get; set; }

        /// <summary>
        /// 耗材名称
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("耗材名称")]
        public string NAME { get; set; }


        /// <summary>
        /// 客户编号
        /// </summary>
        [DisplayName("客户编号")]
        public int CUSID { get; set; }

        /// <summary>
        /// 客户名称
        /// </summary>
        [DisplayName("客户名称")]
        public string CUSTOMERNAME { get; set; }

        /// <summary>
        /// 规格
        /// </summary>
        [StringLength(maximumLength: 200, ErrorMessage = "长度不能超过200")]
        [DisplayName("规格")]
        public string SPECIFICATION { get; set; }

        /// <summary>
        /// 耗材图片
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("耗材图片")]
        public string IMAGE { get; set; }

        /// <summary>
        /// 状态(0-销售中,1-销售完成)
        /// </summary>
        [DisplayName("状态")]
        public int STATUS { get; set; }


        /// <summary>
        /// 实际单价
        /// </summary>
        [DisplayName("实际单价")]
        public decimal REALPRICE { get; set; }

        /// <summary>
        /// 已销售数量
        /// </summary>
        [DisplayName("已销售数量")]
        public decimal QUANTSALED { get; set; }

        /// <summary>
        /// 出库数量
        /// </summary>
        [Required]
        [DisplayName("出库数量")]
        public decimal QUANTOUT { get; set; }

        /// <summary>
        /// 退库数量
        /// </summary>
        [Required]
        [DisplayName("退库数量")]
        public decimal QUANTRETREATED { get; set; }

        /// <summary>
        /// 创建者
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("创建者")]
        public string CREATEUSER { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        [Required]
        [DisplayName("创建日期")]
        public DateTime CREATEDATE { get; set; }

        /// <summary>
        /// 修改者
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("修改者")]
        public string MODIFYUSER { get; set; }

        /// <summary>
        /// 修改日期
        /// </summary>
        [Required]
        [DisplayName("修改日期")]
        public DateTime MODIFYDATE { get; set; }
    }
}
