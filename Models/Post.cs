using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Task_day3.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string PostTitle { get; set; }
        public string PostBrief { get; set; }
        public string PostDesc { get; set; }
        public DateTime PostDate { get; set; }

        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }

        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
    }
}
