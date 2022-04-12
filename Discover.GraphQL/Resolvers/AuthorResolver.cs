using Discover.GraphQL.Models;
using Discover.GraphQL.Repositories.Interfaces;
using HotChocolate;
using HotChocolate.Resolvers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Discover.GraphQL.Resolvers
{
    public class AuthorResolver
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorResolver([Service] IAuthorRepository authorService)
        {
            _authorRepository = authorService;
        }

        public Author GetAuthor(BlogPost blog, IResolverContext ctx)
        {
            return _authorRepository.GetAuthors().Where
            (a => a.Id == blog.AuthorId).FirstOrDefault();
        }
    }
}
