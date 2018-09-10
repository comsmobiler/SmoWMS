using System;
using System.Collections.Generic;
using System.Linq;
using SMOWMS.Domain.IRepository;
using SMOWMS.Infrastructure;

namespace SMOWMS.Repository.Assets
{
    /// <summary>
    /// 固定资产的仓储实现，仅用于查询
    /// </summary>
    public class AssetsRepository : BaseRepository<SMOWMS.Domain.Entity.Assets>, IAssetsRepository
    {
        /// <summary>
        /// 固定资产类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public AssetsRepository(IDbContext dbContext)
            : base(dbContext)
        { }

        /// <summary>
        ///  根据类型编号返回资产对象
        /// </summary>
        /// <param name="TypeID">类型编号</param>
        /// <returns></returns>
        public IQueryable<SMOWMS.Domain.Entity.Assets> GetByTypeID(string TypeID)
        {
            return _entities.Where(x => x.TYPEID  == TypeID);
        }

        /// <summary>
        /// 根据资产条码返回资产对象
        /// </summary>
        /// <param name="ASSID">资产编号</param>
        /// <returns></returns>
        public IQueryable<SMOWMS.Domain.Entity.Assets> GetByID(String ASSID)
        {
            var result = _entities;
            if (!string.IsNullOrEmpty(ASSID))
            {
                result = result.Where(a => a.ASSID == ASSID);
            }
            return result;
        }
        /// <summary>
        /// 根据序列号返回闲置资产对象
        /// </summary>
        /// <param name="SN">序列号</param>
        /// <returns></returns>
        public IQueryable<SMOWMS.Domain.Entity.Assets> GetUnusedBySN(String SN)
        {
            var result = _entities;
            if (!string.IsNullOrEmpty(SN))
            {
                result = result.Where(a => a.SN == SN && a.STATUS==0 && a.ISLOCKED==0);
            }
            return result;
        }

        /// <summary>
        /// 判断当前使用人是否有领用或借用资产
        /// </summary>
        /// <param name="UserID">用户编号</param>
        /// <returns></returns>
        public IQueryable<SMOWMS.Domain.Entity.Assets> GetByUser(String UserID)
        {
            var result = _entities;
            if (!string.IsNullOrEmpty(UserID))
            {
//                result = result.Where(a => a.CURRENTUSER == UserID && (a.STATUS == 2 || a.STATUS==5));
            }
            return result;
        }

        /// <summary>
        /// 查询即将失效的资产(需联合AssPR)
        /// </summary>
        /// <param name="days"></param>
        /// <returns></returns>
        public IQueryable<SMOWMS.Domain.Entity.Assets> GetImminentAssets(int days)
        {
            DateTime targetDateTime = DateTime.Now.Date.AddDays(days);
            DateTime Now = DateTime.Now.Date;
            //            return _entities.Where(a => a.EXPIRYDATE >=Now && ASSIDs.Contains(a.ASSID)).AsNoTracking();
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 查询低于安全库存的资产(需联合AssQuant)
        /// </summary>
        /// <returns></returns>
        public IQueryable<SMOWMS.Domain.Entity.Assets> GetLackOfStockAss()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 根据SN或者名称模糊查询资产
        /// </summary>
        /// <param name="SNOrName">序列号或者名称</param>
        /// <param name="types">类型</param>
        /// <returns></returns>
        public IQueryable<SMOWMS.Domain.Entity.Assets> QueryAssets(string SNOrName, List<String> types)
        {
            var result = _entities;
            if (types.Count > 0)
            {
                result = result.Where(a => types.Contains(a.TYPEID));
            }
            if (!string.IsNullOrEmpty(SNOrName))
            {
                result = result.Where(a => a.SN.Contains(SNOrName) || a.NAME.Contains(SNOrName));
            }
            return result;
        }

        /// <summary>
        /// 根据序列号得到资产
        /// </summary>
        /// <param name="SN">序列号</param>
        /// <returns></returns>
        public IQueryable<SMOWMS.Domain.Entity.Assets> GetAssetsBySN(string SN)
        {
            var result = _entities;
            if (!string.IsNullOrEmpty(SN))
            {
                result = result.Where(a => a.SN==SN);
            }
            return result;
        }

        /// <summary>
        /// 得到最大编号
        /// </summary>
        /// <returns></returns>
        public string GetMaxID()
        {
            return _entities.Select(e => e.ASSID).Max();
        }

        /// <summary>
        /// 查询序列号是否存在
        /// </summary>
        /// <param name="SN">序列号</param>
        /// <returns></returns>
        public bool SNIsExists(string SN)
        {
            return _entities.Any(a => a.SN == SN);
        }

        /// <summary>
        /// 得到在库的序列号列表
        /// </summary>
        /// <param name="snList">序列号列表</param>
        /// <returns></returns>
        public Dictionary<string, int> GetCountBySnList(List<string> snList)
        {
            Dictionary<string, int> resultDictionary = new Dictionary<string, int>();
            var assets = _entities.Where(a => snList.Contains(a.SN)&&a.ISINWAREHOUSE==1);
            var templates = assets.Select(a => a.TEMPLATEID).Distinct();
            foreach (var templateId in templates.ToList())
            {
                var count = assets.Where(a => a.TEMPLATEID == templateId).Select(a => a.SN).Count();
                resultDictionary.Add(templateId, count);
            }
            return resultDictionary;
        }

        /// <summary>
        /// 得到不在库的序列号列表
        /// </summary>
        /// <param name="snList">序列号列表</param>
        /// <returns></returns>
        public Dictionary<string, int> GetCountBySnListEx(List<string> snList)
        {
            Dictionary<string, int> resultDictionary = new Dictionary<string, int>();
            var assets = _entities.Where(a => snList.Contains(a.SN) && a.ISINWAREHOUSE == 0);
            var templates = assets.Select(a => a.TEMPLATEID).Distinct();
            foreach (var templateId in templates.ToList())
            {
                var count = assets.Where(a => a.TEMPLATEID == templateId).Select(a => a.SN).Count();
                resultDictionary.Add(templateId, count);
            }
            return resultDictionary;
        }

        /// <summary>
        /// 根据类型和仓库等相关信息，得到盘点清单
        /// </summary>
        /// <param name="WAREID">仓库编号</param>
        /// <param name="STID">存储类型编号</param>
        /// <param name="SLID">库位编号</param>
        /// <param name="typeId">类型编号</param>
        /// <returns></returns>
        public IQueryable<Domain.Entity.Assets> GetInventoryAssetses(string WAREID, string STID, string SLID, string typeId)
        {
            var result = _entities.Where(a => a.WAREID == WAREID&&a.ISINWAREHOUSE==1);
            if (!string.IsNullOrEmpty(STID))
            {
                result = result.Where(a => a.STID == STID);
            }
            if (!string.IsNullOrEmpty(typeId))
            {
                result = result.Where(a => a.TYPEID == typeId);
            }
            if (!string.IsNullOrEmpty(SLID))
            {
                result = result.Where(a => a.SLID == SLID);
            }
            return result;
        }
    }
}
