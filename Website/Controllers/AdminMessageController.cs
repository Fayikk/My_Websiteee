using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Website.Controllers
{
    public class AdminMessageController : Controller
    {
        WriterMessageManager messageManager = new WriterMessageManager(new EfWriterMessageDal());
        public IActionResult ReceiverMessageList()
        {
            string p;
            p = "admin@gmail.com";
            var result = messageManager.GetByReceiverFilter(p);
            return View(result);
        }
        public IActionResult SenderMessageList()
        {
            string p;
            p = "admin@gmail.com";
            var result = messageManager.GetBySenderFilter(p);
            return View(result);
        }
        [HttpGet]
        public IActionResult AdminMessageDetails(int id)
        {
            var result = messageManager.TGetById(id);
            return View(result);
        }
        public IActionResult AdminMessageDelete(int id)
        {
            var result = messageManager.TGetById(id);
            messageManager.TDelete(result);
            return RedirectToAction("SenderMessageList");
        }


        [HttpGet]
        public IActionResult AdminMessageSend()
        {
    
            return View();
        }

        [HttpPost]
        public IActionResult AdminMessageSend(WriterMessage message)
        {
            message.Sender = "admin@gmail.com";
            message.SenderName = "Admin";
            message.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            Context c = new Context();
            var userNameSurname = c.Users.Where(x => x.Email == message.Receiver).Select(y => y.Name + " " + y.SurName).FirstOrDefault();//First catch value to get
            message.ReceiverName = userNameSurname;
            messageManager.TAdd(message);
            return RedirectToAction("SenderMessageList");

        }
    }
}
