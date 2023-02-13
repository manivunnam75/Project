using System.ComponentModel.DataAnnotations;

namespace TrainnePortal.Models.User
{
    public class SubBatch
    {
        [Key]
        public int S_NO { get; set; }
        public int EmpId { get; set; }
        public int BacthId { get; set; }
        public string BatchName { get; set; }
        public string FullName { get; set; }
        public string Course { get; set;}
    }
}
