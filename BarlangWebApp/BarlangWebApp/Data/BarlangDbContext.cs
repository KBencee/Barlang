using BarlangWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BarlangWebApp.Data
{
    public class BarlangDbContext : DbContext
    {
        public BarlangDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Barlang> barlangok { get; set; }
    }
}
