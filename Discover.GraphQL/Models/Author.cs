using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Discover.GraphQL.Models
{
    public class Author
    {
        [GraphQLType(typeof(NonNullType<IdType>))]
        public int Id { get; set; }
        [GraphQLNonNullType]
        public string FirstName { get; set; }
        [GraphQLNonNullType]
        public string LastName { get; set; }
    }
}
