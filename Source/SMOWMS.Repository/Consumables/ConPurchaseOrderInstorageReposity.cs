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
    /// 耗材入库的查询接口实现
    /// </summary>
    public class ConPurchaseOrderInstorageReposity:BaseRepository<ConPurchaseOrderInstorage>, IConPurchaseOrderInstorageReposity
    {
        /// <summary>
        /// 耗材入库查询类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public ConPurchaseOrderInstorageReposity(IDbContext dbContext)
            : base(dbContext)
        { }

        /// <summary>
        /// 根据耗材单和库位查询入库信息
        /// </summary>
        /// <param name="POID"></param>
        /// <param name="POROWID"></param>
        /// <param name="WAREID"></param>
        /// <param name="STID"></param>
        /// <param name="SLID"></param>
        /// <returns></returns>
        public IQueryable<ConPurchaseOrderInstorage> GetByPOIDAndWareID(string POID, int POROWID, string WAREID, string STID, string SLID)
        {
            return _entities.Where(x=>x.POID==POID && x.POROWID== POROWID && x.WAREID == WAREID && x.STID == STID && x.SLID == SLID);
        }

        /// <summary>
        /// 获取某采购单下的入库信息
        /// </summary>
        /// <param name="POID"></param>
        /// <returns></returns>
        public  IQueryable<ConPurchaseOrderInstorage> GetByPOID(string POID)
        {
            return _entities.Where(x=>x.POID==POID);
        }
    }
}
