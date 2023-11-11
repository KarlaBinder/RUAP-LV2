using ContactManager.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContactManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        // GET: api/contact
        [HttpGet]
        public IActionResult Get()
        {
            Contact[] contacts = new Contact[]
            {
                new Contact { Id = 1, Name = "Glenn Block" },
                new Contact { Id = 2, Name = "Dan Roth" }
            };

            return Ok(contacts);
        }
    }
}
