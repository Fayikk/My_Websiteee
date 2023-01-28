using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Website.Areas.Writer.Controllers
{
    [Area("Writer")]

    public class DashboardWriterController : Controller
    {

        private readonly UserManager<WriterUser> _userManager;

        public DashboardWriterController(UserManager<WriterUser> userManager)
        {
                    _userManager = userManager; 
        }

        public async Task<IActionResult> Index()
        {
            var result = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.V = result.Name + " " + result.SurName;
            //Weather api
            string api = "fc675d3df86096b3ce423fdb7bb89294";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=Diyarbak%C4%B1r&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument  document=XDocument.Load(connection);
            ViewBag.v5 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            //Statistic
            Context c = new Context();
            ViewBag.v1 = 0;
            ViewBag.v2 = c.Announcements.Count();
            ViewBag.v3 = 0;
            ViewBag.v4 = c.Skills.Count();


            return View();
        }


    }
}
