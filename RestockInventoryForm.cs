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
    public partial class RestockInventoryForm : Form
    {
        //Holds the instance of the store object passed to the constructor when form is created
        private GroceryStore store;

        // Constructor for the RestockInventoryForm class, which takes in a GroceryStore object as a parameter
        public RestockInventoryForm(GroceryStore groceryStore)
        {
            // Initialize the components of the form
            InitializeComponent();

            // Assign the groceryStore parameter to the store field of the class
            this.store = groceryStore;
        }


        // Click event handler for the CheckInventoryButton
        private void CheckInventoryButton_Click(object sender, EventArgs e)
        {
            // Clear the RestockInventoryRichTextbox
            RestockInventoryRichTextbox.Clear();

            // Call the CheckItemsToRestock method on the Inventory object of the store
            store.Inventory.CheckItemsToRestock();

            // Call the DisplayRestockItemQueue method on the Inventory object of the store
            store.Inventory.DisplayRestockItemQueue();

            // Check if the restockItemsDisplay list in the Inventory object is empty
            if (store.Inventory.restockItemsDisplay.Count == 0)
            {
                // If the list is empty, display a message in the RestockInventoryRichTextbox
                RestockInventoryRichTextbox.Text = "There are currently no items to restock";
            }
            else
            {
                // If the list is not empty, clear the RestockInventoryRichTextbox
                RestockInventoryRichTextbox.Clear();

                // Iterate through the restockItemsDisplay list in the Inventory object
                foreach (string item in store.Inventory.restockItemsDisplay)
                {
                    // Initialize a counter variable i
                    int i = 1;

                    // Append the index and item name to the RestockInventoryRichTextbox
                    RestockInventoryRichTextbox.AppendText($"\n{i}.{item}\n\n");
                }
            }
        }
    }
}
