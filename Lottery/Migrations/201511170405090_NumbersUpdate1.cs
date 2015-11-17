namespace Lottery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NumbersUpdate1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.DrawnNumbers", newName: "Numbers");
            RenameColumn(table: "dbo.NumberValues", name: "DrawnNumbers_Id", newName: "Numbers_Id");
            RenameIndex(table: "dbo.NumberValues", name: "IX_DrawnNumbers_Id", newName: "IX_Numbers_Id");
            AddColumn("dbo.Numbers", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Numbers", "Discriminator");
            RenameIndex(table: "dbo.NumberValues", name: "IX_Numbers_Id", newName: "IX_DrawnNumbers_Id");
            RenameColumn(table: "dbo.NumberValues", name: "Numbers_Id", newName: "DrawnNumbers_Id");
            RenameTable(name: "dbo.Numbers", newName: "DrawnNumbers");
        }
    }
}
