using System;
using System.Linq;
using SMOWMS.Domain.Entity;

namespace SMOWMS.Domain.IRepository
{
    /// <summary>
    /// 耗材查询接口
    /// </summary>
    public interface IConsumablesRepository : IRepository<Consumables>
    {
        /// <summary>
        /// 根据耗材条码返回耗材对象
        /// </summary>
        /// <param name="CID">耗材条码</param>
        /// <returns></returns>
        IQueryable<Consumables> GetByID(String CID);

        /// <summary>
        /// 根据耗材名称返回耗材对象
        /// </summary>
        /// <param name="Name">耗材名称</param>
        /// <returns></returns>
        IQueryable<Consumables> GetByName(String Name);

        /// <summary>
        /// 得到最大编号
        /// </summary>
        /// <returns></returns>
        string GetMaxID();
    }
}