using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;

namespace SMOWMS.DTOs.OutputDTO
{
    /// <summary>
    /// 存储库位输出对象
    /// </summary>
    public class WHStorageLocationOutputDto
    {
        /// <summary>
        /// 仓库编号
        /// </summary>
        public string WAREID { get; set; }
        /// <summary>
        /// 仓库名称
        /// </summary>
        public string WARENAME { get; set; }
        /// <summary>
        /// 类型编号
        /// </summary>
        public string STID { get; set; }
        /// <summary>
        /// 类型名称
        /// </summary>
        public string STNAME { get; set; }
        /// <summary>
        /// 库位编号
        /// </summary>
        public string SLID { get; set; }

        /// <summary>
        /// 库位
        /// </summary>
        public string SLNAME { get; set; }

        /// <summary>
        /// 管理者
        /// </summary>
        public string MANAGER { get; set; }

        /// <summary>
        /// 管理者名称
        /// </summary>
        public string MANAGERNAME { get; set; }

        /// <summary>
        /// 最大承重
        /// </summary>
        public string MAXCAPACITY { get; set; }

        /// <summary>
        /// 最大体积
        /// </summary>
        public string MAXVOLUME { get; set; }

        /// <summary>
        /// 当前承重
        /// </summary>
        public string NOWCAPACITY { get; set; }

        /// <summary>
        /// 当前体积
        /// </summary>
        public string NOWVOLUME { get; set; }

        /// <summary>
        /// 库位状态（0-正常,1-入库冻结,2-出库冻结,3-全部冻结,4-不可用）
        /// </summary>
        public int STATUS { get; set; }
    }
}
