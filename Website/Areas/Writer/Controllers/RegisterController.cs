using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Website.Areas.Writer.Models;

namespace Website.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class RegisterController : Controller
    {

        private readonly UserManager<WriterUser> _userManager;

        public RegisterController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new UserRegisterViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel user)
        {
            
                WriterUser w = new WriterUser()
                {
                    Name = user.Name,
                    SurName=user.Surname,
                    Email=user.Mail,
                    UserName=user.UserName,
                    ImageUrl=user.ImageUrl,
                };


                if(user.Password == user.ConfirmPassword)
                    {

                var results = await _userManager.CreateAsync(w, user.Password);

                if (results.Succeeded && user.ConfirmPassword == user.Password)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in results.Errors)
                    {
                        ModelState.AddModelError("", item.Description);

                    }
                }
            }

            
            

            return View();
        }
    }
}
