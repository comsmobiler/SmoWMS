using AutoMapper;
using SMOWMS.Application.IServices;
using SMOWMS.Domain.Entity;
using SMOWMS.Domain.IRepository;
using SMOWMS.DTOs.OutputDTO;
using SMOWMS.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;

namespace SMOWMS.Application.Services
{
    /// <summary>
    /// 单据的服务接口实现
    /// 各种单据通用的查询
    /// </summary>
    public class OrderCommonService : IOrderCommonService
    {
        /// <summary>
        /// 操作记录的查询接口
        /// </summary>
        private IAssProcessRecordRepository _AssProcessRecordRepository;
        /// <summary>
        /// 耗材的查询接口
        /// </summary>
        private IConsumablesRepository _ConsumablesRepository;
        /// <summary>
        /// 耗材库存的查询接口
        /// </summary>
        private IConQuantRepository _ConQuantRepository;
        /// <summary>
        /// 资产信息的查询接口
        /// </summary>
        private IAssetsRepository _AssetsRepository;
        /// <summary>
        /// 资产分类的查询接口
        /// </summary>
        private IAssetsTypeRepository _AssetsTypeRepository;
        /// <summary>
        /// 数据库上下文
        /// </summary>
        private SMOWMSDbContext SMOWMSDbContext;

