namespace ContactAppAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateContactTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 255),
                        LastName = c.String(maxLength: 255),
                        Phone = c.String(maxLength: 255),
                        Email = c.String(maxLength: 255),
                        Blocked = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Contacts");
        }
    }
}
