using Microsoft.AspNetCore.Mvc;

namespace Website.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
