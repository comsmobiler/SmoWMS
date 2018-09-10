using System.Linq;
using SMOWMS.Domain.Entity;
using SMOWMS.Domain.IRepository;
using SMOWMS.Infrastructure;

namespace SMOWMS.Repository.Setting
{
    /// <summary>
    /// 仓库的仓储实现，仅用于查询
    /// </summary>
    public class WarehouseRepository : BaseRepository<WareHouse>, IWarehouseRepository
    {
        /// <summary>
        /// 仓储类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public WarehouseRepository(IDbContext dbContext)
            : base(dbContext)
        { }
        /// <summary>
        /// 根据仓库编号获取仓库信息
        /// </summary>
        /// <param name="WAREID"></param>
        /// <returns></returns>
        public IQueryable<WareHouse> GetById(string WAREID)
        {
            return _entities.Where(x=>x.WAREID==WAREID);
        }

        /// <summary>
        /// 判断是否存在
        /// </summary>
        /// <param name="WAREID">仓库编号</param>
        /// <returns></returns>
        public bool IsExist(string WAREID)
        {
            return _entities.Any(a => a.WAREID == WAREID);
        }
    }
}
