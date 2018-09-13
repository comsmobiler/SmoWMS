using SMOWMS.Domain.Entity;
using SMOWMS.Domain.IRepository;
using SMOWMS.DTOs.Enum;
using SMOWMS.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMOWMS.Repository.Consumables
{
    public class ConSalesOrderRowReposity : BaseRepository<ConSalesOrderRow>, IConSalesOrderRowReposity
    {
        public ConSalesOrderRowReposity(IDbContext dbContext) :
            base(dbContext)
        { }
        /// <summary>
        /// 根据销售单号查询销售单下行项信息
        /// </summary>
        /// <param name="SOID"></param>
        /// <returns></returns>
        public IQueryable<ConSalesOrderRow> GetBySOID(string SOID)
        {
            return _entities.Where(x=>x.SOID==SOID);
        }
        /// <summary>
        /// 得到销售单下对应状态的行项
        /// </summary>
        /// <param name="SOID"></param>
        /// <param name="Status"></param>
        /// <returns></returns>
        public IQueryable<ConSalesOrderRow> GetOrderRowsByStatus(string SOID, int? Status)
        {
            var result = _entities.Where(a => a.SOID == SOID);
            if (Status != null)
            {
                if (Status == (int)SalesOrderStatus.销售中)
                {
                    result = result.Where(a => a.STATUS == Status);
                }
                else
                {
                    result = result.Where(a => a.STATUS == 1 || a.STATUS == 2);
                }
            }
            return result;
        }

        /// <summary>
        /// 根据销售单号和耗材编号获取行项信息
        /// </summary>
        /// <param name="SOID"></param>
        /// <param name="CID"></param>
        /// <returns></returns>
        public IQueryable<ConSalesOrderRow> GetOrderRowByCID(string SOID, string CID)
        {
            return _entities.Where(x => x.SOID == SOID && x.CID == CID);
        }
        /// <summary>
        /// 获取某采购单下可出库选项
        /// </summary>
        /// <param name="SOID"></param>
        /// <returns></returns>
        public IQueryable<ConSalesOrderRow> GetOutboundRowsBySOID(string SOID)
        {
            return _entities.Where(a => a.SOID == SOID && a.QUANTSALED - a.QUANTOUT > 0);
        }
    }
}
