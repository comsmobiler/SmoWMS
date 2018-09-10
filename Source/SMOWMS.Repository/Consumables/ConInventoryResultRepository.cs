using System.Collections.Generic;
using System.Linq;
using SMOWMS.Domain.Entity;
using SMOWMS.Domain.IRepository;
using SMOWMS.DTOs.Enum;
using SMOWMS.Infrastructure;

namespace SMOWMS.Repository.Consumables
{
    /// <summary>
    /// 耗材盘点单结果行项查询实现
    /// </summary>
    public class ConInventoryResultRepository : BaseRepository<ConInventoryResult>, IConInventoryResultRepository
    {
        /// <summary>
        /// 盘点单结果行项查询类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public ConInventoryResultRepository(IDbContext dbContext)
            : base(dbContext)
        { }

        /// <summary>
        /// 根据耗材盘点单编号得到结果行项信息
        /// </summary>
        /// <param name="IID">盘点单编号</param>
        /// <returns></returns>
        public IQueryable<ConInventoryResult> GetResultsByStatus(string IID, int? Status)
        {
            var result = _entities.Where(a => a.IID == IID);
            if (Status != null)
            {
                if (Status == (int)ResultStatus.待盘点)
                {
                    result = result.Where(a => a.RESULT == Status);
                }
                else
                {
                    result = result.Where(a => a.RESULT == 1 || a.RESULT == 2 || a.RESULT == 3);
                }

            }
            return result;
        }
        /// <summary>
        /// 根据库位和物料编号，查找盘点单行项
        /// </summary>
        /// <param name="IID"></param>
        /// <param name="CID"></param>
        /// <param name="WAREID"></param>
        /// <param name="STID"></param>
        /// <param name="SLID"></param>
        /// <returns></returns>
        public IQueryable<ConInventoryResult> GetResultBySL(string IID, string CID, string WAREID, string STID, string SLID)
        {
            return _entities.Where(x => x.IID == IID && x.CID == CID
            && x.WAREID == WAREID && x.STID == STID && x.SLID == SLID);
        }
        /// <summary>
        /// 根据库位，查找盘点单下待盘点行项
        /// </summary>
        /// <param name="IID"></param>
        /// <param name="WAREID"></param>
        /// <param name="STID"></param>
        /// <param name="SLID"></param>
        /// <returns></returns>
        public IQueryable<ConInventoryResult> GetResultListBySL(string IID, string WAREID, string STID, string SLID)
        {
            return _entities.Where(x => x.IID == IID && x.RESULT == 0
            && x.WAREID == WAREID && x.STID == STID && x.SLID == SLID);
        }
        /// <summary>
        /// 查询是否已经有盘点单结果记录
        /// </summary>
        /// <param name="IID">盘点单编号</param>
        /// <returns></returns>
        public bool IsExist(string IID)
        {
            return _entities.Any(a => a.IID == IID);
        }
        /// <summary>
        /// 根据盘点单编号得到结果行项信息
        /// </summary>
        /// <param name="IID">盘点单编号</param>
        /// <param name="CID">耗材编号</param>
        /// <returns></returns>
        public IQueryable<ConInventoryResult> GetResultsByCID(string IID, string CID)
        {
            var result = _entities.Where(a => a.IID == IID);
            if (!string.IsNullOrEmpty(CID))
            {
                result = result.Where(a => a.CID == CID);
            }
            return result;
        }

        /// <summary>
        /// 根据盘点单编号得到需要盘点的资产列表
        /// </summary>
        /// <param name="IID"></param>
        /// <returns></returns>
        public IQueryable<ConInventoryResult> GetOrdinaryList(string IID)
        {
            int no = (int)ResultStatus.盘盈;
            return _entities.Where(a => a.IID == IID && a.RESULT != no);
        }
    }
}
