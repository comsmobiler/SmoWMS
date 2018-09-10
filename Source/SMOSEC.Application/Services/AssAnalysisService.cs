using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text.RegularExpressions;
using SMOWMS.Application.IServices;
using SMOWMS.Domain.Entity;
using SMOWMS.Domain.IRepository;
using SMOWMS.DTOs.Enum;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.DTOs.OutputDTO;
using SMOWMS.Infrastructure;

namespace SMOWMS.Application.Services
{
    /// <summary>
    /// 资产分析服务的实现
    /// </summary>
    public class AssAnalysisService:IAssAnalysisService
    {
        /// <summary>
        /// 资产信息的查询接口
        /// </summary>
        private IAssetsRepository _assetsRepository;

        /// <summary>
        /// 数据库上下文
        /// </summary>
        private SMOWMSDbContext SMOWMSDbContext;

        private ICustomerReposity _customerReposity;
        private IVendorReposity _vendorReposity;

        /// <summary>
        /// 资产分析服务实现的构造函数
        /// </summary>
        public AssAnalysisService(IAssetsRepository assetsRepository,
            ICustomerReposity customerReposity,
            IVendorReposity vendorReposity,
        IDbContext dbContext)
        {
            _assetsRepository = assetsRepository;
            _customerReposity = customerReposity;
            _vendorReposity = vendorReposity;
            SMOWMSDbContext = (SMOWMSDbContext)dbContext;
        }

        public List<AssQuantDto> GetAssQuant(QueryAssQuantInputDto inputDto)
        {
            var asset = _assetsRepository.GetAll().Where(a=>a.ISINWAREHOUSE==1);
            if (!string.IsNullOrEmpty(inputDto.WAREID))
            {
                asset = asset.Where(a => a.WAREID == inputDto.WAREID);
            }
            var types = (from type1 in SMOWMSDbContext.AssetsTypes
                where type1.TLEVEL == 1
                select new
                {
                    Level1 = type1.TYPEID,
                    Level2 = "",
                    Level3 = ""
                }).Union(from type1 in SMOWMSDbContext.AssetsTypes
                where type1.TLEVEL == 2
                select new
                {
                    Level1 = type1.PARENTTYPEID,
                    Level2 = type1.TYPEID,
                    Level3 = ""
                }).Union(from type1 in SMOWMSDbContext.AssetsTypes
                join type2 in SMOWMSDbContext.AssetsTypes on type1.PARENTTYPEID equals type2.TYPEID 
                where type1.TLEVEL == 3
                select new
                {
                    Level1 = type2.PARENTTYPEID,
                    Level2 = type1.PARENTTYPEID,
                    Level3 = type1.TYPEID
                });
            var typelist = types;
            if (!string.IsNullOrEmpty(inputDto.TYPEID))
            {
                typelist = typelist.Where(a => a.Level1 == inputDto.TYPEID);
            }
            var result = from assetse in asset
                from assTemplate in SMOWMSDbContext.AssTemplates
                from type in typelist
                from type1 in SMOWMSDbContext.AssetsTypes
                         join wareHouse in SMOWMSDbContext.WareHouses on assetse.WAREID equals wareHouse.WAREID
                where assetse.TEMPLATEID == assTemplate.TEMPLATEID &&
                      ((assTemplate.TYPEID == type.Level1&&type.Level2=="") || (assTemplate.TYPEID == type.Level2&&type.Level3=="") ||
                       assTemplate.TYPEID == type.Level3)&&type.Level1==type1.TYPEID
                select new AssQuantDto()
                {
                    IMAGE = assTemplate.IMAGE,
                    NAME = assTemplate.NAME,
                    TEMPLATEID = assTemplate.TEMPLATEID,
                    WARENAME = wareHouse.NAME,
                    TYPENAME = type1.NAME,
                    QUANT=1
                };
            var fresult = from assQuantDto in result
                group assQuantDto by new
                {
                    assQuantDto.TEMPLATEID,
                    assQuantDto.IMAGE,
                    assQuantDto.NAME,
                    assQuantDto.WARENAME,
                    assQuantDto.TYPENAME
                }
                into quant
                select new AssQuantDto()
                {
                    IMAGE = quant.Key.IMAGE,
                    NAME = quant.Key.NAME,
                    TEMPLATEID = quant.Key.TEMPLATEID,
                    WARENAME = quant.Key.WARENAME,
                    TYPENAME = quant.Key.TYPENAME,
                    QUANT = quant.Count()
                };
            return fresult.ToList();
        }

