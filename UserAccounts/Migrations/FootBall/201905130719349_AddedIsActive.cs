namespace UserAccounts.Migrations.FootBall
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedIsActive : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Players", "IsActive");
        }
    }
}
