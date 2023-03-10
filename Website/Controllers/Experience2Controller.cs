using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Website.Controllers
{
    public class Experience2Controller : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new DataAccessLayer.EntityFramework.EfExperienceDal());
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListExperience()
        {
            var values = JsonConvert.SerializeObject(experienceManager.TGetList());
            return Json(values);
        }

        [HttpPost]
        public IActionResult AddExperience(Experience p)
        {
            experienceManager.TAdd(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }

        public IActionResult GetById(int ExperienceId)
        {
            var values = experienceManager.TGetById(ExperienceId);
            var result = JsonConvert.SerializeObject(values);
            return Json(result);
        }


        public IActionResult DeleteExperience(int id)
        {
            var result = experienceManager.TGetById(id);
            experienceManager.TDelete(result);
            return Ok();
        }
    }
}
