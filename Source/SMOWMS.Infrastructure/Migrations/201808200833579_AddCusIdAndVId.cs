namespace SMOWMS.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCusIdAndVId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AssPurchaseOrder", "VID", c => c.Int(nullable: false));
            AddColumn("dbo.AssSalesOrder", "CUSID", c => c.Int(nullable: false));
            AddColumn("dbo.ConPurchaseOrder", "VID", c => c.Int(nullable: false));
            AddColumn("dbo.ConSalesOrder", "CUSID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ConSalesOrder", "CUSID");
            DropColumn("dbo.ConPurchaseOrder", "VID");
            DropColumn("dbo.AssSalesOrder", "CUSID");
            DropColumn("dbo.AssPurchaseOrder", "VID");
        }
    }
}