        /// <summary>
        /// 成本中心服务实现的构造函数
        /// </summary>
        public OrderCommonService(
            IAssProcessRecordRepository AssProcessRecordRepository,
            IConsumablesRepository ConsumablesRepository,
            IConQuantRepository ConQuantRepository,
            IAssetsRepository AssetsRepository,
            IAssetsTypeRepository AssetsTypeRepository,
            IDbContext dbContext)
        {
            _AssProcessRecordRepository = AssProcessRecordRepository;
            _ConsumablesRepository = ConsumablesRepository;
            _ConQuantRepository = ConQuantRepository;
            _AssetsRepository = AssetsRepository;
            _AssetsTypeRepository = AssetsTypeRepository;
            SMOWMSDbContext = (SMOWMSDbContext)dbContext;
        }
        #region  查询
        /// <summary>
        /// 获取资产使用情况
        /// </summary>
        /// <param name="Mode"></param>
        /// <param name="Level1"></param>
        /// <returns></returns>
        public List<AssProRecordOutputDto> GetUseAnalyse(string Mode)
        {
            var list = _AssProcessRecordRepository.GetUserData(Mode).AsNoTracking();
            var resultFirst = from AssPR in list
                              join Ass in SMOWMSDbContext.Assetss on AssPR.ASSID equals Ass.ASSID
                              join AssType in SMOWMSDbContext.AssetsTypes on Ass.TYPEID equals AssType.TYPEID
                              select new AssProRecordOutputDto()
                              {
                                  TYPEID = Ass.TYPEID,
                                  TYPENAME = AssType.NAME,
                                  QUANTITY = AssPR.QUANTITY,
                                  CREATEDATE = AssPR.CREATEDATE,
                                  TLEVEL = (int)AssType.TLEVEL,
                                  Level1 = GetLevel1TypeID(AssType.TYPEID)
                              };
            Dictionary<String, List<BarChartOutputDto>> AssetsData = new Dictionary<string, List<BarChartOutputDto>>();
            foreach (AssProRecordOutputDto Row in resultFirst)
            {
                var result = from AssPR in list
                             from Ass in SMOWMSDbContext.Assetss
                             from AssType in SMOWMSDbContext.AssetsTypes
                             where AssPR.ASSID == Ass.ASSID && Ass.TYPEID == AssType.TYPEID
                             select new AssProRecordOutputDto()
                             {
                                 TYPEID = Ass.TYPEID,
                                 TYPENAME = AssType.NAME,
                                 QUANTITY = AssPR.QUANTITY,
                                 CREATEDATE = AssPR.CREATEDATE
                             };
                var Data = Mapper.Map<List<AssProRecordOutputDto>, List<AssProcessRecord>>(result.ToList());
                if (result.Count() > 0)     //数据超过一条，则进行数据缩减
                {
                    Data = ReduceData(Mode, Data);         //同一天的行项数据归并为一条
                }
                List<BarChartOutputDto> ChartData = new List<BarChartOutputDto>();
                foreach (AssProcessRecord NowRow in Data)
                {
                    BarChartOutputDto NewRow = new BarChartOutputDto();
                    NewRow.QUANTITY = NowRow.QUANTITY;
                    NewRow.CREATEDATE = NowRow.CREATEDATE;
                    ChartData.Add(NewRow);
                }
                String TypeName = _AssetsTypeRepository.GetByID(Row.Level1).FirstOrDefault().NAME;
                if (AssetsData.ContainsKey(TypeName) == false)
                    AssetsData.Add(TypeName, ChartData);
            }

            List<int> xData = new List<int>();
            List<List<decimal>> Assetss = new List<List<decimal>>();
            DateTime date = DateTime.Now;
            int year = date.Year;
            int month = date.Month;
            int day = date.Day;
            switch (Mode)
            {
                case "OM":
                    for(int i = 0; i < day; i++)
                    {
                        xData.Add(i+1);
                    }
                    for(int j=0;j< AssetsData.Count; j++)
                    {
                        List<decimal> Assets = new List<decimal>();
                        for(int i = 0; i < day; i++)
                        {
                            Boolean isAdd = false;
                            foreach(String key in AssetsData.Keys)
                            {
                                foreach(BarChartOutputDto Row in AssetsData[key])
                                {
                                    int DayThat = Row.CREATEDATE.Day;
                                    if (i + 1 == DayThat)
                                    {
                                        Assets[i] = Row.QUANTITY;
                                        isAdd = true;
                                    }
                                }
                                if (isAdd == false)
                                    Assets[i] = 0;
                            }
                        }
                        Assetss[j] = Assets;
                    }
                    break;
                case "TM":
                    for(int i = 0; i < 12; i++)
                    {
                        
                    }
                    break;
                case "OY":

                    break;
            }
            return resultFirst.AsNoTracking().ToList();
        }
        /// <summary>
        /// 数据进行缩减，以便进行后续处理
        /// </summary>
        /// <param name="Mode"></param>
        /// <param name="Data"></param>
        /// <returns></returns>
        public List<AssProcessRecord> ReduceData(String Mode, List<AssProcessRecord> Data)
        {
            for (int i = 0; i < Data.Count; i++)
            {
                Int32 j = i + 1;
                while (j < Data.Count)
                {
                    if (Data[i].CREATEDATE.Day == Data[j].CREATEDATE.Day && Data[i].CREATEDATE.Month == Data[j].CREATEDATE.Month)
                    {
                        Data[i].QUANTITY = Data[i].QUANTITY + Data[j].QUANTITY;
                        Data.RemoveAt(j);
                        j = i + 1;
                    }
                    else
                    {
                        j = j + 1;
                    }
                }
            }
            switch (Mode)
            {
                case "TM":
                    if (Data.Count > 1)
                    {
                        for (int i = 0; i < Data.Count; i++)
                        {
                            int h = i + 1;
                            while (h < Data.Count)
                            {
                                if (WeekOfYear(Convert.ToDateTime(Data[i].CREATEDATE), new CultureInfo("zh-CN")) == WeekOfYear(Convert.ToDateTime(Data[h].CREATEDATE), new CultureInfo("zh-CN")))
                                {
                                    Data[i].QUANTITY = Data[i].QUANTITY + Data[h].QUANTITY;
                                    Data.RemoveAt(h);
                                    h = i + 1;
                                }
                                else
                                {
                                    h = h + 1;
                                }
                            }
                        }
                    }
                    break;
                case "OY":
                    if (Data.Count > 1)
                    {
                        for (int i = 0; i < Data.Count; i++)
                        {
                            int h = i + 1;
                            while (h < Data.Count)
                            {
                                if (Data[i].CREATEDATE.Month == Data[h].CREATEDATE.Month)
                                {
                                    Data[i].QUANTITY = Data[i].QUANTITY + Data[h].QUANTITY;
                                    Data.RemoveAt(h);
                                    h = i + 1;
                                }
                                else
                                {
                                    h = h + 1;
                                }
                            }
                        }
                    }
                    break;
            }
            return Data;
        }
        /// <summary>
        /// 获取父资产信息
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public String GetLevel1TypeID(String type)
        {
            AssetsType assetsType = _AssetsTypeRepository.GetByID(type).FirstOrDefault();
            if (assetsType.TLEVEL == 1)   //没有父资产，说明是一级资产分类
            {
                return type;
            }
            else if (assetsType.TLEVEL == 2)     //二级资产
            {
                return assetsType.PARENTTYPEID;
            }
            else        //三级资产
            {
                AssetsType AssType = _AssetsTypeRepository.GetByID(assetsType.PARENTTYPEID).FirstOrDefault();
                return assetsType.PARENTTYPEID;
            }
        }
        /// <summary>
        /// 根据资产条码查询资产信息
        /// </summary>
        /// <param name="ASSID"></param>
        /// <returns></returns>
        public Assets GetAssetsByID(String ASSID)
        {
            return _AssetsRepository.GetByID(ASSID).AsNoTracking().FirstOrDefault();
        }
        /// <summary>
        /// 根据序列号查询资产对象 
        /// </summary>
        /// <param name="ASSID"></param>
        /// <returns></returns>
        public Assets GetUnusedAssetsBySN(String SN)
        {
            return _AssetsRepository.GetUnusedBySN(SN).AsNoTracking().FirstOrDefault();
        }
        /// <summary>
        /// 获取除选择库位外的空闲耗材库存信息
        /// </summary>
        /// <param name="LocaitionID"></param>
        /// <param name="CID"></param>
        /// <returns></returns>
        public List<ConQuantOutputDto> GetUnUseCon(string WAREID, string STID, string SLID, string CID)
        {
            var conQuants= _ConQuantRepository.GetUnUserCon(WAREID,STID,SLID, CID);
            var result = from conQuant in conQuants
                         join WH in SMOWMSDbContext.WareHouses on conQuant.WAREID equals WH.WAREID
                         join WHST in SMOWMSDbContext.WHStorageTypes on conQuant.STID equals WHST.STID
                         where conQuant.WAREID==WHST.WAREID
                         join WHSL in SMOWMSDbContext.WHStorageLocations on conQuant.SLID equals WHSL.SLID
                         where conQuant.WAREID==WHSL.WAREID && conQuant.STID==WHSL.STID  
                         select new ConQuantOutputDto
                         {
                             CID=conQuant.CID,
                             WAREID=conQuant.WAREID,
                             WARENAME=WH.NAME,
                             STID=conQuant.STID,
                             STNAME=WHST.NAME,
                             SLID=conQuant.SLID,
                             SLNAME=WHSL.NAME,
                             QUANTITY=conQuant.QUANTITY
                         };
            return result.AsNoTracking().ToList();
        }
        /// <summary>
        /// 根据耗材编号和区域编号获取耗材库存信息
        /// </summary>
        /// <param name="CID"></param>
        /// <param name="WAREID"></param>
        /// <param name="STID"></param>
        /// <param name="SLID"></param>
        /// <returns></returns>
        public ConQuant GetUnUseConByCID(string CID, string WAREID, string STID, string SLID)
        {
            return _ConQuantRepository.GetByCID(CID, WAREID, STID, SLID).AsNoTracking().FirstOrDefault();
        }
        /// <summary>
        /// 根据序列号，返回序列号信息
        /// </summary>
        /// <param name="SN"></param>
        /// <returns></returns>
        public Assets GetSNByID(String SN)
        {
            return _AssetsRepository.GetAssetsBySN(SN).FirstOrDefault();
        }
        /// <summary>
        /// 计算当前日期属于一年中的第几天
        /// </summary>
        /// <returns></returns>
        public int WeekOfYear(DateTime dt, CultureInfo ci)
        {
            return ci.Calendar.GetWeekOfYear(dt, ci.DateTimeFormat.CalendarWeekRule, ci.DateTimeFormat.FirstDayOfWeek);
        }
        #endregion
    }
}
