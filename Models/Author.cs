using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Task_day3.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorUsername { get; set; }
        public string AuthorPassword { get; set; }
        public string? AuthorPhoto { get; set; }
        public int AuthorAge { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
