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
    public class WriterUserManager : IWriterUserService
    {
        EfWriterUserDal _writerUser;
        public WriterUserManager(EfWriterUserDal writerUser)
        {
            _writerUser = writerUser;   
        }

        public void TAdd(WriterUser entity)
        {
            _writerUser.Insert(entity);
        }

        public void TDelete(WriterUser entity)
        {
            _writerUser.Delete(entity);
        }

        public WriterUser TGetById(int id)
        {
            return _writerUser.GetById(id);
        }

        public List<WriterUser> TGetList()
        {
            return _writerUser.GetAll();
        }

        public void TUpdate(WriterUser entity)
        {
            _writerUser.Update(entity);
        }
    }
}
