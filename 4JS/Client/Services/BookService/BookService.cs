using _4JS.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace _4JS.Client.Services.BookService
{
    public class BookService : IBookService
    {
        private readonly HttpClient _http;

        public BookService(HttpClient http)
        {
            _http = http;
        }
        public async Task<List<Book>> AddBook(Book book)
        {
            var result = await _http.PostAsJsonAsync("api/book/create", book);
            var status = await result.Content.ReadFromJsonAsync<List<Book>>();
            return status;
        }

        public async Task<List<Book>> DeleteBook(Book book)
        {
            var result = await _http.PostAsJsonAsync("api/book/delete", book);
            var status = await result.Content.ReadFromJsonAsync<List<Book>>();
            return status;
        }

        public async Task<List<Book>> GetAllBook()
        {
            var result = await _http.GetFromJsonAsync<List<Book>>($"api/book/displayall");
            return result;
        }

        public async Task<Book> GetBook(int Id)
        {
            var result = await _http.GetFromJsonAsync<Book>($"api/book/display/{Id}");
            return result;
        }

        public async Task<List<Book>> UpdateBook(Book book)
        {
            var result = await _http.PostAsJsonAsync("api/book/update", book);
            var status = await result.Content.ReadFromJsonAsync<List<Book>>();
            return status;
        }
    }
}
