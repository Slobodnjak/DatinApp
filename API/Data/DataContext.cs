using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
  public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opcija) : base(opcija)
        {
        }

        public DbSet<AppUser> Users { get; set; }

    }
}