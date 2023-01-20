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
    public class ServiceManager : IServiceService
    {
        private EfServiceDal _serviceDal;
        public ServiceManager(EfServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void TAdd(Service entity)
        {
            _serviceDal.Insert(entity);
        }

        public void TDelete(Service entity)
        {
            _serviceDal.Delete(entity);
        }

        public Service TGetById(int id)
        {
             return _serviceDal.GetById(id);
        }

        public List<Service> TGetList()
        {
            return _serviceDal.GetAll();
        }

        public void TUpdate(Service entity)
        {
            _serviceDal.Update(entity);
        }
    }
}
