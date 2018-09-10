using System.Linq;
using SMOWMS.Domain.IRepository;
using SMOWMS.Infrastructure;

namespace SMOWMS.Repository.Consumables
{
    /// <summary>
    /// 耗材的查询实现
    /// </summary>
    public class ConsumablesRepository : BaseRepository<Domain.Entity.Consumables>, IConsumablesRepository
    {
        /// <summary>
        /// 耗材查询类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public ConsumablesRepository(IDbContext dbContext)
            : base(dbContext)
        { }

        /// <summary>
        /// 根据耗材编号得到耗材信息
        /// </summary>
        /// <param name="CID">耗材编号</param>
        /// <returns></returns>
        public IQueryable<Domain.Entity.Consumables> GetByID(string CID)
        {
            return _entities.Where(a => a.CID == CID);
        }

        /// <summary>
        /// 根据名称查询耗材信息
        /// </summary>
        /// <param name="Name">耗材名称</param>
        /// <returns></returns>
        public IQueryable<Domain.Entity.Consumables> GetByName(string Name)
        {
            var list = _entities;
            if (!string.IsNullOrEmpty(Name))
            {
                list = list.Where(a => a.NAME.Contains(Name));
            }
            return list;
        }
        /// <summary>
        /// 得到最大编号
        /// </summary>
        /// <returns></returns>
        public string GetMaxID()
        {
            return _entities.Select(e => e.CID).Max();
        }
    }
}