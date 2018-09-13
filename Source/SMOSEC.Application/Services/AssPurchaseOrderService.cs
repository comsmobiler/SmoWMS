using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using AutoMapper;
using SMOWMS.Application.IServices;
using SMOWMS.CommLib;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.DTOs.OutputDTO;
using SMOWMS.Infrastructure;
using SMOWMS.Domain.IRepository;
using SMOWMS.DTOs.Enum;

namespace SMOWMS.Application.Services
{
    /// <summary>
    /// 资产销售单服务实现
    /// </summary>
    public class AssPurchaseOrderService : IAssPurchaseOrderService
    {
        /// <summary>
        /// 工作单元的接口
        /// </summary>
        private IUnitOfWork _unitOfWork;

        /// <summary>
        /// 资产信息的查询接口
        /// </summary>
        private IAssetsRepository _assetsRepository;

        /// <summary>
        /// 数据库上下文
        /// </summary>
        private SMOWMSDbContext SMOWMSDbContext;

        /// <summary>
        /// 采购单查询接口
        /// </summary>
        private IAssPurchaseOrderRepository _assPurchaseOrderRepository;

        /// <summary>
        /// 采购单行项查询接口
        /// </summary>
        private IAssPORowRepository _assPoRowRepository;

        /// <summary>
        /// 资产模板查询接口
        /// </summary>
        private IAssTemplateRepository _assTemplateRepository;

        /// <summary>
        /// 采购单服务实现的构造函数
        /// </summary>
        public AssPurchaseOrderService(IUnitOfWork unitOfWork,
            IAssetsRepository assetsRepository,
            IAssPurchaseOrderRepository assPurchaseOrderRepository,
            IAssPORowRepository assPoRowRepository,
            IAssTemplateRepository assTemplateRepository,
            IDbContext dbContext)
        {
            _unitOfWork = unitOfWork;
            _assetsRepository = assetsRepository;
            _assPurchaseOrderRepository = assPurchaseOrderRepository;
            _assPoRowRepository = assPoRowRepository;
            _assTemplateRepository = assTemplateRepository;
            SMOWMSDbContext = (SMOWMSDbContext)dbContext;
        }

        #region 查询
        /// <summary>
        /// 根据采购单号得到采购单
        /// </summary>
        /// <param name="POID">采购单号</param>
        /// <returns></returns>
        public AssPurchaseOrderOutputDto GetById(string POID)
        {
            var result = from order in SMOWMSDbContext.AssPurchaseOrders
                join user in SMOWMSDbContext.coreUsers on order.PURCHASER equals user.USER_ID
                join vendor in SMOWMSDbContext.Vendors on order.VID equals vendor.VID
                where order.POID == POID
                select new AssPurchaseOrderOutputDto()
                {
                    POID = order.POID,
                    NAME = order.NAME,
                    PURCHASER = order.PURCHASER,
                    PURCHASERNAME = user.USER_NAME,
                    REALID = order.REALID,
                    STATUS = order.STATUS,
                    VID = order.VID,
                    VNAME = vendor.NAME
                };

            return result.AsNoTracking().FirstOrDefault();
        }

        /// <summary>
        /// 得到用户的采购单列表
        /// </summary>
        /// <param name="UserId">用户编号</param>
        /// <returns></returns>
        public DataTable GetOrders(string UserId)
        {
            var area = _assPurchaseOrderRepository.GetAll();
          
            if (!string.IsNullOrEmpty(UserId))
            {
                area = area.Where(a => a.PURCHASER == UserId);
            }
            var list = from assPurchaseOrder in area
                join user in SMOWMSDbContext.coreUsers on assPurchaseOrder.PURCHASER equals user.USER_ID
                orderby assPurchaseOrder.CREATEDATE descending
                select new AssPOListOutputDto()
                {                    
                    REALID = assPurchaseOrder.REALID,
                    POID = assPurchaseOrder.POID,
                    NAME = assPurchaseOrder.NAME,
                    PURCHASER = assPurchaseOrder.PURCHASER,
                    PURCHASERNAME = user.USER_NAME,
                    STATUS = assPurchaseOrder.STATUS,
                    STATUSNAME = "",
                    CREATEDATE = assPurchaseOrder.CREATEDATE,
                    Time = ""
                };
            var temTable = LINQToDataTable.ToDataTable(list);
            foreach (DataRow row in temTable.Rows)
            {
                AssPurchaseOrderRow assPurchaseOrderRow= _assPoRowRepository.GetByPOID(row["POID"].ToString()).FirstOrDefault();
                AssTemplate assTemplate=_assTemplateRepository.GetById(assPurchaseOrderRow.TEMPLATEID).FirstOrDefault();
                row["Image"] = assTemplate.IMAGE;

                int status = int.Parse(row["STATUS"].ToString());
                row["STATUSNAME"] = Enum.GetName(typeof(PurchaseOrderStatus), status);
                row["Time"] = DateTime.Parse(row["CREATEDATE"].ToString()).ToShortDateString();
            }
            return temTable;
        }

