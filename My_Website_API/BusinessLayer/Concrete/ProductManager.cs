using My_Website_API.BusinessLayer.Abstract;
using My_Website_API.Dal.ApiContext;
using My_Website_API.Dal.Entity;
using System.Collections.Generic;
using System.Linq;

namespace My_Website_API.BusinessLayer.Concrete
{
    public class ProductManager<T> : IProductService<T>
    {
        
        

        public void Add(T entity)
        {
            var p = new ContextApi();
            p.Add(entity);
            p.SaveChanges();
        }

        public void Delete(T entity)
        {
            var p = new ContextApi();
            p.Remove(entity);
            p.SaveChanges();
        }

        public List<Product> GetAll()
        {
            var p = new ContextApi();
          return  p.Products.ToList();
            
        }

        public Product GetById(int id)
        {
            var p = new ContextApi();
            return p.Products.Find(id);
        }

        public void Update(T entity)
        {
            var p = new ContextApi();
            p.Update(entity);
            p.SaveChanges();
        }
    }
}
