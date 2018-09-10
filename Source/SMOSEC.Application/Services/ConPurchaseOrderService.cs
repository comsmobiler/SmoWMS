using SMOWMS.Application.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOWMS.CommLib;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.Domain.IRepository;
using SMOWMS.Infrastructure;
using SMOWMS.Domain.Entity;
using AutoMapper;
using System.Data.Entity;
using SMOWMS.DTOs.OutputDTO;
using System.Data;
using SMOWMS.DTOs.Enum;

namespace SMOWMS.Application.Services
{
    /// <summary>
    /// 耗材采购单的接口实现
    /// </summary>
    public class ConPurchaseOrderService : IConPurchaseOrderService
    {
        /// <summary>
        /// 工作单元的接口
        /// </summary>
        private IUnitOfWork _unitOfWork;

        /// <summary>
        /// 数据库上下文
        /// </summary>
        private SMOWMSDbContext _SMOWMSDbContext;

        /// <summary>
        /// 耗材的查询接口
        /// </summary>
        private IConsumablesRepository _consumablesRepository;
        /// <summary>
        /// 耗材采购单查询接口
        /// </summary>
        private IConPurchaseOrderReposity _ConPurchaseOrderReposity;
        /// <summary>
        /// 耗材行项采购单查询接口
        /// </summary>
        private IConPurchaseOrderRowReposity _ConPurchaseOrderRowReposity;
        /// <summary>
        /// 耗材入库查询接口
        /// </summary>
        private IConPurchaseOrderInstorageReposity _conPurchaseOrderInstorageReposity;
        /// <summary>
        /// 耗材退库查询接口
        /// </summary>
        private IConPurchaseOrderReturnReposity _conPurchaseOrderReturnReposity;
        /// <summary>
        /// 耗材库存查询接口
        /// </summary>
        private IConQuantRepository _conQuantRepository;

