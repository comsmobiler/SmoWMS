using System.Linq;
using SMOWMS.Domain.Entity;

namespace SMOWMS.Domain.IRepository
{
    /// <summary>
    /// 资产销售单的查询接口
    /// </summary>
    public interface IAssSalesOrderRepository:IRepository<AssSalesOrder>
    {
        /// <summary>
        /// 根据销售单编号得到销售单
        /// </summary>
        /// <param name="SOID">销售单编号</param>
        /// <returns></returns>
        IQueryable<AssSalesOrder> GetById(string SOID);

        /// <summary>
        /// 得到最大编号
        /// </summary>
        /// <returns></returns>
        string GetMaxId();
    }
}