using My_Website_API.Dal.ApiContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace My_Website_API.BaseInterface
{
    public class GenericRepository<T> : IGenericDal<T> where T:class
    {
        public void Delete(T item)
        {
            using var c = new ContextApi();
            c.Remove(item);
            c.SaveChanges();
        }

        public List<T> GetAll()
        {
            using var c = new ContextApi();
            return c.Set<T>().ToList();
        }

    
        public T GetById(int id)
        {
            using var c = new ContextApi();
           return  c.Set<T>().Find(id);
        }

        public void Insert(T item)
        {
            var c = new ContextApi();
            c.Add(item);
            c.SaveChanges();
        }

        public void Update(T item)
        {
            using var c = new ContextApi();
            c.Update(item);
            c.SaveChanges();
        }
    }
}
