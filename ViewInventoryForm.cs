using System;
using System.Collections;
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
    public partial class ViewInventoryForm : Form
    {
        //Holds the instance of the store object passed to the constructor when form is created
        private GroceryStore store;

        // Constructor for the ViewInventoryForm class, which takes in a GroceryStore object as a parameter
        public ViewInventoryForm(GroceryStore groceryStore)
        {
            // Initialize the components of the form
            InitializeComponent();

            // Assign the groceryStore parameter to the store field of the class
            this.store = groceryStore;
        }

        // This method is triggered when the RefreshInventoryDisplayButton is clicked
        private void RefreshInventoryDisplayButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the inventory is empty
                if (store.Inventory.inventory.Keys.Count == 0 && store.Inventory.inventory.Values.Count == 0)
                {
                    // Display a message indicating that there are no items in the inventory
                    ViewInventoryRichTextbox.Text = "No items are currently stored in inventory";
                }
                else
                {
                    // Clear the ViewInventoryRichTextbox
                    ViewInventoryRichTextbox.Clear();

                    // Call the DisplayInventory method of the store's Inventory object
                    store.Inventory.DisplayInventory();

                    // Create a new Dictionary to store the inventory items categorized by their category
                    Dictionary<ItemCategory, List<string>> items = new Dictionary<ItemCategory, List<string>>();

                    // Loop through the categories in the store's Inventory object
                    for (int i = 0; i < store.Inventory.categoriesInDictionary.Count; i++)
                    {
                        // Add a new KeyValuePair to the items Dictionary, with the category as the key and the corresponding item list as the value
                        items.Add(store.Inventory.categoriesInDictionary[i], store.Inventory.itemLists[i]);
                    }

                    // Loop through the KeyValuePair objects in the items Dictionary
                    foreach (KeyValuePair<ItemCategory, List<string>> kvp in items)
                    {
                        // Set the font of the next text to be added to the ViewInventoryRichTextbox to bold
                        ViewInventoryRichTextbox.SelectionFont = new Font(ViewInventoryRichTextbox.Font, FontStyle.Bold);

                        // Add the category name to the ViewInventoryRichTextbox
                        ViewInventoryRichTextbox.AppendText($"Category: {kvp.Key}\n");

                        // Set the font of the next text to be added to the ViewInventoryRichTextbox to regular
                        ViewInventoryRichTextbox.SelectionFont = new Font(ViewInventoryRichTextbox.Font, FontStyle.Regular);

                        // Initialize a counter variable to keep track of the item number
                        int i = 1;

                        // Loop through the items in the current category
                        foreach (string item in kvp.Value)
                        {
                            // Add the item number and name to the ViewInventoryRichTextbox
                            ViewInventoryRichTextbox.AppendText($"\n{i}.{item}\n\n");

                            // Increment the item counter
                            i++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Display an error message if an exception is thrown
                MessageBox.Show($"{ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for the RefreshItemHistoryButton click event
        private void RefreshItemHistoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the inventory is empty
                if (store.Inventory.AddItemHistory.Count == 0)
                {
                    // Display a message indicating no items are in inventory
                    ItemHistoryRichTextbox.Text = "No items are currently stored in inventory";
                }
                else
                {
                    // Clear the ItemHistoryRichTextbox
                    ItemHistoryRichTextbox.Clear();

                    // Retrieve and display the last added item in the inventory
                    string lastAddedItem = store.Inventory.DisplayLastAddedItem();
                    ItemHistoryRichTextbox.Text = lastAddedItem;
                }
            }
            catch (Exception ex)
            {
                // Display an error message with the exception details
                MessageBox.Show($"{ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
