using SMOWMS.CommLib;
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
    /// 耗材销售单的接口
    /// </summary>
    public interface IConSalesOrderService
    {
        #region 查询
        /// <summary>
        /// 得到所有耗材销售单
        /// </summary>
        /// <returns></returns>
        DataTable GetOrders();
        /// <summary>
        /// 获取对应耗材单号下所有行项信息
        /// </summary>
        /// <param name="SOID"></param>
        /// <returns></returns>
        List<ConPurAndSaleCreateInputDto> GetOrderRows(string SOID);
        /// <summary>
        /// 销售分析
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        Dictionary<string, decimal> GetSaleAnalyze(DateTime startDate,DateTime endDate);
        /// <summary>
        /// 客户销售量分析
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        Dictionary<string, Dictionary<string, decimal>> GetCustomerAnalyze(DateTime startDate, DateTime endDate);
        /// <summary>
        /// 根据销售单号和耗材编号获取采购行项信息
        /// </summary>
        /// <param name="SOID"></param>
        /// <param name="CID"></param>
        /// <returns></returns>
        ConSalesOrderRowInputDto GetOrderRowByCID(string SOID, string CID);
        /// <summary>
        /// 得到对应销售单下可出库行项
        /// </summary>
        /// <param name="SOID"></param>
        /// <returns></returns>
        List<ConSalesOrderOutboundOutputDto> GetOutRowsBySOID(string SOID);
        /// <summary>
        /// 得到对应销售单下可退货行项
        /// </summary>
        /// <param name="SOID"></param>
        /// <returns></returns>
        List<ConSalesOrderRowInputDto> GetRetRowsBySOID(string SOID);
        /// <summary>
        /// 根据耗材单号获取耗材单对象
        /// </summary>
        /// <param name="SOID"></param>
        /// <returns></returns>
        ConSalesOrderOutputDto GetBySOID(string SOID);
        /// <summary>
        /// 获取对应销售单下相应状态的行项信息
        /// </summary>
        /// <param name="SOID"></param>
        /// <param name="Status"></param>
        /// <returns></returns>
        List<ConSalesOrderRowInputDto> GetOrderRowsByStatus(string SOID, SalesOrderStatus Status);
        #endregion
        #region 操作
        /// <summary>
        /// 创建销售单
        /// </summary>
        /// <param name="inputDto"></param>
        /// <returns></returns>
        ReturnInfo AddSalesOrder(ConSalesOrderInputDto inputDto);
        /// <summary>
        /// 删除销售单
        /// </summary>
        /// <param name="SOID"></param>
        /// <returns></returns>
        ReturnInfo DeleteSalesOrder(string SOID);
        /// <summary>
        /// 更新销售单
        /// </summary>
        /// <param name="inputDto"></param>
        /// <returns></returns>
        ReturnInfo UpdateSalesOrder(ConSalesOrderInputDto inputDto);
        /// <summary>
        /// 耗材销售单出库
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        ReturnInfo OutboundConSalesOrder(ConSOOutboundInputDto entity);
        /// <summary>
        /// 耗材销售单退货
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        ReturnInfo RetConSalesOrder(ConSOOutboundInputDto entity);
        #endregion
    }
}
