namespace Lottery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NumberValues",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumberId = c.Int(nullable: false),
                        Value = c.Int(nullable: false),
                        DrawnNumbers_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DrawnNumbers", t => t.DrawnNumbers_Id)
                .Index(t => t.DrawnNumbers_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NumberValues", "DrawnNumbers_Id", "dbo.DrawnNumbers");
            DropIndex("dbo.NumberValues", new[] { "DrawnNumbers_Id" });
            DropTable("dbo.NumberValues");
        }
    }
}
