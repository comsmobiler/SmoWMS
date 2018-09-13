using SMOWMS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMOWMS.Domain.IRepository
{
    /// <summary>
    /// 客户的查询接口
    /// </summary>
    public interface ICustomerReposity:IRepository<Customer>
    {
        /// <summary>
        /// 根据客户编号查询客户信息
        /// </summary>
        /// <param name="cusId"></param>
        /// <returns></returns>
        IQueryable<Customer> GetById(int cusId);
        /// <summary>
        /// 根据关键词查询客户信息
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns></returns>
        IQueryable<Customer> GetByKeyword(string keyword);
    }
}
