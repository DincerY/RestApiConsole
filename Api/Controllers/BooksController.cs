using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BooksController : ControllerBase
{
    [HttpGet]
    public Book GetBook()
    {
        Book book = new Book();
        book.Id = 1;
        book.Author = "Dincer";
        book.Title = "Test";
        return book;
    }
}


public class Book
{
    public int Id { get; set; }
    public string Author { get; set; }
    public string Title { get; set; }
}