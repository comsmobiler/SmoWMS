using System.Linq;
using SMOWMS.Domain.Entity;

namespace SMOWMS.Domain.IRepository
{
    /// <summary>
    /// 库位查询接口
    /// </summary>
    public interface IWHStorageLocationRepository : IRepository<WHStorageLocation>
    {
        /// <summary>
        /// 根据主键查询库位信息
        /// </summary>
        /// <param name="WAREID">仓库编号</param>
        /// <param name="STID">存储类型编号</param>
        /// <param name="SLID">库位编号</param>
        /// <returns></returns>
        IQueryable<WHStorageLocation> GetById(string WAREID,string STID,string SLID);

        /// <summary>
        /// 获取某个仓库和存储类型下的所有库位
        /// </summary>
        /// <param name="WAREID">仓库编号</param>
        /// <param name="STID">存储类型编号</param>
        /// <returns></returns>
        IQueryable<WHStorageLocation> GetByWareIdAndSTID(string WAREID, string STID);

        /// <summary>
        /// 判断是否已经存在
        /// </summary>
        /// <param name="WAREID">仓库编号</param>
        /// <param name="STID">存储类型编号</param>
        /// <param name="SLID">库位编号</param>
        /// <returns></returns>
        bool IsExist(string WAREID, string STID,string SLID);
    }
}
