using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Website.Controllers
{
    [Authorize(Roles ="Admin")]
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
        public IActionResult Index()
        {
            ViewBag.V1 = "Hizmetleri Listele";
            ViewBag.V2 = "Hizmetlerim";
        
            var value = serviceManager.TGetList();
            return View(value);


        }


        [HttpGet]
        public IActionResult AddService()
        {
            ViewBag.V1 = "Hizmetlerim";
            ViewBag.V2 = "Hizmetleri Ekle";
            return View();

        }
        [HttpPost]
        public IActionResult AddService(Service service)
        {

          

            serviceManager.TAdd(service);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var service = serviceManager.TGetById(id);
            serviceManager.TDelete(service);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            var value = serviceManager.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateService(Service service)
        {
            serviceManager.TUpdate(service);
            return RedirectToAction("Index");
        }




    }
}