        /// <summary>
        /// 根据采购单编号得到采购单行项
        /// </summary>
        /// <param name="POID">采购单编号</param>
        /// <returns></returns>
        public DataTable GetRows(string POID)
        {
            var results = from purchaseOrderRow in SMOWMSDbContext.AssPurchaseOrderRows
                join template in SMOWMSDbContext.AssTemplates on purchaseOrderRow.TEMPLATEID equals template.TEMPLATEID 
                where purchaseOrderRow.POID == POID
                select new AssPORowOutputDto()
                {
                    POID = purchaseOrderRow.POID,
                    IMAGE = template.IMAGE,
                    NAME = template.NAME,
                    POROWID = purchaseOrderRow.POROWID,
                    QUANTPURCHASED = purchaseOrderRow.QUANTPURCHASED,
                    QUANTRETREATED = purchaseOrderRow.QUANTRETREATED,
                    QUANTSTORED = purchaseOrderRow.QUANTSTORED,
                    REALPRICE = purchaseOrderRow.REALPRICE,
                    TEMPLATEID = purchaseOrderRow.TEMPLATEID,
                    STATUS = purchaseOrderRow.STATUS,
                    STATUSNAME = ""                    
                };
            DataTable tempTable = LINQToDataTable.ToDataTable(results);

            foreach (DataRow row in tempTable.Rows)
            {
                row["STATUSNAME"] = Enum.GetName(typeof(PurchaseOrderStatus), int.Parse(row["STATUS"].ToString()));
            }
            return tempTable;
        }

        /// <summary>
        /// 得到采购单行项中的资产模板
        /// </summary>
        /// <param name="POID">采购单编号</param>
        /// <returns></returns>
        public List<AssTempOutputDto> GetTemplateList(string POID)
        {
            var result = from purchaseOrderRow in SMOWMSDbContext.AssPurchaseOrderRows
                join assTemplate in SMOWMSDbContext.AssTemplates on purchaseOrderRow.TEMPLATEID equals assTemplate
                    .TEMPLATEID
                where purchaseOrderRow.POID == POID &&purchaseOrderRow.STATUS!=2
                select new AssTempOutputDto()
                {
                    TEMPLATEID = assTemplate.TEMPLATEID,
                    NAME = assTemplate.NAME
                };
            return result.ToList();
        }

        /// <summary>
        /// 根据采购单编号，得到采购单行项数据
        /// </summary>
        /// <param name="POID">采购单编号</param>
        /// <returns></returns>
        public List<AssPORowOutputDto> GetPORows(string POID)
        {
            var results = from purchaseOrderRow in SMOWMSDbContext.AssPurchaseOrderRows
                join template in SMOWMSDbContext.AssTemplates on purchaseOrderRow.TEMPLATEID equals template.TEMPLATEID
                where purchaseOrderRow.POID == POID
                select new AssPORowOutputDto()
                {
                    POID = purchaseOrderRow.POID,
                    IMAGE = template.IMAGE,
                    NAME = template.NAME,
                    POROWID = purchaseOrderRow.POROWID,
                    TPRICE = template.PRICE.Value,
                    PRICE = purchaseOrderRow.REALPRICE,
                    QUANT = purchaseOrderRow.QUANTPURCHASED,
                    QUANTPURCHASED = purchaseOrderRow.QUANTPURCHASED,
                    QUANTRETREATED = purchaseOrderRow.QUANTRETREATED,
                    QUANTSTORED = purchaseOrderRow.QUANTSTORED,
                    REALPRICE = purchaseOrderRow.REALPRICE,
                    TEMPLATEID = purchaseOrderRow.TEMPLATEID,
                    STATUS = purchaseOrderRow.STATUS,
                    STATUSNAME = ""
                };
            
            return results.ToList();
        }

