namespace LearnEntityByCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjouttablesAddressetUtilisateur2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Number = c.String(),
                        Street = c.String(),
                        City = c.String(),
                        Zipcode = c.String(),
                        Country = c.String(),
                        Utilisateur_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Utilisateurs", t => t.Utilisateur_Id)
                .Index(t => t.Utilisateur_Id);
            
            CreateTable(
                "dbo.Utilisateurs",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Firstname = c.String(),
                        LastName = c.String(),
                        Birthdate = c.String(),
                        Gender = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Addresses", "Utilisateur_Id", "dbo.Utilisateurs");
            DropIndex("dbo.Addresses", new[] { "Utilisateur_Id" });
            DropTable("dbo.Utilisateurs");
            DropTable("dbo.Addresses");
        }
    }
}
