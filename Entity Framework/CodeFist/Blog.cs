using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodeFist
{
    public class Blog
    {
        public int BlogId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public string Url { get; set; }

        public string SubName { get; set; }

        public virtual List<Post> Posts { get; set; }
    }
}
