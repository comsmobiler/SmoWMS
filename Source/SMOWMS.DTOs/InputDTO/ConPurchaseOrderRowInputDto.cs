using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SMOWMS.DTOs.InputDTO
{
    /// <summary>
    /// 耗材采购时，传给后台的数据
    /// </summary>
    public class ConPurchaseOrderRowInputDto
    {
        /// <summary>
        /// 行项编号
        /// </summary>
        [DisplayName("行项编号")]
        public int POROWID { get; set; }

        /// <summary>
        /// 采购单编号
        /// </summary>
        [StringLength(maximumLength: 10, ErrorMessage = "长度不能超过10")]
        [DisplayName("采购单编号")]
        public string POID { get; set; }

        /// <summary>
        /// 供应商编号
        /// </summary>
        [DisplayName("供应商编号")]
        public int VID { get; set; }

        /// <summary>
        /// 供应商名称
        /// </summary>
        [DisplayName("供应商名称")]
        public string VENDORNAME { get; set; }

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
        /// 计划采购数量
        /// </summary>
        [DisplayName("计划采购数量")]
        public decimal QUANT { get; set; }

        /// <summary>
        /// 计划单价
        /// </summary>
        [Required]
        [DisplayName("计划单价")]
        public decimal PRICE { get; set; }

        /// <summary>
        /// 实际单价
        /// </summary>
        [DisplayName("实际单价")]
        public decimal REALPRICE { get; set; }

        /// <summary>
        /// 已购数量
        /// </summary>
        [DisplayName("已购数量")]
        public decimal QUANTPURCHASED { get; set; }

        /// <summary>
        /// 入库数量
        /// </summary>
        [DisplayName("入库数量")]
        public decimal QUANTSTORED { get; set; }

        /// <summary>
        /// 退库数量
        /// </summary>
        [DisplayName("退库数量")]
        public decimal QUANTRETREATED { get; set; }

        /// <summary>
        /// 状态(0-采购中,1-入库中,2-已完成)
        /// </summary>
        [DisplayName("状态")]
        public int STATUS { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        [Required]
        [DisplayName("创建日期")]
        public DateTime CREATEDATE { get; set; }

        /// <summary>
        /// 修改日期
        /// </summary>
        [Required]
        [DisplayName("修改日期")]
        public DateTime MODIFYDATE { get; set; }

        /// <summary>
        /// 仓库编号
        /// </summary>
        [StringLength(maximumLength: 10, ErrorMessage = "长度不能超过10")]
        [DisplayName("仓库编号")]
        public string WAREID { get; set; }
        /// <summary>
        /// 类型编号
        /// </summary>
        [StringLength(maximumLength: 10, ErrorMessage = "长度不能超过10")]
        [DisplayName("类型编号")]
        public string STID { get; set; }
        /// <summary>
        /// 库位编号
        /// </summary>
        [StringLength(maximumLength: 4, ErrorMessage = "长度不能超过4")]
        [DisplayName("库位编号")]
        public string SLID { get; set; }
    }
}
