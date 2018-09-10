using SMOWMS.Application.IServices;
using SMOWMS.Domain.IRepository;
using SMOWMS.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOWMS.DTOs.OutputDTO;
using System.Data;
using SMOWMS.CommLib;
using SMOWMS.DTOs.Enum;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.Domain.Entity;
using AutoMapper;
using System.Data.Entity;

namespace SMOWMS.Application.Services
{
    /// <summary>
    /// 耗材销售单的接口实现
    /// </summary>
    public class ConSalesOrderService : IConSalesOrderService
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
        /// 耗材销售单查询接口
        /// </summary>
        private IConSalesOrderReposity _ConSalesOrderReposity;
        /// <summary>
        /// 耗材销售单行项查询接口
        /// </summary>
        private IConSalesOrderRowReposity _ConSalesOrderRowReposity;
        /// <summary>
        /// 耗材出库单查询接口
        /// </summary>
        private IConSalesOrderOutboundReposity _ConSalesOrderOutboundReposity;
        /// <summary>
        /// 耗材退货查询接口
        /// </summary>
        private IConSalesOrderRetiringReposity _ConSalesOrderRetiringReposity;
        /// <summary>
        /// 耗材库存查询接口
        /// </summary>
        private IConQuantRepository _ConQuantRepository;

        /// <summary>
        /// 主数据服务实现的构造函数
        /// </summary>
        public ConSalesOrderService(IUnitOfWork unitOfWork,
            IConsumablesRepository consumablesRepository,
            IConSalesOrderReposity ConSalesOrderReposity,
            IConSalesOrderRowReposity ConSalesOrderRowReposity,
            IConSalesOrderOutboundReposity ConSalesOrderOutboundReposity,
            IConSalesOrderRetiringReposity ConSalesOrderRetiringReposity,
            IConQuantRepository conQuantRepository,
            IDbContext dbContext)
        {
            _unitOfWork = unitOfWork;
            _consumablesRepository = consumablesRepository;
            _ConSalesOrderReposity = ConSalesOrderReposity;
            _ConSalesOrderRowReposity = ConSalesOrderRowReposity;
            _ConSalesOrderOutboundReposity = ConSalesOrderOutboundReposity;
            _ConSalesOrderRetiringReposity = ConSalesOrderRetiringReposity;
            _ConQuantRepository = conQuantRepository;
            _SMOWMSDbContext = (SMOWMSDbContext)dbContext;
        }
        #region 查询
        /// <summary>
        /// 根据耗材销售单号查询销售单信息
        /// </summary>
        /// <param name="SOID"></param>
        /// <returns></returns>
        public ConSalesOrderOutputDto GetBySOID(string SOID)
        {
            var FirstOrder = _ConSalesOrderReposity.GetById(SOID).AsNoTracking();
            var result = from Order in FirstOrder
                         join User in _SMOWMSDbContext.coreUsers on Order.SALESPERSON equals User.USER_ID
                         join customer in _SMOWMSDbContext.Customers on Order.CUSID equals customer.CUSID
                         select new ConSalesOrderOutputDto()
                         {
                             SOID = Order.SOID,
                             NAME = Order.NAME,
                             CUSID = Order.CUSID,
                             CUSTOMERNAME = customer.NAME,
                             REALID = Order.REALID,
                             STATUS = Order.STATUS,
                             SALESPERSON = Order.SALESPERSON,
                             SALESPERSONNAME = User.USER_NAME,
                             CREATEDATE = Order.CREATEDATE,
                         };
            return result.AsNoTracking().FirstOrDefault();
        }
        /// <summary>
        /// 得到所有耗材销售单
        /// </summary>
        /// <returns></returns>
        public DataTable GetOrders()
        {
            var FirstOrders = _ConSalesOrderReposity.GetAll().AsNoTracking();
            var result = from Order in FirstOrders
                         join User in _SMOWMSDbContext.coreUsers on Order.SALESPERSON equals User.USER_ID
                         select new ConSalesOrderOutputDto()
                         {
                             SOID = Order.SOID,
                             NAME = Order.NAME,
                             REALID = Order.REALID,
                             STATUS = Order.STATUS,
                             SALESPERSON = Order.SALESPERSON,
                             SALESPERSONNAME = User.USER_NAME,
                             CREATEDATE = Order.CREATEDATE,
                             CANEDIT = "",
                             CANDELETE = "",
                             CANSTART = "",
                             TIME = ""
                         };
            var OrderTable = LINQToDataTable.ToDataTable(result.OrderByDescending(x => x.CREATEDATE));
            foreach (DataRow Row in OrderTable.Rows)
            {
                ConSalesOrderRow conSalesOrderRow = _ConSalesOrderRowReposity.GetBySOID(Row["SOID"].ToString()).FirstOrDefault();
                Consumables consumables = _consumablesRepository.GetByID(conSalesOrderRow.CID).FirstOrDefault();
                Row["Image"] = consumables.IMAGE;

                Row["STATUSNAME"] = Enum.GetName(typeof(SalesOrderStatus), int.Parse(Row["STATUS"].ToString()));
                Row["TIME"] = DateTime.Parse(Row["CREATEDATE"].ToString()).ToShortDateString();
            }
            return OrderTable;
        }
        /// <summary>
        /// 获取对应耗材单号下所有行项信息
        /// </summary>
        /// <param name="SOID"></param>
        /// <returns></returns>
        public List<ConPurAndSaleCreateInputDto> GetOrderRows(string SOID)
        {
            var Rows = _ConSalesOrderRowReposity.GetBySOID(SOID).AsNoTracking();
            var result = from Row in Rows
                         join Cons in _SMOWMSDbContext.Consumableses on Row.CID equals Cons.CID
                         select new ConPurAndSaleCreateInputDto()
                         {
                             CID = Row.CID,
                             NAME = Cons.NAME,
                             IMAGE = Cons.IMAGE,
                             REALPRICE = Row.REALPRICE,
                             QUANTSALED = Row.QUANTSALED,        
                             QUANTOUT = Row.QUANTOUT,
                             QUANTRETREATED = Row.QUANTRETREATED
                         };
            return result.AsNoTracking().ToList();
        }
        /// <summary>
        /// 得到对应销售单下可出库行项
        /// </summary>
        /// <param name="SOID"></param>
        /// <returns></returns>
        public List<ConSalesOrderOutboundOutputDto> GetOutRowsBySOID(string SOID)
        {
            var outboundRows = _ConSalesOrderRowReposity.GetOutboundRowsBySOID(SOID).AsNoTracking();
            var result = from outboundRow in outboundRows
                         join con in _SMOWMSDbContext.Consumableses on outboundRow.CID equals con.CID
                         select new ConSalesOrderOutboundOutputDto()
                         {
                             SOID = outboundRow.SOID,
                             SOROWID = outboundRow.SOROWID,
                             CID = outboundRow.CID,
                             NAME = con.NAME,
                             IMAGE = con.IMAGE,
                             QUANTSALED = outboundRow.QUANTSALED - outboundRow.QUANTOUT,
                         };
            return result.Where(x => x.QUANTSALED > 0).AsNoTracking().ToList();
        }
        /// <summary>
        /// 销售分析
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public Dictionary<string, decimal> GetSaleAnalyze(DateTime startDate, DateTime endDate)
        {
            List<ConSalesOrderRow> orderRows = _ConSalesOrderRowReposity.GetAll().
                Where(x => (x.STATUS == 1 || x.STATUS == 2) && x.CREATEDATE >= startDate 
                && x.CREATEDATE <= endDate).ToList();
            var Data = from orderRow in orderRows
                       join con in _SMOWMSDbContext.Consumableses on orderRow.CID equals con.CID
                       select new ConSalesOrderRowInputDto()
                       {
                           CID = orderRow.CID,
                           NAME = con.NAME,
                           QUANTOUT = orderRow.QUANTOUT
                       };
            Dictionary<string, decimal> result = new Dictionary<string, decimal>();
            foreach (ConSalesOrderRowInputDto row in Data)
            {
                if (result.Keys.Contains(row.NAME))
                {
                    result[row.NAME] = result[row.NAME] + row.QUANTOUT;
                }
                else
                {
                    result.Add(row.NAME, row.QUANTOUT);
                }
            }
            return result;
        }
        /// <summary>
        /// 客户销售量分析
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, Dictionary<string, decimal>> GetCustomerAnalyze(DateTime startDate,
            DateTime endDate)
        {
            List<ConSalesOrderRow> orderRows = _ConSalesOrderRowReposity.GetAll()
                .Where(x => (x.STATUS == 1 || x.STATUS == 2) && x.CREATEDATE >= startDate 
                && x.CREATEDATE <= endDate).ToList();
            var Data = from orderRow in orderRows
                       join con in _SMOWMSDbContext.Consumableses on orderRow.CID equals con.CID
                       join order in _SMOWMSDbContext.ConSalesOrders on orderRow.SOID equals order.SOID
                       join customer in _SMOWMSDbContext.Customers on order.CUSID equals customer.CUSID
                       select new ConSalesOrderRowInputDto()
                       {
                           CID = orderRow.CID,
                           NAME = con.NAME,
                           CUSID = order.CUSID,
                           CUSTOMERNAME = customer.NAME,
                           QUANTOUT = orderRow.QUANTOUT
                       };
            Dictionary<string, Dictionary<string, decimal>> result = new Dictionary<string, Dictionary<string, decimal>>();
            foreach (ConSalesOrderRowInputDto row in Data)
            {
                if (result.Keys.Contains(row.CUSTOMERNAME))
                {
                    if (result[row.CUSTOMERNAME].Keys.Contains(row.NAME))
                    {
                        result[row.CUSTOMERNAME][row.NAME] = result[row.CUSTOMERNAME][row.NAME] + row.QUANTOUT;
                    }
                    else
                    {
                        result[row.CUSTOMERNAME].Add(row.NAME, row.QUANTOUT);
                    }
                }
                else
                {
                    Dictionary<string, decimal> rowQuant = new Dictionary<string, decimal>();
                    rowQuant.Add(row.NAME, row.QUANTOUT);
                    result.Add(row.CUSTOMERNAME, rowQuant);
                }
            }
            return result;
        }
        /// <summary>
        /// 得到对应销售单下可退货行项
        /// </summary>
        /// <param name="SOID"></param>
        /// <returns></returns>
        public List<ConSalesOrderRowInputDto> GetRetRowsBySOID(string SOID)
        {
            var outRows = _ConSalesOrderRowReposity.GetBySOID(SOID).Where(x => 
            x.QUANTOUT - x.QUANTRETREATED > 0).AsNoTracking();
            var result = from Row in outRows
                         join Con in _SMOWMSDbContext.Consumableses on Row.CID equals Con.CID
                         select new ConSalesOrderRowInputDto()
                         {
                             CID = Row.CID,
                             SOROWID = Row.SOROWID,
                             NAME = Con.NAME,
                             IMAGE = Con.IMAGE,
                             SPECIFICATION = Con.SPECIFICATION,
                             REALPRICE = Row.REALPRICE,
                             QUANTSALED = Row.QUANTSALED,
                             QUANTOUT = Row.QUANTOUT - Row.QUANTRETREATED,
                         };
            return result.AsNoTracking().ToList();
        }
        /// <summary>
        /// 根据销售单号和耗材编号获取采购行项信息
        /// </summary>
        /// <param name="SOID"></param>
        /// <param name="CID"></param>
        /// <returns></returns>
        public ConSalesOrderRowInputDto GetOrderRowByCID(string SOID, string CID)
        {
            var firstRow = _ConSalesOrderRowReposity.GetOrderRowByCID(SOID, CID).AsNoTracking();
            var result = from Row in firstRow
                         join Con in _SMOWMSDbContext.Consumableses on Row.CID equals Con.CID
                         select new ConSalesOrderRowInputDto()
                         {
                             CID = Row.CID,
                             NAME = Con.NAME,
                             IMAGE = Con.IMAGE,
                             SPECIFICATION = Con.SPECIFICATION,
                             REALPRICE = Row.REALPRICE,
                             QUANTSALED = Row.QUANTSALED,
                             QUANTOUT = Row.QUANTOUT,
                             QUANTRETREATED = Row.QUANTRETREATED
                         };
            return result.AsNoTracking().FirstOrDefault();
        }
        /// <summary>
        /// 获取对应销售单下相应状态的行项信息
        /// </summary>
        /// <param name="SOID"></param>
        /// <param name="Status"></param>
        /// <returns></returns>
        public List<ConSalesOrderRowInputDto> GetOrderRowsByStatus(string SOID, SalesOrderStatus Status)
        {
            var Rows = _ConSalesOrderRowReposity.GetOrderRowsByStatus(SOID, (int)Status).AsNoTracking();
            var result = from Row in Rows
                         join Cons in _SMOWMSDbContext.Consumableses on Row.CID equals Cons.CID
                         select new ConSalesOrderRowInputDto()
                         {
                             CID = Row.CID,
                             NAME = Cons.NAME,
                             IMAGE = Cons.IMAGE,
                             SPECIFICATION = Cons.SPECIFICATION,
                             REALPRICE = Row.REALPRICE,
                             QUANTSALED = Row.QUANTSALED,
                             QUANTOUT = Row.QUANTOUT,
                             QUANTRETREATED = Row.QUANTRETREATED
                         };
            return result.AsNoTracking().ToList();
        }
        #endregion
        #region 操作
        /// <summary>
        /// 创建销售单
        /// </summary>
        /// <param name="inputDto"></param>
        /// <returns></returns>
        public ReturnInfo AddSalesOrder(ConSalesOrderInputDto inputDto)
        {
            ReturnInfo RInfo = new ReturnInfo();
            if (string.IsNullOrEmpty(inputDto.NAME)) throw new Exception("销售单名称不能为空!");
            if (string.IsNullOrEmpty(inputDto.SALESPERSON)) throw new Exception("请选择销售人!");
            String MaxID = _ConSalesOrderReposity.GetMaxID();       //获取最大采购单ID
            String NowID = Helper.GenerateID("SO", MaxID);
            //产生销售单编号
            inputDto.SOID = NowID;
            try
            {
                ConSalesOrder salesOrder = new ConSalesOrder();
                salesOrder = Mapper.Map<ConSalesOrderInputDto, ConSalesOrder>(inputDto);
                salesOrder.STATUS = 0;
                _unitOfWork.RegisterNew(salesOrder);

                foreach (var Row in inputDto.RowData)
                {
                    ConSalesOrderRow salesOrderRow = new ConSalesOrderRow();
                    salesOrderRow = Mapper.Map<ConSalesOrderRowInputDto, ConSalesOrderRow>(Row);
                    salesOrderRow.SOID = NowID;
                    salesOrderRow.CREATEUSER = inputDto.CREATEUSER;
                    salesOrderRow.CREATEDATE = DateTime.Now;
                    salesOrderRow.MODIFYUSER = inputDto.MODIFYUSER;
                    salesOrderRow.MODIFYDATE = DateTime.Now;
                    salesOrderRow.STATUS = 0;
                    _unitOfWork.RegisterNew(salesOrderRow);
                }
                bool result = _unitOfWork.Commit();
                RInfo.IsSuccess = result;
                RInfo.ErrorInfo = inputDto.SOID;
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
        /// 删除销售单
        /// </summary>
        /// <param name="SOID"></param>
        /// <returns></returns>
        public ReturnInfo DeleteSalesOrder(string SOID)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            ConSalesOrder Order = _ConSalesOrderReposity.GetById(SOID).FirstOrDefault();
            if (Order == null)
            {
                sb.Append("未找到该销售单!");
                RInfo.IsSuccess = false;
                RInfo.ErrorInfo = sb.ToString();
                return RInfo;
            }
            else
            {
                ///根据销售单状态进行操作
                if (Order.STATUS == (int)SalesOrderStatus.销售中)
                {
                    _unitOfWork.RegisterDeleted(Order);

                    List<ConSalesOrderRow> Rows = _ConSalesOrderRowReposity.GetBySOID(SOID).ToList();
                    if (Rows.Count > 0)    //如果存在行项
                    {
                        foreach (ConSalesOrderRow Row in Rows)
                        {
                            _unitOfWork.RegisterDeleted(Row);
                        }
                    }
                    //可以删除
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
        /// 更新采购单
        /// </summary>
        /// <param name="inputDto"></param>
        /// <returns></returns>
        public ReturnInfo UpdateSalesOrder(ConSalesOrderInputDto inputDto)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            ConSalesOrder Order = _ConSalesOrderReposity.GetById(inputDto.SOID).FirstOrDefault();
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
                Order.CUSID = inputDto.CUSID;
                Order.SALESPERSON = inputDto.SALESPERSON;
                Order.MODIFYDATE = inputDto.MODIFYDATE;
                Order.MODIFYUSER = inputDto.MODIFYUSER;
                _unitOfWork.RegisterDirty(Order);

                //如果原来存在行项,则先删除
                List<ConSalesOrderRow> Rows = _ConSalesOrderRowReposity.GetBySOID(inputDto.SOID).ToList();
                if (Rows.Count > 0)    //如果存在行项
                {
                    foreach (ConSalesOrderRow Row in Rows)
                    {
                        _unitOfWork.RegisterDeleted(Row);
                    }
                }
                ///添加新的选择行项
                foreach (ConSalesOrderRowInputDto Row in inputDto.RowData)
                {
                    ConSalesOrderRow salesOrderRow = new ConSalesOrderRow();
                    salesOrderRow = Mapper.Map<ConSalesOrderRowInputDto, ConSalesOrderRow>(Row);
                    salesOrderRow.SOID = inputDto.SOID;
                    salesOrderRow.CREATEUSER = inputDto.CREATEUSER;
                    salesOrderRow.CREATEDATE = DateTime.Now;
                    salesOrderRow.MODIFYUSER = inputDto.MODIFYUSER;
                    salesOrderRow.MODIFYDATE = DateTime.Now;
                    salesOrderRow.STATUS = 0;
                    _unitOfWork.RegisterNew(salesOrderRow);
                }
                try
                {
                    _unitOfWork.Commit();
                    RInfo.IsSuccess = true;
                    return RInfo;
                }
                catch (Exception ex)
                {
                    sb.Append(ex.Message);
                    RInfo.IsSuccess = false;
                    RInfo.ErrorInfo = sb.ToString();
                    return RInfo;
                }
            }
        }

        /// <summary>
        /// 耗材销售单出库
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public ReturnInfo OutboundConSalesOrder(ConSOOutboundInputDto entity)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            int thisOver = 0;    //此次完成出库的行项数
            foreach (ConSalesOrderRowInputDto Row in entity.RowDatas)
            {
                decimal quantSum = _ConQuantRepository.GetSumByCID(Row.CID);
                if (quantSum < Row.QUANTOUT) throw new Exception("耗材" + Row.CID + "库存不足,请先补充库存!");
                List<ConQuant> conQuantList = _ConQuantRepository.GetQuantByCID(Row.CID).ToList();
                decimal quantOut = Row.QUANTOUT;
                while (quantOut > 0)
                {
                    foreach (ConQuant conQuant in conQuantList)
                    {
                        ConSalesOrderOutbound outbound = new ConSalesOrderOutbound();
                        outbound.SOID = entity.SOID;
                        outbound.SOROWID = Row.SOROWID;
                        outbound.WAREID = conQuant.WAREID;
                        outbound.STID = conQuant.STID;
                        outbound.SLID = conQuant.SLID;
                        if (conQuant.QUANTITY > quantOut)
                        {
                            conQuant.QUANTITY = conQuant.QUANTITY - quantOut;
                            _unitOfWork.RegisterDirty(conQuant);
                            outbound.QUANT = quantOut;
                            quantOut = 0;
                            _unitOfWork.RegisterNew(outbound);
                            break;
                        }
                        else if (conQuant.QUANTITY == quantOut)
                        {
                            outbound.QUANT = quantOut;
                            _unitOfWork.RegisterDeleted(conQuant);
                            quantOut = 0;
                            _unitOfWork.RegisterNew(outbound);
                            break;
                        }
                        else
                        {
                            outbound.QUANT = conQuant.QUANTITY;
                            quantOut = quantOut - conQuant.QUANTITY;
                            _unitOfWork.RegisterDeleted(conQuant);
                            _unitOfWork.RegisterNew(outbound);
                        }
                    }
                }

                ConSalesOrderRow orderRow = _ConSalesOrderRowReposity.GetOrderRowByCID(entity.SOID, Row.CID).FirstOrDefault();
                orderRow.QUANTOUT = orderRow.QUANTOUT + Row.QUANTOUT;
                orderRow.STATUS = (int)SalesOrderStatus.出库中;
                if (orderRow.QUANTOUT == orderRow.QUANTSALED)
                {
                    orderRow.STATUS = (int)PurchaseOrderStatus.已完成;
                    thisOver += 1;
                }
                if (orderRow.QUANTOUT > orderRow.QUANTSALED) throw new Exception("出库数量不可大于实际销售数量!");
                _unitOfWork.RegisterDirty(orderRow);
            }

            ConSalesOrder conSalesOrder = _ConSalesOrderReposity.GetById(entity.SOID).AsNoTracking().FirstOrDefault();
            int allRowsCount = _ConSalesOrderRowReposity.GetBySOID(entity.SOID).ToList().Count;
            int hasOverCount = _ConSalesOrderRowReposity.GetOrderRowsByStatus(entity.SOID, (int)PurchaseOrderStatus.已完成).ToList().Count;
            if (allRowsCount == hasOverCount + thisOver)
            {
                conSalesOrder.STATUS = (int)PurchaseOrderStatus.已完成;
            }
            else
            {
                conSalesOrder.STATUS = (int)PurchaseOrderStatus.入库中;
            }
            _unitOfWork.RegisterDirty(conSalesOrder);
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
        /// 耗材销售单退货
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public ReturnInfo RetConSalesOrder(ConSOOutboundInputDto entity)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            foreach (ConSalesOrderRowInputDto Row in entity.RowDatas)
            {
                //新增退库行项
                List<ConSalesOrderOutbound> orderOutList = _ConSalesOrderOutboundReposity.GetBySOIDAndSOROWID(entity.SOID, Row.SOROWID).AsNoTracking().ToList();
                ConSalesOrderRow orderRow = _ConSalesOrderRowReposity.GetOrderRowByCID(entity.SOID, Row.CID).FirstOrDefault();
                decimal hasRet = orderRow.QUANTRETREATED;   //已经退货数
                decimal waitRet = Row.QUANTRETREATED;        //等待退货数
                foreach (ConSalesOrderOutbound orderOut in orderOutList)
                {
                    if (waitRet > 0)
                    {
                        if (hasRet >= orderOut.QUANT)
                        {
                            hasRet -= orderOut.QUANT;
                        }
                        else
                        {
                            //新增退库单数据
                            decimal canRetNum = orderOut.QUANT - hasRet;    //此行项可退库数量
                            ConSalesOrderRetiring orderRetiring = _ConSalesOrderRetiringReposity.GetBySOIDAndWareID(entity.SOID, Row.SOROWID, orderOut.WAREID, orderOut.STID, orderOut.SLID).FirstOrDefault();
                            if (orderRetiring == null)
                            {
                                ConSalesOrderRetiring orderNewRetiring = new ConSalesOrderRetiring();
                                orderNewRetiring.SOID = entity.SOID;
                                orderNewRetiring.SOROWID = Row.SOROWID;
                                orderNewRetiring.WAREID = orderOut.WAREID;
                                orderNewRetiring.STID = orderOut.STID;
                                orderNewRetiring.SLID = orderOut.SLID;
                                if (waitRet > canRetNum)
                                {
                                    waitRet -= canRetNum;
                                    orderNewRetiring.QUANT = canRetNum;
                                }
                                else
                                {
                                    orderNewRetiring.QUANT = waitRet;
                                    waitRet = 0;
                                }
                                _unitOfWork.RegisterNew(orderNewRetiring);
                                //新增或者修改ConQuant数据
                                ConQuant conQuant = _ConQuantRepository.GetByCID(Row.CID, orderNewRetiring.WAREID, orderNewRetiring.STID, orderNewRetiring.SLID).FirstOrDefault();
                                if (conQuant == null)  //当前库位不存在库存，则新增
                                {
                                    ConQuant newQuant = new ConQuant();
                                    newQuant.CID = Row.CID;
                                    newQuant.WAREID = orderNewRetiring.WAREID;
                                    newQuant.STID = orderNewRetiring.STID;
                                    newQuant.SLID = orderNewRetiring.SLID;
                                    newQuant.QUANTITY = orderNewRetiring.QUANT;
                                    newQuant.CREATEUSER = entity.CREATEUSER;
                                    newQuant.CREATEDATE = DateTime.Now;
                                    newQuant.MODIFYUSER = entity.CREATEUSER;
                                    newQuant.MODIFYDATE = DateTime.Now;
                                    _unitOfWork.RegisterNew(newQuant);
                                }
                                else          //当前库位存在库存，则添加数量
                                {
                                    conQuant.QUANTITY += orderNewRetiring.QUANT;
                                    _unitOfWork.RegisterDirty(conQuant);
                                }
                                hasRet -= orderNewRetiring.QUANT;
                            }
                            else
                            {
                                decimal retNumThisTime = 0;
                                if (waitRet > canRetNum)
                                {
                                    waitRet -= canRetNum;
                                    retNumThisTime = canRetNum;
                                    orderRetiring.QUANT = orderRetiring.QUANT + canRetNum;
                                }
                                else
                                {
                                    orderRetiring.QUANT = orderRetiring.QUANT + waitRet;
                                    retNumThisTime = waitRet;
                                    waitRet = 0;
                                }
                                _unitOfWork.RegisterDirty(orderRetiring);
                                //新增或者修改ConQuant数据
                                ConQuant conQuant = _ConQuantRepository.GetByCID(Row.CID, orderRetiring.WAREID, orderRetiring.STID, orderRetiring.SLID).FirstOrDefault();
                                if (conQuant == null)  //当前库位不存在库存，则新增
                                {
                                    ConQuant newQuant = new ConQuant();
                                    newQuant.CID = Row.CID;
                                    newQuant.WAREID = orderRetiring.WAREID;
                                    newQuant.STID = orderRetiring.STID;
                                    newQuant.SLID = orderRetiring.SLID;
                                    newQuant.QUANTITY = retNumThisTime;
                                    newQuant.CREATEUSER = entity.CREATEUSER;
                                    newQuant.CREATEDATE = DateTime.Now;
                                    newQuant.MODIFYUSER = entity.CREATEUSER;
                                    newQuant.MODIFYDATE = DateTime.Now;
                                    _unitOfWork.RegisterNew(newQuant);
                                }
                                else          //当前库位存在库存，则添加数量
                                {
                                    conQuant.QUANTITY += retNumThisTime;
                                    _unitOfWork.RegisterDirty(conQuant);
                                }
                                hasRet -= retNumThisTime;
                            }
                        }
                    }
                }

                //修改OrderRow行项表退库数量
                ConSalesOrderRow conSalesOrderRow = _ConSalesOrderRowReposity.GetOrderRowByCID(entity.SOID, Row.CID).FirstOrDefault();
                conSalesOrderRow.QUANTRETREATED = conSalesOrderRow.QUANTRETREATED + Row.QUANTRETREATED;
                if (conSalesOrderRow.QUANTRETREATED > conSalesOrderRow.QUANTOUT)
                {
                    throw new Exception("退货数量不能大于出库数量!");
                }
                _unitOfWork.RegisterDirty(conSalesOrderRow);
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
