using System;

namespace SMOWMS.DTOs.OutputDTO
{
    /// <summary>
    /// 操作记录
    /// </summary>
    public class AssProRecordOutputDto
    {
        /// <summary>
        /// 操作记录编号
        /// </summary>
        public string PRID { get; set; }
        /// <summary>
        /// 资产条码
        /// </summary>
        public string ASSID { get; set; }
        /// <summary>
        /// 资产分类编号
        /// </summary>
        public string TYPEID { get; set; }
        /// <summary>
        /// 一级父资产编号
        /// </summary>
        public string Level1 { get; set; }
        /// <summary>
        /// 资产分类名称
        /// </summary>
        public string TYPENAME { get; set; }
        /// <summary>
        /// 资产级别
        /// </summary>
        public int TLEVEL { get; set; }
        /// <summary>
        /// 序列号
        /// </summary>
        public string SN { get; set; }
        /// <summary>
        /// 资产名称
        /// </summary>
        public string NAME { get; set; }
        /// <summary>
        /// 操作类型
        /// </summary>
        public int PROCESSMODE { get; set; }
        /// <summary>
        /// 操作内容
        /// </summary>
        public string PROCESSCONTENT { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CREATEDATE { get; set; }
        /// <summary>
        /// 操作数量
        /// </summary>
        public decimal? QUANTITY { get; set; }
        /// <summary>
        /// 过期时间
        /// </summary>
        public DateTime? EXPIRYDATE { get; set; }
    }
}
