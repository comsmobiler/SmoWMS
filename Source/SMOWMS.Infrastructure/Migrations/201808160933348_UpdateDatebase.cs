namespace SMOWMS.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatebase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        CUSID = c.Int(nullable: false, identity: true),
                        NAME = c.String(nullable: false, maxLength: 50),
                        FAX = c.String(maxLength: 50),
                        EMAIL = c.String(maxLength: 200),
                        ADDRESS = c.String(maxLength: 200),
                        NOTE = c.String(maxLength: 200),
                        TAXNUMBER = c.String(maxLength: 200),
                        BANK = c.String(maxLength: 200),
                        ACCOUNT = c.String(maxLength: 200),
                        CONTACTS = c.String(maxLength: 50),
                        PHONE = c.String(maxLength: 50),
                        CREATEDATE = c.DateTime(nullable: false),
                        CREATEUSER = c.String(maxLength: 20),
                        MODIFYDATE = c.DateTime(nullable: false),
                        MODIFYUSER = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.CUSID);
            
            CreateTable(
                "dbo.Vendor",
                c => new
                    {
                        VID = c.Int(nullable: false, identity: true),
                        NAME = c.String(nullable: false, maxLength: 50),
                        FAX = c.String(maxLength: 50),
                        EMAIL = c.String(maxLength: 200),
                        PHONE = c.String(maxLength: 50),
                        NOTE = c.String(maxLength: 200),
                        CONTACTS = c.String(maxLength: 50),
                        ADDRESS = c.String(maxLength: 200),
                        TAXNUMBER = c.String(maxLength: 200),
                        BANK = c.String(maxLength: 200),
                        ACCOUNT = c.String(maxLength: 200),
                        CREATEDATE = c.DateTime(nullable: false),
                        CREATEUSER = c.String(maxLength: 20),
                        MODIFYDATE = c.DateTime(nullable: false),
                        MODIFYUSER = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.VID);
            
            AddColumn("dbo.AssTemplate", "TYPEID", c => c.String(nullable: false, maxLength: 4));
            AddColumn("dbo.WHStorageLocation", "ISENABLE", c => c.Int(nullable: false));
            DropColumn("dbo.AssPurchaseOrderRow", "QUANT");
            DropColumn("dbo.AssPurchaseOrderRow", "PRICE");
            DropColumn("dbo.AssSalesOrderRow", "PRICE");
            DropColumn("dbo.AssSalesOrderRow", "QUANT");
            DropColumn("dbo.ConPurchaseOrderRow", "QUANT");
            DropColumn("dbo.ConPurchaseOrderRow", "PRICE");
            DropColumn("dbo.ConSalesOrderRow", "PRICE");
            DropColumn("dbo.ConSalesOrderRow", "QUANT");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ConSalesOrder", "SLID", c => c.String(nullable: false, maxLength: 4));
            AddColumn("dbo.ConSalesOrder", "STID", c => c.String(nullable: false, maxLength: 10));
            AddColumn("dbo.ConSalesOrder", "WAREID", c => c.String(nullable: false, maxLength: 10));
            AddColumn("dbo.ConSalesOrderRow", "QUANT", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.ConSalesOrderRow", "PRICE", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.ConPurchaseOrderRow", "PRICE", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.ConPurchaseOrderRow", "QUANT", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.AssSalesOrder", "SLID", c => c.String(nullable: false, maxLength: 4));
            AddColumn("dbo.AssSalesOrder", "STID", c => c.String(nullable: false, maxLength: 10));
            AddColumn("dbo.AssSalesOrder", "WAREID", c => c.String(nullable: false, maxLength: 10));
            AddColumn("dbo.AssSalesOrderRow", "QUANT", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.AssSalesOrderRow", "PRICE", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.AssPurchaseOrderRow", "PRICE", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.AssPurchaseOrderRow", "QUANT", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.WHStorageLocation", "ISENABLE");
            DropColumn("dbo.AssTemplate", "TYPEID");
            DropTable("dbo.Vendor");
            DropTable("dbo.Customer");
        }
    }
}
