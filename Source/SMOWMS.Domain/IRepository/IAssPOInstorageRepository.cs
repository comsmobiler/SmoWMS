using System.Linq;
using SMOWMS.Domain.Entity;

namespace SMOWMS.Domain.IRepository
{
    public interface IAssPOInstorageRepository:IRepository<AssPurchaseOrderInstorage>
    {
        IQueryable<AssPurchaseOrderInstorage> GetByPOID(string POID);
    }
}