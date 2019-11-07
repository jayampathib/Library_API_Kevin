using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        [HttpGet()]
        public IActionResult GetAuthors()
        {
            Author author = new Author
            {
                Id = new Guid("25320c5e-f58a-4b1f-b63a-8ee07a840bdf"),
                FirstName = "Stephen",
                LastName = "King",
                Genre = "Horror",
                DateOfBirth = new DateTimeOffset(new DateTime(1947, 9, 21))
            };
            return Ok(author);
        }
    }
}