using System.ComponentModel.DataAnnotations;

namespace DemoApplication.Models.Context
{
    public class Employe
    {
        [Required(ErrorMessage ="Please Enter the Emp id")]
        public int EmployeId { get; set; }
        [Required(ErrorMessage ="please enter the name")]
        public string Name { get; set; }
        [Required (ErrorMessage ="Please enter the address")]
        public string Address { get; set; }
        [Required (ErrorMessage ="Please enter the company name")]
       
        public string Company { get; set; }
        [Required(ErrorMessage ="Please enter  the Designation")]
        public string Designation { get; set; }
    }
}
