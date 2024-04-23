using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10361554_PROG6221_ICE_Task__2
{
    public class Inventory
    {
        //key = categories
        //value = list of items in the category
        public Dictionary<ItemCategory, List<InventoryItem>> inventory = new Dictionary<ItemCategory, List<InventoryItem>>();

        //Keep track of history of added items
        //item added pushed onto stack
        //item removed popped from stack
        //LIFO
        public Stack<InventoryItem> AddItemHistory = new Stack<InventoryItem>();

        //keep track of items that need to be restocked
        //quantity goes below certain amount, added to queue to order
        //FIFO
        Queue<InventoryItem> RestockItems = new Queue<InventoryItem>();

        //Lists to handle displaying of inventory
        public List<ItemCategory> categoriesInDictionary = new List<ItemCategory>();
        public List<List<string>> itemLists = new List<List<string>>();

        ////list to handle displaying of stack
        //List<string> itemHistoryList = new List<string>();

        //list to handle displaying of queue
        public List<string> restockItemsDisplay = new List<string>();

        Categories categories = new Categories();

        InputValidator inputValidator = new InputValidator();

        public InventoryItem CreateItem(string name, double price, int quantity, ItemCategory category, int minQuantity)
        {
            InventoryItem item = new InventoryItem();

            item.ItemName = name;
            item.ItemPrice = price;
            item.ItemQuantity = quantity;
            item.Category = category;
            item.MinimumQuantity = minQuantity;

            return item;
        }


        public void AddItem(InventoryItem item)
        {
           bool isValid = inputValidator.CheckItem(item);

            if (isValid)
            {
                // add to dictionary
                categories.AddToCategoryList(item);
                inventory[item.Category] = categories.GetItemList(item.Category);

                //add to stack
                AddItemHistory.Push(item);
            }
            else throw new Exception(message: "Add Item Failed");
            
        }

        public void PopInventoryItemFromStack(string itemName)
        {
            ArrayList list = new ArrayList();
            
            foreach (InventoryItem product in AddItemHistory)
            {
                list.Add(product);
                AddItemHistory.Pop();
            }

            foreach (InventoryItem article in list)
            {
                if (article.ItemName == itemName)
                {
                    list.Remove(article);
                }
            }

            foreach (InventoryItem inventoryItem in list)
            {
                AddItemHistory.Push(inventoryItem);
            }
        }

        public void RemoveItem(ItemCategory category, string itemName) 
        {
            //get item list from dictionary
            List<InventoryItem> items = inventory[category];

           bool isValid = inputValidator.ValidateList(items);

            if (isValid)
            {
                foreach (InventoryItem inventoryItem in items)
                {
                    if (inventoryItem.ItemName == itemName)
                    {
                        items.Remove(inventoryItem);
                    }
                }

                inventory[category] = items;

                PopInventoryItemFromStack(itemName);
            }
            else throw new Exception(message: "List is null, could not pop item from stack");

        }

        public string DisplayItem(InventoryItem item)
        {
            string itemToString;

            itemToString = /*"\n-----------------------------------------------------------" +*/
                           $"\nItem Name: {item.ItemName}" +
                           $"\nItem Price: {item.ItemPrice}" +
                           $"\nItem Quantity: {item.ItemQuantity}" +
                           $"\nItem Category: {item.Category}";
                           //"-----------------------------------------------------------";

            return itemToString;
        }

        public void DisplayInventory()
        {
            categoriesInDictionary.Clear();
            itemLists.Clear();

            foreach (KeyValuePair<ItemCategory, List<InventoryItem>> kvp in inventory)
            {
                categoriesInDictionary.Add(kvp.Key);
                List<string> items = new List<string>();

                foreach (InventoryItem item in kvp.Value)
                {
                    items.Add(DisplayItem(item));
                }

                itemLists.Add(items);


            }
        }

        public InventoryItem DisplayLastAddedItem()
        {
            InventoryItem item = AddItemHistory.Peek();

            return item;
        }

        public void DisplayRestockItemQueue()
        {
            foreach (InventoryItem item in RestockItems)
            {
                restockItemsDisplay.Add(DisplayItem(item));
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
