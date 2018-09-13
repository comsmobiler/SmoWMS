namespace SMOWMS.DTOs.InputDTO
{
    /// <summary>
    /// 更新销售单行项时，行项数据
    /// </summary>
    public class UploadSOResultInputDto
    {
        /// <summary>
        /// 销售单行项编号
        /// </summary>
        public int SOROWID { get; set; }

        /// <summary>
        /// 销售数量
        /// </summary>
        public decimal QUANTSALED { get; set; }

        /// <summary>
        /// 实际单价
        /// </summary>
        public decimal REALPRICE { get; set; }
    }
}