using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models.Entities
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }

        public DateTime YearPublished { get; set;  }

        public int AuthorId { get; set; }

        public Author Author { get; set; }

        public int Pages { get; set; }
    }
}
