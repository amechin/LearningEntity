namespace LearnEntityByCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjouttablesAddressetUtilisateur3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Addresses", "Utilisateur_Id", "dbo.Utilisateurs");
            DropIndex("dbo.Addresses", new[] { "Utilisateur_Id" });
            RenameColumn(table: "dbo.Addresses", name: "Utilisateur_Id", newName: "Utilisateur_Email");
            DropPrimaryKey("dbo.Utilisateurs");
            AlterColumn("dbo.Addresses", "Utilisateur_Email", c => c.String(maxLength: 128));
            AlterColumn("dbo.Utilisateurs", "Email", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Utilisateurs", "Email");
            CreateIndex("dbo.Addresses", "Utilisateur_Email");
            AddForeignKey("dbo.Addresses", "Utilisateur_Email", "dbo.Utilisateurs", "Email");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Addresses", "Utilisateur_Email", "dbo.Utilisateurs");
            DropIndex("dbo.Addresses", new[] { "Utilisateur_Email" });
            DropPrimaryKey("dbo.Utilisateurs");
            AlterColumn("dbo.Utilisateurs", "Email", c => c.String());
            AlterColumn("dbo.Addresses", "Utilisateur_Email", c => c.Int());
            AddPrimaryKey("dbo.Utilisateurs", "Id");
            RenameColumn(table: "dbo.Addresses", name: "Utilisateur_Email", newName: "Utilisateur_Id");
            CreateIndex("dbo.Addresses", "Utilisateur_Id");
            AddForeignKey("dbo.Addresses", "Utilisateur_Id", "dbo.Utilisateurs", "Id");
        }
    }
}
