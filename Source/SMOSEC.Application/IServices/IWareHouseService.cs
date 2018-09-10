using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.OutputDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOWMS.CommLib;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.DTOs.Enum;

namespace SMOWMS.Application.IServices
{
    /// <summary>
    /// 仓库相关的服务接口
    /// </summary>
    public interface IWareHouseService
    {
        #region 查询
        /// <summary>
        /// 查询库位信息
        /// </summary>
        /// <param name="WAREID">仓库编号</param>
        /// <param name="STID">类型编号</param>
        /// <param name="SLID">库位编号</param>
        /// <returns></returns>
        WHStorageLocationOutputDto GetSLByID(string WAREID, string STID, string SLID);

        /// <summary>
        /// 得到所有仓库列表
        /// </summary>
        /// <returns></returns>
        List<WareHouse> GetAllWareHouse();

        /// <summary>
        /// 根据仓库编号获取仓库信息
        /// </summary>
        /// <param name="WAREID">仓库编号</param>
        /// <returns></returns>
        WareHouse GetByWareID(string WAREID);

        /// <summary>
        /// 得到某个仓库下的所有存储类型
        /// </summary>
        /// <param name="WAREID">仓库编号</param>
        /// <returns></returns>
        List<WHStorageType> GetSTByWareID(string WAREID);

        /// <summary>
        /// 根据仓库编号和存储类型编号得到存储类型
        /// </summary>
        /// <param name="WAREID">仓库编号</param>
        /// <param name="STID">存储类型编号</param>
        /// <returns></returns>
        WHStorageTypeOutputDto GetSTByWareIDandSTID(string WAREID,string STID);

        /// <summary>
        /// 得到某个仓库和存储类型下的所有库位
        /// </summary>
        /// <param name="WAREID">仓库编号</param>
        /// <param name="STID">存储类型编号</param>
        /// <returns></returns>
        List<WHStorageLocation> GetSLByWareIDAndSTID(string WAREID,string STID);

        /// <summary>
        /// 盘点库位是否存在
        /// </summary>
        /// <param name="WAREID">仓库编号</param>
        /// <param name="STID">存储类型编号</param>
        /// <param name="SLID">库位编号</param>
        /// <returns></returns>
        bool SLIsExists(string WAREID, string STID, string SLID);
        #endregion

        #region 操作
        /// <summary>
        /// 添加仓库
        /// </summary>
        /// <param name="inputDto">仓库信息</param>
        /// <returns></returns>
        ReturnInfo AddWareHouse(WareHouseInputDto inputDto);

        /// <summary>
        /// 更新仓库
        /// </summary>
        /// <param name="inputDto">仓库信息</param>
        /// <returns></returns>
        ReturnInfo UpdateWareHouse(WareHouseInputDto inputDto);

        /// <summary>
        /// 添加存储类型
        /// </summary>
        /// <param name="inputDto">存储类型信息</param>
        /// <returns></returns>
        ReturnInfo AddWhStorageType(WHStorageTypeInputDto inputDto);

        /// <summary>
        /// 更新存储类型
        /// </summary>
        /// <param name="inputDto">存储类型信息</param>
        /// <returns></returns>
        ReturnInfo UpdateWhStorageType(WHStorageTypeInputDto inputDto);

        /// <summary>
        /// 添加库位
        /// </summary>
        /// <param name="inputDto">库位信息</param>
        /// <returns></returns>
        ReturnInfo AddWhStorageLocation(WHStorageLocationInputDto inputDto);

        /// <summary>
        /// 更新库位
        /// </summary>
        /// <param name="inputDto">库位信息</param>
        /// <returns></returns>
        ReturnInfo UpdateWhStorageLocation(WHStorageLocationInputDto inputDto);
        /// <summary>
        /// 启用/禁用:仓库/存储类型/库位
        /// </summary>
        /// <param name="wareId"></param>
        /// <param name="stId"></param>
        /// <param name="SlId"></param>
        /// <param name="isEnable"></param>
        /// <returns></returns>
        ReturnInfo ChangeEnable(string wareId,string stId,string SlId,IsEnable isEnable);
        #endregion
    }
}
