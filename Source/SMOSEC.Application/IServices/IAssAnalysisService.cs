using System.Collections.Generic;
using System.Data;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.DTOs.OutputDTO;

namespace SMOWMS.Application.IServices
{
    /// <summary>
    /// 资产分析接口
    /// </summary>
    public interface IAssAnalysisService
    {
        /// <summary>
        /// 得到资产库存
        /// </summary>
        /// <param name="inputDto">资产库存查询入参</param>
        /// <returns></returns>
        List<AssQuantDto> GetAssQuant(QueryAssQuantInputDto inputDto);

        /// <summary>
        /// 得到即将过期的资产
        /// </summary>
        /// <param name="inputDto">查询的时间区间</param>
        /// <returns></returns>
        List<AssImminentExpiryDto> GetImminentExpiryAss(QueryAssAnalysisInputDto inputDto);

        /// <summary>
        /// 得到采购单报表
        /// </summary>
        /// <param name="inputDto">查询的时间区间</param>
        /// <returns></returns>
        List<AssPurchaseAnalysisDto> GetAssPurchaseAnalysis(QueryAssAnalysisInputDto inputDto);

        /// <summary>
        /// 得到销售单报表
        /// </summary>
        /// <param name="inputDto">查询的时间区间</param>
        /// <returns></returns>
        List<AssSaleAnalysisDto> GetAssSaleAnalysis(QueryAssAnalysisInputDto inputDto);

        /// <summary>
        /// 得到客户报表
        /// </summary>
        /// <param name="inputDto">查询的条件</param>
        /// <returns></returns>
        List<AssCusAnalysisDto> GetAssCustomerAnalysis(QueryAssCusandVenAnalysisInputDto inputDto);

        /// <summary>
        /// 得到供应商报表
        /// </summary>
        /// <param name="inputDto">查询的条件</param>
        /// <returns></returns>
        List<AssVenAnalysisDto> GetAssVendorAnalysis(QueryAssCusandVenAnalysisInputDto inputDto);

        /// <summary>
        /// 得到采购单报表
        /// </summary>
        /// <param name="inputDto">查询的时间区间</param>
        /// <returns></returns>
        List<BarChartDto> GetAssPurchaseAnalysisChart(QueryAssAnalysisInputDto inputDto);

        /// <summary>
        /// 得到销售单报表
        /// </summary>
        /// <param name="inputDto">查询的时间区间</param>
        /// <returns></returns>
        List<BarChartDto> GetAssSaleAnalysisChart(QueryAssAnalysisInputDto inputDto);

        /// <summary>
        /// 得到客户报表
        /// </summary>
        /// <param name="inputDto">查询的条件</param>
        /// <returns></returns>
        List<BarChartDto> GetAssCustomerAnalysisChart(QueryAssCusandVenAnalysisInputDto inputDto);

        /// <summary>
        /// 得到供应商报表
        /// </summary>
        /// <param name="inputDto">查询的条件</param>
        /// <returns></returns>
        List<BarChartDto> GetAssVendorAnalysisChart(QueryAssCusandVenAnalysisInputDto inputDto);

        /// <summary>
        /// 得到资产库存
        /// </summary>
        /// <param name="inputDto">资产库存查询入参</param>
        /// <returns></returns>
        List<AssQuantDto> GetAssQuantChart(QueryAssQuantInputDto inputDto);
    }
}