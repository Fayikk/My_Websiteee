using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using My_Website_API.Dal.ApiContext;
using My_Website_API.Dal.Entity;
using My_Website_API.Dal.Model;
using System.Threading.Tasks;

namespace My_Website_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {

       public UserManager<User> _userManager;

        public AccountController(UserManager<User> userManager)
        {
          _userManager = userManager;   
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel register)
        {
            if (ModelState.IsValid)
            {
                var user = new User();
                user.UserName = register.UserName;
                user.Email = register.Email;
                user.Password = register.Password;
                var result = await _userManager.CreateAsync(user, register.Password);



            }
            return Ok();
        }
    }
}
