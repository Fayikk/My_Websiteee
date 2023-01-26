using System.ComponentModel.DataAnnotations;

namespace Website.Areas.Writer.Models
{
    public class UserLoginViewModel
    {
        [Display(Name ="Kullanıcı Adın")]
        [Required(ErrorMessage ="Kullanıcı Adını Giriniz")]
        public string UserName { get; set; }
        [Display(Name ="Parolan")]
        [Required(ErrorMessage = "Parolayı Giriniz")]
        public string Password { get; set; }
    }
}
