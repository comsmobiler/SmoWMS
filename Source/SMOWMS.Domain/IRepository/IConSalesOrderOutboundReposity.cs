using SMOWMS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMOWMS.Domain.IRepository
{
    /// <summary>
    /// 销售出库的查询接口
    /// </summary>
    public interface IConSalesOrderOutboundReposity:IRepository<ConSalesOrderOutbound>
    {
        /// <summary>
        /// 根据销售单号和耗材编号获取出库信息
        /// </summary>
        /// <param name="SOID"></param>
        /// <param name="SOROWID"></param>
        /// <returns></returns>
        IQueryable<ConSalesOrderOutbound> GetBySOIDAndSOROWID(string SOID,int SOROWID);
    }
}
