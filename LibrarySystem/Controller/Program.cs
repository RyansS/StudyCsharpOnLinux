using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/controller")]
    
public class LibraryController : ControllerBase
{
public static List<LibraryModel> AllBooks = new ();


[HttpGet]
public IActionResult GetAllProducts()
    {
        return Ok(AllBooks);
    }

[HttpPost]
public CreatedAtActionResult PostCreateBook([FromBody] LibraryModel newBook)
    {
        return CreatedAtAction(nameof(newBook), new {id = newBook.BookId}, newBook);
    }


}
