using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Login_Page.Models
{
    public class LoginModel
    {
        [Required]
        public string UserNmae { get; set; }
        [Required]
        public string Password { get; set; }    
    }
}
