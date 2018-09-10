using System;

namespace SMOWMS.DTOs.OutputDTO
{
    /// <summary>
    /// 资产
    /// </summary>
    public class AssetsOutputDto
    {
        /// <summary>
        /// 资产条码
        /// </summary>
        public string AssId { get; set; }

        /// <summary>
        /// 类别
        /// </summary>
        public string TypeId { get; set; }

        /// <summary>
        /// 类别名称
        /// </summary>
        public string TypeName { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 规格型号
        /// </summary>
        public string Specification { get; set; }

        /// <summary>
        /// 序列号
        /// </summary>
        public string SN { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        public decimal? Price { get; set; }

        /// <summary>
        /// 库位编号
        /// </summary>
        public string SLID { get; set; }

        /// <summary>
        /// 库位名称
        /// </summary>
        public string SLName { get; set; }

        /// <summary>
        /// 仓库编号
        /// </summary>
        public string WAREID { get; set; }

        /// <summary>
        /// 仓库名称
        /// </summary>
        public string WAREName { get; set; }

        /// <summary>
        /// 存储类型编号
        /// </summary>
        public string STID { get; set; }

        /// <summary>
        /// 存储类型名称
        /// </summary>
        public string STName { get; set; }

        /// <summary>
        /// 地点
        /// </summary>
        public string Place { get; set; }

        /// <summary>
        /// 购入时间
        /// </summary>
        public DateTime BuyDate { get; set; }

        /// <summary>
        /// 图片名称
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// 供应商
        /// </summary>
        public string Vendor { get; set; }

        /// <summary>
        /// 有效期
        /// </summary>
        public DateTime ExpiryDate { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public int? Status { get; set; }

        /// <summary>
        /// 资产模板编号
        /// </summary>
        public string ATID { get; set; }

    }

}