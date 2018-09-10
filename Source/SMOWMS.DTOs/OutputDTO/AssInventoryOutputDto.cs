using System;

namespace SMOWMS.DTOs.OutputDTO
{
    /// <summary>
    /// 盘点单详情
    /// </summary>
    public class AssInventoryOutputDto
    {
        /// <summary>
        /// 盘点单编号
        /// </summary>
        public string IID { get; set; }

        /// <summary>
        /// 盘点名称
        /// </summary>
        public string NAME { get; set; }

        /// <summary>
        /// 盘点人
        /// </summary>
        public string HANDLEMAN { get; set; }

        /// <summary>
        /// 盘点人名称
        /// </summary>
        public string HANDLEMANNAME { get; set; }

        /// <summary>
        /// 盘点仓库
        /// </summary>
        public string WAREID { get; set; }

        /// <summary>
        /// 盘点的仓库名称
        /// </summary>
        public string WareNAME { get; set; }

        /// <summary>
        /// 盘点仓库
        /// </summary>
        public string STID { get; set; }

        /// <summary>
        /// 盘点的仓库名称
        /// </summary>
        public string STNAME { get; set; }

        /// <summary>
        /// 盘点仓库
        /// </summary>
        public string SLID { get; set; }

        /// <summary>
        /// 盘点的仓库名称
        /// </summary>
        public string SLNAME { get; set; }

        /// <summary>
        /// 盘点类型
        /// </summary>
        public string TYPEID { get; set; }

        /// <summary>
        /// 盘点的类型名称
        /// </summary>
        public string TYPENAME { get; set; }

        /// <summary>
        /// 盘点状态(0-盘点结束,1-盘点中)
        /// </summary>
        public int STATUS { get; set; }

        /// <summary>
        /// 盘点状态名
        /// </summary>
        public string STATUSNAME { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CREATEDATE { get; set; }

        /// <summary>
        /// 需要盘点的总数
        /// </summary>
        public int TOTAL { get; set; }
    }

}