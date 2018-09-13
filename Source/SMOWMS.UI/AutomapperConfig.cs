using AutoMapper;
using SMOWMS.Domain.Entity;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.DTOs.OutputDTO;

namespace SMOWMS.UI
{
    /// <summary>
    /// AutoMapper配置类
    /// </summary>
    public static class AutomapperConfig
    {
        public static void Init()
        {
            //映射InputDto到Entity
            Mapper.Initialize(x =>
            {
                //映射InputDto到Entity
                x.CreateMap<AssetsInputDto, Assets>();
                x.CreateMap<ConsumablesInputDto, Consumables>();
                x.CreateMap<AssInventoryInputDto, AssInventory>();
                x.CreateMap<AssPurchaseOrderInputDto, AssPurchaseOrder>();
                x.CreateMap<AssSalesOrderInputDto, AssSalesOrder>();
                x.CreateMap<WHStorageLocationInputDto, WHStorageLocation>();
                x.CreateMap<WareHouseInputDto, WareHouse>();
                x.CreateMap<WHStorageTypeInputDto, WHStorageType>();


                //耗材盘点映射
                x.CreateMap<ConInventoryInputDto, ConInventory>();
                x.CreateMap<ConInventory, ConInventoryOutputDto>();

                //耗材采购映射
                x.CreateMap<ConPurchaseOrderInputDto, ConPurchaseOrder>();
                x.CreateMap<ConPurchaseOrderRowInputDto, ConPurchaseOrderRow>();
                //耗材销售映射
                x.CreateMap<ConSalesOrderInputDto, ConSalesOrder>();
                x.CreateMap<ConSalesOrderRowInputDto, ConSalesOrderRow>();

                //映射Entity到查询用的Dto
                x.CreateMap<Assets, AssetsOutputDto>();
                x.CreateMap<AssTransferOrder, TOInputDto>();
                x.CreateMap<Consumables, ConsumablesOutputDto>();
                x.CreateMap<AssInventory, AssInventoryOutputDto>();
                x.CreateMap<AssPORowOutputDto, AssRowInputDto>();
                x.CreateMap<AssSORowOutputDto, AssRowInputDto>();
                x.CreateMap<AssRowInputDto, AssPurchaseOrderRow>();
                x.CreateMap<AssRowInputDto, AssSalesOrderRow>();
                
            });
        }
    }
}
