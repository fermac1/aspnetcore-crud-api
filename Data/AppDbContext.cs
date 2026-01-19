using Microsoft.EntityFrameworkCore;
using LearningDotNet.Models;

namespace LearningDotNet.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
