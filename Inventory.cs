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
        // A dictionary to store the inventory items categorized by their respective categories
        public Dictionary<ItemCategory, List<InventoryItem>> inventory = new Dictionary<ItemCategory, List<InventoryItem>>();

        // A stack to keep track of the history of added items in a Last-In-First-Out (LIFO) manner
        // When an item is added, it is pushed onto the stack
        public Stack<InventoryItem> AddItemHistory = new Stack<InventoryItem>();

        // A queue to keep track of items that need to be restocked in a First-In-First-Out (FIFO) manner
        // When an item's quantity goes below a certain amount, it is added to the queue to be ordered
        public Queue<InventoryItem> RestockItems = new Queue<InventoryItem>();

        // Lists to handle displaying the inventory categories and items
        public List<ItemCategory> categoriesInDictionary = new List<ItemCategory>();
        public List<List<string>> itemLists = new List<List<string>>();

        // A list to handle displaying the queue of items to be restocked
        public List<string> restockItemsDisplay = new List<string>();

        // An instance of the Categories class to manage item categories
        Categories categories = new Categories();

        // An instance of the InputValidator class to validate user inputs
        InputValidator inputValidator = new InputValidator();

        // This method creates a new InventoryItem object with the given parameters
        public InventoryItem CreateItem(string name, double price, int quantity, ItemCategory category, int minQuantity)
        {
            // Initialize a new InventoryItem object
            InventoryItem item = new InventoryItem();

            // Set the ItemName property of the InventoryItem object to the given name
            item.ItemName = name;

            // Set the ItemPrice property of the InventoryItem object to the given price
            item.ItemPrice = price;

            // Set the ItemQuantity property of the InventoryItem object to the given quantity
            item.ItemQuantity = quantity;

            // Set the Category property of the InventoryItem object to the given category
            item.Category = category;

            // Set the MinimumQuantity property of the InventoryItem object to the given minimum quantity
            item.MinimumQuantity = minQuantity;

            // Return the newly created InventoryItem object
            return item;
        }


        // This method, AddItem, takes an InventoryItem object as a parameter
        public void AddItem(InventoryItem item)
        {
            // The inputValidator object's CheckItem method is called to validate the item
            bool isValid = inputValidator.CheckItem(item);

            // If the item is valid, it is added to the inventory
            if (isValid)
            {
                // The item is added to the appropriate category list
                categories.AddToCategoryList(item);

                // The inventory dictionary is updated with the new category list
                inventory[item.Category] = categories.GetItemList(item.Category);

                // The item is added to the item history stack
                AddItemHistory.Push(item);
            }
            else
            {
                // If the item is not valid, an exception is thrown
                throw new Exception(message: "Add Item Failed");
            }
        }

        // This method removes an item from the inventory based on the provided category and item name
        public void RemoveItem(ItemCategory category, string itemName)
        {
            // Get the list of items from the inventory dictionary using the given category
            List<InventoryItem> items = inventory[category];

            // Initialize the index to remove with a default value of -1
            int indexToRemove = -1;

            // Validate the list of items using the input validator
            bool isValid = inputValidator.ValidateList(items);

            // If the list is valid, proceed with finding the item to remove
            if (isValid)
            {
                // Iterate through the list of items
                foreach (InventoryItem inventoryItem in items)
                {
                    // If the current item's name matches the provided item name, set the index to remove
                    if (inventoryItem.ItemName == itemName)
                    {
                        indexToRemove = items.IndexOf(inventoryItem);
                        break;
                    }
                }

                // If the index to remove is valid, remove the item from the list
                if (indexToRemove!= -1)
                {
                    items.RemoveAt(indexToRemove);
                }
                else
                {
                    // If the index is not valid, throw an exception
                    throw new Exception(message: "Index not valid");
                }

                // Update the inventory dictionary with the modified list of items
                inventory[category] = items;
            }
            else
            {
                // If the list is null, throw an exception
                throw new Exception(message: "List is null, could not remove item");
            }
        }

        // This method, DisplayItem, takes an InventoryItem object as an argument
        public string DisplayItem(InventoryItem item)
        {
            // Initialize a string variable called itemToString
            string itemToString;

            // Assign a formatted string to itemToString, which includes the item's name, price, quantity, and category
            itemToString = $"\nItem Name: {item.ItemName}" +
                           $"\nItem Price: {item.ItemPrice}" +
                           $"\nItem Quantity: {item.ItemQuantity}" +
                           $"\nItem Category: {item.Category}";

            // Return the formatted string
            return itemToString;
        }

        // This method displays the inventory by clearing any existing categories and item lists,
        // then iterating through the inventory dictionary. If a category has items, it is added
        // to the categoriesInDictionary list and its items are displayed and added to the itemLists list.
        public void DisplayInventory()
        {
            // Clear the categoriesInDictionary and itemLists to start fresh
            categoriesInDictionary.Clear();
            itemLists.Clear();

            // Iterate through the inventory dictionary
            foreach (KeyValuePair<ItemCategory, List<InventoryItem>> kvp in inventory)
            {
                // If the category has items, add it to the categoriesInDictionary list
                if (kvp.Value.Count > 0)
                {
                    categoriesInDictionary.Add(kvp.Key);

                    // Create a new list to store the displayed items
                    List<string> items = new List<string>();

                    // Iterate through the items in the category
                    foreach (InventoryItem item in kvp.Value)
                    {
                        // Display the item and add it to the items list
                        items.Add(DisplayItem(item));
                    }

                    // Add the items list to the itemLists list
                    itemLists.Add(items);
                }
            }
        }

        // This method, DisplayLastAddedItem, retrieves and returns the most recently added item from the AddItemHistory stack.
        // It does not remove the item from the stack.
        public string DisplayLastAddedItem()
        {
            // Peek() is used to get the topmost item from the AddItemHistory stack without removing it.
            InventoryItem item = AddItemHistory.Peek();

            // Initialize a flag, isItemDeleted, to check if the item has been deleted from the inventory.
            bool isItemDeleted = true;

            // Initialize a string, displayItem, to store the displayable information of the item.
            string displayItem;

            // Get the list of items in the same category as the item from the inventory dictionary.
            List<InventoryItem> itemsInDictionaryCategory = inventory[item.Category];

            // Iterate through the items in the same category to check if the item still exists in the inventory.
            foreach (InventoryItem inventoryItem in itemsInDictionaryCategory)
            {
                if (inventoryItem.ItemName == item.ItemName)
                {
                    // If the item is found, set the flag to false, indicating that the item is not deleted.
                    isItemDeleted = false;
                    break;
                }
            }

            // If the item is deleted, display the item information along with a message indicating that the item was deleted.
            if (isItemDeleted)
            {
                displayItem = DisplayItem(item) + "\n--This item was deleted from inventory--";
            }
            // If the item is not deleted, display the item information without any additional message.
            else
            {
                displayItem = DisplayItem(item);
            }

            // Return the displayable information of the item.
            return displayItem;
        }

        // This method displays the queue of items that need to be restocked
        public void DisplayRestockItemQueue()
        {
            // Clear the list to get new set of items
            restockItemsDisplay.Clear();

            // Iterate through each item in the RestockItems inventory
            foreach (InventoryItem item in RestockItems)
            {
                // Add the displayed item to the restockItemsDisplay list
                restockItemsDisplay.Add(DisplayItem(item));
            }
        }

        // This method, PurchaseItem, takes in three parameters: ItemCategory category, string itemName, and int purchaseQuantity

        public void PurchaseItem(ItemCategory category, string itemName, int purchaseQuantity)
        {
            // Initialize a list of InventoryItem objects called items, and assign it the value of the inventory dictionary's category key
            List<InventoryItem> items = inventory[category];

            // Loop through each InventoryItem object in the items list
            foreach (InventoryItem item in items)
            {
                // If the current InventoryItem's ItemName matches the itemName parameter and the purchaseQuantity is less than or equal to the ItemQuantity
                if (item.ItemName == itemName && purchaseQuantity <= item.ItemQuantity)
                {
                    // Subtract the purchaseQuantity from the ItemQuantity of the current InventoryItem
                    item.ItemQuantity -= purchaseQuantity;

                    // Exit the loop
                    break;
                }
                // Otherwise, if the purchaseQuantity exceeds the quantity in inventory, throw a new Exception with a message
                else throw new Exception(message: "Purchase quantity exceeds quantity in inventory");
            }

            // Update the inventory dictionary's category key with the modified items list
            inventory[category] = items;
        }

        // This method checks the inventory items to determine if any need to be restocked
        public void CheckItemsToRestock()
        {
            // Clear all items in queue before checking again
            RestockItems.Clear();

            // Iterate through the inventory, which is a dictionary of ItemCategory and a list of InventoryItem
            foreach (KeyValuePair<ItemCategory, List<InventoryItem>> kvp in inventory)
            {
                // Get the list of InventoryItem for the current ItemCategory
                List<InventoryItem> items = kvp.Value;

                // Iterate through the list of InventoryItem
                foreach (InventoryItem item in items)
                {
                    // Check if the quantity of the current InventoryItem is less than or equal to its minimum quantity
                    if (item.ItemQuantity <= item.MinimumQuantity)
                    {
                        // If so, add the InventoryItem to the RestockItems queue
                        RestockItems.Enqueue(item);
                    }
                }

            }
        }

    }
}
