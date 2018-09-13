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
    /// 销售出库的查询接口实现
    /// </summary>
    public class ConSalesOrderOutboundReposity : BaseRepository<ConSalesOrderOutbound>, IConSalesOrderOutboundReposity
    {
        /// <summary>
        /// 销售出库查询类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public ConSalesOrderOutboundReposity(IDbContext dbContext)
            : base(dbContext)
        { }

        /// <summary>
        /// 根据销售单号和耗材编号获取出库信息
        /// </summary>
        /// <param name="SOID"></param>
        /// <param name="SOROWID"></param>
        /// <returns></returns>
        public IQueryable<ConSalesOrderOutbound> GetBySOIDAndSOROWID(string SOID, int SOROWID)
        {
            return _entities.Where(x=>x.SOID==SOID && x.SOROWID== SOROWID);
        }
    }
}
