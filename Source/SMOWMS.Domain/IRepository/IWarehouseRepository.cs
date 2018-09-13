using System.Linq;
using SMOWMS.Domain.Entity;

namespace SMOWMS.Domain.IRepository
{
    /// <summary>
    /// 仓库查询接口
    /// </summary>
    public interface IWarehouseRepository : IRepository<WareHouse>
    {
        /// <summary>
        /// 根据仓库编号获取仓库信息
        /// </summary>
        /// <param name="WAREID"></param>
        /// <returns></returns>
        IQueryable<WareHouse> GetById(string WAREID);

        /// <summary>
        /// 判断是否已经存在
        /// </summary>
        /// <param name="WAREID">仓库编号</param>
        /// <returns></returns>
        bool IsExist(string WAREID);
    }
}
