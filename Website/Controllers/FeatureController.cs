using Microsoft.AspNetCore.Mvc;

namespace Website.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
