namespace LearnEntityByCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjoutIpAdresstableMailServer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MailServers", "IpAdress", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MailServers", "IpAdress");
        }
    }
}
