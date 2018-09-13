using SMOWMS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMOWMS.Domain.IRepository
{
    /// <summary>
    /// 供货商查询接口
    /// </summary>
    public interface IVendorReposity:IRepository<Vendor>
    {
        /// <summary>
        /// 根据编号查询供货商信息
        /// </summary>
        /// <param name="cusId"></param>
        /// <returns></returns>
        IQueryable<Vendor> GetById(int vId);
        /// <summary>
        /// 根据关键词查询供货商信息
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns></returns>
        IQueryable<Vendor> GetByKeyword(string keyword);
    }
}
