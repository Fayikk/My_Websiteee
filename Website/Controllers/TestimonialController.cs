using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Website.Controllers
{
    public class TestimonialController : Controller
    {
        TestimonialManager testiMonialManager = new TestimonialManager(new EfTestimonialDal());

        public IActionResult Index()
        {
            return View();
        }
    }
}
