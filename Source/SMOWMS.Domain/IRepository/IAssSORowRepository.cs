using System.Linq;
using SMOWMS.Domain.Entity;

namespace SMOWMS.Domain.IRepository
{
    public interface IAssSORowRepository:IRepository<AssSalesOrderRow>
    {
        /// <summary>
        /// 根据行项编号得到行项
        /// </summary>
        /// <param name="SOROWID">行项编号</param>
        /// <returns></returns>
        IQueryable<AssSalesOrderRow> GetBySOROWID(int SOROWID);

        /// <summary>
        /// 根据销售单编号和资产模板编号得到的行项
        /// </summary>
        /// <param name="SOID">销售单编号</param>
        /// <param name="TemplateId">资产模板编号</param>
        /// <returns></returns>
        IQueryable<AssSalesOrderRow> GetBySOIDandTemplateID(string SOID, string TemplateId);

        /// <summary>
        /// 根据销售单号获取行项
        /// </summary>
        /// <param name="SOID"></param>
        /// <returns></returns>
        IQueryable<AssSalesOrderRow> GetBySOID(string SOID);
    }
}