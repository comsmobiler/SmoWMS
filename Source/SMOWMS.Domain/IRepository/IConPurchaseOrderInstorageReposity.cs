using SMOWMS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMOWMS.Domain.IRepository
{
    /// <summary>
    /// 耗材入库查询接口
    /// </summary>
    public interface IConPurchaseOrderInstorageReposity:IRepository<ConPurchaseOrderInstorage>
    {
        /// <summary>
        /// 根据耗材单和库位查询入库信息
        /// </summary>
        /// <param name="POID"></param>
        /// <param name="POROWID"></param>
        /// <param name="WAREID"></param>
        /// <param name="STID"></param>
        /// <param name="SLID"></param>
        /// <returns></returns>
        IQueryable<ConPurchaseOrderInstorage> GetByPOIDAndWareID(string POID,int POROWID,string WAREID,string STID,string SLID);
        /// <summary>
        /// 获取某采购单下的入库信息
        /// </summary>
        /// <param name="POID"></param>
        /// <returns></returns>
        IQueryable<ConPurchaseOrderInstorage> GetByPOID(string POID);
    }
}
