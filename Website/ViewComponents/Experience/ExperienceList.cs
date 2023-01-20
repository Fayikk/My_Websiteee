using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Website.ViewComponents.Experience
{
    public class ExperienceList:ViewComponent
    {
        ExperienceManager experienceManager = new ExperienceManager(new DataAccessLayer.EntityFramework.EfExperienceDal());
        public IViewComponentResult Invoke()
        {
            var value = experienceManager.TGetList();
            return View(value);
        } 
    }
}
