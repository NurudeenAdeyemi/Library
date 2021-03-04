using Library.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Interface.Services
{
    public interface IAuthorService
    {
        public List<Author> GetAll();

        public Author GetAuthor(int id);

        public Author AddAuthor(Author author);

        public Author UpdateAuthor(Author author);

        public void DeleteAuthor(int id);

        public bool Exists(int id);
    }
}
