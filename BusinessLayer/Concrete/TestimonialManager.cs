using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TestimonialManager : ITestiMonialService
    {
        private EfTestimonialDal _testimonialDal;
        public TestimonialManager(EfTestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void TAdd(Testimonial entity)
        {
            _testimonialDal.Insert(entity);
        }

        public void TDelete(Testimonial entity)
        {
            _testimonialDal.Delete(entity);
        }

        public Testimonial TGetById(int id)
        {
           return _testimonialDal.GetById(id);
        }

        public List<Testimonial> TGetList()
        {
           return _testimonialDal.GetAll();
        }

        public void TUpdate(Testimonial entity)
        {
            _testimonialDal.Update(entity);
        }
    }
}
