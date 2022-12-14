using GraphQLExistingAPI.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLExistingAPI.Services
{
    public interface IBookService
    {
        Task<BookDto> GetBook(Guid bookId);
    }
}