        public List<AssImminentExpiryDto> GetImminentExpiryAss(QueryAssAnalysisInputDto inputDto)
        {
            var asset = _assetsRepository.GetAll().Where(a => a.ISINWAREHOUSE == 1&&a.EXPIRYDATE>=inputDto.StarTime&&a.EXPIRYDATE<=inputDto.EndTime).OrderBy(a=>a.EXPIRYDATE).OrderBy(a=>a.EXPIRYDATE).Select(a=>new AssImminentExpiryDto(){ASSID = a.ASSID,SN = a.SN,ExpiryDate = a.EXPIRYDATE,IMAGE = a.IMAGE});
            return asset.ToList();
        }

        public List<AssPurchaseAnalysisDto> GetAssPurchaseAnalysis(QueryAssAnalysisInputDto inputDto)
        {
            var types = (from type1 in SMOWMSDbContext.AssetsTypes
                where type1.TLEVEL == 1
                select new
                {
                    Level1 = type1.TYPEID,
                    Level2 = "",
                    Level3 = ""
                }).Union(from type1 in SMOWMSDbContext.AssetsTypes
                where type1.TLEVEL == 2
                select new
                {
                    Level1 = type1.PARENTTYPEID,
                    Level2 = type1.TYPEID,
                    Level3 = ""
                }).Union(from type1 in SMOWMSDbContext.AssetsTypes
                join type2 in SMOWMSDbContext.AssetsTypes on type1.PARENTTYPEID equals type2.TYPEID
                where type1.TLEVEL == 3
                select new
                {
                    Level1 = type2.PARENTTYPEID,
                    Level2 = type1.PARENTTYPEID,
                    Level3 = type1.TYPEID
                });

            var poRowResult =
                from assTemplate in SMOWMSDbContext.AssTemplates
                from type in types
                join porow in SMOWMSDbContext.AssPurchaseOrderRows on assTemplate.TEMPLATEID equals porow.TEMPLATEID
                from po in SMOWMSDbContext.AssPurchaseOrders
                where
                ((assTemplate.TYPEID == type.Level1 && type.Level2 == "") || (assTemplate.TYPEID == type.Level2 && type.Level3 == "") ||
                 assTemplate.TYPEID == type.Level3) && porow.CREATEDATE >= inputDto.StarTime && porow.CREATEDATE <= inputDto.EndTime&&po.STATUS>0&&po.POID==porow.POID
                select new AssPurchaseAnalysisDto()
                {
                    IMAGE = assTemplate.IMAGE,
                    NAME = assTemplate.NAME,
                    TEMPLATEID = assTemplate.TEMPLATEID,
                    
                    QUANTPURCHAED=porow.QUANTPURCHASED,
                    QUANTSTORED = 0,
                    QUANTRETREATED = 0
                };
            var poRowfresult = from assQuantDto in poRowResult
                 group assQuantDto by new
                {
                    assQuantDto.TEMPLATEID,
                    assQuantDto.IMAGE,
                    assQuantDto.NAME
                 }
                into quant
                select new AssPurchaseAnalysisDto()
                {
                    IMAGE = quant.Key.IMAGE,
                    NAME = quant.Key.NAME,
                    TEMPLATEID = quant.Key.TEMPLATEID,
                    
                    QUANTPURCHAED = quant.Sum(a=>a.QUANTPURCHAED),
                    QUANTSTORED = 0,
                    QUANTRETREATED = 0
                };
            var   t3 = poRowfresult.ToList();

            return t3;    
        }

