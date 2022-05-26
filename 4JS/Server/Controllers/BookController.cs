using _4JS.Server.Services.BookService;
using _4JS.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _4JS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _service;

        public BookController(IBookService service)
        {
            _service = service;
        }

        List<Book> Books = new List<Book>();
        Book book = new Book();

        [HttpPost("create")]
        public async Task<ActionResult<List<Book>>> LoginBook(Book book)
        {
            return Books = await _service.AddBook(book);
        }

        [HttpPost("update")]
        public async Task<ActionResult<List<Book>>> UpdateBook(Book book)
        {
            return Books = await _service.UpdateBook(book);
        }

        [HttpPost("delete")]
        public async Task<ActionResult<List<Book>>> DeleteBook(Book book)
        {
            return Books = await _service.RemoveBook(book);
        }

        [HttpGet("displayall")]
        public async Task<ActionResult<List<Book>>> GetAllBook()
        {
            return Books = await _service.LoadAllBooks();
        }

        [HttpGet("display/{Id:int}")]
        public async Task<ActionResult<Book>> GetBook(int Id)
        {
            return book = await _service.GetBook(Id);
        }
    }
}
