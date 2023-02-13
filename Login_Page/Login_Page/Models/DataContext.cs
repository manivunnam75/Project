using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Login_Page.Models
{
    public class DataContext:IdentityDbContext<Login>
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }
        public DbSet<Login> Login_Page { get; set; }
    }
}
