using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Website.Areas.Writer.Controllers
{
    public class DashboardWriterController : Controller
    {

        private readonly UserManager<WriterUser> _userManager;

        public DashboardWriterController(UserManager<WriterUser> userManager)
        {
                    _userManager = userManager; 
        }

        [Area("Writer")]
        public async Task<IActionResult> Index()
        {
            var result = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.V = result.Name + " " + result.SurName;
            
            return View();
        }
    }
}
