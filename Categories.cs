using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10361554_PROG6221_ICE_Task__2
{
    public enum ItemCategory
    {
        // Enumerates various item categories
        Produce, // Represents fresh fruits and vegetables
        Dairy, // Includes milk, cheese, and other dairy products
        Meat, // Contains various types of meat products
        Seafood, // Encompasses fish, shellfish, and other seafood items
        Bakery, // Covers bread, pastries, and other baked goods
        Frozen_Foods, // Comprises frozen meals, vegetables, and desserts
        Canned_Food, // Consists of canned fruits, vegetables, and proteins
        Beverages, // Incorporates various drinks, including soda, juice, and alcohol
        Snacks, // Features chips, crackers, and other snack foods
        Kitchen_Essentials, // Contains items like utensils, cookware, and appliances
        Condiments, // Includes sauces, dressings, and spreads
        Cleaning_Supplies, // Encompasses cleaning products for the home
        Personal_Care, // Comprises hygiene and beauty products
        Health_and_Wellness, // Features vitamins, supplements, and health-related items
        Other // Represents any items that do not fit into the other categories
    }

    internal class Categories
    {
        // Lists of inventory items for Products by category
        public List<InventoryItem> Produce { get; set; } = new List<InventoryItem>();
        public List<InventoryItem> Dairy { get; set; } = new List<InventoryItem>();
        public List<InventoryItem> Meat { get; set; } = new List<InventoryItem>();
        public List<InventoryItem> Seafood { get; set; } = new List<InventoryItem>();
        public List<InventoryItem> Bakery { get; set; } = new List<InventoryItem>();
        public List<InventoryItem> FrozenFoods { get; set; } = new List<InventoryItem>();
        public List<InventoryItem> CannedFood { get; set; } = new List<InventoryItem>();
        public List<InventoryItem> Beverages { get; set; } = new List<InventoryItem>();
        public List<InventoryItem> Snacks { get; set; } = new List<InventoryItem>();
        public List<InventoryItem> KitchenEssentials { get; set; } = new List<InventoryItem>();
        public List<InventoryItem> Condiments { get; set; } = new List<InventoryItem>();
        public List<InventoryItem> CleaningSupplies { get; set; } = new List<InventoryItem>();
        public List<InventoryItem> PersonalCare { get; set; } = new List<InventoryItem>();
        public List<InventoryItem> HealthAndWellness { get; set; } = new List<InventoryItem>();
        public List<InventoryItem> Other { get; set; } = new List<InventoryItem>();


        // This method retrieves a list of inventory items based on the provided category.
        // It uses a switch statement to determine which list of items to return.
        // The lists are predefined and correspond to the different categories of items.
        public List<InventoryItem> GetItemList(ItemCategory category)
        {
            // Initialize a new list of InventoryItem objects
            List<InventoryItem> items = new List<InventoryItem>();

            // Use a switch statement to determine which list of items to return
            switch (category)
            {
                // If the category is Produce, return the Produce list
                case ItemCategory.Produce:
                    items = Produce;
                    break;

                // If the category is Dairy, return the Dairy list
                case ItemCategory.Dairy:
                    items = Dairy;
                    break;

                // If the category is Meat, return the Meat list
                case ItemCategory.Meat:
                    items = Meat;
                    break;

                // If the category is Seafood, return the Seafood list
                case ItemCategory.Seafood:
                    items = Seafood;
                    break;

                // If the category is Bakery, return the Bakery list
                case ItemCategory.Bakery:
                    items = Bakery;
                    break;

                // If the category is Frozen_Foods, return the FrozenFoods list
                case ItemCategory.Frozen_Foods:
                    items = FrozenFoods;
                    break;

                // If the category is Canned_Food, return the CannedFood list
                case ItemCategory.Canned_Food:
                    items = CannedFood;
                    break;

                // If the category is Beverages, return the Beverages list
                case ItemCategory.Beverages:
                    items = Beverages;
                    break;

                // If the category is Snacks, return the Snacks list
                case ItemCategory.Snacks:
                    items = Snacks;
                    break;

                // If the category is Kitchen_Essentials, return the KitchenEssentials list
                case ItemCategory.Kitchen_Essentials:
                    items = KitchenEssentials;
                    break;

                // If the category is Condiments, return the Condiments list
                case ItemCategory.Condiments:
                    items = Condiments;
                    break;

                // If the category is Cleaning_Supplies, return the CleaningSupplies list
                case ItemCategory.Cleaning_Supplies:
                    items = CleaningSupplies;
                    break;

                // If the category is Personal_Care, return the PersonalCare list
                case ItemCategory.Personal_Care:
                    items = PersonalCare;
                    break;

                // If the category is Health_and_Wellness, return the HealthAndWellness list
                case ItemCategory.Health_and_Wellness:
                    items = HealthAndWellness;
                    break;

                // If the category is Other, return the Other list
                case ItemCategory.Other:
                    items = Other;
                    break;
            }

            // Return the list of items
            return items;
        }

        // This method, AddToCategoryList, takes an InventoryItem object as an argument
        // and adds it to the appropriate list based on its Category property.

        public void AddToCategoryList(InventoryItem item)
        {
            // A switch statement is used to determine which list the item should be added to.
            switch (item.Category)
            {
                // If the item's Category is Produce, it is added to the Produce list.
                case ItemCategory.Produce:
                    Produce.Add(item);
                    break;

                // If the item's Category is Dairy, it is added to the Dairy list.
                case ItemCategory.Dairy:
                    Dairy.Add(item);
                    break;

                // If the item's Category is Meat, it is added to the Meat list.
                case ItemCategory.Meat:
                    Meat.Add(item);
                    break;

                // If the item's Category is Seafood, it is added to the Seafood list.
                case ItemCategory.Seafood:
                    Seafood.Add(item);
                    break;

                // If the item's Category is Bakery, it is added to the Bakery list.
                case ItemCategory.Bakery:
                    Bakery.Add(item);
                    break;

                // If the item's Category is Frozen_Foods, it is added to the FrozenFoods list.
                case ItemCategory.Frozen_Foods:
                    FrozenFoods.Add(item);
                    break;

                // If the item's Category is Canned_Food, it is added to the CannedFood list.
                case ItemCategory.Canned_Food:
                    CannedFood.Add(item);
                    break;

                // If the item's Category is Beverages, it is added to the Beverages list.
                case ItemCategory.Beverages:
                    Beverages.Add(item);
                    break;

                // If the item's Category is Snacks, it is added to the Snacks list.
                case ItemCategory.Snacks:
                    Snacks.Add(item);
                    break;

                // If the item's Category is Kitchen_Essentials, it is added to the KitchenEssentials list.
                case ItemCategory.Kitchen_Essentials:
                    KitchenEssentials.Add(item);
                    break;

                // If the item's Category is Condiments, it is added to the Condiments list.
                case ItemCategory.Condiments:
                    Condiments.Add(item);
                    break;

                // If the item's Category is Cleaning_Supplies, it is added to the CleaningSupplies list.
                case ItemCategory.Cleaning_Supplies:
                    CleaningSupplies.Add(item);
                    break;

                // If the item's Category is Personal_Care, it is added to the PersonalCare list.
                case ItemCategory.Personal_Care:
                    PersonalCare.Add(item);
                    break;

                // If the item's Category is Health_and_Wellness, it is added to the HealthAndWellness list.
                case ItemCategory.Health_and_Wellness:
                    HealthAndWellness.Add(item);
                    break;

                // If the item's Category is Other, it is added to the Other list.
                case ItemCategory.Other:
                    Other.Add(item);
                    break;
            }
        }
    }
}
