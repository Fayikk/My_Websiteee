using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Website.ViewComponents
{
    public class MessageList:ViewComponent
    {


     
        public IViewComponentResult Invoke()
        {

            return View();
        }


    }
}
