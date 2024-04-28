using System.Drawing.Text;  

namespace ST10361554_PROG6221_ICE_Task__2
{
    public partial class AddItemForm : Form
    {

        private GroceryStore store;  // Declaring a private variable to hold the grocery store object

        // Constructor for AddItemForm class that initializes the form and sets the grocery store object
        public AddItemForm(GroceryStore groceryStore)
        {
            InitializeComponent();  // Initializing the form components
            this.store = groceryStore;  // Assigning the passed grocery store object to the private variable
            SetNumericUpDownMaxValue();  // Calling a method to set the maximum value for numeric up-down controls
        }

        // Event handler for the AddToInventoryButton Click event
        private void AddToInventoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieving input values from form controls
                string itemName = ItemNameTextbox.Text;
                double itemPrice = Convert.ToDouble(ItemPriceTextbox.Text);
                int itemQuantity = Convert.ToInt32(ItemQuantityNumBox.Value);
                int itemCategoryIndex = ItemCategoryComboBox.SelectedIndex;
                ItemCategory itemCategory = (ItemCategory)itemCategoryIndex;
                int itemMinQuantity = Convert.ToInt32(ItemMinQuantityNumBox.Value);

                // Creating an inventory item using the store's CreateItem method
                InventoryItem item = store.Inventory.CreateItem(itemName, itemPrice, itemQuantity, itemCategory, itemMinQuantity);

                // Adding the created item to the store's inventory
                store.Inventory.AddItem(item);

                // Showing a success message to the user
                MessageBox.Show("Item Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handling any exceptions that may occur during item addition
                MessageBox.Show($"Add item failed: {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Clearing the input fields after adding the item
            ItemNameTextbox.Clear();
            ItemPriceTextbox.Clear();
            ItemQuantityNumBox.Value = 0;
            ItemCategoryComboBox.SelectedIndex = -1;
            ItemMinQuantityNumBox.Value = 0;

        }

        // Method to set the maximum value for numeric up-down controls
        public void SetNumericUpDownMaxValue()
        {
            ItemQuantityNumBox.Maximum = Decimal.MaxValue;
            ItemMinQuantityNumBox.Maximum = Decimal.MaxValue;
        }
    }
}
