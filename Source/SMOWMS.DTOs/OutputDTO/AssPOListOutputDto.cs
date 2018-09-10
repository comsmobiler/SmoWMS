using System;

namespace SMOWMS.DTOs.OutputDTO
{
    /// <summary>
    /// 采购单列表
    /// </summary>
    public class AssPOListOutputDto
    {
        /// <summary>
        /// 采购单编号
        /// </summary>
        public string POID { get; set; }

        /// <summary>
        /// 实际的采购单编号
        /// </summary>
        public string REALID { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string NAME { get; set; }

        /// <summary>
        /// 采购人
        /// </summary>
        public string PURCHASER { get; set; }

        /// <summary>
        /// 采购人名称
        /// </summary>
        public string PURCHASERNAME { get; set; }

        /// <summary>
        /// 状态(0-采购中,1-入库中,2-采购完成)
        /// </summary>
        public int STATUS { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public string STATUSNAME { get; set; }

        /// <summary>
        /// 订单中采购行项图片(任意一个)
        /// </summary>
        public string Image { get; set; }
        /// <summary>
        /// 时间
        /// </summary>
        public string Time { get; set; }

        public DateTime CREATEDATE { get; set; }
    }
}