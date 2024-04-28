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
    public partial class DeleteItemForm : Form
    {
        //Holds the instance of the store object passed to the constructor when form is created
        private GroceryStore store;

        // Constructor for the DeleteItemForm class, which takes in a GroceryStore object as a parameter
        public DeleteItemForm(GroceryStore groceryStore)
        {
            // Initialize the components of the form
            InitializeComponent();

            // Assign the groceryStore parameter to the store field of the class
            this.store = groceryStore;
        }


        // Event handler for the DeleteItemButton click event
        private void DeleteItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected index of the ItemCategoryComboBox
                int itemCategoryIndex = ItemCategoryComboBox.SelectedIndex;

                // Cast the selected index to the ItemCategory enumeration
                ItemCategory itemCategory = (ItemCategory)itemCategoryIndex;

                // Get the text from the ItemNameComboBox
                string itemName = ItemNameComboBox.Text;

                // Remove the item from the store's inventory
                store.Inventory.RemoveItem(itemCategory, itemName);

                // Display a success message
                MessageBox.Show("Item Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Display an error message with the exception details
                MessageBox.Show($"Delete item failed: {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Reset the selected index of the ItemCategoryComboBox and ItemNameComboBox
                ItemCategoryComboBox.SelectedIndex = -1;
                ItemNameComboBox.SelectedIndex = -1;
            }
        }

        // Event handler for the CheckCategoryButton click event
        private void CheckCategoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear the ItemNameComboBox items
                ItemNameComboBox.Items.Clear();

                // Get the selected index of the ItemCategoryComboBox
                int itemCategoryIndex = ItemCategoryComboBox.SelectedIndex;

                // Cast the selected index to the ItemCategory enum
                ItemCategory itemCategory = (ItemCategory)itemCategoryIndex;

                // Call the SetItemNameComboBox method with the selected item category
                SetItemNameComboBox(itemCategory);
            }
            catch (Exception ex)
            {
                // Display an error message if the load names fail
                MessageBox.Show($"Load names failed: {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // This method sets the ItemNameComboBox with the names of the items that belong to a specific category
        public void SetItemNameComboBox(ItemCategory category)
        {
            // Initialize a list to store the names of the items
            List<string> itemNames = new List<string>();

            // Initialize a list to store the items that belong to the specified category
            List<InventoryItem> items = new List<InventoryItem>();

            // Iterate through the inventory dictionary to find the items that belong to the specified category
            foreach (KeyValuePair<ItemCategory, List<InventoryItem>> kvp in store.Inventory.inventory)
            {
                if (kvp.Key == category)
                {
                    items = kvp.Value;
                }
            }

            // If there are any items in the list, add their names to the itemNames list
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

            // Add the item names to the ItemNameComboBox
            foreach (string item in itemNames)
            {
                ItemNameComboBox.Items.Add(item);
            }
        }

    }
}
