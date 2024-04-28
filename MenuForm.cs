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
    public partial class MenuForm : Form
    {
        // Initialize a new instance of the GroceryStore class
        public GroceryStore store = new GroceryStore();

        // Initialize components for the MenuForm
        public MenuForm()
        {
            // Call the InitializeComponent method to set up the form
            InitializeComponent();
        }

        // This code handles the Click event for the AddItemMenuButton.
        private void AddItemMenuButton_Click(object sender, EventArgs e)
        {
            // Create a new instance of the AddItemForm, passing in the store object.
            AddItemForm form = new AddItemForm(store);

            // Display the form.
            form.Show();
        }

        // This code handles the Click event for the DeleteItemMenuButton.
        private void DeleteItemMenuButton_Click(object sender, EventArgs e)
        {
            // Create a new instance of the DeleteItemForm, passing in the store object.
            DeleteItemForm form = new DeleteItemForm(store);

            // Display the form.
            form.Show();
        }

        // This code handles the Click event for the ViewInventoryMenuButton.
        private void ViewInventoryMenuButton_Click(object sender, EventArgs e)
        {
            // Create a new instance of the ViewInventoryForm, passing in the store object.
            ViewInventoryForm form = new ViewInventoryForm(store);

            // Display the form.
            form.Show();
        }

        // This code handles the Click event for the PurchaseItemMenuButton.
        private void PurchaseItemMenuButton_Click(object sender, EventArgs e)
        {
            // Create a new instance of the PurchaseItemForm, passing in the store object.
            PurchaseItemForm form = new PurchaseItemForm(store);

            // Display the form.
            form.Show();
        }

        // This code handles the Click event for the RestockItemMenuButton.
        private void RestockItemMenuButton_Click(object sender, EventArgs e)
        {
            // Create a new instance of the RestockItemForm, passing in the store object.
            RestockInventoryForm form = new RestockInventoryForm(store);

            // Display the form.
            form.Show();
        }

    }
}
