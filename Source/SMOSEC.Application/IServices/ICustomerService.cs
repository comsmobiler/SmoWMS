using SMOWMS.CommLib;
using SMOWMS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMOWMS.Application.IServices
{
    /// <summary>
    /// 客户的服务接口
    /// </summary>
    public interface ICustomerService
    {
        #region 查询
        /// <summary>
        /// 根据客户编号查询客户信息
        /// </summary>
        /// <param name="cusId"></param>
        /// <returns></returns>
        Customer GetById(int cusId);
        /// <summary>
        /// 查询所有客户信息
        /// </summary>
        /// <returns></returns>
        List<Customer> GetAll();
        /// <summary>
        /// 根据关键词查询客户信息
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns></returns>
        List<Customer> GetByKeyword(string keyword);
        #endregion
        #region 操作
        /// <summary>
        /// 新增客户信息
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        ReturnInfo AddCustomer(Customer customer);
       /// <summary>
       /// 更新客户信息
       /// </summary>
       /// <param name="customer"></param>
       /// <returns></returns>
        ReturnInfo UpdateCustomer(Customer customer);
        /// <summary>
        /// 删除客户信息
        /// </summary>
        /// <param name="cusId"></param>
        /// <returns></returns>
        ReturnInfo DeleteCustomer(int cusId);
        #endregion
    }
}
