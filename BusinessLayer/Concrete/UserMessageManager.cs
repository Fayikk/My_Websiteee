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
    public class UserMessageManager : IUserMessageService
    {
        private IUserMessageDal _userMessageDal;
        public UserMessageManager(IUserMessageDal userMessageDal)
        {
            _userMessageDal = userMessageDal;
        }

        public List<UserMessage> GetUserMessageWithUserService()
        {
           return _userMessageDal.GetUserMessagesWithUser();
        }

        public void TAdd(UserMessage entity)
        {
            _userMessageDal.Insert(entity);
        }

        public void TDelete(UserMessage entity)
        {
            _userMessageDal.Delete(entity);
        }

        public UserMessage TGetById(int id)
        {
            return _userMessageDal.GetById(id);
        }

        public List<UserMessage> TGetList()
        {
            return _userMessageDal.GetAll();
        }

        public void TUpdate(UserMessage entity)
        {
            _userMessageDal.Update(entity);
        }
    }
}
