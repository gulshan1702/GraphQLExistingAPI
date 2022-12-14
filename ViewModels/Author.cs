using GraphQLExistingAPI.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLExistingAPI.ViewModels
{
    public class Author
    {
        public Guid Id { get; set; }
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public static Author FromDto(AuthorDto author)
            => new Author
            {
                Id = author.Id,
                GivenName = author.GivenName,
                FamilyName = author.FamilyName
            };
    }
}
