using System.Linq;
using SMOWMS.Domain.Entity;

namespace SMOWMS.Domain.IRepository
{
    /// <summary>
    /// 采购单的查询接口
    /// </summary>
    public interface IAssPurchaseOrderRepository:IRepository<AssPurchaseOrder>
    {
        /// <summary>
        /// 根据采购单编号得到资产采购单
        /// </summary>
        /// <param name="POID">采购单编号</param>
        /// <returns></returns>
        IQueryable<AssPurchaseOrder> GetById(string POID);

        /// <summary>
        /// 得到最大编号
        /// </summary>
        /// <returns></returns>
        string GetMaxId();
    }
}