using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10361554_PROG6221_ICE_Task__2
{
    internal class InventoryItem
    {
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }
        public int ItemQuantity { get; set; }
        public string ItemCategory { get; set; }

        public InventoryItem(string itemName, double itemPrice, int  itemQuantity, string itemCategory) 
        {
            this.ItemName = itemName;
            this.ItemPrice = itemPrice;
            this.ItemQuantity = itemQuantity;
            this.ItemCategory = itemCategory;
        }

    }
}
