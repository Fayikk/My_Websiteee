using Microsoft.AspNetCore.Mvc;

namespace Website.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
