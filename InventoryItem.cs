using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10361554_PROG6221_ICE_Task__2
{
    // Represents an inventory item with various properties
    public class InventoryItem
    {
        // The name of the inventory item, which can be null
        public string? ItemName { get; set; }

        // The price of the inventory item
        public double ItemPrice { get; set; }

        // The quantity of the inventory item in stock
        public int ItemQuantity { get; set; }

        // The category of the inventory item
        public ItemCategory Category { get; set; }

        // The minimum quantity of the inventory item that should be in stock
        public int MinimumQuantity { get; set; }
    }
}
