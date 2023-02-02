using My_Website_API.BusinessLayer.Abstract;
using My_Website_API.Dal.Entity;
using My_Website_API.DataAccessLayer.Abstract;
using System.Collections.Generic;

namespace My_Website_API.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Delete(Category item)
        {
            _categoryDal.Delete(item);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public void Insert(Category item)
        {
            _categoryDal.Insert(item);
        }

        public void Update(Category item)
        {
            _categoryDal.Update(item);
        }
    }
}
