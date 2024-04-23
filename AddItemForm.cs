using System.Drawing.Text;

namespace ST10361554_PROG6221_ICE_Task__2
{
    public partial class AddItemForm : Form
    {

        private GroceryStore store;

        public AddItemForm(GroceryStore groceryStore)
        {
            InitializeComponent();
            this.store = groceryStore;
            SetNumericUpDownMaxValue();
        }

        private void AddToInventoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                string itemName = ItemNameTextbox.Text;
                double itemPrice = Convert.ToDouble(ItemPriceTextbox.Text);
                int itemQuantity = Convert.ToInt32(ItemQuantityNumBox.Value);
                int itemCategoryIndex = ItemCategoryComboBox.SelectedIndex;
                ItemCategory itemCategory = (ItemCategory)itemCategoryIndex;
                int itemMinQuantity = Convert.ToInt32(ItemMinQuantityNumBox.Value);

                InventoryItem item = store.Inventory.CreateItem(itemName, itemPrice, itemQuantity, itemCategory, itemMinQuantity);

                store.Inventory.AddItem(item);

                MessageBox.Show("Item Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                //code attribution
                MessageBox.Show($"Add item failed: {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ItemNameTextbox.Clear();
            ItemPriceTextbox.Clear();
            ItemQuantityNumBox.Value = 0;
            ItemCategoryComboBox.SelectedIndex = -1;
            ItemMinQuantityNumBox.Value = 0;

        }

        public void SetNumericUpDownMaxValue()
        {
            ItemQuantityNumBox.Maximum = Decimal.MaxValue;
            ItemMinQuantityNumBox.Maximum = Decimal.MaxValue;
        }
    }
}
