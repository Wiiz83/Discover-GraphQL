using Discover.GraphQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Discover.GraphQL.Repositories.Interfaces
{
    public interface IBlogPostRepository
    {
        public List<BlogPost> GetBlogPosts();
        public BlogPost GetBlogPostById(int id);
    }
}
