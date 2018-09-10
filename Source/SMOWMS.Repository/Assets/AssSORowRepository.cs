using System.Linq;
using SMOWMS.Domain.Entity;
using SMOWMS.Domain.IRepository;
using SMOWMS.Infrastructure;

namespace SMOWMS.Repository.Assets
{
    public class AssSORowRepository : BaseRepository<AssSalesOrderRow>, IAssSORowRepository
    {
        /// <summary>
        /// 销售单行项类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public AssSORowRepository(IDbContext dbContext)
            : base(dbContext)
        { }

        /// <summary>
        /// 根据行项编号得到行项
        /// </summary>
        /// <param name="SOROWID">行项编号</param>
        /// <returns></returns>
        public IQueryable<AssSalesOrderRow> GetBySOROWID(int SOROWID)
        {
            return _entities.Where(a => a.SOROWID == SOROWID);
        }

        /// <summary>
        /// 根据销售单编号和资产模板编号得到的行项
        /// </summary>
        /// <param name="SOID">销售单编号</param>
        /// <param name="TemplateId">资产模板编号</param>
        /// <returns></returns>
        public IQueryable<AssSalesOrderRow> GetBySOIDandTemplateID(string SOID, string TemplateId)
        {
            var result = _entities;
            if (!string.IsNullOrEmpty(SOID))
            {
                result = result.Where(a => a.SOID == SOID);
            }
            if (!string.IsNullOrEmpty(TemplateId))
            {
                result = result.Where(a => a.TEMPLATEID == TemplateId);
            }
            return result;
        }

        /// <summary>
        /// 根据销售单号获取行项
        /// </summary>
        /// <param name="SOID"></param>
        /// <returns></returns>
        public IQueryable<AssSalesOrderRow> GetBySOID(string SOID)
        {
            return _entities.Where(x=>x.SOID==SOID);
        }
    }
}