        public List<AssSaleAnalysisDto> GetAssSaleAnalysis(QueryAssAnalysisInputDto inputDto)
        {
            var types = (from type1 in SMOWMSDbContext.AssetsTypes
                where type1.TLEVEL == 1
                select new
                {
                    Level1 = type1.TYPEID,
                    Level2 = "",
                    Level3 = ""
                }).Union(from type1 in SMOWMSDbContext.AssetsTypes
                where type1.TLEVEL == 2
                select new
                {
                    Level1 = type1.PARENTTYPEID,
                    Level2 = type1.TYPEID,
                    Level3 = ""
                }).Union(from type1 in SMOWMSDbContext.AssetsTypes
                join type2 in SMOWMSDbContext.AssetsTypes on type1.PARENTTYPEID equals type2.TYPEID
                where type1.TLEVEL == 3
                select new
                {
                    Level1 = type2.PARENTTYPEID,
                    Level2 = type1.PARENTTYPEID,
                    Level3 = type1.TYPEID
                });

            var poRowResult =
                from assTemplate in SMOWMSDbContext.AssTemplates
                from type in types
                from so in SMOWMSDbContext.AssSalesOrders
                join sorow in SMOWMSDbContext.AssSalesOrderRows on assTemplate.TEMPLATEID equals sorow.TEMPLATEID
                where
                ((assTemplate.TYPEID == type.Level1 && type.Level2 == "") || (assTemplate.TYPEID == type.Level2 && type.Level3 == "") ||
                 assTemplate.TYPEID == type.Level3) && sorow.CREATEDATE >= inputDto.StarTime && sorow.CREATEDATE <= inputDto.EndTime && so.STATUS > 0&&so.SOID==sorow.SOID
                select new AssSaleAnalysisDto()
                {
                    IMAGE = assTemplate.IMAGE,
                    NAME = assTemplate.NAME,
                    TEMPLATEID = assTemplate.TEMPLATEID,
                    QUANTSALED = sorow.QUANTSALED,
                    QUANTOUT = 0,
                    QUANTRETREATED = 0
                };
            var poRowfresult = from assQuantDto in poRowResult
                group assQuantDto by new
                {
                    assQuantDto.TEMPLATEID,
                    assQuantDto.IMAGE,
                    assQuantDto.NAME
                }
                into quant
                select new AssSaleAnalysisDto()
                {
                    IMAGE = quant.Key.IMAGE,
                    NAME = quant.Key.NAME,
                    TEMPLATEID = quant.Key.TEMPLATEID,
                    QUANTSALED = quant.Sum(a => a.QUANTSALED),
                    QUANTOUT = 0,
                    QUANTRETREATED = 0
                };

            var t3 = poRowfresult.ToList();

            return t3;

        }

        public List<AssVenAnalysisDto> GetAssVendorAnalysis(QueryAssCusandVenAnalysisInputDto inputDto)
        {
            var types = (from type1 in SMOWMSDbContext.AssetsTypes
                where type1.TLEVEL == 1
                select new
                {
                    Level1 = type1.TYPEID,
                    Level2 = "",
                    Level3 = ""
                }).Union(from type1 in SMOWMSDbContext.AssetsTypes
                where type1.TLEVEL == 2
                select new
                {
                    Level1 = type1.PARENTTYPEID,
                    Level2 = type1.TYPEID,
                    Level3 = ""
                }).Union(from type1 in SMOWMSDbContext.AssetsTypes
                join type2 in SMOWMSDbContext.AssetsTypes on type1.PARENTTYPEID equals type2.TYPEID
                where type1.TLEVEL == 3
                select new
                {
                    Level1 = type2.PARENTTYPEID,
                    Level2 = type1.PARENTTYPEID,
                    Level3 = type1.TYPEID
                });
            var vendorlist = _vendorReposity.GetAll();
            if (inputDto.ID != null)
            {
                vendorlist = vendorlist.Where(a => a.VID == inputDto.ID);
            }
            var poRowResult =
                from assTemplate in SMOWMSDbContext.AssTemplates
                from type in types
                join porow in SMOWMSDbContext.AssPurchaseOrderRows on assTemplate.TEMPLATEID equals porow.TEMPLATEID
                from vendor in vendorlist
                from po in SMOWMSDbContext.AssPurchaseOrders
                where
                ((assTemplate.TYPEID == type.Level1 && type.Level2 == "") || (assTemplate.TYPEID == type.Level2 && type.Level3 == "") ||
                 assTemplate.TYPEID == type.Level3) && porow.CREATEDATE >= inputDto.StarTime && porow.CREATEDATE <= inputDto.EndTime && po.STATUS > 0&&po.VID==vendor.VID&&po.POID==porow.POID
                select new AssVenAnalysisDto()
                {
                    IMAGE = assTemplate.IMAGE,
                    NAME = assTemplate.NAME,
                    TEMPLATEID = assTemplate.TEMPLATEID,
                    VendorName = vendor.NAME,

                    QUANTPURCHAED = porow.QUANTPURCHASED
                };
            var poRowfresult = from assQuantDto in poRowResult
                group assQuantDto by new
                {
                    assQuantDto.TEMPLATEID,
                    assQuantDto.IMAGE,
                    assQuantDto.NAME,
                    assQuantDto.VendorName
                }
                into quant
                select new AssVenAnalysisDto()
                {
                    IMAGE = quant.Key.IMAGE,
                    NAME = quant.Key.NAME,
                    TEMPLATEID = quant.Key.TEMPLATEID,
                    VendorName = quant.Key.VendorName,
                    QUANTPURCHAED = quant.Sum(a => a.QUANTPURCHAED)
                };
            var t3 = poRowfresult.ToList();

            return t3;
        }

