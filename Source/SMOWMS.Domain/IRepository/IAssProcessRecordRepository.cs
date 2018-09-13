using System.Linq;
using SMOWMS.Domain.Entity;

namespace SMOWMS.Domain.IRepository
{
    /// <summary>
    /// 处理记录的仓储接口，仅用于查询
    /// </summary>
    public interface IAssProcessRecordRepository : IRepository<AssProcessRecord>
    {
        // <summary>
        /// 得到最大的报修单ID
        /// </summary>
        /// <returns></returns>
        int  GetMaxID();
        /// <summary>
        /// 查询处理记录
        /// </summary>
        /// <param name="ASSID"></param>
        /// <param name="SN"></param>
        /// <returns></returns>
        IQueryable<AssProcessRecord> GetRecords(string ASSID);
        /// <summary>
        /// 根据需要类型(时间段)获取使用数据
        /// </summary>
        /// <param name="Mode"></param>
        /// <returns></returns>
        IQueryable<AssProcessRecord> GetUserData(string Mode);
    }
}
