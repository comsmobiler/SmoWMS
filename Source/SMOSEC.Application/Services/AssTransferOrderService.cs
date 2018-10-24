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
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SMOWMS.Application.Services
{
    /// <summary>
    /// 调拨单的接口实现
    /// </summary>
    public class AssTransferOrderService : IAssTransferOrderService
    {
        /// <summary>
        /// 工作单元的接口
        /// </summary>
        private IUnitOfWork _unitOfWork;
        /// <summary>
        /// 库存管理的查询接口
        /// </summary>
        private IConQuantRepository _ConQuantRepository;
        /// <summary>
        /// 调拨单的查询接口
        /// </summary>
        private IAssTransferOrderRepository _AssTransferOrderRepository;
        /// <summary>
        /// 调拨单行项的查询接口
        /// </summary>
        private IAssTransferOrderRowRepository _AssTransferOrderRowRepository;
        /// <summary>
        /// 资产的查询接口
        /// </summary>
        private IAssetsRepository _AssetsRepository;
        /// <summary>
        /// 处理记录的查询接口
        /// </summary>
        private IAssProcessRecordRepository _AssProcessRecordRepository;
        /// <summary>
        /// 数据库上下文
        /// </summary>
        private SMOWMSDbContext SMOWMSDbContext;

        /// <summary>
        /// 成本中心服务实现的构造函数
        /// </summary>
        public AssTransferOrderService(IUnitOfWork unitOfWork,
            IAssTransferOrderRepository AssTransferOrderRepository,
            IAssTransferOrderRowRepository AssTransferOrderRowRepository,
            IConQuantRepository ConQuantRepository,
            IAssetsRepository AssetsRepository,
            IcoreUserRepository coreUserRepository,
            IAssProcessRecordRepository AssProcessRecordRepository,
            IDbContext dbContext)
        {
            _unitOfWork = unitOfWork;
            _AssTransferOrderRepository = AssTransferOrderRepository;
            _AssTransferOrderRowRepository = AssTransferOrderRowRepository;
            _ConQuantRepository = ConQuantRepository;
            _AssetsRepository = AssetsRepository;
            _AssProcessRecordRepository = AssProcessRecordRepository;
            SMOWMSDbContext = (SMOWMSDbContext)dbContext;
        }
        #region 查询
        /// <summary>
        /// 根据用户编号和调拨类型返回调拨单信息
        /// </summary>
        /// <param name="UserID"></param>
        /// <returns></returns>
        public List<AssTransferOrderOutputDto> GetByUser(String UserID, OperateType type)
        {
            List<AssTransferOrderOutputDto> result = new List<AssTransferOrderOutputDto>();
            List<AssTransferOrder> data= _AssTransferOrderRepository.GetByUser(UserID, (int)type).AsNoTracking().ToList();
            foreach(AssTransferOrder row in data)
            {
                AssTransferOrderOutputDto resultRow = new AssTransferOrderOutputDto();
                resultRow.TOID = row.TOID;
                resultRow.NOTE = row.NOTE;
                resultRow.CREATEDATE = string.Format("{0:yyyy.MM.dd}", row.TRANSFERDATE);
                result.Add(resultRow);
            }
            return result;
        }
        /// <summary>
        /// 根据调拨单编号返回调拨单信息
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public TOInputDto GetByID(string ID)
        {
            TOInputDto ro = Mapper.Map<AssTransferOrder, TOInputDto>(_AssTransferOrderRepository.GetByID(ID).AsNoTracking().FirstOrDefault());
            ro.Rows = _AssTransferOrderRowRepository.GetByTOID(ID).AsNoTracking().ToList();
            return ro;
        }
        /// <summary>
        /// 根据调拨行项编号返回调拨单行项信息
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public AssTransferOrderRow GetRowByRowID(String TOID, String TOROWID)
        {
            return _AssTransferOrderRowRepository.GetByID(TOID, TOROWID).AsNoTracking().FirstOrDefault();
        }
        #endregion

        #region 操作
        /// <summary>
        /// 新增调拨单
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public ReturnInfo AddAssTransferOrder(TOInputDto entity, OperateType type)
        {
            ReturnInfo RInfo = new ReturnInfo();
            if (String.IsNullOrEmpty(entity.MANAGER)) throw new Exception("调入管理员不能为空");
            if (String.IsNullOrEmpty(entity.HANDLEMAN)) throw new Exception("处理人不能为空");
            if (String.IsNullOrEmpty(entity.TRANSFERDATE.ToString())) throw new Exception("业务日期不能为空");
            if (String.IsNullOrEmpty(entity.DESSLID)) throw new Exception("调入区域不能为空");
            String MaxID = _AssTransferOrderRepository.GetMaxID();        //获取当前最大报修单编号
            String NowID = Helper.GeneratePRID("T", MaxID);                //生成最新的报修单编号
            entity.TOID = NowID;
            try
            {
                AssTransferOrder OrderData = new AssTransferOrder();
                OrderData.TOID = NowID;
                OrderData.MANAGER = entity.MANAGER;
                OrderData.HANDLEMAN = entity.HANDLEMAN;
                OrderData.TRANSFERDATE = entity.TRANSFERDATE;
                OrderData.WAREID = entity.WAREID;
                OrderData.STID = entity.STID;
                OrderData.DESSLID = entity.DESSLID;
                OrderData.NOTE = entity.NOTE;
                OrderData.TYPE = (int)type;
                OrderData.STATUS = 0;
                OrderData.CREATEDATE = entity.CREATEDATE;
                OrderData.CREATEUSER = entity.CREATEUSER;
                _unitOfWork.RegisterNew(OrderData);
                AddAssTransferOrderRow(entity, type);

                bool result = _unitOfWork.Commit();
                RInfo.IsSuccess = result;
                RInfo.ErrorInfo = "创建成功!";
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
        /// 新增调拨单行项
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public ReturnInfo AddAssTransferOrderRow(TOInputDto entity, OperateType type)
        {
            ReturnInfo RInfo = new ReturnInfo();
            try
            {
                String TOROWID = "0";
                ConQuant assQuant = new ConQuant();
                if (entity.Rows != null)
                {
                    foreach (AssTransferOrderRow Row in entity.Rows)
                    {
                        TOROWID = (int.Parse(TOROWID) + 1).ToString();
                        Row.TOID = entity.TOID;
                        Row.TOROWID = TOROWID;
                        if (GetRowByRowID(Row.TOID, Row.TOROWID) != null)
                            throw new Exception("调拨单行项号已存在!");
                        _unitOfWork.RegisterNew(Row);
                        //往AssProcessRecord表添加数据
                        CreatePR(entity, Row, PROCESSMODE.调拨);

                        if (type == OperateType.资产)
                        {
                            Assets assetsSN = _AssetsRepository.GetByID(Row.ASSID).FirstOrDefault();
                            if (assetsSN == null)
                                throw new Exception("不存在条码为:" + Row.ASSID + "的资产。");
                            assetsSN.STATUS = (Int32)STATUS.调拨中;
                            _unitOfWork.RegisterDirty(assetsSN);
                        }
                        else
                        {
                            ConQuant aq = _ConQuantRepository.GetByCID(Row.CID, Row.WAREID, Row.STID, Row.SLID).FirstOrDefault();
                            if (aq == null) throw new Exception("库存中不存在编号为+" + Row.CID + "的耗材，请检查!");

                            aq.QUANTITY = aq.QUANTITY - Row.INTRANSFERQTY;
                            if (aq.QUANTITY > 0)
                            {
                                //更新数据
                                _unitOfWork.RegisterDirty(aq);
                            }
                            else if (aq.QUANTITY == 0)
                            {
                                _unitOfWork.RegisterDeleted(aq);
                            }
                            else
                            {
                                throw new Exception("所需调拨数量超过库存数!");
                            }
                        }
                    }
                    RInfo.IsSuccess = true;
                    RInfo.ErrorInfo = "调拨单行项创建成功！";
                }
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback();
                RInfo.IsSuccess = false;
                RInfo.ErrorInfo = ex.Message;
            }
            return RInfo;
        }
        /// <summary>
        /// 更新调拨单
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public ReturnInfo UpdateAssTransferOrder(TOInputDto entity, PROCESSMODE ProType, OperateType type)
        {
            ReturnInfo RInfo = new ReturnInfo();
            try
            {
                if (String.IsNullOrEmpty(entity.TOID)) throw new Exception("调拨单编号不能为空");

                AssTransferOrder aro = _AssTransferOrderRepository.GetByID(entity.TOID).FirstOrDefault();
                if (aro != null)
                {
                    if (aro.STATUS == 1 || aro.STATUS == 2)
                    {
                        throw new Exception("只有调拨中的才能确认");
                    }
                    else
                    {
                        List<AssTransferOrderRow> Rows = _AssTransferOrderRowRepository.GetUnTransferTOID(aro.TOID).AsNoTracking().ToList();
                        int doneCount = 0;
                        int cancelCount = 0;
                        foreach (AssTransferOrderRow Row in entity.Rows)     //只要调拨行项中有一个确认，则调拨单属于完成
                        {
                            if (Row.STATUS == 1)
                            {
                                doneCount++;
                            }
                            else if(Row.STATUS==2)
                            {
                                cancelCount++;
                            }
                        }
                        if (Rows.Count == doneCount)
                        {
                            aro.STATUS = 1;
                        }else if (Rows.Count == cancelCount)
                        {
                            aro.STATUS = 2;
                        }
                        //更新报修单行项
                        aro.MODIFYDATE = entity.MODIFYDATE;
                        aro.MODIFYUSER = entity.MODIFYUSER;
                        entity.WAREID = aro.WAREID;
                        entity.STID = aro.STID;
                        entity.DESSLID = aro.DESSLID;
                        _unitOfWork.RegisterDirty(aro);
                        UpdateAssTransferOrderRow(entity, ProType, type);

                        bool result = _unitOfWork.Commit();
                        RInfo.IsSuccess = result;
                        RInfo.ErrorInfo = "修改成功!";
                        return RInfo;
                    }
                }
                else
                {
                    throw new Exception("调拨单不存在!");
                }
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
        /// 更新报修单行项
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public void UpdateAssTransferOrderRow(TOInputDto entity, PROCESSMODE ProType, OperateType type)
        {
            AssTransferOrderRow assROR = new AssTransferOrderRow();
            foreach (AssTransferOrderRow Row in entity.Rows)
            {
                assROR = _AssTransferOrderRowRepository.GetByID(entity.TOID, Row.TOROWID).FirstOrDefault();
                if (assROR == null) throw new Exception("调拨单行项：" + Row.TOROWID + "不存在！");
                switch (ProType)
                {
                    case PROCESSMODE.调拨确认:
                        assROR.INTRANSFERQTY = assROR.INTRANSFERQTY - Convert.ToDecimal(Row.TRANSFEREDQTY);     //确认调拨数量
                        if (Row.INTRANSFERQTY < 0) throw new Exception("确认数量不能超过申请调拨数量!");
                        assROR.TRANSFEREDQTY = Convert.ToDecimal(assROR.TRANSFEREDQTY) + Row.TRANSFEREDQTY;
                        break;
                    case PROCESSMODE.调拨取消:
                        assROR.INTRANSFERQTY = assROR.INTRANSFERQTY - Convert.ToDecimal(Row.TRANSFERCANCELQTY);     //取消调拨数量
                        if (Row.INTRANSFERQTY < 0) throw new Exception("取消数量不能超过申请调拨数量!");
                        assROR.TRANSFERCANCELQTY = Convert.ToDecimal(assROR.TRANSFERCANCELQTY) + Row.TRANSFERCANCELQTY;
                        break;
                }

                if (assROR.INTRANSFERQTY == 0)       //如果全部调拨完毕，则修改行项状态
                {
                    if (ProType == PROCESSMODE.调拨确认)
                        assROR.STATUS = 1;        //调拨完成
                    else
                        assROR.STATUS = 2;        //调拨取消 
                }

                //更新OrderRow数据
                _unitOfWork.RegisterDirty(assROR);

                if (type == OperateType.资产)
                {
                    Assets SNData = _AssetsRepository.GetByID(Row.ASSID).FirstOrDefault();
                    if (ProType == PROCESSMODE.调拨确认)
                    {
                        SNData.WAREID = entity.WAREID;        //调入仓库
                        SNData.STID = entity.STID;            //调入类型
                        SNData.SLID = entity.DESSLID;         //调入库位
                    }
                    //修改AssetsSN表中资产状态
                    SNData.STATUS = (Int32)STATUS.闲置;  //资产状态
                    _unitOfWork.RegisterDirty(SNData);    //更新调拨行项
                }
                else
                {
                    ConQuant assQuant = new ConQuant();
                    //修改Quant表数据
                    assQuant.CID = Row.CID;    //资产条码 
                    if (ProType == PROCESSMODE.调拨确认)
                    {
                        assQuant.QUANTITY = Convert.ToDecimal(Row.TRANSFEREDQTY);        //确认调入数量
                        assQuant.WAREID = entity.WAREID;        //仓库编号
                        assQuant.STID = entity.STID;            //存储类型编号
                        assQuant.SLID = entity.DESSLID;         //库位编号
                    }
                    else
                    {
                        assQuant.QUANTITY = Convert.ToDecimal(Row.TRANSFERCANCELQTY);        //取消调入数量
                        assQuant.WAREID = Row.WAREID;        //仓库编号
                        assQuant.STID = Row.STID;            //存储类型编号
                        assQuant.SLID = Row.SLID;            //库位编号
                    }
                    ConQuant aq = _ConQuantRepository.GetByCID(Row.CID, assQuant.WAREID, assQuant.STID, assQuant.SLID).FirstOrDefault();

                    if (aq == null)     //如果不存在当前库存地数据，则创建一条新数据
                    {
                        assQuant.CREATEDATE = DateTime.Now;
                        assQuant.CREATEUSER = entity.MODIFYUSER;
                        assQuant.MODIFYDATE = DateTime.Now;
                        assQuant.MODIFYUSER = entity.MODIFYUSER;
                        _unitOfWork.RegisterNew(assQuant);
                    }
                    else            //已有数据，修改库存数量
                    {
                        aq.QUANTITY = aq.QUANTITY + assQuant.QUANTITY;
                        _unitOfWork.RegisterDirty(aq);
                    }
                }
                //往AssProcessRecord表添加数据
                CreatePR(entity, Row, ProType);
            }
        }
        /// <summary>
        /// 创建ProcessRecorder表数据
        /// </summary>
        /// <param name="Data"></param>
        /// <param name="RowData"></param>
        /// <param name="Type"></param>
        public void CreatePR(TOInputDto Data, AssTransferOrderRow RowData, PROCESSMODE Type)
        {
            AssProcessRecord assProcessRecord = new AssProcessRecord
            {
                ASSID = RowData.ASSID,          //资产条码
                CID = RowData.CID,              //耗材编号  
                CREATEDATE = DateTime.Now,      //创建时间
                CREATEUSER = Data.CREATEUSER,     //创建用户
                HANDLEDATE = DateTime.Now,      //处理时间
                MODIFYDATE = DateTime.Now,      //修改时间
                MODIFYUSER = Data.MODIFYUSER,     //修改用户
            };
            switch (Type)
            {
                case PROCESSMODE.调拨:
                    assProcessRecord.QUANTITY = RowData.INTRANSFERQTY;
                    assProcessRecord.PROCESSMODE = (Int32)PROCESSMODE.调拨;
                    assProcessRecord.HANDLEMAN = Data.CREATEUSER;
                    break;
                case PROCESSMODE.调拨确认:
                    assProcessRecord.QUANTITY = Convert.ToDecimal(RowData.TRANSFEREDQTY);
                    assProcessRecord.PROCESSMODE = (Int32)PROCESSMODE.调拨确认;
                    assProcessRecord.HANDLEMAN = Data.MODIFYUSER;
                    break;
                case PROCESSMODE.调拨取消:
                    assProcessRecord.QUANTITY = Convert.ToDecimal(RowData.TRANSFERCANCELQTY);
                    assProcessRecord.PROCESSMODE = (Int32)PROCESSMODE.调拨取消;
                    assProcessRecord.HANDLEMAN = Data.MODIFYUSER;
                    break;
            }
            if (String.IsNullOrEmpty(RowData.ASSID) == false)
            {
                switch (Type)         //根据操作模式，输入操作内容
                {
                    case PROCESSMODE.调拨:
                        assProcessRecord.PROCESSCONTENT = Data.CREATEUSER + "调拨了物品编号为" + RowData.ASSID + "的资产";
                        break;
                    case PROCESSMODE.调拨确认:
                        assProcessRecord.PROCESSCONTENT = Data.CREATEUSER + "确认调拨了物品编号为" + RowData.ASSID + "的资产";
                        break;
                    case PROCESSMODE.调拨取消:
                        assProcessRecord.PROCESSCONTENT = Data.CREATEUSER + "取消调拨了物品编号为" + RowData.ASSID + "的资产";
                        break;
                }
            }
            else
            {
                assProcessRecord.CID = RowData.CID;
                switch (Type)         //根据操作模式，输入操作内容
                {
                    case PROCESSMODE.调拨:
                        assProcessRecord.PROCESSCONTENT = Data.CREATEUSER + "调拨了耗材编号为" + RowData.CID + ",数量为" + RowData.INTRANSFERQTY;
                        break;
                    case PROCESSMODE.调拨确认:
                        assProcessRecord.PROCESSCONTENT = Data.CREATEUSER + "确认调拨了耗材编号为" + RowData.CID + ",数量为" + RowData.TRANSFEREDQTY;
                        break;
                    case PROCESSMODE.调拨取消:
                        assProcessRecord.PROCESSCONTENT = Data.CREATEUSER + "取消调拨了耗材编号为" + RowData.CID + ",数量为" + RowData.TRANSFERCANCELQTY;
                        break;
                }
            }
            _unitOfWork.RegisterNew(assProcessRecord);
        }
        #endregion
    }
}
