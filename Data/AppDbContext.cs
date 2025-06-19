using Microsoft.EntityFrameworkCore;
using Think_Digitally_week01.Models;

namespace Think_Digitally_week01.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
