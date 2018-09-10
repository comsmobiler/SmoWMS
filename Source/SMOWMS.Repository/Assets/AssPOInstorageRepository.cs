using System.Linq;
using SMOWMS.Domain.Entity;
using SMOWMS.Domain.IRepository;
using SMOWMS.Infrastructure;

namespace SMOWMS.Repository.Assets
{
    public class AssPOInstorageRepository : BaseRepository<AssPurchaseOrderInstorage>, IAssPOInstorageRepository
    {
        /// <summary>
        /// 固定资产入库类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public AssPOInstorageRepository(IDbContext dbContext)
            : base(dbContext)
        { }

        public IQueryable<AssPurchaseOrderInstorage> GetByPOID(string POID)
        {
            return _entities.Where(a => a.POID == POID);
        }
    }
}