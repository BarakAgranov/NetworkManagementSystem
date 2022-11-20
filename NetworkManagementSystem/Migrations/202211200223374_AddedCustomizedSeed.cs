namespace NetworkManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCustomizedSeed : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.NetworkComponentModels", "ComponentType_Id", "dbo.ComponentTypeModels");
            DropIndex("dbo.NetworkComponentModels", new[] { "ComponentType_Id" });
            DropColumn("dbo.NetworkComponentModels", "ComponentType_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NetworkComponentModels", "ComponentType_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.NetworkComponentModels", "ComponentType_Id");
            AddForeignKey("dbo.NetworkComponentModels", "ComponentType_Id", "dbo.ComponentTypeModels", "Id", cascadeDelete: true);
        }
    }
}
