using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST10361554_PROG6221_ICE_Task__2
{
    public partial class PurchaseItemForm : Form
    {
        //Holds the instance of the store object passed to the constructor when form is created
        private GroceryStore store;

        // Constructor for the PurchaseItemForm class, which takes in a GroceryStore object as a parameter
        public PurchaseItemForm(GroceryStore groceryStore)
        {
            // Initialize the components of the form
            InitializeComponent();

            // Assign the groceryStore parameter to the store field of the class
            this.store = groceryStore;

            // Set the maximum value of the ItemQuantityNumBox to the maximum value of the Decimal data type
            ItemQuantityNumBox.Maximum = Decimal.MaxValue;
        }

        // Event handler for the PurchaseButton click event
        private void PurchaseButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected index of the ItemCategoriesComboBox
                int itemCategoryIndex = ItemCategoriesComboBox.SelectedIndex;

                // Cast the selected index to an ItemCategory object
                ItemCategory itemCategory = (ItemCategory)itemCategoryIndex;

                // Get the text from the ItemNameComboBox
                string itemName = ItemNameComboBox.Text;

                // Get the value from the ItemQuantityNumBox
                int purchaseQuantity = (int)ItemQuantityNumBox.Value;

                // Call the PurchaseItem method on the store's Inventory object
                store.Inventory.PurchaseItem(itemCategory, itemName, purchaseQuantity);

                // Display a success message to the user
                MessageBox.Show("Item Purchased Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Display an error message to the user
                MessageBox.Show($"Add item failed: {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Reset the selected index of the ItemNameComboBox and ItemCategoriesComboBox
                ItemNameComboBox.SelectedIndex = -1;
                ItemCategoriesComboBox.SelectedIndex = -1;

                // Reset the value of the ItemQuantityNumBox
                ItemQuantityNumBox.Value = 0;
            }
        }

        // This method sets the ItemNameComboBox with the names of the InventoryItems
        // that belong to the given ItemCategory.
        public void setItemNameComboBox(ItemCategory category)
        {
            // Initialize a list to store the names of the InventoryItems
            List<string> itemNames = new List<string>();

            // Initialize a list to store the InventoryItems that belong to the given category
            List<InventoryItem> items = new List<InventoryItem>();

            // Iterate through the inventory dictionary to find the InventoryItems that belong to the given category
            foreach (KeyValuePair<ItemCategory, List<InventoryItem>> kvp in store.Inventory.inventory)
            {
                if (kvp.Key == category)
                {
                    items = kvp.Value;
                }
            }

            // If there are any InventoryItems that belong to the given category, add their names to the itemNames list
            if (items.Count > 0)
            {

                foreach (InventoryItem item in items)
                {
                    if (item.ItemName!= null)
                    {
                        itemNames.Add(item.ItemName);
                    }
                }
            }

            // Add the names of the InventoryItems to the ItemNameComboBox
            foreach (string item in itemNames)
            {
                ItemNameComboBox.Items.Add(item);
            }
        }

        // Event handler for the CheckCategoryButton click event
        private void CheckCategoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear the ItemNameComboBox items
                ItemNameComboBox.Items.Clear();

                // Get the selected index of the ItemCategoriesComboBox
                int itemCategoryIndex = ItemCategoriesComboBox.SelectedIndex;

                // Cast the selected index to an ItemCategory object
                ItemCategory itemCategory = (ItemCategory)itemCategoryIndex;

                // Call the setItemNameComboBox method with the selected ItemCategory as a parameter
                setItemNameComboBox(itemCategory);
            }
            catch (Exception ex)
            {
                // Display an error message if the load names fail
                MessageBox.Show($"Load names failed: {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
