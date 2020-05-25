namespace WindowsForms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Dishes", new[] { "restaurant_Id" });
            AlterColumn("dbo.Dishes", "restaurant_Id", c => c.Int());
            AlterColumn("dbo.Dishes", "Restaurant_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Dishes", "restaurant_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Dishes", new[] { "restaurant_Id" });
            AlterColumn("dbo.Dishes", "Restaurant_Id", c => c.Int());
            AlterColumn("dbo.Dishes", "restaurant_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Dishes", "restaurant_Id");
        }
    }
}
