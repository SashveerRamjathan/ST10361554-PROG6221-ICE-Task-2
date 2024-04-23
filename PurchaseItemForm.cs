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
        private GroceryStore store;

        public PurchaseItemForm(GroceryStore groceryStore)
        {
            InitializeComponent();
            this.store = groceryStore;
            ItemNameComboBox.Items.Add(setItemNameComboBox());
            ItemQuantityNumBox.Maximum = Decimal.MaxValue;
        }

        private void PurchaseButton_Click(object sender, EventArgs e)
        {
            try
            {
                int itemCategoryIndex = ItemCategoriesComboBox.SelectedIndex;
                ItemCategory itemCategory = (ItemCategory)itemCategoryIndex;

                string itemName = ItemNameComboBox.Text;

                int purchaseQuantity = (int)ItemQuantityNumBox.Value;

                store.Inventory.PurchaseItem(itemCategory, itemName, purchaseQuantity);

                MessageBox.Show("Item Purchased Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Add item failed: {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<string> setItemNameComboBox()
        {
            List<string> itemNames = new List<string>();

            foreach (var item in store.Inventory.inventory)
            {
                foreach (var list in item.Value)
                {
                    itemNames.Add(list.ItemName);
                }
            }

            return itemNames;
        }

    }
}
