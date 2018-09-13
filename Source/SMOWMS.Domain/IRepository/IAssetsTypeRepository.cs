using System;
using System.Linq;
using SMOWMS.Domain.Entity;

namespace SMOWMS.Domain.IRepository
{
    /// <summary>
    /// 资产类别的仓储接口，仅用于查询
    /// </summary>
    public interface IAssetsTypeRepository:IRepository<AssetsType>
    {
        /// <summary>
        /// 根据资产类别编号返回资产类别对象
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        IQueryable<AssetsType> GetByID(String ID);
        /// <summary>
        /// 获取所有大类
        /// </summary>
        /// <returns></returns>
        IQueryable<AssetsType> GetAllFirstLevel();
        /// <summary>
        /// 根据资产级别和父类编号获取资产类别信息
        /// </summary>
        /// <param name="Level"></param>
        /// <param name="parentId"></param>
        /// <returns></returns>
        IQueryable<AssetsType> GetByLevelAndParentId(int Level,String parentId);
        /// <summary>
        /// 根据父类型编号，获取子类型数据
        /// </summary>
        /// <param name="TypeID"></param>
        /// <returns></returns>
        IQueryable<AssetsType> GetByParentTypeID(string TypeID);
        /// <summary>
        /// 判断是否为父分类
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        IQueryable<AssetsType> IsParent(String ID);
    }
}
