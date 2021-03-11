using Library.Interface.Repositories;
using Library.Models.ApplicationContext;
using Library.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Domain.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly LibraryContext _libraryContext;
        public AuthorRepository(LibraryContext libraryContext)
        {
            _libraryContext = libraryContext;
        }

        public Author AddAuthor(Author author)
        {
            _libraryContext.Authors.Add(author);
            _libraryContext.SaveChanges();
            return author;
        }

        public void DeleteAuthor(int id)
        {
            var author = _libraryContext.Authors.Find(id);
            if (author != null)
            {
                _libraryContext.Authors.Remove(author);
                _libraryContext.SaveChanges();
            }
        }

        public bool Exists(int id)
        {
            return _libraryContext.Authors.Any(a => a.Id == id);
        }

        public List<Author> GetAll()
        {
            return _libraryContext.Authors.ToList();
        }

        public Author GetAuthor(int id)
        {
            return _libraryContext.Authors.Find(id);
        }

        public Author UpdateAuthor(Author author)
        {
            _libraryContext.Authors.Update(author);
            _libraryContext.SaveChanges();
            return author;
        }

        public Author FindByEmail(string email)
        {
            return _libraryContext.Authors.FirstOrDefault(c => c.Email == email);
        }
    }
}
