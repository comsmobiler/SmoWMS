using SMOWMS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMOWMS.Domain.IRepository
{
    /// <summary>
    /// 耗材采购行项单的查询接口
    /// </summary>
    public interface IConPurchaseOrderRowReposity : IRepository<ConPurchaseOrderRow>
    {
        /// <summary>
        /// 根据耗材单号查询耗材行项
        /// </summary>
        /// <param name="POID"></param>
        /// <returns></returns>
        IQueryable<ConPurchaseOrderRow> GetByPOID(string POID);
        /// <summary>
        /// 根据采购单号和耗材编号获取行项信息
        /// </summary>
        /// <param name="POID"></param>
        /// <param name="CID"></param>
        /// <returns></returns>
        IQueryable<ConPurchaseOrderRow> GetOrderRowByCID(string POID,string CID);
        /// <summary>
        /// 得到采购单下对应状态的行项
        /// </summary>
        /// <param name="POID"></param>
        /// <param name="Status"></param>
        /// <returns></returns>
        IQueryable<ConPurchaseOrderRow> GetOrderRowsByStatus(string POID,int? Status);
        /// <summary>
        /// 获取某采购单下可入库行项
        /// </summary>
        /// <param name="POID"></param>
        /// <returns></returns>
        IQueryable<ConPurchaseOrderRow> GetInStoRowsByPOID(string POID);
    }
}
