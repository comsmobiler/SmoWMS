using System;
using System.Linq;
using SMOWMS.Domain.Entity;
using SMOWMS.Domain.IRepository;
using SMOWMS.Infrastructure;

namespace SMOWMS.Repository.Setting
{
    /// <summary>
    /// 用户信息的仓储实现，仅用于查询
    /// </summary>
    public class coreUserRepository : BaseRepository<coreUser>, IcoreUserRepository
    {
        /// <summary>
        /// 仓储类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public coreUserRepository(IDbContext dbContext)
            : base(dbContext)
        { }
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="Password">用户密码</param>
        /// <returns>true表示成功，false表示失败</returns>
        public bool Login(string UserID, String Password)
        {
            return _entities.Any(x => x.USER_ID == UserID && x.USER_PASSWORD == Password);
        }
        /// <summary>
        /// 获取管理员数据
        /// </summary>
        /// <returns></returns>
        public IQueryable<coreUser> GetAdmin()
        {
            return _entities.Where(x => x.USER_ROLE == "ADMIN");
        }
        /// <summary>
        /// 得到某个部门的所有用户
        /// </summary>
        /// <param name="DepartmentID"></param>
        /// <returns></returns>
        public IQueryable<coreUser> GetUserByDepID(string DepartmentID)
        {
            return _entities.Where(x => x.USER_DEPARTMENTID == DepartmentID);
        }
        /// <summary>
        /// 获取用户数据
        /// </summary>
        /// <returns></returns>
        public IQueryable<coreUser> GetUser()
        {
            return _entities.Where(x => x.USER_ROLE == "SMOWMSUSER");
        }
        /// <summary>
        /// 通过用户名称获取用户数据
        /// </summary>
        /// <returns></returns>
        public IQueryable<coreUser> GetUser(string Name)
        {
            return _entities.Where(x => x.USER_NAME.Contains(Name));
        }
        /// <summary>
        /// 通过用户编号获取用户信息
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public IQueryable<coreUser> GetByID(String ID)
        {
            return _entities.Where(x => x.USER_ID == ID);
        }
        /// <summary>
        /// 获取调入管理员数据
        /// </summary>
        /// <returns></returns>
        public IQueryable<coreUser> GetDealInAdmin()
        {
            return _entities.Where(x => x.USER_ROLE == "SMOWMSADMIN");
        }
        /// <summary>
        /// 通过邮箱获取用户信息
        /// </summary>
        /// <param name="Email"></param>
        /// <returns></returns>
        public IQueryable<coreUser> GetByEmail(string Email)
        {
            return _entities.Where(x => x.USER_EMAIL == Email); ;
        }
        /// <summary>
        /// 通过电话获取用户信息
        /// </summary>
        /// <param name="Phone"></param>
        /// <returns></returns>
        public IQueryable<coreUser> GetByPhone(string Phone)
        {
            return _entities.Where(x => x.USER_PHONE == Phone);
        }
        /// <summary>
        /// 判断该用户ID是否存在
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <returns>true表示存在，false表示不存在</returns>
        public bool IsExists(string UserID)
        {
            return _entities.Any(x => x.USER_ID == UserID);
        }
    }
}
