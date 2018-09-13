using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using AutoMapper;
using SMOWMS.CommLib;
using SMOWMS.Domain.Entity;
using SMOWMS.Domain.IRepository;
using SMOWMS.DTOs.Enum;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.DTOs.OutputDTO;
using SMOWMS.Infrastructure;
using SMOWMS.Application.IServices;

namespace SMOWMS.Application.Services
{
    /// <summary>
    /// 主数据的服务实现
    /// </summary>
    public class SettingService : ISettingService
    {
        /// <summary>
        /// 工作单元的接口
        /// </summary>
        private IUnitOfWork _unitOfWork;

        /// <summary>
        /// 资产信息的查询接口
        /// </summary>
        private IAssetsRepository _AssetsRepository;

        /// <summary>
        /// 数据库上下文
        /// </summary>
        private SMOWMSDbContext SMOWMSDbContext;

        /// <summary>
        /// 资产分类查询接口
        /// </summary>
        private IAssetsTypeRepository _assetsTypeRepository;

        /// <summary>
        /// 资产模板查询接口
        /// </summary>
        private IAssTemplateRepository _assTemplateRepository;

        /// <summary>
        /// 库位查询接口
        /// </summary>
        private IWHStorageLocationRepository _whStorageLocationRepository;
        /// <summary>
        /// 主数据服务实现的构造函数
        /// </summary>
        public SettingService(IUnitOfWork unitOfWork,
            IAssetsRepository AssetsRepository,
            IAssetsTypeRepository assetsTypeRepository,
            IAssTemplateRepository assTemplateRepository,
            IWHStorageLocationRepository whStorageLocationRepository,
            IDbContext dbContext)
        {
            _unitOfWork = unitOfWork;
            _AssetsRepository = AssetsRepository;
            _assetsTypeRepository = assetsTypeRepository;
            _assTemplateRepository = assTemplateRepository;
            _whStorageLocationRepository = whStorageLocationRepository;
            SMOWMSDbContext = (SMOWMSDbContext)dbContext;
        }

        #region 查询

        /// <summary>
        /// 根据资产编号返回资产信息
        /// </summary>
        /// <param name="ID">资产编号</param>
        /// <returns></returns>
        public AssetsOutputDto GetAssetsByID(string ID)
        {
            var dto = from assetse in SMOWMSDbContext.Assetss
                      from user in SMOWMSDbContext.coreUsers
                      join type in SMOWMSDbContext.AssetsTypes on assetse.TYPEID equals type.TYPEID
                from location in SMOWMSDbContext.WHStorageLocations
                from storageType in SMOWMSDbContext.WHStorageTypes
                from wareHouse in SMOWMSDbContext.WareHouses
                      where assetse.ASSID == ID && user.USER_ID == location.MANAGER&& wareHouse.WAREID == assetse.WAREID && storageType.WAREID == assetse.WAREID && storageType.STID == assetse.STID && location.WAREID == assetse.WAREID && location.STID == assetse.STID && location.SLID == assetse.SLID
                      select new AssetsOutputDto
                      {
                          AssId = assetse.ASSID,
                          BuyDate = assetse.BUYDATE,
                          ExpiryDate = assetse.EXPIRYDATE,
                          Image = assetse.IMAGE,
                          STID = assetse.STID,
                          SLID = assetse.SLID,
                          WAREID = assetse.WAREID,
                          SLName = wareHouse.NAME + "/" + storageType.NAME + "/" + location.NAME,
                          Name = assetse.NAME,
                          Note = assetse.NOTE,
                          Place = assetse.PLACE,
                          Price = assetse.PRICE,
                          SN = assetse.SN,
                          Specification = assetse.SPECIFICATION,
                          TypeId = assetse.TYPEID,
                          TypeName = type.NAME,
                          Vendor = assetse.VENDOR,
                          Unit = assetse.UNIT,
                          ATID = assetse.TEMPLATEID
                      };
            var assdto = dto.AsNoTracking().FirstOrDefault();
            return assdto;
        }

