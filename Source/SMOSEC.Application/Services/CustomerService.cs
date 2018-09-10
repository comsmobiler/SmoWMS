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
    /// 客户的接口实现
    /// </summary>
    public class CustomerService : ICustomerService
    {
        /// <summary>
        /// 工作单元的接口
        /// </summary>
        private IUnitOfWork _unitOfWork;
        /// <summary>
        /// 客户信息的查询接口
        /// </summary>
        private ICustomerReposity _customerReposity;
        /// <summary>
        /// 数据库上下文
        /// </summary>
        private SMOWMSDbContext SMOWMSDbContext;
        /// <summary>
        /// 成本中心服务实现的构造函数
        /// </summary>
        public CustomerService(IUnitOfWork unitOfWork,
            ICustomerReposity customerReposity,
            IDbContext dbContext)
        {
            _unitOfWork = unitOfWork;
            _customerReposity = customerReposity;
            SMOWMSDbContext = (SMOWMSDbContext)dbContext;
        }
        #region 查询
        public Customer GetById(int cusId)
        {
            return _customerReposity.GetById(cusId).AsNoTracking().FirstOrDefault();
        }
        /// <summary>
        /// 根据关键词查询客户信息
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public List<Customer> GetByKeyword(string keyword)
        {
            return _customerReposity.GetByKeyword(keyword).AsNoTracking().ToList();
        }

        public List<Customer> GetAll()
        {
            return _customerReposity.GetAll().AsNoTracking().ToList();
        }
        #endregion
        #region 操作
        public ReturnInfo AddCustomer(Customer customer)
        {
            ReturnInfo RInfo = new ReturnInfo();
            try
            {
                customer.CREATEDATE = DateTime.Now;
                customer.MODIFYDATE = DateTime.Now;
                _unitOfWork.RegisterNew(customer);
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
        public ReturnInfo UpdateCustomer(Customer customer)
        {
            ReturnInfo RInfo = new ReturnInfo();
            try
            {
                Customer hasCus = _customerReposity.GetById(customer.CUSID).AsNoTracking().FirstOrDefault();
                if (hasCus == null)
                {
                    throw new Exception("编号" + customer.CUSID + "不存在");
                }
                hasCus.NAME = customer.NAME;
                hasCus.FAX = customer.FAX;
                hasCus.ADDRESS = customer.ADDRESS;
                hasCus.EMAIL = customer.EMAIL;
                hasCus.NOTE = customer.NOTE;
                hasCus.TAXNUMBER = customer.TAXNUMBER;
                hasCus.BANK = customer.BANK;
                hasCus.ACCOUNT = customer.ACCOUNT;
                hasCus.CONTACTS = customer.CONTACTS;
                hasCus.PHONE = customer.PHONE;
                hasCus.MODIFYUSER = customer.MODIFYUSER;
                hasCus.MODIFYDATE = DateTime.Now;

                _unitOfWork.RegisterDirty(hasCus);
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
        /// <summary>
        /// 删除客户
        /// </summary>
        /// <param name="cusId"></param>
        /// <returns></returns>
        public ReturnInfo DeleteCustomer(int cusId)
        {
            ReturnInfo RInfo = new ReturnInfo();
            try
            {
                Customer customer = _customerReposity.GetById(cusId).FirstOrDefault();
                if (customer == null)
                {
                    throw new Exception("编号" + cusId + "不存在");
                }

                _unitOfWork.RegisterDeleted(customer);
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
