using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _4JS.Shared;

namespace _4JS.Server.Services.BookService
{
    public interface IBookService
    {
        Task<List<Book>> AddBook(Book book);

        Task<Book> GetBook(int bookId);

        Task<List<Book>> UpdateBook(Book book);

        Task<List<Book>> RemoveBook(Book book);

        Task<List<Book>> LoadAllBooks();
    }
}
