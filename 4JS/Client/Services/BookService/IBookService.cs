using _4JS.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _4JS.Client.Services.BookService
{
    interface IBookService
    {
        Task<List<Book>> AddBook(Book book);

        Task<List<Book>> UpdateBook(Book book);

        Task<List<Book>> DeleteBook(Book book);

        Task<List<Book>> GetAllBook();

        Task<Book> GetBook(int Id);
    }
}
