using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace SMOWMS.Infrastructure
{
    /// <summary>
    /// 数据库上下文接口
    /// </summary>
    public interface IDbContext
    {

        DbSet<TEntity> Set<TEntity>()
            where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity)
            where TEntity : class;


        /// <summary>
        /// 保存
        /// </summary>
        int SaveChanges();
    }
}
