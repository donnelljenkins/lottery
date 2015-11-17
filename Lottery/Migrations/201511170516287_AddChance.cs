namespace Lottery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddChance : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DrawnNumbers", "DrawDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DrawnNumbers", "DrawDate");
        }
    }
}
