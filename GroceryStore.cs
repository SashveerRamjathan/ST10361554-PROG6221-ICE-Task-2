using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10361554_PROG6221_ICE_Task__2
{
    public class GroceryStore
    {
        // Initializing the inventory object
        Inventory GroceryStoreInventory = new Inventory();

        // Constructor for the grocery store
        public GroceryStore() 
        {
            // Setting the property to the instance of the inventory object
            this.Inventory = GroceryStoreInventory;
        }

        // Property for the inventory of the grocery store
        // This property allows access to the inventory of the grocery store
        public Inventory Inventory { get; set; }
    }
}
