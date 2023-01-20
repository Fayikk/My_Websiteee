using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Website.ViewComponents.Testimonial
{
    public class TestimonialList:ViewComponent
    {
        TestimonialManager testiMonialManager = new TestimonialManager(new EfTestimonialDal());

        public IViewComponentResult Invoke()
        {
            var value = testiMonialManager.TGetList();
            return View(value);
        }
    }
}
