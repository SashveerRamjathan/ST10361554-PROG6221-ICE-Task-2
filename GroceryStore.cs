using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10361554_PROG6221_ICE_Task__2
{
    public class GroceryStore
    {
       Inventory GroceryStoreInventory = new Inventory();

        public GroceryStore() 
        {
            this.Inventory = GroceryStoreInventory;
        }

        public Inventory Inventory { get; set; }
    }
}
