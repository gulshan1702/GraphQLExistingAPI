using GraphQLExistingAPI.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLExistingAPI.ViewModels
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime PublishedDate { get; set; }
        public Author Authors { get; set; }

        public static Book FromDto(BookDto book, AuthorDto authors)
            => new Book
            {
                Id = book.Id,
                Name = book.Name,
                PublishedDate = book.PublishedDate,
                Authors = Author.FromDto(authors)
            };
    }
}
