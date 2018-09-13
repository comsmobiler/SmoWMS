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
    /// 供货商的查询接口实现
    /// </summary>
    public class VendorReposity:BaseRepository<Vendor>, IVendorReposity
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="dbContext"></param>
        public VendorReposity(IDbContext dbContext)
            :base(dbContext)
        {}

        public IQueryable<Vendor> GetById(int vId)
        {
            return _entities.Where(x=>x.VID==vId);
        }

        public IQueryable<Vendor> GetByKeyword(string keyword)
        {
            return _entities.Where(x => x.NAME.Contains(keyword) || x.CONTACTS.Contains(keyword) || x.PHONE.Contains(keyword) || x.ADDRESS.Contains(keyword));
        }
    }
}
