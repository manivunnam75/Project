using Microsoft.AspNetCore.Identity;

namespace Login_Page.Models
{
    public class Login:IdentityUser
    {
        public string Name{ get; set; }
        public string picture { get; set; }    
    }
}
