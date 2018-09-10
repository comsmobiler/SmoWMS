using System;
using System.Collections.Generic;
using System.Linq;
using SMOWMS.Domain.Entity;

namespace SMOWMS.Domain.IRepository
{
    /// <summary>
    /// 固定资产的仓储接口，仅用于查询
    /// </summary>
    public interface IAssetsRepository : IRepository<Assets>
    {
        /// <summary>
        ///  根据类型编号返回资产对象
        /// </summary>
        /// <param name="TypeID">类型编号</param>
        /// <returns></returns>
        IQueryable<Assets> GetByTypeID(String TypeID);

        /// <summary>
        /// 根据资产条码返回资产对象
        /// </summary>
        /// <param name="ASSID">资产编号</param>
        /// <returns></returns>
        IQueryable<Assets> GetByID(String ASSID);

        /// <summary>
        /// 根据序列号返回闲置资产对象
        /// </summary>
        /// <param name="SN">序列号</param>
        /// <returns></returns>
        IQueryable<Assets> GetUnusedBySN(String SN);

        /// <summary>
        /// 判断当前使用人是否有领用或借用资产
        /// </summary>
        /// <param name="UserID">使用人</param>
        /// <returns></returns>
        IQueryable<Assets> GetByUser(String UserID);

        /// <summary>
        /// 查询即将失效的资产
        /// </summary>
        /// <param name="days">天数</param>
        /// <returns></returns>
        IQueryable<Assets> GetImminentAssets(int days);

        /// <summary>
        /// 查询低于安全库存的资产
        /// </summary>
        /// <returns></returns>
        IQueryable<Assets> GetLackOfStockAss();


        /// <summary>
        /// 根据SN或者名称模糊查询资产
        /// </summary>
        /// <param name="SNOrName">序列号或者名称</param>
        /// <param name="types">类型</param>
        /// <returns></returns>
        IQueryable<Assets> QueryAssets(string SNOrName, List<String> types);

        /// <summary>
        /// 根据SN得到资产信息
        /// </summary>
        /// <param name="SN">序列号</param>
        /// <returns></returns>
        IQueryable<Assets> GetAssetsBySN(string SN);

        /// <summary>
        /// 查询SN是否重复
        /// </summary>
        /// <param name="SN">序列号</param>
        /// <returns></returns>
        bool SNIsExists(string SN);

        /// <summary>
        /// 得到最大编号
        /// </summary>
        /// <returns></returns>
        string GetMaxID();

        /// <summary>
        /// 得到在库的序列号列表
        /// </summary>
        /// <param name="snList">序列号列表</param>
        /// <returns></returns>
        Dictionary<string, int> GetCountBySnList(List<string> snList);

        /// <summary>
        /// 得到不在库的序列号列表
        /// </summary>
        /// <param name="snList">序列号列表</param>
        /// <returns></returns>
        Dictionary<string, int> GetCountBySnListEx(List<string> snList);

        /// <summary>
        /// 根据类型和仓库等相关信息，得到盘点清单
        /// </summary>
        /// <param name="WAREID">仓库编号</param>
        /// <param name="STID">存储类型编号</param>
        /// <param name="SLID">库位编号</param>
        /// <param name="typeId">类型编号</param>
        /// <returns></returns>
        IQueryable<Assets> GetInventoryAssetses(string WAREID,string STID,string SLID, string typeId);

    }
}
