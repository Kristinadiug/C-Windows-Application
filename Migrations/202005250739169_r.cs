namespace WindowsForms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class r : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Dishes", "restaurant_Id", "dbo.Restaurants");
            DropIndex("dbo.Dishes", new[] { "restaurant_Id" });
            AlterColumn("dbo.Dishes", "Restaurant_Id", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Dishes", "Restaurant_Id", c => c.Int());
            CreateIndex("dbo.Dishes", "restaurant_Id");
            AddForeignKey("dbo.Dishes", "restaurant_Id", "dbo.Restaurants", "Id");
        }
    }
}
