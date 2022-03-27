using Microsoft.AspNetCore.Mvc;

namespace CustomerSupport.Controllers
{
    public class ErrorController : Controller
    {
        [HttpGet]
        public IActionResult Error()
        {
            return View();
        }
    }
}