        /// <summary>
        /// 主数据服务实现的构造函数
        /// </summary>
        public ConPurchaseOrderService(IUnitOfWork unitOfWork,
            IConsumablesRepository consumablesRepository,
            IConPurchaseOrderReposity ConPurchaseOrderReposity,
            IConPurchaseOrderRowReposity conPurchaseOrderRowReposity,
            IConPurchaseOrderInstorageReposity conPurchaseOrderInstorageReposity,
            IConPurchaseOrderReturnReposity conPurchaseOrderReturnReposity,
            IConQuantRepository conQuantRepository,
            IDbContext dbContext)
        {
            _unitOfWork = unitOfWork;
            _consumablesRepository = consumablesRepository;
            _ConPurchaseOrderReposity = ConPurchaseOrderReposity;
            _ConPurchaseOrderRowReposity = conPurchaseOrderRowReposity;
            _conPurchaseOrderInstorageReposity = conPurchaseOrderInstorageReposity;
            _conPurchaseOrderReturnReposity = conPurchaseOrderReturnReposity;
            _conQuantRepository = conQuantRepository;
            _SMOWMSDbContext = (SMOWMSDbContext)dbContext;
        }
        #region 查询
        /// <summary>
        /// 根据耗材采购单号查询采购单信息
        /// </summary>
        /// <param name="POID"></param>
        /// <returns></returns>
        public ConPurchaseOrderOutputDto GetByPOID(string POID)
        {
            var FirstOrder = _ConPurchaseOrderReposity.GetById(POID);
            var result = from Order in FirstOrder
                         join User in _SMOWMSDbContext.coreUsers on Order.PURCHASER equals User.USER_ID
                         join vendor in _SMOWMSDbContext.Vendors on Order.VID equals vendor.VID
                         select new ConPurchaseOrderOutputDto()
                         {
                             POID = Order.POID,
                             NAME = Order.NAME,
                             REALID = Order.REALID,
                             VID = Order.VID,
                             VENDORNAME = vendor.NAME,
                             STATUS = Order.STATUS,
                             PURCHASER = Order.PURCHASER,
                             PURCHASERNAME = User.USER_NAME,
                             CREATEDATE = Order.CREATEDATE,
                         };
            return result.FirstOrDefault();
        }
        /// <summary>
        /// 采购分析
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public Dictionary<string, decimal> GetPurchaseAnalyze(DateTime startDate, DateTime endDate)
        {
            List<ConPurchaseOrderRow> orderRows = _ConPurchaseOrderRowReposity.GetAll()
                .Where(x => (x.STATUS == 1 || x.STATUS == 2) && x.CREATEDATE >= startDate && x.CREATEDATE<= endDate).ToList();
            var Data = from orderRow in orderRows
                       join con in _SMOWMSDbContext.Consumableses on orderRow.CID equals con.CID
                       select new ConPurchaseOrderRowInputDto()
                       {
                           CID = orderRow.CID,
                           NAME = con.NAME,
                           QUANTSTORED = orderRow.QUANTSTORED
                       };
            Dictionary<string, decimal> result = new Dictionary<string, decimal>();
            foreach (ConPurchaseOrderRowInputDto row in Data)
            {
                if (result.Keys.Contains(row.NAME))
                {
                    result[row.NAME] = result[row.NAME] + row.QUANTSTORED;
                }
                else
                {
                    result.Add(row.NAME, row.QUANTSTORED);
                }
            }
            return result;
        }
        /// <summary>
        /// 供应商采购量分析
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public Dictionary<string, Dictionary<string, decimal>> GetVendorAnalyze(DateTime startDate, DateTime endDate)
        {
            List<ConPurchaseOrderRow> orderRows = _ConPurchaseOrderRowReposity.GetAll()
                .Where(x => (x.STATUS == 1 || x.STATUS == 2) && x.CREATEDATE >= startDate && x.CREATEDATE <= endDate).ToList();
            var Data = from orderRow in orderRows
                       join con in _SMOWMSDbContext.Consumableses on orderRow.CID equals con.CID
                       join order in _SMOWMSDbContext.ConPurchaseOrders on orderRow.POID equals order.POID
                       join vendor in _SMOWMSDbContext.Vendors on order.VID equals vendor.VID
                       select new ConPurchaseOrderRowInputDto()
                       {
                           CID = orderRow.CID,
                           NAME = con.NAME,
                           VID = order.VID,
                           VENDORNAME = vendor.NAME,
                           QUANTSTORED = orderRow.QUANTSTORED
                       };
            Dictionary<string, Dictionary<string, decimal>> result = new Dictionary<string, Dictionary<string, decimal>>();
            foreach (ConPurchaseOrderRowInputDto row in Data)
            {
                if (result.Keys.Contains(row.VENDORNAME))
                {
                    if (result[row.VENDORNAME].Keys.Contains(row.NAME))
                    {
                        result[row.VENDORNAME][row.NAME] = result[row.VENDORNAME][row.NAME] + row.QUANTSTORED;
                    }
                    else
                    {
                        result[row.VENDORNAME].Add(row.NAME,row.QUANTSTORED);
                    }
                }
                else
                {
                    Dictionary<string,decimal> rowQuant = new Dictionary<string, decimal>();
                    rowQuant.Add(row.NAME,row.QUANTSTORED);
                    result.Add(row.VENDORNAME, rowQuant);
                }
            }
            return result;
        }
        /// <summary>
        /// 获取对应采购单号下所有行项信息
        /// </summary>
        /// <param name="POID"></param>
        /// <returns></returns>
        public List<ConPurAndSaleCreateInputDto> GetOrderRows(string POID)
        {
            var Rows = _ConPurchaseOrderRowReposity.GetByPOID(POID);
            var result = from Row in Rows
                         join Cons in _SMOWMSDbContext.Consumableses on Row.CID equals Cons.CID
                         select new ConPurAndSaleCreateInputDto()
                         {
                             CID = Row.CID,
                             NAME = Cons.NAME,
                             IMAGE = Cons.IMAGE,
                             QUANTPURCHASED = Row.QUANTPURCHASED,
                             REALPRICE = Row.REALPRICE,
                             QUANTRETREATED = Row.QUANTRETREATED,
                             QUANTSTORED = Row.QUANTSTORED

                         };
            return result.ToList();
        }
        /// <summary>
        /// 得到对应采购单下可入库行项
        /// </summary>
        /// <param name="POID"></param>
        /// <returns></returns>
        public List<ConPORInstorageOutputDto> GetInStoRowsByPOID(string POID)
        {
            var Rows = _ConPurchaseOrderRowReposity.GetInStoRowsByPOID(POID);
            var result = from Row in Rows
                         join Cons in _SMOWMSDbContext.Consumableses on Row.CID equals Cons.CID
                         select new ConPORInstorageOutputDto()
                         {
                             POID = Row.POID,
                             POROWID = Row.POROWID,
                             CID = Row.CID,
                             NAME = Cons.NAME,
                             IMAGE = Cons.IMAGE,
                             QUANTPURCHASED = Row.QUANTPURCHASED - Row.QUANTSTORED,
                             QUANTSTORED = Row.QUANTSTORED,
                             QUANTRETREATED = Row.QUANTRETREATED
                         };
            return result.Where(x => x.QUANTPURCHASED > 0).ToList();
        }
        /// <summary>
        /// 得到对应采购单下可退库选项
        /// </summary>
        /// <param name="POID"></param>
        /// <returns></returns>
        public List<ConPurchaseOrderReturnOutputDto> GetReturnRowsByPOID(string POID)
        {
            var inStoRows = _conPurchaseOrderInstorageReposity.GetByPOID(POID);
            var returnRows = _conPurchaseOrderReturnReposity.GetByPOID(POID);
            List<ConPurchaseOrderReturnOutputDto> rowDatas = new List<ConPurchaseOrderReturnOutputDto>();
            var result = from inStoRow in inStoRows
                         join WH in _SMOWMSDbContext.WareHouses on inStoRow.WAREID equals WH.WAREID
                         join WHST in _SMOWMSDbContext.WHStorageTypes on inStoRow.STID equals WHST.STID
                         where inStoRow.WAREID == WHST.WAREID
                         join WHSL in _SMOWMSDbContext.WHStorageLocations on inStoRow.SLID equals WHSL.SLID
                         where inStoRow.WAREID == WHSL.WAREID && inStoRow.STID == WHSL.STID
                         join row in _SMOWMSDbContext.ConPurchaseOrderRows on inStoRow.POID equals row.POID
                         where inStoRow.POROWID == row.POROWID
                         join con in _SMOWMSDbContext.Consumableses on row.CID equals con.CID
                         join returnRow in _SMOWMSDbContext.ConPurchaseOrderReturns
                         on new { inStoRow.POID, inStoRow.POROWID, inStoRow.WAREID, inStoRow.STID, inStoRow.SLID }
                         equals new { returnRow.POID, returnRow.POROWID, returnRow.WAREID, returnRow.STID, returnRow.SLID }
                         into result1
                         from ret in result1.DefaultIfEmpty()
                         select new ConPurchaseOrderReturnOutputDto()
                         {
                             POID = inStoRow.POID,
                             POROWID = inStoRow.POROWID,
                             CID = row.CID,
                             NAME = con.NAME,
                             IMAGE = con.IMAGE,
                             WAREID = inStoRow.WAREID,
                             WARENAME = WH.NAME,
                             STID = inStoRow.STID,
                             STNAME = WHST.NAME,
                             SLID = inStoRow.SLID,
                             SLNAME = WHSL.NAME,
                             QUANTSTORED = ret == null ? inStoRow.QUANT : inStoRow.QUANT - ret.QUANT,
                             LOCID = "",
                             LOCNAME = ""
                         };
            rowDatas = result.Where(x => x.QUANTSTORED > 0).ToList();
            foreach (ConPurchaseOrderReturnOutputDto row in rowDatas)
            {
                row.QUANTSTORED = row.QUANTSTORED - row.QUANTRETREATED;
                row.LOCID = row.WAREID + "/" + row.STID + "/" + row.SLID;
                row.LOCNAME = row.WARENAME + "/" + row.STNAME + "/" + row.SLNAME;
            }
            return rowDatas;
        }
        /// <summary>
        /// 得到所有耗材采购单
        /// </summary>
        /// <returns></returns>
        public DataTable GetOrders()
        {
            var FirstOrders = _ConPurchaseOrderReposity.GetAll();
            var result = from Order in FirstOrders
                         join User in _SMOWMSDbContext.coreUsers on Order.PURCHASER equals User.USER_ID
                         select new ConPurchaseOrderOutputDto()
                         {
                             POID = Order.POID,
                             NAME = Order.NAME,
                             REALID = Order.REALID,
                             STATUS = Order.STATUS,
                             PURCHASER = Order.PURCHASER,
                             PURCHASERNAME = User.USER_NAME,
                             CREATEDATE = Order.CREATEDATE,
                             TIME = ""
                         };
            var OrderTable = LINQToDataTable.ToDataTable(result.OrderByDescending(x => x.CREATEDATE));
            foreach (DataRow Row in OrderTable.Rows)
            {
                ConPurchaseOrderRow conPurchaseOrderRow = _ConPurchaseOrderRowReposity.GetByPOID(Row["POID"].ToString()).FirstOrDefault();
                Consumables consumables = _consumablesRepository.GetByID(conPurchaseOrderRow.CID).FirstOrDefault();
                Row["Image"] = consumables.IMAGE;

                Row["STATUSNAME"] = Enum.GetName(typeof(PurchaseOrderStatus), int.Parse(Row["STATUS"].ToString()));
                Row["TIME"] = DateTime.Parse(Row["CREATEDATE"].ToString()).ToShortDateString();
            }
            return OrderTable;
        }
        #endregion
        #region 操作
        /// <summary>
        /// 耗材采购单创建
        /// </summary>
        /// <param name="inputDto"></param>
        /// <returns></returns>
        public ReturnInfo AddPurchaseOrder(ConPurchaseOrderInputDto inputDto)
        {
            ReturnInfo RInfo = new ReturnInfo();
            if (string.IsNullOrEmpty(inputDto.NAME)) throw new Exception("采购单名称不能为空!");
            if (string.IsNullOrEmpty(inputDto.PURCHASER)) throw new Exception("请选择采购人!");
            String MaxID = _ConPurchaseOrderReposity.GetMaxID();       //获取最大采购单ID
            String NowID = Helper.GenerateID("PO", MaxID);
            //产生采购单编号
            inputDto.POID = NowID;
            try
            {
                ConPurchaseOrder purchaseOrder = new ConPurchaseOrder();
                purchaseOrder = Mapper.Map<ConPurchaseOrderInputDto, ConPurchaseOrder>(inputDto);
                purchaseOrder.STATUS = 0;
                _unitOfWork.RegisterNew(purchaseOrder);

                foreach (var Row in inputDto.RowData)
                {
                    ConPurchaseOrderRow purchaseOrderRow = new ConPurchaseOrderRow();
                    purchaseOrderRow = Mapper.Map<ConPurchaseOrderRowInputDto, ConPurchaseOrderRow>(Row);
                    purchaseOrderRow.POID = NowID;
                    purchaseOrderRow.CREATEUSER = inputDto.CREATEUSER;
                    purchaseOrderRow.CREATEDATE = DateTime.Now;
                    purchaseOrderRow.MODIFYUSER = inputDto.MODIFYUSER;
                    purchaseOrderRow.MODIFYDATE = DateTime.Now;
                    purchaseOrderRow.STATUS = 0;
                    _unitOfWork.RegisterNew(purchaseOrderRow);
                }
                bool result = _unitOfWork.Commit();
                RInfo.IsSuccess = result;
                RInfo.ErrorInfo = inputDto.POID;
                return RInfo;
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback();
                RInfo.IsSuccess = false;
                RInfo.ErrorInfo = ex.Message;
                return RInfo;
            }
        }
        /// <summary>
        /// 更新采购单
        /// </summary>
        /// <param name="inputDto"></param>
        /// <returns></returns>
        public ReturnInfo UpdatePruchaseOrder(ConPurchaseOrderInputDto inputDto)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            ConPurchaseOrder Order = _ConPurchaseOrderReposity.GetById(inputDto.POID).FirstOrDefault();
            if (Order == null)
            {
                sb.Append("该采购单不存在,请检查!");
                RInfo.IsSuccess = false;
                RInfo.ErrorInfo = sb.ToString();
                return RInfo;
            }
            else      //采购单存在
            {
                Order.REALID = inputDto.REALID;
                Order.NAME = inputDto.NAME;
                Order.VID = inputDto.VID;
                Order.PURCHASER = inputDto.PURCHASER;
                Order.MODIFYDATE = inputDto.MODIFYDATE;
                Order.MODIFYUSER = inputDto.MODIFYUSER;
                _unitOfWork.RegisterDirty(Order);

                //如果原来存在行项,则先删除
                List<ConPurchaseOrderRow> Rows = _ConPurchaseOrderRowReposity.GetByPOID(inputDto.POID).ToList();
                if (Rows.Count > 0)    //如果存在行项
                {
                    foreach (ConPurchaseOrderRow Row in Rows)
                    {
                        _unitOfWork.RegisterDeleted(Row);
                    }
                }
                ///添加新的选择行项
                foreach (ConPurchaseOrderRowInputDto Row in inputDto.RowData)
                {
                    ConPurchaseOrderRow purchaseOrderRow = new ConPurchaseOrderRow();
                    purchaseOrderRow = Mapper.Map<ConPurchaseOrderRowInputDto, ConPurchaseOrderRow>(Row);
                    purchaseOrderRow.POID = inputDto.POID;
                    purchaseOrderRow.CREATEUSER = inputDto.CREATEUSER;
                    purchaseOrderRow.CREATEDATE = DateTime.Now;
                    purchaseOrderRow.MODIFYUSER = inputDto.MODIFYUSER;
                    purchaseOrderRow.MODIFYDATE = DateTime.Now;
                    purchaseOrderRow.STATUS = 0;
                    _unitOfWork.RegisterNew(purchaseOrderRow);
                }
                try
                {
                    _unitOfWork.Commit();
                    RInfo.IsSuccess = true;
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
        /// <summary>
        /// 删除采购单
        /// </summary>
        /// <param name="POID"></param>
        /// <returns></returns>
        public ReturnInfo DeletePurchaseOrder(string POID)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            ConPurchaseOrder Order = _ConPurchaseOrderReposity.GetById(POID).FirstOrDefault();
            if (Order == null)
            {
                sb.Append("未找到该采购单!");
                RInfo.IsSuccess = false;
                RInfo.ErrorInfo = sb.ToString();
                return RInfo;
            }
            else
            {
                ///根据盘点单状态进行操作
                if (Order.STATUS == (int)PurchaseOrderStatus.采购中)
                {
                    //可以删除
                    try
                    {
                        _unitOfWork.RegisterDeleted(Order);

                        List<ConPurchaseOrderRow> Rows = _ConPurchaseOrderRowReposity.GetByPOID(POID).ToList();
                        if (Rows.Count > 0)    //如果存在行项
                        {
                            foreach (ConPurchaseOrderRow Row in Rows)
                            {
                                _unitOfWork.RegisterDeleted(Row);
                            }
                        }
                        _unitOfWork.Commit();
                        RInfo.IsSuccess = true;
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
                    sb.Append("已经开始采购，无法删除采购单!");
                    RInfo.IsSuccess = false;
                    RInfo.ErrorInfo = sb.ToString();
                    return RInfo;
                }
            }
        }
        /// <summary>
        /// 耗材采购单入库
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public ReturnInfo InStoConPurhcaseOrder(ConPOInStoInputDto entity)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            if (String.IsNullOrEmpty(entity.WAREID) || String.IsNullOrEmpty(entity.STID) || String.IsNullOrEmpty(entity.SLID))
            {
                throw new Exception("请扫描调入库位!");
            }
            int thisOver = 0;    //此次完成入库的行项数
            foreach (ConPurchaseOrderRowInputDto row in entity.RowDatas)
            {
                ConPurchaseOrderInstorage hasInSto = _conPurchaseOrderInstorageReposity.GetByPOIDAndWareID(entity.POID, row.POROWID, entity.WAREID, entity.STID, entity.SLID).FirstOrDefault();
                if (hasInSto == null) //不存在入库行项
                {
                    ConPurchaseOrderInstorage instorage = new ConPurchaseOrderInstorage();
                    instorage.POID = entity.POID;
                    instorage.POROWID = row.POROWID;
                    instorage.WAREID = entity.WAREID;
                    instorage.STID = entity.STID;
                    instorage.SLID = entity.SLID;
                    instorage.QUANT = row.QUANTSTORED;
                    _unitOfWork.RegisterNew(instorage);
                }
                else      //已存在入库行项
                {
                    hasInSto.QUANT = hasInSto.QUANT + row.QUANTSTORED;
                    _unitOfWork.RegisterDirty(hasInSto);
                }

                //OrderRow表修改入库数量以及状态
                ConPurchaseOrderRow orderRow = _ConPurchaseOrderRowReposity.GetOrderRowByCID(entity.POID, row.CID).FirstOrDefault();
                orderRow.QUANTSTORED = orderRow.QUANTSTORED + row.QUANTSTORED;
                orderRow.STATUS = (int)PurchaseOrderStatus.入库中;
                if (orderRow.QUANTSTORED == orderRow.QUANTPURCHASED)
                {
                    orderRow.STATUS = (int)PurchaseOrderStatus.已完成;
                    thisOver += 1;
                }
                if (orderRow.QUANTSTORED > orderRow.QUANTPURCHASED) throw new Exception("实际入库数量不可大于可入库数量!");
                _unitOfWork.RegisterDirty(orderRow);

                ConQuant con = _conQuantRepository.GetByCID(row.CID, entity.WAREID, entity.STID, entity.SLID).FirstOrDefault();
                if (con == null)  //如果原先不存在相关库存，则添加库存信息
                {
                    ConQuant conQuant = new ConQuant();
                    conQuant.CID = row.CID;
                    conQuant.WAREID = entity.WAREID;
                    conQuant.STID = entity.STID;
                    conQuant.SLID = entity.SLID;
                    conQuant.QUANTITY = row.QUANTSTORED;
                    conQuant.CREATEDATE = DateTime.Now;
                    conQuant.CREATEUSER = entity.CREATEUSER;
                    conQuant.MODIFYDATE = DateTime.Now;
                    conQuant.MODIFYUSER = entity.CREATEUSER;
                    _unitOfWork.RegisterNew(conQuant);
                }
                else
                {
                    con.QUANTITY = con.QUANTITY + row.QUANTSTORED;
                    _unitOfWork.RegisterDirty(con);
                }
            }

            //order表修改状态
            ConPurchaseOrder conPurchaseOrder = _ConPurchaseOrderReposity.GetById(entity.POID).FirstOrDefault();
            int allRowsCount = _ConPurchaseOrderRowReposity.GetByPOID(entity.POID).ToList().Count;
            int hasOverCount = _ConPurchaseOrderRowReposity.GetOrderRowsByStatus(entity.POID, (int)PurchaseOrderStatus.已完成).ToList().Count;
            if (allRowsCount == hasOverCount + thisOver)
            {
                conPurchaseOrder.STATUS = (int)PurchaseOrderStatus.已完成;
            }
            else
            {
                conPurchaseOrder.STATUS = (int)PurchaseOrderStatus.入库中;
            }
            _unitOfWork.RegisterDirty(conPurchaseOrder);
            try
            {
                _unitOfWork.Commit();
                RInfo.IsSuccess = true;
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
        /// 耗材采购单退库
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public ReturnInfo ReturnConPurchaseOrder(ConPOInStoInputDto entity)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            foreach (ConPurchaseOrderRowInputDto row in entity.RowDatas)
            {
                ConPurchaseOrderReturn hasReturn = _conPurchaseOrderReturnReposity.GetByPOIDAndWareID(entity.POID, row.POROWID, row.WAREID, row.STID, row.SLID).FirstOrDefault();
                if (hasReturn == null) //不存在退库行项
                {
                    ConPurchaseOrderReturn orderReturn = new ConPurchaseOrderReturn();
                    orderReturn.POID = entity.POID;
                    orderReturn.POROWID = row.POROWID;
                    orderReturn.WAREID = row.WAREID;
                    orderReturn.STID = row.STID;
                    orderReturn.SLID = row.SLID;
                    orderReturn.QUANT = row.QUANTRETREATED;
                    _unitOfWork.RegisterNew(orderReturn);
                }
                else      //已存在退库行项
                {
                    hasReturn.QUANT = hasReturn.QUANT + row.QUANTRETREATED;
                    _unitOfWork.RegisterDirty(hasReturn);
                }

                ConPurchaseOrderRow orderRow = _ConPurchaseOrderRowReposity.GetOrderRowByCID(entity.POID, row.CID).FirstOrDefault();
                orderRow.QUANTRETREATED = orderRow.QUANTRETREATED + row.QUANTRETREATED;
                if (orderRow.QUANTRETREATED > orderRow.QUANTSTORED) throw new Exception("实际退库数量不可大于可退库数量!");
                _unitOfWork.RegisterDirty(orderRow);

                ConQuant conq = _conQuantRepository.GetByCID(row.CID, row.WAREID, row.STID, row.SLID).FirstOrDefault();
                if (conq == null)  //如果原先不存在相关库存，则添加库存信息
                {
                    throw new Exception("不存在耗材编号为" + row.CID + "的库存，请检查!");
                }
                else
                {
                    conq.QUANTITY = conq.QUANTITY - row.QUANTRETREATED;
                    if (conq.QUANTITY < 0)
                    {
                        throw new Exception("耗材" + row.CID + "库存不足，无法退库!");
                    }
                    else if (conq.QUANTITY == 0)
                    {
                        _unitOfWork.RegisterDeleted(conq);
                    }
                    else
                    {
                        _unitOfWork.RegisterDirty(conq);
                    }
                }
            }
            try
            {
                _unitOfWork.Commit();
                RInfo.IsSuccess = true;
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
        #endregion
    }
}
