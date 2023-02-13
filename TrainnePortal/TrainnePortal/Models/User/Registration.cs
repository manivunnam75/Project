using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainnePortal.Models.User;

public class Registration
{

    [Key]
    public int EmployeId { get; set; }
    public string firstName { get; set; }
    public string lastname { get; set; }
    public string father_Name { get; set; }
    public string birthDate { get; set; }
    public string degree { get; set; }
    public string branch { get; set; }
    public string passOutYear { get; set; }
    public string college { get; set; }
    public string Address { get; set; }   
    public int pincode { get; set; }
    public string mobile_number { get; set; }
    [NotMapped]
    public IFormFile Image { get; set; }
    public string pic { get; set; } 
    public bool IsChecked { get; set; }
    public string Gender { get; set; }=string.Empty;
    public string Email { get;set; }
    public string DOJ { get; set; }

}
