using AhsanSports.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace AhsanSports.Data
{
    public class ItemsDbContext : DbContext
    {
        public ItemsDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Items> Item { get; set; }
    }
}