        public List<BarChartDto> GetAssPurchaseAnalysisChart(QueryAssAnalysisInputDto inputDto)
        {
            var types = (from type1 in SMOWMSDbContext.AssetsTypes
                where type1.TLEVEL == 1
                select new
                {
                    Level1 = type1.TYPEID,
                    Level2 = "",
                    Level3 = ""
                }).Union(from type1 in SMOWMSDbContext.AssetsTypes
                where type1.TLEVEL == 2
                select new
                {
                    Level1 = type1.PARENTTYPEID,
                    Level2 = type1.TYPEID,
                    Level3 = ""
                }).Union(from type1 in SMOWMSDbContext.AssetsTypes
                join type2 in SMOWMSDbContext.AssetsTypes on type1.PARENTTYPEID equals type2.TYPEID
                where type1.TLEVEL == 3
                select new
                {
                    Level1 = type2.PARENTTYPEID,
                    Level2 = type1.PARENTTYPEID,
                    Level3 = type1.TYPEID
                });

            var poRowResult =
                from assTemplate in SMOWMSDbContext.AssTemplates
                from type in types
                from type2 in SMOWMSDbContext.AssetsTypes
                join porow in SMOWMSDbContext.AssPurchaseOrderRows on assTemplate.TEMPLATEID equals porow.TEMPLATEID
                from po in SMOWMSDbContext.AssPurchaseOrders
                where
                ((assTemplate.TYPEID == type.Level1 && type.Level2 == "") || (assTemplate.TYPEID == type.Level2 && type.Level3 == "") ||
                 assTemplate.TYPEID == type.Level3) && porow.CREATEDATE >= inputDto.StarTime && porow.CREATEDATE <= inputDto.EndTime && po.STATUS > 0&&type.Level1==type2.TYPEID&&po.POID==porow.POID
                select new BarChartDto()
                {
                    XValue = type2.NAME,
                    YValue = porow.QUANTPURCHASED
                };
            var poRowfresult = from assQuantDto in poRowResult
                group assQuantDto by new
                {
                    assQuantDto.XValue
                }
                into quant
                select new BarChartDto()
                {
                    XValue = quant.Key.XValue,
                    YValue = quant.Sum(a => a.YValue)
                };
            var t3 = poRowfresult.ToList();

            return t3;
        }

        public List<BarChartDto> GetAssSaleAnalysisChart(QueryAssAnalysisInputDto inputDto)
        {
            var types = (from type1 in SMOWMSDbContext.AssetsTypes
                where type1.TLEVEL == 1
                select new
                {
                    Level1 = type1.TYPEID,
                    Level2 = "",
                    Level3 = ""
                }).Union(from type1 in SMOWMSDbContext.AssetsTypes
                where type1.TLEVEL == 2
                select new
                {
                    Level1 = type1.PARENTTYPEID,
                    Level2 = type1.TYPEID,
                    Level3 = ""
                }).Union(from type1 in SMOWMSDbContext.AssetsTypes
                join type2 in SMOWMSDbContext.AssetsTypes on type1.PARENTTYPEID equals type2.TYPEID
                where type1.TLEVEL == 3
                select new
                {
                    Level1 = type2.PARENTTYPEID,
                    Level2 = type1.PARENTTYPEID,
                    Level3 = type1.TYPEID
                });

            var poRowResult =
                from assTemplate in SMOWMSDbContext.AssTemplates
                from type in types
                from type2 in SMOWMSDbContext.AssetsTypes
                join sorow in SMOWMSDbContext.AssSalesOrderRows on assTemplate.TEMPLATEID equals sorow.TEMPLATEID
                from so in SMOWMSDbContext.AssSalesOrders
                where
                ((assTemplate.TYPEID == type.Level1 && type.Level2 == "") || (assTemplate.TYPEID == type.Level2 && type.Level3 == "") ||
                 assTemplate.TYPEID == type.Level3) && sorow.CREATEDATE >= inputDto.StarTime && sorow.CREATEDATE <= inputDto.EndTime && so.STATUS > 0 && type.Level1 == type2.TYPEID&&so.SOID==sorow.SOID
                select new BarChartDto()
                {
                    XValue = type2.NAME,
                    YValue = sorow.QUANTSALED
                };
            var poRowfresult = from assQuantDto in poRowResult
                group assQuantDto by new
                {
                    assQuantDto.XValue
                }
                into quant
                select new BarChartDto()
                {
                    XValue = quant.Key.XValue,
                    YValue = quant.Sum(a => a.YValue)
                };

            var t3 = poRowfresult.ToList();

            return t3;
        }

