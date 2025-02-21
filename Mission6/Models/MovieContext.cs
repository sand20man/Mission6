using Microsoft.EntityFrameworkCore;

namespace Mission6.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Movie> Movies { get; set; } // Table name in SQLite
        public DbSet<Category> Categories { get; set; }
    }
}