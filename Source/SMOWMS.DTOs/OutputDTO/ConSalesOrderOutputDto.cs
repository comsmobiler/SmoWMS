using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SMOWMS.DTOs.OutputDTO
{
    /// <summary>
    /// 耗材销售单输出到前台对象
    /// </summary>
    public  class ConSalesOrderOutputDto
    {
        /// <summary>
        /// 销售单编号
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("销售单编号")]
        public string SOID { get; set; }

        /// <summary>
        /// 实际的销售单编号
        /// </summary>
        [StringLength(maximumLength: 50, ErrorMessage = "长度不能超过50")]
        [DisplayName("实际的销售单编号")]
        public string REALID { get; set; }

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
        /// 名称
        /// </summary>
        [StringLength(maximumLength: 50, ErrorMessage = "长度不能超过50")]
        [DisplayName("名称")]
        public string NAME { get; set; }

        /// <summary>
        /// 销售员
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("销售员")]
        public string SALESPERSON { get; set; }

        /// <summary>
        /// 销售员名称
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("销售员名称")]
        public string SALESPERSONNAME { get; set; }

        /// <summary>
        /// 状态(0-未开始,1-销售中,2-销售完成)
        /// </summary>
        [DisplayName("状态(0-未开始,1-销售中,2-销售完成)")]
        public int STATUS { get; set; }

        /// <summary>
        /// 状态名称
        /// </summary>
        [DisplayName("状态名称")]
        public string STATUSNAME { get; set; }
        /// <summary>
        /// 订单中行项图片(任意一个)
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        public string TIME { get; set; }
        /// <summary>
        /// 是否可编辑
        /// </summary>
        public string CANEDIT { get; set; }

        /// <summary>
        /// 是否可删除
        /// </summary>
        public string CANDELETE { get; set; }

        /// <summary>
        /// 是否显示"开始销售"
        /// </summary>
        public string CANSTART { get; set; }
        /// <summary>
        /// 创建者
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("创建者")]
        public string CREATEUSER { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
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
        [DisplayName("修改日期")]
        public DateTime MODIFYDATE { get; set; }
    }
}
