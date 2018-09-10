using System.Collections.Generic;
using System.Data;
using SMOWMS.CommLib;
using SMOWMS.DTOs.Enum;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.DTOs.OutputDTO;

namespace SMOWMS.Application.IServices
{
    /// <summary>
    /// 资产盘点的服务接口
    /// </summary>
    public interface IAssInventoryService
    {
        #region 查询

        /// <summary>
        /// 得到盘点单列表
        /// </summary>
        /// <param name="UserId">处理人编号</param>
        /// <returns></returns>
        DataTable GetAssInventoryList(string UserId);

        /// <summary>
        /// 根据盘点单编号得到盘点单详情
        /// </summary>
        /// <param name="IID">盘点单编号</param>
        /// <returns></returns>
        AssInventoryOutputDto GetAssInventoryById(string IID);

        /// <summary>
        /// 根据盘点单编号和状态得到结果行项信息
        /// </summary>
        /// <param name="IID">盘点单编号</param>
        /// <param name="Status">状态</param>
        /// <returns></returns>
        DataTable GetAssInventoryResultsByIID(string IID, ResultStatus Status);

        /// <summary>
        /// 查询是否已经有盘点单结果记录
        /// </summary>
        /// <param name="IID">盘点单编号</param>
        /// <returns></returns>
        bool IsExist(string IID);

        /// <summary>
        /// 根据区域编号,类型和部门编号,得到盘点清单
        /// </summary>
        /// <param name="SLID"></param>
        /// <param name="typeId">类型编号</param>
        /// <param name="WAREID"></param>
        /// <param name="STID"></param>
        /// <returns></returns>
        DataTable GetInventoryAssList(string WAREID,string STID,string SLID, string typeId);

        /// <summary>
        /// 得到盘点单待盘点列表
        /// </summary>
        /// <param name="IID">盘点单编号</param>
        /// <param name="typeId">类型编号</param>
        /// <returns></returns>
        DataTable GetPendingInventoryTable(string IID, string WAREID, string STID, string SLID, string typeId);

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
        Dictionary<string, int> GetResultDictionary(string IID);

        #endregion

        #region 操作
        /// <summary>
        /// 添加盘点单
        /// </summary>
        /// <param name="inputDto">盘点单信息</param>
        /// <returns></returns>
        ReturnInfo AddAssInventory(AssInventoryInputDto inputDto);

        /// <summary>
        /// 更新盘点单
        /// </summary>
        /// <param name="inputDto">盘点单信息</param>
        /// <returns></returns>
        ReturnInfo UpdateInventory(AssInventoryInputDto inputDto);

        /// <summary>
        /// 只更新盘点单表头
        /// </summary>
        /// <param name="inputDto">所需数据</param>
        /// <returns></returns>
        ReturnInfo UpdateInventoryOnly(AddAIResultInputDto inputDto);

        /// <summary>
        /// 开始盘点
        /// <param name="inputDto">开始盘点时,传给后台的数据</param>
        /// <returns></returns>
        ReturnInfo AddAssInventoryResult(AddAIResultInputDto inputDto);

        /// <summary>
        /// 删除盘点单
        /// </summary>
        /// <param name="IID">盘点单编号</param>
        /// <returns></returns>
        ReturnInfo DeleteInventory(string IID);

        #endregion
    }
}
