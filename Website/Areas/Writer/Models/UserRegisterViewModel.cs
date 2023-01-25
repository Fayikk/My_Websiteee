using System.ComponentModel.DataAnnotations;

namespace Website.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "adınızı giriniz.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "soyadınızı giriniz.")]
        public string Surname { get; set; }


        [Required(ErrorMessage = "ImageUrl'i giriniz")]
        public string ImageUrl { get; set; }

        public string UserName { get; set; }
        [Required(ErrorMessage = "Şifreyi giriniz.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Şifreyi tekrar giriniz.")]
        [Compare("Password",ErrorMessage ="Şifreler uyumlu değil")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage ="Mail Adresinizi girin")]
        public string Mail { get; set; }

    }
}
