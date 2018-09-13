using System;
using System.Data.Entity;
using System.Linq;
using SMOWMS.Domain.Entity;
using SMOWMS.Domain.IRepository;
using SMOWMS.DTOs.Enum;
using SMOWMS.Infrastructure;

namespace SMOWMS.Repository.Assets
{
    /// <summary>
    /// 调拨单的仓储实现，仅用于查询
    /// </summary>
    public class AssTransferOrderRepository : BaseRepository<AssTransferOrder>, IAssTransferOrderRepository
    {
        /// <summary>
        /// 仓储类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public AssTransferOrderRepository(IDbContext dbContext)
            : base(dbContext)
        { }
        /// <summary>
        /// 根据调拨单编号返回调拨单信息
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public IQueryable<AssTransferOrder> GetByID(string ID)
        {
            return _entities.Where(x => x.TOID == ID);
        }
        /// <summary>
        /// 根据用户编号查询调拨单信息
        /// </summary>
        /// <param name="UserID"></param>
        /// <returns></returns>
        public IQueryable<AssTransferOrder> GetByUser(string UserID, int type)
        {
            var result = _entities;
            if (type == (int)OperateType.资产)
            {
                result = result.Where(x => x.TYPE == 0);
            }
            else if (type == (int)OperateType.耗材)
            {
                result = result.Where(x => x.TYPE == 1);
            }
            if (String.IsNullOrEmpty(UserID) == false)
            {
                result = result.Where(x => x.CREATEUSER == UserID);
            }
            return result.AsNoTracking().OrderByDescending(a => a.CREATEDATE);
        }
        /// <summary>
        /// 得到最大的调拨单编号
        /// </summary>
        /// <returns></returns>
        public string GetMaxID()
        {
            return _entities.Select(e => e.TOID).Max();
        }
    }
}
