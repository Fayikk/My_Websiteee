using System.Collections.Generic;
using System.Linq.Expressions;
using System;

namespace My_Website_API.BaseInterface
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T item);
        void Update(T item);
        void Delete(T item);
        List<T> GetAll();
        T GetById(int id);
    }
}
