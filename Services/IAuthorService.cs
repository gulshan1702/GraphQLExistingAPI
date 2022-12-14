using GraphQLExistingAPI.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLExistingAPI.Services
{
    public interface IAuthorService
    {
        Task<AuthorDto> GetAuthor(Guid bookId);
    }
}
