using My_Website_API.BaseInterface;
using My_Website_API.Dal.Entity;
using My_Website_API.DataAccessLayer.Abstract;

namespace My_Website_API.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
    }
}