        /// <summary>
        /// 得到所有的固定资产
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllAss(string wareId)
        {
            var list = _AssetsRepository.GetAll().Where(a=>a.ISINWAREHOUSE==1);
            if (!String.IsNullOrEmpty(wareId))
            {
                list = list.Where(a=>a.WAREID==wareId);
            }
            list = list.OrderByDescending(a => a.CREATEDATE);
            var result = from assetse in list
                         from location in SMOWMSDbContext.WHStorageLocations
                         from storageType in SMOWMSDbContext.WHStorageTypes
                         from wareHouse in SMOWMSDbContext.WareHouses
                         join type in SMOWMSDbContext.AssetsTypes on assetse.TYPEID equals type.TYPEID
                         where wareHouse.WAREID==assetse.WAREID&&storageType.WAREID==assetse.WAREID&&storageType.STID==assetse.STID&&location.WAREID==assetse.WAREID&&location.STID==assetse.STID&&location.SLID==assetse.SLID
                         select new
                         {
                             ASSID = assetse.ASSID,
                             Image = assetse.IMAGE,
                             SLName =wareHouse.NAME+"/"+storageType.NAME+"/"+ location.NAME,
                             Name = assetse.NAME,
                             Price = assetse.PRICE,
                             SN = assetse.SN,
                             TypeName = type.NAME,
                             Specification = assetse.SPECIFICATION
                         };
            return LINQToDataTable.ToDataTable(result);
        }


        /// <summary>
        /// 查询处理记录
        /// </summary>
        /// <param name="ASSID">资产编号</param>
        /// <param name="CID">耗材编号</param>
        /// <returns></returns>
        public DataTable GetRecords(string ASSID, string CID)
        {
            if (!string.IsNullOrEmpty(ASSID))
            {
                var result = from processRecord in SMOWMSDbContext.AssProcessRecords
                             join assetse in SMOWMSDbContext.Assetss on processRecord.ASSID equals assetse.ASSID
                             join user in SMOWMSDbContext.coreUsers on processRecord.HANDLEMAN equals user.USER_ID
                             where processRecord.ASSID == ASSID
                             select new
                             {
                                 PrId = processRecord.PRID,
                                 ProcessMode = processRecord.PROCESSMODE,
                                 ProcessContent = processRecord.PROCESSCONTENT,
                                 AssId = processRecord.ASSID,
                                 HandleDate = processRecord.HANDLEDATE,
                                 ProcessModeName = "",
                                 HandleMan = user.USER_NAME,
                                 SN = assetse.SN
                             };
                DataTable tempTable = LINQToDataTable.ToDataTable(result);
                foreach (DataRow row in tempTable.Rows)
                {
                    row["ProcessModeName"] = Enum.GetName(typeof(PROCESSMODE), int.Parse(row["ProcessMode"].ToString()));
                }
                return tempTable;
            }
            else
            {
                var result = from processRecord in SMOWMSDbContext.AssProcessRecords
                             join comConsumablese in SMOWMSDbContext.Consumableses on processRecord.CID equals comConsumablese.CID
                             join user in SMOWMSDbContext.coreUsers on processRecord.HANDLEMAN equals user.USER_ID
                             where processRecord.CID == CID
                             select new
                             {
                                 PrId = processRecord.PRID,
                                 ProcessMode = processRecord.PROCESSMODE,
                                 ProcessContent = processRecord.PROCESSCONTENT,
                                 CId = processRecord.CID,
                                 HandleDate = processRecord.HANDLEDATE,
                                 ProcessModeName = "",
                                 HandleMan = user.USER_NAME
                             };
                DataTable tempTable = LINQToDataTable.ToDataTable(result);
                foreach (DataRow row in tempTable.Rows)
                {
                    row["ProcessModeName"] = Enum.GetName(typeof(PROCESSMODE), int.Parse(row["ProcessMode"].ToString()));
                }
                return tempTable;
            }
        }

