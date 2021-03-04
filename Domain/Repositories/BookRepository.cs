using Library.Interface.Repositories;
using Library.Models.ApplicationContext;
using Library.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Domain.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryContext _libraryContext;
        public BookRepository(LibraryContext libraryContext)
        {
            _libraryContext = libraryContext;
        }

        public Book AddBook(Book book)
        {
            _libraryContext.Books.Add(book);
            _libraryContext.SaveChanges();
            return book;
        }

        public void DeleteBook(int id)
        {
            var book = _libraryContext.Books.Find(id);
            if (book != null)
            {
                _libraryContext.Books.Remove(book);
                _libraryContext.SaveChanges();
            }
        }

        public bool Exists(int id)
        {
            return _libraryContext.Books.Any(b => b.Id == id);
        }

        public List<Book> GetAll()
        {
            return _libraryContext.Books.ToList();
        }

        public Book GetBook(int id)
        {
            return _libraryContext.Books.Find(id);
        }

        public Book UpdateBook(Book book)
        {
            _libraryContext.Books.Update(book);
            _libraryContext.SaveChanges();
            return book;
        }
    }
}
