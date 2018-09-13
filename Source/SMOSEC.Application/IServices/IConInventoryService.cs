using SMOWMS.CommLib;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.Enum;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.DTOs.OutputDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SMOWMS.Application.IServices
{
    /// <summary>
    /// 耗材盘点的服务接口
    /// </summary>
    public interface IConInventoryService
    {
        #region 查询

        /// <summary>
        /// 得到盘点单列表
        /// </summary>
        /// <param name="UserId">处理人编号</param>
        /// <param name="WAREID">仓库编号</param>
        /// <returns></returns>
        DataTable GetConInventoryList(string UserId, string WAREID);

        /// <summary>
        /// 根据盘点单编号得到盘点单详情
        /// </summary>
        /// <param name="IID">盘点单编号</param>
        /// <returns></returns>
        ConInventoryOutputDto GetConInventoryById(string IID);
        /// <summary>
        /// 根据库位和物料，查询盘点单行项详情
        /// </summary>
        /// <param name="IID"></param>
        /// <param name="CID"></param>
        /// <param name="WAREID"></param>
        /// <param name="STID"></param>
        /// <param name="SLID"></param>
        /// <returns></returns>
        ConInventoryResult GetResultBySL(string IID, string CID, string WAREID, string STID, string SLID);
        /// <summary>
        /// 根据库存和盘点单号，查询该盘点单下，该库位下的盘点单行项
        /// </summary>
        /// <param name="IID"></param>
        /// <param name="WAREID"></param>
        /// <param name="STID"></param>
        /// <param name="SLID"></param>
        /// <returns></returns>
        List<ConInventoryResult> GetResultListBySL(string IID,string WAREID, string STID, string SLID);
        /// <summary>
        /// 根据盘点单号和耗材编号查询盘点行项
        /// </summary>
        /// <param name="IID"></param>
        /// <param name="CID"></param>
        /// <returns></returns>
        ConInventoryResult GetResultByCID(string IID, string CID);

        /// <summary>
        /// 根据盘点单编号和状态得到结果行项信息
        /// </summary>
        /// <param name="IID">盘点单编号</param>
        /// <param name="Status">状态</param>
        /// <returns></returns>
        DataTable GetConInventoryResultsByIID(string IID, ResultStatus Status);

        /// <summary>
        /// 查询是否已经有盘点单结果记录
        /// </summary>
        /// <param name="IID">盘点单编号</param>
        /// <returns></returns>
        bool IsExist(string IID);

        /// <summary>
        /// 根据库位获取待盘点列表
        /// </summary>
        /// <param name="WAREID"></param>
        /// <param name="STID"></param>
        /// <param name="SLID"></param>
        /// <returns></returns>
        DataTable GetInventoryConList(string WAREID, string STID, string SLID);

        /// <summary>
        /// 得到盘点单待盘点列表
        /// </summary>
        /// <param name="IID"></param>
        /// <param name="WAREID"></param>
        /// <param name="STID"></param>
        /// <param name="SLID"></param>
        /// <returns></returns>
        DataTable GetPendingInventoryTable(string IID, string WAREID,string STID,string SLID);

        /// <summary>
        /// 得到盘点单需要盘点的列表
        /// </summary>
        /// <param name="IID">盘点单编号</param>
        /// <returns></returns>
        List<string> GetPendingInventoryList(string IID);

        /// <summary>
        /// 得到盘点单结果行项的结果字典
        /// </summary>
        /// <param name="IID">盘点单编号</param>
        /// <returns></returns>
        Dictionary<string, List<decimal>> GetResultDictionary(string IID);

        #endregion

        #region 操作
        /// <summary>
        /// 添加盘点单
        /// </summary>
        /// <param name="inputDto">盘点单信息</param>
        /// <returns></returns>
        ReturnInfo AddConInventory(ConInventoryInputDto inputDto);

        /// <summary>
        /// 更新盘点单
        /// </summary>
        /// <param name="inputDto">盘点单信息</param>
        /// <returns></returns>
        ReturnInfo UpdateInventory(ConInventoryInputDto inputDto);

        /// <summary>
        /// 只更新盘点单表头
        /// </summary>
        /// <param name="inputDto">所需数据</param>
        /// <returns></returns>
        ReturnInfo UpdateInventoryOnly(AddCIResultInputDto inputDto);

        /// <summary>
        /// 开始盘点
        /// <param name="inputDto">开始盘点时,传给后台的数据</param>
        /// <returns></returns>
        ReturnInfo AddConInventoryResult(AddCIResultInputDto inputDto);

        /// <summary>
        /// 删除盘点单
        /// </summary>
        /// <param name="IID">盘点单编号</param>
        /// <returns></returns>
        ReturnInfo DeleteInventory(string IID);

        #endregion
    }
}
