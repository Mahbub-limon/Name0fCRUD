using Microsoft.EntityFrameworkCore;
using Name0fCRUD.Models;

namespace Name0fCRUD
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Item> Items { get; set; }



    }
}
