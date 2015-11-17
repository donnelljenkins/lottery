namespace Lottery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveNumbersLinkFromNumberValue : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Numbers", newName: "DrawnNumbers");
            RenameColumn(table: "dbo.NumberValues", name: "Numbers_Id", newName: "DrawnNumbers_Id");
            RenameIndex(table: "dbo.NumberValues", name: "IX_Numbers_Id", newName: "IX_DrawnNumbers_Id");
            DropColumn("dbo.DrawnNumbers", "Discriminator");
            DropColumn("dbo.NumberValues", "NumberId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NumberValues", "NumberId", c => c.Int(nullable: false));
            AddColumn("dbo.DrawnNumbers", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            RenameIndex(table: "dbo.NumberValues", name: "IX_DrawnNumbers_Id", newName: "IX_Numbers_Id");
            RenameColumn(table: "dbo.NumberValues", name: "DrawnNumbers_Id", newName: "Numbers_Id");
            RenameTable(name: "dbo.DrawnNumbers", newName: "Numbers");
        }
    }
}
