using System.Linq;
using SMOWMS.Domain.Entity;
using SMOWMS.Domain.IRepository;
using SMOWMS.Infrastructure;

namespace SMOWMS.Repository.Assets
{
    public class AssPORowRepository : BaseRepository<AssPurchaseOrderRow>, IAssPORowRepository
    {
        /// <summary>
        /// 采购单行项类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public AssPORowRepository(IDbContext dbContext)
            : base(dbContext)
        { }

        /// <summary>
        /// 根据行项编号得到行项
        /// </summary>
        /// <param name="POROWID">行项编号</param>
        /// <returns></returns>
        public IQueryable<AssPurchaseOrderRow> GetById(int POROWID)
        {
            return _entities.Where(a => a.POROWID == POROWID);
        }
        /// <summary>
        /// 根据采购单编号得到行项
        /// </summary>
        /// <param name="POID"></param>
        /// <returns></returns>
        public IQueryable<AssPurchaseOrderRow> GetByPOID(string POID)
        {
            return _entities.Where(x=>x.POID==POID);
        }
        /// <summary>
        /// 根据采购单编号和资产模板编号，得到行项信息
        /// </summary>
        /// <param name="POID">采购单编号</param>
        /// <param name="TemplateId">资产模板编号</param>
        /// <returns></returns>
        public IQueryable<AssPurchaseOrderRow> GetByPOIDandTemplateID(string POID, string TemplateId)
        {
            var result = _entities;
            if (!string.IsNullOrEmpty(POID))
            {
                result = result.Where(a => a.POID == POID);
            }
            if (!string.IsNullOrEmpty(TemplateId))
            {
                result = result.Where(a => a.TEMPLATEID == TemplateId);
            }
            return result;
        }
    }
}