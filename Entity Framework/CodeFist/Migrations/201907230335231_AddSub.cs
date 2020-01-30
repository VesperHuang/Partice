namespace CodeFist.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSub : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "SubName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "SubName");
        }
    }
}
