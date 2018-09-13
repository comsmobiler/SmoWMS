using System.Collections.Generic;
using System.Linq;
using SMOWMS.Domain.Entity;
using SMOWMS.Domain.IRepository;
using SMOWMS.DTOs.Enum;
using SMOWMS.Infrastructure;

namespace SMOWMS.Repository.Assets
{
    /// <summary>
    /// 盘点单结果行项查询实现
    /// </summary>
    public class AssInventoryResultRepository : BaseRepository<AssInventoryResult>, IAssInventoryResultRepository
    {
        /// <summary>
        /// 盘点单结果行项查询类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public AssInventoryResultRepository(IDbContext dbContext)
            : base(dbContext)
        { }

        /// <summary>
        /// 根据盘点单编号得到结果行项信息
        /// </summary>
        /// <param name="IID">盘点单编号</param>
        /// <returns></returns>
        public IQueryable<AssInventoryResult> GetResultsByStatus(string IID,int? Status)
        {
            var result = _entities.Where(a => a.IID == IID);
            if (Status != null)
            {
                result = Status == (int)ResultStatus.待盘点 ? result.Where(a => a.RESULT == Status) : result.Where(a => a.RESULT == 2 || a.RESULT == 3 || a.RESULT == 1);
            }
            return result;
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
        /// <param name="Assid">资产编号</param>
        /// <returns></returns>
        public IQueryable<AssInventoryResult> GetResultsByAssId(string IID, string Assid)
        {
            var result = _entities.Where(a => a.IID == IID);
            if (!string.IsNullOrEmpty(Assid))
            {
                result = result.Where(a => a.ASSID == Assid);
            }
            return result;
        }

        /// <summary>
        /// 根据盘点单编号得到需要盘点的资产列表
        /// </summary>
        /// <param name="IID"></param>
        /// <returns></returns>
        public List<string> GetOrdinaryList(string IID)
        {
            int no = (int) ResultStatus.盘盈;
            var result = _entities.Where(a => a.IID == IID&&a.RESULT!=no).Select(a=>a.ASSID);
            return result.ToList();
        }
    }
}