        public List<BarChartDto> GetAssCustomerAnalysisChart(QueryAssCusandVenAnalysisInputDto inputDto)
        {
            var types = (from type1 in SMOWMSDbContext.AssetsTypes
                where type1.TLEVEL == 1
                select new
                {
                    Level1 = type1.TYPEID,
                    Level2 = "",
                    Level3 = ""
                }).Union(from type1 in SMOWMSDbContext.AssetsTypes
                where type1.TLEVEL == 2
                select new
                {
                    Level1 = type1.PARENTTYPEID,
                    Level2 = type1.TYPEID,
                    Level3 = ""
                }).Union(from type1 in SMOWMSDbContext.AssetsTypes
                join type2 in SMOWMSDbContext.AssetsTypes on type1.PARENTTYPEID equals type2.TYPEID
                where type1.TLEVEL == 3
                select new
                {
                    Level1 = type2.PARENTTYPEID,
                    Level2 = type1.PARENTTYPEID,
                    Level3 = type1.TYPEID
                });
            var customerlist = _customerReposity.GetAll();
            if (inputDto.ID != null)
            {
                customerlist = customerlist.Where(a => a.CUSID == inputDto.ID);
            }
            var poRowResult =
                from assTemplate in SMOWMSDbContext.AssTemplates
                from type in types
                from type2 in SMOWMSDbContext.AssetsTypes
                join sorow in SMOWMSDbContext.AssSalesOrderRows on assTemplate.TEMPLATEID equals sorow.TEMPLATEID
                from customer in customerlist
                from so in SMOWMSDbContext.AssSalesOrders
                where
                ((assTemplate.TYPEID == type.Level1 && type.Level2 == "") || (assTemplate.TYPEID == type.Level2 && type.Level3 == "") ||
                 assTemplate.TYPEID == type.Level3) && sorow.CREATEDATE >= inputDto.StarTime && sorow.CREATEDATE <= inputDto.EndTime && so.STATUS > 0 && assTemplate.TEMPLATEID == sorow.TEMPLATEID
                && so.CUSID == customer.CUSID && type.Level1 == type2.TYPEID
                && so.SOID == sorow.SOID
                select new BarChartDto()
                {
                    XValue = type2.NAME,
                    Series = customer.NAME,
                    YValue = sorow.QUANTSALED
                };
            var poRowfresult = from assQuantDto in poRowResult
                group assQuantDto by new
                {
                    assQuantDto.XValue,
                    assQuantDto.Series,
                }
                into quant
                select new BarChartDto()
                {
                    XValue = quant.Key.XValue,
                    Series = quant.Key.Series,
                    YValue = quant.Sum(a => a.YValue)
                };

            var t3 = poRowfresult.ToList();

            var t4 = new List<BarChartDto>();
            if (inputDto.ID == null)
            {
                //如果是全部，则需要补全数量为0的项
                //得到所有需要显示的一级资产类型
                var allLevel1 =
                    from assTemplate in SMOWMSDbContext.AssTemplates
                    from type in types
                    from type2 in SMOWMSDbContext.AssetsTypes
                    join sorow in SMOWMSDbContext.AssSalesOrderRows on assTemplate.TEMPLATEID equals sorow.TEMPLATEID
                    from customer in customerlist
                    from so in SMOWMSDbContext.AssSalesOrders
                    where
                    ((assTemplate.TYPEID == type.Level1 && type.Level2 == "") || (assTemplate.TYPEID == type.Level2 && type.Level3 == "") ||
                     assTemplate.TYPEID == type.Level3) && sorow.CREATEDATE >= inputDto.StarTime && sorow.CREATEDATE <= inputDto.EndTime && sorow.STATUS > 0 && assTemplate.TEMPLATEID == sorow.TEMPLATEID
                    && so.CUSID == customer.CUSID && type.Level1 == type2.TYPEID
                    && so.SOID == sorow.SOID
                    select type2.NAME;
                List<string> typeList = allLevel1.ToList();
                //得到符合条件的供应商列表
                var allCustomer =
                    from assTemplate in SMOWMSDbContext.AssTemplates
                    from type in types
                    from type2 in SMOWMSDbContext.AssetsTypes
                    join sorow in SMOWMSDbContext.AssSalesOrderRows on assTemplate.TEMPLATEID equals sorow.TEMPLATEID
                    from customer in customerlist
                    from so in SMOWMSDbContext.AssSalesOrders
                    where
                    ((assTemplate.TYPEID == type.Level1 && type.Level2 == "") || (assTemplate.TYPEID == type.Level2 && type.Level3 == "") ||
                     assTemplate.TYPEID == type.Level3) && sorow.CREATEDATE >= inputDto.StarTime && sorow.CREATEDATE <= inputDto.EndTime && sorow.STATUS > 0 && assTemplate.TEMPLATEID == sorow.TEMPLATEID
                    && so.CUSID == customer.CUSID && type.Level1 == type2.TYPEID
                    && so.SOID == sorow.SOID
                    select customer.NAME;
                List<string> CusLists = allCustomer.ToList();
                foreach (var customer in CusLists)
                {
                    foreach (var tp in typeList)
                    {
                        var row = t3.Find(a => a.XValue == tp && a.Series == customer);
                        if (row == null)
                        {
                            BarChartDto dto = new BarChartDto
                            {
                                XValue = tp,
                                Series = customer,
                                YValue = 0
                            };
                            t4.Add(dto);
                        }
                        else
                        {
                            t4.Add(row);
                        }
                    }
                }



            }
            else
            {
                t4 = t3;
            }


            return t4;
        }

