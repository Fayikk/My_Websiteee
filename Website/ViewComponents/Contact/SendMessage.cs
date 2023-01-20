using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Website.ViewComponents.Contact
{
    public class SendMessage:ViewComponent
    {

        MessageManager messageManager = new MessageManager(new DataAccessLayer.EntityFramework.EfMessageDal());


        [HttpGet]
        public IViewComponentResult Invoke()
        {
            return View();  
        }
        //[HttpPost]
        //public IViewComponentResult Invoke(Message message)
        //{
        //    message.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        //    message.Status = true;
        //    messageManager.TAdd(message);
        //    return View();
        //}

    }
}
