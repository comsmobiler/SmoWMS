namespace SMOWMS.DTOs.OutputDTO
{
    /// <summary>
    /// 存储类型输出对象
    /// </summary>
    public class WHStorageTypeOutputDto
    {
        /// <summary>
        /// 存储类型编号
        /// </summary>
        public string STID { get; set; }

        /// <summary>
        /// 仓库编号
        /// </summary>
        public string WAREID { get; set; }

        /// <summary>
        /// 仓库名称
        /// </summary>
        public string WARENAME { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string NAME { get; set; }

        /// <summary>
        /// 是否启用(0-不启用，1-启用)
        /// </summary>
        public int ISENABLE { get; set; }
    }
}