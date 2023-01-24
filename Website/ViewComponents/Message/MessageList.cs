using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Website.ViewComponents
{
    public class MessageList:ViewComponent
    {

        UserMessageManager messageManager = new UserMessageManager(new EfUserMessageDal());

     
        public IViewComponentResult Invoke()
        {
            var result = messageManager.GetUserMessageWithUserService();

            return View(result);
        }


    }
}