        public List<BarChartDto> GetAssVendorAnalysisChart(QueryAssCusandVenAnalysisInputDto inputDto)
        {
            var types = (from type1 in SMOWMSDbContext.AssetsTypes
                where type1.TLEVEL == 1
                select new
                {
                    Level1 = type1.TYPEID,
                    Level2 = "",
                    Level3 = ""
                }).Union(from type1 in SMOWMSDbContext.AssetsTypes
                where type1.TLEVEL == 2
                select new
                {
                    Level1 = type1.PARENTTYPEID,
                    Level2 = type1.TYPEID,
                    Level3 = ""
                }).Union(from type1 in SMOWMSDbContext.AssetsTypes
                join type2 in SMOWMSDbContext.AssetsTypes on type1.PARENTTYPEID equals type2.TYPEID
                where type1.TLEVEL == 3
                select new
                {
                    Level1 = type2.PARENTTYPEID,
                    Level2 = type1.PARENTTYPEID,
                    Level3 = type1.TYPEID
                });
            var vendorlist = _vendorReposity.GetAll();
            if (inputDto.ID != null)
            {
                vendorlist = vendorlist.Where(a => a.VID == inputDto.ID);
            }




            var poRowResult =
                from assTemplate in SMOWMSDbContext.AssTemplates
                from type in types
                from type2 in SMOWMSDbContext.AssetsTypes
                join porow in SMOWMSDbContext.AssPurchaseOrderRows on assTemplate.TEMPLATEID equals porow.TEMPLATEID
                from vendor in vendorlist
                from po in SMOWMSDbContext.AssPurchaseOrders
                where
                ((assTemplate.TYPEID == type.Level1 && type.Level2 == "") || (assTemplate.TYPEID == type.Level2 && type.Level3 == "") ||
                 assTemplate.TYPEID == type.Level3) && porow.CREATEDATE >= inputDto.StarTime && porow.CREATEDATE <= inputDto.EndTime && po.STATUS > 0 && po.VID == vendor.VID && po.POID == porow.POID && type.Level1 == type2.TYPEID
                select new BarChartDto()
                {
                    XValue = type2.NAME,
                    Series = vendor.NAME,

                    YValue = porow.QUANTPURCHASED
                };
            var poRowfresult = from assQuantDto in poRowResult
                group assQuantDto by new
                {
                    assQuantDto.XValue,
                    assQuantDto.Series
                }
                into quant
                select new BarChartDto()
                {
                    XValue = quant.Key.XValue,
                    Series = quant.Key.Series,
                    YValue = quant.Sum(a => a.YValue)
                };
            var t3 = poRowfresult.ToList();
            var t4 = new List<BarChartDto>();
            if (inputDto.ID == null)
            {
                //如果是全部，则需要补全数量为0的项
                //得到所有需要显示的一级资产类型
                var allLevel1 =
                    from assTemplate in SMOWMSDbContext.AssTemplates
                    from type in types
                    from type2 in SMOWMSDbContext.AssetsTypes
                    join porow in SMOWMSDbContext.AssPurchaseOrderRows on assTemplate.TEMPLATEID equals porow.TEMPLATEID
                    from vendor in vendorlist
                    from po in SMOWMSDbContext.AssPurchaseOrders
                    where
                    ((assTemplate.TYPEID == type.Level1 && type.Level2 == "") || (assTemplate.TYPEID == type.Level2 && type.Level3 == "") ||
                     assTemplate.TYPEID == type.Level3) && porow.CREATEDATE >= inputDto.StarTime && porow.CREATEDATE <= inputDto.EndTime && porow.STATUS > 0 && po.VID == vendor.VID && po.POID == porow.POID && type.Level1 == type2.TYPEID
                    select type2.NAME;
                List<string> typeList = allLevel1.ToList();
                //得到符合条件的供应商列表
                var allVendor =
                    from assTemplate in SMOWMSDbContext.AssTemplates
                    from type in types
                    from type2 in SMOWMSDbContext.AssetsTypes
                    join porow in SMOWMSDbContext.AssPurchaseOrderRows on assTemplate.TEMPLATEID equals porow.TEMPLATEID
                    from vendor in vendorlist
                    from po in SMOWMSDbContext.AssPurchaseOrders
                    where
                    ((assTemplate.TYPEID == type.Level1 && type.Level2 == "") || (assTemplate.TYPEID == type.Level2 && type.Level3 == "") ||
                     assTemplate.TYPEID == type.Level3) && porow.CREATEDATE >= inputDto.StarTime && porow.CREATEDATE <= inputDto.EndTime && porow.STATUS > 0 && po.VID == vendor.VID && po.POID == porow.POID && type.Level1 == type2.TYPEID
                    select vendor.NAME;
                List<string> vendorLists = allVendor.ToList();
                foreach (var vendor in vendorLists)
                {
                    foreach (var tp in typeList)
                    {
                        var row = t3.Find(a => a.XValue == tp && a.Series == vendor);
                        if (row == null)
                        {
                            BarChartDto dto = new BarChartDto();
                            dto.XValue = tp;
                            dto.Series = vendor;
                            dto.YValue = 0;
                            t4.Add(dto);
                        }
                        else
                        {
                            t4.Add(row);
                        }

                    }
                }



            }
            else
            {
                t4 = t3;
            }
            return t4;
        }

