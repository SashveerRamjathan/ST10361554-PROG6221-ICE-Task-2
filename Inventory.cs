﻿using System;
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


    }
}
