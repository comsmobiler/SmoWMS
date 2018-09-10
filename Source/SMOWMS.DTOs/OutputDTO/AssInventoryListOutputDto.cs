using System;

namespace SMOWMS.DTOs.OutputDTO
{
    /// <summary>
    /// 盘点单行项信息
    /// </summary>
    public class AssInventoryListOutputDto
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
        /// 盘点状态(0-盘点结束,1-盘点中，2-盘点未开始)
        /// </summary>
        public int STATUS { get; set; }

        /// <summary>
        /// 盘点状态(0-盘点结束,1-盘点中，2-盘点未开始)
        /// </summary>
        public string STATUSNAME { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CREATEDATE { get; set; }

        /// <summary>
        /// 创建者
        /// </summary>
        public string CREATEUSER { get; set; }

        /// <summary>
        /// 需要盘点的数量
        /// </summary>
        public int TOTAL { get; set; }

        /// <summary>
        /// 已盘点数量
        /// </summary>
        public int RESULTCOUNT { get; set; }

        /// <summary>
        /// 是否可编辑
        /// </summary>
        public string CanEdit { get; set; }

        /// <summary>
        /// 是否可删除
        /// </summary>
        public string CanDelete { get; set; }

        /// <summary>
        /// 是否显示"开始盘点"
        /// </summary>
        public string CanStart { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        public string Time { get; set; }
    }
}