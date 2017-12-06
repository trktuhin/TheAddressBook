namespace GCon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AddressGroups", "UserId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AddressGroups", "UserId", c => c.String(nullable: false));
        }
    }
}
