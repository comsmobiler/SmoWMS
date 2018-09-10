using System.Data.Entity;
using System.Linq;
using SMOWMS.Domain.Entity;
using SMOWMS.Domain.IRepository;
using SMOWMS.Infrastructure;

namespace SMOWMS.Repository.Assets
{
    /// <summary>
    /// 调拨单行项的仓储实现，仅用于查询
    /// </summary>
    public class AssTransferOrderRowRepository : BaseRepository<AssTransferOrderRow>, IAssTransferOrderRowRepository
    {
        /// <summary>
        /// 仓储类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public AssTransferOrderRowRepository(IDbContext dbContext)
            : base(dbContext)
        { }
        /// <summary>
        /// 根据调拨单行项ID返回行项对象
        /// </summary>
        /// <param name="TOID"></param>
        /// <param name="TOROWID"></param>
        /// <returns></returns>
        public IQueryable<AssTransferOrderRow> GetByID(string TOID, string TOROWID)
        {
            return _entities.Where(x => x.TOID == TOID && x.TOROWID == TOROWID);
        }
        /// <summary>
        /// 根据报修单编号返回调拨单行项信息
        /// </summary>
        /// <param name="TOID"></param>
        /// <returns></returns>
        public IQueryable<AssTransferOrderRow> GetByTOID(string TOID)
        {
            return _entities.Where(x => x.TOID == TOID).OrderByDescending(o => o.TOROWID).AsNoTracking();
        }
        /// <summary>
        /// 根据调拨单编号返回调拨单未完成行项信息
        /// </summary>
        /// <param name="TOID"></param>
        /// <returns></returns>
        public IQueryable<AssTransferOrderRow> GetUnTransferTOID(string TOID)
        {
            return _entities.Where(x => x.TOID == TOID && x.STATUS == 0);
        }
    }
}
