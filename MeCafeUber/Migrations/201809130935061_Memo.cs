namespace MeCafeUber.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Memo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Memos",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Date = c.String(),
                        Time = c.String(),
                        Priority = c.String(),
                        Rip = c.String(),
                        Type = c.String(),
                        Action = c.String(),
                        ActionDescription = c.String(),
                        Account = c.String(),
                        CardNumber = c.String(),
                        PlanNumber = c.String(),
                        SequenceNumber = c.String(),
                        CaseNumber = c.String(),
                        StoreNumber = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Memos");
        }
    }
}
