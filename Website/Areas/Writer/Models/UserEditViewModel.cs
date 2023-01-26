using Microsoft.AspNetCore.Http;

namespace Website.Areas.Writer.Models
{
    public class UserEditViewModel
    {
        public string UserName { get; set; }
        public string SurName { get; set; } 
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public string PictureUrl { get; set; }
        public IFormFile Picture { get; set; }//Save into wwroot folder
    }
}
