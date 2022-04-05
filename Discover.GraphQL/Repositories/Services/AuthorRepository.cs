using Discover.GraphQL.Models;
using Discover.GraphQL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Discover.GraphQL.Repositories.Services
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;

        public AuthorRepository(IDbContextFactory<ApplicationDbContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
            using (var _applicationDbContext =
                _dbContextFactory.CreateDbContext())
            {
                _applicationDbContext.Database
                .EnsureCreated();
            }
        }
        public List<Author> GetAuthors()
        {
            using (var applicationDbContext =
                _dbContextFactory.CreateDbContext())
            {
                return applicationDbContext.Authors.ToList();
            }
        }
        public Author GetAuthorById(int id)
        {
            using (var applicationDbContext =
                _dbContextFactory.CreateDbContext())
            {
                return applicationDbContext.Authors.
                SingleOrDefault(x => x.Id == id);
            }
        }
        public async Task<Author> CreateAuthor(Author author)
        {
            using (var applicationDbContext =
                _dbContextFactory.CreateDbContext())
            {
                await applicationDbContext.Authors.AddAsync(author);
                await applicationDbContext.SaveChangesAsync();
                return author;
            }
        }
    }
}
