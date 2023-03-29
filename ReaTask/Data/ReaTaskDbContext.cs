using Microsoft.EntityFrameworkCore;
using ReaTask.Models;

namespace ReaTask.Data
{
    public class ReaTaskDbContext : DbContext
    {
        public ReaTaskDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
