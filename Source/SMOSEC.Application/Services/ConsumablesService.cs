using SMOWMS.Application.IServices;
using SMOWMS.CommLib;
using SMOWMS.Domain.Entity;
using SMOWMS.Domain.IRepository;
using SMOWMS.Infrastructure;
using SMOWMS.Repository.Consumables;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using AutoMapper;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.DTOs.OutputDTO;

namespace SMOWMS.Application.Services
{
    /// <summary>
    /// 耗材的接口实现
    /// </summary>
    public class ConsumablesService : IConsumablesService
    {
        /// <summary>
        /// 工作单元的接口
        /// </summary>
        private IUnitOfWork _unitOfWork;
        /// <summary>
        /// 耗材信息的查询接口
        /// </summary>
        private IConsumablesRepository _consumablesRepository;
        /// <summary>
        /// 耗材库存的查询接口
        /// </summary>
        private IConQuantRepository _conQuantRepository;
        /// <summary>
        /// 数据库上下文
        /// </summary>
        private SMOWMSDbContext SMOWMSDbContext;
        /// <summary>
        /// 耗材服务实现的构造函数
        /// </summary>
        public ConsumablesService(IUnitOfWork unitOfWork,
            IConsumablesRepository consumablesRepository,
            IConQuantRepository conQuantRepository,
            IDbContext dbContext)
        {
            _unitOfWork = unitOfWork;
            _conQuantRepository = conQuantRepository;
            _consumablesRepository = consumablesRepository;
            SMOWMSDbContext = (SMOWMSDbContext)dbContext;
        }
        #region 查询
        /// <summary>
        /// 根据库位等编号和耗材编号得到耗材库存
        /// </summary>
        /// <param name="WAREID">仓库编号</param>
        /// <param name="STID">类型编号</param>
        /// <param name="SLID">库位编号</param>
        /// <param name="CID">耗材编号</param>
        /// <returns></returns>
        public ConQuant GetQuants(string WAREID, string STID, string SLID, string CID)
        {
            ConQuant conQuant = _conQuantRepository.GetByCID(CID, WAREID, STID, SLID).FirstOrDefault();
            return conQuant;
        }
        /// <summary>
        /// 库存分析
        /// </summary>
        /// <param name="wareId"></param>
        /// <returns></returns>
        public Dictionary<string, decimal> GetQuantAnalyse(string wareId)
        {
            var conQuants = String.IsNullOrEmpty(wareId)
                ? _conQuantRepository.GetAll().AsNoTracking()
                : _conQuantRepository.GetAll().Where(x => x.WAREID == wareId).AsNoTracking();
            var conResult = from conQuant in conQuants
                            join con in SMOWMSDbContext.Consumableses on conQuant.CID equals con.CID
                            select new ConOutputDto
                            {
                                CID = conQuant.CID,
                                NAME = con.NAME,
                                QUANTITY = conQuant.QUANTITY
                            };

            Dictionary<string, decimal> result = new Dictionary<string, decimal>();
            foreach (ConOutputDto row in conResult)
            {
                if (result.ContainsKey(row.NAME))
                {
                    result[row.NAME] = result[row.NAME] + row.QUANTITY;
                }
                else
                {
                    result.Add(row.NAME, row.QUANTITY);
                }
            }
            return result;
        }
        /// <summary>
        /// 安全库存分析
        /// </summary>
        /// <returns></returns>
        public List<ConOutputDto> GetSafeQuantAnalyse()
        {
            var conQuants = _conQuantRepository.GetAll().AsNoTracking();
            var conResult = from con in SMOWMSDbContext.Consumableses
                            join conQuant in conQuants on con.CID equals conQuant.CID
                            into temp
                            from tt in temp.DefaultIfEmpty()
                            select new ConOutputDto
                            {
                                CID = con.CID,
                                NAME = con.NAME,
                                QUANTITY = tt == null ? 0 : tt.QUANTITY,
                                SAFEFLOOR = con.SAFEFLOOR
                            };
            Dictionary<string, List<decimal>> quantResult = new Dictionary<string, List<decimal>>();
            foreach (ConOutputDto row in conResult)
            {
                decimal Quantity = row.QUANTITY;
                if (String.IsNullOrEmpty(row.QUANTITY.ToString()))
                {
                    Quantity = 0;
                }
                if (quantResult.ContainsKey(row.CID))
                {
                    quantResult[row.CID][0] = quantResult[row.CID][0] + Quantity;
                }
                else
                {
                    quantResult.Add(row.CID, new List<decimal> { Quantity, Convert.ToDecimal(row.SAFEFLOOR) });
                }
            }
            List<ConOutputDto> result = new List<ConOutputDto>();
            foreach (string CID in quantResult.Keys)
            {
                if (quantResult[CID][0] <= quantResult[CID][1] + 10)      //当前库存低于安全库存+10
                {
                    ConOutputDto row = new ConOutputDto();
                    Consumables con = _consumablesRepository.GetByID(CID).AsNoTracking().FirstOrDefault();
                    row.CID = CID;
                    row.NAME = con.NAME;
                    row.SPECIFICATION = con.SPECIFICATION;
                    row.QUANTITY = quantResult[CID][0];
                    row.SAFEFLOOR = con.SAFEFLOOR;
                    result.Add(row);
                }
            }
            return result;
        }
        /// <summary>
        /// 根据库位等编号和耗材编号得到耗材库存
        /// </summary>
        /// <param name="WAREID">仓库编号</param>
        /// <param name="STID">类型编号</param>
        /// <param name="SLID">库位编号</param>
        /// <param name="CID">耗材编号</param>
        /// <returns></returns>
        public DataTable GetQuantsEx(string WAREID, string STID, string SLID, string CID)
        {
            var list = _conQuantRepository.GetByCID(CID, WAREID, STID, SLID).AsNoTracking();
            var result = from conQuant in list
                         join consumablese in SMOWMSDbContext.Consumableses on conQuant.CID equals consumablese.CID
                         from wareHouse in SMOWMSDbContext.WareHouses
                         from whStorageType in SMOWMSDbContext.WHStorageTypes
                         from whStorageLocation in SMOWMSDbContext.WHStorageLocations
                         where conQuant.WAREID == wareHouse.WAREID && conQuant.WAREID == whStorageType.WAREID && conQuant.STID == whStorageType.STID && conQuant.WAREID == whStorageLocation.WAREID && conQuant.STID == whStorageLocation.STID && conQuant.SLID == whStorageLocation.SLID
                         select new
                         {
                             CID = conQuant.CID,
                             NAME = consumablese.NAME,
                             SLNAME = wareHouse.NAME + "-" + whStorageType.NAME + "-" + whStorageLocation.NAME,
                             QUANTITY = conQuant.QUANTITY
                         };
            return LINQToDataTable.ToDataTable(result);
        }
        /// <summary>
        /// 获取某个耗材的库存总数
        /// </summary>
        /// <param name="CID"></param>
        /// <returns></returns>
        public decimal GetSumByCID(string CID)
        {
            return _conQuantRepository.GetSumByCID(CID);
        }
        /// <summary>
        /// 得到耗材列表
        /// </summary>
        /// <returns></returns>

