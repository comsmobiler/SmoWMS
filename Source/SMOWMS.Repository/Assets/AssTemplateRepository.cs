using System.Collections.Generic;
using System.Linq;
using SMOWMS.Domain.Entity;
using SMOWMS.Domain.IRepository;
using SMOWMS.Infrastructure;

namespace SMOWMS.Repository.Assets
{
    public class AssTemplateRepository : BaseRepository<AssTemplate>, IAssTemplateRepository
    {
        /// <summary>
        /// 资产模板查询类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public AssTemplateRepository(IDbContext dbContext)
            : base(dbContext)
        { }

        /// <summary>
        /// 根据资产模板编号返回资产模板信息
        /// </summary>
        /// <param name="id">资产模板编号</param>
        /// <returns></returns>
        public IQueryable<AssTemplate> GetById(string id)
        {
            return _entities.Where(a => a.TEMPLATEID == id);
        }

        /// <summary>
        /// 得到最大编号
        /// </summary>
        /// <returns></returns>
        public string GetMaxId()
        {
            return _entities.Select(e => e.TEMPLATEID).Max();
        }

        /// <summary>
        /// 根据TemplateID或者名称模糊查询资产模板
        /// </summary>
        /// <param name="TemplateIdOrName">TemplateID或者名称</param>
        /// <param name="types">类型</param>
        /// <returns></returns>
        public IQueryable<AssTemplate> QueryAssTemplates(string TemplateIdOrName, List<string> types)
        {
            var result = _entities;
            if (types.Count > 0)
            {
                result = result.Where(a => types.Contains(a.TYPEID));
            }
            if (!string.IsNullOrEmpty(TemplateIdOrName))
            {
                result = result.Where(a => a.NAME.Contains(TemplateIdOrName) || a.TEMPLATEID.Contains(TemplateIdOrName));
            }
            return result;
        }
    }
}