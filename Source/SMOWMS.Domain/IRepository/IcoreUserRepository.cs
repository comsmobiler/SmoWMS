using System;
using System.Linq;
using SMOWMS.Domain.Entity;

namespace SMOWMS.Domain.IRepository
{
    /// <summary>
    /// 用户信息的仓储接口，仅用于查询
    /// </summary>
    public interface IcoreUserRepository : IRepository<coreUser>
    {
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="Password">用户密码</param>
        /// <returns>true表示成功，false表示失败</returns>
        bool Login(string UserID, String Password);
        /// <summary>
        /// 获取管理员数据
        /// </summary>
        /// <returns></returns>
        IQueryable<coreUser> GetAdmin();
        /// <summary>
        /// 获取用户数据
        /// </summary>
        /// <returns></returns>
        IQueryable<coreUser> GetUser();
        /// <summary>
        /// 通过用户名称获取用户数据
        /// </summary>
        /// <returns></returns>
        IQueryable<coreUser> GetUser(string Name);
        /// <summary>
        /// 获取调入管理员数据
        /// </summary>
        /// <returns></returns>
        IQueryable<coreUser> GetDealInAdmin();
        /// <summary>
        /// 通过用户编号获取数据
        /// </summary>
        /// <returns></returns>
        IQueryable<coreUser> GetByID(String ID);
        /// <summary>
        /// 得到某个部门的所有用户
        /// </summary>
        /// <param name="DepartmentID"></param>
        /// <returns></returns>
        IQueryable<coreUser> GetUserByDepID(string DepartmentID);
        /// <summary>
        /// 通过手机号码获取数据
        /// </summary>
        /// <param name="Phone"></param>
        /// <returns></returns>
        IQueryable<coreUser> GetByPhone(String Phone);
        /// <summary>
        /// 通过邮箱获取数据
        /// </summary>
        /// <param name="Email"></param>
        /// <returns></returns>
        IQueryable<coreUser> GetByEmail(String Email);
        /// <summary>
        /// 判断该用户ID是否存在
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <returns>true表示存在，false表示不存在</returns>
        bool IsExists(string UserID);
    }
}
