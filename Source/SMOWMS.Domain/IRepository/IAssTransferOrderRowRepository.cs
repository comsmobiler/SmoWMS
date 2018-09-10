using System;
using System.Linq;
using SMOWMS.Domain.Entity;

namespace SMOWMS.Domain.IRepository
{
    /// <summary>
    /// 调拨单的仓储实现，仅用于查询
    /// </summary>
    public interface IAssTransferOrderRowRepository : IRepository<AssTransferOrderRow>
    {
        /// <summary>
        /// 根据调拨单行项编号返回调拨单行项信息
        /// </summary>
        /// <param name="TOID"></param>
        /// <param name="TOROWID"></param>
        /// <returns></returns>
        IQueryable<AssTransferOrderRow> GetByID(String TOID, String TOROWID);
        /// <summary>
        /// 根据调拨单编号返回调拨单行项信息
        /// </summary>
        /// <param name="TOID"></param>
        /// <returns></returns>
        IQueryable<AssTransferOrderRow> GetByTOID(String TOID);
        /// <summary>
        /// 根据调拨单编号返回调拨单未完成行项信息
        /// </summary>
        /// <param name="TOID"></param>
        /// <returns></returns>
        IQueryable<AssTransferOrderRow> GetUnTransferTOID(String TOID);
    }
}
