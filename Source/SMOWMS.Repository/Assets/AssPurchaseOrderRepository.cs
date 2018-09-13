using System.Linq;
using SMOWMS.Domain.Entity;
using SMOWMS.Domain.IRepository;
using SMOWMS.Infrastructure;

namespace SMOWMS.Repository.Assets
{
    public class AssPurchaseOrderRepository : BaseRepository<AssPurchaseOrder>, IAssPurchaseOrderRepository
    {
        /// <summary>
        /// 固定资产类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public AssPurchaseOrderRepository(IDbContext dbContext)
            : base(dbContext)
        { }

        /// <summary>
        /// 根据采购单编号得到资产采购单
        /// </summary>
        /// <param name="POID">采购单编号</param>
        /// <returns></returns>
        public IQueryable<AssPurchaseOrder> GetById(string POID)
        {
            return _entities.Where(a => a.POID == POID);
        }

        /// <summary>
        /// 得到最大编号
        /// </summary>
        /// <returns></returns>
        public string GetMaxId()
        {
            return _entities.Select(a => a.POID).Max();
        }
    }
}