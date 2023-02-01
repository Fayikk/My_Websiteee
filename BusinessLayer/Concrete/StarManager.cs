using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class StarManager : IStarService
    {
        EfStarDal _starDal;
        public StarManager(EfStarDal starDal)
        {
            _starDal = starDal;
        }

 
        public void TAdd(Star entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Star entity)
        {
            throw new NotImplementedException();
        }

        public Star TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Star> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Star entity)
        {
            throw new NotImplementedException();
        }
    }
}
