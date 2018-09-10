using SMOWMS.Application.IServices;
using SMOWMS.Domain.Entity;
using SMOWMS.Domain.IRepository;
using SMOWMS.DTOs.OutputDTO;
using SMOWMS.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using SMOWMS.CommLib;
using SMOWMS.DTOs.InputDTO;
using AutoMapper;
using SMOWMS.DTOs.Enum;

namespace SMOWMS.Application.Services
{
    /// <summary>
    /// 库位的服务接口实现
    /// </summary>
    public class WareHouseService : IWareHouseService
    {
        /// <summary>
        /// 工作单元的接口
        /// </summary>
        private IUnitOfWork _unitOfWork;
        // <summary>
        /// 仓库信息的查询接口
        /// </summary>
        private IWarehouseRepository _warehouseRepository;
        /// <summary>
        /// 存储类型的查询接口
        /// </summary>
        private IWHStorageTypeReposity _wHStorageTypeReposity;
        /// <summary>
        /// 库位信息的查询接口
        /// </summary>
        private IWHStorageLocationRepository _wHStorageLocationRepository;
        /// <summary>
        /// 数据库上下文
        /// </summary>
        private SMOWMSDbContext SMOWMSDbContext;

        /// <summary>
        /// 库位服务实现的构造函数
        /// </summary>
        public WareHouseService(IUnitOfWork unitOfWork,
            IWHStorageLocationRepository wHStorageLocationRepository,
            IWHStorageTypeReposity wHStorageTypeReposity,
            IWarehouseRepository warehouseRepository,
            IDbContext dbContext)
        {
            _unitOfWork = unitOfWork;
            _wHStorageLocationRepository = wHStorageLocationRepository;
            _wHStorageTypeReposity = wHStorageTypeReposity;
            _warehouseRepository = warehouseRepository;
            SMOWMSDbContext = (SMOWMSDbContext)dbContext;
        }
        #region 查询
        /// <summary>
        /// 查询库位信息
        /// </summary>
        /// <param name="WAREID">仓库编号</param>
        /// <param name="STID">类型编号</param>
        /// <param name="SLID">库位编号</param>
        /// <returns></returns>
        public WHStorageLocationOutputDto GetSLByID(string WAREID, string STID, string SLID)
        {
            try
            {
                var whLoc = _wHStorageLocationRepository.GetById(WAREID, STID, SLID).AsNoTracking();
                if (whLoc != null)
                {
                    var result = from loc in whLoc
                                 join WH in SMOWMSDbContext.WareHouses on loc.WAREID equals WH.WAREID
                                 from WHST in SMOWMSDbContext.WHStorageTypes
                                 join user in SMOWMSDbContext.coreUsers on loc.MANAGER equals user.USER_ID
                                 where loc.WAREID==WHST.WAREID&&loc.STID==WHST.STID
                                 select new WHStorageLocationOutputDto()
                                 {
                                     WAREID = loc.WAREID,
                                     WARENAME = WH.NAME,
                                     STID = loc.STID,
                                     STNAME = WHST.NAME,
                                     SLID = loc.SLID,
                                     SLNAME = loc.NAME,
                                     MAXVOLUME = loc.MAXVOLUME,
                                     MAXCAPACITY = loc.MAXCAPACITY,
                                     MANAGER = loc.MANAGER,
                                     MANAGERNAME = user.USER_NAME
                                 };
                    return result.FirstOrDefault();
                }
                else
                {
                    throw new Exception("库位不存在");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 根据仓库编号获取仓库信息
        /// </summary>
        /// <param name="WAREID">仓库编号</param>
        /// <returns></returns>
        public WareHouse GetByWareID(string WAREID)
        {
            return _warehouseRepository.GetById(WAREID).AsNoTracking().FirstOrDefault();
        }

        /// <summary>
        /// 得到所有仓库列表
        /// </summary>
        /// <returns></returns>
        public List<WareHouse> GetAllWareHouse()
        {
            return _warehouseRepository.GetAll().AsNoTracking().ToList();
        }

        /// <summary>
        /// 得到某个仓库下的所有存储类型
        /// </summary>
        /// <param name="WAREID">仓库编号</param>
        /// <returns></returns>
        public List<WHStorageType> GetSTByWareID(string WAREID)
        {
            return _wHStorageTypeReposity.GetByWAREID(WAREID).AsNoTracking().ToList();
        }

        /// <summary>
        /// 根据仓库编号和存储类型编号得到存储类型
        /// </summary>
        /// <param name="WAREID">仓库编号</param>
        /// <param name="STID">存储类型编号</param>
        /// <returns></returns>
        public WHStorageTypeOutputDto GetSTByWareIDandSTID(string WAREID, string STID)
        {
            var result = _wHStorageTypeReposity.GetById(WAREID, STID).AsNoTracking();
            var type = from storageType in result
                       join wareHouse in SMOWMSDbContext.WareHouses on storageType.WAREID equals wareHouse.WAREID
                       select new WHStorageTypeOutputDto()
                       {
                           WAREID = storageType.WAREID,
                           ISENABLE = storageType.ISENABLE,
                           NAME = storageType.NAME,
                           STID = storageType.STID,
                           WARENAME = wareHouse.NAME
                       };
            return type.FirstOrDefault();
        }

        /// <summary>
        /// 得到某个仓库和存储类型下的所有库位
        /// </summary>
        /// <param name="WAREID">仓库编号</param>
        /// <param name="STID">存储类型编号</param>
        /// <returns></returns>
        public List<WHStorageLocation> GetSLByWareIDAndSTID(string WAREID, string STID)
        {
            return _wHStorageLocationRepository.GetByWareIdAndSTID(WAREID, STID).AsNoTracking().ToList();
        }

        /// <summary>
        /// 盘点库位是否存在
        /// </summary>
        /// <param name="WAREID">仓库编号</param>
        /// <param name="STID">存储类型编号</param>
        /// <param name="SLID">库位编号</param>
        /// <returns></returns>
        public bool SLIsExists(string WAREID, string STID, string SLID)
        {

            return _wHStorageLocationRepository.IsExist(WAREID, STID, SLID);
        }

        #endregion


        #region 操作
        /// <summary>
        /// 添加仓库
        /// </summary>
        /// <param name="inputDto">仓库信息</param>
        /// <returns></returns>
        public ReturnInfo AddWareHouse(WareHouseInputDto inputDto)
        {
            //验证
            ReturnInfo rInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            sb.Append(Helper.BasicValidate(inputDto).ToString());
            if (sb.Length == 0)
            {
                bool isExist = _warehouseRepository.IsExist(inputDto.WAREID);
                if (isExist)
                {
                    rInfo.IsSuccess = false;
                    rInfo.ErrorInfo = "已经存在！";
                    return rInfo;
                }
                var wareHouse = Mapper.Map<WareHouseInputDto, WareHouse>(inputDto);
                wareHouse.CREATEDATE = DateTime.Now;
                wareHouse.MODIFYDATE = DateTime.Now;
                try
                {
                    _unitOfWork.RegisterNew(wareHouse);


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
        /// 更新仓库
        /// </summary>
        /// <param name="inputDto">仓库信息</param>
        /// <returns></returns>
        public ReturnInfo UpdateWareHouse(WareHouseInputDto inputDto)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            string ValidateInfo = Helper.BasicValidate(inputDto).ToString();
            sb.Append(ValidateInfo);
            if (sb.Length == 0)
            {
                try
                {
                    WareHouse wareHouse = _warehouseRepository.GetById(inputDto.WAREID).FirstOrDefault();
                    if (wareHouse != null)
                    {
                        wareHouse.NAME = inputDto.NAME;
                        wareHouse.ISENABLE = inputDto.ISENABLE;
                        wareHouse.MANAGER = inputDto.MANAGER;
                        wareHouse.PLACE = inputDto.PLACE;
                        wareHouse.MODIFYUSER = inputDto.MODIFYUSER;
                        wareHouse.MODIFYDATE = DateTime.Now;
                        _unitOfWork.RegisterDirty(wareHouse);
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
        /// 添加存储类型
        /// </summary>
        /// <param name="inputDto">存储类型信息</param>
        /// <returns></returns>
        public ReturnInfo AddWhStorageType(WHStorageTypeInputDto inputDto)
        {
            //验证
            ReturnInfo rInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            sb.Append(Helper.BasicValidate(inputDto).ToString());
            if (sb.Length == 0)
            {
                bool isExist = _wHStorageTypeReposity.IsExist(inputDto.WAREID, inputDto.STID);
                if (isExist)
                {
                    rInfo.IsSuccess = false;
                    rInfo.ErrorInfo = "已经存在！";
                    return rInfo;
                }
                var whStorageType = Mapper.Map<WHStorageTypeInputDto, WHStorageType>(inputDto);
                whStorageType.CREATEDATE = DateTime.Now;
                whStorageType.MODIFYDATE = DateTime.Now;
                try
                {
                    _unitOfWork.RegisterNew(whStorageType);


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
        /// 更新存储类型
        /// </summary>
        /// <param name="inputDto">存储类型信息</param>
        /// <returns></returns>
        public ReturnInfo UpdateWhStorageType(WHStorageTypeInputDto inputDto)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            string ValidateInfo = Helper.BasicValidate(inputDto).ToString();
            sb.Append(ValidateInfo);
            if (sb.Length == 0)
            {
                try
                {
                    WHStorageType whStorageType = _wHStorageTypeReposity.GetById(inputDto.WAREID, inputDto.STID).FirstOrDefault();
                    if (whStorageType != null)
                    {
                        whStorageType.NAME = inputDto.NAME;
                        whStorageType.ISENABLE = inputDto.ISENABLE;
                        whStorageType.MODIFYUSER = inputDto.MODIFYUSER;
                        whStorageType.MODIFYDATE = DateTime.Now;
                        _unitOfWork.RegisterDirty(whStorageType);
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
        /// 添加库位信息
        /// </summary>
        /// <param name="inputDto">库位信息</param>
        /// <returns></returns>
        public ReturnInfo AddWhStorageLocation(WHStorageLocationInputDto inputDto)
        {
            //验证
            ReturnInfo rInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            sb.Append(Helper.BasicValidate(inputDto).ToString());
            if (sb.Length == 0)
            {
                bool isExist = _wHStorageLocationRepository.IsExist(inputDto.WAREID, inputDto.STID, inputDto.SLID);
                if (isExist)
                {
                    rInfo.IsSuccess = false;
                    rInfo.ErrorInfo = "已经存在！";
                    return rInfo;
                }
                var whStorageLocation = Mapper.Map<WHStorageLocationInputDto, WHStorageLocation>(inputDto);
                whStorageLocation.CREATEDATE = DateTime.Now;
                whStorageLocation.MODIFYDATE = DateTime.Now;
                try
                {
                    _unitOfWork.RegisterNew(whStorageLocation);


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
        /// 更新库位
        /// </summary>
        /// <param name="inputDto">库位信息</param>
        /// <returns></returns>
        public ReturnInfo UpdateWhStorageLocation(WHStorageLocationInputDto inputDto)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            string ValidateInfo = Helper.BasicValidate(inputDto).ToString();
            sb.Append(ValidateInfo);
            if (sb.Length == 0)
            {
                try
                {
                    WHStorageLocation wareHouse = _wHStorageLocationRepository.GetById(inputDto.WAREID, inputDto.STID, inputDto.SLID).FirstOrDefault();
                    if (wareHouse != null)
                    {
                        wareHouse.NAME = inputDto.NAME;
                        wareHouse.MAXVOLUME = inputDto.MAXVOLUME;
                        wareHouse.MAXCAPACITY = inputDto.MAXCAPACITY;
                        wareHouse.MANAGER = inputDto.MANAGER;
                        wareHouse.MODIFYUSER = inputDto.MODIFYUSER;
                        wareHouse.MODIFYDATE = DateTime.Now;
                        _unitOfWork.RegisterDirty(wareHouse);
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
        /// 启用/禁用:仓库/存储类型/库位
        /// </summary>
        /// <param name="wareId"></param>
        /// <param name="stId"></param>
        /// <returns></returns>
        public ReturnInfo ChangeEnable(string wareId, string stId, string SlId, IsEnable isEnable)
        {
            ReturnInfo RInfo = new ReturnInfo();
            // 启用/禁用库位
            if (!String.IsNullOrEmpty(wareId) && !String.IsNullOrEmpty(stId) && !String.IsNullOrEmpty(SlId))
            {
                WHStorageLocation wHStorageLocation = _wHStorageLocationRepository.GetById(wareId, stId, SlId).FirstOrDefault();
                if (wHStorageLocation != null)
                {
                    if (wHStorageLocation.ISENABLE == (int)isEnable && isEnable == IsEnable.启用)
                    {
                        throw new Exception("该库位已启用，不可重复启用");
                    }
                    else if (wHStorageLocation.ISENABLE == (int)isEnable && isEnable == IsEnable.禁用)
                    {
                        throw new Exception("该库位已禁用，不可重复禁用");
                    }
                    wHStorageLocation.ISENABLE = (int)isEnable;
                }
                else
                {
                    throw new Exception("当前库位不存在");
                }
            }
            // 启用/禁用存储类型
            else if (!String.IsNullOrEmpty(wareId) && !String.IsNullOrEmpty(stId))
            {
                WHStorageType wHStorageType = _wHStorageTypeReposity.GetById(wareId, stId).FirstOrDefault();
                if (wHStorageType != null)
                {
                    if (wHStorageType.ISENABLE == (int)isEnable && isEnable == IsEnable.启用)
                    {
                        throw new Exception("该存储类型已启用，不可重复启用");
                    }
                    else if (wHStorageType.ISENABLE == (int)isEnable && isEnable == IsEnable.禁用)
                    {
                        throw new Exception("该存储类型已禁用，不可重复禁用");
                    }
                    wHStorageType.ISENABLE = (int)isEnable;
                }
                else
                {
                    throw new Exception("当前存储类型不存在");
                }
            }
            else      // 启用/禁用仓库
            {
                WareHouse wareHouse = _warehouseRepository.GetById(wareId).FirstOrDefault();
                if (wareHouse != null)
                {
                    if (wareHouse.ISENABLE == (int)isEnable && isEnable == IsEnable.启用)
                    {
                        throw new Exception("该仓库已启用，不可重复启用");
                    }
                    else if (wareHouse.ISENABLE == (int)isEnable && isEnable == IsEnable.禁用)
                    {
                        throw new Exception("该仓库已禁用，不可重复禁用");
                    }
                    wareHouse.ISENABLE = (int)isEnable;
                }
                else
                {
                    throw new Exception("当前仓库不穿在");
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
                RInfo.IsSuccess = false;
                RInfo.ErrorInfo = ex.Message;
                return RInfo;
            }
        }
        #endregion
    }
}
