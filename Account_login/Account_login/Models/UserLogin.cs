using Microsoft.AspNetCore.Identity;

namespace Account_login.Models
{
    public class UserLogin:IdentityUser
    {
        public string Name { get; set; }
        public string picture { get; set; }
    }
}