        public DataTable GetConList()
        {
            var list = _consumablesRepository.GetAll().AsNoTracking();
            return LINQToDataTable.ToDataTable(list);
        }

        /// <summary>
        /// 根据耗材编号查询耗材信息
        /// </summary>
        /// <param name="CID">耗材编号</param>
        /// <returns></returns>
        public Consumables GetConsById(string CID)
        {
            return _consumablesRepository.GetByID(CID).AsNoTracking().FirstOrDefault();
        }
        /// <summary>
        /// 查找所有耗材(根据耗材名称)
        /// </summary>
        /// <param name="name">耗材名称</param>
        /// <returns></returns>
        public List<Consumables> GetConsByName(string name)
        {
            return _consumablesRepository.GetByName(name).AsNoTracking().ToList();
        }
        #endregion
        #region 操作
        /// <summary>
        /// 添加耗材
        /// </summary>
        /// <param name="inputDto">耗材信息</param>
        /// <returns></returns>
        public ReturnInfo AddConsumables(ConsumablesInputDto inputDto)
        {
            ReturnInfo rInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            string maxId = _consumablesRepository.GetMaxID();
            string CId = Helper.GenerateIDEx("C", maxId);
            inputDto.CID = CId;
            sb.Append(Helper.BasicValidate(inputDto).ToString());
            if (sb.Length == 0)
            {
                var consumable = Mapper.Map<ConsumablesInputDto, Consumables>(inputDto);
                consumable.CREATEDATE = DateTime.Now;
                consumable.MODIFYDATE = DateTime.Now;
                try
                {
                    _unitOfWork.RegisterNew(consumable);
                    bool result = _unitOfWork.Commit();
                    rInfo.IsSuccess = result;
                    rInfo.ErrorInfo = sb.ToString();
                    return rInfo;
                }
                catch (Exception ex)
                {
                    _unitOfWork.Rollback();
                    sb.Append(ex.Message);
                    rInfo.IsSuccess = false;
                    rInfo.ErrorInfo = sb.ToString();
                    return rInfo;
                }
            }
            else
            {
                rInfo.IsSuccess = false;
                rInfo.ErrorInfo = sb.ToString();
                return rInfo;
            }

        }
        /// <summary>
        /// 更新耗材
        /// </summary>
        /// <param name="inputDto">耗材信息</param>
        /// <returns></returns>
        public ReturnInfo UpdateConsumables(ConsumablesInputDto inputDto)
        {
            ReturnInfo rInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            sb.Append(Helper.BasicValidate(inputDto).ToString());
            if (sb.Length == 0)
            {
                try
                {
                    Consumables consumable = _consumablesRepository.GetByID(inputDto.CID).FirstOrDefault();
                    if (consumable != null)
                    {
                        consumable.MODIFYDATE = DateTime.Now;
                        consumable.IMAGE = inputDto.IMAGE;
                        consumable.MODIFYUSER = inputDto.MODIFYUSER;
                        consumable.NAME = inputDto.NAME;
                        consumable.NOTE = inputDto.NOTE;
                        consumable.SAFECEILING = inputDto.SAFECEILING;
                        consumable.SAFEFLOOR = inputDto.SAFEFLOOR;
                        consumable.SPECIFICATION = inputDto.SPECIFICATION;
                        consumable.SPQ = inputDto.SPQ;
                        consumable.UNIT = inputDto.UNIT;
                        _unitOfWork.RegisterDirty(consumable);

                    }

                    bool result = _unitOfWork.Commit();
                    rInfo.IsSuccess = result;
                    rInfo.ErrorInfo = sb.ToString();
                    return rInfo;
                }
                catch (Exception ex)
                {
                    _unitOfWork.Rollback();
                    sb.Append(ex.Message);
                    rInfo.IsSuccess = false;
                    rInfo.ErrorInfo = sb.ToString();
                    return rInfo;
                }
            }
            else
            {
                rInfo.IsSuccess = false;
                rInfo.ErrorInfo = sb.ToString();
                return rInfo;
            }
        }
        /// <summary>
        /// 删除耗材
        /// </summary>
        /// <param name="CID">耗材编号</param>
        /// <returns></returns>
        public ReturnInfo DeleteConsumables(string CID)
        {
            ReturnInfo rInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            var consumable = _consumablesRepository.GetByID(CID).FirstOrDefault();
            if (consumable == null)
            {
                sb.Append("未找到该编号的耗材.");
                rInfo.IsSuccess = false;
                rInfo.ErrorInfo = sb.ToString();
                return rInfo;
            }
            else
            {
                var quant = _conQuantRepository.GetQuants("", CID);
                if (quant == null || quant.ToList().Count == 0)
                {
                    try
                    {
                        _unitOfWork.RegisterDeleted(consumable);
                        _unitOfWork.Commit();
                        rInfo.IsSuccess = true;
                        rInfo.ErrorInfo = sb.ToString();
                        return rInfo;
                    }
                    catch (Exception ex)
                    {
                        _unitOfWork.Rollback();
                        sb.Append(ex.Message);
                        rInfo.IsSuccess = false;
                        rInfo.ErrorInfo = sb.ToString();
                        return rInfo;
                    }
                }
                else
                {
                    sb.Append("存在入库记录,故无法删除。");
                    rInfo.IsSuccess = false;
                    rInfo.ErrorInfo = sb.ToString();
                    return rInfo;
                }
            }
        }
        #endregion
    }
}
