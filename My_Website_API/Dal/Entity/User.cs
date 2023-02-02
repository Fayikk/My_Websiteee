using Microsoft.AspNetCore.Identity;

namespace My_Website_API.Dal.Entity
{
    public class User : IdentityUser
    {
        public string UserName { get; set; }    
        public string Password { get; set; }
        public string Email { get; set; }

    }
}
