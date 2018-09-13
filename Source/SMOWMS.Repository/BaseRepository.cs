using System.Linq;
using SMOWMS.Domain;
using SMOWMS.Domain.IRepository;
using SMOWMS.Infrastructure;

namespace SMOWMS.Repository
{
    public abstract class BaseRepository<TAggregateRoot> : IRepository<TAggregateRoot>
        where TAggregateRoot : class, IAggregateRoot
    {
        /// <summary>
        /// 只读的基于继承IAggregateRoot的类的可查询的类对象集合
        /// </summary>
        public readonly IQueryable<TAggregateRoot> _entities;

        /// <summary>
        /// 仓储类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public BaseRepository(IDbContext dbContext)
        {
            _entities = dbContext.Set<TAggregateRoot>();
        }

        //public IQueryable<TAggregateRoot> Get(int id)
        //{
        //    return _entities.Where(t => t.Id == id);
        //}

        /// <summary>
        /// 得到该表的所有的对象
        /// </summary>
        public IQueryable<TAggregateRoot> GetAll()
        {
            return _entities;
        }
    }
}
