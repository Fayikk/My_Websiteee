using Microsoft.AspNetCore.Mvc;

namespace Website.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult PartialSideBar()
        {
            return View();
        }
    }
}
