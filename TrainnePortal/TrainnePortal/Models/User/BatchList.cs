using System.ComponentModel.DataAnnotations;

namespace TrainnePortal.Models.User
{
    public class BatchList
    {
        [Key]
        public int S_NO { get; set;}
        public int BatchId { get; set;}
        public string Batchname{ get; set;}   
        public bool IsCheck { get; set;}
       

       
    }
}
