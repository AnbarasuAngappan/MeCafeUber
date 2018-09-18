namespace MeCafeUber.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aspnetuserchanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CustomerAccountSearches", "DeliqAmount", c => c.String());
            DropColumn("dbo.CustomerAccountSearches", "DeingAmount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CustomerAccountSearches", "DeingAmount", c => c.String());
            DropColumn("dbo.CustomerAccountSearches", "DeliqAmount");
        }
    }
}
