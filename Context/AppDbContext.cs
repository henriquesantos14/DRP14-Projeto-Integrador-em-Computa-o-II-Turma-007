using Microsoft.EntityFrameworkCore;
using PaulaPachecoHairStyle.Models;

namespace PaulaPachecoHairStyle.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 

        }

        public DbSet<Photo> Photo { get; set; }
        public DbSet<Procedure> Procedures { get; set; } 
    }
}
