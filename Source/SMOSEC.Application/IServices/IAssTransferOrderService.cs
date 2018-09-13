using SMOWMS.CommLib;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.Enum;
using SMOWMS.DTOs.InputDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMOWMS.Application.IServices
{
    /// <summary>
    /// 调拨单的服务接口
    /// </summary>
    public interface IAssTransferOrderService
    {
        #region 查询
        /// <summary>
        /// 根据调拨单编号返回调拨单信息
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        TOInputDto GetByID(string ID);
        ///// <summary>
        ///// 根据用户编号和调拨类型，返回调拨单
        ///// </summary>
        ///// <param name="UserID"></param>
        ///// <returns></returns>
        List<AssTransferOrder> GetByUser(String UserID,OperateType type);
        #endregion

        #region 操作
        /// <summary>
        /// 新增调拨单
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        ReturnInfo AddAssTransferOrder(TOInputDto entity,OperateType type);
        /// <summary>
        /// 更新调拨单
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        ReturnInfo UpdateAssTransferOrder(TOInputDto entity, PROCESSMODE Type,OperateType type);
        #endregion
    }
}