        /// <summary>
        /// 查询即将失效的资产
        /// </summary>
        /// <param name="days">距离现在的天数</param>
        /// <returns></returns>
        public DataTable GetImminentAssets(int days)
        {
            DateTime targetDateTime = DateTime.Now.Date.AddDays(days);
            DateTime Now = DateTime.Now.Date;
            var result = from ass in SMOWMSDbContext.Assetss
                         where ass.EXPIRYDATE >= Now && ass.EXPIRYDATE <= targetDateTime
                         select new
                         {

                         };

            return LINQToDataTable.ToDataTable(_AssetsRepository.GetImminentAssets(days));
        }

        /// <summary>
        /// 查询低于安全库存的资产(待修改)
        /// </summary>
        /// <returns></returns>
        public DataTable GetLackOfStockAss()
        {
            throw new System.NotImplementedException();
        }


        /// <summary>
        /// 根据SN或者名称查询资产
        /// </summary>
        /// <param name="SNOrName">SN或者名称</param>
        /// <param name="Type">一级资产编号</param>
        /// <returns></returns>
        public DataTable QueryAssets(string SNOrName, string Type)
        {
            List<String> Types = new List<string>();
            if (String.IsNullOrEmpty(Type) == false)
            {
                Types.Add(Type);
                List<AssetsType> listType = _assetsTypeRepository.GetByParentTypeID(Type).AsNoTracking().ToList();
                foreach (AssetsType Row in listType)
                {
                    List<AssetsType> LastlistType = _assetsTypeRepository.GetByParentTypeID(Row.TYPEID).AsNoTracking().ToList();
                    foreach (AssetsType LastRow in LastlistType)
                    {
                        Types.Add(LastRow.TYPEID);
                    }
                    Types.Add(Row.TYPEID);
                }
            }

            var list = _AssetsRepository.QueryAssets(SNOrName, Types).Where(a => a.ISINWAREHOUSE == 1).AsNoTracking();
            var result = from assetse in list
                from location in SMOWMSDbContext.WHStorageLocations
                from storageType in SMOWMSDbContext.WHStorageTypes
                from wareHouse in SMOWMSDbContext.WareHouses
                join type in SMOWMSDbContext.AssetsTypes on assetse.TYPEID equals type.TYPEID
                where wareHouse.WAREID == assetse.WAREID && storageType.WAREID == assetse.WAREID && storageType.STID == assetse.STID && location.WAREID == assetse.WAREID && location.STID == assetse.STID && location.SLID == assetse.SLID
                select new
                {
                    ASSID = assetse.ASSID,
                    Image = assetse.IMAGE,
                    SLName = wareHouse.NAME + "/" + storageType.NAME + "/" + location.NAME,
                    Name = assetse.NAME,
                    Price = assetse.PRICE,
                    SN = assetse.SN,
                    TypeName = type.NAME,
                    Specification = assetse.SPECIFICATION
                };
            return LINQToDataTable.ToDataTable(result);
        }

        /// <summary>
        /// 根据SN得到资产信息
        /// </summary>
        /// <param name="SN">SN编号</param>
        /// <returns></returns>
        public DataTable GetAssetsBySN(string SN)
        {
            var result = _AssetsRepository.GetAssetsBySN(SN).AsNoTracking();
            return LINQToDataTable.ToDataTable(result);
        }

        /// <summary>
        /// 得到所有的Sn
        /// </summary>
        /// <returns></returns>
        public List<string> GetAllSns()
        {
            var lists = new List<string>();
            lists = _AssetsRepository.GetAll().Select(a => a.SN).ToList();
            return lists;
        }

