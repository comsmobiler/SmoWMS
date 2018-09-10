using System;
using System.Data.Entity;

namespace SMOWMS.Infrastructure
{
    /// <summary>
    /// 工作单元的实现，用于处理增删改操作
    /// </summary>
    public class UnitOfWork:IUnitOfWork
    {
        /// <summary>
        /// 数据库上下文
        /// </summary>
        private IDbContext _dbContext;

        /// <summary>
        /// 工作单元的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public UnitOfWork(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// 新增
        /// </summary>
        public void RegisterNew<TEntity>(TEntity entity)
            where TEntity : class
        {
            _dbContext.Set<TEntity>().Add(entity);
        }

        /// <summary>
        /// 更新
        /// </summary>
        public void RegisterDirty<TEntity>(TEntity entity)
            where TEntity : class
        {
            _dbContext.Entry<TEntity>(entity).State = EntityState.Modified;
        }

        /// <summary>
        /// 不更新
        /// </summary>
        public void RegisterClean<TEntity>(TEntity entity)
            where TEntity : class
        {
            _dbContext.Entry<TEntity>(entity).State = EntityState.Unchanged;
        }

        /// <summary>
        /// 删除
        /// </summary>
        public void RegisterDeleted<TEntity>(TEntity entity)
            where TEntity : class
        {
            _dbContext.Set<TEntity>().Remove(entity);
        }


        /// <summary>
        /// 提交
        /// </summary>
        public bool Commit()
        {
            return _dbContext.SaveChanges() > 0;
        }

        /// <summary>
        /// 事务回滚
        /// </summary>
        public void Rollback()
        {
            throw new NotImplementedException();
        }
    }
}
