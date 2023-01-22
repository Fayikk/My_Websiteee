using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Website.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());        
        public IActionResult Index()
        {
            ViewBag.v1 = "Deneyim Listesi";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyim Listesi";

            var experience = experienceManager.TGetList();
            return View(experience);
        }


        [HttpGet]
        public IActionResult AddExperience()
        {

            ViewBag.v1 = "Deneyim Ekleme";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyim Ekleme";
            return View();
        } 




        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
          
            experienceManager.TAdd(experience);

            return RedirectToAction("Index");
        }

        //__--------

        public IActionResult Delete(int id)
        {
            var value = experienceManager.TGetById(id);
            experienceManager.TDelete(value);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            ViewBag.v1 = "Deneyim Güncelleme";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyim Güncelleme";
            var skill = experienceManager.TGetById(id);
            return View(skill);
        }

        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            experienceManager.TUpdate(experience);
            return RedirectToAction("Index");

        }

    }
}
