using GraphQLExistingAPI.Data;
using GraphQLExistingAPI.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLExistingAPI.Services
{
    public class BookService : IBookService
    {
        private readonly ApplicationContext _context;
        public BookService(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<BookDto> GetBook(Guid bookId)
        {
            var resultData = await _context.BookDto.Where(o => o.Id == bookId)
                .Select(book => new BookDto()
                {
                    Id = book.Id,
                    Name = book.Name,
                    PublishedDate = book.PublishedDate
                }).FirstOrDefaultAsync();
            return resultData;
        }
    }
}
