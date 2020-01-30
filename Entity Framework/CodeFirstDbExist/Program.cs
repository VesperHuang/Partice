using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDbExist
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new BlogContext()) {

                ctx.Blogs.Add(new Blog { Name ="BlogNew",SubName="sub"});
                ctx.SaveChanges();
            }
        }
    }
}
