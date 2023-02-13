using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Login_Page.Models
{
    public class RegistrationModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        [RegularExpression("^(?=.*?[a-z])(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[#$^+=!*()@%&]).{6,}$")]

        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        [Required]
        public string PhoneNumber { get; set; }

        public string ? Role { get; set; }



    }
}
