using System.Linq;
using SMOWMS.Domain.Entity;
using SMOWMS.Domain.IRepository;
using SMOWMS.Infrastructure;

namespace SMOWMS.Repository.Setting
{
    /// <summary>
    /// 库位的仓储实现，仅用于查询
    /// </summary>
    public class WHStorageLocationRepository : BaseRepository<WHStorageLocation>, IWHStorageLocationRepository
    {
        /// <summary>
        /// 仓储类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public WHStorageLocationRepository(IDbContext dbContext)
            : base(dbContext)
        { }
        /// <summary>
        /// 根据主键查询库位信息
        /// </summary>
        /// <param name="WAREID">仓库编号</param>
        /// <param name="STID">存储类型编号</param>
        /// <param name="SLID">库位编号</param>
        /// <returns></returns>
        public IQueryable<WHStorageLocation> GetById(string WAREID, string STID, string SLID)
        {
            return _entities.Where(x => x.WAREID == WAREID && x.STID==STID && x.SLID==SLID);
        }

        /// <summary>
        /// 获取某个仓库和存储类型下的所有库位
        /// </summary>
        /// <param name="WAREID">仓库编号</param>
        /// <param name="STID">存储类型编号</param>
        /// <returns></returns>
        public IQueryable<WHStorageLocation> GetByWareIdAndSTID(string WAREID, string STID)
        {
            return _entities.Where(x => x.WAREID == WAREID && x.STID == STID);
        }

        /// <summary>
        /// 判断是否存在
        /// </summary>
        /// <param name="WAREID">仓库编号</param>
        /// <param name="STID">存储类型编号</param>
        /// <param name="SLID">库位编号</param>
        /// <returns></returns>
        public bool IsExist(string WAREID, string STID, string SLID)
        {
            return _entities.Any(a => a.WAREID == WAREID && a.STID == STID && a.SLID == SLID);
        }
    }
}
