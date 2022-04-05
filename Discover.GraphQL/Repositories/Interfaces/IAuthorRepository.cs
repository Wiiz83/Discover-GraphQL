using Discover.GraphQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Discover.GraphQL.Repositories.Interfaces
{
    public interface IAuthorRepository
    {
        public List<Author> GetAuthors();
        public Author GetAuthorById(int id);
        public Task<Author> CreateAuthor(Author author);
    }
}
