using System.ComponentModel.DataAnnotations;

namespace My_Website_API.Dal.Model
{
    public class RegisterModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]

        public string Password { get; set; }
        [Required]

        public string Email { get; set; }
    }
}
