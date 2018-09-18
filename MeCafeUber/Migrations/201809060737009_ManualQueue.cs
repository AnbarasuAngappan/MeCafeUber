namespace MeCafeUber.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ManualQueue : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ManualQueues",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Worked = c.Boolean(nullable: false),
                        AccountNumber = c.String(),
                        AccountHoldername = c.String(),
                        Balance = c.String(),
                        DelinquentAmount = c.String(),
                        PaymentAmount = c.String(),
                        NextWorkDate = c.String(),
                        OverLimitAmount = c.String(),
                        CyclesDelinquent = c.String(),
                        DaysPastDue = c.String(),
                        NoofBrokenPTP = c.String(),
                        FuturePromiseDate = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ManualQueues");
        }
    }
}
