using Autofac;
using SMOWMS.Application.IServices;
using SMOWMS.Application.Services;
using SMOWMS.Domain.IRepository;
using SMOWMS.Infrastructure;
using SMOWMS.Repository.Assets;
using SMOWMS.Repository.Consumables;
using SMOWMS.Repository.Setting;

namespace SMOWMS.UI
{
    /// <summary>
    /// Autofac配置类
    /// </summary>
    public class AutofacConfig
    {
        /// <summary>
        /// 库位相关服务接口
        /// </summary>
        public IWareHouseService wareHouseService;
        /// <summary>
        /// 资产分类相关服务接口
        /// </summary>
        public IAssTypeService assTypeService;

        /// <summary>
        /// 各种单据的服务接口，具体啥，自己去看
        /// </summary>
        public ISettingService SettingService;
        /// <summary>
        /// 调拨单相关服务接口
        /// </summary>
        public IAssTransferOrderService assTransferOrderService;
        /// <summary>
        /// 单据通用服务接口
        /// </summary>
        public IOrderCommonService orderCommonService;
        /// <summary>
        /// 用户服务接口
        /// </summary>
        public IcoreUserService coreUserService;
        /// <summary>
        /// 验证表服务接口
        /// </summary>
        public IValidateCodeService ValidateCodeService;

        /// <summary>
        /// Ioc容器
        /// </summary>
        private ContainerBuilder containerBuilder;

        /// <summary>
        /// 耗材服务接口
        /// </summary>
        public IConsumablesService consumablesService;
        /// <summary>
        /// 客户服务接口
        /// </summary>
        public ICustomerService customerService;
        /// <summary>
        /// 供货商服务接口
        /// </summary>
        public IVendorService vendorService;
        /// <summary>
        /// 耗材盘点单服务接口
        /// </summary>
        public IConInventoryService ConInventoryService;
        /// <summary>
        /// 耗材采购单服务接口
        /// </summary>
        public IConPurchaseOrderService ConPurchaseOrderService;
        /// <summary>
        /// 耗材销售单服务接口
        /// </summary>
        public IConSalesOrderService ConSalesOrderService;
        /// <summary>
        /// 资产盘点单服务接口
        /// </summary>
        public IAssInventoryService AssInventoryService;

        /// <summary>
        /// 资产采购单服务接口
        /// </summary>
        public IAssPurchaseOrderService AssPurchaseOrderService;

        /// <summary>
        /// 资产销售单服务接口
        /// </summary>
        public IAssSalesOrderService AssSalesOrderService;

