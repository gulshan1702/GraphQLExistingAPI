using GraphQLExistingAPI.Data;
using GraphQLExistingAPI.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLExistingAPI.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly ApplicationContext _context;
        public AuthorService(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<AuthorDto> GetAuthor(Guid bookId)
        {
            var resultData = await _context.AuthorDto.Where(o => o.Id == bookId)
                .Select(a => new AuthorDto()
                {
                    Id = a.Id,
                    GivenName = a.GivenName,
                    FamilyName = a.FamilyName
                }).FirstOrDefaultAsync();
            return resultData;
        }
    }
}
