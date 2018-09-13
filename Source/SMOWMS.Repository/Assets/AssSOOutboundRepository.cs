using System.Linq;
using SMOWMS.Domain.Entity;
using SMOWMS.Domain.IRepository;
using SMOWMS.Infrastructure;

namespace SMOWMS.Repository.Assets
{
    public class AssSOOutboundRepository : BaseRepository<AssSalesOrderOutbound>, IAssSOOutboundRepository
    {
        /// <summary>
        /// 销售单出库类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public AssSOOutboundRepository(IDbContext dbContext)
            : base(dbContext)
        { }

        /// <summary>
        /// 根据销售单编号得到出库信息
        /// </summary>
        /// <param name="SOID">销售单编号</param>
        /// <returns></returns>
        public IQueryable<AssSalesOrderOutbound> GetBySOID(string SOID)
        {
            return _entities.Where(a => a.SOID == SOID);
        }
    }
}