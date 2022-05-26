using Microsoft.EntityFrameworkCore;

namespace JobTestApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<UserCreation> UserCreations { get; set; }
    }
}
