namespace SMOWMS.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSLOCInfo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ConInventoryResult", "WAREID", c => c.String(nullable: false, maxLength: 10));
            AddColumn("dbo.ConInventoryResult", "STID", c => c.String(nullable: false, maxLength: 10));
            AddColumn("dbo.ConInventoryResult", "SLID", c => c.String(nullable: false, maxLength: 4));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ConInventoryResult", "SLID");
            DropColumn("dbo.ConInventoryResult", "STID");
            DropColumn("dbo.ConInventoryResult", "WAREID");
        }
    }
}
