using System;
using System.Linq;
using SMOWMS.Domain.Entity;

namespace SMOWMS.Domain.IRepository
{
    /// <summary>
    /// 调拨单的仓储接口，仅用于查询
    /// </summary>
    public interface IAssTransferOrderRepository : IRepository<AssTransferOrder>
    {
        /// <summary>
        /// 根据调拨单编号，返回调拨单信息
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        IQueryable<AssTransferOrder> GetByID(string ID);
        /// <summary>
        /// 根据用户编号和调拨类型查询调拨单信息
        /// </summary>
        /// <param name="Role"></param>
        /// <param name="ID"></param>
        /// <returns></returns>
        IQueryable<AssTransferOrder> GetByUser(String UserID, int type);
        /// <summary>
        /// 得到最大的调拨单ID
        /// </summary>
        /// <returns></returns>
        String GetMaxID();
    }
}
