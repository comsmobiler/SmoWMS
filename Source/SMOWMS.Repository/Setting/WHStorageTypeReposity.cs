using SMOWMS.Domain.Entity;
using SMOWMS.Domain.IRepository;
using SMOWMS.Infrastructure;
using System.Linq;

namespace SMOWMS.Repository.Setting
{
    /// <summary>
    /// 存储类别的仓储实现，仅用于查询
    /// </summary>
    public class WHStorageTypeReposity : BaseRepository<WHStorageType>, IWHStorageTypeReposity
    {
        /// <summary>
        /// 仓储类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public WHStorageTypeReposity(IDbContext dbContext)
            : base(dbContext)
        { }

        /// <summary>
        /// 根据主键获取类型信息
        /// </summary>
        /// <param name="WAREID">仓库编号</param>
        /// <param name="STID">存储类型编号</param>
        /// <returns></returns>
        public IQueryable<WHStorageType> GetById(string WAREID, string STID)
        {
            return _entities.Where(x=>x.WAREID==WAREID && x.STID==STID);
        }

        /// <summary>
        /// 获取某个仓库下的所有存储类型
        /// </summary>
        /// <param name="WAREID">仓库编号</param>
        /// <returns></returns>
        public IQueryable<WHStorageType> GetByWAREID(string WAREID)
        {
            return _entities.Where(x=>x.WAREID==WAREID);
        }

        /// <summary>
        /// 判断是否存在
        /// </summary>
        /// <param name="WAREID">仓库编号</param>
        /// <param name="STID">存储类型编号</param>
        /// <returns></returns>
        public bool IsExist(string WAREID, string STID)
        {
            return _entities.Any(a => a.WAREID == WAREID && a.STID == STID);
        }
    }
}
