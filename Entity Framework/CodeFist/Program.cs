using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFist
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new BloggingContext()) {
                ctx.Blogs.Add(new Blog { BlogId = 2, Name = "SeconedBlog" });
                ctx.SaveChanges();
            }
        }
    }
}
