using Microsoft.AspNetCore.Mvc;


    [Route("api/controller")]
    [ApiController]

public class LibraryController : ControllerBase
{
public static List<LibraryModel> AllBooks = new ();

[HttpGet]
public IActionResult GetAllProducts()
    {
        return Ok(AllBooks);
    }


}
