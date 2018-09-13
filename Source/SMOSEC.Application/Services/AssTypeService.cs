using System.Collections.Generic;
using SMOWMS.Application.IServices;
using SMOWMS.CommLib;
using SMOWMS.Domain.Entity;
using SMOWMS.Infrastructure;
using SMOWMS.Domain.IRepository;
using System;
using AutoMapper;
using System.Data.Entity;
using System.Linq;
using SMOWMS.DTOs.Enum;

namespace SMOWMS.Application.Services
{
    /// <summary>
    /// 资产类别的接口实现
    /// </summary>
    public class AssTypeService : IAssTypeService
    {
        /// <summary>
        /// 工作单元的接口
        /// </summary>
        private IUnitOfWork _unitOfWork;
        /// <summary>
        /// 资产类别的查询接口
        /// </summary>
        private IAssetsTypeRepository _AssetsTypeRepository;
        /// <summary>
        /// 固定资产的查询接口
        /// </summary>
        private IAssetsRepository _AssetsRepository;
        /// <summary>
        /// 数据库上下文
        /// </summary>
        private SMOWMSDbContext SMOWMSDbContext;

        /// <summary>
        /// 成本中心服务实现的构造函数
        /// </summary>
        public AssTypeService(IUnitOfWork unitOfWork,
            IAssetsTypeRepository AssetsTypeRepository,
            IAssetsRepository AssetsRepository,
            IDbContext dbContext)
        {
            _unitOfWork = unitOfWork;
            _AssetsTypeRepository = AssetsTypeRepository;
            _AssetsRepository = AssetsRepository;
            SMOWMSDbContext = (SMOWMSDbContext)dbContext;
        }
        #region 查询
        /// <summary>
        /// 返回所有资产类别信息
        /// </summary>
        /// <returns></returns>
        public List<AssetsType> GetAll()
        {
            return _AssetsTypeRepository.GetAll().AsNoTracking().ToList();
        }
        /// <summary>
        /// 根据资产类别编号返回资产类别信息
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public AssetsType GetByID(string ID)
        {
            return _AssetsTypeRepository.GetByID(ID).AsNoTracking().FirstOrDefault();
        }
        /// <summary>
        /// 根据资产级别和父类编号获取资产类别信息
        /// </summary>
        /// <param name="Level"></param>
        /// <param name="parentId"></param>
        /// <returns></returns>
        public List<AssetsType> GetByLevelAndParentId(int Level, String parentId)
        {
            return _AssetsTypeRepository.GetByLevelAndParentId(Level,parentId).AsNoTracking().ToList();
        }
        /// <summary>
        /// 返回所有资产大类信息
        /// </summary>
        /// <returns></returns>
        public List<AssetsType> GetAllFirstLevel()
        {
            return _AssetsTypeRepository.GetAllFirstLevel().AsNoTracking().ToList();
        }
        /// <summary>
        /// 根据资产类别编号判断该资产类别下是否有相关资产
        /// 暂未实现
        /// </summary>
        /// <param name="TypeID"></param>
        /// <returns></returns>
        public bool HasAssets(string TypeID)
        {
            List<Assets> assetss = _AssetsRepository.GetByTypeID(TypeID).AsNoTracking().ToList();
            if (assetss.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 根据编号判断是否为父分类
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Boolean IsParent(String ID)
        {
            List<AssetsType> ats = _AssetsTypeRepository.IsParent(ID).AsNoTracking().ToList();
            if (ats.Count > 0)    //有子类，说明为父类
            {
                return true;    
            }
            else                  //无子类，说明不是父类
            {
                return false;
            }
        }
        #endregion 查询
        #region 操作
        public ReturnInfo AddAssetsType(AssetsType entity)
        {
            ReturnInfo RInfo = new ReturnInfo();
            try
            {
                if (String.IsNullOrEmpty(entity.TYPEID))
                    throw new Exception("分类编号不能为空");
                if (String.IsNullOrEmpty(entity.NAME))
                    throw new Exception("分类名称不能为空");
                if (String.IsNullOrEmpty(entity.EXPIRYDATE.ToString()))
                    throw new Exception("年限不能为空");
                AssetsType at = _AssetsTypeRepository.GetByID(entity.TYPEID).AsNoTracking().FirstOrDefault();
                if (at != null)
                    throw new Exception("该分类编号已存在!");

                _unitOfWork.RegisterNew(entity);
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
        /// 更新资产类别
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public ReturnInfo UpdateAssetsType(AssetsType entity)
        {
            ReturnInfo RInfo = new ReturnInfo();
            try
            {
                if (String.IsNullOrEmpty(entity.TYPEID))
                    throw new Exception("资产类别编号不能为空");
                AssetsType at = _AssetsTypeRepository.GetByID(entity.TYPEID).FirstOrDefault();
                if (at == null)
                    throw new Exception("该分类编号不存在，请检查!");

                at.NAME = entity.NAME;
                at.EXPIRYDATE = entity.EXPIRYDATE;
                _unitOfWork.RegisterDirty(at);
                bool result = _unitOfWork.Commit();
                RInfo.IsSuccess = result;
                RInfo.ErrorInfo = "更新信息成功!";
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
        /// 删除资产类别
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ReturnInfo DeleteAssetsType(String ID)
        {
            ReturnInfo RInfo = new ReturnInfo();
            try
            {
                if (String.IsNullOrEmpty(ID))
                    throw new Exception("资产类别编号不能为空");
                AssetsType at = _AssetsTypeRepository.GetByID(ID).FirstOrDefault();
                if (at == null)
                    throw new Exception("该分类编号不存在，请检查!");

                _unitOfWork.RegisterDeleted(at);
                bool result = _unitOfWork.Commit();
                RInfo.IsSuccess = result;
                RInfo.ErrorInfo = "删除成功!";
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
        /// 更改分类启用状态
        /// </summary>
        /// <param name="TypeId"></param>
        /// <param name="isEnable"></param>
        /// <returns></returns>
        public ReturnInfo ChangeEnable(string TypeId, IsEnable isEnable)
        {
            ReturnInfo RInfo = new ReturnInfo();
            if (String.IsNullOrEmpty(TypeId))
                throw new Exception("分类编号不能为空");
            AssetsType assetsType = _AssetsTypeRepository.GetByID(TypeId).FirstOrDefault();
            if (assetsType == null)
                throw new Exception("分类编号不存在，请检查!");
            if(assetsType.ISENABLE ==(int)isEnable && isEnable == IsEnable.启用)
            {
                throw new Exception("该分类已启用，不可重复启用");
            }
            else if (assetsType.ISENABLE == (int)isEnable && isEnable == IsEnable.禁用)
            {
                throw new Exception("该分类已禁用，不可重复禁用");
            }
            try
            {
                assetsType.ISENABLE = (int)isEnable;
                _unitOfWork.RegisterDirty(assetsType);
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
        #endregion 操作
    }
}
