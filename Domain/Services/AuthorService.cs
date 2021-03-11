using Library.Interface.Repositories;
using Library.Interface.Services;
using Library.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Domain.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorService (IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }
        public Author AddAuthor(Author author)
        {
            return _authorRepository.AddAuthor(author);
        }

        public void DeleteAuthor(int id)
        {
            _authorRepository.DeleteAuthor(id);
        }

        public List<Author> GetAll()
        {
            return _authorRepository.GetAll();
        }

        public Author GetAuthor(int id)
        {
            return _authorRepository.GetAuthor(id);
        }

        public Author UpdateAuthor(Author author)
        {
            return _authorRepository.UpdateAuthor(author);
        }

        public bool Exists(int id)
        {
            return _authorRepository.Exists(id);
        }

        public Author Login(string username, string password)
        {
            var author = _authorRepository.FindByEmail(username);
            if (author == null || author.Password != password)
            {
                return null;
            }

            return author;
        }
    }
}
