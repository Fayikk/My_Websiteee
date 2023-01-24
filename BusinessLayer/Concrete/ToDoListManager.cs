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
    public class ToDoListManager : IToDoListService
    {
        private IToDoListDal _toDoListDal;

        public ToDoListManager(IToDoListDal toDoListDal)
        {
            _toDoListDal = toDoListDal; 
        }

        public void TAdd(ToDoList entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(ToDoList entity)
        {
            throw new NotImplementedException();
        }

        public ToDoList TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ToDoList> TGetList()
        {
           return  _toDoListDal.GetAll();
        }

        public void TUpdate(ToDoList entity)
        {
            throw new NotImplementedException();
        }
    }
}
