using System.Linq;
using SMOWMS.Domain.Entity;

namespace SMOWMS.Domain.IRepository
{
    /// <summary>
    /// 耗材库存查询接口
    /// </summary>
    public interface IConQuantRepository : IRepository<ConQuant>
    {
        /// <summary>
        /// 得到某个耗材的库存总数
        /// </summary>
        /// <param name="CID"></param>
        /// <returns></returns>
        decimal GetSumByCID(string CID);
        /// <summary>
        /// 查询某个耗材的相关库存信息
        /// </summary>
        /// <param name="CID"></param>
        /// <returns></returns>
        IQueryable<ConQuant> GetQuantByCID(string CID);

        /// <summary>
        /// 根据仓库和资产编号返回库存信息
        /// </summary>
        /// <param name="WAREID">区域</param>
        /// <param name="CID">耗材编号</param>
        /// <returns></returns>
        IQueryable<ConQuant> GetQuants(string WAREID, string CID);

        /// <summary>
        /// 根据耗材编号和区域编号查询库存信息
        /// </summary>
        /// <param name="CID"></param>
        /// <param name="WAREID"></param>
        /// <param name="STID"></param>
        /// <param name="SLID"></param>
        /// <returns></returns>
        IQueryable<ConQuant> GetByCID(string CID, string WAREID, string STID, string SLID);

        /// <summary>
        /// 查询除选择库位外的空闲的耗材信息
        /// </summary>
        /// <param name="WAREID"></param>
        /// <param name="STID"></param>
        /// <param name="SLID"></param>
        /// <param name="CID"></param>
        /// <returns></returns>
        IQueryable<ConQuant> GetUnUserCon(string WAREID, string STID, string SLID, string CID);
        /// <summary>
        /// 根据仓库编号,得到盘点清单
        /// </summary>
        /// <param name="WAREID"></param>
        /// <param name="STID"></param>
        /// <param name="SLID"></param>
        /// <returns></returns>
        IQueryable<ConQuant> GetInventoryCons(string WAREID, string STID, string SLID);


    }
}