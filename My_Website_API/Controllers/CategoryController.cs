using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using My_Website_API.Dal.ApiContext;
using My_Website_API.Dal.Entity;
using My_Website_API.DataAccessLayer.EntityFramework;
using System.Linq;

namespace My_Website_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        //CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

        [HttpGet]
        public IActionResult GetAll()
        {
            var c = new ContextApi();
            return Ok(c.Categories.ToList());

        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            if (ModelState.IsValid)
            {
                var result = new ContextApi();
                result.Categories.Add(category);
                result.SaveChanges();  
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        
        }


        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var result = new ContextApi();
            var obj = result.Categories.FirstOrDefault(x => x.CategoryId == id);
            result.Remove(obj);
            result.SaveChanges();
            return Ok();    
        
        }

        [HttpGet("{id}")]
        public IActionResult GetByCategoryId(int id)
        {
            var result = new ContextApi();
            var value = result.Categories.Find(id);
            if (value == null)
            {

                return BadRequest("aranan eleman bulunamadı");
            }
            else
            {
                return Ok(value);
            };

          
        }


        [HttpPut]
        public IActionResult UpdateCategory(Category category)
        {
            if (ModelState.IsValid)
            {
                var result = new ContextApi();
                result.Update(category);
                result.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
           
        }



    }
}
