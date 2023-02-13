using Microsoft.EntityFrameworkCore;

using TrainnePortal.Models.User;

namespace TrainnePortal.Models.User
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions options):base(options)
        {
            

        }
        public DbSet<Registration> TrainneDetails { get; set; }
        public DbSet<BatchModel> BatchDetails { get; set; }  
        public DbSet<BatchList> BatchList { get; set; }
        public DbSet<OverView> OverView { get; set; }
        public DbSet<SubBatch> SubBatche { get; set; }


    }
}