        /// <summary>
        /// 根据SN列表得到资产数据
        /// </summary>
        /// <param name="Sns">资产列表</param>
        /// <returns></returns>
        public DataTable GetBySnList(List<string> Sns)
        {
            if (Sns.Count > 0)
            {
                var list = _AssetsRepository.GetAll().Where(a => Sns.Contains(a.SN));
                var result = from assetse in list
                             join location in SMOWMSDbContext.WHStorageLocations on assetse.SLID equals location.SLID
                             join type in SMOWMSDbContext.AssetsTypes on assetse.TYPEID equals type.TYPEID
                             select new
                             {
                                 ASSID = assetse.ASSID,
                                 Image = assetse.IMAGE,
                                 LocationName = location.NAME,
                                 Name = assetse.NAME,
                                 Price = assetse.PRICE,
                                 SN = assetse.SN,
                                 TypeName = type.NAME,
                                 Specification = assetse.SPECIFICATION,
                                 RESULTNAME = ""
                             };
                return LINQToDataTable.ToDataTable(result);
            }
            else
            {
                return new DataTable();
            }
        }

        /// <summary>
        /// 得到所有资产模板
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllTemplate()
        {
            var all= _assTemplateRepository.GetAll().AsNoTracking();
            return LINQToDataTable.ToDataTable(all);
        }

        /// <summary>
        /// 根据模板编号得到信息
        /// </summary>
        /// <param name="templateId">模板编号</param>
        /// <returns></returns>
        public AssTemplate GetAtbyId(string templateId)
        {
            return _assTemplateRepository.GetById(templateId).AsNoTracking().FirstOrDefault();
        }

        /// <summary>
        /// 得到所有资产模板(资产模板选择时用到)
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllAssTemps()
        {
            var result = from assTemplate in SMOWMSDbContext.AssTemplates
                select new ATChooseOutputDto()
                {
                    TEMPLATEID = assTemplate.TEMPLATEID,
                    IMAGE = assTemplate.IMAGE,
                    IsChecked = false,
                    NAME = assTemplate.NAME,
                    PRICE = 0,
                    QUANT = 0
//                    TPRICE = assTemplate.PRICE.Value
                };
            return LINQToDataTable.ToDataTable(result);
        }

        /// <summary>
        /// 根据资产模板编号或者名称查询模板
        /// </summary>
        /// <param name="TIdorName">资产模板编号或者名称</param>
        /// <returns></returns>
        public DataTable QueryAssTemplate(string TIdorName)
        {
            var result = _assTemplateRepository.GetAll();
            if (!string.IsNullOrEmpty(TIdorName))
            {
                result = result.Where(a => a.TEMPLATEID.Contains(TIdorName) || a.NAME.Contains(TIdorName));
            }
            var table = from assTemplate in result
                select new ATChooseOutputDto()
                {
                    TEMPLATEID = assTemplate.TEMPLATEID,
                    IMAGE = assTemplate.IMAGE,
                    IsChecked = false,
                    NAME = assTemplate.NAME,
                    PRICE = 0,
                    QUANT = 0
//                    TPRICE = assTemplate.PRICE.Value
                };
            return LINQToDataTable.ToDataTable(table);
        }

        /// <summary>
        /// 查询SN是否已存在
        /// </summary>
        /// <param name="SN">序列号</param>
        /// <returns></returns>
        public bool SNIsExists(string SN)
        {
            return _AssetsRepository.SNIsExists(SN);
        }

        /// <summary>
        /// 查询SN是否已存在
        /// </summary>
        /// <param name="SN">序列号</param>
        /// <param name="TemplateIds">模板编号列表</param>
        /// <returns></returns>
        public bool SOSNIsExists(string SN, List<string> TemplateIds)
        {
            var result = _AssetsRepository.GetAll().Where(a=>TemplateIds.Contains(a.TEMPLATEID)&&a.ISINWAREHOUSE==1);
            if (!string.IsNullOrEmpty(SN))
            {
                return result.Any(a => a.SN == SN);
            }
            return false;
        }

        /// <summary>
        /// 根据序列号得到资产
        /// </summary>
        /// <param name="SN">序列号</param>
        /// <returns></returns>
        public Assets GetBySN(string SN)
        {
            var result = _AssetsRepository.GetAll().Where(a => a.ISINWAREHOUSE == 1 && a.SN == SN).AsNoTracking()
                .FirstOrDefault();
            return result;
        }

