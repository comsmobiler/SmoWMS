using System.Collections.Generic;
using System.Data;
using SMOWMS.CommLib;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.DTOs.OutputDTO;

namespace SMOWMS.Application.IServices
{
    public interface IAssPurchaseOrderService
    {
        #region 查询
        /// <summary>
        /// 根据采购单号得到采购单
        /// </summary>
        /// <param name="POID">采购单号</param>
        /// <returns></returns>
        AssPurchaseOrderOutputDto GetById(string POID);

        /// <summary>
        /// 得到用户的采购单列表
        /// </summary>
        /// <param name="UserId">用户编号</param>
        /// <returns></returns>
        DataTable GetOrders(string UserId);

        /// <summary>
        /// 根据采购单编号得到采购单行项
        /// </summary>
        /// <param name="POID">采购单编号</param>
        /// <returns></returns>
        DataTable GetRows(string POID);

        /// <summary>
        /// 得到采购单行项中的资产模板
        /// </summary>
        /// <param name="POID">采购单编号</param>
        /// <returns></returns>
        List<AssTempOutputDto> GetTemplateList(string POID);

        /// <summary>
        /// 根据采购单编号，得到采购单行项数据
        /// </summary>
        /// <param name="POID">采购单编号</param>
        /// <returns></returns>
        List<AssPORowOutputDto> GetPORows(string POID);

        /// <summary>
        /// 根据采购单编号，得到入库的序列号
        /// </summary>
        /// <param name="POID">采购单编号</param>
        /// <returns></returns>
        List<string> GetPoSnList(string POID);

        /// <summary>
        /// 查询序列号是否在采购单入库行项中
        /// </summary>
        /// <param name="POID">采购单编号</param>
        /// <param name="SN">序列号</param>
        /// <returns></returns>
        bool SNIsOK(string POID,string SN);

        /// <summary>
        /// 判断采购单编号是否存在
        /// </summary>
        /// <param name="POID">采购单编号</param>
        /// <returns></returns>
        bool POIDIsExist(string POID);
            #endregion

        #region 操作
        /// <summary>
        /// 添加采购单
        /// </summary>
        /// <param name="inputDto">采购单数据</param>
        /// <returns></returns>
        ReturnInfo AddPurchaseOrder(AssPurchaseOrderInputDto inputDto);

        /// <summary>
        /// 更新采购单信息
        /// </summary>
        /// <param name="inputDto">采购单信息</param>
        /// <returns></returns>
        ReturnInfo UpdatePurchaseOrderOnly(AssPurchaseOrderInputDto inputDto);

        /// <summary>
        /// 采购退货
        /// </summary>
        /// <param name="inputDto">采购退货相关信息</param>
        /// <returns></returns>
        ReturnInfo ReturnAss(AssReturnInputDto inputDto);

        /// <summary>
        /// 采购入库
        /// </summary>
        /// <param name="inputDto">采购入库相关信息</param>
        /// <returns></returns>
        ReturnInfo InstorageAss(AssInStorageInputDto inputDto);

        /// <summary>
        /// 删除采购单
        /// </summary>
        /// <param name="POID">采购单编号</param>
        /// <returns></returns>
        ReturnInfo DeletePurchaseOrder(string POID);
        #endregion
    }
}