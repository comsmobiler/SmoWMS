using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMOWMS.Domain.Entity
{
    /// <summary>
    /// 资产类别
    /// </summary>
    [Table("AssetsType")]
    public class AssetsType : IAggregateRoot
    {
        /// <summary>
        /// 资产类型编号
        /// </summary>
        [Key]
        public string TYPEID { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string NAME { get; set; }
        /// <summary>
        /// 层级
        /// </summary>
        public int? TLEVEL { get; set; }
        /// <summary>
        /// 有效期
        /// </summary>
        public int EXPIRYDATE { get; set; }
        /// <summary>
        /// 有效期时间单位(0 年,1 月, 2 日,默认为月)
        /// </summary>
        public int? EXPIRYDATEUNIT { get; set; }
        /// <summary>
        /// 是否启用(0 不启用，1 启用，默认为1)
        /// </summary>
        public int? ISENABLE { get; set; }
        /// <summary>
        /// 父编码
        /// </summary>
        public string PARENTTYPEID { get; set; }
        /// <summary>
        /// 创建用户
        /// </summary>
        public string CREATEUSER { get; set; }

    }
}
