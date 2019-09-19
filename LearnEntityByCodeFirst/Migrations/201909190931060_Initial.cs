namespace LearnEntityByCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MailServers",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Host = c.String(),
                        Username = c.String(),
                        Password_Value = c.String(),
                        Password_AllowSave = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Senders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SenderMailServers",
                c => new
                    {
                        Sender_ID = c.Int(nullable: false),
                        MailServer_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Sender_ID, t.MailServer_Id })
                .ForeignKey("dbo.Senders", t => t.Sender_ID, cascadeDelete: true)
                .ForeignKey("dbo.MailServers", t => t.MailServer_Id, cascadeDelete: true)
                .Index(t => t.Sender_ID)
                .Index(t => t.MailServer_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SenderMailServers", "MailServer_Id", "dbo.MailServers");
            DropForeignKey("dbo.SenderMailServers", "Sender_ID", "dbo.Senders");
            DropIndex("dbo.SenderMailServers", new[] { "MailServer_Id" });
            DropIndex("dbo.SenderMailServers", new[] { "Sender_ID" });
            DropTable("dbo.SenderMailServers");
            DropTable("dbo.Senders");
            DropTable("dbo.MailServers");
        }
    }
}
