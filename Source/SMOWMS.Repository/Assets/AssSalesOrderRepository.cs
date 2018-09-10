using System.Linq;
using SMOWMS.Domain.Entity;
using SMOWMS.Domain.IRepository;
using SMOWMS.Infrastructure;

namespace SMOWMS.Repository.Assets
{
    /// <summary>
    /// 资产销售单的查询接口
    /// </summary>
    public class AssSalesOrderRepository : BaseRepository<AssSalesOrder>, IAssSalesOrderRepository
    {
        /// <summary>
        /// 资产销售单类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public AssSalesOrderRepository(IDbContext dbContext)
            : base(dbContext)
        { }

        /// <summary>
        /// 根据资产销售单编号得到销售单
        /// </summary>
        /// <param name="SOID">资产销售单编号</param>
        /// <returns></returns>
        public IQueryable<AssSalesOrder> GetById(string SOID)
        {
            return _entities.Where(a => a.SOID == SOID);
        }

        /// <summary>
        /// 得到最大编号
        /// </summary>
        /// <returns></returns>
        public string GetMaxId()
        {
            return _entities.Select(a => a.SOID).Max();
        }
    }
}