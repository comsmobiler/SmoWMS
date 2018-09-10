using System.Linq;
using SMOWMS.Domain.Entity;

namespace SMOWMS.Domain.IRepository
{
    public interface IAssPORowRepository:IRepository<AssPurchaseOrderRow>
    {
        /// <summary>
        /// 根据行项编号得到行项
        /// </summary>
        /// <param name="POROWID">行项编号</param>
        /// <returns></returns>
        IQueryable<AssPurchaseOrderRow> GetById(int POROWID);

        /// <summary>
        /// 根据采购单编号和资产模板编号，得到行项信息
        /// </summary>
        /// <param name="POID">采购单编号</param>
        /// <param name="TemplateId">资产模板编号</param>
        /// <returns></returns>
        IQueryable<AssPurchaseOrderRow> GetByPOIDandTemplateID(string POID, string  TemplateId);
        /// <summary>
        /// 根据采购单编号得到行项
        /// </summary>
        /// <param name="POID"></param>
        /// <returns></returns>
        IQueryable<AssPurchaseOrderRow> GetByPOID(string POID);
    }
}