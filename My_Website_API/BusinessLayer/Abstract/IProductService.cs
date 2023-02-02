using My_Website_API.Dal.Entity;
using System.Collections.Generic;

namespace My_Website_API.BusinessLayer.Abstract
{
    public interface IProductService<T>
    {
        void Add(T entity);
        void Delete(T entity);
        List<Product> GetAll();
        void Update(T entity);   
        Product GetById(int id);    
    }
}
