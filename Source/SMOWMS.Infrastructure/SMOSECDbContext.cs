using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using SMOWMS.Domain.Entity;

namespace SMOWMS.Infrastructure
{
    public class SMOWMSDbContext : DbContext, IDbContext
    {
        #region 构造函数

        /// <summary>
        ///     初始化一个 使用连接名称为“default”的数据访问上下文类 的新实例
        /// </summary>
        public SMOWMSDbContext()
            : base("default")
        {
            //手动创建了数据库和表,不用产生系统表
            //if (!Database.Exists("default"))
            //{
            //    Database.SetInitializer<SMOSECDbContext>(
            //            new DropCreateDatabaseIfModelChanges<SMOSECDbContext>());
            //}
            //自动创建更新数据库和表,产生系统表
            Database.SetInitializer<SMOWMSDbContext>(
                    new DropCreateDatabaseIfModelChanges<SMOWMSDbContext>());
            this.Configuration.LazyLoadingEnabled = false;

        }

        /// <summary>
        /// 初始化一个 使用指定数据连接名称或连接串 的数据访问上下文类 的新实例
        /// </summary>
        public SMOWMSDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString) { }

        #endregion

        #region 属性

        /// <summary>
        /// 申明所需要映射的所有类
        /// </summary>
        public DbSet<Assets> Assetss { get; set; }
//        public DbSet<AssetsSN> AssetsSNs { get; set; }
        public DbSet<AssetsType> AssetsTypes { get; set; }
        public DbSet<AssTransferOrder> AssTransferOrders { get; set; }
        public DbSet<AssTransferOrderRow> AssTransferOrderRows { get; set; }

        public DbSet<coreUser> coreUsers { get; set; }
        public DbSet<ValidateCode> ValidateCodes { get; set; }

        public DbSet<AssProcessRecord> AssProcessRecords { get; set; }
        public DbSet<AssTemplate> AssTemplates { get; set; }
        public DbSet<Consumables> Consumableses { get; set; }
        public DbSet<WareHouse> WareHouses { get; set; }
        public DbSet<ConQuant> ConQuants { get; set; }

        public DbSet<AssInventory> AssInventories { get; set; }
        public DbSet<AssInventoryResult> AssInventoryResults { get; set; }
        public DbSet<ConInventory> ConInventories { get; set; }
        public DbSet<ConInventoryResult> ConInventoryResults { get; set; }
        public DbSet<WHStorageType> WHStorageTypes { get; set; }
        public DbSet<WHStorageLocation> WHStorageLocations { get; set; }

        public DbSet<AssSalesOrder> AssSalesOrders { get; set; }
        public DbSet<AssSalesOrderRow> AssSalesOrderRows { get; set; }
        public DbSet<AssPurchaseOrder> AssPurchaseOrders { get; set; }
        public DbSet<AssPurchaseOrderRow> AssPurchaseOrderRows { get; set; }
        public DbSet<ConSalesOrder> ConSalesOrders { get; set; }
        public DbSet<ConSalesOrderRow> ConSalesOrderRows { get; set; }
        public DbSet<ConPurchaseOrder> ConPurchaseOrders { get; set; }
        public DbSet<ConPurchaseOrderRow> ConPurchaseOrderRows { get; set; }

        public DbSet<AssPurchaseOrderInstorage> AssPurchaseOrderInstorages { get; set; }
        public DbSet<AssPurchaseOrderReturn> AssPurchaseOrderReturns { get; set; }
        public DbSet<AssSalesOrderOutbound> AssSalesOrderOutbounds { get; set; }
        public DbSet<AssSalesOrderRetiring> AssSalesOrderRetirings { get; set; }
        public DbSet<ConPurchaseOrderInstorage> ConPurchaseOrderInstorages { get; set; }
        public DbSet<ConPurchaseOrderReturn> ConPurchaseOrderReturns { get; set; }
        public DbSet<ConSalesOrderOutbound> ConSalesOrderOutbounds { get; set; }
        public DbSet<ConSalesOrderRetiring> ConSalesOrderRetirings { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Vendor> Vendors { get; set; }

        #endregion

        /// <summary>
        /// 数据库模型产生时执行
        /// </summary>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //移除一对多的级联删除约定，想要级联删除可以在 EntityTypeConfiguration<TEntity>的实现类中进行控制
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            //比较基础的映射配置,在Domain的Entity文件夹下已经配置了(通过Data Annotations)
            //配置需要额外映射的属性（通过Fluent API）
            base.OnModelCreating(modelBuilder);
        }
    }
}
