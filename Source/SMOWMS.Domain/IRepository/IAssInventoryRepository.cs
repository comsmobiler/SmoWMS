using System.Linq;
using SMOWMS.Domain.Entity;

namespace SMOWMS.Domain.IRepository
{
    /// <summary>
    /// 盘点单的查询接口
    /// </summary>
    public interface IAssInventoryRepository:IRepository<AssInventory>
    {
        /// <summary>
        /// 根据盘点单编号得到盘点单信息
        /// </summary>
        /// <param name="IID">盘点单编号</param>
        /// <returns></returns>
        IQueryable<AssInventory> GetAssInventoryByID(string IID);

        /// <summary>
        /// 得到最大编号
        /// </summary>
        /// <returns></returns>
        string GetMaxId();
    }
}