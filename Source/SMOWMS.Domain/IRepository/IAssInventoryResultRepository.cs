using System.Collections.Generic;
using System.Linq;
using SMOWMS.Domain.Entity;

namespace SMOWMS.Domain.IRepository
{
    /// <summary>
    /// 盘点单结果行项的查询接口
    /// </summary>
    public interface IAssInventoryResultRepository
    {
        /// <summary>
        /// 根据盘点单编号得到结果行项信息
        /// </summary>
        /// <param name="IID">盘点单编号</param>
        /// <param name="Status">状态</param>
        /// <returns></returns>
        IQueryable<AssInventoryResult> GetResultsByStatus(string IID, int? Status);

        /// <summary>
        /// 查询是否已经有盘点单结果记录
        /// </summary>
        /// <param name="IID">盘点单编号</param>
        /// <returns></returns>
        bool IsExist(string IID);

        /// <summary>
        /// 根据盘点单编号得到结果行项信息
        /// </summary>
        /// <param name="IID">盘点单编号</param>
        /// <param name="Assid">资产编号</param>
        /// <returns></returns>
        IQueryable<AssInventoryResult> GetResultsByAssId(string IID, string Assid);

        /// <summary>
        /// 根据盘点单编号得到需要盘点的资产列表
        /// </summary>
        /// <param name="IID"></param>
        /// <returns></returns>
        List<string> GetOrdinaryList(string IID);
    }
}