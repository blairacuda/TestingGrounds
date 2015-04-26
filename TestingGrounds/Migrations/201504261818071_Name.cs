namespace TestingGrounds.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Name : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "Name", c => c.String());
            AlterColumn("dbo.Addresses", "Name", c => c.String());
            DropColumn("dbo.People", "Name");
            DropColumn("dbo.People", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "Description", c => c.String());
            AddColumn("dbo.People", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Addresses", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Books", "Name", c => c.String(nullable: false));
        }
    }
}
