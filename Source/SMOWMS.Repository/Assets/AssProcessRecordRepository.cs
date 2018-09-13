using System;
using System.Data.Entity;
using System.Linq;
using SMOWMS.Domain.Entity;
using SMOWMS.Domain.IRepository;
using SMOWMS.Infrastructure;

namespace SMOWMS.Repository.Assets
{
    /// <summary>
    /// 处理记录的仓储实现，仅用于查询
    /// </summary>
    public class AssProcessRecordRepository : BaseRepository<AssProcessRecord>, IAssProcessRecordRepository
    {
        /// <summary>
        /// 仓储类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public AssProcessRecordRepository(IDbContext dbContext)
            : base(dbContext)
        { }

        /// <summary>
        /// 得到最大的处理记录ID
        /// </summary>
        /// <returns></returns>
        public int  GetMaxID()
        {
            return _entities.Select(e => e.PRID).Max();
        }
        /// <summary>
        /// 查询处理记录
        /// </summary>
        /// <param name="ASSID"></param>
        /// <param name="SN"></param>
        /// <returns></returns>
        public IQueryable<AssProcessRecord> GetRecords(string ASSID)
        {
            return _entities.Where(a => a.ASSID == ASSID).AsNoTracking();
        }
        /// <summary>
        /// 根据需要类型(时间段)获取使用数据
        /// </summary>
        /// <param name="Mode"></param>
        /// <returns></returns>
        public IQueryable<AssProcessRecord> GetUserData(string Mode)
        {
            var q = _entities.Where(x => x.PROCESSMODE == 1 || x.PROCESSMODE == 3);
            DateTime StartDate = new DateTime();
            DateTime FinishDate = new DateTime();
            switch (Mode)
            {
                case "OM":
                    StartDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-01")).AddMonths(-1);
                    FinishDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-01")).AddDays(-1);
                    break;
                case "TM":
                    StartDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-01")).AddMonths(-3);
                    FinishDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-01")).AddDays(-1);
                    break;
                case "OY":
                    StartDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-01")).AddYears(-1);
                    FinishDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-01")).AddDays(-1);
                    break;
            }
            q = q.Where(x => x.CREATEDATE > StartDate && x.CREATEDATE < FinishDate);
            return q;
        }
    }
}