        public List<AssQuantDto> GetAssQuantChart(QueryAssQuantInputDto inputDto)
        {
            var asset = _assetsRepository.GetAll().Where(a => a.ISINWAREHOUSE == 1);
            if (!string.IsNullOrEmpty(inputDto.WAREID))
            {
                asset = asset.Where(a => a.WAREID == inputDto.WAREID);
            }
            var types = (from type1 in SMOWMSDbContext.AssetsTypes
                where type1.TLEVEL == 1
                select new
                {
                    Level1 = type1.TYPEID,
                    Level2 = "",
                    Level3 = ""
                }).Union(from type1 in SMOWMSDbContext.AssetsTypes
                where type1.TLEVEL == 2
                select new
                {
                    Level1 = type1.PARENTTYPEID,
                    Level2 = type1.TYPEID,
                    Level3 = ""
                }).Union(from type1 in SMOWMSDbContext.AssetsTypes
                join type2 in SMOWMSDbContext.AssetsTypes on type1.PARENTTYPEID equals type2.TYPEID
                where type1.TLEVEL == 3
                select new
                {
                    Level1 = type2.PARENTTYPEID,
                    Level2 = type1.PARENTTYPEID,
                    Level3 = type1.TYPEID
                });
            var typelist = types;
            if (!string.IsNullOrEmpty(inputDto.TYPEID))
            {
                typelist = typelist.Where(a => a.Level1 == inputDto.TYPEID);
            }
            var result = from assetse in asset
                from assTemplate in SMOWMSDbContext.AssTemplates
                from type in typelist
                from type1 in SMOWMSDbContext.AssetsTypes
                join wareHouse in SMOWMSDbContext.WareHouses on assetse.WAREID equals wareHouse.WAREID
                where assetse.TEMPLATEID == assTemplate.TEMPLATEID &&
                      ((assTemplate.TYPEID == type.Level1 && type.Level2 == "") || (assTemplate.TYPEID == type.Level2 && type.Level3 == "") ||
                       assTemplate.TYPEID == type.Level3) && type.Level1 == type1.TYPEID
                select new AssQuantDto()
                {
                    WARENAME = wareHouse.NAME,
                    TYPENAME = type1.NAME,
                    QUANT = 1
                };
            var fresult = from assQuantDto in result
                group assQuantDto by new
                {
                    assQuantDto.WARENAME,
                    assQuantDto.TYPENAME
                }
                into quant
                select new AssQuantDto()
                {
                    WARENAME = quant.Key.WARENAME,
                    TYPENAME = quant.Key.TYPENAME,
                    QUANT = quant.Count()
                };
            var quantlist = fresult.ToList();
            var all = new List<AssQuantDto>();
            if (string.IsNullOrEmpty(inputDto.TYPEID) && string.IsNullOrEmpty(inputDto.WAREID))
            {
                //如果是全部,则需要补全行项为0的项
                var warelist = from assetse in asset
                    from assTemplate in SMOWMSDbContext.AssTemplates
                    from type in typelist
                    from type1 in SMOWMSDbContext.AssetsTypes
                    join wareHouse in SMOWMSDbContext.WareHouses on assetse.WAREID equals wareHouse.WAREID
                    where assetse.TEMPLATEID == assTemplate.TEMPLATEID &&
                          ((assTemplate.TYPEID == type.Level1 && type.Level2 == "") ||
                           (assTemplate.TYPEID == type.Level2 && type.Level3 == "") ||
                           assTemplate.TYPEID == type.Level3) && type.Level1 == type1.TYPEID
                    select wareHouse.NAME;
                var typelists = from assetse in asset
                    from assTemplate in SMOWMSDbContext.AssTemplates
                    from type in typelist
                    from type1 in SMOWMSDbContext.AssetsTypes
                    join wareHouse in SMOWMSDbContext.WareHouses on assetse.WAREID equals wareHouse.WAREID
                    where assetse.TEMPLATEID == assTemplate.TEMPLATEID &&
                          ((assTemplate.TYPEID == type.Level1 && type.Level2 == "") ||
                           (assTemplate.TYPEID == type.Level2 && type.Level3 == "") ||
                           assTemplate.TYPEID == type.Level3) && type.Level1 == type1.TYPEID
                    select type1.NAME;
                foreach (var ware in warelist.ToList())
                {
                    foreach (var tp in typelists.ToList())
                    {
                        var row = quantlist.Find(a => a.TYPENAME == tp && a.WARENAME == ware);
                        if (row == null)
                        {
                            AssQuantDto dto = new AssQuantDto
                            {
                                TYPENAME = tp,
                                WARENAME = ware,
                                QUANT = 0
                            };
                            all.Add(dto);
                        }
                        else
                        {
                            all.Add(row);
                        }
                    }
                }

            }
            else
            {
                all = quantlist;
            }
            return all.ToList();
        }

