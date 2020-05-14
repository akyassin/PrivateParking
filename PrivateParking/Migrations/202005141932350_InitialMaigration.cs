namespace PrivateParking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMaigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        MobileNumber = c.Int(nullable: false),
                        Email = c.String(),
                        Password = c.String(),
                        PlateNumber = c.String(),
                        ParkingBlock_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ParkingBlocks", t => t.ParkingBlock_Id)
                .Index(t => t.ParkingBlock_Id);
            
            CreateTable(
                "dbo.ParkingBlocks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsAvailable = c.Boolean(nullable: false),
                        ParkingLot_Id = c.Int(),
                        ParkingType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ParkingLots", t => t.ParkingLot_Id)
                .ForeignKey("dbo.ParkingTypes", t => t.ParkingType_Id)
                .Index(t => t.ParkingLot_Id)
                .Index(t => t.ParkingType_Id);
            
            CreateTable(
                "dbo.ParkingLots",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumberOfParkings = c.Int(nullable: false),
                        Address = c.String(),
                        OwnerCompany = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ParkingTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Area = c.Double(nullable: false),
                        MonthlyRent = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "ParkingBlock_Id", "dbo.ParkingBlocks");
            DropForeignKey("dbo.ParkingBlocks", "ParkingType_Id", "dbo.ParkingTypes");
            DropForeignKey("dbo.ParkingBlocks", "ParkingLot_Id", "dbo.ParkingLots");
            DropIndex("dbo.ParkingBlocks", new[] { "ParkingType_Id" });
            DropIndex("dbo.ParkingBlocks", new[] { "ParkingLot_Id" });
            DropIndex("dbo.Customers", new[] { "ParkingBlock_Id" });
            DropTable("dbo.ParkingTypes");
            DropTable("dbo.ParkingLots");
            DropTable("dbo.ParkingBlocks");
            DropTable("dbo.Customers");
        }
    }
}
