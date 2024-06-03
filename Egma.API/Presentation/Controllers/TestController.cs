using Microsoft.AspNetCore.Mvc;

namespace Egma.API.Presentation.Controllers
{
    [Route("/tests")]
    public class TestController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Tests is okay");
        }
    }
}
