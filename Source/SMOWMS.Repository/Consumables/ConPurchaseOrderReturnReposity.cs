using SMOWMS.Domain.Entity;
using SMOWMS.Domain.IRepository;
using SMOWMS.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMOWMS.Repository.Consumables
{
    /// <summary>
    /// 耗材退库的查询接口实现
    /// </summary>
    public class ConPurchaseOrderReturnReposity : BaseRepository<ConPurchaseOrderReturn>, IConPurchaseOrderReturnReposity
    {
        /// <summary>
        /// 耗材退库查询类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public ConPurchaseOrderReturnReposity(IDbContext dbContext)
            : base(dbContext)
        { }
        public IQueryable<ConPurchaseOrderReturn> GetByPOIDAndWareID(string POID, int POROWID, string WAREID, string STID, string SLID)
        {
            return _entities.Where(x => x.POID == POID && x.POROWID == POROWID && x.WAREID == WAREID && x.STID == STID && x.SLID == SLID);
        }

        /// <summary>
        /// 根据耗材单号查询退库信息
        /// </summary>
        /// <param name="POID"></param>
        /// <returns></returns>
        public IQueryable<ConPurchaseOrderReturn> GetByPOID(string POID)
        {
            return _entities.Where(x=>x.POID==POID);
        }
    }
}
