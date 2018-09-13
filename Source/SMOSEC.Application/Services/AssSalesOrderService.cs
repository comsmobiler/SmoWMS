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
using SMOWMS.Domain.IRepository;
using SMOWMS.DTOs.Enum;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.DTOs.OutputDTO;
using SMOWMS.Infrastructure;

namespace SMOWMS.Application.Services
{
    /// <summary>
    /// 资产采购单服务实现
    /// </summary>
    public class AssSalesOrderService : IAssSalesOrderService
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
        /// 采购单查询接口
        /// </summary>
        private IAssSalesOrderRepository _assSalesOrderRepository;

        /// <summary>
        /// 采购单行项查询接口
        /// </summary>
        private IAssSORowRepository _assSoRowRepository;
        /// <summary>
        /// 资产模板查询接口
        /// </summary>
        private IAssTemplateRepository _assTemplateRepository;

        /// <summary>
        /// 资产销售单服务实现的构造函数
        /// </summary>
        public AssSalesOrderService(IUnitOfWork unitOfWork,
            IAssetsRepository AssetsRepository,
            IAssSalesOrderRepository assSalesOrderRepository,
            IAssSORowRepository assSoRowRepository,
            IAssTemplateRepository assTemplateRepository,
            IDbContext dbContext)
        {
            _unitOfWork = unitOfWork;
            _AssetsRepository = AssetsRepository;
            _assSalesOrderRepository = assSalesOrderRepository;
            _assSoRowRepository = assSoRowRepository;
            _assTemplateRepository = assTemplateRepository;
            SMOWMSDbContext = (SMOWMSDbContext)dbContext;
        }

        #region 查询
        /// <summary>
        /// 根据销售单编号得到销售单
        /// </summary>
        /// <param name="SOID">销售单编号</param>
        /// <returns></returns>
        public AssSalesOrderOutputDto GetById(string SOID)
        {
            var result = from order in SMOWMSDbContext.AssSalesOrders
                         join user in SMOWMSDbContext.coreUsers on order.SALESPERSON equals user.USER_ID
                         join customer in SMOWMSDbContext.Customers on order.CUSID equals customer.CUSID
                         where order.SOID == SOID
                         select new AssSalesOrderOutputDto()
                         {
                             SOID = order.SOID,
                             NAME = order.NAME,
                             SALESPERSON = order.SALESPERSON,
                             SALESPERSONNAME = user.USER_NAME,
                             REALID = order.REALID,
                             STATUS = order.STATUS,
                             CUSID = order.CUSID,
                             CUSNAME = customer.NAME
                         };

            return result.AsNoTracking().FirstOrDefault();

        }

        /// <summary>
        /// 得到用户的销售单列表
        /// </summary>
        /// <param name="UserId">用户编号</param>
        /// <returns></returns>
        public DataTable GetOrders(string UserId)
        {
            var area = _assSalesOrderRepository.GetAll();

            if (!string.IsNullOrEmpty(UserId))
            {
                area = area.Where(a => a.SALESPERSON == UserId);
            }
            var list = from assSalesOrder in area
                       join user in SMOWMSDbContext.coreUsers on assSalesOrder.SALESPERSON equals user.USER_ID
                       orderby assSalesOrder.CREATEDATE descending
                       select new AssSOListOutputDto()
                       {
                           SOID = assSalesOrder.SOID,
                           NAME = assSalesOrder.NAME,
                           SALESPERSON = assSalesOrder.SALESPERSON,
                           SALESPERSONNAME = user.USER_NAME,
                           STATUS = assSalesOrder.STATUS,
                           STATUSNAME = "",
                           Time = "",
                           REALID = assSalesOrder.REALID,
                           CREATEDATE = assSalesOrder.CREATEDATE
                       };
            var temTable = LINQToDataTable.ToDataTable(list);
            foreach (DataRow row in temTable.Rows)
            {
                AssSalesOrderRow assSalesOrderRow = _assSoRowRepository.GetBySOID(row["SOID"].ToString()).FirstOrDefault();
                AssTemplate assTemplate = _assTemplateRepository.GetById(assSalesOrderRow.TEMPLATEID).FirstOrDefault();
                row["Image"] = assTemplate.IMAGE;

                int status = int.Parse(row["STATUS"].ToString());
                row["STATUSNAME"] = Enum.GetName(typeof(SalesOrderStatus), status);
                row["Time"] = DateTime.Parse(row["CREATEDATE"].ToString()).ToShortDateString();
            }
            return temTable;
        }

