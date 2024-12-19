using System;
using System.ComponentModel.DataAnnotations;

namespace InventoryTracker.Models
{
    public class Inventory
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Stock { get; set; }



    }
}
