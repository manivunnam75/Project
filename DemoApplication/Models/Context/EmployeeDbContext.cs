using Microsoft.EntityFrameworkCore;
namespace DemoApplication.Models.Context
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {
        }

       public DbSet<Employe> Employees{ get; set; }
      
     
    }
}
