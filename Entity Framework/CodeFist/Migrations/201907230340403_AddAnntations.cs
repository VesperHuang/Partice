namespace CodeFist.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAnntations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Blogs", "Name", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Blogs", "Name", c => c.String());
        }
    }
}
