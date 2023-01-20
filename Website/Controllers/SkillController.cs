using Microsoft.AspNetCore.Mvc;

namespace Website.Controllers
{
    public class SkillController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
