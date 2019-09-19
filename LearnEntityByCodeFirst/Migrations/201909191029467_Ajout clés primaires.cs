namespace LearnEntityByCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ajoutclésprimaires : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "Department_Id", "dbo.Departments");
            DropPrimaryKey("dbo.Departments");
            DropPrimaryKey("dbo.Employees");
            AlterColumn("dbo.Departments", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Employees", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Departments", "Id");
            AddPrimaryKey("dbo.Employees", "Id");
            AddForeignKey("dbo.Employees", "Department_Id", "dbo.Departments", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Department_Id", "dbo.Departments");
            DropPrimaryKey("dbo.Employees");
            DropPrimaryKey("dbo.Departments");
            AlterColumn("dbo.Employees", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Departments", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Employees", "Id");
            AddPrimaryKey("dbo.Departments", "Id");
            AddForeignKey("dbo.Employees", "Department_Id", "dbo.Departments", "Id");
        }
    }
}
