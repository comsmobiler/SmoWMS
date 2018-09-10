using SMOWMS.Application.IServices;
using SMOWMS.Domain.IRepository;
using SMOWMS.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOWMS.CommLib;
using SMOWMS.Domain.Entity;
using System.Data.Entity;

namespace SMOWMS.Application.Services
{
    /// <summary>
    /// 供货商服务接口实现
    /// </summary>
    public class VendorService : IVendorService
    {
        /// <summary>
        /// 工作单元的接口
        /// </summary>
        private IUnitOfWork _unitOfWork;
        /// <summary>
        /// 供货商信息的查询接口
        /// </summary>
        private IVendorReposity _vendorReposity;
        /// <summary>
        /// 数据库上下文
        /// </summary>
        private SMOWMSDbContext SMOWMSDbContext;
        /// <summary>
        /// 成本中心服务实现的构造函数
        /// </summary>
        public VendorService(IUnitOfWork unitOfWork,
            IVendorReposity vendorReposity,
            IDbContext dbContext)
        {
            _unitOfWork = unitOfWork;
            _vendorReposity = vendorReposity;
            SMOWMSDbContext = (SMOWMSDbContext)dbContext;
        }
        #region 查询
        public List<Vendor> GetAll()
        {
            return _vendorReposity.GetAll().AsNoTracking().ToList();
        }

        public Vendor GetById(int vId)
        {
            return _vendorReposity.GetById(vId).AsNoTracking().FirstOrDefault();
        }

        public List<Vendor> GetByKeyword(string keyword)
        {
            return _vendorReposity.GetByKeyword(keyword).AsNoTracking().ToList();
        }

        #endregion
        #region 操作
        public ReturnInfo AddVendor(Vendor vendor)
        {
            ReturnInfo RInfo = new ReturnInfo();
            try
            {
                vendor.CREATEDATE = DateTime.Now;
                vendor.MODIFYDATE = DateTime.Now;
                _unitOfWork.RegisterNew(vendor);
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
        public ReturnInfo UpdateVendor(Vendor vendor)
        {
            ReturnInfo RInfo = new ReturnInfo();
            try
            {
                Vendor hasVen = _vendorReposity.GetById(vendor.VID).AsNoTracking().FirstOrDefault();
                if (hasVen == null)
                {
                    throw new Exception("编号" + vendor.VID + "不存在");
                }
                hasVen.NAME = vendor.NAME;
                hasVen.FAX = vendor.FAX;
                hasVen.ADDRESS = vendor.ADDRESS;
                hasVen.EMAIL = vendor.EMAIL;
                hasVen.NOTE = vendor.NOTE;
                hasVen.TAXNUMBER = vendor.TAXNUMBER;
                hasVen.BANK = vendor.BANK;
                hasVen.ACCOUNT = vendor.ACCOUNT;
                hasVen.CONTACTS = vendor.CONTACTS;
                hasVen.PHONE = vendor.PHONE;
                hasVen.MODIFYUSER = vendor.MODIFYUSER;
                hasVen.MODIFYDATE = DateTime.Now;

                _unitOfWork.RegisterDirty(hasVen);
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
        public ReturnInfo DeleteVendor(int vId)
        {
            ReturnInfo RInfo = new ReturnInfo();
            try
            {
                Vendor vendor = _vendorReposity.GetById(vId).FirstOrDefault();
                if (vendor == null)
                {
                    throw new Exception("编号" + vId + "不存在");
                }

                _unitOfWork.RegisterDeleted(vendor);
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
