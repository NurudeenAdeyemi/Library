using Library.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Interface.Services
{
    public interface IBookService
    {
        public List<Book> GetAll();

        public Book GetBook(int id);

        public Book AddBook(Book book);

        public Book UpdateBook(Book book);

        public void DeleteBook(int id);
    }
}
