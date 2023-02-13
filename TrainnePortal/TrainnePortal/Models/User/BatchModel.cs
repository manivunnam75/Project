using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
namespace TrainnePortal.Models.User
{
    
    public class BatchModel
    {
        [Key]
        public int Id { get; set; }
        public int batchId { get; set; }
        public string batchName { get; set; }
        public string? course { get; set; }
        public int EmpId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public bool Istick { get; set; }


    }
}
