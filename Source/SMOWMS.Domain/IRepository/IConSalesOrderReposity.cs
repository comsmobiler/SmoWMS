using SMOWMS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMOWMS.Domain.IRepository
{
    /// <summary>
    /// 耗材销售单的查询接口
    /// </summary>
    public interface IConSalesOrderReposity:IRepository<ConSalesOrder>
    {
        // <summary>
        /// 得到最大的报修单ID
        /// </summary>
        /// <returns></returns>
        string GetMaxID();
        /// <summary>
        /// 根据销售单编号得到销售单信息
        /// </summary>
        /// <param name="SOID"></param>
        /// <returns></returns>
        IQueryable<ConSalesOrder> GetById(string SOID);
    }
}
