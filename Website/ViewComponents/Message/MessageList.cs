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
     
        public IViewComponentResult Invoke()
        {
            var result = messageManager.TGetList();
            return View(result);
        }


    }
}