        /// <summary>
        /// 根据采购单编号，得到入库的序列号
        /// </summary>
        /// <param name="POID">采购单编号</param>
        /// <returns></returns>
        public List<string> GetPoSnList(string POID)
        {
            var result = from instorage in SMOWMSDbContext.AssPurchaseOrderInstorages
                join assetse in SMOWMSDbContext.Assetss on instorage.SN equals assetse.SN
                where instorage.POID == POID&&assetse.ISINWAREHOUSE==1
                select assetse.SN;
            return result.ToList();
        }

        /// <summary>
        /// 查询序列号是否在采购单入库行项中
        /// </summary>
        /// <param name="POID">采购单编号</param>
        /// <param name="SN">序列号</param>
        /// <returns></returns>
        public bool SNIsOK(string POID,string SN)
        {
            List<string> snList = GetPoSnList(POID);
            if (snList.Count > 0)
            {
                if (snList.Contains(SN))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// 判断采购单编号是否存在
        /// </summary>
        /// <param name="POID">采购单编号</param>
        /// <returns></returns>
        public bool POIDIsExist(string POID)
        {
            return _assPurchaseOrderRepository.GetAll().Any(a => a.POID == POID);
        }

        #endregion

        #region 操作
        /// <summary>
        /// 添加采购单
        /// </summary>
        /// <param name="inputDto">采购单数据</param>
        /// <returns></returns>
        public ReturnInfo AddPurchaseOrder(AssPurchaseOrderInputDto inputDto)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            if (string.IsNullOrEmpty(inputDto.POID))
            {
                string MaxId = _assPurchaseOrderRepository.GetMaxId();
                string PoId = Helper.GenerateIDEx2("P", MaxId);
                //产生资产编号
                inputDto.POID = PoId;
            }
            string ValidateInfo = Helper.BasicValidate(inputDto).ToString();
            sb.Append(ValidateInfo);
            if (sb.Length == 0)
            {
                try
                {
                    AssPurchaseOrder purchaseOrder = Mapper.Map<AssPurchaseOrderInputDto, AssPurchaseOrder>(inputDto);
                    purchaseOrder.STATUS = (int)PurchaseOrderStatus.采购中;
                    purchaseOrder.CREATEDATE = DateTime.Now;
                    purchaseOrder.MODIFYDATE = DateTime.Now;
                    _unitOfWork.RegisterNew(purchaseOrder);
                    foreach (var inputDtoRow in inputDto.RowInputDtos)
                    {
                        AssPurchaseOrderRow row = new AssPurchaseOrderRow
                        {
                            QUANTPURCHASED = inputDtoRow.QUANT,
                            REALPRICE = inputDtoRow.PRICE,
                            TEMPLATEID = inputDtoRow.TEMPLATEID,
                            STATUS = (int)PurchaseOrderStatus.采购中,
                            CREATEUSER = inputDtoRow.CREATEUSER,
                            MODIFYUSER = inputDtoRow.MODIFYUSER,
                            CREATEDATE = DateTime.Now,
                            MODIFYDATE = DateTime.Now,
//                            Time = DateTime.Now,
                            POID = inputDto.POID
                        };
                        _unitOfWork.RegisterNew(row);
                    }
                    bool result = _unitOfWork.Commit();
                    RInfo.IsSuccess = result;
                    RInfo.ErrorInfo = inputDto.POID;
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
        /// 采购退货
        /// </summary>
        /// <param name="inputDto">采购退货相关信息</param>
        /// <returns></returns>
        public ReturnInfo ReturnAss(AssReturnInputDto inputDto)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            try
            {

                //先从Asset表得到属于这个POID的资产的全部SN,放入List<string>
                var allSn = from instorage in SMOWMSDbContext.AssPurchaseOrderInstorages
                    join assetse in SMOWMSDbContext.Assetss on instorage.SN equals assetse.SN
                    where assetse.ISINWAREHOUSE == 1 && instorage.POID == inputDto.POID
                    select instorage.SN;
                List<string> allList = allSn.ToList();
                //2个List<string>取交集，如果所传的SN都包括，则继续
                List<string> bothList = allList.Intersect(inputDto.sns).ToList();


                //取出SN在范围内的所有资产

                var assets = _assetsRepository.GetAll().Where(a => bothList.Contains(a.SN));

                //遍历,修改状态为已不在库

                foreach (var asset in assets)
                {
                    //修改状态为已不在库
                    asset.ISINWAREHOUSE = 0;
                    _unitOfWork.RegisterDirty(asset);
                    //添加退货关联表
                    AssPurchaseOrderReturn poReturn = new AssPurchaseOrderReturn
                    {
                        POID = inputDto.POID,
                        SN = asset.SN,
                        TEMPLATEID = asset.TEMPLATEID,
//                        Time = DateTime.Now
                    };
                    _unitOfWork.RegisterNew(poReturn);

                    var pr = new AssProcessRecord
                    {
                        ASSID = asset.ASSID,
                        CREATEDATE = DateTime.Now,
                        CREATEUSER = inputDto.UserId,
                        HANDLEDATE = DateTime.Now,
                        HANDLEMAN = inputDto.UserId,
                        MODIFYDATE = DateTime.Now,
                        MODIFYUSER = inputDto.UserId,
                        PROCESSCONTENT = inputDto.UserId + "采购退回了" + asset.ASSID + ",数量为1",
                        PROCESSMODE = (int) PROCESSMODE.出库,
                        QUANTITY = 1
                    };
                    _unitOfWork.RegisterNew(pr);
                }
                var countDictionary = _assetsRepository.GetCountBySnList(bothList);
                if (countDictionary != null)
                {
                    foreach (var templateId in countDictionary.Keys)
                    {
                        var asspoRow = _assPoRowRepository.GetByPOIDandTemplateID(inputDto.POID, templateId)
                            .FirstOrDefault();
                        if (asspoRow != null)
                        {
                            asspoRow.QUANTRETREATED = asspoRow.QUANTRETREATED + countDictionary[templateId];
                            _unitOfWork.RegisterDirty(asspoRow);
                        }
                    }
                }
            
                bool result = _unitOfWork.Commit();
                RInfo.IsSuccess = result;
                RInfo.ErrorInfo = "";
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

        /// <summary>
        /// 采购入库
        /// </summary>
        /// <param name="inputDto">采购入库相关信息</param>
        /// <returns></returns>
        public ReturnInfo InstorageAss(AssInStorageInputDto inputDto)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            string ValidateInfo = Helper.BasicValidate(inputDto).ToString();
            sb.Append(ValidateInfo);
            if (sb.Length == 0)
            {
                try
                {
                    //先确定数量是否超出
                    AssPurchaseOrderRow row = _assPoRowRepository
                        .GetByPOIDandTemplateID(inputDto.POID, inputDto.TEMPLATEID).FirstOrDefault();
                    if (row != null)
                    {
                        if (row.QUANTPURCHASED < row.QUANTSTORED + inputDto.SnList.Count)
                        {
                            RInfo.IsSuccess = false;
                            RInfo.ErrorInfo = "入库量超过采购量！";
                            return RInfo;
                        }
                        else
                        {
                            row.QUANTSTORED = row.QUANTSTORED + inputDto.SnList.Count;
                            var asspo = _assPurchaseOrderRepository.GetById(inputDto.POID).FirstOrDefault();
                            if (asspo != null)
                            {
                                asspo.STATUS = (int) PurchaseOrderStatus.入库中;
                                if (row.QUANTPURCHASED == row.QUANTSTORED)
                                {
                                    row.STATUS = (int)PurchaseOrderStatus.已完成;

                                    //判断是否需要将整个采购单状态改为"已完成"
                                    //得到采购单的行项数
                                    var count = _assPoRowRepository.GetByPOID(inputDto.POID).Count();
                                    //得到已完成的行项数
                                    var count2 = _assPoRowRepository.GetByPOID(inputDto.POID)
                                        .Count(a => a.STATUS == (int)PurchaseOrderStatus.已完成);
                                    if (count == count2+1)
                                    {
                                        //包括当前行项,所有行项均已完成，则更新整个采购单状态为"已完成"
                                        asspo.STATUS = (int)PurchaseOrderStatus.已完成;
                                        _unitOfWork.RegisterDirty(asspo);
                                    }
                                }
                                else
                                {
                                    row.STATUS = (int)PurchaseOrderStatus.入库中;
                                }
                            }
                            _unitOfWork.RegisterDirty(row);
                        }

                    }


                    AssTemplate assTemplate = _assTemplateRepository.GetById(inputDto.TEMPLATEID).AsNoTracking()
                        .FirstOrDefault();
                    if (assTemplate != null)
                    {
                        for (int i = 0; i < inputDto.SnList.Count; i++)
                        {
                            //资产入库
                            string MaxId = _assetsRepository.GetMaxID();
                            string ASSID = Helper.GenerateASSID("ASS", MaxId, i);
                            Assets assets = new Assets
                            {
                                STATUS = (int) STATUS.闲置,
                                ASSID = ASSID,
                                BUYDATE = DateTime.Now,
                                CREATEUSER = inputDto.UserId,
                                EXPIRYDATE = DateTime.Now.AddYears(1),
                                IMAGE = assTemplate.IMAGE,
                                ISINWAREHOUSE = 1,
                                ISLOCKED = 0,
                                MODIFYUSER = inputDto.UserId,
                                NAME = assTemplate.NAME,
                                NOTE = assTemplate.NOTE,
                                PRICE = assTemplate.PRICE,
                                SLID = inputDto.SLID,
                                WAREID = inputDto.WAREID,
                                STID = inputDto.STID,
                                SPECIFICATION = assTemplate.SPECIFICATION,
                                TYPEID = assTemplate.TYPEID,
                                UNIT = assTemplate.UNIT,
                                VENDOR = assTemplate.VENDOR,
                                CREATEDATE = DateTime.Now,
                                MODIFYDATE = DateTime.Now,
                                SN = inputDto.SnList[i],
                                TEMPLATEID = inputDto.TEMPLATEID
                            };
                            _unitOfWork.RegisterNew(assets);
                            var pr = new AssProcessRecord
                            {
                                ASSID = ASSID,
                                CREATEDATE = DateTime.Now,
                                CREATEUSER = inputDto.UserId,
                                HANDLEDATE = DateTime.Now,
                                HANDLEMAN = inputDto.UserId,
                                MODIFYDATE = DateTime.Now,
                                MODIFYUSER = inputDto.UserId,
                                PROCESSCONTENT = inputDto.UserId + "入库了" + ASSID + ",数量为1",
                                PROCESSMODE = (int)PROCESSMODE.入库,
                                QUANTITY = 1
                            };
                            _unitOfWork.RegisterNew(pr);
                            string SN = inputDto.SnList[i];
                            //添加采购入库关联表
                            AssPurchaseOrderInstorage instorage = new AssPurchaseOrderInstorage
                            {
                                POID = inputDto.POID,
                                SN = SN,
                                TEMPLATEID = inputDto.TEMPLATEID,
//                                Time = DateTime.Now
                            };
                            _unitOfWork.RegisterNew(instorage);
                        }
                        bool result = _unitOfWork.Commit();
                        RInfo.IsSuccess = result;
                        RInfo.ErrorInfo = "";
                        return RInfo;
                    }
                    else
                    {
                        RInfo.IsSuccess = false;
                        RInfo.ErrorInfo = "该资产模板不存在！";
                        return RInfo;
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

        /// <summary>
        /// 删除采购单
        /// </summary>
        /// <param name="POID">采购单编号</param>
        /// <returns></returns>
        public ReturnInfo DeletePurchaseOrder(string POID)
        {
            ReturnInfo rInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            var purchaseOrder = _assPurchaseOrderRepository.GetById(POID).FirstOrDefault();
            if (purchaseOrder == null)
            {
                sb.Append("未找到该编号的采购单.");
                rInfo.IsSuccess = false;
                rInfo.ErrorInfo = sb.ToString();
                return rInfo;
            }
            else
            {
                //根据采购单状态，已开始采购就不能删除了
                if (purchaseOrder.STATUS == (int)PurchaseOrderStatus.采购中)
                {
                    //可以删除
                    try
                    {
                        _unitOfWork.RegisterDeleted(purchaseOrder);
                        var rows = _assPoRowRepository.GetAll().Where(a => a.POID == POID);
                        foreach (var row in rows)
                        {
                            _unitOfWork.RegisterDeleted(row);
                        }

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
                    sb.Append("已经开始采购,无法删除采购单.");
                    rInfo.ErrorInfo = sb.ToString();
                    return rInfo;
                }
            }
            
        }

        /// <summary>
        /// 更新采购单信息
        /// </summary>
        /// <param name="inputDto">采购单信息</param>
        /// <returns></returns>
        public ReturnInfo UpdatePurchaseOrderOnly(AssPurchaseOrderInputDto inputDto)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            string ValidateInfo = Helper.BasicValidate(inputDto).ToString();
            sb.Append(ValidateInfo);
            if (sb.Length == 0)
            {
                try
                {
                    AssPurchaseOrder purchaseOrder = _assPurchaseOrderRepository.GetById(inputDto.POID).FirstOrDefault();
                    if (purchaseOrder != null)
                    {
                        purchaseOrder.VID = inputDto.VID;
                        purchaseOrder.PURCHASER = inputDto.PURCHASER;
                        purchaseOrder.REALID = inputDto.REALID;
                        purchaseOrder.MODIFYUSER = inputDto.MODIFYUSER;
                        purchaseOrder.NAME = inputDto.NAME;
                        purchaseOrder.MODIFYDATE = DateTime.Now;
                        _unitOfWork.RegisterDirty(purchaseOrder);
                    }
                    //得到原有行项的所有TemplateId
                    List<string> TempIds = _assPoRowRepository.GetAll().Where(a => a.POID == inputDto.POID)
                        .Select(a => a.TEMPLATEID).ToList();
                    //得到现在行项的所有TemplateId
                    List<string> NowTempIds = inputDto.RowInputDtos.Select(a => a.TEMPLATEID).ToList();
                    //得到更新的
                    List<string> Update = TempIds.Intersect(NowTempIds).ToList();
                    //得到新增的
                    List<string> Add = NowTempIds.Except(TempIds).ToList();
                    //得到删除的
                    List<string> Delete = TempIds.Except(NowTempIds).ToList();

                    foreach (var templateId in Add)
                    {
                        var info = inputDto.RowInputDtos.Find(a => a.TEMPLATEID == templateId);
                        AssPurchaseOrderRow row = new AssPurchaseOrderRow
                        {
                            POID = inputDto.POID,
                            CREATEDATE = DateTime.Now,
                            CREATEUSER = inputDto.CREATEUSER,
                            MODIFYDATE = DateTime.Now,
                            MODIFYUSER = inputDto.CREATEUSER,
                            QUANTPURCHASED = info.QUANT,
//                            Time = DateTime.Now,
                            REALPRICE = info.PRICE,
                            QUANTRETREATED = 0,
                            QUANTSTORED = 0,
                            STATUS = (int)PurchaseOrderStatus.采购中,
                            TEMPLATEID = templateId
                        };
                        _unitOfWork.RegisterNew(row);
                    }

                    foreach (var templateId in Delete)
                    {
                        AssPurchaseOrderRow row = _assPoRowRepository
                            .GetByPOIDandTemplateID(purchaseOrder.POID, templateId).FirstOrDefault();
                        if (row != null)
                        {
                            _unitOfWork.RegisterDeleted(row);
                        }
                        
                    }

                    foreach (var templateId in Update)
                    {
                        var info = inputDto.RowInputDtos.Find(a => a.TEMPLATEID == templateId);
                        AssPurchaseOrderRow row = _assPoRowRepository
                            .GetByPOIDandTemplateID(purchaseOrder.POID, templateId).FirstOrDefault();
                        if (row != null)
                        {
                            row.POID = inputDto.POID;
                            row.CREATEDATE = DateTime.Now;
                            row.CREATEUSER = inputDto.CREATEUSER;
                            row.MODIFYDATE = DateTime.Now;
                            row.MODIFYUSER = inputDto.CREATEUSER;
                            row.QUANTPURCHASED = info.QUANT;
                            row.REALPRICE = info.PRICE;
//                            row.Time = DateTime.Now;
                            row.QUANTRETREATED = 0;
                            row.QUANTSTORED = 0;
                            row.STATUS = (int)PurchaseOrderStatus.采购中;
                            row.TEMPLATEID = templateId;
                            _unitOfWork.RegisterDirty(row);

                        }

                    }
                    bool result = _unitOfWork.Commit();
                    RInfo.IsSuccess = result;
                    RInfo.ErrorInfo = inputDto.POID;
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
        #endregion




    }
}