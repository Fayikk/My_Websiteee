using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Website.ViewComponents.Dashboard
{
    public class MessageList:ViewComponent
    {
        MessageManager messageManager = new MessageManager(new DataAccessLayer.EntityFramework.EfMessageDal());
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
