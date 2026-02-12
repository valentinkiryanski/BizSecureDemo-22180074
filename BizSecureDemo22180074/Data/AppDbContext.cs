using Microsoft.EntityFrameworkCore;
using BizSecureDemo22180074.Models;



namespace BizSecureDemo22180074.Data
{
   
    public class AppDbContext : DbContext
    {
        public DbSet<AppUser> Users => Set<AppUser>();
        public DbSet<Order> Orders => Set<Order>();
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }


}
