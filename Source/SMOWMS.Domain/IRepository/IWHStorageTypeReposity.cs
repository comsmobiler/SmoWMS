using SMOWMS.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMOWMS.Domain.IRepository
{
    /// <summary>
    /// 存储类型表的查询接口
    /// </summary>
    public interface IWHStorageTypeReposity:IRepository<WHStorageType>
    {
        /// <summary>
        /// 根据主键获取类型信息
        /// </summary>
        /// <param name="WAREID">仓库编号</param>
        /// <param name="STID">存储类型编号</param>
        /// <returns></returns>
        IQueryable<WHStorageType> GetById(string WAREID,string STID);

        /// <summary>
        /// 获取某个仓库下的所有存储类型
        /// </summary>
        /// <param name="WAREID">仓库编号</param>
        /// <returns></returns>
        IQueryable<WHStorageType> GetByWAREID(string WAREID);

        /// <summary>
        /// 判断是否已经存在
        /// </summary>
        /// <param name="WAREID">仓库编号</param>
        /// <param name="STID">存储类型编号</param>
        /// <returns></returns>
        bool IsExist(string WAREID,string STID);
    }
}
