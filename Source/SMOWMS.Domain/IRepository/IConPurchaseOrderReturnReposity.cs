using SMOWMS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMOWMS.Domain.IRepository
{
    /// <summary>
    /// 耗材退库查询接口
    /// </summary>
    public interface IConPurchaseOrderReturnReposity:IRepository<ConPurchaseOrderReturn>
    {
        /// <summary>
        /// 根据耗材单和库位查询退库信息
        /// </summary>
        /// <param name="POID"></param>
        /// <param name="POROWID"></param>
        /// <param name="WAREID"></param>
        /// <param name="STID"></param>
        /// <param name="SLID"></param>
        /// <returns></returns>
        IQueryable<ConPurchaseOrderReturn> GetByPOIDAndWareID(string POID, int POROWID, string WAREID, string STID, string SLID);
        /// <summary>
        /// 根据耗材单号查询退库信息
        /// </summary>
        /// <param name="POID"></param>
        /// <returns></returns>
        IQueryable<ConPurchaseOrderReturn> GetByPOID(string POID);
    }
}
