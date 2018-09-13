using System.Collections.Generic;
using System.Data;
using System.Linq;
using SMOWMS.CommLib;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.DTOs.OutputDTO;

namespace SMOWMS.Application.IServices
{
    /// <summary>
    /// 主数据的服务接口
    /// </summary>
    public interface ISettingService
    {
        #region 查询
        /// <summary>
        /// 根据资产编号返回资产信息
        /// </summary>
        /// <param name="ID">资产编号</param>
        /// <returns></returns>
        AssetsOutputDto  GetAssetsByID(string ID);

        /// <summary>
        /// 得到所有的固定资产
        /// </summary>
        /// <returns></returns>
        DataTable GetAllAss(string wareId);


        /// <summary>
        /// 查询即将失效的资产
        /// </summary>
        /// <param name="days">距离现在的天数</param>
        /// <returns></returns>
        DataTable GetImminentAssets(int days);

        /// <summary>
        /// 查询低于安全库存的资产
        /// </summary>
        /// <returns></returns>
        DataTable GetLackOfStockAss();

        /// <summary>
        /// 查询处理记录
        /// </summary>
        /// <param name="ASSID">资产编号</param>
        /// <param name="CID">耗材编号</param>
        /// <returns></returns>
        DataTable GetRecords(string ASSID,string CID);

        /// <summary>
        /// 根据SN或者名称查询资产
        /// </summary>
        /// <param name="SNOrName">SN或者名称</param>
        /// <param name="Type">一级资产编号</param>
        /// <returns></returns>
        DataTable QueryAssets(string SNOrName,string Type);

        /// <summary>
        /// 根据SN得到资产信息
        /// </summary>
        /// <param name="SN">SN编号</param>
        /// <returns></returns>
        DataTable GetAssetsBySN(string SN);

        /// <summary>
        /// 得到所有的SN
        /// </summary>
        /// <returns></returns>
        List<string> GetAllSns();
        
        /// <summary>
        /// 根据SN列表得到相关的资产数据
        /// </summary>
        /// <param name="Sns">SN列表</param>
        /// <returns></returns>
        DataTable GetBySnList(List<string> Sns);

        /// <summary>
        /// 得到所有资产模板
        /// </summary>
        /// <returns></returns>
        DataTable GetAllTemplate();

        /// <summary>
        /// 根据模板编号得到信息
        /// </summary>
        /// <param name="templateId">模板编号</param>
        /// <returns></returns>
        AssTemplate GetAtbyId(string templateId);

        /// <summary>
        /// 得到所有资产模板(资产模板选择时用到)
        /// </summary>
        /// <returns></returns>
        DataTable GetAllAssTemps();

        /// <summary>
        /// 根据资产模板编号或者名称查询模板
        /// </summary>
        /// <param name="TIdorName">资产模板编号或者名称</param>
        /// <returns></returns>
        DataTable QueryAssTemplate(string TIdorName);

        /// <summary>
        /// 查询SN是否已存在
        /// </summary>
        /// <param name="SN">序列号</param>
        /// <returns></returns>
        bool SNIsExists(string SN);

        /// <summary>
        /// 查询SN是否已存在
        /// </summary>
        /// <param name="SN">序列号</param>
        /// <param name="TemplateIds">模板编号列表</param>
        /// <returns></returns>
        bool SOSNIsExists(string SN,List<string> TemplateIds);

        /// <summary>
        /// 根据序列号得到资产
        /// </summary>
        /// <param name="SN">序列号</param>
        /// <returns></returns>
        Assets GetBySN(string SN);

        /// <summary>
        /// 根据模板编号或者名称查询资产模板
        /// </summary>
        /// <param name="TemplateIdOrName">模板编号或者名称</param>
        /// <param name="Type">一级资产编号</param>
        /// <returns></returns>
        DataTable QueryAssTemplates(string TemplateIdOrName, string Type);
        #endregion

        #region 操作
        /// <summary>
        /// 新增资产
        /// </summary>
        /// <param name="entity">资产信息</param>
        /// <returns></returns>
        ReturnInfo AddAssets(AssetsInputDto entity);

        /// <summary>
        /// 更新资产信息
        /// </summary>
        /// <param name="entity">资产信息</param>
        /// <returns></returns>
        ReturnInfo UpdateAssets(AssetsInputDto entity);

        /// <summary>
        /// 添加资产模板
        /// </summary>
        /// <param name="inputDto">资产模板信息</param>
        /// <returns></returns>
        ReturnInfo AddAssTemplate(AssTemplateInputDto inputDto);

        /// <summary>
        /// 修改资产模板
        /// </summary>
        /// <param name="inputDto">资产模板信息</param>
        /// <returns></returns>
        ReturnInfo UpdateAssTemplate(AssTemplateInputDto inputDto);

        /// <summary>
        /// 删除资产模板
        /// </summary>
        /// <param name="templateId">模板编号</param>
        /// <returns></returns>
        ReturnInfo DeleteAssTemplate(string templateId);


        /// <summary>
        /// 资产移库
        /// </summary>
        /// <param name="inputDto">移库相关信息</param>
        /// <returns></returns>
        ReturnInfo TransferAss(AssTransferInputDto inputDto);

        #endregion

    }
}