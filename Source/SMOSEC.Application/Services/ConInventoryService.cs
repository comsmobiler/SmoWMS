using AutoMapper;
using SMOWMS.Application.IServices;
using SMOWMS.CommLib;
using SMOWMS.Domain.Entity;
using SMOWMS.Domain.IRepository;
using SMOWMS.DTOs.Enum;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.DTOs.OutputDTO;
using SMOWMS.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace SMOWMS.Application.Services
{
    /// <summary>
    /// 耗材盘点单服务实现
    /// </summary>
    public class ConInventoryService : IConInventoryService
    {
        /// <summary>
        /// 工作单元的接口
        /// </summary>
        private IUnitOfWork _unitOfWork;

        /// <summary>
        /// 耗材信息的查询接口
        /// </summary>
        private IConsumablesRepository _conRepository;

        /// <summary>
        /// 耗材库存的查询接口
        /// </summary>
        private IConQuantRepository _conQuantRepository;

        /// <summary>
        /// 数据库上下文
        /// </summary>
        private SMOWMSDbContext _SMOWMSDbContext;
        /// <summary>
        /// 耗材盘点单的查询接口
        /// </summary>
        private IConInventoryRepository _conInventoryRepository;

        /// <summary>
        /// 耗材盘点结果行项的查询接口
        /// </summary>
        private IConInventoryResultRepository _conInventoryResultRepository;
        /// <summary>
        /// 耗材盘点的服务实现的构造函数
        /// </summary>
        public ConInventoryService(IUnitOfWork unitOfWork,
            IConsumablesRepository conRepository,
            IConQuantRepository conQuantRepository,
            IConInventoryRepository conInventoryRepository,
            IConInventoryResultRepository conInventoryResultRepository,
            IDbContext dbContext)
        {
            _unitOfWork = unitOfWork;
            _conRepository = conRepository;
            _conQuantRepository = conQuantRepository;
            _conInventoryRepository = conInventoryRepository;
            _conInventoryResultRepository = conInventoryResultRepository;
            _SMOWMSDbContext = (SMOWMSDbContext)dbContext;
        }

        #region 查询

        /// <summary>
        /// 根据盘点单编号得到盘点单详情
        /// </summary>
        /// <param name="IID">盘点单编号</param>
        /// <returns></returns>
        public ConInventoryOutputDto GetConInventoryById(string IID)
        {
            try
            {
                var conInventory = _conInventoryRepository.GetConInventoryByID(IID);
                if (conInventory != null)
                {
                    //仓库下盘点
                    var list = from Inventory in conInventory
                               join user in _SMOWMSDbContext.coreUsers on Inventory.HANDLEMAN equals user.USER_ID
                               join WH in _SMOWMSDbContext.WareHouses on Inventory.WAREID equals WH.WAREID
                               select new ConInventoryOutputDto()
                               {
                                   NAME = Inventory.NAME,
                                   CREATEDATE = Inventory.CREATEDATE,
                                   HANDLEMAN = Inventory.HANDLEMAN,
                                   HANDLEMANNAME = user.USER_NAME,
                                   IID = Inventory.IID,
                                   WAREID = Inventory.WAREID,
                                   WARENAME = WH.NAME,
                                   STID = Inventory.STID,
                                   STNAME = "",
                                   SLID = Inventory.SLID,
                                   SLNAME = "",
                                   STATUS = Inventory.STATUS,
                                   STATUSNAME = "",
                                   TOTAL = Inventory.TOTAL
                               };
                    //存储类型下盘点
                    if (String.IsNullOrEmpty(conInventory.FirstOrDefault().STID) == false)
                    {
                        list = from Inventory in list
                               join WHST in _SMOWMSDbContext.WHStorageTypes on Inventory.STID equals WHST.STID
                               where Inventory.WAREID == WHST.WAREID
                               select new ConInventoryOutputDto()
                               {
                                   NAME = Inventory.NAME,
                                   CREATEDATE = Inventory.CREATEDATE,
                                   HANDLEMAN = Inventory.HANDLEMAN,
                                   HANDLEMANNAME = Inventory.HANDLEMANNAME,
                                   IID = Inventory.IID,
                                   WAREID = Inventory.WAREID,
                                   WARENAME = Inventory.WARENAME,
                                   STID = Inventory.STID,
                                   STNAME = WHST.NAME,
                                   SLID = Inventory.SLID,
                                   SLNAME = "",
                                   STATUS = Inventory.STATUS,
                                   STATUSNAME = "",
                                   TOTAL = Inventory.TOTAL
                               };
                    }
                    if (String.IsNullOrEmpty(conInventory.FirstOrDefault().SLID) == false)
                    {
                        //库位下盘点
                        list = from Inventory in list
                               join WHSL in _SMOWMSDbContext.WHStorageLocations on Inventory.SLID equals WHSL.SLID
                               where Inventory.WAREID == WHSL.WAREID && Inventory.STID == WHSL.STID
                               select new ConInventoryOutputDto()
                               {
                                   NAME = Inventory.NAME,
                                   CREATEDATE = Inventory.CREATEDATE,
                                   HANDLEMAN = Inventory.HANDLEMAN,
                                   HANDLEMANNAME = Inventory.HANDLEMANNAME,
                                   IID = Inventory.IID,
                                   WAREID = Inventory.WAREID,
                                   WARENAME = Inventory.WARENAME,
                                   STID = Inventory.STID,
                                   STNAME = Inventory.STNAME,
                                   SLID = Inventory.SLID,
                                   SLNAME = WHSL.NAME,
                                   STATUS = Inventory.STATUS,
                                   STATUSNAME = "",
                                   TOTAL = Inventory.TOTAL
                               };
                    }
                    var result = list.FirstOrDefault();
                    result.STATUSNAME = Enum.GetName(typeof(InventoryStatus), result.STATUS);
                    return result;
                }
                else
                {
                    throw new Exception("未找到该盘点");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 根据库位和物料，查询盘点单行项详情
        /// </summary>
        /// <param name="IID"></param>
        /// <param name="CID"></param>
        /// <param name="WAREID"></param>
        /// <param name="STID"></param>
        /// <param name="SLID"></param>
        /// <returns></returns>
        public ConInventoryResult GetResultBySL(string IID, string CID, string WAREID, string STID, string SLID)
        {
            return _conInventoryResultRepository.GetResultBySL(IID, CID, WAREID, STID, SLID).FirstOrDefault();
        }
        /// <summary>
        /// 根据库存和盘点单号，查询该盘点单下，该库位下的盘点单行项
        /// </summary>
        /// <param name="IID"></param>
        /// <param name="WAREID"></param>
        /// <param name="STID"></param>
        /// <param name="SLID"></param>
        /// <returns></returns>
        public List<ConInventoryResult> GetResultListBySL(string IID, string WAREID, string STID, string SLID)
        {
            return _conInventoryResultRepository.GetResultListBySL(IID, WAREID, STID, SLID).ToList();
        }
        /// <summary>
        /// 得到盘点单列表
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="WAREID"></param>
        /// <returns></returns>
        public DataTable GetConInventoryList(string UserId, string WAREID)
        {
            var area = _conInventoryRepository.GetAll();
            if (!string.IsNullOrEmpty(WAREID))
            {
                area = area.Where(a => a.WAREID == WAREID);
            }
            if (!string.IsNullOrEmpty(UserId))
            {
                area = area.Where(a => a.HANDLEMAN == UserId);
            }
            var list = from conInventory in area
                       join user in _SMOWMSDbContext.coreUsers on conInventory.HANDLEMAN equals user.USER_ID
                       orderby conInventory.CREATEDATE descending
                       select new ConInventoryListOutputDto()
                       {
                           IID = conInventory.IID,
                           NAME = conInventory.NAME,
                           CREATEDATE = conInventory.CREATEDATE,
                           CREATEUSER = user.USER_NAME,
                           CREATEUSERNAME = "",
                           TOTAL = conInventory.TOTAL,
                           RESULTCOUNT = conInventory.RESULTCOUNT,
                           COUNT = "",
                           STATUS = conInventory.STATUS,
                           STATUSNAME = "",
                           Time = ""
                       };
            var temTable = LINQToDataTable.ToDataTable(list);
            foreach (DataRow row in temTable.Rows)
            {
                int status = int.Parse(row["STATUS"].ToString());
                row["CREATEUSERNAME"] = row["CREATEUSER"].ToString()[0];
                row["STATUSNAME"] = Enum.GetName(typeof(InventoryStatus), status);
                row["COUNT"] = row["RESULTCOUNT"] + "/" + row["TOTAL"];;
                row["Time"] = string.Format("{0:yyyy.MM.dd}", row["CREATEDATE"]);
            }
            return temTable;
        }

        /// <summary>
        /// 根据盘点单编号得到结果行项信息
        /// </summary>
        /// <param name="IID">盘点单编号</param>
        /// <returns></returns>
        public DataTable GetConInventoryResultsByIID(string IID, ResultStatus Status)
        {
            int status = (int)Status;
            var list = _conInventoryResultRepository.GetResultsByStatus(IID, status);
            var results = from invR in list
                          join cons in _SMOWMSDbContext.Consumableses on invR.CID equals cons.CID
                          join invs in _SMOWMSDbContext.ConInventories on invR.IID equals invs.IID
                          from WH in _SMOWMSDbContext.WareHouses
                          from WHSL in _SMOWMSDbContext.WHStorageLocations
                          from WHST in _SMOWMSDbContext.WHStorageTypes
                          where invR.WAREID == WH.WAREID
                          && invR.STID == WHSL.STID && invR.SLID == WHSL.SLID
                          && invR.WAREID == WHST.WAREID && invR.STID == WHST.STID
                          && invR.WAREID == WH.WAREID
                          select new ConInventoryResultOutputDto()
                          {
                              CID = invR.CID,
                              WAREID = invR.WAREID,
                              WARENAME = WH.NAME,
                              STID = invR.STID,
                              STNAME = WHST.NAME,
                              SLID = invR.SLID,
                              SLNAME = WHSL.NAME,
                              RESULT = invR.RESULT,
                              RESULTNAME = "",
                              Image = cons.IMAGE,
                              Name = cons.NAME,
                              Unit = cons.UNIT,
                              Total = invR.TOTAL,
                              RealAmount = invR.REALAMOUNT
                          };
            DataTable tempTable = LINQToDataTable.ToDataTable(results);

            foreach (DataRow row in tempTable.Rows)
            {
                row["RESULTNAME"] = Enum.GetName(typeof(ResultStatus), int.Parse(row["RESULT"].ToString()));
            }
            return tempTable;
        }

        /// <summary>
        /// 查询是否已经有盘点单结果记录
        /// </summary>
        /// <param name="IID">盘点单编号</param>
        /// <returns></returns>
        public bool IsExist(string IID)
        {
            return _conInventoryResultRepository.IsExist(IID);
        }
        /// <summary>
        /// 根据仓库编号,得到盘点清单
        /// </summary>
        /// <param name="WAREID">仓库编号</param>
        /// <returns></returns>
        public DataTable GetInventoryConList(string WAREID, string STID, string SLID)
        {
            var conqlist = _conQuantRepository.GetInventoryCons(WAREID, STID, SLID);
            var results = from conq in conqlist
                          join con in _SMOWMSDbContext.Consumableses on conq.CID equals con.CID
                          from WH in _SMOWMSDbContext.WareHouses
                          from WHSL in _SMOWMSDbContext.WHStorageLocations
                          from WHST in _SMOWMSDbContext.WHStorageTypes
                          where conq.WAREID == WH.WAREID
                          && conq.STID == WHSL.STID && conq.SLID == WHSL.SLID
                          && conq.WAREID == WHST.WAREID && conq.STID == WHST.STID
                          && conq.WAREID == WH.WAREID
                          select new ConInventoryResultOutputDto()
                          {
                              CID = con.CID,
                              WAREID = conq.WAREID,
                              WARENAME = WH.NAME,
                              STID = conq.STID,
                              STNAME = WHST.NAME,
                              SLID = conq.SLID,
                              SLNAME = WHSL.NAME,
                              RESULT = 0,
                              RESULTNAME = "待盘点",
                              Image = con.IMAGE,
                              Name = con.NAME,
                              Unit = con.UNIT,
                              Total = conq.QUANTITY

                          };
            return LINQToDataTable.ToDataTable(results);
        }

        /// <summary>
        /// 得到盘点单待盘点列表
        /// </summary>
        /// <param name="IID"></param>
        /// <param name="WAREID"></param>
        /// <param name="STID"></param>
        /// <param name="SLID"></param>
        /// <returns></returns>
        public DataTable GetPendingInventoryTable(string IID, string WAREID, string STID, string SLID)
        {
            bool isExist = IsExist(IID);
            if (isExist)
            {
                //存在记录,则从盘点单结果取数据
                return GetConInventoryResultsByIID(IID, ResultStatus.待盘点);
            }
            else
            {
                //不存在,则连表查询出结果
                return GetInventoryConList(WAREID, STID, SLID);
            }
        }

        /// <summary>
        /// 得到盘点单需要盘点的列表
        /// </summary>
        /// <param name="IID">盘点单编号</param>
        /// <returns></returns>
        public List<string> GetPendingInventoryList(string IID)
        {
            List<ConInventoryResult> resultList = _conInventoryResultRepository.GetOrdinaryList(IID).ToList();
            if (resultList.Count > 0)
            {
                List<string> resultData = new List<string>();
                foreach (ConInventoryResult row in resultList)
                {
                    resultData.Add(row.CID + "/" + row.WAREID + "/" + row.STID + "/" + row.SLID);
                }
                return resultData;
            }
            return null;
        }

        /// <summary>
        /// 得到盘点单结果行项的结果字典
        /// </summary>
        /// <param name="IID">盘点单编号</param>
        /// <returns></returns>
        public Dictionary<string, List<Decimal>> GetResultDictionary(string IID)
        {
            Dictionary<string, List<Decimal>> assDictionary = new Dictionary<string, List<Decimal>>();
            var results = _conInventoryResultRepository.GetResultsByCID(IID, "");
            foreach (var result in results)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(result.CID + "/" + result.WAREID + "/" + result.STID + "/" + result.SLID);
                List<decimal> list = new List<decimal>();
                list.Add(result.REALAMOUNT);
                list.Add(result.RESULT);
                assDictionary.Add(sb.ToString(), list);
            }
            return assDictionary;
        }
        /// <summary>
        /// 根据盘点单号和耗材编号查询盘点行项
        /// </summary>
        /// <param name="IID"></param>
        /// <param name="CID"></param>
        /// <returns></returns>
        public ConInventoryResult GetResultByCID(string IID, string CID)
        {
            return _conInventoryResultRepository.GetResultsByCID(IID, CID).FirstOrDefault();
        }
        #endregion

        #region 操作
        /// <summary>
        /// 添加盘点单
        /// </summary>
        /// <param name="inputDto">盘点单信息</param>
        /// <returns></returns>
        public ReturnInfo AddConInventory(ConInventoryInputDto inputDto)
        {
            //验证
            ReturnInfo rInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            string maxId = _conInventoryRepository.GetMaxId();
            string IId = Helper.GenerateIDEx("CI", maxId);
            inputDto.IID = IId;
            sb.Append(Helper.BasicValidate(inputDto).ToString());
            if (sb.Length == 0)
            {
                var assbo = Mapper.Map<ConInventoryInputDto, ConInventory>(inputDto);
                assbo.STATUS = (int)InventoryStatus.未盘点;
                assbo.CREATEDATE = DateTime.Now;
                assbo.MODIFYDATE = DateTime.Now;

                try
                {
                    _unitOfWork.RegisterNew(assbo);

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
        /// 删除盘点单
        /// </summary>
        /// <param name="IID">盘点单编号</param>
        /// <returns></returns>
        public ReturnInfo DeleteInventory(string IID)
        {
            ReturnInfo rInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            var inventory = _conInventoryRepository.GetConInventoryByID(IID).FirstOrDefault();
            if (inventory == null)
            {
                sb.Append("未找到该编号的盘点单.");
                rInfo.IsSuccess = false;
                rInfo.ErrorInfo = sb.ToString();
                return rInfo;
            }
            else
            {
                //根据盘点单状态，已开始盘点就不能删除了
                if (inventory.STATUS == (int)InventoryStatus.未盘点)
                {
                    //可以删除
                    try
                    {
                        _unitOfWork.RegisterDeleted(inventory);
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
                    rInfo.IsSuccess = false;
                    sb.Append("已经开始盘点,无法删除盘点单.");
                    rInfo.ErrorInfo = sb.ToString();
                    return rInfo;
                }
            }
        }

        /// <summary>
        /// 更新盘点单
        /// </summary>
        /// <param name="inputDto">盘点单信息</param>
        /// <returns></returns>
        public ReturnInfo UpdateInventory(ConInventoryInputDto inputDto)
        {
            ReturnInfo rInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            var inventory = _conInventoryRepository.GetConInventoryByID(inputDto.IID).FirstOrDefault();
            if (inventory == null)
            {
                sb.Append("未找到该编号的盘点单.");
                rInfo.IsSuccess = false;
                rInfo.ErrorInfo = sb.ToString();
                return rInfo;
            }
            else
            {
                if (inventory.STATUS == (int)InventoryStatus.盘点结束)
                {
                    sb.Append("该盘点单已经盘点结束.");
                    rInfo.IsSuccess = false;
                    rInfo.ErrorInfo = sb.ToString();
                    return rInfo;
                }
                try
                {
                    List<ConInventoryResult> resultList = _conInventoryResultRepository.GetResultsByStatus(inputDto.IID, null).ToList();
                    List<String> keyList = new List<string>();
                    if (resultList.Count > 0)
                    {
                        foreach (ConInventoryResult row in resultList)
                        {
                            keyList.Add(row.CID + "/" + row.WAREID + "/" + row.STID + "/" + row.SLID);
                        }
                    }
                    int count = inputDto.ConDictionary.Count;
                    //更新盘点单结果行项
                    foreach (var key in inputDto.ConDictionary.Keys)
                    {
                        if (keyList.Contains(key))
                        {
                            String[] keys = key.Split('/');
                            //更新
                            ConInventoryResult inventoryresult = _conInventoryResultRepository.GetResultBySL
                                (inputDto.IID, keys[0], keys[1], keys[2], keys[3]).FirstOrDefault();
                            if (inventoryresult != null)
                            {
                                inventoryresult.RESULT = Convert.ToInt32(inputDto.ConDictionary[key][1]);
                                inventoryresult.REALAMOUNT = inputDto.ConDictionary[key][0];
                                if (inventoryresult.RESULT == (int)ResultStatus.待盘点)
                                {
                                    count--;
                                }
                            }
                            _unitOfWork.RegisterDirty(inventoryresult);
                        }
                        else
                        {
                            //添加
                            ConInventoryResult result = new ConInventoryResult
                            {
                                IID = inputDto.IID,
                                CID = key.Split('/')[0],
                                WAREID = key.Split('/')[1],
                                STID = key.Split('/')[2],
                                SLID = key.Split('/')[3],
                                REALAMOUNT = inputDto.ConDictionary[key][0],
                                RESULT = Convert.ToInt32(inputDto.ConDictionary[key][1]),
                                CREATEDATE = DateTime.Now,
                                MODIFYDATE = DateTime.Now,
                                CREATEUSER = inputDto.MODIFYUSER,
                                MODIFYUSER = inputDto.MODIFYUSER
                            };
                            _unitOfWork.RegisterNew(result);
                        }
                        if (inputDto.IsEnd)
                        {
                            //如果盘点结束，就更新资产状态为非锁定
                            var conqs = _conQuantRepository.GetQuants(inputDto.WAREID, key).FirstOrDefault();
                            if (conqs != null)
                            {
                                conqs.ISLOCKED = 0;
                                _unitOfWork.RegisterDirty(conqs);
                            }

                        }
                    }
                    //如果盘点结束，就更新盘点单状态
                    inventory.MODIFYUSER = inputDto.MODIFYUSER;
                    inventory.MODIFYDATE = DateTime.Now;
                    inventory.RESULTCOUNT = count;
                    if (inputDto.IsEnd)
                    {
                        inventory.STATUS = (int)InventoryStatus.盘点结束;
                    }
                    _unitOfWork.RegisterDirty(inventory);

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

        }

        /// <summary>
        /// 只更新盘点单表头
        /// </summary>
        /// <param name="inputDto">所需数据</param>
        /// <returns></returns>
        public ReturnInfo UpdateInventoryOnly(AddCIResultInputDto inputDto)
        {
            //验证
            ReturnInfo rInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            if (sb.Length == 0)
            {
                var assInventory = _conInventoryRepository.GetConInventoryByID(inputDto.IID).FirstOrDefault();
                if (assInventory != null)
                {
                    assInventory.NAME = inputDto.Name;
                    assInventory.MODIFYDATE = DateTime.Now;
                    assInventory.HANDLEMAN = inputDto.HANDLEMAN;
                    assInventory.WAREID = inputDto.WAREID;
                    assInventory.STID = inputDto.STID;
                    assInventory.SLID = inputDto.SLID;
                    try
                    {
                        _unitOfWork.RegisterDirty(assInventory);


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
                    sb.Append("未找到该盘点单.");
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
        /// 开始盘点
        /// </summary>
        /// <param name="inputDto">开始盘点时,传给后台的数据</param>
        /// <returns></returns>
        public ReturnInfo AddConInventoryResult(AddCIResultInputDto inputDto)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            if (IsExist(inputDto.IID))
            {
                RInfo.IsSuccess = true;
                RInfo.ErrorInfo = sb.ToString();
                return RInfo;
            }
            else
            {
                try
                {
                    //更新盘点单状态为盘点中
                    var inventory = _conInventoryRepository.GetConInventoryByID(inputDto.IID).FirstOrDefault();
                    if (inventory != null)
                    {
                        //添加当前的盘点单行项
                        List<ConQuant> conQuantList = _conQuantRepository.GetByCID(null, inventory.WAREID, inventory.STID, inventory.SLID).ToList();
                        inventory.STATUS = (int)InventoryStatus.盘点中;
                        inventory.TOTAL = conQuantList.Count;
                        inventory.RESULTCOUNT = 0;
                        _unitOfWork.RegisterDirty(inventory);

                        foreach (ConQuant conQuant in conQuantList)
                        {
                            ConInventoryResult result = new ConInventoryResult
                            {
                                IID = inputDto.IID,
                                CID = conQuant.CID,
                                WAREID = conQuant.WAREID,
                                STID = conQuant.STID,
                                SLID = conQuant.SLID,
                                RESULT = 0,
                                TOTAL = conQuant.QUANTITY,
                                CREATEDATE = DateTime.Now,
                                CREATEUSER = inputDto.UserId,
                                MODIFYDATE = DateTime.Now,
                                MODIFYUSER = inputDto.UserId
                            };
                            _unitOfWork.RegisterNew(result);

                            //更新盘点的物品状态为锁定
                            var conq = _conQuantRepository.GetQuants(inputDto.WAREID, conQuant.CID).FirstOrDefault();
                            if (conq != null)
                            {
                                conq.ISLOCKED = 1;
                                _unitOfWork.RegisterDirty(conq);
                            }
                        }

                    }
                    _unitOfWork.Commit();
                    RInfo.IsSuccess = true;
                    RInfo.ErrorInfo = sb.ToString();
                    return RInfo;
                }
                catch (Exception ex)
                {
                    _unitOfWork.Rollback();
                    sb.Append(ex.Message);
                    RInfo.IsSuccess = false;
                    RInfo.ErrorInfo = sb.ToString();
                    return RInfo;
                }
            }
        }
        #endregion
    }
}
