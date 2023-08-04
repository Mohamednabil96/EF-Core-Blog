using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Task_day3.Models
{
    public class Blog
    {
        public int blogId { get; set; }
        public string blogName { get; set; }
        public string blogDescription { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
