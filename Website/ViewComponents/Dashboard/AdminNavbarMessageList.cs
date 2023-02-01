using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Website.ViewComponents.Dashboard
{
    public class AdminNavbarMessageList:ViewComponent
    {
        WriterMessageManager writeMessageManager = new WriterMessageManager(new EfWriterMessageDal());
        public IViewComponentResult Invoke()
        {
            string p = "admin@gmail.com";
            var result = writeMessageManager.GetByReceiverFilter(p).OrderByDescending(x=>x.WriterMessageId).Take(3).ToList();

            //Context c = new Context();
            ViewBag.v = writeMessageManager.TGetList().Count();
            return View(result);
        }
    }
}
