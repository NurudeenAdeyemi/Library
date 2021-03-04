using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models.Entities
{
    public class Author : BaseEntity
    {
        public string FirstName { get; set; }

        public string LasttName { get; set; }

        public IList<Book> Books = new List<Book>();
    }
}