        /// <summary>
        /// 资产分析服务接口
        /// </summary>
        public IAssAnalysisService AssAnalysisService;
        /// <summary>
        /// 初始化
        /// </summary>
        public void Init()
        {
            this.containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterType<SMOWMSDbContext>().As<IDbContext>().SingleInstance();
            containerBuilder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();

            containerBuilder.RegisterType<CustomerReposity>().As<ICustomerReposity>().InstancePerDependency();
            containerBuilder.RegisterType<VendorReposity>().As<IVendorReposity>().InstancePerDependency();
            containerBuilder.RegisterType<WarehouseRepository>().As<IWarehouseRepository>().InstancePerDependency();
            containerBuilder.RegisterType<WHStorageTypeReposity>().As<IWHStorageTypeReposity>().InstancePerDependency();
            containerBuilder.RegisterType<WHStorageLocationRepository>().As<IWHStorageLocationRepository>().InstancePerDependency();
            containerBuilder.RegisterType<AssetsRepository>().As<IAssetsRepository>().InstancePerLifetimeScope();
            containerBuilder.RegisterType<AssetsTypeRepository>().As<IAssetsTypeRepository>().InstancePerDependency();
            containerBuilder.RegisterType<AssTemplateRepository>().As<IAssTemplateRepository>().InstancePerDependency();
            containerBuilder.RegisterType<AssTransferOrderRepository>().As<IAssTransferOrderRepository>().InstancePerDependency();
            containerBuilder.RegisterType<AssTransferOrderRowRepository>().As<IAssTransferOrderRowRepository>().InstancePerDependency();
            containerBuilder.RegisterType<AssProcessRecordRepository>().As<IAssProcessRecordRepository>().InstancePerDependency();
            containerBuilder.RegisterType<coreUserRepository>().As<IcoreUserRepository>().InstancePerDependency();
            containerBuilder.RegisterType<ValidateCodeRepository>().As<IValidateCodeRepository>().InstancePerDependency();
            containerBuilder.RegisterType<AssProcessRecordRepository>().As<IAssProcessRecordRepository>().InstancePerDependency();

            containerBuilder.RegisterType<ConQuantRepository>().As<IConQuantRepository>().InstancePerDependency();
            containerBuilder.RegisterType<ConsumablesRepository>().As<IConsumablesRepository>().InstancePerDependency();
            containerBuilder.RegisterType<ConPurchaseOrderReposity>().As<IConPurchaseOrderReposity>().InstancePerDependency();
            containerBuilder.RegisterType<ConPurchaseOrderRowReposity>().As<IConPurchaseOrderRowReposity>().InstancePerDependency();
            containerBuilder.RegisterType<ConPurchaseOrderInstorageReposity>().As<IConPurchaseOrderInstorageReposity>().InstancePerDependency();
            containerBuilder.RegisterType<ConPurchaseOrderReturnReposity>().As<IConPurchaseOrderReturnReposity>().InstancePerDependency();
            containerBuilder.RegisterType<ConSalesOrderReposity>().As<IConSalesOrderReposity>().InstancePerDependency();
            containerBuilder.RegisterType<ConSalesOrderRowReposity>().As<IConSalesOrderRowReposity>().InstancePerDependency();
            containerBuilder.RegisterType<ConSalesOrderOutboundReposity>().As<IConSalesOrderOutboundReposity>().InstancePerDependency();
            containerBuilder.RegisterType<ConSalesOrderRetiringReposity>().As<IConSalesOrderRetiringReposity>().InstancePerDependency();

            containerBuilder.RegisterType<AssInventoryRepository>().As<IAssInventoryRepository>()
                .InstancePerDependency();
            containerBuilder.RegisterType<AssInventoryResultRepository>().As<IAssInventoryResultRepository>()
                .InstancePerDependency();
            containerBuilder.RegisterType<ConInventoryRepository>().As<IConInventoryRepository>()
                .InstancePerDependency();
            containerBuilder.RegisterType<ConInventoryResultRepository>().As<IConInventoryResultRepository>()
                .InstancePerDependency();
            containerBuilder.RegisterType<AssPurchaseOrderRepository>().As<IAssPurchaseOrderRepository>()
                .InstancePerDependency();
            containerBuilder.RegisterType<AssPORowRepository>().As<IAssPORowRepository>()
                .InstancePerDependency();
            containerBuilder.RegisterType<AssPOInstorageRepository>().As<IAssPOInstorageRepository>()
                .InstancePerDependency();
            containerBuilder.RegisterType<AssSalesOrderRepository>().As<IAssSalesOrderRepository>()
                .InstancePerDependency();
            containerBuilder.RegisterType<AssSOOutboundRepository>().As<IAssSOOutboundRepository>()
                .InstancePerDependency();
            containerBuilder.RegisterType<AssSORowRepository>().As<IAssSORowRepository>()
                .InstancePerDependency();
            containerBuilder.RegisterType<AssTemplateRepository>().As<IAssTemplateRepository>()
                .InstancePerDependency();

            containerBuilder.RegisterType<CustomerService>().As<ICustomerService>().InstancePerLifetimeScope();
            containerBuilder.RegisterType<VendorService>().As<IVendorService>().InstancePerLifetimeScope();
            containerBuilder.RegisterType<WareHouseService>().As<IWareHouseService>().InstancePerLifetimeScope();
            containerBuilder.RegisterType<AssTypeService>().As<IAssTypeService>().InstancePerLifetimeScope();
            containerBuilder.RegisterType<SettingService>().As<ISettingService>().InstancePerLifetimeScope();
            containerBuilder.RegisterType<coreUserService>().As<IcoreUserService>().InstancePerLifetimeScope();
            containerBuilder.RegisterType<ValidateCodeService>().As<IValidateCodeService>().InstancePerLifetimeScope();
            containerBuilder.RegisterType<OrderCommonService>().As<IOrderCommonService>().InstancePerLifetimeScope();
            containerBuilder.RegisterType<AssTransferOrderService>().As<IAssTransferOrderService>().InstancePerLifetimeScope();
            containerBuilder.RegisterType<ConInventoryService>().As<IConInventoryService>().InstancePerLifetimeScope();
            containerBuilder.RegisterType<AssInventoryService>().As<IAssInventoryService>().InstancePerLifetimeScope();
            containerBuilder.RegisterType<ConsumablesService>().As<IConsumablesService>().InstancePerLifetimeScope();
            containerBuilder.RegisterType<ConPurchaseOrderService>().As<IConPurchaseOrderService>().InstancePerLifetimeScope();
            containerBuilder.RegisterType<ConSalesOrderService>().As<IConSalesOrderService>().InstancePerLifetimeScope();
            containerBuilder.RegisterType<AssPurchaseOrderService>().As<IAssPurchaseOrderService>().InstancePerLifetimeScope();
            containerBuilder.RegisterType<AssSalesOrderService>().As<IAssSalesOrderService>().InstancePerLifetimeScope();
            containerBuilder.RegisterType<AssAnalysisService>().As<IAssAnalysisService>().InstancePerLifetimeScope();

        }

        /// <summary>
        /// 构造函数,最终得到新的服务实例
        /// </summary>
        public AutofacConfig()
        {
            if (this.containerBuilder == null)
            {
                Init();
            }
            IContainer container = this.containerBuilder.Build();
            IDbContext db = container.Resolve<IDbContext>();
            this.customerService = container.Resolve<ICustomerService>();
            this.vendorService = container.Resolve<IVendorService>();
            this.wareHouseService = container.Resolve<IWareHouseService>();
            this.coreUserService = container.Resolve<IcoreUserService>();
            this.ValidateCodeService = container.Resolve<IValidateCodeService>();
            this.assTypeService = container.Resolve<IAssTypeService>();
            this.orderCommonService = container.Resolve<IOrderCommonService>();
            this.assTransferOrderService = container.Resolve<IAssTransferOrderService>();
            this.SettingService = container.Resolve<ISettingService>();
            this.ConInventoryService = container.Resolve<IConInventoryService>();
            this.AssInventoryService = container.Resolve<IAssInventoryService>();
            this.consumablesService = container.Resolve<IConsumablesService>();
            this.ConPurchaseOrderService = container.Resolve<IConPurchaseOrderService>();
            this.ConSalesOrderService = container.Resolve<IConSalesOrderService>();
            this.AssPurchaseOrderService = container.Resolve<IAssPurchaseOrderService>();
            this.AssSalesOrderService = container.Resolve<IAssSalesOrderService>();
            this.AssAnalysisService = container.Resolve<IAssAnalysisService>();
        }
    }
}
