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
        private GroceryStore store;

        public DeleteItemForm(GroceryStore groceryStore)
        {
            InitializeComponent();
            this.store = groceryStore;
            ItemNameComboBox.Items.Add(setItemNameComboBox());
        }

        
        private void DeleteItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                int itemCategoryIndex = ItemCategoryComboBox.SelectedIndex;
                ItemCategory itemCategory = (ItemCategory)itemCategoryIndex;

                string itemName = ItemNameComboBox.Text;

                store.Inventory.RemoveItem(itemCategory, itemName);

                MessageBox.Show("Item Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Delete item failed: {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
