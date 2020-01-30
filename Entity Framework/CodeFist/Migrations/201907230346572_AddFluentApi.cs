namespace CodeFist.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFluentApi : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Blogs", name: "Url", newName: "UrlAddress");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Blogs", name: "UrlAddress", newName: "Url");
        }
    }
}
