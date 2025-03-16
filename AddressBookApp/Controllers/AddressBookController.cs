using Microsoft.AspNetCore.Mvc;

namespace AddressBookApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddressBookController : ControllerBase
    {
        

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Get");
        }
    }
}
