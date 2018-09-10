using System.Linq;
using SMOWMS.Domain.Entity;

namespace SMOWMS.Domain.IRepository
{
    public interface IAssSOOutboundRepository:IRepository<AssSalesOrderOutbound>
    {
        /// <summary>
        /// 根据销售单编号得到出库信息
        /// </summary>
        /// <param name="SOID">销售单编号</param>
        /// <returns></returns>
        IQueryable<AssSalesOrderOutbound> GetBySOID(string SOID);
    }
}