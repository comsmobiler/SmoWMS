using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.OutputDTO;
using System;
using System.Collections.Generic;

namespace SMOWMS.Application.IServices
{
    /// <summary>
    /// 单据的服务接口
    /// 各种单据通用的查询
    /// </summary>
    public interface IOrderCommonService
    {
        #region  查询
        /// <summary>
        /// 根据资产条码查询资产对象 
        /// </summary>
        /// <param name="ASSID"></param>
        /// <returns></returns>
        Assets GetAssetsByID(String ASSID);
        /// <summary>
        /// 根据序列号查询资产对象 
        /// </summary>
        /// <param name="ASSID"></param>
        /// <returns></returns>
        Assets GetUnusedAssetsBySN(String SN);
        /// <summary>
        /// 获取资产使用数据
        /// </summary>
        /// <param name="Mode"></param>
        /// <param name="Level1"></param>
        /// <returns></returns>
        List<AssProRecordOutputDto> GetUseAnalyse(string Mode);
        /// <summary>
        /// 获取除选择库位外的空闲耗材库存信息
        /// </summary>
        /// <param name="WAREID"></param>
        /// <param name="STID"></param>
        /// <param name="SLID"></param>
        /// <param name="CID"></param>
        /// <returns></returns>
        List<ConQuantOutputDto> GetUnUseCon(string WAREID,string STID,string SLID,string CID);
        /// <summary>
        /// 根据耗材编号和区域编号获取耗材库存信息
        /// </summary>
        /// <param name="CID"></param>
        /// <param name="WAREID"></param>
        /// <param name="STID"></param>
        /// <param name="SLID"></param>
        /// <returns></returns>
        ConQuant GetUnUseConByCID(string CID, string WAREID, string STID, string SLID);
        #endregion
    }
}
