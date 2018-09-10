using SMOWMS.Domain.Entity;
using SMOWMS.Domain.IRepository;
using SMOWMS.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMOWMS.Repository.Setting
{
    /// <summary>
    /// 客户的仓储实现，仅用于查询
    /// </summary>
    public class CustomerReposity : BaseRepository<Customer>, ICustomerReposity
    {
        /// <summary>
        /// 仓储类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public CustomerReposity(IDbContext dbContext)
                : base(dbContext)
        { }

        public IQueryable<Customer> GetById(int cusId)
        {
            return _entities.Where(x=>x.CUSID==cusId).OrderByDescending(x=>x.CREATEDATE);
        }
        public IQueryable<Customer> GetByKeyword(string keyword)
        {
            return _entities.Where(x=>x.NAME.Contains(keyword) || x.CONTACTS.Contains(keyword) || x.PHONE.Contains(keyword) || x.ADDRESS.Contains(keyword));
        }
    }
}
