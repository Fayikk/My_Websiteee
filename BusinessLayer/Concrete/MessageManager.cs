﻿using BusinessLayer.Abstract;
using BusinessLayer.Helper;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        

        private IMessageDal _messageDal;
       
        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;   
        }

        public void TAdd(Message entity)
        {
            SendMailHelper.Execute().Wait();
            _messageDal.Insert(entity);
        }
        
        public void TDelete(Message entity)
        {
            _messageDal.Delete(entity);
        }

        public Message TGetById(int id)
        {
            return _messageDal.GetById(id);
        }

        public List<Message> TGetList()
        {
            return _messageDal.GetAll();
        }

       

        public void TUpdate(Message entity)
        {
            _messageDal.Update(entity);
        }
    }
}


