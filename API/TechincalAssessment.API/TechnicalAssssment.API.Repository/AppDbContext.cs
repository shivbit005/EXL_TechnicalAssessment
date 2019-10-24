using Microsoft.EntityFrameworkCore;

namespace TechnicalAssssment.API.Repository
{
    public class AppDbContext : DbContext
    {
        // DBSets
        public DbSet<Employee> Employees { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
