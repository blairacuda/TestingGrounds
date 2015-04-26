namespace TestingGrounds.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        Author_PersonId = c.Int(),
                    })
                .PrimaryKey(t => t.BookId)
                .ForeignKey("dbo.People", t => t.Author_PersonId)
                .Index(t => t.Author_PersonId);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Age = c.Int(nullable: true),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        BillingAddress_AddressId = c.Int(),
                        ShippingAddress_AddressId = c.Int(),
                    })
                .PrimaryKey(t => t.PersonId)
                .ForeignKey("dbo.Addresses", t => t.BillingAddress_AddressId)
                .ForeignKey("dbo.Addresses", t => t.ShippingAddress_AddressId)
                .Index(t => t.BillingAddress_AddressId)
                .Index(t => t.ShippingAddress_AddressId);
            
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressId = c.Int(nullable: false, identity: true),
                        CityName = c.String(),
                        State = c.String(),
                        StreetAddress1 = c.String(),
                        StreetAddress2 = c.String(),
                        ZipCode = c.String(),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.AddressId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "Author_PersonId", "dbo.People");
            DropForeignKey("dbo.People", "ShippingAddress_AddressId", "dbo.Addresses");
            DropForeignKey("dbo.People", "BillingAddress_AddressId", "dbo.Addresses");
            DropIndex("dbo.People", new[] { "ShippingAddress_AddressId" });
            DropIndex("dbo.People", new[] { "BillingAddress_AddressId" });
            DropIndex("dbo.Books", new[] { "Author_PersonId" });
            DropTable("dbo.Addresses");
            DropTable("dbo.People");
            DropTable("dbo.Books");
        }
    }
}
