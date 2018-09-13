using SMOWMS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMOWMS.Domain.IRepository
{
    /// <summary>
    /// 耗材采购单查询接口
    /// </summary>
    public interface IConPurchaseOrderReposity:IRepository<ConPurchaseOrder>
    {
        // <summary>
        /// 得到最大的报修单ID
        /// </summary>
        /// <returns></returns>
        string GetMaxID();
        /// <summary>
        /// 根据采购单编号得到采购单信息
        /// </summary>
        /// <param name="POID"></param>
        /// <returns></returns>
        IQueryable<ConPurchaseOrder> GetById(string POID);
    }
}
