using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using InventoryTracker.Data;
using System;
using System.Linq;

namespace InventoryTracker.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new InventoryTrackerContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<InventoryTrackerContext>>()))
            {
                // Look for any Inventorys.
                if (context.Inventory.Any())
                {
                    return;   // DB has been seeded
                }

                context.Inventory.AddRange(
                     new Inventory
                     {
                         Name = "When Harry Met Sally",
                         Description = "A classic romantic comedy where two people fall in love over time.",
                         Stock = 100
                     },
                    new Inventory
                    {
                        Name = "Ghostbusters",
                        Description = "A comedy about a group of scientists who become ghost hunters in New York City.",
                        Stock = 150
                    },
                    new Inventory
                    {
                        Name = "Ghostbusters 2",
                        Description = "The Ghostbusters return to battle paranormal activity in New York City once again.",
                        Stock = 120
                    },
                    new Inventory
                    {
                        Name = "Rio Bravo",
                        Description = "A classic Western where a sheriff and his friends defend a town from outlaws.",
                        Stock = 80
                    }
                );
                context.SaveChanges();
            }
        }
    }
}