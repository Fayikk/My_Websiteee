using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterMessageManager : IWriterMessageService
    {
        IWriterMessageDal _writerMessageDal;

        public WriterMessageManager(IWriterMessageDal writerMessageDal)
        {
            _writerMessageDal = writerMessageDal;
        }

  

        public List<WriterMessage> GetByReceiverFilter(string b)
        {
            return _writerMessageDal.GetByFilter(x => x.Receiver == b);

        }

        public List<WriterMessage> GetBySenderFilter(string a)
        {
            return _writerMessageDal.GetByFilter(x => x.Sender == a);

        }

        public void TAdd(WriterMessage entity)
        {
            _writerMessageDal.Insert(entity);
        }

        public void TDelete(WriterMessage entity)
        {
            _writerMessageDal.Delete(entity);
        }

        public WriterMessage TGetById(int id)
        {
            return _writerMessageDal.GetById(id);
        }

        public List<WriterMessage> TGetList()
        {
            return _writerMessageDal.GetAll();
        }

        public void TUpdate(WriterMessage entity)
        {
            _writerMessageDal.Update(entity);
        }
    }
}
