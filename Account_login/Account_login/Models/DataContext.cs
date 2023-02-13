using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Account_login.Models
{
    public class DataContext:IdentityDbContext<UserLogin>
    {
        public DataContext(DbContextOptions <DataContext> options):base(options) 
        {

        }
        public DbSet<UserLogin> AccountTABLE { get; set; }


        
    }
}
