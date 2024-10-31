using System.Collections.Generic;
using LeloProject.Models;
using Microsoft.EntityFrameworkCore;

namespace LeloProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Claim> Claims { get; set; }
      
    }
}
