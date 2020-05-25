namespace WindowsForms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class resid : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dishes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Weight = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        Temperature = c.Int(nullable: false),
                        Restaurant_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Restaurants", t => t.Restaurant_Id)
                .Index(t => t.Restaurant_Id);
            
            CreateTable(
                "dbo.Restaurants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Dishes", "Restaurant_Id", "dbo.Restaurants");
            DropIndex("dbo.Dishes", new[] { "Restaurant_Id" });
            DropTable("dbo.Restaurants");
            DropTable("dbo.Dishes");
        }
    }
}
