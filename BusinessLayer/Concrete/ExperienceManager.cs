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
    public class ExperienceManager : IExperienceService
    {

        private EfExperienceDal _experienceDal;
        public ExperienceManager(EfExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }

        public void TAdd(Experience entity)
        {
            _experienceDal.Insert(entity);
        }

        public void TDelete(Experience entity)
        {
            _experienceDal.Delete(entity);
        }

        public Experience TGetById(int id)
        {
            return _experienceDal.GetById(id);
        }

        public List<Experience> TGetList()
        {
            return _experienceDal.GetAll();
        }

        public void TUpdate(Experience entity)
        {
            _experienceDal.Update(entity);
        }
    }
}
