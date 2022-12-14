using GraphQLExistingAPI.Dtos;
using GraphQLExistingAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLExistingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;
        private readonly IAuthorService _authorService;
        public BooksController(IBookService bookService, IAuthorService authorService)
        {
            _bookService = bookService;
            _authorService = authorService;
        }
        [HttpGet("GetBook/Id")]
        public async Task<ViewModels.Book> GetBook(Guid Id)
        {
            var book = await _bookService.GetBook(Id);
            var author = await _authorService.GetAuthor(Id);
            return ViewModels.Book.FromDto(book, author);
        }
    }
}
