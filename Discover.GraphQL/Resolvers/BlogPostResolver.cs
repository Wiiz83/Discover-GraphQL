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
    public class BlogPostResolver
    {
        private readonly IBlogPostRepository _blogPostRepository;

        public BlogPostResolver([Service] IBlogPostRepository blogPostRepository)
        {
            _blogPostRepository = blogPostRepository;
        }

        public IEnumerable<BlogPost> GetBlogPosts(Author author, IResolverContext ctx)
        {
            return _blogPostRepository.GetBlogPosts()
            .Where(b => b.AuthorId == author.Id);
        }
    }
}
