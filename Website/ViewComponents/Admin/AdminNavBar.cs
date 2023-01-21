using Microsoft.AspNetCore.Mvc;

namespace Website.ViewComponents.Admin
{
    public class AdminNavBar:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
