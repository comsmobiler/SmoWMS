using SMOWMS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMOWMS.Domain.IRepository
{
    /// <summary>
    /// 盘点销售退货的查询接口
    /// </summary>
    public interface IConSalesOrderRetiringReposity : IRepository<ConSalesOrderRetiring>
    {
        /// <summary>
        /// 根据销售单和库位查询退货信息信息
        /// </summary>
        /// <param name="SOID"></param>
        /// <param name="SOROWID"></param>
        /// <param name="WAREID"></param>
        /// <param name="STID"></param>
        /// <param name="SLID"></param>
        /// <returns></returns>
        IQueryable<ConSalesOrderRetiring> GetBySOIDAndWareID(string SOID, int SOROWID, string WAREID, string STID, string SLID);
    }
}
