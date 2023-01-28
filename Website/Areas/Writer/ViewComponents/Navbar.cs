using EllipticCurve;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Website.Areas.Writer.ViewComponents
{
    public class Navbar:ViewComponent
    {
         private readonly UserManager<WriterUser> _userManager;

        public Navbar(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var result = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = result.ImageUrl;
            return View();
        }
    }
}
