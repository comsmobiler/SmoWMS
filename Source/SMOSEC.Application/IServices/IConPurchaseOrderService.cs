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
    /// 耗材采购单的服务接口
    /// </summary>
    public interface IConPurchaseOrderService
    {
        #region 查询
        /// <summary>
        /// 得到所有耗材采购单
        /// </summary>
        /// <returns></returns>
        DataTable GetOrders();
        /// <summary>
        /// 根据采购单号获取采购单对象
        /// </summary>
        /// <param name="POID"></param>
        /// <returns></returns>
        ConPurchaseOrderOutputDto GetByPOID(string POID);
        /// <summary>
        /// 采购分析
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        Dictionary<string, decimal> GetPurchaseAnalyze(DateTime startDate,DateTime endDate);
        /// <summary>
        /// 供应商采购量分析
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        Dictionary<string, Dictionary<string, decimal>> GetVendorAnalyze(DateTime startDate, DateTime endDate);
        /// <summary>
        /// 获取对应采购单号下所有行项信息
        /// </summary>
        /// <param name="POID"></param>
        /// <returns></returns>
        List<ConPurAndSaleCreateInputDto> GetOrderRows(string POID);
        /// <summary>
        /// 得到对应采购单下可入库行项
        /// </summary>
        /// <param name="POID"></param>
        /// <returns></returns>
        List<ConPORInstorageOutputDto> GetInStoRowsByPOID(string POID);
        /// <summary>
        /// 得到对应采购单下可退库选项
        /// </summary>
        /// <param name="POID"></param>
        /// <returns></returns>
        List<ConPurchaseOrderReturnOutputDto> GetReturnRowsByPOID(string POID);
        #endregion
        #region 操作
        /// <summary>
        /// 创建采购单
        /// </summary>
        /// <param name="inputDto"></param>
        /// <returns></returns>
        ReturnInfo AddPurchaseOrder(ConPurchaseOrderInputDto inputDto);
        /// <summary>
        /// 更新采购单
        /// </summary>
        /// <param name="inputDto"></param>
        /// <returns></returns>
        ReturnInfo UpdatePruchaseOrder(ConPurchaseOrderInputDto inputDto);
        /// <summary>
        /// 删除采购单
        /// </summary>
        /// <param name="POID"></param>
        /// <returns></returns>
        ReturnInfo DeletePurchaseOrder(string POID);
        /// <summary>
        /// 耗材采购单入库
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        ReturnInfo InStoConPurhcaseOrder(ConPOInStoInputDto entity);
        /// <summary>
        /// 耗材采购单退库
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        ReturnInfo ReturnConPurchaseOrder(ConPOInStoInputDto entity);
        #endregion
    }
}
