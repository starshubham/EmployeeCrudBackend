using DemoAPI.Controllers.Models.Entites;
using Microsoft.EntityFrameworkCore;

namespace DemoAPI.Data

{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employees> Employees { get; set; }
    }
}
