using SMOWMS.Domain.Entity;
using SMOWMS.Domain.IRepository;
using SMOWMS.DTOs.Enum;
using SMOWMS.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace SMOWMS.Repository.Consumables
{
    /// <summary>
    /// 耗材采购行项单的查询接口实现
    /// </summary>
    public class ConPurchaseOrderRowReposity : BaseRepository<ConPurchaseOrderRow>, IConPurchaseOrderRowReposity
    {
        /// <summary>
        /// 耗材采购行项的接口构造函数
        /// </summary>
        /// <param name="dbContext"></param>
        public ConPurchaseOrderRowReposity(IDbContext dbContext)
            : base(dbContext)
        { }
        /// <summary>
        /// 根据耗材单号查询耗材行项
        /// </summary>
        /// <param name="POID"></param>
        /// <returns></returns>
        public IQueryable<ConPurchaseOrderRow> GetByPOID(string POID)
        {
            return _entities.Where(x => x.POID == POID);
        }
        /// <summary>
        /// 根据采购单号和耗材编号获取行项信息
        /// </summary>
        /// <param name="POID"></param>
        /// <param name="CID"></param>
        /// <returns></returns>
        public IQueryable<ConPurchaseOrderRow> GetOrderRowByCID(string POID, string CID)
        {
            return _entities.Where(x => x.POID == POID && x.CID == CID);
        }
        /// <summary>
        /// 得到采购单下对应状态的行项
        /// </summary>
        /// <param name="POID"></param>
        /// <param name="Status"></param>
        /// <returns></returns>
        public IQueryable<ConPurchaseOrderRow> GetOrderRowsByStatus(string POID, int? Status)
        {
            var result = _entities.Where(a => a.POID == POID);
            if (Status != null)
            {
                result = result.Where(a => a.STATUS == Status);
            }
            return result;
        }
        /// <summary>
        /// 获取某采购单下可入库行项
        /// </summary>
        /// <param name="POID"></param>
        /// <returns></returns>
        public IQueryable<ConPurchaseOrderRow> GetInStoRowsByPOID(string POID)
        {
            return _entities.Where(a => a.POID == POID && a.QUANTPURCHASED - a.QUANTSTORED > 0);
        }
    }
}
