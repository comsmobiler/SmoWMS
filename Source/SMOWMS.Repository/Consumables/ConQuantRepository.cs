using System.Linq;
using SMOWMS.Domain.Entity;
using SMOWMS.Domain.IRepository;
using SMOWMS.Infrastructure;
using System;

namespace SMOWMS.Repository.Consumables
{
    /// <summary>
    /// 耗材库存查询实现
    /// </summary>
    public class ConQuantRepository : BaseRepository<Domain.Entity.ConQuant>, IConQuantRepository
    {
        /// <summary>
        /// 耗材库存查询类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public ConQuantRepository(IDbContext dbContext)
            : base(dbContext)
        { }

        /// <summary>
        /// 根据仓库编号和耗材编号得到库存信息
        /// </summary>
        /// <param name="SLID">库位编号</param>
        /// <param name="CID">耗材编号</param>
        /// <returns></returns>
        public IQueryable<ConQuant> GetQuants(string WAREID, string CID)
        {
            var result = _entities;
            if (!string.IsNullOrEmpty(WAREID))
            {
                result = result.Where(a => a.SLID == WAREID);
            }
            if (!string.IsNullOrEmpty(CID))
            {
                result = result.Where(a => a.CID == CID);
            }
            return result;
        }
        /// <summary>
        /// 查询某个耗材的相关库存信息
        /// </summary>
        /// <param name="CID"></param>
        /// <returns></returns>
        public IQueryable<ConQuant> GetQuantByCID(string CID)
        {
            return _entities.Where(x=>x.CID==CID);
        }
        /// <summary>
        /// 得到某个耗材的库存总数
        /// </summary>
        /// <param name="CID"></param>
        /// <returns></returns>
        public decimal GetSumByCID(string CID)
        {
            return _entities.Where(x => x.CID == CID).Sum(x => x.QUANTITY);
        }
        /// <summary>
        /// 获取除选择区域外的空闲的耗材信息
        /// </summary>
        /// <param name="WAREID"></param>
        /// <param name="STID"></param>
        /// <param name="SLID"></param>
        /// <param name="CID"></param>
        /// <returns></returns>
        public IQueryable<ConQuant> GetUnUserCon(string WAREID, string STID, string SLID, string CID)
        {
            if (String.IsNullOrEmpty(CID))
                return _entities.Where(x => x.QUANTITY > 0 && !(x.WAREID == WAREID && x.STID == STID && x.SLID == SLID));
            else
                return _entities.Where(x => x.QUANTITY > 0 && x.CID == CID && !(x.WAREID == WAREID && x.STID == STID && x.SLID == SLID));
        }

        /// <summary>
        /// 根据耗材编号和库位编号查询库存信息
        /// </summary>
        /// <param name="CID">耗材编号</param>
        /// <param name="SLID">库位编号</param>
        /// <returns></returns>
        public IQueryable<ConQuant> GetByCID(string CID, string WAREID, string STID, string SLID)
        {
            var result = _entities;
            if (!string.IsNullOrEmpty(CID))
            {
                result = result.Where(a => a.CID == CID);
            }
            if (!string.IsNullOrEmpty(WAREID))
            {
                result = result.Where(a => a.WAREID == WAREID);
            }
            if (!string.IsNullOrEmpty(STID))
            {
                result = result.Where(a => a.STID == STID);
            }
            if (!string.IsNullOrEmpty(SLID))
            {
                result = result.Where(a => a.SLID == SLID);
            }
            return result;
        }
        /// <summary>
        /// 根据仓库编号,得到盘点清单
        /// </summary>
        /// <param name="WAREID"></param>
        /// <param name="STID"></param>
        /// <param name="SLID"></param>
        /// <returns></returns>
        public IQueryable<ConQuant> GetInventoryCons(string WAREID, string STID, string SLID)
        {
            var result = _entities;
            if (!string.IsNullOrEmpty(WAREID))
            {
                result = result.Where(a => a.WAREID == WAREID);
            }
            if (!string.IsNullOrEmpty(STID))
            {
                result = result.Where(a => a.STID == STID);
            }
            if (!string.IsNullOrEmpty(SLID))
            {
                result = result.Where(a => a.SLID == SLID);
            }
            return result;
        }

    }
}