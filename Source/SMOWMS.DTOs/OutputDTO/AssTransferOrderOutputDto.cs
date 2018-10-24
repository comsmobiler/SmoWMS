using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMOWMS.DTOs.OutputDTO
{
    /// <summary>
    /// 调拨单输出
    /// </summary>
    public class AssTransferOrderOutputDto
    {
        /// <summary>
        /// 调拨单编号
        /// </summary>
        public string TOID { get; set; }
        /// <summary>
        /// 调拨说明
        /// </summary>
        public string NOTE { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public string CREATEDATE { get; set; }
    }
}
