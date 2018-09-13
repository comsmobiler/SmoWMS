using SMOWMS.CommLib;
using SMOWMS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMOWMS.Application.IServices
{
    /// <summary>
    /// 供货商的服务接口
    /// </summary>
    public interface IVendorService
    {
        #region 查询
        /// <summary>
        /// 根据编号查询供货商信息
        /// </summary>
        /// <param name="cusId"></param>
        /// <returns></returns>
        Vendor GetById(int vId);
        /// <summary>
        /// 查询所有供货商信息
        /// </summary>
        /// <returns></returns>
        List<Vendor> GetAll();
        /// <summary>
        /// 根据关键词查询供货商信息
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns></returns>
        List<Vendor> GetByKeyword(string keyword);
        #endregion
        #region 操作
        /// <summary>
        /// 新增供货商信息
        /// </summary>
        /// <param name="vendor"></param>
        /// <returns></returns>
        ReturnInfo AddVendor(Vendor vendor);
        /// <summary>
        /// 更新供货商信息
        /// </summary>
        /// <param name="vendor"></param>
        /// <returns></returns>
        ReturnInfo UpdateVendor(Vendor vendor);
        /// <summary>
        /// 删除供货商信息
        /// </summary>
        /// <param name="vId"></param>
        /// <returns></returns>
        ReturnInfo DeleteVendor(int vId);
        #endregion
    }
}
