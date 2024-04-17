﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10361554_PROG6221_ICE_Task__2
{
    public enum ItemCategory
    {
        Produce,
        Dairy,
        Meat,
        Seafood,
        Bakery,
        Frozen_Foods,
        Canned_Food,
        Beverages,
        Snacks,
        Kitchen_Essentials,
        Condiments,
        Cleaning_Supplies,
        Personal_Care,
        Health_and_Wellness,
        Other
    }

    internal class Categories
    {
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

        public void AddToCategoryList(InventoryItem item)
        {
            GetItemList(item.Category).Add(item);
        }

        public List<InventoryItem> GetItemList(ItemCategory category)
        { 
            List<InventoryItem> items = new List<InventoryItem>();

            switch(category)
            {
                case ItemCategory.Produce:
                    items = Produce;
                    break;

                case ItemCategory.Dairy:
                    items = Dairy;
                    break;

                case ItemCategory.Meat:
                    items = Meat;
                    break;

                case ItemCategory.Seafood:
                    items = Seafood;
                    break;

                case ItemCategory.Bakery:
                    items = Bakery;
                    break;

                case ItemCategory.Frozen_Foods:
                    items = FrozenFoods;
                    break;

                case ItemCategory.Canned_Food:
                    items = CannedFood;
                    break;

                case ItemCategory.Beverages:
                    items = Beverages;
                    break;

                case ItemCategory.Snacks:
                    items = Snacks;
                    break;

                case ItemCategory.Kitchen_Essentials:
                    items = KitchenEssentials;
                    break;

                case ItemCategory.Condiments:
                    items = Condiments;
                    break;

                case ItemCategory.Cleaning_Supplies:
                    items = CleaningSupplies;
                    break;

                case ItemCategory.Personal_Care:
                    items = PersonalCare;
                    break;

                case ItemCategory.Health_and_Wellness:
                    items = HealthAndWellness;
                    break;

                case ItemCategory.Other:
                    items = Other;
                    break;


            }

            return items;
        }
    }
}
