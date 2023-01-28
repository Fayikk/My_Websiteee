using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Website.Areas.Writer.ViewComponents
{
    public class Notification: ViewComponent
    {
        AnnouncementManager announcementManager = new AnnouncementManager(new EfAnnouncementDal());

        public IViewComponentResult Invoke()
        {

            var result = announcementManager.TGetList().Take(5).ToList();
            return View(result);
        }
    }
}
