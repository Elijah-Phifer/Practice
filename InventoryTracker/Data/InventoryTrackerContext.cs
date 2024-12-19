using Microsoft.EntityFrameworkCore;
using InventoryTracker.Models;

namespace InventoryTracker.Data
{
    public class InventoryTrackerContext : DbContext
    {

        public InventoryTrackerContext(DbContextOptions<InventoryTrackerContext> options)
            : base(options)
        {
        }

        public DbSet<Inventory> Inventory { get; set; }
    }
}
