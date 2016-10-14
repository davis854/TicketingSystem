namespace TicketingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newDB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Responses", "CustomerName", c => c.String());
            AddColumn("dbo.Responses", "Email", c => c.String());
            AddColumn("dbo.Responses", "TechnicalRemarks", c => c.String());
            AddColumn("dbo.Tickets", "CustomerName", c => c.String());
            AddColumn("dbo.Tickets", "EmailAddress", c => c.String());
            AddColumn("dbo.Tickets", "Date", c => c.Int(nullable: false));
            AddColumn("dbo.Tickets", "Status", c => c.String());
            AddColumn("dbo.Tickets", "Time", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tickets", "Time");
            DropColumn("dbo.Tickets", "Status");
            DropColumn("dbo.Tickets", "Date");
            DropColumn("dbo.Tickets", "EmailAddress");
            DropColumn("dbo.Tickets", "CustomerName");
            DropColumn("dbo.Responses", "TechnicalRemarks");
            DropColumn("dbo.Responses", "Email");
            DropColumn("dbo.Responses", "CustomerName");
        }
    }
}
