namespace SMOWMS.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Assets",
                c => new
                    {
                        ASSID = c.String(nullable: false, maxLength: 20),
                        TYPEID = c.String(nullable: false, maxLength: 4),
                        NAME = c.String(nullable: false, maxLength: 50),
                        IMAGE = c.String(maxLength: 200),
                        SPECIFICATION = c.String(maxLength: 200),
                        SN = c.String(maxLength: 200),
                        UNIT = c.String(maxLength: 6),
                        PRICE = c.Decimal(precision: 18, scale: 2),
                        BUYDATE = c.DateTime(nullable: false),
                        SLID = c.String(nullable: false, maxLength: 4),
                        WAREID = c.String(nullable: false, maxLength: 10),
                        STID = c.String(nullable: false, maxLength: 10),
                        PLACE = c.String(maxLength: 50),
                        EXPIRYDATE = c.DateTime(nullable: false),
                        VENDOR = c.String(maxLength: 10),
                        NOTE = c.String(maxLength: 200),
                        CREATEDATE = c.DateTime(nullable: false),
                        CREATEUSER = c.String(maxLength: 20),
                        MODIFYDATE = c.DateTime(nullable: false),
                        MODIFYUSER = c.String(maxLength: 20),
                        STATUS = c.Int(),
                        ISLOCKED = c.Int(nullable: false),
                        TEMPLATEID = c.String(nullable: false, maxLength: 20),
                        ISINWAREHOUSE = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ASSID);
            
            CreateTable(
                "dbo.AssetsType",
                c => new
                    {
                        TYPEID = c.String(nullable: false, maxLength: 128),
                        NAME = c.String(),
                        TLEVEL = c.Int(),
                        EXPIRYDATE = c.Int(nullable: false),
                        EXPIRYDATEUNIT = c.Int(),
                        ISENABLE = c.Int(),
                        PARENTTYPEID = c.String(),
                        CREATEUSER = c.String(),
                    })
                .PrimaryKey(t => t.TYPEID);
            
            CreateTable(
                "dbo.AssInventory",
                c => new
                    {
                        IID = c.String(nullable: false, maxLength: 20),
                        NAME = c.String(nullable: false, maxLength: 200),
                        HANDLEMAN = c.String(nullable: false, maxLength: 20),
                        WAREID = c.String(nullable: false, maxLength: 10),
                        STID = c.String(maxLength: 10),
                        SLID = c.String(maxLength: 4),
                        TYPEID = c.String(maxLength: 10),
                        STATUS = c.Int(nullable: false),
                        CREATEDATE = c.DateTime(nullable: false),
                        CREATEUSER = c.String(maxLength: 20),
                        MODIFYDATE = c.DateTime(nullable: false),
                        MODIFYUSER = c.String(maxLength: 20),
                        TOTAL = c.Int(nullable: false),
                        RESULTCOUNT = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IID);
            
            CreateTable(
                "dbo.AssInventoryResult",
                c => new
                    {
                        RROWID = c.Int(nullable: false, identity: true),
                        IID = c.String(nullable: false, maxLength: 20),
                        ASSID = c.String(nullable: false, maxLength: 20),
                        RESULT = c.Int(nullable: false),
                        CREATEDATE = c.DateTime(nullable: false),
                        CREATEUSER = c.String(maxLength: 20),
                        MODIFYDATE = c.DateTime(nullable: false),
                        MODIFYUSER = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.RROWID);
            
            CreateTable(
                "dbo.AssProcessRecord",
                c => new
                    {
                        PRID = c.Int(nullable: false, identity: true),
                        ASSID = c.String(maxLength: 20),
                        CID = c.String(maxLength: 20),
                        HANDLEDATE = c.DateTime(nullable: false),
                        HANDLEMAN = c.String(nullable: false, maxLength: 20),
                        PROCESSMODE = c.Int(nullable: false),
                        PROCESSCONTENT = c.String(),
                        CREATEDATE = c.DateTime(nullable: false),
                        CREATEUSER = c.String(maxLength: 20),
                        MODIFYDATE = c.DateTime(nullable: false),
                        MODIFYUSER = c.String(maxLength: 20),
                        QUANTITY = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.PRID);
            
            CreateTable(
                "dbo.AssPurchaseOrderInstorage",
                c => new
                    {
                        POISID = c.Int(nullable: false, identity: true),
                        POID = c.String(nullable: false, maxLength: 20),
                        TEMPLATEID = c.String(nullable: false, maxLength: 20),
                        SN = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.POISID);
            
            CreateTable(
                "dbo.AssPurchaseOrderReturn",
                c => new
                    {
                        PORID = c.Int(nullable: false, identity: true),
                        POID = c.String(nullable: false, maxLength: 20),
                        TEMPLATEID = c.String(nullable: false, maxLength: 20),
                        SN = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.PORID);
            
            CreateTable(
                "dbo.AssPurchaseOrderRow",
                c => new
                    {
                        POROWID = c.Int(nullable: false, identity: true),
                        POID = c.String(nullable: false, maxLength: 20),
                        TEMPLATEID = c.String(nullable: false, maxLength: 20),
                        QUANT = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PRICE = c.Decimal(nullable: false, precision: 18, scale: 2),
                        REALPRICE = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QUANTPURCHASED = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QUANTSTORED = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QUANTRETREATED = c.Decimal(nullable: false, precision: 18, scale: 2),
                        STATUS = c.Int(nullable: false),
                        CREATEUSER = c.String(maxLength: 20),
                        CREATEDATE = c.DateTime(nullable: false),
                        MODIFYUSER = c.String(maxLength: 20),
                        MODIFYDATE = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.POROWID);
            
            CreateTable(
                "dbo.AssPurchaseOrder",
                c => new
                    {
                        POID = c.String(nullable: false, maxLength: 20),
                        REALID = c.String(maxLength: 50),
                        NAME = c.String(nullable: false, maxLength: 50),
                        PURCHASER = c.String(nullable: false, maxLength: 20),
                        STATUS = c.Int(nullable: false),
                        CREATEUSER = c.String(maxLength: 20),
                        CREATEDATE = c.DateTime(nullable: false),
                        MODIFYUSER = c.String(maxLength: 20),
                        MODIFYDATE = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.POID);
            
            CreateTable(
                "dbo.AssSalesOrderOutbound",
                c => new
                    {
                        SOOBID = c.Int(nullable: false, identity: true),
                        SOID = c.String(nullable: false, maxLength: 20),
                        TEMPLATEID = c.String(nullable: false, maxLength: 20),
                        SN = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.SOOBID);
            
            CreateTable(
                "dbo.AssSalesOrderRetiring",
                c => new
                    {
                        SORID = c.Int(nullable: false, identity: true),
                        SOID = c.String(nullable: false, maxLength: 20),
                        TEMPLATEID = c.String(nullable: false, maxLength: 20),
                        SN = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.SORID);
            
            CreateTable(
                "dbo.AssSalesOrderRow",
                c => new
                    {
                        SOROWID = c.Int(nullable: false, identity: true),
                        SOID = c.String(nullable: false, maxLength: 20),
                        TEMPLATEID = c.String(nullable: false, maxLength: 20),
                        STATUS = c.Int(nullable: false),
                        PRICE = c.Decimal(nullable: false, precision: 18, scale: 2),
                        REALPRICE = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QUANT = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QUANTSALED = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QUANTOUT = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QUANTRETREATED = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CREATEUSER = c.String(maxLength: 20),
                        CREATEDATE = c.DateTime(nullable: false),
                        MODIFYUSER = c.String(maxLength: 20),
                        MODIFYDATE = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SOROWID);
            
            CreateTable(
                "dbo.AssSalesOrder",
                c => new
                    {
                        SOID = c.String(nullable: false, maxLength: 20),
                        REALID = c.String(maxLength: 50),
                        NAME = c.String(nullable: false, maxLength: 50),
                        SALESPERSON = c.String(nullable: false, maxLength: 20),
                        STATUS = c.Int(nullable: false),
                        CREATEUSER = c.String(maxLength: 20),
                        CREATEDATE = c.DateTime(nullable: false),
                        MODIFYUSER = c.String(maxLength: 20),
                        MODIFYDATE = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SOID);
            
            CreateTable(
                "dbo.AssTemplate",
                c => new
                    {
                        TEMPLATEID = c.String(nullable: false, maxLength: 20),
                        NAME = c.String(nullable: false, maxLength: 50),
                        IMAGE = c.String(maxLength: 200),
                        SPECIFICATION = c.String(maxLength: 200),
                        UNIT = c.String(maxLength: 6),
                        PRICE = c.Decimal(precision: 18, scale: 2),
                        MANAGER = c.String(maxLength: 20),
                        VENDOR = c.String(maxLength: 10),
                        NOTE = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.TEMPLATEID);
            
            CreateTable(
                "dbo.AssTransferOrderRow",
                c => new
                    {
                        TOROWID = c.String(nullable: false, maxLength: 128),
                        TOID = c.String(nullable: false, maxLength: 128),
                        IMAGE = c.String(),
                        ASSID = c.String(),
                        SN = c.String(),
                        CID = c.String(),
                        SLID = c.String(nullable: false, maxLength: 4),
                        WAREID = c.String(nullable: false, maxLength: 10),
                        STID = c.String(nullable: false, maxLength: 10),
                        INTRANSFERQTY = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TRANSFEREDQTY = c.Decimal(precision: 18, scale: 2),
                        TRANSFERCANCELQTY = c.Decimal(precision: 18, scale: 2),
                        CURRENTDEP = c.String(),
                        CURRENTUSER = c.String(),
                        PLACE = c.String(),
                        STATUS = c.Int(),
                        CREATEUSER = c.String(),
                        CREATEDATE = c.DateTime(),
                    })
                .PrimaryKey(t => new { t.TOROWID, t.TOID });
            
            CreateTable(
                "dbo.AssTransferOrder",
                c => new
                    {
                        TOID = c.String(nullable: false, maxLength: 128),
                        DESSLID = c.String(),
                        WAREID = c.String(nullable: false, maxLength: 10),
                        STID = c.String(nullable: false, maxLength: 10),
                        MANAGER = c.String(),
                        TRANSFERDATE = c.DateTime(),
                        HANDLEMAN = c.String(),
                        HANDLEDATE = c.DateTime(),
                        STATUS = c.Int(),
                        TYPE = c.Int(nullable: false),
                        NOTE = c.String(),
                        CREATEUSER = c.String(),
                        CREATEDATE = c.DateTime(),
                        MODIFYDATE = c.DateTime(),
                        MODIFYUSER = c.String(),
                    })
                .PrimaryKey(t => t.TOID);
            
            CreateTable(
                "dbo.ConInventory",
                c => new
                    {
                        IID = c.String(nullable: false, maxLength: 20),
                        NAME = c.String(nullable: false, maxLength: 200),
                        HANDLEMAN = c.String(nullable: false, maxLength: 20),
                        WAREID = c.String(nullable: false, maxLength: 10),
                        STID = c.String(maxLength: 10),
                        SLID = c.String(maxLength: 4),
                        STATUS = c.Int(nullable: false),
                        TOTAL = c.Int(nullable: false),
                        RESULTCOUNT = c.Int(nullable: false),
                        CREATEDATE = c.DateTime(nullable: false),
                        CREATEUSER = c.String(maxLength: 20),
                        MODIFYDATE = c.DateTime(nullable: false),
                        MODIFYUSER = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.IID);
            
            CreateTable(
                "dbo.ConInventoryResult",
                c => new
                    {
                        RROWID = c.Int(nullable: false, identity: true),
                        IID = c.String(nullable: false, maxLength: 20),
                        CID = c.String(nullable: false, maxLength: 20),
                        TOTAL = c.Decimal(nullable: false, precision: 18, scale: 2),
                        REALAMOUNT = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RESULT = c.Int(nullable: false),
                        CREATEDATE = c.DateTime(nullable: false),
                        CREATEUSER = c.String(maxLength: 20),
                        MODIFYDATE = c.DateTime(nullable: false),
                        MODIFYUSER = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.RROWID);
            
            CreateTable(
                "dbo.ConPurchaseOrderInstorage",
                c => new
                    {
                        POISID = c.Int(nullable: false, identity: true),
                        POID = c.String(nullable: false, maxLength: 20),
                        POROWID = c.Int(nullable: false),
                        WAREID = c.String(nullable: false, maxLength: 10),
                        STID = c.String(nullable: false, maxLength: 10),
                        SLID = c.String(nullable: false, maxLength: 4),
                        QUANT = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.POISID);
            
            CreateTable(
                "dbo.ConPurchaseOrderReturn",
                c => new
                    {
                        PORID = c.Int(nullable: false, identity: true),
                        POID = c.String(nullable: false, maxLength: 20),
                        POROWID = c.Int(nullable: false),
                        WAREID = c.String(nullable: false, maxLength: 10),
                        STID = c.String(nullable: false, maxLength: 10),
                        SLID = c.String(nullable: false, maxLength: 4),
                        QUANT = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.PORID);
            
            CreateTable(
                "dbo.ConPurchaseOrderRow",
                c => new
                    {
                        POROWID = c.Int(nullable: false, identity: true),
                        POID = c.String(nullable: false, maxLength: 20),
                        CID = c.String(nullable: false, maxLength: 20),
                        QUANT = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PRICE = c.Decimal(nullable: false, precision: 18, scale: 2),
                        REALPRICE = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QUANTPURCHASED = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QUANTSTORED = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QUANTRETREATED = c.Decimal(nullable: false, precision: 18, scale: 2),
                        STATUS = c.Int(nullable: false),
                        CREATEUSER = c.String(maxLength: 20),
                        CREATEDATE = c.DateTime(nullable: false),
                        MODIFYUSER = c.String(maxLength: 20),
                        MODIFYDATE = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.POROWID);
            
            CreateTable(
                "dbo.ConPurchaseOrder",
                c => new
                    {
                        POID = c.String(nullable: false, maxLength: 20),
                        REALID = c.String(maxLength: 50),
                        NAME = c.String(nullable: false, maxLength: 50),
                        PURCHASER = c.String(nullable: false, maxLength: 20),
                        STATUS = c.Int(nullable: false),
                        CREATEUSER = c.String(maxLength: 20),
                        CREATEDATE = c.DateTime(nullable: false),
                        MODIFYUSER = c.String(maxLength: 20),
                        MODIFYDATE = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.POID);
            
            CreateTable(
                "dbo.ConQuant",
                c => new
                    {
                        QID = c.Int(nullable: false, identity: true),
                        CID = c.String(nullable: false, maxLength: 20),
                        SLID = c.String(nullable: false, maxLength: 4),
                        WAREID = c.String(nullable: false, maxLength: 10),
                        STID = c.String(nullable: false, maxLength: 10),
                        QUANTITY = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CREATEDATE = c.DateTime(nullable: false),
                        CREATEUSER = c.String(maxLength: 20),
                        MODIFYDATE = c.DateTime(nullable: false),
                        MODIFYUSER = c.String(maxLength: 20),
                        ISLOCKED = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.QID);
            
            CreateTable(
                "dbo.ConSalesOrderOutbound",
                c => new
                    {
                        SOOBID = c.Int(nullable: false, identity: true),
                        SOID = c.String(nullable: false, maxLength: 20),
                        SOROWID = c.Int(nullable: false),
                        WAREID = c.String(nullable: false, maxLength: 10),
                        STID = c.String(nullable: false, maxLength: 10),
                        SLID = c.String(nullable: false, maxLength: 4),
                        QUANT = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.SOOBID);
            
            CreateTable(
                "dbo.ConSalesOrderRetiring",
                c => new
                    {
                        SORID = c.Int(nullable: false, identity: true),
                        SOID = c.String(nullable: false, maxLength: 20),
                        SOROWID = c.Int(nullable: false),
                        WAREID = c.String(nullable: false, maxLength: 10),
                        STID = c.String(nullable: false, maxLength: 10),
                        SLID = c.String(nullable: false, maxLength: 4),
                        QUANT = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.SORID);
            
            CreateTable(
                "dbo.ConSalesOrderRow",
                c => new
                    {
                        SOROWID = c.Int(nullable: false, identity: true),
                        SOID = c.String(nullable: false, maxLength: 20),
                        CID = c.String(nullable: false, maxLength: 20),
                        STATUS = c.Int(nullable: false),
                        PRICE = c.Decimal(nullable: false, precision: 18, scale: 2),
                        REALPRICE = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QUANT = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QUANTSALED = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QUANTOUT = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QUANTRETREATED = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CREATEUSER = c.String(maxLength: 20),
                        CREATEDATE = c.DateTime(nullable: false),
                        MODIFYUSER = c.String(maxLength: 20),
                        MODIFYDATE = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SOROWID);
            
            CreateTable(
                "dbo.ConSalesOrder",
                c => new
                    {
                        SOID = c.String(nullable: false, maxLength: 20),
                        REALID = c.String(maxLength: 50),
                        NAME = c.String(nullable: false, maxLength: 50),
                        SALESPERSON = c.String(nullable: false, maxLength: 20),
                        STATUS = c.Int(nullable: false),
                        CREATEUSER = c.String(maxLength: 20),
                        CREATEDATE = c.DateTime(nullable: false),
                        MODIFYUSER = c.String(maxLength: 20),
                        MODIFYDATE = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SOID);
            
            CreateTable(
                "dbo.Consumables",
                c => new
                    {
                        CID = c.String(nullable: false, maxLength: 20),
                        NAME = c.String(nullable: false, maxLength: 50),
                        IMAGE = c.String(maxLength: 200),
                        SPECIFICATION = c.String(maxLength: 200),
                        UNIT = c.String(maxLength: 6),
                        NOTE = c.String(maxLength: 200),
                        SPQ = c.Int(),
                        SAFECEILING = c.Int(),
                        SAFEFLOOR = c.Int(),
                        CREATEDATE = c.DateTime(nullable: false),
                        CREATEUSER = c.String(maxLength: 20),
                        MODIFYDATE = c.DateTime(nullable: false),
                        MODIFYUSER = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.CID);
            
            CreateTable(
                "dbo.coreUser",
                c => new
                    {
                        USER_ID = c.String(nullable: false, maxLength: 128),
                        USER_NAME = c.String(),
                        USER_PASSWORD = c.String(),
                        USER_ROLE = c.String(),
                        USER_LANGUAGE = c.Int(),
                        USER_SEX = c.Int(),
                        USER_BIRTHDAY = c.DateTime(),
                        USER_LOCATIONID = c.String(),
                        USER_ADDRESS = c.String(),
                        USER_PHONE = c.String(),
                        USER_EMAIL = c.String(),
                        USER_IMAGEID = c.String(),
                        USER_ISPHONEVALIDATED = c.Int(),
                        USER_ISEMAILVALIDATED = c.Int(),
                        USER_ISDEMO = c.Int(),
                        USER_DEMONAME = c.String(),
                        USER_DEPARTMENTID = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.USER_ID);
            
            CreateTable(
                "dbo.ValidateCode",
                c => new
                    {
                        CODEID = c.Int(nullable: false, identity: true),
                        PHONENUMBER = c.String(),
                        EMAIL = c.String(),
                        VCODE = c.String(),
                        CREATEDATE = c.DateTime(),
                        DEVICEID = c.String(),
                    })
                .PrimaryKey(t => t.CODEID);
            
            CreateTable(
                "dbo.WareHouse",
                c => new
                    {
                        WAREID = c.String(nullable: false, maxLength: 10),
                        NAME = c.String(nullable: false),
                        ISENABLE = c.Int(nullable: false),
                        PLACE = c.String(maxLength: 200),
                        MANAGER = c.String(maxLength: 20),
                        CREATEUSER = c.String(maxLength: 20),
                        CREATEDATE = c.DateTime(nullable: false),
                        MODIFYDATE = c.DateTime(nullable: false),
                        MODIFYUSER = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.WAREID);
            
            CreateTable(
                "dbo.WHStorageLocation",
                c => new
                    {
                        SLID = c.String(nullable: false, maxLength: 4),
                        WAREID = c.String(nullable: false, maxLength: 10),
                        STID = c.String(nullable: false, maxLength: 10),
                        NAME = c.String(nullable: false, maxLength: 50),
                        MANAGER = c.String(nullable: false, maxLength: 20),
                        MAXCAPACITY = c.String(maxLength: 20),
                        MAXVOLUME = c.String(maxLength: 20),
                        NOWCAPACITY = c.String(maxLength: 20),
                        NOWVOLUME = c.String(maxLength: 20),
                        STATUS = c.Int(nullable: false),
                        CREATEUSER = c.String(maxLength: 20),
                        CREATEDATE = c.DateTime(nullable: false),
                        MODIFYDATE = c.DateTime(nullable: false),
                        MODIFYUSER = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => new { t.SLID, t.WAREID, t.STID });
            
            CreateTable(
                "dbo.WHStorageType",
                c => new
                    {
                        STID = c.String(nullable: false, maxLength: 10),
                        WAREID = c.String(nullable: false, maxLength: 10),
                        NAME = c.String(nullable: false, maxLength: 50),
                        ISENABLE = c.Int(nullable: false),
                        CREATEUSER = c.String(maxLength: 20),
                        CREATEDATE = c.DateTime(nullable: false),
                        MODIFYDATE = c.DateTime(nullable: false),
                        MODIFYUSER = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => new { t.STID, t.WAREID });
        }
        
        public override void Down()
        {
            DropTable("dbo.WHStorageType");
            DropTable("dbo.WHStorageLocation");
            DropTable("dbo.WareHouse");
            DropTable("dbo.ValidateCode");
            DropTable("dbo.coreUser");
            DropTable("dbo.Consumables");
            DropTable("dbo.ConSalesOrder");
            DropTable("dbo.ConSalesOrderRow");
            DropTable("dbo.ConSalesOrderRetiring");
            DropTable("dbo.ConSalesOrderOutbound");
            DropTable("dbo.ConQuant");
            DropTable("dbo.ConPurchaseOrder");
            DropTable("dbo.ConPurchaseOrderRow");
            DropTable("dbo.ConPurchaseOrderReturn");
            DropTable("dbo.ConPurchaseOrderInstorage");
            DropTable("dbo.ConInventoryResult");
            DropTable("dbo.ConInventory");
            DropTable("dbo.AssTransferOrder");
            DropTable("dbo.AssTransferOrderRow");
            DropTable("dbo.AssTemplate");
            DropTable("dbo.AssSalesOrder");
            DropTable("dbo.AssSalesOrderRow");
            DropTable("dbo.AssSalesOrderRetiring");
            DropTable("dbo.AssSalesOrderOutbound");
            DropTable("dbo.AssPurchaseOrder");
            DropTable("dbo.AssPurchaseOrderRow");
            DropTable("dbo.AssPurchaseOrderReturn");
            DropTable("dbo.AssPurchaseOrderInstorage");
            DropTable("dbo.AssProcessRecord");
            DropTable("dbo.AssInventoryResult");
            DropTable("dbo.AssInventory");
            DropTable("dbo.AssetsType");
            DropTable("dbo.Assets");
        }
    }
}
