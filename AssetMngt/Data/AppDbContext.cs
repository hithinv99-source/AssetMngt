using Microsoft.EntityFrameworkCore;
using AssetMngt.Models;
namespace AssetMngt.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}

