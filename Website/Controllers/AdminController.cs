using Microsoft.AspNetCore.Mvc;

namespace Website.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult PartialSideBar()
        {
            return View();
        }

        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }


        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }


        public PartialViewResult PartialScript()
        {
            return PartialView();
        }

        public PartialViewResult NavigationPartial()
        {
            return PartialView();
        }
    }
}