        /// <summary>
        /// 得到销售单行项
        /// </summary>
        /// <param name="SOID">销售单编号</param>
        /// <returns></returns>
        public DataTable GetRows(string SOID)
        {
            var results = from salesOrderRow in SMOWMSDbContext.AssSalesOrderRows
                          join template in SMOWMSDbContext.AssTemplates on salesOrderRow.TEMPLATEID equals template.TEMPLATEID
                          where salesOrderRow.SOID == SOID
                          select new AssSORowOutputDto()
                          {
                              SOID = salesOrderRow.SOID,
                              IMAGE = template.IMAGE,
                              NAME = template.NAME,
                              SOROWID = salesOrderRow.SOROWID,
                              QUANTOUT = salesOrderRow.QUANTOUT,
                              QUANTRETREATED = salesOrderRow.QUANTRETREATED,
                              QUANTSALED = salesOrderRow.QUANTSALED,
                              REALPRICE = salesOrderRow.REALPRICE,
                              TEMPLATEID = salesOrderRow.TEMPLATEID,
                              STATUS = salesOrderRow.STATUS,
                              STATUSNAME = ""
                          };
            DataTable tempTable = LINQToDataTable.ToDataTable(results);

            foreach (DataRow row in tempTable.Rows)
            {
                row["STATUSNAME"] = Enum.GetName(typeof(SalesOrderStatus), int.Parse(row["STATUS"].ToString()));
            }
            return tempTable;
        }

        /// <summary>
        /// 得到销售单行项的资产模板列表
        /// </summary>
        /// <param name="SOID">销售单编号</param>
        /// <returns></returns>
        public List<AssTempOutputDto> GetTemplateList(string SOID)
        {
            var result = from salesOrderRow in SMOWMSDbContext.AssSalesOrderRows
                         join assTemplate in SMOWMSDbContext.AssTemplates on salesOrderRow.TEMPLATEID equals assTemplate
                             .TEMPLATEID
                         where salesOrderRow.SOID == SOID
                         select new AssTempOutputDto()
                         {
                             TEMPLATEID = assTemplate.TEMPLATEID,
                             NAME = assTemplate.NAME
                         };
            return result.ToList();

        }

        /// <summary>
        /// 得到销售单行项
        /// </summary>
        /// <param name="SOID">销售单编号</param>
        /// <returns></returns>
        public List<AssSORowOutputDto> GetSORows(string SOID)
        {
            var results = from assSalesOrderRow in SMOWMSDbContext.AssSalesOrderRows
                          join template in SMOWMSDbContext.AssTemplates on assSalesOrderRow.TEMPLATEID equals template.TEMPLATEID
                          where assSalesOrderRow.SOID == SOID
                          select new AssSORowOutputDto()
                          {
                              SOID = assSalesOrderRow.SOID,
                              IMAGE = template.IMAGE,
                              NAME = template.NAME,
                              SOROWID = assSalesOrderRow.SOROWID,
                              PRICE = assSalesOrderRow.REALPRICE,
//                              TPRICE = template.PRICE.Value,
                              QUANT = assSalesOrderRow.QUANTSALED,
                              QUANTSALED = assSalesOrderRow.QUANTSALED,
                              QUANTRETREATED = assSalesOrderRow.QUANTRETREATED,
                              QUANTOUT = assSalesOrderRow.QUANTOUT,
                              REALPRICE = assSalesOrderRow.REALPRICE,
                              TEMPLATEID = assSalesOrderRow.TEMPLATEID,
                              STATUS = assSalesOrderRow.STATUS,
                              STATUSNAME = ""
                          };

            return results.ToList();

        }

