namespace HealthRecords.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class x : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CartItems", "medicineId", "dbo.Medicines");
            DropIndex("dbo.CartItems", new[] { "medicineId" });
            DropTable("dbo.CartItems");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.CartItems",
                c => new
                    {
                        ItemId = c.String(nullable: false, maxLength: 128),
                        CartId = c.String(),
                        Quantity = c.Int(nullable: false),
                        medicineId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ItemId);
            
            CreateIndex("dbo.CartItems", "medicineId");
            AddForeignKey("dbo.CartItems", "medicineId", "dbo.Medicines", "Id", cascadeDelete: true);
        }
    }
}
