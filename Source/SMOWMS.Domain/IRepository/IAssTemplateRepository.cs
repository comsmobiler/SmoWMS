using System;
using System.Collections.Generic;
using System.Linq;
using SMOWMS.Domain.Entity;

namespace SMOWMS.Domain.IRepository
{
    public interface IAssTemplateRepository : IRepository<AssTemplate>
    {
        /// <summary>
        /// 根据资产模板编号返回资产模板信息
        /// </summary>
        /// <param name="id">资产模板编号</param>
        /// <returns></returns>
        IQueryable<AssTemplate> GetById(string id);

        /// <summary>
        /// 得到最大编号
        /// </summary>
        /// <returns></returns>
        string GetMaxId();

        /// <summary>
        /// 根据TemplateID或者名称模糊查询资产模板
        /// </summary>
        /// <param name="TemplateIdOrName">TemplateID或者名称</param>
        /// <param name="types">类型</param>
        /// <returns></returns>
        IQueryable<AssTemplate> QueryAssTemplates(string TemplateIdOrName, List<String> types);
    }
}