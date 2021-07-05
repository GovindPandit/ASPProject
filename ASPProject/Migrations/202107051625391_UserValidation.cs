namespace ASPProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Mobile", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Mobile", c => c.String());
        }
    }
}
