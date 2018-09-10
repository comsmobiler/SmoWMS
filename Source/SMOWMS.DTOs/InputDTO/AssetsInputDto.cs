using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SMOWMS.DTOs.InputDTO
{
    /// <summary>
    /// 资产信息
    /// </summary>
    public class AssetsInputDto : IEntity
    {
        /// <summary>
        /// 资产编号
        /// </summary>
        [Key]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("资产编号")]
        public string ASSID { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [Required]
        [StringLength(maximumLength: 4, ErrorMessage = "长度不能超过4")]
        [DisplayName("类型")]
        public string TYPEID { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "长度不能超过50")]
        [DisplayName("名称")]
        public string NAME { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        [StringLength(maximumLength: 200, ErrorMessage = "长度不能超过200")]
        [DisplayName("图片")]
        public string IMAGE { get; set; }

        /// <summary>
        /// 规格
        /// </summary>
        [StringLength(maximumLength: 200, ErrorMessage = "长度不能超过200")]
        [DisplayName("规格")]
        public string SPECIFICATION { get; set; }

        /// <summary>
        /// 序列号
        /// </summary>
//        [Required]
        [StringLength(maximumLength: 200, ErrorMessage = "长度不能超过200")]
        [DisplayName("序列号")]
        public string SN { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        [StringLength(maximumLength: 6, ErrorMessage = "长度不能超过6")]
        [DisplayName("单位")]
        public string UNIT { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        [DisplayName("价格")]
        public decimal? PRICE { get; set; }

        //        /// <summary>
        //        /// 使用的部门
        //        /// </summary>
        //        [StringLength(maximumLength: 10, ErrorMessage = "长度不能超过10")]
        //        [DisplayName("使用的部门")]
        //        public string DEPARTMENTID { get; set; }

        /// <summary>
        /// 购买日期
        /// </summary>
        [Required]
        [DisplayName("购买日期")]
        public DateTime BUYDATE { get; set; }

        //        /// <summary>
        //        /// 当前使用者
        //        /// </summary>
        //        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        //        [DisplayName("当前使用者")]
        //        public string CURRENTUSER { get; set; }

        /// <summary>
        /// 库位编号
        /// </summary>
        [Required]
        [StringLength(maximumLength: 4, ErrorMessage = "长度不能超过4")]
        [DisplayName("库位编号")]
        public string SLID { get; set; }

        /// <summary>
        /// 仓库编号
        /// </summary>
        [Required]
        [StringLength(maximumLength: 10, ErrorMessage = "长度不能超过10")]
        [DisplayName("仓库编号")]
        public string WAREID { get; set; }

        /// <summary>
        /// 类型编号
        /// </summary>
        [Required]
        [StringLength(maximumLength: 10, ErrorMessage = "长度不能超过10")]
        [DisplayName("类型编号")]
        public string STID { get; set; }

        /// <summary>
        /// 存放地
        /// </summary>
        [StringLength(maximumLength: 50, ErrorMessage = "长度不能超过50")]
        [DisplayName("存放地")]
        public string PLACE { get; set; }

        /// <summary>
        /// 过期日期
        /// </summary>
        [Required]
        [DisplayName("过期日期")]
        public DateTime EXPIRYDATE { get; set; }

        /// <summary>
        /// 供应商
        /// </summary>
        [StringLength(maximumLength: 10, ErrorMessage = "长度不能超过10")]
        [DisplayName("供应商")]
        public string VENDOR { get; set; }

        /// <summary>
        /// 说明
        /// </summary>
        [StringLength(maximumLength: 200, ErrorMessage = "长度不能超过200")]
        [DisplayName("说明")]
        public string NOTE { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        [DisplayName("创建日期")]
        public DateTime CREATEDATE { get; set; }

        /// <summary>
        /// 创建者
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("创建者")]
        public string CREATEUSER { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [DisplayName("更新时间")]
        public DateTime MODIFYDATE { get; set; }

        /// <summary>
        /// 更新人
        /// </summary>
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("更新人")]
        public string MODIFYUSER { get; set; }

        /// <summary>
        /// 当前状态(0 闲置,1 调拨中,2 使用中,3 维修中,4 报废，5借用中)默认为闲置
        /// </summary>
        [DisplayName("当前状态(0 闲置,1 调拨中,2 使用中,3 维修中,4 报废，5借用中)默认为闲置")]
        public int? STATUS { get; set; }

        /// <summary>
        /// 是否锁定(0-不锁定，1-锁定)
        /// </summary>
        [DisplayName("是否锁定(0-不锁定，1-锁定)")]
        public int ISLOCKED { get; set; }

        /// <summary>
        /// 采购单编号
        /// </summary>
        public string POID { get; set; }

        /// <summary>
        /// 模板编号
        /// </summary>
        public string TEMPLATEID { get; set; }

        /// <summary>
        /// 是否在仓库(0-不在，1-在)
        /// </summary>
        [DisplayName("是否在仓库(0-不在，1-在)")]
        public int ISINWAREHOUSE { get; set; }
    }

}