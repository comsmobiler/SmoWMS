using SMOWMS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using SMOWMS.CommLib;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.DTOs.OutputDTO;

namespace SMOWMS.Application.IServices
{
    /// <summary>
    /// 耗材查询接口
    /// </summary>
    public interface IConsumablesService
    {
        #region 查询
        /// <summary>
        /// 根据库位等编号和耗材编号得到耗材库存
        /// </summary>
        /// <param name="WAREID">仓库编号</param>
        /// <param name="STID">类型编号</param>
        /// <param name="SLID">库位编号</param>
        /// <param name="CID">耗材编号</param>
        /// <returns></returns>
        ConQuant GetQuants(string WAREID, string STID, string SLID, string CID);
        /// <summary>
        /// 库存分析
        /// </summary>
        /// <param name="wareId"></param>
        /// <returns></returns>
        Dictionary<string, decimal> GetQuantAnalyse(string wareId);
        /// <summary>
        /// 安全库存分析
        /// </summary>
        /// <returns></returns>
        List<ConOutputDto> GetSafeQuantAnalyse();

        /// <summary>
        /// 根据库位等编号和耗材编号得到耗材库存
        /// </summary>
        /// <param name="WAREID">仓库编号</param>
        /// <param name="STID">类型编号</param>
        /// <param name="SLID">库位编号</param>
        /// <param name="CID">耗材编号</param>
        /// <returns></returns>
        DataTable GetQuantsEx(string WAREID, string STID, string SLID, string CID);

        /// <summary>
        /// 得到耗材列表
        /// </summary>
        /// <returns></returns>
        DataTable GetConList();

        /// <summary>
        /// 获取某个耗材的库存总数
        /// </summary>
        /// <param name="CID"></param>
        /// <returns></returns>
        decimal GetSumByCID(string CID);
        /// <summary>
        /// 根据耗材编号查询耗材信息
        /// </summary>
        /// <param name="CID">耗材编号</param>
        /// <returns></returns>
        Consumables GetConsById(string CID);

        /// <summary>
        /// 查找所有耗材(根据耗材名称)
        /// </summary>
        /// <param name="name">耗材名称</param>
        /// <returns></returns>
        List<Consumables> GetConsByName(string name);
        #endregion

        #region 操作
        /// <summary>
        /// 添加耗材
        /// </summary>
        /// <param name="inputDto">耗材信息</param>
        /// <returns></returns>
        ReturnInfo AddConsumables(ConsumablesInputDto inputDto);

        /// <summary>
        /// 更新耗材
        /// </summary>
        /// <param name="inputDto">耗材信息</param>
        /// <returns></returns>
        ReturnInfo UpdateConsumables(ConsumablesInputDto inputDto);

        /// <summary>
        /// 删除耗材
        /// </summary>
        /// <param name="CID">耗材编号</param>
        /// <returns></returns>
        ReturnInfo DeleteConsumables(string CID);

        #endregion

    }
}
