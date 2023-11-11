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
            string[] greetings = new string[]
            {
                "Hello",
                "World"
            };

            return Ok(greetings);
        }
    
    }
}
