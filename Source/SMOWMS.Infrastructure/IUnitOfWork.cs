namespace SMOWMS.Infrastructure
{
    /// <summary>
    /// 工作单元的接口，用于处理增删改操作
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// 新增
        /// </summary>
        void RegisterNew<TEntity>(TEntity entity)
            where TEntity : class;

        /// <summary>
        /// 更新
        /// </summary>
        void RegisterDirty<TEntity>(TEntity entity)
            where TEntity : class;

        /// <summary>
        /// 不更新
        /// </summary>
        void RegisterClean<TEntity>(TEntity entity)
            where TEntity : class;

        /// <summary>
        /// 删除
        /// </summary>
        void RegisterDeleted<TEntity>(TEntity entity)
            where TEntity : class;


        /// <summary>
        /// 直接提交
        /// </summary>
        bool Commit();

        /// <summary>
        /// 事务回滚
        /// </summary>
        void Rollback();
    }
}