        public List<AssCusAnalysisDto> GetAssCustomerAnalysis(QueryAssCusandVenAnalysisInputDto inputDto)
        {
            var types = (from type1 in SMOWMSDbContext.AssetsTypes
                where type1.TLEVEL == 1
                select new
                {
                    Level1 = type1.TYPEID,
                    Level2 = "",
                    Level3 = ""
                }).Union(from type1 in SMOWMSDbContext.AssetsTypes
                where type1.TLEVEL == 2
                select new
                {
                    Level1 = type1.PARENTTYPEID,
                    Level2 = type1.TYPEID,
                    Level3 = ""
                }).Union(from type1 in SMOWMSDbContext.AssetsTypes
                join type2 in SMOWMSDbContext.AssetsTypes on type1.PARENTTYPEID equals type2.TYPEID
                where type1.TLEVEL == 3
                select new
                {
                    Level1 = type2.PARENTTYPEID,
                    Level2 = type1.PARENTTYPEID,
                    Level3 = type1.TYPEID
                });
            var customerlist = _customerReposity.GetAll();
            if (inputDto.ID != null)
            {
                customerlist = customerlist.Where(a => a.CUSID == inputDto.ID);
            }
            var poRowResult =
                from assTemplate in SMOWMSDbContext.AssTemplates
                from type in types
                join sorow in SMOWMSDbContext.AssSalesOrderRows on assTemplate.TEMPLATEID equals sorow.TEMPLATEID
                from customer in customerlist
                from so in SMOWMSDbContext.AssSalesOrders
                where
                ((assTemplate.TYPEID == type.Level1 && type.Level2 == "") || (assTemplate.TYPEID == type.Level2 && type.Level3 == "") ||
                 assTemplate.TYPEID == type.Level3) && sorow.CREATEDATE >= inputDto.StarTime && sorow.CREATEDATE <= inputDto.EndTime && so.STATUS > 0 && assTemplate.TEMPLATEID==sorow.TEMPLATEID
&& so.CUSID == customer.CUSID
&& so.SOID == sorow.SOID
                 select new AssCusAnalysisDto()
                {
                    IMAGE = assTemplate.IMAGE,
                    NAME = assTemplate.NAME,
                    TEMPLATEID = assTemplate.TEMPLATEID,
                    CUSNAME = customer.NAME,
                    QUANTSALED = sorow.QUANTSALED
                };
            var poRowfresult = from assQuantDto in poRowResult
                group assQuantDto by new
                {
                    assQuantDto.TEMPLATEID,
                    assQuantDto.IMAGE,
                    assQuantDto.NAME,
                    assQuantDto.CUSNAME
                }
                into quant
                select new AssCusAnalysisDto()
                {
                    IMAGE = quant.Key.IMAGE,
                    NAME = quant.Key.NAME,
                    TEMPLATEID = quant.Key.TEMPLATEID,
                    CUSNAME = quant.Key.CUSNAME,
                    QUANTSALED = quant.Sum(a => a.QUANTSALED)
                };

            var t3 = poRowfresult.ToList();


            return t3;
        }



    }
}