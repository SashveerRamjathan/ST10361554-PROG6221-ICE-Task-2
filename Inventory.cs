﻿using System;
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
        Queue<InventoryItem> RestockItems = new Queue<InventoryItem>();

        //Lists to handle displaying of inventory
        List<ItemCategory> categoriesInDictionary = new List<ItemCategory>();
        ArrayList itemLists = new ArrayList();
        List<string>? items;

        //list to handle displaying of stack
        List<string> itemHistoryList = new List<string>();
        Categories categories = new Categories();

        public void CreateItem(string name, double price, int quantity, ItemCategory category, int minQuantity)
        {
            InventoryItem item = new InventoryItem();

            item.ItemName = name;
            item.ItemPrice = price;
            item.ItemQuantity = quantity;
            item.Category = category;
            item.MinimumQuantity = minQuantity;
        }


        public void AddItem(InventoryItem item)
        {
            // add to dictionary
            categories.AddToCategoryList(item);
            inventory.Add(item.Category, categories.GetItemList(item.Category));

            //add to stack
            AddItemHistory.Push(item);
        }

        public void PopInventoryItemFromStack(InventoryItem item)
        {
            ArrayList list = new ArrayList();
            
            foreach (InventoryItem product in AddItemHistory)
            {
                list.Add(product);
                AddItemHistory.Pop();
            }

            foreach (InventoryItem article in list)
            {
                if (article.ItemName == item.ItemName)
                {
                    list.Remove(article);
                }
            }

            foreach (InventoryItem inventoryItem in list)
            {
                AddItemHistory.Push(inventoryItem);
            }
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

            PopInventoryItemFromStack(item);

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

        public void DisplayItemHistoryStack()
        {
            foreach (InventoryItem item in AddItemHistory)
            {
                itemHistoryList.Add(DisplayItem(item));
            }
        }
        public void PurchaseItem(ItemCategory category, string itemName, int purchaseQuantity)
        {
            List<InventoryItem> items = inventory[category];

            foreach (InventoryItem item in items)
            {
                if (item.ItemName == itemName)
                {
                    item.ItemQuantity -= purchaseQuantity;
                }
            }

            inventory[category] = items;

        }

        public void CheckItemsToRestock()
        {
            foreach (KeyValuePair<ItemCategory, List<InventoryItem>> kvp in inventory)
            {
                List<InventoryItem> items = kvp.Value;

                foreach (InventoryItem item in items)
                {
                    if(item.ItemQuantity <= item.MinimumQuantity)
                    {
                        RestockItems.Enqueue(item);
                    }
                }

            }
        }

    }
}