        /// <summary>
        /// 得到销售单下的SN集合
        /// </summary>
        /// <param name="SOID">销售单编号</param>
        /// <returns></returns>
        public List<string> GetSoSnList(string SOID)
        {
            var result = from outbound in SMOWMSDbContext.AssSalesOrderOutbounds
                         join assetse in SMOWMSDbContext.Assetss on outbound.SN equals assetse.SN
                         where outbound.SOID == SOID && assetse.ISINWAREHOUSE == 0
                         select assetse.SN;
            return result.ToList();
        }

        /// <summary>
        /// 查询该销售单下是否有该序列号
        /// </summary>
        /// <param name="SOID">销售单编号</param>
        /// <param name="SN">序列号</param>
        /// <returns></returns>
        public bool SNIsOK(string SOID, string SN)
        {
            List<string> snList = GetSoSnList(SOID);
            if (snList.Count > 0)
            {
                if (snList.Contains(SN))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// 判断销售单编号是否存在
        /// </summary>
        /// <param name="SOID">销售单编号</param>
        /// <returns></returns>
        public bool SOIDIsExist(string SOID)
        {
            return _assSalesOrderRepository.GetAll().Any(a => a.SOID == SOID);
        }

        #endregion

        #region 操作
        /// <summary>
        /// 添加销售单
        /// </summary>
        /// <param name="inputDto">销售单信息</param>
        /// <returns></returns>
        public ReturnInfo AddSalesOrder(AssSalesOrderInputDto inputDto)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            if (string.IsNullOrEmpty(inputDto.SOID))
            {
                string MaxId = _assSalesOrderRepository.GetMaxId();
                string SoId = Helper.GenerateIDEx2("S", MaxId);
                //产生资产编号
                inputDto.SOID = SoId;
            }
            string ValidateInfo = Helper.BasicValidate(inputDto).ToString();
            sb.Append(ValidateInfo);
            if (sb.Length == 0)
            {
                try
                {
                    AssSalesOrder salesOrder = Mapper.Map<AssSalesOrderInputDto, AssSalesOrder>(inputDto);
                    salesOrder.STATUS = (int)SalesOrderStatus.销售中;
                    salesOrder.CREATEDATE = DateTime.Now;
                    salesOrder.MODIFYDATE = DateTime.Now;
                    _unitOfWork.RegisterNew(salesOrder);

                    foreach (var inputDtoRow in inputDto.RowInputDtos)
                    {
                        AssSalesOrderRow row = new AssSalesOrderRow
                        {
                            STATUS = (int)SalesOrderStatus.销售中,
                            QUANTSALED = inputDtoRow.QUANT,
                            REALPRICE = inputDtoRow.PRICE,
                            CREATEUSER = inputDtoRow.CREATEUSER,
                            MODIFYUSER = inputDtoRow.MODIFYUSER,
                            TEMPLATEID = inputDtoRow.TEMPLATEID,
                            CREATEDATE = DateTime.Now,
                            MODIFYDATE = DateTime.Now,
//                            Time = DateTime.Now,
                            SOID = inputDto.SOID
                        };
                        _unitOfWork.RegisterNew(row);
                    }
                    bool result = _unitOfWork.Commit();
                    RInfo.IsSuccess = result;
                    RInfo.ErrorInfo = inputDto.SOID;
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
        /// 销售退库
        /// </summary>
        /// <param name="inputDto">销售退库相关信息</param>
        /// <returns></returns>
        public ReturnInfo RetiringAss(AssRetiringInputDto inputDto)
        {
            //
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();

            string ValidateInfo = Helper.BasicValidate(inputDto).ToString();
            sb.Append(ValidateInfo);
            if (sb.Length == 0)
            {
                try
                {
                    //先根据SOID,得到<templateId,List<sn>>的Dictionary

                    //取得各个templateId有多少SN

                    //更改Row中的数值

                    //更改Assets表中的状态为在库，库位等对应修改
                    //根据sns，得到<templateId,sn数>的Dictionary
                    string SOID = inputDto.SOID;
                    var allSn = from outbound in SMOWMSDbContext.AssSalesOrderOutbounds
                                join assetse in SMOWMSDbContext.Assetss on outbound.SN equals assetse.SN
                                where assetse.ISINWAREHOUSE == 0 && outbound.SOID == SOID
                                select outbound.SN;
                    List<string> allList = allSn.ToList();
                    //更改Row中的数值
                    List<string> bothList = allList.Intersect(inputDto.SnList).ToList();
                    var assDictionary = _AssetsRepository.GetCountBySnListEx(bothList);
                    foreach (var templateId in assDictionary.Keys)
                    {
                        var row = _assSoRowRepository.GetBySOIDandTemplateID(inputDto.SOID, templateId).FirstOrDefault();
                        if (row != null)
                        {
                            row.QUANTRETREATED = row.QUANTRETREATED + assDictionary[templateId];
                            _unitOfWork.RegisterDirty(row);
                        }
                    }
                    //更改Assets表中的状态为在库

                    var assets = _AssetsRepository.GetAll().Where(a => bothList.Contains(a.SN));

                    //遍历,修改状态为在库

                    foreach (var asset in assets)
                    {
                        //修改状态为在库
                        asset.ISINWAREHOUSE = 1;
                        asset.WAREID = inputDto.WAREID;
                        asset.STID = inputDto.STID;
                        asset.SLID = inputDto.SLID;
                        _unitOfWork.RegisterDirty(asset);
                        //添加出货关联表
                        AssSalesOrderRetiring soRetiring = new AssSalesOrderRetiring()
                        {
                            SOID = SOID,
                            SN = asset.SN,
                            TEMPLATEID = asset.TEMPLATEID,
//                            Time = DateTime.Now
                        };
                        _unitOfWork.RegisterNew(soRetiring);

                        var pr = new AssProcessRecord
                        {
                            ASSID = asset.ASSID,
                            CREATEDATE = DateTime.Now,
                            CREATEUSER = inputDto.UserId,
                            HANDLEDATE = DateTime.Now,
                            HANDLEMAN = inputDto.UserId,
                            MODIFYDATE = DateTime.Now,
                            MODIFYUSER = inputDto.UserId,
                            PROCESSCONTENT = inputDto.UserId + "退库了" + asset.ASSID + ",数量为1",
                            PROCESSMODE = (int)PROCESSMODE.退库,
                            QUANTITY = 1
                        };
                        _unitOfWork.RegisterNew(pr);
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
            else
            {
                RInfo.IsSuccess = false;
                RInfo.ErrorInfo = sb.ToString();
                return RInfo;
            }
        }

        /// <summary>
        /// 删除销售单
        /// </summary>
        /// <param name="SOID">销售单编号</param>
        /// <returns></returns>
        public ReturnInfo DeleteSalesOrder(string SOID)
        {
            ReturnInfo rInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            var salesOrder = _assSalesOrderRepository.GetById(SOID).FirstOrDefault();
            if (salesOrder == null)
            {
                sb.Append("未找到该编号的销售单.");
                rInfo.IsSuccess = false;
                rInfo.ErrorInfo = sb.ToString();
                return rInfo;
            }
            else
            {
                //根据销售单状态，已开始出库就不能删除了
                if (salesOrder.STATUS == (int)SalesOrderStatus.销售中)
                {
                    //可以删除
                    try
                    {
                        _unitOfWork.RegisterDeleted(salesOrder);
                        var rows = _assSoRowRepository.GetAll().Where(a => a.SOID == SOID);
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
                    sb.Append("已经开始出库,无法删除销售单.");
                    rInfo.ErrorInfo = sb.ToString();
                    return rInfo;
                }
            }
        }

        /// <summary>
        /// 销售资产
        /// </summary>
        /// <param name="inputDto">相关信息</param>
        /// <returns></returns>
        public ReturnInfo SaleAss(AssSalesInputDto inputDto)
        {

            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            try
            {
                //先判断所有sn是否在库
                //先得到所有在库的sn集合
                var allInSn= _AssetsRepository.GetAll().Where(a=>a.ISINWAREHOUSE==1).Select(a => a.SN).ToList();
                foreach (var sn in inputDto.sns)
                {
                    if (!allInSn.Contains(sn))
                    {
                        RInfo.IsSuccess = false;
                        RInfo.ErrorInfo = "序列号" + sn + "不在库!";
                        return RInfo;
                    }
                }

                //根据sns，得到<templateId,sn数>的Dictionary
                var assDictionary = _AssetsRepository.GetCountBySnList(inputDto.sns);
                //记录现在追加的行项完成数
                int nowComplete = 0;
                //更改Row中的数值
                foreach (var templateId in assDictionary.Keys)
                {
                    var row = _assSoRowRepository.GetBySOIDandTemplateID(inputDto.SOID, templateId).FirstOrDefault();
                    if (row != null)
                    {
                        row.QUANTOUT = row.QUANTOUT + assDictionary[templateId];
                        if (row.QUANTSALED < row.QUANTOUT)
                        {
                            RInfo.IsSuccess = false;
                            RInfo.ErrorInfo = "模板" + templateId + "的出库量出过销售量！";
                            return RInfo;
                        }
                        else
                        {
                            if (row.QUANTSALED == row.QUANTOUT)
                            {
                                row.STATUS = (int)SalesOrderStatus.已完成;
                                nowComplete++;
                            }
                            else
                            {
                                row.STATUS = (int) SalesOrderStatus.出库中;
                            }
                        }
                        _unitOfWork.RegisterDirty(row);
                    }
                }
                var assSo = _assSalesOrderRepository.GetById(inputDto.SOID).FirstOrDefault();
                if (assSo != null)
                {
                    assSo.STATUS = (int) SalesOrderStatus.出库中;
                    //得到采购单未完成行项数
                    var uncompleteCount = _assSoRowRepository.GetBySOID(inputDto.SOID).Count(a => a.STATUS != (int)SalesOrderStatus.已完成);
                    if (uncompleteCount == nowComplete)
                    {
                        //如果全部完成了，修改销售单状态为"已完成"
                        assSo.STATUS = (int) SalesOrderStatus.已完成;
                        _unitOfWork.RegisterDirty(assSo);
                    }
                }
                //更改Assets表中的状态为不在库
                var allList = _AssetsRepository.GetAll().Select(a => a.SN).ToList();
                List<string> bothList = allList.Intersect(inputDto.sns).ToList();
                var assets = _AssetsRepository.GetAll().Where(a => bothList.Contains(a.SN));

                //遍历,修改状态为已不在库

                foreach (var asset in assets)
                {
                    //修改状态为已不在库
                    asset.ISINWAREHOUSE = 0;
                    _unitOfWork.RegisterDirty(asset);
                    //添加出货关联表
                    AssSalesOrderOutbound soOutbound = new AssSalesOrderOutbound()
                    {
                        SOID = inputDto.SOID,
                        SN = asset.SN,
                        TEMPLATEID = asset.TEMPLATEID,
//                        Time = DateTime.Now
                    };
                    _unitOfWork.RegisterNew(soOutbound);

                    var pr = new AssProcessRecord
                    {
                        ASSID = asset.ASSID,
                        CREATEDATE = DateTime.Now,
                        CREATEUSER = inputDto.UserId,
                        HANDLEDATE = DateTime.Now,
                        HANDLEMAN = inputDto.UserId,
                        MODIFYDATE = DateTime.Now,
                        MODIFYUSER = inputDto.UserId,
                        PROCESSCONTENT = inputDto.UserId + "出库了" + asset.ASSID + ",数量为1",
                        PROCESSMODE = (int)PROCESSMODE.出库,
                        QUANTITY = 1
                    };
                    _unitOfWork.RegisterNew(pr);
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
        /// 修改销售单
        /// </summary>
        /// <param name="inputDto">销售单信息</param>
        /// <returns></returns>
        public ReturnInfo UpdateSalesOrderOnly(AssSalesOrderInputDto inputDto)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            string ValidateInfo = Helper.BasicValidate(inputDto).ToString();
            sb.Append(ValidateInfo);
            if (sb.Length == 0)
            {
                try
                {
                    AssSalesOrder salesOrder = _assSalesOrderRepository.GetById(inputDto.SOID).FirstOrDefault();
                    if (salesOrder != null)
                    {
                        salesOrder.CUSID = inputDto.CUSID;
                        salesOrder.SALESPERSON = inputDto.SALESPERSON;
                        salesOrder.REALID = inputDto.REALID;
                        salesOrder.MODIFYUSER = inputDto.MODIFYUSER;
                        salesOrder.NAME = inputDto.NAME;
                        salesOrder.MODIFYDATE = DateTime.Now;
                        salesOrder.CREATEDATE = salesOrder.CREATEDATE;
                        _unitOfWork.RegisterDirty(salesOrder);
                    }

                    //得到原有行项的所有TemplateId
                    List<string> TempIds = _assSoRowRepository.GetAll().Where(a => a.SOID == inputDto.SOID)
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
                        AssSalesOrderRow row = new AssSalesOrderRow()
                        {
                            SOID = inputDto.SOID,
                            CREATEDATE = DateTime.Now,
                            CREATEUSER = inputDto.CREATEUSER,
                            MODIFYDATE = DateTime.Now,
                            MODIFYUSER = inputDto.CREATEUSER,
                            QUANTOUT = 0,
                            QUANTRETREATED = info.QUANT,
                            REALPRICE = info.PRICE,
//                            Time = DateTime.Now,
                            QUANTSALED = 0,
                            STATUS = (int)SalesOrderStatus.销售中,
                            TEMPLATEID = templateId
                        };
                        _unitOfWork.RegisterNew(row);
                    }

                    foreach (var templateId in Delete)
                    {
                        AssSalesOrderRow row = _assSoRowRepository
                            .GetBySOIDandTemplateID(inputDto.SOID, templateId).FirstOrDefault();
                        if (row != null)
                        {
                            _unitOfWork.RegisterDeleted(row);
                        }
                    }

                    foreach (var templateId in Update)
                    {
                        var info = inputDto.RowInputDtos.Find(a => a.TEMPLATEID == templateId);
                        AssSalesOrderRow row = _assSoRowRepository
                            .GetBySOIDandTemplateID(inputDto.SOID, templateId).FirstOrDefault();
                        if (row != null)
                        {
                            row.MODIFYDATE = DateTime.Now;
                            row.MODIFYUSER = inputDto.CREATEUSER;
//                            row.Time = DateTime.Now;
                            row.QUANTOUT = 0;
                            row.QUANTRETREATED = 0;
                            row.QUANTSALED = 0;
                            row.STATUS = (int)SalesOrderStatus.销售中;
                            row.TEMPLATEID = templateId;
                            row.REALPRICE = info.PRICE;
                            row.QUANTSALED = info.QUANT;
                            _unitOfWork.RegisterDirty(row);
                        }
                    }
                    bool result = _unitOfWork.Commit();
                    RInfo.IsSuccess = result;
                    RInfo.ErrorInfo = inputDto.SOID;
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