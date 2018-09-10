using SMOWMS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMOWMS.Domain.IRepository
{
    /// <summary>
    /// 耗材销售单行项的查询接口
    /// </summary>
    public interface IConSalesOrderRowReposity:IRepository<ConSalesOrderRow>
    {
        /// <summary>
        /// 根据耗材单号查询销售单行项
        /// </summary>
        /// <param name="SOID"></param>
        /// <returns></returns>
        IQueryable<ConSalesOrderRow> GetBySOID(string SOID);
        /// <summary>
        /// 得到销售单下对应状态的行项
        /// </summary>
        /// <param name="SOID"></param>
        /// <param name="Status"></param>
        /// <returns></returns>
        IQueryable<ConSalesOrderRow> GetOrderRowsByStatus(string SOID, int? Status);
        /// <summary>
        /// 根据销售单号和耗材编号获取行项信息
        /// </summary>
        /// <param name="SOID"></param>
        /// <param name="CID"></param>
        /// <returns></returns>
        IQueryable<ConSalesOrderRow> GetOrderRowByCID(string SOID, string CID);
        /// <summary>
        /// 获取某采购单下可出库选项
        /// </summary>
        /// <param name="SOID"></param>
        /// <returns></returns>
        IQueryable<ConSalesOrderRow> GetOutboundRowsBySOID(string SOID);
    }
}
