namespace SMOWMS.DTOs.InputDTO
{
    /// <summary>
    /// 更新采购单行项信息时,行项数据
    /// </summary>
    public class UploadPOResultInputDto
    {
        /// <summary>
        /// 行项编号
        /// </summary>
        public int POROWID { get; set; }

        /// <summary>
        /// 采购数
        /// </summary>
        public decimal QUANTPURCHASED { get; set; }

        /// <summary>
        /// 实际单价
        /// </summary>
        public decimal REALPRICE { get; set; }


    }
}