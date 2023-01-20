using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Website.ViewComponents
{
    public class MessageList:ViewComponent
    {

        MessageManager messageManager = new MessageManager(new EfMessageDal());

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