        /// <summary>
        /// 根据模板编号或者名称查询资产模板
        /// </summary>
        /// <param name="TemplateIdOrName">模板编号或者名称</param>
        /// <param name="Type">一级资产编号</param>
        /// <returns></returns>
        public DataTable QueryAssTemplates(string TemplateIdOrName, string Type)
        {
            List<String> Types = new List<string>();
            if (!String.IsNullOrEmpty(Type))
            {
                Types.Add(Type);
                List<AssetsType> listType = _assetsTypeRepository.GetByParentTypeID(Type).AsNoTracking().ToList();
                foreach (AssetsType Row in listType)
                {
                    List<AssetsType> LastlistType = _assetsTypeRepository.GetByParentTypeID(Row.TYPEID).AsNoTracking().ToList();
                    foreach (AssetsType LastRow in LastlistType)
                    {
                        Types.Add(LastRow.TYPEID);
                    }
                    Types.Add(Row.TYPEID);
                }
            }

            var result = _assTemplateRepository.QueryAssTemplates(TemplateIdOrName, Types).AsNoTracking();
            return LINQToDataTable.ToDataTable(result);
        }



        #endregion

        #region 操作
        /// <summary>
        /// 新增资产
        /// </summary>
        /// <param name="entity">资产信息</param>
        /// <returns></returns>
        public ReturnInfo AddAssets(AssetsInputDto entity)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            if (string.IsNullOrEmpty(entity.ASSID))
            {
                string MaxId = _AssetsRepository.GetMaxID();
                string AssId = Helper.GenerateID("ASS", MaxId);
                //产生资产编号
                entity.ASSID = AssId;
            }
            string ValidateInfo = Helper.ValidateAssets(entity).ToString();
            sb.Append(ValidateInfo);
            if (sb.Length == 0)
            {
                try
                {
                    Assets assets = Mapper.Map<AssetsInputDto, Assets>(entity);
                    assets.STATUS = (int)STATUS.闲置;
                    assets.CREATEDATE = DateTime.Now;
                    assets.MODIFYDATE = DateTime.Now;
                    _unitOfWork.RegisterNew(assets);
                    var pr = new AssProcessRecord
                    {
                        ASSID = entity.ASSID,
                        CREATEDATE = DateTime.Now,
                        CREATEUSER = entity.CREATEUSER,
                        HANDLEDATE = DateTime.Now,
                        HANDLEMAN = entity.CREATEUSER,
                        MODIFYDATE = DateTime.Now,
                        MODIFYUSER = entity.MODIFYUSER,
                        PROCESSCONTENT = entity.CREATEUSER + "入库了" + entity.ASSID + ",数量为1",
                        PROCESSMODE = (int)PROCESSMODE.入库,
                        QUANTITY = 1
                    };
                    _unitOfWork.RegisterNew(pr);

                    bool result = _unitOfWork.Commit();
                    RInfo.IsSuccess = result;
                    RInfo.ErrorInfo = entity.ASSID;
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
            else
            {
                RInfo.IsSuccess = false;
                RInfo.ErrorInfo = sb.ToString();
                return RInfo;
            }
        }

        /// <summary>
        /// 更新资产信息
        /// </summary>
        /// <param name="entity">资产信息</param>
        /// <returns></returns>
        public ReturnInfo UpdateAssets(AssetsInputDto entity)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            //产生资产编号
            string ValidateInfo = Helper.BasicValidate(entity).ToString();
            sb.Append(ValidateInfo);
            if (sb.Length == 0)
            {
                try
                {
                    Assets assets = _AssetsRepository.GetByID(entity.ASSID).FirstOrDefault();
                    if (assets != null)
                    {
                        assets.BUYDATE = entity.BUYDATE;
                        assets.CREATEUSER = entity.CREATEUSER;
                        assets.EXPIRYDATE = entity.EXPIRYDATE;
                        assets.IMAGE = entity.IMAGE;
                        assets.SLID = entity.SLID;
                        assets.MODIFYUSER = entity.MODIFYUSER;
                        assets.NAME = entity.NAME;
                        assets.NOTE = entity.NOTE;
                        assets.PLACE = entity.PLACE;
                        assets.PRICE = entity.PRICE;
                        assets.SN = entity.SN;
                        assets.SPECIFICATION = entity.SPECIFICATION;
                        assets.TYPEID = entity.TYPEID;
                        assets.UNIT = entity.UNIT;
                        assets.VENDOR = entity.VENDOR;
                        assets.MODIFYDATE = DateTime.Now;
                        assets.CREATEDATE = assets.CREATEDATE;
                        _unitOfWork.RegisterDirty(assets);
                    }

                    var pr = new AssProcessRecord
                    {
                        ASSID = entity.ASSID,
                        CREATEDATE = DateTime.Now,
                        CREATEUSER = entity.CREATEUSER,
                        HANDLEDATE = DateTime.Now,
                        HANDLEMAN = entity.CREATEUSER,
                        MODIFYDATE = DateTime.Now,
                        MODIFYUSER = entity.MODIFYUSER,
                        PROCESSCONTENT = entity.CREATEUSER + "修改了" + entity.ASSID
                    };
                    ;
                    pr.PROCESSMODE = (int)PROCESSMODE.修改内容;
                    _unitOfWork.RegisterNew(pr);

                    bool result = _unitOfWork.Commit();
                    RInfo.IsSuccess = result;
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
            else
            {
                RInfo.IsSuccess = false;
                RInfo.ErrorInfo = sb.ToString();
                return RInfo;
            }
        }

        /// <summary>
        /// 添加资产模板
        /// </summary>
        /// <param name="inputDto">资产模板信息</param>
        /// <returns></returns>
        public ReturnInfo AddAssTemplate(AssTemplateInputDto inputDto)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            if (string.IsNullOrEmpty(inputDto.TEMPLATEID))
            {
                string MaxId = _assTemplateRepository.GetMaxId();
                string atId = Helper.GenerateIDEx("AT", MaxId);
                //产生资产编号
                inputDto.TEMPLATEID = atId;
            }
            string ValidateInfo = Helper.BasicValidate(inputDto).ToString();
            sb.Append(ValidateInfo);
            if (sb.Length == 0)
            {
                try
                {
                    AssTemplate assets = Mapper.Map<AssTemplateInputDto, AssTemplate>(inputDto);
                    _unitOfWork.RegisterNew(assets);

                    bool result = _unitOfWork.Commit();
                    RInfo.IsSuccess = result;
                    RInfo.ErrorInfo = inputDto.TEMPLATEID;
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
            else
            {
                RInfo.IsSuccess = false;
                RInfo.ErrorInfo = sb.ToString();
                return RInfo;
            }
        }

        /// <summary>
        /// 修改资产模板
        /// </summary>
        /// <param name="inputDto">资产模板信息</param>
        /// <returns></returns>
        public ReturnInfo UpdateAssTemplate(AssTemplateInputDto inputDto)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            //产生资产编号
            string ValidateInfo = Helper.BasicValidate(inputDto).ToString();
            sb.Append(ValidateInfo);
            if (sb.Length == 0)
            {
                try
                {
                    AssTemplate assets = _assTemplateRepository.GetById(inputDto.TEMPLATEID).FirstOrDefault();
                    if (assets != null)
                    {
                        assets.IMAGE = inputDto.IMAGE;
                        assets.NAME = inputDto.NAME;
                        assets.NOTE = inputDto.NOTE;
                        assets.PRICE = inputDto.PRICE;
                        assets.SPECIFICATION = inputDto.SPECIFICATION;
                        assets.TYPEID = inputDto.TYPEID;
                        assets.UNIT = inputDto.UNIT;
                        assets.VENDOR = inputDto.VENDOR;
                        _unitOfWork.RegisterDirty(assets);
                    }

                    bool result = _unitOfWork.Commit();
                    RInfo.IsSuccess = result;
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
            else
            {
                RInfo.IsSuccess = false;
                RInfo.ErrorInfo = sb.ToString();
                return RInfo;
            }
        }

        /// <summary>
        /// 删除资产模板
        /// </summary>
        /// <param name="templateId">模板编号</param>
        /// <returns></returns>
        public ReturnInfo DeleteAssTemplate(string templateId)
        {
            ReturnInfo rInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            var assTemplate = _assTemplateRepository.GetById(templateId).FirstOrDefault();
            if (assTemplate == null)
            {
                sb.Append("未找到该编号的资产模板.");
                rInfo.IsSuccess = false;
                rInfo.ErrorInfo = sb.ToString();
                return rInfo;
            }
            else
            {
                //如果在采购单或者销售单行项中使用过,则不能删除
                var count1 = from assPurchaseOrderRow in SMOWMSDbContext.AssPurchaseOrderRows
                    where assPurchaseOrderRow.TEMPLATEID == templateId
                    select assPurchaseOrderRow.POID;
                var count2 = from assSalesOrderRow in SMOWMSDbContext.AssSalesOrderRows
                    where assSalesOrderRow.TEMPLATEID == templateId
                    select assSalesOrderRow.SOID;
                if (count1.Count() + count2.Count() > 0)
                {
                    sb.Append("在采购单或者销售单行项中已使用过,故不能删除!");
                    rInfo.IsSuccess = false;
                    rInfo.ErrorInfo = sb.ToString();
                    return rInfo;
                }
                else
                {
                    //可以删除
                    try
                    {
                        _unitOfWork.RegisterDeleted(assTemplate);
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
        }

        /// <summary>
        /// 资产移库
        /// </summary>
        /// <param name="inputDto">移库相关信息</param>
        /// <returns></returns>
        public ReturnInfo TransferAss(AssTransferInputDto inputDto)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            string ValidateInfo = Helper.BasicValidate(inputDto).ToString();
            sb.Append(ValidateInfo);
            if (sb.Length == 0)
            {
                try
                {
                    WHStorageLocation storageLocation = _whStorageLocationRepository.GetById(inputDto.WAREID, inputDto.STID, inputDto.SLID).AsNoTracking()
                        .FirstOrDefault();
                    if (storageLocation != null)
                    {
                        //取出SN在范围内的所有资产

                        var assets = _AssetsRepository.GetAll().Where(a => inputDto.SnList.Contains(a.SN) && a.ISINWAREHOUSE == 1);

                        //遍历,修改库位

                        foreach (var asset in assets)
                        {
                            //修改库位
                            asset.WAREID = inputDto.WAREID;
                            asset.STID = inputDto.STID;
                            asset.SLID = inputDto.SLID;
                            _unitOfWork.RegisterDirty(asset);


                            var pr = new AssProcessRecord
                            {
                                ASSID = asset.ASSID,
                                CREATEDATE = DateTime.Now,
                                CREATEUSER = inputDto.UserId,
                                HANDLEDATE = DateTime.Now,
                                HANDLEMAN = inputDto.UserId,
                                MODIFYDATE = DateTime.Now,
                                MODIFYUSER = inputDto.UserId,
                                PROCESSCONTENT = inputDto.UserId + "修改库位为" + inputDto.WAREID + "/" + inputDto.STID + "/" + inputDto.SLID,
                                PROCESSMODE = (int)PROCESSMODE.调拨,
                                QUANTITY = 1
                            };
                            _unitOfWork.RegisterNew(pr);
                        }


                        bool result = _unitOfWork.Commit();
                        RInfo.IsSuccess = result;
                        RInfo.ErrorInfo = "";
                        return RInfo;
                    }
                    else
                    {
                        throw new Exception("该库位不存在！");
                    }
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
            else
            {
                RInfo.IsSuccess = false;
                RInfo.ErrorInfo = sb.ToString();
                return RInfo;
            }
        }
        #endregion





    }
}