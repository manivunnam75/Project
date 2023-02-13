using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TrainnePortal.Models.User
{
   
    public class OverView
    { 
        public int EmpId { get; set; }
        [Key]
        public string Name { get; set; }
        public string? Course1 { get; set; } = "NA"; 
        public string? Course2 { get; set; } = "NA";
        public string? Course3 { get; set; } = "NA";
        public string ?Course4 { get; set; } = "NA";
        public string? Course5 { get; set; } = "NA";
    }
}
