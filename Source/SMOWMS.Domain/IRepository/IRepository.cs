using System.Linq;

namespace SMOWMS.Domain.IRepository
{
    /// <summary>
    /// 基础接口，仅用于查询
    /// </summary>
    public interface IRepository<TAggregateRoot>
        where TAggregateRoot:class,IAggregateRoot
    {
        /// <summary>
        /// 得到所有信息
        /// </summary>
        /// <returns></returns>
        IQueryable<TAggregateRoot> GetAll();
    }
}
