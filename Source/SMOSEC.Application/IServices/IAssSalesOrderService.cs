using System.Collections.Generic;
using System.Data;
using SMOWMS.CommLib;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.DTOs.OutputDTO;

namespace SMOWMS.Application.IServices
{
    public interface IAssSalesOrderService
    {
        #region 查询
        /// <summary>
        /// 根据销售单编号得到销售单
        /// </summary>
        /// <param name="SOID">销售单编号</param>
        /// <returns></returns>
        AssSalesOrderOutputDto GetById(string SOID);

        /// <summary>
        /// 得到用户的销售单列表
        /// </summary>
        /// <param name="UserId">用户编号</param>
        /// <returns></returns>
        DataTable GetOrders(string UserId);

        /// <summary>
        /// 得到销售单行项
        /// </summary>
        /// <param name="SOID">销售单编号</param>
        /// <returns></returns>
        DataTable GetRows(string SOID);

        /// <summary>
        /// 得到销售单行项的资产模板列表
        /// </summary>
        /// <param name="SOID">销售单编号</param>
        /// <returns></returns>
        List<AssTempOutputDto> GetTemplateList(string SOID);

        /// <summary>
        /// 得到销售单行项
        /// </summary>
        /// <param name="SOID">销售单编号</param>
        /// <returns></returns>
        List<AssSORowOutputDto> GetSORows(string SOID);

        /// <summary>
        /// 得到销售单下的SN集合
        /// </summary>
        /// <param name="SOID">销售单编号</param>
        /// <returns></returns>
        List<string> GetSoSnList(string SOID);

        /// <summary>
        /// 查询该销售单下是否有该序列号
        /// </summary>
        /// <param name="SOID">销售单编号</param>
        /// <param name="SN">序列号</param>
        /// <returns></returns>
        bool SNIsOK(string SOID, string SN);

        /// <summary>
        /// 判断销售单编号是否存在
        /// </summary>
        /// <param name="SOID">销售单编号</param>
        /// <returns></returns>
        bool SOIDIsExist(string SOID);
        #endregion

        #region 操作
        /// <summary>
        /// 添加销售单
        /// </summary>
        /// <param name="inputDto">销售单信息</param>
        /// <returns></returns>
        ReturnInfo AddSalesOrder(AssSalesOrderInputDto inputDto);

        /// <summary>
        /// 修改销售单
        /// </summary>
        /// <param name="inputDto">销售单信息</param>
        /// <returns></returns>
        ReturnInfo UpdateSalesOrderOnly(AssSalesOrderInputDto inputDto);

        /// <summary>
        /// 销售资产
        /// </summary>
        /// <param name="inputDto">相关信息</param>
        /// <returns></returns>
        ReturnInfo SaleAss(AssSalesInputDto inputDto);

        /// <summary>
        /// 销售退库
        /// </summary>
        /// <param name="inputDto">销售退库相关信息</param>
        /// <returns></returns>
        ReturnInfo RetiringAss(AssRetiringInputDto inputDto);

        /// <summary>
        /// 删除销售单
        /// </summary>
        /// <param name="SOID">销售单编号</param>
        /// <returns></returns>
        ReturnInfo DeleteSalesOrder(string SOID);

        #endregion
    }
}