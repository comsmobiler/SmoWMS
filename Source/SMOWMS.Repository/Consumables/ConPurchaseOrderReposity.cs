using System.Linq;
using SMOWMS.Domain.Entity;
using SMOWMS.Domain.IRepository;
using SMOWMS.Infrastructure;

namespace SMOWMS.Repository.Consumables
{
    /// <summary>
    /// 耗材采购单的查询实现
    /// </summary>
    public class ConPurchaseOrderReposity : BaseRepository<ConPurchaseOrder>, IConPurchaseOrderReposity
    {
        /// <summary>
        /// 耗材采购单查询类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public ConPurchaseOrderReposity(IDbContext dbContext)
            : base(dbContext)
        { }
        /// <summary>
        /// 根据采购单编号获取采购单信息
        /// </summary>
        /// <param name="POID"></param>
        /// <returns></returns>
        public IQueryable<ConPurchaseOrder> GetById(string POID)
        {
            return _entities.Where(a=>a.POID==POID);
        }
        /// <summary>
        /// 获取最大采购单编号
        /// </summary>
        /// <returns></returns>
        public string GetMaxID()
        {
            return _entities.Select(a=>a.POID).Max();
        }
    }
}
