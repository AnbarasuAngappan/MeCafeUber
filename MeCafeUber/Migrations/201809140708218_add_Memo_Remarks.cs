namespace MeCafeUber.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_Memo_Remarks : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Memos", "Remarks", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Memos", "Remarks");
        }
    }
}
