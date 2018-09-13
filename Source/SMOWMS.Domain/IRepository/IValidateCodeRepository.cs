using System;
using System.Linq;
using SMOWMS.Domain.Entity;

namespace SMOWMS.Domain.IRepository
{
    /// <summary>
    /// 验证表的仓储接口，仅用于查询
    /// </summary>
    public interface IValidateCodeRepository : IRepository<ValidateCode>
    {
        /// <summary>
        /// 根据号码和验证码查询信息
        /// </summary>
        /// <param name="PhoneNumber"></param>
        /// <param name="VCode"></param>
        /// <returns></returns>
        IQueryable<ValidateCode> GetByPhone(String PhoneNumber,String VCode);
    }
}
