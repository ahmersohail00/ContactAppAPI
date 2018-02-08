namespace ContactAppAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumnImageURL : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "ImageURL", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contacts", "ImageURL");
        }
    }
}
