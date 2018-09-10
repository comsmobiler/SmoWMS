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
    /// 销售退货的查询接口实现
    /// </summary>
    public class ConSalesOrderRetiringReposity : BaseRepository<ConSalesOrderRetiring>, IConSalesOrderRetiringReposity
    {
        /// <summary>
        /// 销售出库查询类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public ConSalesOrderRetiringReposity(IDbContext dbContext)
            : base(dbContext)
        { }

        /// <summary>
        /// 根据销售单和库位查询退货信息信息
        /// </summary>
        /// <param name="SOID"></param>
        /// <param name="SOROWID"></param>
        /// <param name="WAREID"></param>
        /// <param name="STID"></param>
        /// <param name="SLID"></param>
        /// <returns></returns>
        public IQueryable<ConSalesOrderRetiring> GetBySOIDAndWareID(string SOID, int SOROWID, string WAREID, string STID, string SLID)
        {
            return _entities.Where(x => x.SOID == SOID && x.SOROWID == SOROWID && x.WAREID == WAREID && x.STID == STID && x.SLID == SLID);
        }
    }
}
