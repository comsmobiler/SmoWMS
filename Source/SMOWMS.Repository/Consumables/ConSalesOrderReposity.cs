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
    /// 耗材销售单的查询实现
    /// </summary>
    public class ConSalesOrderReposity : BaseRepository<ConSalesOrder>, IConSalesOrderReposity
    {
        public ConSalesOrderReposity(IDbContext dbContext)
            : base(dbContext)
        { }

        /// <summary>
        /// 根据销售单号获取销售单信息
        /// </summary>
        /// <param name="SOID"></param>
        /// <returns></returns>
        public IQueryable<ConSalesOrder> GetById(string SOID)
        {
            return _entities.Where(x => x.SOID == SOID);
        }
        /// <summary>
        /// 获取最大销售单号
        /// </summary>
        /// <returns></returns>
        public string GetMaxID()
        {
            return _entities.Select(x => x.SOID).Max();
        }
    }
}
