using Microsoft.AspNetCore.Mvc;

namespace CustomerSupport.Controllers
{
    public class ErrorController : Controller
    {
        [HttpGet]
        public IActionResult NotFound()
        {
            return View();
        }
    }
}
