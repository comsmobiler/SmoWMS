using System.Linq;
using SMOWMS.Domain.Entity;

namespace SMOWMS.Domain.IRepository
{
    /// <summary>
    /// 耗材盘点单的查询接口
    /// </summary>
    public interface IConInventoryRepository : IRepository<ConInventory>
    {
        /// <summary>
        /// 根据盘点单编号得到盘点单信息
        /// </summary>
        /// <param name="IID"></param>
        /// <returns></returns>
        IQueryable<ConInventory> GetConInventoryByID(string IID);

        /// <summary>
        /// 得到最大编号
        /// </summary>
        /// <returns></returns>
        string GetMaxId();
    }
}
