using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using My_Website_API.BusinessLayer.Abstract;
using My_Website_API.BusinessLayer.Concrete;
using My_Website_API.Dal.Entity;

namespace My_Website_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        IProductService<Product> _productService;

        public ProductController(IProductService<Product> productService)
        {
            _productService = productService;   
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result =_productService.GetAll();
            return Ok(result);       
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct([FromRoute]int id)
        {
            var result = _productService.GetById(id);
            _productService.Delete(result);
            return Ok();

        }

        [HttpPut]
        public IActionResult UpdateProduct(Product item)
        {
            _productService.Update(item);
            return Ok();
        }

        [HttpPost]
        public IActionResult AddProduct(Product item)
        {
            _productService.Add(item);
            return Ok();
        }




    }
}
