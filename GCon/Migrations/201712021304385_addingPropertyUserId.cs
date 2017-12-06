namespace GCon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingPropertyUserId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AddressGroups", "UserId", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AddressGroups", "UserId");
        }
    }
}
