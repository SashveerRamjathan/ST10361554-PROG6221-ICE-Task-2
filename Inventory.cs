using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10361554_PROG6221_ICE_Task__2
{
    internal class Inventory
    {
        //key = categories
        //value = list of items in the category
        Dictionary<ItemCategory, List<InventoryItem>> inventory = new Dictionary<ItemCategory, List<InventoryItem>>();

        //Keep track of history of added items
        //item added pushed onto stack
        //item removed popped from stack
        //LIFO
        Stack<InventoryItem> AddItemHistory = new Stack<InventoryItem>();

        //keep track of items that need to be restocked
        //quantity goes below certain amount, added to queue to order
        //FIFO
        Queue<InventoryItem> queue = new Queue<InventoryItem>();

        //Lists to handle displaying of inventory
        List<ItemCategory> categoriesInDictionary = new List<ItemCategory>();
        ArrayList itemLists = new ArrayList();
        List<string>? items;

        Categories categories = new Categories();

        public void CreateItem(string name, double price, int quantity, ItemCategory category)
        {
            InventoryItem item = new InventoryItem();

            item.ItemName = name;
            item.ItemPrice = price;
            item.ItemQuantity = quantity;
            item.Category = category;

        }

        public void AddItem(InventoryItem item)
        {
            // add to dictionary
            categories.AddToCategoryList(item);
            inventory.Add(item.Category, categories.GetItemList(item.Category));

            //add to stack
            AddItemHistory.Push(item);
        }

        public void RemoveItem(InventoryItem item) 
        {
            //get item list from dictionary
            List<InventoryItem> items = inventory[item.Category];

            foreach (InventoryItem inventoryItem in items)
            {
                if(inventoryItem.ItemName == item.ItemName)
                {
                    items.Remove(inventoryItem);
                }
            }

            inventory[item.Category] = items;

        }

        public string DisplayItem(InventoryItem item)
        {
            string itemToString;

            itemToString = "-----------------------------------------------------------" +
                           "Item Name: " + item.ItemName +
                           "Item Price: " + item.ItemPrice +
                           "Item Quantity: " + item.ItemQuantity +
                           "Item Category: " + item.Category +
                           "-----------------------------------------------------------";

            return itemToString;
        }

        public void DisplayInventory()
        {
            foreach(KeyValuePair<ItemCategory, List<InventoryItem>> kvp in inventory)
            {
                categoriesInDictionary.Add(kvp.Key);
                items = new List<string>();

                foreach (InventoryItem item in kvp.Value)
                {
                    items.Add(DisplayItem(item));
                }

                itemLists.Add(items);
            }
        }

    }
}
