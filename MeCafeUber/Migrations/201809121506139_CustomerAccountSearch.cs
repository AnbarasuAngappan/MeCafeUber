namespace MeCafeUber.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerAccountSearch : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerAccountSearches",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Worked = c.Boolean(nullable: false),
                        AccountNumber = c.String(),
                        CustomerName = c.String(),
                        DeingAmount = c.String(),
                        Multiple = c.String(),
                        RiskIndicator = c.String(),
                        BlockCode1 = c.String(),
                        InsuranceIndicator = c.String(),
                        CurrentDate = c.String(),
                        CurrentBalance = c.String(),
                        DateLast = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CustomerAccountSearches");
        }
    }
}
