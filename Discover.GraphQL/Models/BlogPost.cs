using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Discover.GraphQL.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        [GraphQLType(typeof(NonNullType<StringType>))]
        public string Title { get; set; }
        [GraphQLNonNullType]
        public int AuthorId { get; set; }
    }
}
