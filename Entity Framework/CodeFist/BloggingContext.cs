using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFist
{
    public class BloggingContext:DbContext
    {
        public BloggingContext() {
            Database.SetInitializer<BloggingContext>(new CreateDatabaseIfNotExists<BloggingContext>());
        }

       public DbSet<Blog> Blogs { get; set; }

       public DbSet<Post> Posts { get; set; }


        //Fluent API
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Blog>().Property(b => b.Url).HasColumnName("UrlAddress");
        }
    }
}
