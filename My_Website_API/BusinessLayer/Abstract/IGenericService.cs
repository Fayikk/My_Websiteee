using System.Collections.Generic;

namespace My_Website_API.BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void Insert(T item);
        void Update(T item);
        void Delete(T item);
        List<T> GetAll();
        T GetById(int id);
    }
}
