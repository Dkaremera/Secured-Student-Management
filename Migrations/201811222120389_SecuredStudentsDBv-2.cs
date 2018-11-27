namespace SecureStudentManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecuredStudentsDBv2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Courses", "DepartmentName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "DepartmentName", c => c.String());
        }
    }
}
