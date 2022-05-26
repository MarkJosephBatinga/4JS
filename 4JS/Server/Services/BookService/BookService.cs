using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _4JS.Server.Data;
using _4JS.Shared;

namespace _4JS.Server.Services.BookService
{
    public class BookService : IBookService
    {
        private readonly DataContext _data;

        public BookService(DataContext data)
        {
            _data = data;
        }

        List<Book> Books = new List<Book>();
        Book book = new Book();

        public async Task<List<Book>> AddBook(Book book)
        {
            await _data.book_info.AddAsync(book);
            await _data.SaveChangesAsync();
            return Books = await _data.book_info.ToListAsync();
        }

        public async Task<Book> GetBook(int bookId)
        {
            return book = await _data.book_info.Where(a => a.Id == bookId).FirstOrDefaultAsync();
        }

        public async Task<List<Book>> LoadAllBooks()
        {
            return Books = await _data.book_info.ToListAsync();
        }

        public async Task<List<Book>> RemoveBook(Book book)
        {
            _data.book_info.Remove(book);
            await _data.SaveChangesAsync();
            Books = await _data.book_info.ToListAsync();
            return Books;
        }

        public async Task<List<Book>> UpdateBook(Book book)
        {
            Books = await _data.book_info.ToListAsync();
            var dbBook = await _data.book_info.FindAsync(book.Id);
            if (dbBook != null)
            {
                _data.Entry(dbBook).CurrentValues.SetValues(book);
                await _data.SaveChangesAsync();
            }
            return Books;
        }
    }
}
